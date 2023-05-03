using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CreatedBy
    {
        public int CreatedById { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Form> Forms { get; set; }
    }
}
