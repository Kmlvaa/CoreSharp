namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("hello");
            list.Add("2kakld");
            list.Add("3ofof");

            //Console.WriteLine(list.Remove("1"));
            //Console.WriteLine(list.Find(x => x == "2"));

            //Console.WriteLine(list.RemoveAll(x => x.Contains('o')));

            //foreach(var item in list.FindAll(x => x.Contains('o')))
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //List<int> ints = new List<int>();
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //int x = ints.Find(x => x == 3);
            //Console.WriteLine(x);


            //CUSTOM LIST


            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("salam");
            customList.Add("ohayo");
            customList.Add("hello");

            //Console.WriteLine("------------------------------");
            //CustomList<int> customList = new CustomList<int>();
            //customList.Add(1);
            //customList.Add(2);
            //customList.Add(3);
            //customList.Add(2);
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Added items:");
            //foreach (var item in customList.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Items after remove one:");
            //Console.WriteLine($"Removed item status: {customList.Remove(0)}");
            //foreach (var item in customList.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------------------------");

            //Console.WriteLine(customList.Find(2));

            //var removedItems = customList.RemoveAll(x => x == 3);

            //Console.WriteLine($"Count of removed items: {removedItems}");

            //foreach (var item in customList.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------------------------");

            foreach (var item in customList.FindAll(x => x.Contains('a')))
            {
                Console.WriteLine(item);
            }

        }
    }
}
