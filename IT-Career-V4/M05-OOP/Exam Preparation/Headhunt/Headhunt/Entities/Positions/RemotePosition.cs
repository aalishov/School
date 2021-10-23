namespace Headhunt.Entities.Positions
{
    public class RemotePosition : Position
    {
        public RemotePosition(int refNumber, string positionName, string description, string companyName) : base(refNumber, positionName, description, companyName, "Remote")
        {
        }
    }
}
