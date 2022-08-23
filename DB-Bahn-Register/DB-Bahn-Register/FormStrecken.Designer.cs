namespace DB_Bahn_Register
{
    partial class FormStrecken
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxStrLinien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStartBahnhof = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxZielBahnhof = new System.Windows.Forms.TextBox();
            this.textBoxVerfügbarkeit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonHinzufügen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStreckenLänge = new System.Windows.Forms.TextBox();
            this.buttonWechselDich = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxStrecke = new System.Windows.Forms.ListBox();
            this.listBoxStreckenVerlauf = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonStreckenLoeschen = new System.Windows.Forms.Button();
            this.buttonWechselDich3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStrLinien
            // 
            this.textBoxStrLinien.Location = new System.Drawing.Point(29, 50);
            this.textBoxStrLinien.Name = "textBoxStrLinien";
            this.textBoxStrLinien.Size = new System.Drawing.Size(146, 20);
            this.textBoxStrLinien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Einzugebende Liniennummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Einzugebender Startbahnhof:";
            // 
            // textBoxStartBahnhof
            // 
            this.textBoxStartBahnhof.Location = new System.Drawing.Point(29, 135);
            this.textBoxStartBahnhof.Name = "textBoxStartBahnhof";
            this.textBoxStartBahnhof.Size = new System.Drawing.Size(146, 20);
            this.textBoxStartBahnhof.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Einzugebender Zielbahnhof:";
            // 
            // textBoxZielBahnhof
            // 
            this.textBoxZielBahnhof.Location = new System.Drawing.Point(29, 220);
            this.textBoxZielBahnhof.Name = "textBoxZielBahnhof";
            this.textBoxZielBahnhof.Size = new System.Drawing.Size(143, 20);
            this.textBoxZielBahnhof.TabIndex = 5;
            // 
            // textBoxVerfügbarkeit
            // 
            this.textBoxVerfügbarkeit.Location = new System.Drawing.Point(32, 301);
            this.textBoxVerfügbarkeit.Name = "textBoxVerfügbarkeit";
            this.textBoxVerfügbarkeit.Size = new System.Drawing.Size(143, 20);
            this.textBoxVerfügbarkeit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Verfügbarkeit der Strecke(bsp. Mo-Fr, oder nur Wochende):";
            // 
            // buttonHinzufügen
            // 
            this.buttonHinzufügen.Location = new System.Drawing.Point(28, 445);
            this.buttonHinzufügen.Name = "buttonHinzufügen";
            this.buttonHinzufügen.Size = new System.Drawing.Size(143, 51);
            this.buttonHinzufügen.TabIndex = 8;
            this.buttonHinzufügen.Text = "Hinzufügen";
            this.buttonHinzufügen.UseVisualStyleBackColor = true;
            this.buttonHinzufügen.Click += new System.EventHandler(this.buttonHinzufügen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Einzugebende Streckenlänge:";
            // 
            // textBoxStreckenLänge
            // 
            this.textBoxStreckenLänge.Location = new System.Drawing.Point(29, 385);
            this.textBoxStreckenLänge.Name = "textBoxStreckenLänge";
            this.textBoxStreckenLänge.Size = new System.Drawing.Size(143, 20);
            this.textBoxStreckenLänge.TabIndex = 10;
            // 
            // buttonWechselDich
            // 
            this.buttonWechselDich.Location = new System.Drawing.Point(773, 445);
            this.buttonWechselDich.Name = "buttonWechselDich";
            this.buttonWechselDich.Size = new System.Drawing.Size(149, 51);
            this.buttonWechselDich.TabIndex = 11;
            this.buttonWechselDich.Text = "Wechsel zu Bahnhofs-Register";
            this.buttonWechselDich.UseVisualStyleBackColor = true;
            this.buttonWechselDich.Click += new System.EventHandler(this.buttonWechselDich_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Strecken-Übersicht:";
            // 
            // listBoxStrecke
            // 
            this.listBoxStrecke.FormattingEnabled = true;
            this.listBoxStrecke.Location = new System.Drawing.Point(346, 50);
            this.listBoxStrecke.Name = "listBoxStrecke";
            this.listBoxStrecke.Size = new System.Drawing.Size(328, 355);
            this.listBoxStrecke.TabIndex = 14;
            this.listBoxStrecke.SelectedIndexChanged += new System.EventHandler(this.listBoxStreckenVerlauf_SelectedIndexChanged);
            // 
            // listBoxStreckenVerlauf
            // 
            this.listBoxStreckenVerlauf.FormattingEnabled = true;
            this.listBoxStreckenVerlauf.Location = new System.Drawing.Point(680, 50);
            this.listBoxStreckenVerlauf.Name = "listBoxStreckenVerlauf";
            this.listBoxStreckenVerlauf.Size = new System.Drawing.Size(288, 355);
            this.listBoxStreckenVerlauf.TabIndex = 15;
            this.listBoxStreckenVerlauf.SelectedIndexChanged += new System.EventHandler(this.listBoxStreckenVerlauf_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Strecken-Verlauf:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "KM";
            // 
            // buttonStreckenLoeschen
            // 
            this.buttonStreckenLoeschen.Location = new System.Drawing.Point(199, 445);
            this.buttonStreckenLoeschen.Name = "buttonStreckenLoeschen";
            this.buttonStreckenLoeschen.Size = new System.Drawing.Size(118, 51);
            this.buttonStreckenLoeschen.TabIndex = 18;
            this.buttonStreckenLoeschen.Text = "Löschen";
            this.buttonStreckenLoeschen.UseVisualStyleBackColor = true;
            this.buttonStreckenLoeschen.Click += new System.EventHandler(this.buttonStreckenLoeschen_Click);
            // 
            // buttonWechselDich3
            // 
            this.buttonWechselDich3.Location = new System.Drawing.Point(504, 445);
            this.buttonWechselDich3.Name = "buttonWechselDich3";
            this.buttonWechselDich3.Size = new System.Drawing.Size(133, 51);
            this.buttonWechselDich3.TabIndex = 19;
            this.buttonWechselDich3.Text = "Wechsel zu Fuhrpark-Register";
            this.buttonWechselDich3.UseVisualStyleBackColor = true;
            this.buttonWechselDich3.Click += new System.EventHandler(this.buttonWechselDich3_Click);
            // 
            // FormStrecken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 508);
            this.Controls.Add(this.buttonWechselDich3);
            this.Controls.Add(this.buttonStreckenLoeschen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxStreckenVerlauf);
            this.Controls.Add(this.listBoxStrecke);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonWechselDich);
            this.Controls.Add(this.textBoxStreckenLänge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonHinzufügen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVerfügbarkeit);
            this.Controls.Add(this.textBoxZielBahnhof);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStartBahnhof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStrLinien);
            this.Name = "FormStrecken";
            this.Text = " DB-Bahn-Streckenregister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStrLinien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStartBahnhof;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxZielBahnhof;
        private System.Windows.Forms.TextBox textBoxVerfügbarkeit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonHinzufügen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStreckenLänge;
        private System.Windows.Forms.Button buttonWechselDich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxStrecke;
        private System.Windows.Forms.ListBox listBoxStreckenVerlauf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonStreckenLoeschen;
        private System.Windows.Forms.Button buttonWechselDich3;
    }
}

