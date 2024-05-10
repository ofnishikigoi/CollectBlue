using System.Runtime.Serialization;

namespace CollectBlue.Models
{
  [DataContract]
  public class Author
  {
    [DataMember(Name = "did")]
    public string DId { get; set; }

    [DataMember(Name = "handle")]
    public string Handle { get; set; }

    [DataMember(Name = "displayName")]
    public string DisplayName { get; set; }

    [DataMember(Name = "avatar")]
    public string Avatar { get; set; }

    [DataMember(Name = "viewer")]
    public Viewer Viewer { get; set; }

    [DataMember(Name = "labels")]
    public LabelData[] Labels { get; set; }
  }
}
