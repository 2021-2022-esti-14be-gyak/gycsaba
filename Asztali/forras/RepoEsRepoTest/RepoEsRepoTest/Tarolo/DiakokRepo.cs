using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoEsRepoTest.Modell;
using RepoEsRepoTest.Tarolo.Interface;

namespace RepoEsRepoTest.Tarolo
{
    public class DiakokRepo : IDiakokRepo
    {
        List<Diak> diakok;

        public DiakokRepo()
        {
            diakok = new List<Diak>();
        }

        public void  TestAdatok()
        {
            diakok.Add(new Diak(1,"Kis", "János", 12, true));
            diakok.Add(new Diak(2,"Nagy", "Kelemen", 13, false));
            diakok.Add(new Diak(3,"Molnár", "Piroska", 12, true));
        }

        public int DiakokSzama
        {
            get
            {
                return diakok.Count;
            }
        }

        public bool LetezikEDiak(Diak keresettDiak)
        {
            return diakok.Exists(diak => diak == keresettDiak);
        }

        public void Hozzad(Diak diak)
        {
            diakok.Add(diak);          
        }

        public void Módosít(int azonosító, string vezetéknév)
        {
            throw new NotImplementedException();
        }

        public void Módosít(int azonosító, Diak modosítottAdatok)
        {
            throw new NotImplementedException();
        }

        public void Torol(int azonosito)
        {
            throw new NotImplementedException();
        }
    }
}
