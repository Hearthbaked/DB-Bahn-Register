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
    public partial class FormFuhrpark : Form
    {
        MySqlConnection conn;
        public FormFuhrpark(FormStrecken formStrecken)
        {
            this.formStrecken = formStrecken;
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;uid=root;password=;database=db_bahn_register");
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from fuhrpark";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Fuhrpark f = new Fuhrpark(reader.GetInt64(0), reader.GetString(1),
                reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));
                listBoxFuhrpark.Items.Add(f);
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
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFahrzeugHinzufuegen_Click(object sender, EventArgs e)
        {
            string fahrzeugbezeichnung = textBoxFahrzeugBezeichnung.Text;
            if (fahrzeugbezeichnung == "") return;
            string werkstatt_betriebswerk = textBoxWerkstatt.Text;
            if (werkstatt_betriebswerk == "") return;
            string rufname_intern = textBoxRufname.Text;
            if (rufname_intern == "") return;
            string a = textBoxFahrzeugAlter.Text;
            if (a == "") return;
            int fahrzeug_alter = Int32.Parse(a);
            string anz = textBoxAnzahlFahrzeug.Text;
            if (anz == "") return; 
            int anzahl_fahrzeug = Int32.Parse(anz);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into fuhrpark(fahrzeugbezeichnung,werkstatt_betriebswerk,rufname_bezeichnung_intern,fahrzeugalter,anzahl_des_fahrzeugs) values(@fahrzeugbezeichnung,@werkstatt_betriebswerk,@rufname_bezeichnung_intern,@fahrzeugalter,@anzahl_des_fahrzeugs)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@fahrzeugbezeichnung", fahrzeugbezeichnung);
            cmd.Parameters.AddWithValue("@werkstatt_betriebswerk", werkstatt_betriebswerk);
            cmd.Parameters.AddWithValue("@rufname_bezeichnung_intern", rufname_intern);
            cmd.Parameters.AddWithValue("@fahrzeug_alter", fahrzeug_alter);
            cmd.Parameters.AddWithValue("@anzahl_des_fahrzeugs", anzahl_fahrzeug);
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;
        }

        private void buttonFahrzeugLoeschen_Click(object sender, EventArgs e)
        {
            Fuhrpark f = (Fuhrpark)listBoxFuhrpark.SelectedItem;
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from fuhrpark where idFuhrpark=" + f.GetIdFuhrpark();
            command.ExecuteNonQuery();
            listBoxFuhrpark.Items.RemoveAt(listBoxFuhrpark.SelectedIndex);
        }
        private FormStrecken formStrecken = null;

        private void buttonWechselDich4_Click(object sender, EventArgs e)
        {
            if (formStrecken == null)
            {
                formStrecken = new FormStrecken(this);
            }
            else
            {
                formStrecken.LadDichNochmalNeu();
            }
            formStrecken.Show();
            Visible = false;
        }
        public void LadDichNeu()
        {

        }
        public void LadDichNochmalNeu()
        {

        }
    }
}
