using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoEsRepoTest.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoEsRepoTest.Modell.Tests
{
    [TestClass()]
    public class DiákTestsEtkezikE
    {
        [TestMethod()]
        public void DiákTestEtkezik()
        {
            // Arrange 
            Diak d = new Diak("Nagy", "János", 12, true);
            bool elvart = true;

            // Act
            bool aktualis = d.EtkezikE;

            //
            Assert.AreEqual(elvart, aktualis, "Étkező diák esetén az étkezik tulajdonság nem ad igaz eredményt.");
        }

        [TestMethod()]
        public void DiákTestNemEtkezik()
        {
            // Arrange 
            Diak d = new Diak("Nagy", "János", 12, false);
            bool elvart = false;

            // Act
            bool aktualis = d.EtkezikE;

            //
            Assert.AreEqual(elvart, aktualis, "Nem étkező diák esetén az étkezik tulajdonság nem ad hamis eredményt.");
        }


    }
}