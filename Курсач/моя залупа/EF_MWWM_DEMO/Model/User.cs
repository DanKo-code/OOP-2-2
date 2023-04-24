using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MWWM_DEMO.Model
{
    public class User
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int SurName { get; set; }
        public int Phone { get; set; }
        public int PositionId { get; set; }
        public virtual Position? Position { get; set; }
    }
}
