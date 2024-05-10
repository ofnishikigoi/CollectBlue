using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  public class Reference
  {
    [DataMember(Name = "$link")]
    public string Link { get; set; }
  }
}
