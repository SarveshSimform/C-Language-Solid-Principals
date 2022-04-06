using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.Interface_Segregation_Principle
{
    class DbOrderSaveService : IOrderSave
    {
        #region IOrderSave Members
        public void Save()
        {
            Console.WriteLine("Order is Saved in DataBase..!");
        }
        #endregion
    }
}
