using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCoreMVC.Models
{
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public int OrderNumber { get; set; }
        public Nullable<int> PersonID { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
