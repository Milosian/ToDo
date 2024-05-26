namespace ToDo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zadanietb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajbtn = new System.Windows.Forms.Button();
            this.edytujbtn = new System.Windows.Forms.Button();
            this.usunbtn = new System.Windows.Forms.Button();
            this.zadaniaTable = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.terminDate = new System.Windows.Forms.DateTimePicker();
            this.priorytetSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.idNum = new System.Windows.Forms.NumericUpDown();
            this.idLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idEdit = new System.Windows.Forms.NumericUpDown();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zadaniaTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // zadanietb
            // 
            this.zadanietb.Location = new System.Drawing.Point(12, 37);
            this.zadanietb.Multiline = true;
            this.zadanietb.Name = "zadanietb";
            this.zadanietb.Size = new System.Drawing.Size(349, 59);
            this.zadanietb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jost", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Treść zadania:";
            // 
            // dodajbtn
            // 
            this.dodajbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(192)))), ((int)(((byte)(90)))));
            this.dodajbtn.FlatAppearance.BorderSize = 0;
            this.dodajbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajbtn.Font = new System.Drawing.Font("Jost", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajbtn.ForeColor = System.Drawing.Color.White;
            this.dodajbtn.Location = new System.Drawing.Point(367, 37);
            this.dodajbtn.Name = "dodajbtn";
            this.dodajbtn.Size = new System.Drawing.Size(69, 59);
            this.dodajbtn.TabIndex = 2;
            this.dodajbtn.Text = "Dodaj";
            this.dodajbtn.UseVisualStyleBackColor = false;
            this.dodajbtn.Click += new System.EventHandler(this.dodajbtn_Click);
            // 
            // edytujbtn
            // 
            this.edytujbtn.Font = new System.Drawing.Font("Jost", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujbtn.Location = new System.Drawing.Point(194, 478);
            this.edytujbtn.Name = "edytujbtn";
            this.edytujbtn.Size = new System.Drawing.Size(82, 23);
            this.edytujbtn.TabIndex = 4;
            this.edytujbtn.Text = "Edytuj";
            this.edytujbtn.UseVisualStyleBackColor = true;
            this.edytujbtn.Click += new System.EventHandler(this.edytujbtn_Click);
            // 
            // usunbtn
            // 
            this.usunbtn.Font = new System.Drawing.Font("Jost", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunbtn.Location = new System.Drawing.Point(12, 477);
            this.usunbtn.Name = "usunbtn";
            this.usunbtn.Size = new System.Drawing.Size(75, 23);
            this.usunbtn.TabIndex = 6;
            this.usunbtn.Text = "Usuń";
            this.usunbtn.UseVisualStyleBackColor = true;
            this.usunbtn.Click += new System.EventHandler(this.usunbtn_Click);
            // 
            // zadaniaTable
            // 
            this.zadaniaTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zadaniaTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.zadaniaTable.BackgroundColor = System.Drawing.Color.White;
            this.zadaniaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zadaniaTable.Location = new System.Drawing.Point(12, 160);
            this.zadaniaTable.Name = "zadaniaTable";
            this.zadaniaTable.Size = new System.Drawing.Size(421, 309);
            this.zadaniaTable.TabIndex = 7;
            // 
            // terminDate
            // 
            this.terminDate.Font = new System.Drawing.Font("Jost", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.terminDate.Location = new System.Drawing.Point(12, 121);
            this.terminDate.Name = "terminDate";
            this.terminDate.Size = new System.Drawing.Size(248, 23);
            this.terminDate.TabIndex = 8;
            // 
            // priorytetSelect
            // 
            this.priorytetSelect.Font = new System.Drawing.Font("Jost", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priorytetSelect.FormattingEnabled = true;
            this.priorytetSelect.Items.AddRange(new object[] {
            "niski",
            "średni",
            "wysoki",
            "najwyższy"});
            this.priorytetSelect.Location = new System.Drawing.Point(266, 121);
            this.priorytetSelect.Name = "priorytetSelect";
            this.priorytetSelect.Size = new System.Drawing.Size(94, 25);
            this.priorytetSelect.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jost", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Termin wykonania:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jost", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(262, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Priorytet:";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Jost", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshBtn.Location = new System.Drawing.Point(367, 478);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(66, 23);
            this.refreshBtn.TabIndex = 12;
            this.refreshBtn.Text = "Odśwież";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // idNum
            // 
            this.idNum.Location = new System.Drawing.Point(109, 480);
            this.idNum.Name = "idNum";
            this.idNum.Size = new System.Drawing.Size(61, 20);
            this.idNum.TabIndex = 13;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(88, 483);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(21, 13);
            this.idLbl.TabIndex = 14;
            this.idLbl.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID:";
            // 
            // idEdit
            // 
            this.idEdit.Location = new System.Drawing.Point(298, 480);
            this.idEdit.Name = "idEdit";
            this.idEdit.Size = new System.Drawing.Size(61, 20);
            this.idEdit.TabIndex = 15;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Jost", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateBtn.Location = new System.Drawing.Point(367, 120);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(66, 26);
            this.updateBtn.TabIndex = 17;
            this.updateBtn.Text = "Aktualizuj";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 510);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idEdit);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.idNum);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priorytetSelect);
            this.Controls.Add(this.terminDate);
            this.Controls.Add(this.zadaniaTable);
            this.Controls.Add(this.usunbtn);
            this.Controls.Add(this.edytujbtn);
            this.Controls.Add(this.dodajbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zadanietb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ToDo";
            ((System.ComponentModel.ISupportInitialize)(this.zadaniaTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zadanietb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajbtn;
        private System.Windows.Forms.Button edytujbtn;
        private System.Windows.Forms.Button usunbtn;
        private System.Windows.Forms.DataGridView zadaniaTable;
        private System.Windows.Forms.DateTimePicker terminDate;
        private System.Windows.Forms.ComboBox priorytetSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.NumericUpDown idNum;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown idEdit;
        private System.Windows.Forms.Button updateBtn;
    }
}

