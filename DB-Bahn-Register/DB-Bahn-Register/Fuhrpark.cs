using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Bahn_Register
{
    class Fuhrpark
    {
        private long idFuhrpark;
        private string fahrzeugbezeichnung;
        private string werkstatt_betriebswerk;
        private string rufname_intern;
        private int fahrzeugalter;
        private int anzahl_fahrzeug;

        public long GetIdFuhrpark()
        {
            return idFuhrpark;
        }
        
        public Fuhrpark(long idFuhrpark, string fahrzeugbezeichnung, string werkstatt_betriebswerk, string rufname_intern, int fahrzeugalter, int anzahl_fahrzeug)
        {
            this.idFuhrpark = idFuhrpark;
            this.fahrzeugbezeichnung = fahrzeugbezeichnung;
            this.werkstatt_betriebswerk = werkstatt_betriebswerk;
            this.rufname_intern = rufname_intern;
            this.fahrzeugalter = fahrzeugalter;
            this.anzahl_fahrzeug = anzahl_fahrzeug;
        }
        public override string ToString()
        {
            return fahrzeugbezeichnung + "||" + werkstatt_betriebswerk + "||" + rufname_intern + "||" + fahrzeugalter + "||" + anzahl_fahrzeug + "fahrzeuge"; 
        }
    }
}
