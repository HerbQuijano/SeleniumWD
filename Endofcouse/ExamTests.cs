using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Endofcouse
{
    [TestClass]
    public class ExamTests
    {
        [TestMethod]
        public void ComplicatedPage()
        {
            ComplicatedPage comp = new ComplicatedPage();
            //Console.WriteLine(comp.GetPageName());

            Assert.AreEqual("Complicated Page", comp.PageName);
        }

        [TestMethod]
        public void RandomStuff()
        {
            SectionOfRandomStuff randomStuff = new SectionOfRandomStuff();
            randomStuff.Fillform();
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void Buttons()
        {
            SectionOfButtons buttons = new SectionOfButtons();
            //null reference exception because we did not generate an Element object
            buttons.Button.Click();

            Console.WriteLine("Null Reference Exception");

            

        }

    }
}