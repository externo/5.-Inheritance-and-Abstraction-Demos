using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Human__Student_and_Worker
{
    class DemoPeople
    {
        static void Main(string[] args)
        {
            Student gosho = new Student("gogo", "goshev", "pabass");
            Console.WriteLine(gosho.FirstName);
            Console.WriteLine(gosho.FullName());
            List<Student> students = new List<Student>
            {
                new Student("Gosho", "Petrov", "543232"),
                new Student("Peshko", "Petrov", "432132"),
                new Student("Rumen", "PetSpasov", "120924"),
                new Student("Slavi", "Trifonov", "609123"),
                new Student("Canko", "Cvetanov", "342982"),
                new Student("Dmitrij", "Medvedev", "901837"),
                new Student("Humpti", "Dumpti", "712102"),
                new Student("Rosen", "Plevneliev", "234311"),
                new Student("Toma", "Tomov", "810293"),
                new Student("Koce", "Lemevski", "655654")
            };
            List<Worker> workers = new List<Worker>
            {
                new Worker("Stilqn", "Ilievski", 456.8, 8),
                new Worker("Mario", "Pavlov", 560.4, 9),
                new Worker("Dobromir", "Jechev", 666.8, 8),
                new Worker("Aleko", "IliKonstantinov", 1102.1, 18),
                new Worker("Bai", "Ganio", 234.5, 12),
                new Worker("Yan", "Hus", 156.08, 6),
                new Worker("Yan", "Bibiyan", 556.1, 10),
                new Worker("Trebien", "Gutenmorgenov", 991.2, 11),
                new Worker("Debian", "Umov", 713, 7),
                new Worker("Stamen", "Kocev", 808, 13)
            };
            var studentsOrderedByFacultyNumber = students.OrderBy(x => x.FacultyNumber).ToList();
            var workersOrderedByPaymentByHour = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();
            //Console.WriteLine(studentsOrderedByFacultyNumber.GetType()+ "  "+ workersOrderedByPaymentByHour.GetType());

            List<Human> all = new List<Human> {  };
            all.AddRange(studentsOrderedByFacultyNumber);
            all.AddRange(workersOrderedByPaymentByHour);
            var allOrderedBy =
                from a in all
                orderby a.FirstName, a.LastName
                select a;
            foreach (var human in allOrderedBy)
            {
                Console.WriteLine(human.FirstName+" "+human.LastName);
            }
                
        }
    }
}
