using File;
using Newtonsoft.Json;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "C:\\Users\\Smre\\Desktop\\bck";
            ////Directory.CreateDirectory("C:\\Users\\Smre\\Desktop\\bck");

            ////File.Create(path + @"\xxx.txt"); 

            ////StreamWriter streamWriter = new StreamWriter(path + @"\sss.txt");
            ////streamWriter.WriteLine("koerie");
            ////streamWriter.Close(); // close etmesek connection aciq qalir ve garbage collector terefinden silinir

            //using(StreamWriter sw = new StreamWriter(path + @"\sss.txt", true)) // true versek append edecek vermesek override edecek
            //{
            //    sw.WriteLine("using scope"); //using scopu icinde yazilan seyler scope daxilinde qalir ve scope baglananda bitir
            //    //streamwriter esasen scope ile yazilir
            //}

            //string result;
            //using (StreamReader sr = new StreamReader(path + @"\sss.txt"))
            //{
            //    result = sr.ReadToEnd(); //File daxilini oxuyur
            //}
            //Console.WriteLine(result);



            //Front ve back arasinda elaqe quran data novu JSON-dur. 
            //Product product = new Product()
            //{
            //    Id = 1,
            //    Name = "Product1",
            //};

            ////product objecti json formata cevirmek:
            //var json = JsonConvert.SerializeObject(product);

            //string path = "C:\\Users\\Smre\\Desktop\\C#\\File\\File\\";

            //using(StreamWriter sw = new StreamWriter(path + @"object.json", true))
            //{
            //    sw.WriteLine(json);
            //}

            //string result;

            //using (StreamReader sr = new StreamReader(path + @"object.json"))
            //{
            //    result = sr.ReadToEnd();
            //}

            //Console.WriteLine(result); //json formatda qaytaracaq datani
            //Product pr = JsonConvert.DeserializeObject<Product>(result); //deserialize edirik obj formatina
            //Console.WriteLine(pr.Name);



            //Task
            Product pr1 = new Product("Mebel");
            Product pr2 = new Product("Aksessuar");
            Product pr3 = new Product("Computer");
            Product pr4 = new Product("Car");

            List<Product> products = new List<Product>();
            products.Add(pr1);
            products.Add(pr2);
            products.Add(pr3);
            products.Add(pr4);

            using (StreamWriter sw = new StreamWriter("C:\\Users\\Smre\\Desktop\\C#\\File\\File\\storeList.json"))
            {
                var json = JsonConvert.SerializeObject(products);
                sw.WriteLine(json);
            }

            string result;
            using(StreamReader sr = new StreamReader("C:\\Users\\Smre\\Desktop\\C#\\File\\File\\storeList.json"))
            {
                result = sr.ReadToEnd();
            }

            var jsonObj = JsonConvert.DeserializeObject<List<Product>>(result);

            foreach(var item in jsonObj)
            {
                Console.WriteLine(item.Code);
            }
        }
    }
}
