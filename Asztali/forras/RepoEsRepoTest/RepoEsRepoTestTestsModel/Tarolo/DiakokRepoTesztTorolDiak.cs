using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RepoEsRepoTest.Tarolo;
using RepoEsRepoTest.Modell;

namespace RepoEsRepoTest.Tarolo.Tests
{
    [TestClass()]
    public class DiakokRepoTesztTorolDiak
    {
        [TestMethod()]
        public void TorolTestDiakokSzamaCsokken()
        {
            // arrange
            DiakokRepo repo = new DiakokRepo();
            repo.TestAdatok();

            // act
            repo.Torol(1);
            int elvartDikokSzama = 2;

            // assert
            Assert.AreEqual(elvartDikokSzama,repo.DiakokSzama,"Törlés a diákok száma nem csökkent.")


        }

        [TestMethod()]
        public void TorolTestDiakokDiakNemTalalhatoTorlesUtan()
        {
            DiakokRepo repo = new DiakokRepo();
            repo.TestAdatok();

            repo.Torol(1);
            Diak toroltDiak = new Diak(1, "Kis", "János", 12, true);
            bool elvartVanEToroltDiak = false;

            Assert.AreEqual(elvartVanEToroltDiak,repo.)

        }
    }
}