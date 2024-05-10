using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class Embed
  {
    [DataMember(Name = "$type")]
    public string Type { get; set; }

    [DataMember(Name = "images")]
    public ImageData[] Images { get; set; }

    [DataMember(Name = "record")]
    public RecordSummary RecordSummary { get; set; }
  }
}
