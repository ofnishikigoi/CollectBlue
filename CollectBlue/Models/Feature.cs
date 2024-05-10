using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  public class Feature
  {
    [DataMember(Name = "$type")]
    public string Type { get; set; }

    [DataMember(Name = "tag")]
    public string Tag { get; set; }
  }
}
