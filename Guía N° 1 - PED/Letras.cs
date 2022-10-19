using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guía_N__1___PED
{
    public class Letras
    {        
        public string conversionenletras(string ennumeros)
        {           
            string decimales=null, res;
           double entero, decimal1;
            double numeros;
            try
            {
                numeros = Convert.ToDouble(ennumeros);
            }
            catch (Exception)
            {

                return null;
            }
            entero = Convert.ToInt32(Math.Truncate(numeros));
            decimal1=Convert.ToInt32(Math.Round((numeros-entero)*100,2));
            //Temp
            if(decimal1>0)
            {
                decimales = " punto "+letras(decimal1);
                res = letras(numeros) + decimales;
                return res;
            }
            res = letras(numeros);
            return res;
        }
        
        public string letras(double num)
        {
            try
            {
                
                string letra = null;
                num = Math.Truncate(num);
                //if (num < 0)
                  //  letra = "Menos" + letras(num*-1);
                if (num == 0)
                    letra = "Cero";
                else if (num == 1)
                    letra = "uno";
                else if (num == 2)
                    letra = "dos";
                else if (num == 3)
                    letra = "tres";
                else if (num == 4)
                    letra = "cuatro";
                else if (num == 5)
                    letra = "cinco";
                else if (num == 6)
                    letra = "seis";
                else if (num == 7)
                    letra = "siete";
                else if (num == 8)
                    letra = "ocho";
                else if (num == 9)
                    letra = "nueve";
                else if (num == 10)
                    letra = "diez";
                else if (num == 11)
                    letra = "once";
                else if (num == 12)
                    letra = "doce";
                else if (num == 13)
                    letra = "trece";
                else if (num == 14)
                    letra = "catorce";
                else if (num == 15)
                    letra = "quince";
                else if (num < 20)
                    letra = "dieci" + letras(num - 10);
                else if (num == 20)
                    letra = "veinte";
                else if (num < 30)
                    letra = "venti" + letras(num - 20);
                else if (num == 30)
                    letra = "treinta";
                else if (num == 40)
                    letra = "cuarenta";
                else if (num == 50)
                    letra = "cincuenta";
                else if (num == 60)
                    letra = "sesenta";
                else if (num == 70)
                    letra = "setenta";
                else if (num == 80)
                    letra = "ochenta";
                else if (num == 90)
                    letra = "noventa";
                else if (num < 100)
                    letra = letras(Math.Truncate(num / 10) * 10) + " y " + letras(num % 10);
                else if (num == 100)
                    letra = "cien";
                else if (num < 200)
                    letra = "ciento " + letras(num - 100);
                else if ((num == 200) || (num == 300) || (num == 400) || (num == 600) || (num == 800))
                    letra = letras(Math.Truncate(num / 100)) + "cientos";
                else if (num == 500)
                    letra = "quinientos";
                else if (num == 700)
                    letra = "setecientos";
                else if (num == 900)
                    letra = "novecientos";
                else if (num < 1000)
                    letra = letras(Math.Truncate(num / 100) * 100) + " " + letras(num % 100);
                else if (num == 1000)
                    letra = "mil";
                else if (num < 2000)
                    letra = "mil " + letras(num % 1000);
                else if (num < 1000000)
                {
                    letra = letras(Math.Truncate(num / 1000)) + " mil";
                    if ((num % 1000) > 0)
                        letra = letra + " " + letras(num % 1000);
                }
                else if (num == 1000000)
                    letra = "un millon";
                else if(num<2000000)
                    letra="un millon "+letras(num%1000000);
                else if(num<1000000000000)
                {
                    letra = letras(Math.Truncate(num / 1000000)) + " millones ";
                    if (((num - Math.Truncate(num / 1000000)) * 1000000) > 0)
                        letra = letra + letras(num - Math.Truncate(num % 1000000) * 1000000);
                }
                    return letra;
            }
            catch (Exception A)
            {
                throw new Exception(A.Message);
                
            }
           
        }
    }
}
