namespace DB_Bahn_Register
{
    partial class FormBahnhöfe
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBahnhofName = new System.Windows.Forms.TextBox();
            this.textBoxBahnhofKuerzel = new System.Windows.Forms.TextBox();
            this.textBoxOrt = new System.Windows.Forms.TextBox();
            this.textBoxKategorie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonHinzufügen2 = new System.Windows.Forms.Button();
            this.textBoxStreckenkilometer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxBahnhof = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonWechselDich2 = new System.Windows.Forms.Button();
            this.buttonBahnhoefeLoeschen = new System.Windows.Forms.Button();
            this.listBoxStrecke = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonZuweisen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Einzugebender Bahnhofsname:";
            // 
            // textBoxBahnhofName
            // 
            this.textBoxBahnhofName.Location = new System.Drawing.Point(44, 59);
            this.textBoxBahnhofName.Name = "textBoxBahnhofName";
            this.textBoxBahnhofName.Size = new System.Drawing.Size(145, 20);
            this.textBoxBahnhofName.TabIndex = 1;
            // 
            // textBoxBahnhofKuerzel
            // 
            this.textBoxBahnhofKuerzel.Location = new System.Drawing.Point(44, 129);
            this.textBoxBahnhofKuerzel.Name = "textBoxBahnhofKuerzel";
            this.textBoxBahnhofKuerzel.Size = new System.Drawing.Size(145, 20);
            this.textBoxBahnhofKuerzel.TabIndex = 2;
            // 
            // textBoxOrt
            // 
            this.textBoxOrt.Location = new System.Drawing.Point(44, 203);
            this.textBoxOrt.Name = "textBoxOrt";
            this.textBoxOrt.Size = new System.Drawing.Size(145, 20);
            this.textBoxOrt.TabIndex = 3;
            // 
            // textBoxKategorie
            // 
            this.textBoxKategorie.Location = new System.Drawing.Point(44, 276);
            this.textBoxKategorie.Name = "textBoxKategorie";
            this.textBoxKategorie.Size = new System.Drawing.Size(145, 20);
            this.textBoxKategorie.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Einzugebendes Bahnhofskürzel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Einzugebender Ort:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Einzugebende Bahnhofskategorie:";
            // 
            // buttonHinzufügen2
            // 
            this.buttonHinzufügen2.Location = new System.Drawing.Point(44, 403);
            this.buttonHinzufügen2.Name = "buttonHinzufügen2";
            this.buttonHinzufügen2.Size = new System.Drawing.Size(145, 62);
            this.buttonHinzufügen2.TabIndex = 8;
            this.buttonHinzufügen2.Text = "Hinzufügen";
            this.buttonHinzufügen2.UseVisualStyleBackColor = true;
            this.buttonHinzufügen2.Click += new System.EventHandler(this.buttonHinzufügen2_Click);
            // 
            // textBoxStreckenkilometer
            // 
            this.textBoxStreckenkilometer.Location = new System.Drawing.Point(44, 348);
            this.textBoxStreckenkilometer.Name = "textBoxStreckenkilometer";
            this.textBoxStreckenkilometer.Size = new System.Drawing.Size(145, 20);
            this.textBoxStreckenkilometer.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Einzugebender Streckenkilometer:";
            // 
            // listBoxBahnhof
            // 
            this.listBoxBahnhof.FormattingEnabled = true;
            this.listBoxBahnhof.Location = new System.Drawing.Point(306, 59);
            this.listBoxBahnhof.Name = "listBoxBahnhof";
            this.listBoxBahnhof.Size = new System.Drawing.Size(330, 303);
            this.listBoxBahnhof.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bahnhöfe-Übersicht:";
            // 
            // buttonWechselDich2
            // 
            this.buttonWechselDich2.Location = new System.Drawing.Point(806, 403);
            this.buttonWechselDich2.Name = "buttonWechselDich2";
            this.buttonWechselDich2.Size = new System.Drawing.Size(138, 62);
            this.buttonWechselDich2.TabIndex = 13;
            this.buttonWechselDich2.Text = "Wechsel zu Strecken-Register";
            this.buttonWechselDich2.UseVisualStyleBackColor = true;
            this.buttonWechselDich2.Click += new System.EventHandler(this.buttonWechselDich2_Click);
            // 
            // buttonBahnhoefeLoeschen
            // 
            this.buttonBahnhoefeLoeschen.Location = new System.Drawing.Point(215, 403);
            this.buttonBahnhoefeLoeschen.Name = "buttonBahnhoefeLoeschen";
            this.buttonBahnhoefeLoeschen.Size = new System.Drawing.Size(124, 62);
            this.buttonBahnhoefeLoeschen.TabIndex = 14;
            this.buttonBahnhoefeLoeschen.Text = "Löschen";
            this.buttonBahnhoefeLoeschen.UseVisualStyleBackColor = true;
            this.buttonBahnhoefeLoeschen.Click += new System.EventHandler(this.buttonBahnhoefeLoeschen_Click);
            // 
            // listBoxStrecke
            // 
            this.listBoxStrecke.FormattingEnabled = true;
            this.listBoxStrecke.Location = new System.Drawing.Point(661, 59);
            this.listBoxStrecke.Name = "listBoxStrecke";
            this.listBoxStrecke.Size = new System.Drawing.Size(335, 303);
            this.listBoxStrecke.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(658, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Strecken-Übersicht:";
            // 
            // buttonZuweisen
            // 
            this.buttonZuweisen.Location = new System.Drawing.Point(557, 403);
            this.buttonZuweisen.Name = "buttonZuweisen";
            this.buttonZuweisen.Size = new System.Drawing.Size(128, 62);
            this.buttonZuweisen.TabIndex = 17;
            this.buttonZuweisen.Text = "Zuweisen";
            this.buttonZuweisen.UseVisualStyleBackColor = true;
            this.buttonZuweisen.Click += new System.EventHandler(this.buttonZuweisen_Click);
            // 
            // FormBahnhöfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 489);
            this.Controls.Add(this.buttonZuweisen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxStrecke);
            this.Controls.Add(this.buttonBahnhoefeLoeschen);
            this.Controls.Add(this.buttonWechselDich2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxBahnhof);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxStreckenkilometer);
            this.Controls.Add(this.buttonHinzufügen2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKategorie);
            this.Controls.Add(this.textBoxOrt);
            this.Controls.Add(this.textBoxBahnhofKuerzel);
            this.Controls.Add(this.textBoxBahnhofName);
            this.Controls.Add(this.label1);
            this.Name = "FormBahnhöfe";
            this.Text = "DB-Bahn-Bahnhofsregister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBahnhofName;
        private System.Windows.Forms.TextBox textBoxBahnhofKuerzel;
        private System.Windows.Forms.TextBox textBoxOrt;
        private System.Windows.Forms.TextBox textBoxKategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonHinzufügen2;
        private System.Windows.Forms.TextBox textBoxStreckenkilometer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxBahnhof;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonWechselDich2;
        private System.Windows.Forms.Button buttonBahnhoefeLoeschen;
        private System.Windows.Forms.ListBox listBoxStrecke;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonZuweisen;
    }
}