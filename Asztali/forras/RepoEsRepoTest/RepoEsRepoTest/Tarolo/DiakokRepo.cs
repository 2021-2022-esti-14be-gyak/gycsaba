using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoEsRepoTest.Modell;
using RepoEsRepoTest.Tarolo.Interface;

namespace RepoEsRepoTest.Tarolo
{
    class DiakokRepo : IDiakokRepo
    {
        List<Diak> diakok;

        public DiakokRepo()
        {
            diakok = new List<Diak>();
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
