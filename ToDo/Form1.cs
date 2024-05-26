using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
//using static System.Net.Mime.MediaTypeNames;
namespace ToDo
{
    public partial class Form1 : Form
    {
        
        private SQLiteConnection conn;
        private string filePath = @"F:\repos\ToDo\ToDo\data\lista.db";
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            PokazZadania();
        }
        public void InitializeDatabase()
        {
            conn = new SQLiteConnection($"Data Source={filePath};Version=3;");
            conn.Open();
            
            using (var cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS zadania(Id INTEGER PRIMARY KEY, tresc TEXT NOT NULL, termin DATE NOT NULL, priorytet TEXT NOT NULL)", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        private void PokazZadania()
        {
            string sqlCmdShow = "SELECT * from zadania;";
            using (SQLiteCommand cmd = new SQLiteCommand(sqlCmdShow, conn))
            {
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                zadaniaTable.DataSource = table;
            }
        }
        private void RefreshList()
        {
            InitializeDatabase();
            PokazZadania();
        }

        private void dodajbtn_Click(object sender, EventArgs e)
        {
            string trescZadania = zadanietb.Text;
            DateTime termin = terminDate.Value;
            string formattedDate = termin.ToString("yyyy-MM-dd");
            string priorytet = priorytetSelect.Text;

            using (var cmd = new SQLiteCommand("INSERT INTO zadania(tresc, termin, priorytet) VALUES(@trescZadania, @terminWykonania, @priorytet);", conn))
            {
                cmd.Parameters.AddWithValue("@trescZadania", trescZadania);
                cmd.Parameters.AddWithValue("@terminWykonania", formattedDate);
                cmd.Parameters.AddWithValue("@priorytet", priorytet);
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Zadanie zostało dodane pomyślnie!");
                }
                else
                {
                    MessageBox.Show("BŁĄD! Nie udało się dodać zadania");
                }
            }
            RefreshList();
        }
        private void usunbtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show("Czy na pewno chcesz usunąć zadanie?", "Powierdzenie usunięcia", buttons);
            if(result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(idNum.Value);
                string queryDelete = "DELETE FROM zadania WHERE id = @id;";
                using (var cmd = new SQLiteCommand(queryDelete, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            RefreshList();
        }
        int id;
        string tresc;
        string priorytet;
        string formattedDate;
        public void edytujbtn_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(idEdit.Value);
            string query = "SELECT tresc, termin, priorytet FROM zadania WHERE id = @id";
            using(var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("id", id);
                
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tresc = reader["tresc"].ToString();
                    DateTime termin = Convert.ToDateTime(reader["termin"]);
                    priorytet = reader["priorytet"].ToString();

                    zadanietb.Text = tresc;
                    terminDate.Value = termin;
                    priorytetSelect.SelectedItem = priorytet;
                }
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            formattedDate = terminDate.Value.ToString("yyyy-MM-dd");
            tresc = zadanietb.Text;
            priorytet = priorytetSelect.SelectedItem.ToString();
            string query = "UPDATE zadania SET tresc = @tresc, termin = @termin, priorytet = @priorytet WHERE id = @id";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tresc", tresc);
                cmd.Parameters.AddWithValue("@termin", formattedDate);
                cmd.Parameters.AddWithValue("@priorytet", priorytet);
                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
            };

            RefreshList();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}