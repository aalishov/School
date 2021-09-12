namespace P11_Birthdates
{
    public class Robot : BaseCitizen, IModel
    {
        public Robot(string id, string model) : base(id)
        {
            this.Model = model;
        }

        public string Model { get ; set; }
    }
}
