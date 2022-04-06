using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.Dependency_Inversion_Principle
{
    class CacheOrderService : IService
    {
        #region IService Members
        public void Delete()
        {
            Console.WriteLine("Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Read");
        }

        public void Save()
        {
            Console.WriteLine("Save..");
        }
        #endregion
    }
}
