﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Textumbruch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textumbruch.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void UmbrechenTest()
        {
            Program ProgramInstance;
            String Ausgangstext;
            String Lösungstext;
            int maxLänge;

            ProgramInstance = new Program();

            Ausgangstext = "Hallo Welt!";
            Lösungstext = "Hallo" + System.Environment.NewLine + "Welt!";
            maxLänge = 5;
            Assert.AreEqual(Lösungstext, ProgramInstance.Umbrechen(Ausgangstext, maxLänge));

            Ausgangstext = "Ein potenziell mehrzeiliger Text";
            Lösungstext = "Ein" + System.Environment.NewLine + "potenziell" + System.Environment.NewLine + "mehrzeilig" + System.Environment.NewLine + "er Text";
            maxLänge = 10;
            Assert.AreEqual(Lösungstext, ProgramInstance.Umbrechen(Ausgangstext, maxLänge));


        }

        [TestMethod()]
        public void GetLengthOfNextLineTest()
        {
            Program ProgramInstance;
            String Ausgangstext;
            int Loesung;
            int maxLänge;

            ProgramInstance = new Program();

            Ausgangstext = "Hallo Welt!";
            Loesung = 5;
            maxLänge = 7;
            Assert.AreEqual(Loesung, ProgramInstance.GetLengthOfNextLine(Ausgangstext, maxLänge));

            Ausgangstext = "Ein potenziell mehrzeiliger Text";
            Loesung = 14;
            maxLänge = 24;
            Assert.AreEqual(Loesung, ProgramInstance.GetLengthOfNextLine(Ausgangstext, maxLänge));

            Ausgangstext = "Ein potenziell mehrzeiliger Text";
            Loesung = 3;
            maxLänge = 5;
            Assert.AreEqual(Loesung, ProgramInstance.GetLengthOfNextLine(Ausgangstext, maxLänge));

            Ausgangstext = "EinPotenziellMehrzeiliger Text";
            Loesung = 5;
            maxLänge = 5;
            Assert.AreEqual(Loesung, ProgramInstance.GetLengthOfNextLine(Ausgangstext, maxLänge));
        }
    }
}