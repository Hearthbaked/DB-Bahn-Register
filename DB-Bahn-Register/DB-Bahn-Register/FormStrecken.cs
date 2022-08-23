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
    public partial class FormStrecken : Form
    {
        MySqlConnection conn;
        public FormStrecken(FormBahnhöfe formBahnhöfe)
        {
            this.formBahnhöfe = formBahnhöfe;

            InitializeComponent();
            conn = new MySqlConnection("server=localhost;uid=root;password=;database=db_bahn_register");
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from strecken";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Strecke s = new Strecke(reader.GetInt64(0), reader.GetString(1),
                reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetFloat(5));
                listBoxStrecke.Items.Add(s);
            }
            reader.Close();
        }
        public FormStrecken(FormFuhrpark fuhrpark)
        {
            
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;uid=root;password=root;database=db_bahn_register");
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from fuhrpark";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Fuhrpark f = new Fuhrpark(reader.GetInt64(0), reader.GetString(1),
                reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));
                listBoxStrecke.Items.Add(f);
            }
            reader.Close();
        }
        private FormBahnhöfe formBahnhöfe = null;

        private void buttonWechselDich_Click(object sender, EventArgs e)
        {
            if (formBahnhöfe == null)
            {
                formBahnhöfe = new FormBahnhöfe(this);
            }
            else
            {
                formBahnhöfe.LadDichNeu();
            }
            formBahnhöfe.Show();
            Visible = false;

        }

        public void LadDichNeu()
        {

        }

        private void buttonHinzufügen_Click(object sender, EventArgs e)
        {
            string liniennummer = textBoxStrLinien.Text;
            if (liniennummer == "") return;
            string startbahnhof = textBoxStartBahnhof.Text;
            if (startbahnhof == "") return;
            string endbahnhof = textBoxZielBahnhof.Text;
            if (endbahnhof == "") return;
            string verfuegbarkeit = textBoxVerfügbarkeit.Text;
            if (verfuegbarkeit == "") return;
            string strlaenge = textBoxStreckenLänge.Text;
            if (strlaenge == "") return;
            float streckenlaenge = float.Parse(strlaenge);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into strecken(liniennummer,startbahnhof,endbahnhof,verfuegbarkeit,streckenlaenge) values(@liniennummer,@startbahnhof,@endbahnhof,@verfuegbarkeit,@streckenlaenge)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@liniennummer", liniennummer);
            cmd.Parameters.AddWithValue("@startbahnhof", startbahnhof);
            cmd.Parameters.AddWithValue("@endbahnhof", endbahnhof);
            cmd.Parameters.AddWithValue("@verfuegbarkeit", verfuegbarkeit);
            cmd.Parameters.AddWithValue("@streckenlaenge", streckenlaenge);
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;

            Strecke s = new Strecke(id, liniennummer, startbahnhof, endbahnhof, verfuegbarkeit, streckenlaenge);
            listBoxStrecke.Items.Add(s);
        }

        private void buttonStreckenLoeschen_Click(object sender, EventArgs e)
        {
            Strecke s = (Strecke)listBoxStrecke.SelectedItem;
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from strecken where idStrecken=" + s.GetIdStrecken();
            command.ExecuteNonQuery();
            listBoxStrecke.Items.RemoveAt(listBoxStrecke.SelectedIndex);
        }
        private void listBoxStreckenVerlauf_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxStreckenVerlauf.Items.Clear();
            Strecke s = (Strecke)listBoxStrecke.SelectedItem;

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * from bahnhoefe where idStrecken=" + s.GetIdStrecken() + " " + "order by streckenkilometer";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Bahnhof b = new Bahnhof(reader.GetInt64(0), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetFloat(6));
                listBoxStreckenVerlauf.Items.Add(b);
            }
            reader.Close();
        }

        private FormFuhrpark formFuhrpark;

        private void buttonWechselDich3_Click(object sender, EventArgs e)
        {
            if (formFuhrpark == null)
            {
                formFuhrpark = new FormFuhrpark(this);
            }
            else
            {
                formFuhrpark.LadDichNochmalNeu();
            }
            formFuhrpark.Show();
            Visible = false;
        }
        public void LadDichNochmalNeu()
        {

        }
    }
}
