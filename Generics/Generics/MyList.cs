using Generics.Common;
using System.Collections;

namespace Generics
{
    //<Type> -> normalda T isledilir type demekdir
    public class MyList<Type>
    /*public class MyList<Type, K> where Type : K //Iki type qebul edir, lakin 1ci 2ciden miras almalidir sherti ile */
    /* where Type : BaseEntity, IEmployee, new() // Her 3 shert odenmelidir*/
    /* where Type : class, IEmployee, new() // Type hem class olmali, hem Iemployeeden implement etmeli, hem de bosh constructoru olmalidir */
    /* where Type : new() // Minimum 1 parameterless constructoru olan classlari qebul edir*/
    /* where Type: BaseEntity // base entityden miras alanlari qebul edir*/
    /* where Type : class // ancaq class type qebul edir */
    /* where Type : class // ancaq class type qebul edir */
    /* where Type : IEmployee // ancaq IEmployee'den miras alan classlar qebul olunur */

    /* : IEnumerable<Type>*/ //Ienumerable MyListin iterate oluna bileceyini gostermek ucun islenilir 
    {
        private Type[] array;
        public MyList()
        {
            array = new Type[0];
        }

        public Type this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public void Add(Type value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
        }
        //public IEnumerator<Type> GetEnumerator() //Genericle isleyende Ienumerable ucunde type verilmelidir yoxsa object qaytaracaq
        //{
        //    foreach (var item in array)
        //    {
        //        yield return item;
        //    }
        //}
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
