using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FitnessContext db = new FitnessContext())
            {
                try
                {
                    //Lab9.CreateModels();

                    //Lab9.C("Artyom", 28);
                    //Lab9.R();
                    //Lab9.U(2);
                    //Lab9.D(7);



                }
                catch (Exception e)
                {
                    Console.WriteLine(e);   
                }

                Console.WriteLine("!!!");
                Console.ReadKey();

                //// вывод 
                //foreach (Client pl in db.Clients.Include(p => p.Plan))
                //    Console.WriteLine("{0} - {1}", pl.Name, pl.Plan != null ? pl.Plan.Name : "");
                //Console.WriteLine();
                //foreach (Plan t in db.  Plans.Include(t => t.Players))
                //{
                //    Console.WriteLine("Команда: {0}", t.Name);
                //    foreach (Client pl in t.Clients)
                //    {
                //        Console.WriteLine("{0} - {1}", pl.Name, pl.Age);
                //    }
                //    Console.WriteLine();
                //}
            }
        }
    }
}
