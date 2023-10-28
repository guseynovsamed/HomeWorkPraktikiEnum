using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DataList<T> where T : class
    {
        private T[] _dataList;

        public DataList()
        {
            _dataList = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref  _dataList, _dataList.Length+1);
            _dataList[_dataList.Length-1] = item;
        }

        public void GetAll()
        {
            foreach (T item in _dataList)
            {
                Console.WriteLine(item);
            }
        }

        public T[] GetAllStu()
        {
            return _dataList;
        }
    }
}
