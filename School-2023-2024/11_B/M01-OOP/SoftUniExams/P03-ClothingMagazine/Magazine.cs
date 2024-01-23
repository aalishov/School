using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

public class Magazine
{
    private List<Cloth> clothes = new List<Cloth>();

    public Magazine(string type, int capacity)
    {
        Type = type;
        Capacity = capacity;
    }
    public IReadOnlyList<Cloth> Cloths { get { return clothes; } }

    public string Type { get; set; }
    public int Capacity { get; set; }
    public void AddCloth(Cloth cloth)
    {
        if (clothes.Count < Capacity)
        {
            clothes.Add(cloth);
        }
    }
    public bool RemoveCloth(string color)
    {
        Cloth cloth = GetCloth(color);
        return clothes.Remove(cloth);
    }
    public Cloth GetSmallestCloth()
    {
        Cloth cloth = clothes.OrderBy(c => c.Size).FirstOrDefault();
        return cloth;
    }
    public Cloth GetCloth(string color)
    {
        Cloth cloth = clothes.FirstOrDefault(c => c.Color == color);

        //Cloth cloth = null;
        //foreach (var c in clothes)
        //{
        //    if (c.Color==color)
        //    {
        //        cloth = c;
        //        break;
        //    }
        //}
        //if (cloth==null)
        //{
        //    throw new NullReferenceException();
        //}
        return cloth;
    }
    public int GetClothCount()
    {
        return clothes.Count;
    }
    public string Report()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Type} magazine contains:");
        //foreach (Cloth cloth in clothes)
        //{
        //    sb.AppendLine(cloth.ToString());
        //}

        clothes.ForEach(c => sb.AppendLine(c.ToString()));
        return sb.ToString().TrimEnd();
    }
}

