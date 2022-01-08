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
            diakok.Add(new Diak("Kis", "János", 12, true));
            diakok.Add(new Diak("Nagy", "Kelemen", 13, false));
            diakok.Add(new Diak("Molnár", "Piroska", 12, true));
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

        public void Hozzad(Diak diák)
        {
            throw new NotImplementedException();
        }

        public void Módosít(int azonosító, string vezetéknév)
        {
            throw new NotImplementedException();
        }

        public void Módosít(int azonosító, Diak modosítottAdatok)
        {
            throw new NotImplementedException();
        }

        public void Töröl(int azonosito)
        {
            throw new NotImplementedException();
        }
    }
}
