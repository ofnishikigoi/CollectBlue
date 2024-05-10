using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class Feed
  {
    [DataMember(Name = "post")]
    public Post Post { get; set; }

    [DataMember(Name = "reply")]
    public Reply Reply { get; set; }

    [DataMember(Name = "reason")]
    public Reason Reason { get; set; }
  }
}
