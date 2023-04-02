using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_EF.Unit_of_Work
{
    public class ClientRepository : IRepository<Client>
    {
        private FitnessContext db;

        public ClientRepository(FitnessContext context)
        {
            this.db = context;
        }

        public IEnumerable<Client> GetAll()
        {
            return db.Clients.Include(o => o.Plan);
        }

        public Client Get(int id)
        {
            return db.Clients.Find(id);
        }

        public void Create(Client client)
        {
            db.Clients.Add(client);
        }

        public void Update(Client client)
        {
            db.Entry(client).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Client book = db.Clients.Find(id);
            if (book != null)
                db.Clients.Remove(book);
        }
    }
}
