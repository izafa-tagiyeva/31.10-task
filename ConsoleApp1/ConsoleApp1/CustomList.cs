using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomList<T> 
    {
       
          static  public T[] _items= new T[4];
            public int _size;

       


            public CustomList()
            {
                _items = new T[4]; 
                _size = 0;
            }





            public void Add(T item)
            {
              
                if(_size >= _items.Length) {

                  _items.Length = 2 * _items.Length;
                 }
                if (_size < _items.Length)
                {
                    Array.Resize(ref _items, _size+1);
                    _items[_size-1] = item;
                }
               
            }


           
            public bool Remove(T item)
            {
                for (int i = 0; i < _size; i++)
                {
                    if (_items[i].Equals(item))
                    {
                        for (int j = i; j < _size - 1; j++)
                        {
                            _items[j] = _items[j + 1];
                        }
                        _size--;
                        return true;
                    }
                }
                return false;
            }


           //public Insert()


             public static T Find(Predicate<T> predicate)
             {
           
                foreach (T item in _items)
                 {
                     if (predicate(item))
                       {
                         return item;
                       }
                }
                 return default;
             }

        public static List<T> FindAll(T[] _item, T required)
        {
            List<T> list = new List<T>();
            foreach (T item in _item)
            {

                if (required.Equals(item))
                {
                    list.Add(item);
                    return list;
                }
              
            }
            return list;
        }

      
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       
   
        public static T FisrtOrDefault(T[] _item, T required)
        {

            foreach (T item in _item)
            {
                if (required.Equals(item))
                {
                    return item;
                    break;
                }
            }
            return default;
        }


        public static int FistIndex(T[] _item, T required)
        {

            for (int i = 0; i < _item.Length; i++)
            {
                if(_item[i].Equals(required))
                {
                    return i;
                    break;
                }
            }

            return -1;
        }



        public static int LastIndex(T[] _item, T required)
        {

            for (int i = _item.Length; i >0; i--)
            {
                if (_item[i].Equals(required))
                {
                    return i;
                    break;
                }
            }

            return -1;
        }

        public static bool Contains(T[] _item, T required)
        {
            bool result=false;
            for (int i = 0; i < _item.Length; i++)
            {
                if (_item[i].Equals(required))
                {

                    result = true;
                    return result;
                }
                else return result=false;
            }
            return result;
        }




    }


}

//generic olmaldir, icerisinde t tipinden bir array saxlamalidir,


/*When you add an item to the list and there's no room left (i.e., the array is full), the list creates a new,\
 larger array, copies all the elements from the old array into the new array, and then adds the new element.
 This new array is usually twice the size of the old one to optimize performance.*/