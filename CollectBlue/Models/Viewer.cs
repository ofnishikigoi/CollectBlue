using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class Viewer
  {
    [DataMember(Name = "muted")]
    public bool Lists { get; set; }

    [DataMember(Name = "blockedBy")]
    public bool Feedgens { get; set; }
  }

}
