using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_1
{
    public class ArrayList<T> : IReadOnlyList<T>
    {
        private int _counter;
        private int _initSize;
        private int _position;
        private T[] _arrayList;

        public ArrayList()
        {
            _counter = 0;
            _initSize = 5;
            _position = -1;
            _arrayList = new T[_initSize];
        }

        public ArrayList(int initSize)
        {            
            _counter = 0;
            _initSize = initSize;
            _position = -1;
            _arrayList = new T[_initSize];            
        }

        public int Capacity => _arrayList.Length;
        public int Count => _counter;

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _counter)
                {
                    return _arrayList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
            }
            set
            {
                if (index >= 0 && index < _counter)
                {
                    _arrayList[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
            }
        }

        public bool Add(T item)
        {
            if (item == null)
            {
                return false;
            }

            CheckCapacity(_counter);
            _arrayList[_counter++] = item;

            return true;
        }

        public bool AddRange(T[] items)
        {
            if (items == null)
            {
                return false;
            }

            CheckCapacity(_counter + items.Length);

            for (int i = 0; i < items.Length; i++)
            {
                _arrayList[_counter++] = items[i];
            }

            return true;
        }
        
        public bool Remove(T item)
        {
            if (item == null)
            {
                return false;
            }

            var isSuccess = false;

            for (int i = 0; i < _counter; i++)
            {
                if (_arrayList[i].Equals(item))
                {
                    isSuccess = true;

                    for (int j = i; j < _counter - 1; j++)
                    {
                        _arrayList[j] = _arrayList[j + 1];
                    }

                    _arrayList[--_counter] = default(T);
                    CheckCapacity();
                }
            }

            if (!isSuccess)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine($"{GetType().Name[0..^2]}<{typeof(T).Name}>.Remove: There is no item with value \"{item}\"");
            }

            return isSuccess;
        }
        public bool RemoveAt(int index)
        {
            var isSuccess = false;

            if (index >= 0 && index < _counter)
            {
                isSuccess = true;

                for (int i = index; i < _counter - 1; i++)
                {
                    _arrayList[i] = _arrayList[i + 1];
                }

                _arrayList[--_counter] = default(T);
                CheckCapacity();
            }

            if (!isSuccess)
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine($"{GetType().Name[0..^2]}<{typeof(T).Name}>.RemoveAt: There is no item with index \"{index}\"");
            }

            return isSuccess;
        }
        public void Sort()
        {
            Array.Sort(_arrayList, 0, _counter);
        }
       

        public void Reset()
        {
            _position = -1;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            while (true)
            {
                if (_position < _counter - 1)
                {
                    yield return _arrayList[++_position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }

        private void CheckCapacity(int count)
        {
            while (count >= _arrayList.Length)
            {
                Array.Resize(ref _arrayList, _arrayList.Length * 2);
            }
        }

        private void CheckCapacity()
        {
            while (_counter < _arrayList.Length / 2)
            {
                Array.Resize(ref _arrayList, _arrayList.Length / 2);
            }
        }
    }
}
