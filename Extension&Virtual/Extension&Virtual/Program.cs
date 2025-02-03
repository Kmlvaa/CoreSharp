using Extension_Virtual.DTOs;
using Extension_Virtual.Exceptions;
using Extension_Virtual.Helper;

namespace Extension_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Virtual & Override
            //Person person = new("Samira", "Kamilova");
            //Student student = new("Konul", "Kamilova", 87);
            //Developer dev = new("Konul", "Kamilova", 1200);
            //BackendDeveloper backDev = new("Konul", "Kamilova", 2380, "Senoir");

            //Console.WriteLine(person.GetInfo());
            //Console.WriteLine(student.GetInfo());
            //Console.WriteLine(dev.GetInfo());
            //Console.WriteLine(backDev.GetInfo());

            //Person[] people = new Person[] {person, student};
            //foreach(var p in  people)
            //{
            //    Console.WriteLine(p.GetInfo());
            //}
            //#endregion

            //#region Custom Extension
            //int id = 29;

            //Console.WriteLine(id.IsEven());
            //#endregion

            #region Exceptions
            Student st1 = new("Samira", "Kamilova", 99);
            Student st2 = new("Konul", "Abbasova", 70);
            Student st3 = new("Murad", "Haci", 85);

            Classroom classroom = new("P335", 2);

            try
            {
                classroom.AddStudent(st1);
                classroom.AddStudent(st2);
                //classroom.AddStudent(st3);
                classroom.AddStudent(null);

                foreach (var p in classroom.Students)
                {
                    Console.WriteLine(p.GetInfo());
                }

            }
            catch (StudentLimitException ex)
            {
                ErrorResponseDTO dto = new ErrorResponseDTO();
                dto.StatusCode = 402;
                dto.Message = ex.Message;
                Console.WriteLine($"StatusCode: {dto.StatusCode} - {dto.Message}");
            }
            catch (ArgumentNullException ex)
            {
                ErrorResponseDTO dto = new ErrorResponseDTO();
                dto.StatusCode = 400;
                dto.Message = ex.Message;
                Console.WriteLine($"StatusCode: {dto.StatusCode} - {dto.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong with your shitty code!");
            }
            finally
            {
                Console.WriteLine("Program finished!");
            }
            #endregion

            #region Indexer
            classroom.Students[0].Name = "Someone";

            classroom[0].Name = "Leyla"; //indexer istifade ederek yuxari setirdeki kodu bu formada qisaldib yazmaq mumkundur

            Console.WriteLine(classroom[0].GetInfo());
            #endregion
        }
    }
}
