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
            Assert.IsNotNull(liczbazespolona);
        }

        [TestCategory("Tworzenie obiektu")]
        [TestMethod]
        public void PrzypisanieWartosciRzeczywistaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            Assert.AreEqual(1.1, liczbazespolona.PobierzRzeczywista());
        }

        [TestCategory("Tworzenie obiektu")]
        [TestMethod]
        public void PrzypisanieWartosciUrojonaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            Assert.AreEqual(2.2, liczbazespolona.PobierzZespolona());
        }

        [TestCategory("Sprawdzanie instacji klasy")]
        [TestMethod]
        public void NotInstancjaKlasyTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-1.1, 2.2);
            Assert.IsNotInstanceOfType(liczbazespolona, typeof(double));
        }

        [TestCategory("Sprawdzanie instacji klasy")]
        [TestMethod]
        public void InstancjaKlasyTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-1.1, 2.2);
            Assert.IsInstanceOfType(liczbazespolona, typeof(LiczbaZespolona));
        }

        [TestCategory("Sprawdzanie instacji klasy")]
        [TestMethod]
        public void InstancjaKlasyDodajTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-1.1, 2.2);
            Assert.IsInstanceOfType(liczbazespolona.Dodaj(1.2, 2.3), typeof(LiczbaZespolona));
        }

        [TestCategory("Sprawdzanie instacji klasy")]
        [TestMethod]
        public void InstancjaKlasyOdejmijTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-1.1, 2.2);
            Assert.IsInstanceOfType(liczbazespolona.Odejmij(1.2, 2.3), typeof(LiczbaZespolona));
        }

        [TestCategory("Sprawdzanie instacji klasy")]
        [TestMethod]
        public void InstancjaKlasyPomnozTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-1.1, 2.2);
            Assert.IsInstanceOfType(liczbazespolona.Pomnoz(1.2, 2.3), typeof(LiczbaZespolona));
        }

        [TestCategory("Sprawdzanie instacji klasy")]
        [TestMethod]
        public void InstancjaKlasyPodzielTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-1.1, 2.2);
            Assert.IsInstanceOfType(liczbazespolona.Podziel(1.2, 2.3), typeof(LiczbaZespolona));
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieDodatnichTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(2.3,4.5);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Dodaj(1.2, 2.3)));
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieDodatnichNieprawidloweTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(2.3, 4.5);
            Assert.IsFalse(wynik.Equals(liczbazespolona.Dodaj(1.2, 2.30000000001)));
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieDodatnichRzeczywistaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(2.3, 4.5);
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Dodaj(1.2, 2.3).PobierzRzeczywista());
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieDodatnichUrojonaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(2.3, 4.5);
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Dodaj(1.2, 2.3).PobierzZespolona());
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieUjemnejTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(-0.1, 4.5);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Dodaj(-1.2, 2.3)));
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieUjemnejNiepoprawneTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(-0.1, 4.5);
            Assert.IsFalse(wynik.Equals(liczbazespolona.Dodaj(-1.2000000001, 2.3))); 
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieUjemnejRzeczywistaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(-0.1, 4.5);
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Dodaj(-1.2, 2.3).PobierzRzeczywista());
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieUjemnejUrojonaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(-0.1, 4.5);
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Dodaj(-1.2, 2.3).PobierzZespolona());
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieDwochUjemnychTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-0.532, -0.116);
            LiczbaZespolona wynik = new LiczbaZespolona(0.689, -2.448);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Dodaj(1.221, -2.332)));
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieDwochUjemnychRzeczywistaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-0.532, -0.116);
            LiczbaZespolona wynik = new LiczbaZespolona(0.689, -2.448);
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Dodaj(1.221, -2.332).PobierzRzeczywista());
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieDwochUjemnychUrojonaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-0.532, -0.116);
            LiczbaZespolona wynik = new LiczbaZespolona(0.689, -2.448);
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Dodaj(1.221, -2.332).PobierzZespolona());
        }

        [TestCategory("KalkulatorDodawanie")]
        [TestMethod]
        public void DodawanieZerTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(0, 0);
            LiczbaZespolona wynik = new LiczbaZespolona(0, 0);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Dodaj(0, 0)));
        }


        [TestCategory("KalkulatorOdemowanie")]
        [TestMethod]
        public void OdejmowanieDodatnichTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(-0.1, -0.1);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Odejmij(1.2, 2.3)));
        }

        [TestCategory("KalkulatorOdemowanie")]
        [TestMethod]
        public void OdejmowanieDodatnichNiepoprawneTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(-0.1, -0.1);
            Assert.IsFalse(wynik.Equals(liczbazespolona.Odejmij(1.2, 2.30000000001)));
        }

        [TestCategory("KalkulatorOdemowanie")]
        [TestMethod]
        public void OdejmowanieDodatnichRzeczywisteTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(-0.1, -0.1);
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Odejmij(1.2, 2.3).PobierzRzeczywista());
        }

        [TestCategory("KalkulatorOdemowanie")]
        [TestMethod]
        public void OdejmowanieDodatnichUrojoneTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(1.1, 2.2);
            LiczbaZespolona wynik = new LiczbaZespolona(-0.1, -0.1);
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Odejmij(1.2, 2.3).PobierzZespolona());
        }

        [TestCategory("KalkulatorOdemowanie")]
        [TestMethod]
        public void OdejmowanieUjemnejTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-543.43, 2.309);
            LiczbaZespolona wynik = new LiczbaZespolona(-542.23, 0.009);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Odejmij(-1.2, 2.3)));
        }

        [TestCategory("KalkulatorOdemowanie")]
        [TestMethod]
        public void OdejmowanieUjemnejRzeczywistaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-543.43, 2.309);
            LiczbaZespolona wynik = new LiczbaZespolona(-542.23, 0.009);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Odejmij(-1.2, 2.3)));
        }

        [TestCategory("KalkulatorOdemowanie")]
        [TestMethod]
        public void OdejmowanieUjemnejUrojonaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-543.43, 2.309);
            LiczbaZespolona wynik = new LiczbaZespolona(-542.23, 0.009);
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Odejmij(-1.2, 2.3).PobierzZespolona());
        }

        [TestCategory("KalkulatorOdemowanie")]
        [TestMethod]
        public void OdejmowanieDwieUjemnejTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-0.532, -0.116);
            LiczbaZespolona wynik = new LiczbaZespolona(-1.753, 2.216);
            Assert.IsTrue(wynik.Equals(liczbazespolona.Odejmij(1.221, -2.332)));
        }

        [TestCategory("KalkulatorOdemowanie")]
        [TestMethod]
        public void OdejmowanieDwieRzeczywistaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-0.532, -0.116);
            LiczbaZespolona wynik = new LiczbaZespolona(-1.753, 2.216);
            Assert.AreEqual(wynik.PobierzRzeczywista(), liczbazespolona.Odejmij(1.221, -2.332).PobierzRzeczywista());
        }

        [TestCategory("KalkulatorOdemowanie")]
        [TestMethod]
        public void OdejmowanieDwieUjemnejUrojonaTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-0.532, -0.116);
            LiczbaZespolona wynik = new LiczbaZespolona(-1.753, 2.216);
            Assert.AreEqual(wynik.PobierzZespolona(), liczbazespolona.Odejmij(1.221, -2.332).PobierzZespolona());
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
        [TestCategory("KalkulatorModul")]
        public void ObliczModulDwochDodatnichTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(3, 4);
            double wynik = 5;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());
        }

        [TestMethod]
        [TestCategory("KalkulatorModul")]
        public void ObliczModulDodatniejTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(2, 0);
            double wynik = 2;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());
        }

        [TestMethod]
        [TestCategory("KalkulatorModul")]
        public void ObliczModulUjemnejTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-2, 0);
            double wynik = 2;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());
        }

        [TestMethod]
        [TestCategory("KalkulatorModul")]
        public void ObliczModulDodatniejIUjemnejTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-5, 12);
            double wynik = 13;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());
        }

        [TestMethod]
        [TestCategory("KalkulatorModul")]
        public void ObliczModulDwochUjemnychTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-5, -12);
            double wynik = 13;
            Assert.AreEqual(wynik, liczbazespolona.ObliczModul());
        }

        [TestMethod]
        [TestCategory("KalkulatorModul")]
        public void ObliczModulNiepoprawnyTest()
        {
            LiczbaZespolona liczbazespolona = new LiczbaZespolona(-5, -12);
            double wynik = 14;
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
