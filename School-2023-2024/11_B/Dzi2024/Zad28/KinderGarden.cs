using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KinderGarden
{
    private List<Kid> kids = new List<Kid>();

    public string EnrollKid(Kid kid)
    {
        kids.Add(kid);
        return $"The child {kid.FirstName} {kid.LastName} is enrolled.";
    }

    public string ReleaseKid(string id)
    {
        Kid? kid = kids.FirstOrDefault(x => x.Id == id);

        if (kid != null)
        {
            kids.Remove(kid);
            return $"The child {kid.FirstName} {kid.LastName} has been unsubscribed.";
        }
        else
        {
            return $"Unsubscribe failed - invalid identifier {id}.";
        }
    }

    public string GroupInfo(string group)
    {
        List<Kid> listInGroup = kids.Where(x => x.Group == group).OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{group} group - {listInGroup.Count} children.");

        foreach (Kid kid in listInGroup)
        {
            sb.AppendLine(kid.ToString());
        }

        return sb.ToString().TrimEnd();
    }
}

