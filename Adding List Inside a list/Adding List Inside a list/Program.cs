using System.Transactions;

namespace list
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }

        public Employee(int id, string Name)
        {
            this.name = Name;
            this.Id = id;
        }

        public Employee() { }
    }
    public class Project
    {
        public string projectName { get; set; }
        public int projectId { get; set; }

        public List<Employee> employeesInEmp = new List<Employee>();

        public Project(string projectName ,int projectid)
        {
            this.projectName = projectName;
            this.projectId = projectid;
        }
    }

    public class actual
    {
        public static void Main(string[] args)
        {
            List<Project> projects = new List<Project>();
            Project project = new Project("sai",1);
            projects.Add(project);

            Project project1 = new Project("kiran", 2);
            projects.Add(project1);

            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee(1,"kiransai");

            Console.WriteLine("Enter id of project");
            int searchId = Convert.ToInt32(Console.ReadLine());
            for(int i =0;i<projects.Count;i++) 
            {
                if (projects[i].projectId == searchId)
                {
                    projects[i].employeesInEmp.Add(employee);
                }
            }

            int search = 1;
            for(int i= 0; i < projects.Count; i++)
            {
                if (projects[i].projectId == search) 
                { 
                    for(int j = 0; j < projects[i].employeesInEmp.Count; j++)
                    {
                        Console.WriteLine(projects[i].employeesInEmp[j].name);
                    }
                }
            }
        }

    }
}