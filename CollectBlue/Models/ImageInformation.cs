using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class ImageInformation
  {
    [DataMember(Name = "$type")]
    public string Type { get; set; }

    [DataMember(Name = "ref")]
    public Reference Ref { get; set; }

    [DataMember(Name = "mimeType")]
    public string MimeType { get; set; }

    [DataMember(Name = "size")]
    public int size { get; set; }

  }
}
