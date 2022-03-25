using System;

namespace UpCasting_DownCasting__Implicit_Explicit_operators__Operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }



        enum Currency
        {
            Eur,
            Usd,
            Try
        }
        public double Exchange(Currency[] name,double azn)
        {
            foreach (var item in name)
            {
                if (item == Currency.Eur  && item==Currency.Usd && item==Currency.Try)
                {


                    switch (switch_on)
                    {
                        case 0:
                            Currency.Usd* azn;

                            break;
                        
                    }
                }
            }
        }
    }
}
