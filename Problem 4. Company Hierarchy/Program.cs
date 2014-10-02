using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // create several sales 
            Sale dairy = new Sale("Milk", new DateTime(2014, 10, 1), 2.50m);
            Sale chocolate = new Sale("Chocolate", new DateTime(2014, 10, 1), 1.80m);
            Sale meat = new Sale("Meat", new DateTime(2014, 10, 1), 4.80m);
            Sale vegitables = new Sale("Vegitables", new DateTime(2014, 10, 1), 3.80m);
            Sale books = new Sale("C# Programming", new DateTime(2014, 10, 2), 9.90m);
            Sale laptop = new Sale("Toshiba Satelite", new DateTime(2014, 10, 2), 999.90m);
            Sale beer = new Sale("Stolichno tymno", new DateTime(2014, 10, 3), 1.75m);
            Sale whiskey = new Sale("Jameson", new DateTime(2014, 10, 3), 29.50m);

            // create several Sales lists
            var foodSales = new List<Sale>();
            foodSales.Add(dairy);
            foodSales.Add(chocolate);
            foodSales.Add(meat);
            foodSales.Add(vegitables);

            var otherSales = new List<Sale>();
            otherSales.Add(books);
            otherSales.Add(laptop);
            otherSales.Add(beer);
            otherSales.Add(whiskey);

            // create several projects
            Projects CSharp = new Projects("Accounting system", new DateTime(2014, 9, 15), "N/A");
            Projects Java = new Projects("Booking system", new DateTime(2014, 5, 13), "N/A");
            Projects PHP = new Projects("Database Center", new DateTime(2014, 8, 20), "N/A");
            Projects JavaScript = new Projects("On-line games", new DateTime(2014, 7, 28), "N/A");
            Projects HTML_CSS = new Projects("A fancy web-site", new DateTime(2014, 8, 8), "N/A");

            //create several projects lists
            var webProjects = new List<Projects>();
            webProjects.Add(HTML_CSS);
            webProjects.Add(JavaScript);
            webProjects.Add(Java);

            var otherProjects = new List<Projects>();
            otherProjects.Add(CSharp);
            otherProjects.Add(PHP);

            // create several employes of typep SalesEmployee
            RegularEmployee foodSalesEmployee = new SalesEmployee("Ivan", "Ivanov", "100", 1000, Department.Sales, foodSales);
            RegularEmployee othersSalesEmployee = new SalesEmployee("Dragan", "Peshev", "97", 1400, Department.Sales, otherSales);

            // create several developer employees
            RegularEmployee webDeveloper = new Developer("Maria", "Mainova", "333", 1800, Department.Marketing, webProjects);
            RegularEmployee appDevelooper = new Developer("Gosho", "Topciev", "666", 2800, Department.Production, otherProjects);

            // create several list of regular employess
            var otherEmployees = new List<Employee>();
            otherEmployees.Add(foodSalesEmployee);
            otherEmployees.Add(othersSalesEmployee);

            var programmerEmployees = new List<Employee>();
            programmerEmployees.Add(webDeveloper);
            programmerEmployees.Add(appDevelooper);

            // create several managers
            Employee programmingManager = new Manager("Muncho", "Gunchev", "1", 5000, Department.Sales, programmerEmployees);
            Employee accountingManager = new Manager("Iskra", "Gringo", "2", 4000, Department.Accounting, otherEmployees);

            //createa a list of managers and print them
            var managers = new List<Person>();
            managers.Add(programmingManager);
            managers.Add(accountingManager);

            foreach (var manager in managers)
            {
                Console.WriteLine(manager);
            }
            //foodSales, otherSales, webPoejcts, otherProjects, programmerEmployees, managers };
            foodSales.ForEach(x => Console.WriteLine(x));
            otherSales.ForEach(x => Console.WriteLine(x));
            webProjects.ForEach(x => Console.WriteLine(x));
            otherProjects.ForEach(x => Console.WriteLine(x));
            programmerEmployees.ForEach(x => Console.WriteLine(x));
            managers.ForEach(x => Console.WriteLine(x));
        }
    }
}
