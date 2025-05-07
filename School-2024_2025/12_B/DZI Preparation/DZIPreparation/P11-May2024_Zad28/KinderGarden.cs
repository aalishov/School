using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KinderGarden
{
    private List<Kid> kidList;

    public KinderGarden()
    {
       kidList = new List<Kid>();
    }
    public string EnrollKid(Kid kid)
    {
        kidList.Add(kid);
        return $"The child {kid.FirstName} {kid.LastName} is enrolled.";
    }
    public string ReleaseKid(string id)
    {
       Kid kid = kidList.FirstOrDefault(k => k.Id == id);
        if (kidList.Remove(kid) == true)
        {
            return $"The child {kid.FirstName} {kid.LastName} has been unsubscribed.";
        }
        else { return $"Unsubscribe failed - invalid identifier {id}."; }
    }
    public string GroupInfo(string group)
    {
        List<Kid> kids = kidList.Where(x=>x.Group == group).OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName).ToList();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{group} - {kids.Count}children");
        foreach (Kid kid in kids)
        {
            sb.AppendLine(kid.ToString());
        }
        return sb.ToString().TrimEnd();
    }
    public string Info()
    {
        var kids = kidList
          .GroupBy(x => x.Group);

        foreach (var kid in kids)
        {
            Console.WriteLine($"{kid.Key}");
            Console.WriteLine($"{string.Join("\n\r", kid.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))}");
        }
        return "";
    }
}
