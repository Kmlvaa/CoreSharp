//upcasting & downcasting sadece miras alma zamani bash vere bilir ( bir class basga bir classdan miras almalidir)

using Casting;

//Person person = new Person("Samira");

//Student student = new Student("Konul", 100);

//Person st = new Student("Murad", 90);
//upcasting(boxing), burada yaddasda Student objecti yaranir amma bir ona person olaraq baxiriq (mesel ucun st.Name access ede bilerik, lakin st.Grade accesimiz yoxdur, cunki biz ona person kimi baxiriq


//student ve employee her ikiside bir person olduguna gore Person[] yaradib elave etmek olar:
//Employee employee = new Employee("Samira", 3800);
//Student student1 = new Student("Konul", 90);

//Person[] people = new Person[] { employee, student1 };

//foreach (var p in people)
//{
//    Console.WriteLine(p.GetInfo()); //GetInfo methodu polimorphism ile override olunduguna gore burada ferqli melumatlar goruruk
//    //burada sadece personda olan prop ve methodlara access ede bilerik (cunki persona upcast olunub)
//}


//Downcasting
Person st = new Student("Samira", 100);
Person emp = new Employee("Samira", 2000);

Employee emp1 = (Employee)emp; //bu process downcasting adlanir, normalda emp1 = emp yazmaq olmaz, cunki ferqli tiplerdedir(Employee, Person)
emp1.Salary = 3000;

/*Student stud = (Student)emp; *///Bu kod bize exception qaytaracaq, cunki person kimi baxdigimiz employeeni Studente downcast etmeye calisiriq
//Burda yaranan exceptionu handle etmeyin 3 yolu var: try catch, is, as 

// BIRINCI YOL:
try
{
    Person emp3 = new Employee("Samira", 2000);

    Student emp4 = (Student)emp3;
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong!");
}
// IKINCI YOL:
Person emp5 = new Employee("Samira", 2000);

if (emp5 is Student)
{
    Student emp6 = (Student)emp5;
}

//UCUNCU YOL:
Person empl = new Employee("Samira", 2000);

Student empl1 = empl as Student;

if(empl1 is null)
{
    Console.WriteLine("null");
}



#region Ref Out
int number = 5;
ShowNum(ref /*out*/ number);
Console.WriteLine(number);

void ShowNum(ref /*out*/ int num) //burada num'a referans type xususiyyetini menimsetdik, yeni numda olan deyisiklik numbere da olunacaq
{
    num = 10;
    Console.WriteLine(num);
}

//ref ve out eyni funksiyani yerine yetirir, ferqleri ondan ibaretdirki ref isletsek numbere mutleq en basda deyer menimsedilmelidir
//out da ise bu sert deyil, lakin outda argument kimi gonderilen methodun icerisinde deyer mutleq menimsedilmelidir
//array referance typedir, lakin bezen ref keywordu istifade olunur. buna sebeb initial deyerini mutleq teyin etmek lazimliligidir
#endregion