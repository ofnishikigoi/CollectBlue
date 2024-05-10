using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class AspectRatio
  {
    [DataMember(Name = "height")]
    public string Height { get; set; }

    [DataMember(Name = "width")]
    public string Width { get; set; }
  }
}
