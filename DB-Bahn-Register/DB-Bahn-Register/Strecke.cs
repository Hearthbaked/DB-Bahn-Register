using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Bahn_Register
{
    class Strecke
    {
        private string liniennummer;
        private string startbahnhof;
        private string endbahnhof;
        private string verfuegbarkeit;
        private float streckenlaenge;

        public long idStrecken = 0;
        public long GetIdStrecken()
        {
            return idStrecken;
        }
        public Strecke(long idStrecken, string liniennummer, string startbahnhof, string endbahnhof, string verfuegbarkeit, float streckenlaenge)
        {
            this.idStrecken = idStrecken;
            this.liniennummer = liniennummer;
            this.startbahnhof = startbahnhof;
            this.endbahnhof = endbahnhof;
            this.verfuegbarkeit = verfuegbarkeit;
            this.streckenlaenge = streckenlaenge;
        }
        public override string ToString()
        {
            return liniennummer+ "||" + startbahnhof+ "||" + endbahnhof + "||" + verfuegbarkeit + "||" + streckenlaenge + "km";
        }
    }
}
