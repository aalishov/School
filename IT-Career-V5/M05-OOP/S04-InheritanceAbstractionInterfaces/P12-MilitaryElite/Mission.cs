namespace MilitaryElite
{
    using System;
    public class Mission
    {
        private string state;
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; set; }
        public string State
        {
            get { return state; }
            set
            {
                if (value!="inProgress"&&value!="Finished")
                {
                    throw new NotImplementedException("Invalid state");
                }
                state = value;
            }
        }
        public void CompleteMission()
        {
            this.State = "Finished";
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName } State: {this.State}";
        }
    }
}
