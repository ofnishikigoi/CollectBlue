using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  public class IndexValue
  {
    [DataMember(Name = "byteEnd")]
    public int ByteEnd { get; set; }

    [DataMember(Name = "byteStart")]
    public int ByteStart { get; set; }
  }
}
