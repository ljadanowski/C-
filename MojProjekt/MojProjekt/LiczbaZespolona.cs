using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//using java.math;
using Oracle.DataAccess.Client; 

namespace MojProjekt
{
    public class LiczbaZespolona
    {
        private double x;
        private double y;

        public LiczbaZespolona()
        {
            this.x = 0;
            this.y = 0;
        }

        public LiczbaZespolona(double x)
        {
            this.x = x;
            this.y = 0;
        }

        public LiczbaZespolona(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double PobierzRzeczywista()
        {
            return x;
        }

        public double PobierzZespolona()
        {
            return y;
        }

        public void UstawRzeczywista(double x)
        {
            this.x = x;
        }

        public void UstawZespolona(double y)
        {
            this.y = y;
        }

        public LiczbaZespolona Dodaj(double x, double y)
        {
            LiczbaZespolona nowa = new LiczbaZespolona();
            decimal a = Convert.ToDecimal(this.x) + Convert.ToDecimal(x);
            decimal b = Convert.ToDecimal(this.y) + Convert.ToDecimal(y);
            nowa.x = Convert.ToDouble(a);
            nowa.y = Convert.ToDouble(b);
            return nowa;
        }

        public LiczbaZespolona Odejmij(double x, double y)
        {
            LiczbaZespolona nowa = new LiczbaZespolona();
            decimal a = Convert.ToDecimal(this.x) - Convert.ToDecimal(x);
            decimal b = Convert.ToDecimal(this.y) - Convert.ToDecimal(y);
            nowa.x = Convert.ToDouble(a);
            nowa.y = Convert.ToDouble(b);
            return nowa;
        }

        public LiczbaZespolona Pomnoz(double x, double y)
        {
            LiczbaZespolona nowa = new LiczbaZespolona();
            nowa.x = this.x - x;
            nowa.y = this.y - y;
            return nowa;
        }

        public LiczbaZespolona Podziel(double x, double y)
        {
            LiczbaZespolona nowa = new LiczbaZespolona();
            try
            {
                if (x == 0 && y == 0) throw new DivideByZeroException("Dzielenie przez 0");
                nowa.x = (this.x * x + this.y * y) / (x * x + y * y);
                nowa.y = (this.y * x + this.x * y) / (x * x + y * y);
            }
            catch (DivideByZeroException ex)
            {
                throw;
            }
            
            
            return nowa;
        }

        public double ObliczModul()
        {
            return Math.Sqrt(Math.Pow(Convert.ToDouble(x), 2) + Math.Pow(Convert.ToDouble(y), 2));
        }

        public void Sprzezenie()
        {
            y *= (-1);
        }
        
        public override string ToString()
        {
            if (x == 0) return y + "i";
            else if (y == 0) return x + "";
            else return x + " + " + y + "i";
        }

        public bool Equals(LiczbaZespolona inna)
        {
            //var toCompareWith = inna as LiczbaZespolona;
            if (inna == null) return false;
            return this.x == inna.x &&
                   this.y == inna.y; 
        }
    }
}
