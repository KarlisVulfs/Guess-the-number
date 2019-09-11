using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spele__atmini_skaitli
{
    class Program
    {
        static void Main(string[] args)
        {
            Atminiskaitli();
            Console.Read();
        }       
        static void Atminiskaitli()
        {       //1. definejiet minamo skaitli 
                int[] iespejamieskaitli = { 123, 321, 12, 14, 69 };
                int pozicija = new Random().Next(iespejamieskaitli.Length);
                int mainamais = iespejamieskaitli[pozicija];
                            
                // int minamais = new Random().Next(100);
                                          
                while (true)
                {//2. vaicajiet ievadīt skaitli
                    Console.Write(" Ievadi skaitli: ");
                    int skaitlis = int.Parse(Console.ReadLine());

                    if (skaitlis == mainamais)
                    {
                        Console.WriteLine(" Skaitlis ir atminets");
                        break;

                    }
                    //3. salīdzināt ievadīto skaitli ar minamo skaitli
                    //3.1 ja ievadīta vertiba ir mazaka vai lielaka, attelojiet attiecigo pazinojumu
                    //3.2 ja ievadita vertiba sakrit ar minamo tad skaitllis ir atminets
                    else if (skaitlis < mainamais)
                    {
                        Console.WriteLine(" Megini lielaku vertibu");
                    }
                    else
                    {
                        Console.WriteLine(" Megini mazaku vertibu");
                    }
                    ///4. atkartot soli nr 3 lidz izpildas nosacijums 3.2
                }
            

        }
    }
}

