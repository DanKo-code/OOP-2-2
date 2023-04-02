using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_EF
{
    public static class Lab9
    {
        public static void CreateModels()
        {
            using (FitnessContext db = new FitnessContext())
            {
                // создание и добавление моделей
                Plan p1 = new Plan { Name = "PowerLifting" };
                Plan p2 = new Plan { Name = "BodyBuilding" };
                db.Plans.Add(p1);
                db.Plans.Add(p2);
                db.SaveChanges();
                Client cl1 = new Client { Name = "Danila", Age = 19, Plan = p1 };
                Client cl2 = new Client { Name = "Nikita", Age = 25, Plan = p2 };
                Client cl3 = new Client { Name = "Sanya", Age = 32, Plan = p2 };
                db.Clients.AddRange(new List<Client> { cl1, cl2, cl3 });
                db.SaveChanges();
            }
        }

        public static void PrintInfo() 
        {
            using(FitnessContext db = new FitnessContext())
            {
                // хорошо понял пример Eager Loading
                //var clients = db.Clients.Include("Plan").ToList();

                //foreach (Client p in clients)
                //{
                //    Console.WriteLine(p.Plan.Name);
                //}

                //var plans = db.Plans.Include("Clients").ToList();
                var plans = db.Plans.ToList();
                foreach (var plan in plans) 
                {
                    Console.WriteLine(plan.Name);

                    foreach(var client in plan.Clients)
                    {
                        Console.WriteLine(client.Name + " " + client.Age);
                    }

                    Console.WriteLine();
                }
            }
        }

        public static void C(string name, int age)
        {
            using (FitnessContext db = new FitnessContext())
            {
                Client cl = new Client { Name = name, Age = age };
                db.Clients.Add(cl);
                db.SaveChanges();
            }
        }

        public static void R()
        {
            PrintInfo();
        }

        public static void U(int id)
        {
            using (FitnessContext db = new FitnessContext())
            {
                Client cl = db.Clients.Find(id);

                if(cl != null)
                {
                    cl.PlanId = 1;

                    db.SaveChanges();
                } 
            }
        }

        public static void D(int id)
        {
            using (FitnessContext db = new FitnessContext())
            {
                Client cl = db.Clients.FindAsync(id).Result;

                if (cl != null)
                {
                    db.Clients.Remove(cl);

                    db.SaveChanges();
                }
            }
        }

        public static void Sort(string name, int age = 0)
        {
            using (FitnessContext db = new FitnessContext())
            {
                if (age == 0)
                {
                    var clients = db.Clients.OrderBy(x => x.Name);

                    foreach(var client in clients)
                        Console.WriteLine("{0} {1}", client.Name, client.Age);
                }
                else
                {
                    var clients = db.Clients.OrderBy(x => x.Name).ThenBy(x=>x.Age);

                    foreach (var client in clients)
                        Console.WriteLine("{0} {1}", client.Name, client.Age);
                }

                db.SaveChangesAsync();
            }
        }

        public static void Search(string name, int age = 0)
        {
            using (FitnessContext db = new FitnessContext())
            {
                if (age == 0)
                {
                    var clients = db.Clients.Where(x => x.Name == name);

                    foreach (var client in clients)
                        Console.WriteLine("{0} {1}", client.Name, client.Age);
                }
                else
                {
                    var clients = db.Clients.Where(x => x.Name == name).Where(x => x.Age == age);

                    foreach (var client in clients)
                        Console.WriteLine("{0} {1}", client.Name, client.Age);
                }

                db.SaveChangesAsync();
            }
        }

        public static void Transact()
        {
            using (FitnessContext db = new FitnessContext())
            {

            }
        }
    }
}
