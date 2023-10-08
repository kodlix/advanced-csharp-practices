// See https://aka.ms/new-console-template for more information

using HRAdministrationAPI;

var employees = new List<IEmployee>();
SeedData(employees);
Console.WriteLine($"Total annual salaries including bonuses {employees.Sum(e => e.Salary)}");
Console.ReadKey();

static void SeedData(List<IEmployee> employees)
{
    IEmployee teacher1 = new Teacher()
    {
        Id = 1,
        FirstName = "Mike",
        LastName = "Crow",
        Salary = 837945
    };
    employees.Add(teacher1);


    IEmployee teacher22 = new HeadOfDepartment()
    {
        Id = 5,
        FirstName = "OldMan",
        LastName = "Savage",
        Salary = 789
    };
    employees.Add(teacher22);
    
    
    IEmployee teacher2 = new  HeadMaster()
    {
        Id = 2,
        FirstName = "Steve",
        LastName = "Adam",
        Salary = 83545
    };
    employees.Add(teacher2);
    
    
    IEmployee teacher3 = new DeputyHeadMaster()
    {
        Id = 3,
        FirstName = "Okon",
        LastName = "Madu",
        Salary = 345
    };
    employees.Add(teacher3);
    
    
    IEmployee teacher4 = new HeadMaster()
    {
        Id = 1,
        FirstName = "Griggs",
        LastName = "Adune",
        Salary = 1200
    };
    employees.Add(teacher4);
}


public class Teacher: EmployeeBase
{
    public override decimal Salary => base.Salary + (base.Salary * 0.03m);
}

public class HeadOfDepartment: EmployeeBase
{
    public override decimal Salary => base.Salary + (base.Salary * 0.02m);

}

public class DeputyHeadMaster: EmployeeBase
{
    public override decimal Salary => base.Salary + (base.Salary * 0.04m);

}

public class HeadMaster: EmployeeBase
{
    public override decimal Salary => base.Salary + (base.Salary * 0.07m);

}

public enum EmployeeTypes
{
    Teacher,
    HeadOfDepartment,
    HeadMaster,
    DeputyHeadMaster
};