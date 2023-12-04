//using Assignment_26;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;

//namespace SeriDesiBinaXml
//{
//    internal class Program
//    {
//       static void Main(string[] args)
//       {
//          Employee Emp = new Employee
//          {    
//               Id = 1,
//               FirstName = "kota",
//               LastName = "priyanka",
//               Salary = 50000.0
//          };
//           IFormatter formatter = new BinaryFormatter();
//            Stream stream = new FileStream(@"C:\Users\kotap\OneDrive\Desktop\simpli learn Assignments\Assignment 26\Assignment 26\EmployeeData.txt", FileMode.Create, FileAccess.Write);
//            formatter.Serialize(stream, Emp);
//            stream.Close();
//            stream = new FileStream(@"C:\Users\kotap\OneDrive\Desktop\simpli learn Assignments\Assignment 26\Assignment 26\EmployeeData.txt", FileMode.Open, FileAccess.Read);
//            Employee objnew = (Employee)formatter.Deserialize(stream);
//            Console.WriteLine(Emp.Id);
//            Console.WriteLine(Emp.FirstName);
//            Console.WriteLine(Emp.LastName);
//            Console.WriteLine(Emp.Salary);
//           Console.ReadKey();
//        }
//}


using System;
using System.IO;
using System.Xml.Serialization;

namespace SeriDesiBinaXml
{

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Employee Emp = new Employee
            {
                Id = 1,
                FirstName = "kota",
                LastName = "priyanka",
                Salary = 50000.0
            };

            // Serialize the employee object to XML
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("employee.xml"))
            {
                serializer.Serialize(writer, Emp);
            }
            //Descrialize the object from XML
            Employee deserializedEmp;
            using (TextReader reader = new StreamReader("employee.xml"))
            {
                deserializedEmp = (Employee)serializer.Deserialize(reader);
            }

            // Accessing the properties of deserializedEmployee
            Console.WriteLine(deserializedEmp.Id);
            Console.WriteLine(deserializedEmp.FirstName);
            Console.WriteLine(deserializedEmp.LastName);
            Console.WriteLine(deserializedEmp.Salary);
            Console.ReadKey();
        }
    }
}
       