using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.Interface_Segregation_Principle
{
    class CacheOrderSaveService : IOrderSave, IorderDelete, IOrderRead
    {
        #region IOrderSave IOrderRead IorderDelete Members
        public void Save()
        {
            Console.WriteLine("Order is Saved in DataBase..!");
        }
        public void Delete()
        {
            Console.WriteLine("Order is Deleted in DataBase..!");
        }

        public void Read()
        {
            Console.WriteLine("Order is Read in DataBase..!");
        }
        #endregion
    }
}
