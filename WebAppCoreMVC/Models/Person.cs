using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCoreMVC.Models
{
    
    public partial class Person
    {
        public Person()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Nullable<int> Age { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
