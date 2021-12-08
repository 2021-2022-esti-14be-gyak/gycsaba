using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoEsRepoTest.Modell
{
    public class Diák
    {
        private string vezetekNev;
        private string keresztNev;
        private int eletkor;
        private bool etkezes;

        public Diák(string vezetekNev, string keresztNev, int eletkor, bool etkezes)
        {
            this.vezetekNev = vezetekNev;
            this.keresztNev = keresztNev;
            this.eletkor = eletkor;
            this.etkezes = etkezes;
        }

        public string TeljesNev
        {
            get
            {
                if ((vezetekNev == null) || (keresztNev == null))
                {
                    string teljesNev = "Hibás név";
                    return teljesNev;
                }
                else
                {
                    string teljesNev = vezetekNev + " " + keresztNev;
                    return teljesNev;
                }
            }
        }

        public bool EtkezikE
        {
            get
            {
                return true;
            }
        }

    }
}
