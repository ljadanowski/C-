using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MojProjekt;

namespace MojProjekt.Test
{
    [TestClass]
    public class LiczbaZespolonaTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestCategory("Tworzenie obiektu")]
        [TestMethod]
        public void TworzenieObiektuTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(2.3, 4.5);
            //sprawdzanie poprawnosci utworzonych typow
            //najpierw nalezy sprawdzic czy liczbazespolona nie jest null
            Assert.IsNotNull(liczbazespolona);
            //oraz wynik
            Assert.IsNotNull(wynik);
            Assert.IsInstanceOfType(liczbazespolona, typeof(LiczbaZespolona));
            Assert.IsInstanceOfType(liczbazespolona.Dodaj(1.2, 2.3), typeof(LiczbaZespolona));
            Assert.IsInstanceOfType(liczbazespolona.Odejmij(1.2, 2.3), typeof(LiczbaZespolona));
            Assert.IsNotInstanceOfType(liczbazespolona.Dodaj(1.2, 2.3), typeof(double));
            Assert.IsNotInstanceOfType(liczbazespolona.Odejmij(1.2, 2.3), typeof(double));
        }

        [TestCategory("Kalkulator")]
        [TestMethod]
        public void DodawanieTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(2.3,4.5);
            //Sprawdzanie poprawnosci dzialan
            Assert.IsTrue(wynik.Equals(liczbazespolona.Dodaj(1.2, 2.3)));
            Assert.IsFalse(wynik.Equals(liczbazespolona.Dodaj(1.2, 2.30000000001)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Dodaj(1.2, 2.3).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Dodaj(1.2, 2.3).PobierzZespolona());
            
            wynik = new LiczbaZespolona(-0.1, 4.5);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Dodaj(-1.2, 2.3)));
            Assert.IsFalse(wynik.Equals(liczbazespolona.Dodaj(-1.2000000001, 2.3)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Dodaj(-1.2, 2.3).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Dodaj(-1.2, 2.3).PobierzZespolona());

            liczbazespolona = new LiczbaZespolona(1.12, 2.23);
            wynik = new LiczbaZespolona(2.341, -0.102);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Dodaj(1.221, -2.332)));
            Assert.IsFalse(wynik.Equals(liczbazespolona.Dodaj(-1.221, -2.332)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Dodaj(1.221, -2.332).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Dodaj(1.221, -2.332).PobierzZespolona());

            liczbazespolona = new LiczbaZespolona(-0.532, -0.116);
            wynik = new LiczbaZespolona(0.689, -2.448);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Dodaj(1.221, -2.332)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Dodaj(1.221, -2.332).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Dodaj(1.221, -2.332).PobierzZespolona());

            liczbazespolona = new LiczbaZespolona(-2, 3);
            wynik = new LiczbaZespolona(2, 2);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Dodaj(4, -1)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Dodaj(4, -1).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Dodaj(4, -1).PobierzZespolona());

            liczbazespolona = new LiczbaZespolona(0, 0);
            wynik = new LiczbaZespolona(0, 0);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Dodaj(0, 0)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Dodaj(0, 0).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Dodaj(0, 0).PobierzZespolona());
        }
        
        [TestCategory("Kalkulator")]
        [TestMethod]
        public void OdejmowanieTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(-0.1, -0.1);
            
            Assert.IsTrue(wynik.Equals(liczbazespolona.Odejmij(1.2, 2.3)));
            Assert.IsFalse(wynik.Equals(liczbazespolona.Odejmij(1.2, 2.30000000001)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Odejmij(1.2, 2.3).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Odejmij(1.2, 2.3).PobierzZespolona());

            //poprawiac od tad
            liczbazespolona = new LiczbaZespolona(-543.43, 2.309);
            wynik = new LiczbaZespolona(-542.23, 0.009);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Odejmij(-1.2, 2.3)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Odejmij(-1.2, 2.3).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Odejmij(-1.2, 2.3).PobierzZespolona());

            liczbazespolona = new LiczbaZespolona(1.12, 2.23);
            wynik = new LiczbaZespolona(-0.101, 4.562);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Odejmij(1.221, -2.332)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Odejmij(1.221, -2.332).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Odejmij(1.221, -2.332).PobierzZespolona());

            liczbazespolona = new LiczbaZespolona(-0.532, -0.116);
            wynik = new LiczbaZespolona(-1.753, 2.216);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Odejmij(1.221, -2.332)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Odejmij(1.221, -2.332).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Odejmij(1.221, -2.332).PobierzZespolona());

            liczbazespolona = new LiczbaZespolona(-2, 3);
            wynik = new LiczbaZespolona(-6, 4);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Odejmij(4, -1)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Odejmij(4, -1).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Odejmij(4, -1).PobierzZespolona());

            liczbazespolona = new LiczbaZespolona(0, 0);
            wynik = new LiczbaZespolona(0, 0);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Odejmij(0, 0)));
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Odejmij(0, 0).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Odejmij(0, 0).PobierzZespolona());
        }

        [TestCategory("Kalkulator")]
        [TestMethod]
        [DataSource("System.Data.SqlClient",
            @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\PROGRAMY\C#\MojProjekt\MojProjekt.Test\Database1.mdf;Integrated Security=True;Connect Timeout=30",
            "dbo.Table",
            DataAccessMethod.Sequential
            )]
        public void SprzezenieTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona();
            double x = Convert.ToDouble(TestContext.DataRow["x"]);
            double y = Convert.ToDouble(TestContext.DataRow["y"]);
            liczbazespolona.UstawRzeczywista(x);
            liczbazespolona.UstawZespolona(y);
            double x_true = Convert.ToDouble(TestContext.DataRow["x_true"]);
            double y_true = Convert.ToDouble(TestContext.DataRow["y_true"]);
            liczbazespolona.Sprzezenie();
            Assert.AreEqual(x_true, liczbazespolona.PobierzRzeczywista());
            Assert.AreEqual(y_true, liczbazespolona.PobierzZespolona());
        }

        [TestMethod]
        [TestCategory("Kalkulator")]
        public void ObliczModulTest()
        {
            LiczbaZespolona liczbazespolona;

            liczbazespolona = new LiczbaZespolona(3, 4);
            double wynik = 5;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());

            liczbazespolona = new LiczbaZespolona(2, 0);
            wynik = 2;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());

            liczbazespolona = new LiczbaZespolona(-2, 0);
            wynik = 2;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());

            liczbazespolona = new LiczbaZespolona(0, 5);
            wynik = 5;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());

            liczbazespolona = new LiczbaZespolona(0, -5);
            wynik = 5;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());
            
            //testowanie jak to jest z ujemnymi liczbami
            liczbazespolona = new LiczbaZespolona(-5, 12);
            wynik = 13;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());

            liczbazespolona = new LiczbaZespolona(5, -12);
            wynik = 13;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());

            liczbazespolona = new LiczbaZespolona(-5, -12);
            wynik = 13;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());

            //Testowanie dla niepoprawnej wartosci
            liczbazespolona = new LiczbaZespolona(-5, -12);
            wynik = 14;
            Assert.AreNotEqual(wynik, liczbazespolona.ObliczModul());
        }

        [TestMethod]
        [TestCategory("Divide")]
        public void PodzielTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(5, 7);

            LiczbaZespolona wynik = new LiczbaZespolona(0.76, 0.68);
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Podziel(5, 10).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Podziel(5, 10).PobierzZespolona());

            liczbazespolona = new LiczbaZespolona(3, 6);
            wynik = new LiczbaZespolona(2.4, 3);
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Podziel(2, 1).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Podziel(2, 1).PobierzZespolona());

            wynik = new LiczbaZespolona(0, -1.8);
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Podziel(-2, 1).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Podziel(-2, 1).PobierzZespolona());

            wynik = new LiczbaZespolona(-2.4, -3);
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Podziel(-2, -1).PobierzRzeczywista());
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Podziel(-2, -1).PobierzZespolona());


        }

        [TestMethod]
        [TestCategory("Divide")]
        [ExpectedException(typeof(DivideByZeroException)
            ,"Dzielenie przez 0!")
        ]
        public void PodzielTestWithException()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(5, 6);
            liczbazespolona.Podziel(0, 0);
        }

        [TestMethod]
        [TestCategory("Konwersja")]
        public void ToStringTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(5, 7);
            Assert.IsInstanceOfType(liczbazespolona, typeof(LiczbaZespolona));
            Assert.IsNotNull(liczbazespolona.ToString());
            Assert.IsInstanceOfType(liczbazespolona.ToString(), typeof(string));
            Assert.IsNotInstanceOfType(liczbazespolona.ToString(), typeof(double));
            Assert.IsNotInstanceOfType(liczbazespolona.ToString(), typeof(int));
            Assert.IsNotInstanceOfType(liczbazespolona.ToString(), typeof(LiczbaZespolona));

            Assert.AreEqual("5 + 7i",liczbazespolona.ToString());
            Assert.AreNotEqual("5+ 7i", liczbazespolona.ToString());
            Assert.AreNotEqual("5+7i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(-5, 27);
            Assert.AreEqual("-5 + 27i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(-11, 15);
            Assert.AreEqual("-11 + 15i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(-21, -20);
            Assert.AreEqual("-21 + -20i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(0, 2);
            Assert.AreEqual("2i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(0, -2);
            Assert.AreEqual("-2i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(3, 0);
            Assert.AreEqual("3", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(-3, 0);
            Assert.AreEqual("-3", liczbazespolona.ToString());

            //testowanie dla liczb typowo double
            liczbazespolona = new LiczbaZespolona(-5.23, 27.3);
            Assert.AreEqual("-5,23 + 27,3i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(-11.99, 15.8);
            Assert.AreEqual("-11,99 + 15,8i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(-21.56, -20.82);
            Assert.AreEqual("-21,56 + -20,82i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(0.23, 2.7);
            Assert.AreEqual("0,23 + 2,7i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(0, -2.921);
            Assert.AreEqual("-2,921i", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(3.43, 0);
            Assert.AreEqual("3,43", liczbazespolona.ToString());

            liczbazespolona = new LiczbaZespolona(-3.43, 0);
            Assert.AreEqual("-3,43", liczbazespolona.ToString());
        }
    }
}
