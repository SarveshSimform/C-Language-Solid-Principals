using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.Dependency_Inversion_Principle
{
    class OrderProcesser
    {
       
        IService service;
       
        public OrderProcesser(IService service)
        {
            this.service = service;
        }
        public void Process()
        {
            service.Save();
            service.Read();
            service.Delete();
        }
    }
}
