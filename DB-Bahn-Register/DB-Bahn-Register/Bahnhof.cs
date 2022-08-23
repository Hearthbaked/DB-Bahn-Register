using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Bahn_Register
{
    class Bahnhof
    {
        private long idBahnhoefe;
        private string bahnhofsname;
        private string bahnhofskuerzel;
        private string ort;
        private int bahnhofskategorie;
        private float streckenkilometer;
        public long GetidBahnhoefe()
        {
            return idBahnhoefe;
        }
        public float GetStreckenkilometer()
        {
            return streckenkilometer;
        }
        public Bahnhof(long idBahnhoefe, string bahnhofsname, string bahnhofskuerzel, string ort, int bahnhofskategorie, float streckenkilometer)
        {
            this.idBahnhoefe = idBahnhoefe;
            this.bahnhofsname = bahnhofsname;
            this.bahnhofskuerzel = bahnhofskuerzel;
            this.ort = ort;
            this.bahnhofskategorie = bahnhofskategorie;
            this.streckenkilometer = streckenkilometer;
        }
        public override string ToString()
        {
            return bahnhofsname + "||" + bahnhofskuerzel + "||" + ort + "||" + bahnhofskategorie + "||" + streckenkilometer + "km";
        }
    
    }
}
