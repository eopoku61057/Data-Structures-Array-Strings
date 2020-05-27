// this code implements an employee base graph and uses BST to search and prints the employees

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class Graph
    {
        public class Employee
        {
            public string name { get; set; }
            List<Employee> EmployeeList = new List<Employee>();
            public Employee(string name)
            {
                this.name = name;
            }
            public List<Employee> Employees
            {
                get
                {
                    return EmployeeList;
                }
            }
            public void isEmployeeOf(Employee p)
            {
                EmployeeList.Add(p);
            }
            public override string ToString()
            {
                return name;
            }
        }

        public class BreadthFirstAlgorithm
        {
            public Employee BuildEmployeeGraph()
            {
                Employee Eva = new Employee("Eva");
                Employee Sophia = new Employee("Sophia");
                Employee Brian = new Employee("Brian");
                Eva.isEmployeeOf(Sophia);
                Eva.isEmployeeOf(Brian);

                Employee Lisa = new Employee("Lisa");
                Employee Tina = new Employee("Tina");
                Employee John = new Employee("John");
                Employee Mike = new Employee("Mike");
                Sophia.isEmployeeOf(Lisa);
                Sophia.isEmployeeOf(John);
                Brian.isEmployeeOf(Tina);
                Brian.isEmployeeOf(Mike);

                return Eva;
            }

            public Employee Search(Employee root, string nameToSearchFor)
            {
                Queue<Employee> queue = new Queue<Employee>();
                HashSet<Employee> set = new HashSet<Employee>();

                queue.Enqueue(root);
                set.Add(root);

                while (queue.Count > 0)
                {
                    Employee e = queue.Dequeue();
                    if (e.name == nameToSearchFor)
                    {
                        return e;
                    }

                    foreach (Employee friend in e.Employees)
                    {
                        if (!set.Contains(friend))
                        {
                            queue.Enqueue(friend);
                            set.Add(friend);
                        }
                    }
                }
                return null;
            }

            public void Traverse(Employee root)
            {
                Queue<Employee> traverseOrder = new Queue<Employee>();

                Queue<Employee> queue = new Queue<Employee>();
                HashSet<Employee> set = new HashSet<Employee>();
                queue.Enqueue(root);
                set.Add(root);

                while (queue.Count > 0)
                {
                    Employee e = queue.Dequeue();
                    traverseOrder.Enqueue(e);

                    foreach (Employee emp in e.Employees)
                    {
                        if (!set.Contains(emp))
                        {
                            queue.Enqueue(emp);
                            set.Add(emp);
                        }
                    }
                }

                while (traverseOrder.Count > 0)
                {
                    Employee e = traverseOrder.Dequeue();
                    Console.WriteLine(e);
                }
            }

            static void Main(string[] args)
            {
                BreadthFirstAlgorithm b = new BreadthFirstAlgorithm();
                Employee root = b.BuildEmployeeGraph();
                Console.WriteLine("Traverse Graph\n------");
                b.Traverse(root);

                Console.WriteLine("\nSearch in Graph\n------");
                Employee e = b.Search(root, "Eva");

                Console.WriteLine(e == null ? "Employee not found" : e.name);

                e = b.Search(root, "Brian");
                Console.WriteLine(e == null ? "Employee not found" : e.name);

                e = b.Search(root, "Soni");
                Console.WriteLine(e == null ? "Employee not found" : e.name);
            }
        }
    }
}
