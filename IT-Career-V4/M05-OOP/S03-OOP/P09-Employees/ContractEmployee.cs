namespace P09_Employees
{
    using System;
    public class ContractEmployee : BaseEmployee
    {
        public ContractEmployee(string id, string name, string address, string task, string department) : base(id, name, address)
        {
            this.Task=task;
            this.Department = department;
        }
        public string Task { get; set; }
        public string Department { get; set; }
        public override string Show()
        {
            return base.Show() + $"\n\tTask: {this.Task}\n\tDepartment: {this.Department}";
        }
        public override string CalculateSalary(int workingHours)
        {
            return $"Id: {this.Id}, salary: {250 + workingHours * 20}";
        }
        public override string GetDepartment()
        {
            return $"Id: {this.Id}, department: {this.Department}";
        }
    }
}
