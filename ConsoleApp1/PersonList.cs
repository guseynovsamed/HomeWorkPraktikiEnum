using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PersonList
    {
        private Person[] _personList;

        public PersonList()
        {
            _personList = new Person[0];
        }

        public void Add(Person person)
        {
            Array.Resize(ref _personList, _personList.Length+1);
            _personList[_personList.Length-1] = person;
        }

        public void GettAll()
        {
            foreach (var item in _personList)
            {
                Console.WriteLine(item.Name+" "+item.Surname);
            }
        }
    }
}
