using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_EF.Unit_of_Work
{
    public class PlanRepository : IRepository<Plan>
    {
        private FitnessContext db;

        public PlanRepository(FitnessContext context)
        {
            this.db = context;
        }

        public IEnumerable<Plan> GetAll()
        {
            return db.Plans.Include(o => o.Clients);
        }

        public Plan Get(int id)
        {
            return db.Plans.Find(id);
        }

        public void Create(Plan order)
        {
            db.Plans.Add(order);
        }

        public void Update(Plan order)
        {
            db.Entry(order).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Plan order = db.Plans.Find(id);
            if (order != null)
                db.Plans.Remove(order);
        }
    }
}
