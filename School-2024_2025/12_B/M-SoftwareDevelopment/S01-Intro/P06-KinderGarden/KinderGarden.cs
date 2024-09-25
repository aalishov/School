using System.Text;

public class KinderGarden
{
    private readonly List<Kid> kids;
    public KinderGarden()
    {
        kids = new List<Kid>();
    }

    public string EnrollKid(Kid kid)
    {
        kids.Add(kid);
        return $"The child {kid.FirstName} {kid.LastName} is enrolled.";
    }

    public string ReleaseKid(string id)
    {
        Kid? kid = kids.FirstOrDefault(k => k.Id == id);

        if (kid != null)
        {
            kids.Remove(kid);
            return $"The child {kid.FirstName} {kid.LastName} has been unsubscribed.";
        }
        return $"Unsubscribe failed - invalid identifier {id}";
    }
    public string GroupInfo(string group)
    {
        List<Kid> groupKids = kids
            .Where(x => x.Group == group)
            .OrderBy(x=>x.FirstName)
            .ThenBy(x=>x.LastName)
            .ToList();

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{group} group - {groupKids.Count} children.");
        foreach (var kid in groupKids)
        {
            sb.AppendLine(kid.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}

