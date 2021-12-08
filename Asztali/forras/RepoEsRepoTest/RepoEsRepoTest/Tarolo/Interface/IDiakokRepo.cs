using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RepoEsRepoTest.Modell;

namespace RepoEsRepoTest.Tarolo.Interface
{
    interface IDiakokRepo
    {
        /// <summary>
        /// A listához a diák hozzáadása
        /// </summary>
        /// <param name="diák">Ezt a diákok adjuk a listához</param>
        public void Hozzad(Diák diák);

        /// <summary>
        /// A diák törlés a listából
        /// </summary>
        /// <param name="azonosito">A törlendő diák azonosítója</param>
        public void Töröl(int azonosito);

        /// <summary>
        /// Diák vezetéknevének módosítása
        /// </summary>
        /// <param name="azonosító">A módosítandó diák azonosítója</param>
        /// <param name="vezetéknév">A diák új vezetékneve</param>
        public void Módosít(int azonosító, string vezetéknév);

        /// <summary>
        /// Diák több adatának módosítása
        /// </summary>
        /// <param name="azonosító">A módosítandó diák azonosítója</param>
        /// <param name="modosítottAdatok">Erre az adatokra módosítjuk a diák adatait</param>
        public void Módosít(int azonosító, Diák modosítottAdatok);
    }
}
