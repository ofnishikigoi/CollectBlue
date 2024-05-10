using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class RecordSummary
  {
    [DataMember(Name = "uri")]
    public string Uri { get; set; }

    [DataMember(Name = "cid")]
    public string CId { get; set; }
  }
}
