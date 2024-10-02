using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BCustomer
    {
        public List<Products> Get()
        {
            DCustomer dCustomer = new DCustomer();
            return dCustomer.Get();
        }
    }
}
