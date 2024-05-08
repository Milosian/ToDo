using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
namespace ToDo
{
    public partial class Form1 : Form
    {
        public static SQLiteConnection conn;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        public static void InitializeDatabase()
        {
            string dbPath = @"F:\repos\ToDo\ToDo\data\listaZadan.db";
            conn = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            conn.Open();

            using (var cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS zadania(Id INTEGER PRIMARY KEY, tresc TEXT NOT NULL, termin DATE NOT NULL, status TEXT NOT NULL)", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void dodajbtn_Click(object sender, EventArgs e)
        {
            string trescZadania = zadanietb.Text;
            string terminWykonania = terminDate.Value.ToString("MM/dd/yyyy");
            string priorytet = priorytetSelect.Text;

            using (var cmd = new SQLiteCommand("INSERT INTO zadania(tresc, termin, status) VALUES(@trescZadania, @terminWykonania, @priorytet);", conn))
            {
                cmd.Parameters.AddWithValue("@trescZadania", trescZadania);
                cmd.Parameters.AddWithValue("@terminWykonania", terminWykonania);
                cmd.Parameters.AddWithValue("@priorytet", priorytet);
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Values inserted successfully into the database!");
                }
                else
                {
                    MessageBox.Show("Failed to insert values into the database.");
                }
            }
        }

        private void edytujbtn_Click(object sender, EventArgs e)
        {

        }

        private void priorytetbtn_Click(object sender, EventArgs e)
        {

        }

        private void usunbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
