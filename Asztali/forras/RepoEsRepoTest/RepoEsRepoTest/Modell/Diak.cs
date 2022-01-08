using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoEsRepoTest.Modell
{
    public class Diak
    {
        private string vezetekNev;
        private string keresztNev;
        private int eletkor;
        private bool etkezes;

        public Diak(string vezetekNev, string keresztNev, int eletkor, bool etkezes)
        {
            this.VezetekNev = vezetekNev;
            this.KeresztNev = keresztNev;
            this.Eletkor = eletkor;
            this.etkezes = etkezes;
        }

        public string TeljesNev
        {
            get
            {
                if ((VezetekNev == null) || (KeresztNev == null))
                {
                    string teljesNev = "Hibás név";
                    return teljesNev;
                }
                else
                {
                    string teljesNev = VezetekNev + " " + KeresztNev;
                    return teljesNev;
                }
            }
        }

        public bool EtkezikE
        {
            get
            {
                if (etkezes)
                    return true;
                else
                    return false;
            }
        }

        public string VezetekNev { get => vezetekNev; set => vezetekNev = value; }
        public string KeresztNev { get => keresztNev; set => keresztNev = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
    }
}
