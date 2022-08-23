namespace DB_Bahn_Register
{
    partial class FormFuhrpark
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
            this.textBoxFahrzeugBezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxWerkstatt = new System.Windows.Forms.TextBox();
            this.textBoxRufname = new System.Windows.Forms.TextBox();
            this.textBoxFahrzeugAlter = new System.Windows.Forms.TextBox();
            this.textBoxAnzahlFahrzeug = new System.Windows.Forms.TextBox();
            this.buttonFahrzeugHinzufuegen = new System.Windows.Forms.Button();
            this.buttonFahrzeugLoeschen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxFuhrpark = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxStrecke = new System.Windows.Forms.ListBox();
            this.buttonFahrzeugZuweisen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonWechselDich4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFahrzeugBezeichnung
            // 
            this.textBoxFahrzeugBezeichnung.Location = new System.Drawing.Point(52, 34);
            this.textBoxFahrzeugBezeichnung.Name = "textBoxFahrzeugBezeichnung";
            this.textBoxFahrzeugBezeichnung.Size = new System.Drawing.Size(152, 20);
            this.textBoxFahrzeugBezeichnung.TabIndex = 0;
            // 
            // textBoxWerkstatt
            // 
            this.textBoxWerkstatt.Location = new System.Drawing.Point(52, 89);
            this.textBoxWerkstatt.Name = "textBoxWerkstatt";
            this.textBoxWerkstatt.Size = new System.Drawing.Size(152, 20);
            this.textBoxWerkstatt.TabIndex = 1;
            // 
            // textBoxRufname
            // 
            this.textBoxRufname.Location = new System.Drawing.Point(52, 145);
            this.textBoxRufname.Name = "textBoxRufname";
            this.textBoxRufname.Size = new System.Drawing.Size(152, 20);
            this.textBoxRufname.TabIndex = 2;
            // 
            // textBoxFahrzeugAlter
            // 
            this.textBoxFahrzeugAlter.Location = new System.Drawing.Point(52, 202);
            this.textBoxFahrzeugAlter.Name = "textBoxFahrzeugAlter";
            this.textBoxFahrzeugAlter.Size = new System.Drawing.Size(152, 20);
            this.textBoxFahrzeugAlter.TabIndex = 3;
            // 
            // textBoxAnzahlFahrzeug
            // 
            this.textBoxAnzahlFahrzeug.Location = new System.Drawing.Point(52, 260);
            this.textBoxAnzahlFahrzeug.Name = "textBoxAnzahlFahrzeug";
            this.textBoxAnzahlFahrzeug.Size = new System.Drawing.Size(152, 20);
            this.textBoxAnzahlFahrzeug.TabIndex = 4;
            // 
            // buttonFahrzeugHinzufuegen
            // 
            this.buttonFahrzeugHinzufuegen.Location = new System.Drawing.Point(52, 298);
            this.buttonFahrzeugHinzufuegen.Name = "buttonFahrzeugHinzufuegen";
            this.buttonFahrzeugHinzufuegen.Size = new System.Drawing.Size(150, 49);
            this.buttonFahrzeugHinzufuegen.TabIndex = 5;
            this.buttonFahrzeugHinzufuegen.Text = "Hinzufügen";
            this.buttonFahrzeugHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonFahrzeugHinzufuegen.Click += new System.EventHandler(this.buttonFahrzeugHinzufuegen_Click);
            // 
            // buttonFahrzeugLoeschen
            // 
            this.buttonFahrzeugLoeschen.Location = new System.Drawing.Point(52, 363);
            this.buttonFahrzeugLoeschen.Name = "buttonFahrzeugLoeschen";
            this.buttonFahrzeugLoeschen.Size = new System.Drawing.Size(150, 46);
            this.buttonFahrzeugLoeschen.TabIndex = 6;
            this.buttonFahrzeugLoeschen.Text = "Löschen";
            this.buttonFahrzeugLoeschen.UseVisualStyleBackColor = true;
            this.buttonFahrzeugLoeschen.Click += new System.EventHandler(this.buttonFahrzeugLoeschen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Einzugebende Fahrzeugbezeichnung:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Einzugebende Werkstatt/Betriebswerk:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Einzugebender interner Rufname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Einzugebendes Fahrzeugalter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Einzugebende Anzahl des Fahrzeugs:";
            // 
            // listBoxFuhrpark
            // 
            this.listBoxFuhrpark.FormattingEnabled = true;
            this.listBoxFuhrpark.Location = new System.Drawing.Point(292, 34);
            this.listBoxFuhrpark.Name = "listBoxFuhrpark";
            this.listBoxFuhrpark.Size = new System.Drawing.Size(297, 316);
            this.listBoxFuhrpark.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fuhrpark-Übersicht:";
            // 
            // listBoxStrecke
            // 
            this.listBoxStrecke.FormattingEnabled = true;
            this.listBoxStrecke.Location = new System.Drawing.Point(595, 34);
            this.listBoxStrecke.Name = "listBoxStrecke";
            this.listBoxStrecke.Size = new System.Drawing.Size(352, 316);
            this.listBoxStrecke.TabIndex = 14;
            // 
            // buttonFahrzeugZuweisen
            // 
            this.buttonFahrzeugZuweisen.Location = new System.Drawing.Point(500, 372);
            this.buttonFahrzeugZuweisen.Name = "buttonFahrzeugZuweisen";
            this.buttonFahrzeugZuweisen.Size = new System.Drawing.Size(113, 37);
            this.buttonFahrzeugZuweisen.TabIndex = 15;
            this.buttonFahrzeugZuweisen.Text = "Zuweisen";
            this.buttonFahrzeugZuweisen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Strecken-Übersicht:";
            // 
            // buttonWechselDich4
            // 
            this.buttonWechselDich4.Location = new System.Drawing.Point(710, 372);
            this.buttonWechselDich4.Name = "buttonWechselDich4";
            this.buttonWechselDich4.Size = new System.Drawing.Size(115, 54);
            this.buttonWechselDich4.TabIndex = 17;
            this.buttonWechselDich4.Text = "Wechsel zu Strecken-Register";
            this.buttonWechselDich4.UseVisualStyleBackColor = true;
            this.buttonWechselDich4.Click += new System.EventHandler(this.buttonWechselDich4_Click);
            // 
            // FormFuhrpark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.buttonWechselDich4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFahrzeugZuweisen);
            this.Controls.Add(this.listBoxStrecke);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxFuhrpark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFahrzeugLoeschen);
            this.Controls.Add(this.buttonFahrzeugHinzufuegen);
            this.Controls.Add(this.textBoxAnzahlFahrzeug);
            this.Controls.Add(this.textBoxFahrzeugAlter);
            this.Controls.Add(this.textBoxRufname);
            this.Controls.Add(this.textBoxWerkstatt);
            this.Controls.Add(this.textBoxFahrzeugBezeichnung);
            this.Name = "FormFuhrpark";
            this.Text = "DB-Fuhrparkregister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFahrzeugBezeichnung;
        private System.Windows.Forms.TextBox textBoxWerkstatt;
        private System.Windows.Forms.TextBox textBoxRufname;
        private System.Windows.Forms.TextBox textBoxFahrzeugAlter;
        private System.Windows.Forms.TextBox textBoxAnzahlFahrzeug;
        private System.Windows.Forms.Button buttonFahrzeugHinzufuegen;
        private System.Windows.Forms.Button buttonFahrzeugLoeschen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxFuhrpark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxStrecke;
        private System.Windows.Forms.Button buttonFahrzeugZuweisen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonWechselDich4;
    }
}