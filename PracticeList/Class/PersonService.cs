using PracticeList.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeList.Class
{
    public class PersonService : IHumanResources
    {
        private readonly List<Person> _people = new List<Person>();
        public PersonService()
        {
            _people = new List<Person>();
        }

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public void GetAll()
        {
            if(! _people.Any())
            {
                Console.WriteLine("No people found.");
                return;
            }
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
