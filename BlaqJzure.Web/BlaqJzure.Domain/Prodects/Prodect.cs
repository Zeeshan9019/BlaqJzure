using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaqJzure.Domain.Prodects
{
    public class Prodect : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
