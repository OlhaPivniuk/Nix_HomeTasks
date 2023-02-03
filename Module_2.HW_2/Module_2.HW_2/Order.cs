using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_2
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public User User { get; private set; }               
        public string Address { get; set; }        
        public string Phone { get; set; }        
        public string Email { get; set; }        
        public decimal Total { get; set; }       
        public List<OrderDetail> OrderDetails { get; set; }
    }
    public class OrderDetail
    {
        public int OrderLineId { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
    }
}

