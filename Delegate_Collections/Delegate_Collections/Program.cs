namespace Delegate_Collections
{
    internal class Program
    {
        internal delegate bool CheckNumbers(int num);
        //internal delegate void StringMethods(string s);
        internal delegate void StringMethods<T>(T s); //generic
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 5 };
            //FindSum(array, CheckOdd);

            //StringMethods<string> method = StringToUpper;
            //method += StringToLower;

            //method += delegate (string s) //anonim delegate method
            //{
            //    Console.WriteLine(s.Length);
            //};

            //method += x => Console.WriteLine(x); //lambda expression

            //method("SALam");
            ///*method.Invoke("Code");*/ //middleware da istifade olunur


            ////Delegate methods
            //Action<string> action = StringToLower; //action 16a qeder parameter qebul ede bilir ve void qaytarir
            //Func<string, string> func = x => x.ToLower(); //17 overloadi var, 16 parameter tipi, 1 return tipi. Eger 1 tip varsa bu returndur
            //Predicate<string> predicate = x => true; //yanliz 1 deyer qebul edir ve bool qaytarir


            //Dictionary
            //Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            //keyValuePairs.Add("a", "salam, sagol");
            //keyValuePairs.Add("b", "sabah, axsam");
            //keyValuePairs.Add("c", "gece, gunduz");
            //bool result = keyValuePairs.TryAdd("d", "assa,kewik");

            //if (result)Console.WriteLine("Added");
            //else Console.WriteLine("Not Added");

            //foreach (var (key, value) in keyValuePairs)
            //{
            //    Console.WriteLine($"Key: {key} || Value: {value}");
            //}

            //Stack
            Stack<DateTime> stack = new Stack<DateTime>();
            stack.Push(DateTime.Now);
            stack.Push(new DateTime(2024, 10, 10));
            stack.Push(new DateTime(2023, 5, 12));

            Console.WriteLine($"cixarildi: {stack.Pop()}"); // en son elave olnani silir
            Console.WriteLine($"novbeti mehsul: {stack.Peek()}"); //en son elave olunani gosterir


            //IList - interface
            IList<string> strings = new List<string>(); //list upcasting

        }

        static void StringToUpper(string s)
        {
            Console.WriteLine(s.ToUpper());
        }

        static void StringToLower(string s)
        {
            Console.WriteLine(s.ToLower());
        }


        //static void FindSum(int[] numbers, CheckNumbers function)
        //{
        //    int sum = 0;
        //    foreach (int i in numbers)
        //    {
        //        if (function(i))
        //        {
        //            sum += i;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}
        //static bool CheckOdd(int num)
        //{
        //    return (num % 2 != 0);
        //}
        //static bool CheckEven(int num)
        //{
        //    return (num % 2 == 0);
        //}
    }
}
