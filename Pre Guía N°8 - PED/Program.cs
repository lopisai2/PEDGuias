using System;
using System.Collections;
namespace Pre_Guía_N_8___PED
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable has = new Hashtable();
            has.Add("txt", "Programa notepad.exe");
            has.Add("bmp", "Programa paint.exe");
            has.Add("dib", "Programa paint.exe");
            has.Add("rtf", "Programa wordpad.exe");

            try
            {
                has.Add("txt", "Programa winword.exe");
            }
            catch (Exception)
            {

                Console.WriteLine("Un elemento con la clave =\"txt\" ya existe\n");
            }

            Console.WriteLine("Imprimimos un valor de la tabla usando la clave");
            Console.WriteLine("Para la clave \"rtf\", valor ={0}", has["rtf"] + "\n");

            //Cambiar nombre de xclavex
            has["rtf"] = "recortes.exe";
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Cambiando el valor asociado a la clave rtf");
            Console.WriteLine("Para la clave=\"rtf\", valor={0}.",has["rtf"]);
            Console.WriteLine("\n------------------------------------------");

            //Si no existe la clave, se puede agregar esta usando "add"
            has["doc"] = "winword.exe";
            //La función ContainsKey puede ser usada para comprobar si ya existe una clave
            if(!has.ContainsKey("ht"))
            {
                has.Add("ht", "hypertrm.exe");
                Console.WriteLine("Valor agregado para=\"ht\":{0}", has["ht"]);
                Console.WriteLine("-----------------------------------------");              
            }
            ICollection valueColl = has.Values;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Imprimiendo sólo valores de la tabla");

            foreach (string s in valueColl)
            {
                Console.WriteLine("Value={0}", s);
            }


            //Solo obteniendo las claves, usando ICollection para crear una coleccion a partir de las claves de la tabla
            ICollection keyColl = has.Keys;
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Imprimiendo solo llaves de la tabla");
            foreach(string s in keyColl)
            {
                Console.WriteLine("Value={0}", s);
            }

            //Quitar elementos de la tabla hash sama

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Remover Claves");
            Console.WriteLine("\nRemover(\"doc\")"); has.Remove("doc");
            Console.WriteLine("------");
            Console.WriteLine("\n Después se verifica si la clave aún existe dentro de la tabla");
            if(!has.ContainsKey("doc"))
            {
                Console.WriteLine("Clave\"doc\" no encontrada.");
            }
            Console.WriteLine("-----------------------------------------");
            Console.ReadLine();

        }

       
    }
}
