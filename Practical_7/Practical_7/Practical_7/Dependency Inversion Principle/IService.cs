using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.Dependency_Inversion_Principle
{
    interface IService
    {
        public void Save();
        public void Read();
        public void Delete();
    }
}
