using Lab9_EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_EF
{
    internal class Program
    {
        //Lab_9
        /*
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
        */

        //Lab_10
        static void Main(string[] args)
        {
            #region Repository
            EFGenericRepository<Client> clientRepo = new EFGenericRepository<Client>(new FitnessContext());

            IEnumerable<Client> clients = clientRepo.GetWithInclude(p => p.Plan);
            //IEnumerable<Client> clients = clientRepo.GetWithInclude(x => x.Plan.Name.StartsWith("S"), p => p.Company);
            foreach (Client p in clients)
            {
                Console.WriteLine($"{p.Name} ({p.Plan.Name}) - {p.Age}");
            }
            #endregion

            #region  Unit of Work
                
            #endregion

            Console.ReadLine();
        }
    }
}
