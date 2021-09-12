namespace P09_Employees
{
    public class FullTimeEmployee : BaseEmployee
    {
        public FullTimeEmployee(string id, string name, string address,string position, string department) : base(id, name, address)
        {
            this.Position = position;
            this.Department = department;
        }
        public string Position { get; set; }
        public string Department { get; set; }

        public override string Show()
        {
            return base.Show()+$"\n\tPosition: {this.Position}\n\tDepartment: {this.Department}";
        }
        public override string CalculateSalary(int workingHours)
        {
            return $"Id: {this.Id}, salary: {250 + workingHours * 10.80}";
        }
        public override string GetDepartment()
        {
            return $"Id: {this.Id}, department: {this.Department}";
        }
    }
}
