using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class ImageData
  {
    [DataMember(Name = "thumb")]
    public string Thumb { get; set; }

    [DataMember(Name = "fullsize")]
    public string Fullsize { get; set; }

    [DataMember(Name = "alt")]
    public string Alt { get; set; }

    [DataMember(Name = "aspectRatio")]
    public AspectRatio AspectRatio { get; set; }

    [DataMember(Name = "image")]
    public ImageInformation ImageInformation { get; set; }
  }
}
