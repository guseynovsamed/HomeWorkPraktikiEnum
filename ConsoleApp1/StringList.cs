using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringList
    {

        private string[] _stringList;

        public StringList()
        {
            _stringList = new string[0];
        }

        public void Add(string item)
        {
            Array.Resize(ref _stringList, _stringList.Length + 1);
            _stringList[_stringList.Length - 1] = item;
        }

        public void GetAll()
        {
            foreach (string item in _stringList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
