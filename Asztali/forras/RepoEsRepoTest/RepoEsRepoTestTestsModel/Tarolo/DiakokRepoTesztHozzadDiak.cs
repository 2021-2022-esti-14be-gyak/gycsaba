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
    public class DiakokRepoTesztHozzadDiak
    {
        [TestMethod()]
        public void Hozzad3DiakhozTest()
        {
            // Arrange
            DiakokRepo repo = new DiakokRepo();
            repo.TestAdatok();
            Diak ujDiak = new Diak("Uj", "László", 13, true);

            // Act
            repo.Hozzad(ujDiak);

            // Arrange
            int elvartDiakszam = 4;
            bool ujDiakTarolvaVan = true;

            Assert.AreEqual(elvartDiakszam, repo.DiakokSzama, "Három diák van a repoba, egyet hozzáadtunk, de a diákok száma nem változott");

            Assert.AreEqual(ujDiakTarolvaVan, repo.LetezikEDiak(ujDiak), "Hozzadtuk a diákot, a diákok száma nőtt, de mégsincs tárolva");
        }
    }
}