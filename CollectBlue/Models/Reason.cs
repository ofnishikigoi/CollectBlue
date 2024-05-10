using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class Reason
  {
    [DataMember(Name = "$type")]
    public string Type { get; set; }

    [DataMember(Name = "by")]
    public ReasonBy By { get; set; }

    [DataMember(Name = "indexedAt")]
    public string IndexedAt { get; set; }
  }
}
