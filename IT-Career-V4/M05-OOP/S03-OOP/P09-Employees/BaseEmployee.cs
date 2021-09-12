namespace P09_Employees
{
    public abstract class BaseEmployee
    {
        protected BaseEmployee(string id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual string Show()
        {
            return $"Id: {this.Id}, name: {this.Name}, address: {this.Address}";
        }
        public abstract string CalculateSalary(int workingHours);
        public abstract string GetDepartment();
    }
}
