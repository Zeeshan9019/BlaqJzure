using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaqJzure.Domain
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
