using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_Bahn_Register
{
    public partial class FormBahnhöfe : Form
    {
        MySqlConnection conn;
        public FormBahnhöfe(FormStrecken formStrecken)
        {
            this.formStrecken = formStrecken;
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;uid=root;password=;database=db_bahn_register");
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from bahnhoefe";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Bahnhof b = new Bahnhof(reader.GetInt64(0), reader.GetString(2),
                reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetFloat(6));
                listBoxBahnhof.Items.Add(b);
            }
            reader.Close();

            cmd.CommandText = "select * from strecken";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Strecke s = new Strecke(reader.GetInt64(0), reader.GetString(1),
                reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetFloat(5));
                listBoxStrecke.Items.Add(s);
            }
            reader.Close();
        }

        private FormStrecken formStrecken = null;

        private void buttonWechselDich2_Click(object sender, EventArgs e)
        {
            if (formStrecken == null)
            {
                formStrecken = new FormStrecken(this);
            }
            else
            {
                formStrecken.LadDichNeu();
            }
            formStrecken.Show();
            Visible = false;
        }
        public void LadDichNeu()
        {

        }

        private void buttonHinzufügen2_Click(object sender, EventArgs e)
        {
            string bahnhofsname = textBoxBahnhofName.Text;
            if (bahnhofsname == "") return;
            string bahnhofskuerzel = textBoxBahnhofKuerzel.Text;
            if (bahnhofskuerzel == "") return;
            string ort = textBoxOrt.Text;
            if (ort == "") return;
            string kat = textBoxKategorie.Text;
            if (kat == "") return;
            int bahnhofskategorie = Int32.Parse(kat);
            string kilo = textBoxStreckenkilometer.Text;
            if (kilo == "") return;
            float streckenkilometer = float.Parse(kilo);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into bahnhoefe(bahnhofsname,bahnhofskuerzel,ort,bahnhofskategorie,streckenkilometer) values(@bahnhofsname,@bahnhofskuerzel,@ort,@bahnhofskategorie,@streckenkilometer)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@bahnhofsname", bahnhofsname);
            cmd.Parameters.AddWithValue("@bahnhofskuerzel", bahnhofskuerzel);
            cmd.Parameters.AddWithValue("@ort", ort);
            cmd.Parameters.AddWithValue("@bahnhofskategorie", bahnhofskategorie);
            cmd.Parameters.AddWithValue("@streckenkilometer", streckenkilometer);
            cmd.ExecuteNonQuery();
            long idBahnhoefe = cmd.LastInsertedId;

            Bahnhof b = new Bahnhof(idBahnhoefe, bahnhofsname, bahnhofskuerzel, ort, bahnhofskategorie, streckenkilometer);
            listBoxBahnhof.Items.Add(b);
        }

        private void buttonBahnhoefeLoeschen_Click(object sender, EventArgs e)
        {
            Bahnhof b = (Bahnhof)listBoxBahnhof.SelectedItem;
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from bahnhoefe where idBahnhoefe=" + b.GetidBahnhoefe();
            command.ExecuteNonQuery();
            listBoxBahnhof.Items.RemoveAt(listBoxBahnhof.SelectedIndex);
        }

        private void buttonZuweisen_Click(object sender, EventArgs e)
        {
            Bahnhof b = (Bahnhof)listBoxBahnhof.SelectedItem;
            Strecke s = (Strecke)listBoxStrecke.SelectedItem;

            if (s == null || b == null)
            {
                MessageBox.Show("Auswahl inkorrekt!");
            }
            else
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "update bahnhoefe set idStrecken=" + s.GetIdStrecken() + " where idBahnhoefe=" + b.GetidBahnhoefe();
                command.ExecuteNonQuery();
            }

        }
    }
}
