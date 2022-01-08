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
    public class DiákTestsTeljesNev
    {
        [TestMethod()]
        public void DiákTeljesNévTestJóProgramozóPéter()
        {
            // arrange
            Diak d = new Diak("Programozó", "Péter", 10, true);
            string elvártTeljesNév = "Programozó Péter";

            // act
            string aktuálisTeljesNev = d.TeljesNev;

            // asssert
            Assert.AreEqual(elvártTeljesNév, aktuálisTeljesNev);
        }
        [TestMethod()]
        // Elméleti megfontolása
        public void DiákTeljesNévTestNincsVezetéknév()
        {
            // arrange
            Diak d = new Diak(null, "Péter", 10, true);
            string elvártTeljesNév = "Hibás név";

            // act
            string aktuálisTeljesNev = d.TeljesNev;

            // asssert
            Assert.AreEqual(elvártTeljesNév, aktuálisTeljesNev);
        }
    }
}