using ExceptionsTask.DTOs;
using ExceptionsTask.Exceptions;

namespace ExceptionsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product book = new Book("Cerpeleng Ucuran", 23.99M, "Xalid Huseyni", 328)
            {
                Count = 3
            };
            Product book1 = new Book("Qumarbaz", 12.2M, "Xalid Huseyni", 328)
            {
                Count = 3
            };
            Product book2 = new Book("14cu adam", 43.99M, "Xalid Huseyni", 328)
            {
                Count = 3
            };
            //Console.WriteLine(book.ShowInfo());
             
            Stock stock = new Stock(10);

            try
            {
                //book.Sell(book);

                stock.AddProduct(book);
                stock.AddProduct(book1);
                stock.AddProduct(book2);

                //stock.GetBookById(1);

                var list = stock.GetAllBooks();

                foreach(var item in list)
                {
                    Console.WriteLine($"ID: {item.Id} | Name: {item.Name}");
                }

                Console.WriteLine(stock.RemoveById(5).ShowInfo());

                var list2 = stock.GetAllBooks();

                foreach (var item in list2)
                {
                    Console.WriteLine($"ID: {item.Id} | Name: {item.Name}");
                }

            }
            catch(NotFoundException ex)
            {
                ErrorResultDTO errorResultDTO = new ErrorResultDTO();
                errorResultDTO.Message = ex.Message;
                errorResultDTO.StatusCode = 402;

                Console.WriteLine($"Status Code: {errorResultDTO.StatusCode} || Message: {errorResultDTO.Message}");
            }
            catch(ProductCountisZeroException ex)
            {
                ErrorResultDTO errorResultDTO = new ErrorResultDTO();
                errorResultDTO.Message = ex.Message;
                errorResultDTO.StatusCode = 404;

                Console.WriteLine($"Status Code: {errorResultDTO.StatusCode} || Message: {errorResultDTO.Message}");
            }
            catch(CapacityLimitException ex)
            {
                ErrorResultDTO dto = new ErrorResultDTO();
                dto.Message = ex.Message;
                dto.StatusCode = 401;
                Console.WriteLine($"Status Code: {dto.StatusCode} || Message: {dto.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
