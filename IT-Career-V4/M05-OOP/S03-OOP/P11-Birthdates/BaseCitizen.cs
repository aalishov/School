namespace P11_Birthdates
{
    public abstract class BaseCitizen
    {
        protected BaseCitizen(string id)
        {
            this.Id = id;
        }
        public string Id { get; set; }
    }
}
