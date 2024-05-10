using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class Record
  {
    [DataMember(Name = "$type")]
    public string Type { get; set; }

    [DataMember(Name = "createdAt")]
    public string CreatedAt { get; set; }

    [DataMember(Name = "embed")]
    public Embed Embed { get; set; }

    [DataMember(Name = "facets")]
    public Facet[] Facets { get; set; }

    [DataMember(Name = "langs")]
    public string[] Langs { get; set; }

    [DataMember(Name = "reply")]
    public Reply ReplySummary { get; set; }

    [DataMember(Name = "text")]
    public string Text { get; set; }

  }
}
