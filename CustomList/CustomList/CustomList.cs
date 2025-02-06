using System.Collections;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        //public Queue<T> Values;
        public T[] Values;
        public int ListLimit;

        public CustomList()
        {
            //Values = new Queue<T>();
            Values = new T[0];
        }

        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Can not add null.");
            }
            //Values.Enqueue(item);
            Array.Resize(ref Values, Values.Length + 1);
            Values[Values.Length - 1] = item;
        }
        public T Find(T item)
        {
            for (int i = 0; i < Values.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(Values[i], item))
                {
                    return Values[i];
                }
            }
            return default;
        }
        public T[] FindAll(Predicate<T> predicate)
        {
            T[] values = [];

            for(int i = 0; i < Values.Length; i++)
            {
                if (predicate(Values[i]))
                {
                    Array.Resize(ref values, values.Length + 1);
                    values[values.Length - 1] = Values[i];
                }
            }

            return values;
        }
        public bool Remove(T item)
        {
            T[] array = [];
            if (item == null) Console.WriteLine("Can not remove null");

            if(EqualityComparer<T>.Default.Equals(Find(item), item))
            {
                for(int i = 0; i < Values.Length; i++)
                {
                    if(EqualityComparer<T>.Default.Equals(Values[i], item))
                    {
                        continue;
                    }
                    else
                    {
                        Array.Resize<T>(ref array, array.Length + 1);
                        array[array.Length - 1] = Values[i];
                    }
                }
                Values = array;
                return true;
            }
            else return false;
        }
        public int RemoveAll(Predicate<T> predicate)
        {
            int count = 0;
            T[] values = [];

            foreach(T item in Values)
            {
                if (predicate(item))
                {
                    count++;
                }
                else
                {
                    Array.Resize<T>(ref values, values.Length + 1);
                    values[values.Length - 1] = item;
                }
            }
            Values = values;

            return count;
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
