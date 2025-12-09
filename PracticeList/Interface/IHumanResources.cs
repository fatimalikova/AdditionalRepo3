using PracticeList.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeList.Interface
{
    public interface IHumanResources
    {
        void Add(Person person);
        void Remove(int Id);
        void GetAll();
    }
}
