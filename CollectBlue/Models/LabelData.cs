using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class LabelData
  {
    [DataMember(Name = "src")]
    public string Src { get; set; }

    [DataMember(Name = "uri")]
    public string Uri { get; set; }

    [DataMember(Name = "cid")]
    public string CId { get; set; }

    [DataMember(Name = "val")]
    public string Val { get; set; }

    [DataMember(Name = "cts")]
    public string Cts { get; set; }
  }
}
