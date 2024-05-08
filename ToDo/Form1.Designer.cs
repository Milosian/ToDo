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
            this.zadanietb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajbtn = new System.Windows.Forms.Button();
            this.edytujbtn = new System.Windows.Forms.Button();
            this.priorytetbtn = new System.Windows.Forms.Button();
            this.usunbtn = new System.Windows.Forms.Button();
            this.zadaniaTable = new System.Windows.Forms.DataGridView();
            this.terminDate = new System.Windows.Forms.DateTimePicker();
            this.priorytetSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zadaniaTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // zadanietb
            // 
            this.zadanietb.Location = new System.Drawing.Point(12, 54);
            this.zadanietb.Multiline = true;
            this.zadanietb.Name = "zadanietb";
            this.zadanietb.Size = new System.Drawing.Size(263, 59);
            this.zadanietb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Treść zadania:";
            // 
            // dodajbtn
            // 
            this.dodajbtn.Location = new System.Drawing.Point(281, 54);
            this.dodajbtn.Name = "dodajbtn";
            this.dodajbtn.Size = new System.Drawing.Size(82, 59);
            this.dodajbtn.TabIndex = 2;
            this.dodajbtn.Text = "Dodaj";
            this.dodajbtn.UseVisualStyleBackColor = true;
            this.dodajbtn.Click += new System.EventHandler(this.dodajbtn_Click);
            // 
            // edytujbtn
            // 
            this.edytujbtn.Location = new System.Drawing.Point(288, 194);
            this.edytujbtn.Name = "edytujbtn";
            this.edytujbtn.Size = new System.Drawing.Size(75, 23);
            this.edytujbtn.TabIndex = 4;
            this.edytujbtn.Text = "Edytuj";
            this.edytujbtn.UseVisualStyleBackColor = true;
            this.edytujbtn.Click += new System.EventHandler(this.edytujbtn_Click);
            // 
            // priorytetbtn
            // 
            this.priorytetbtn.Location = new System.Drawing.Point(288, 223);
            this.priorytetbtn.Name = "priorytetbtn";
            this.priorytetbtn.Size = new System.Drawing.Size(75, 23);
            this.priorytetbtn.TabIndex = 5;
            this.priorytetbtn.Text = "Priorytet";
            this.priorytetbtn.UseVisualStyleBackColor = true;
            this.priorytetbtn.Click += new System.EventHandler(this.priorytetbtn_Click);
            // 
            // usunbtn
            // 
            this.usunbtn.Location = new System.Drawing.Point(288, 252);
            this.usunbtn.Name = "usunbtn";
            this.usunbtn.Size = new System.Drawing.Size(75, 23);
            this.usunbtn.TabIndex = 6;
            this.usunbtn.Text = "Usuń";
            this.usunbtn.UseVisualStyleBackColor = true;
            this.usunbtn.Click += new System.EventHandler(this.usunbtn_Click);
            // 
            // zadaniaTable
            // 
            this.zadaniaTable.AutoGenerateColumns = false;
            this.zadaniaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zadaniaTable.DataSource = this.bindingSource1;
            this.zadaniaTable.Location = new System.Drawing.Point(12, 194);
            this.zadaniaTable.Name = "zadaniaTable";
            this.zadaniaTable.Size = new System.Drawing.Size(265, 294);
            this.zadaniaTable.TabIndex = 7;
            // 
            // terminDate
            // 
            this.terminDate.Location = new System.Drawing.Point(12, 139);
            this.terminDate.Name = "terminDate";
            this.terminDate.Size = new System.Drawing.Size(176, 20);
            this.terminDate.TabIndex = 8;
            // 
            // priorytetSelect
            // 
            this.priorytetSelect.FormattingEnabled = true;
            this.priorytetSelect.Items.AddRange(new object[] {
            "niski",
            "średni",
            "wysoki",
            "najwyższy"});
            this.priorytetSelect.Location = new System.Drawing.Point(194, 138);
            this.priorytetSelect.Name = "priorytetSelect";
            this.priorytetSelect.Size = new System.Drawing.Size(82, 21);
            this.priorytetSelect.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Termin wykonania:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Priorytet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priorytetSelect);
            this.Controls.Add(this.terminDate);
            this.Controls.Add(this.zadaniaTable);
            this.Controls.Add(this.usunbtn);
            this.Controls.Add(this.priorytetbtn);
            this.Controls.Add(this.edytujbtn);
            this.Controls.Add(this.dodajbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zadanietb);
            this.Name = "Form1";
            this.Text = "ToDo";
            ((System.ComponentModel.ISupportInitialize)(this.zadaniaTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zadanietb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajbtn;
        private System.Windows.Forms.Button edytujbtn;
        private System.Windows.Forms.Button priorytetbtn;
        private System.Windows.Forms.Button usunbtn;
        private System.Windows.Forms.DataGridView zadaniaTable;
        private System.Windows.Forms.DateTimePicker terminDate;
        private System.Windows.Forms.ComboBox priorytetSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

