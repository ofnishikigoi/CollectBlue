using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class Facet
  {
    [DataMember(Name = "features")]
    public Feature[] Features { get; set; }

    [DataMember(Name = "index")]
    public IndexValue Index { get; set; }
  }
}
