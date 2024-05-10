using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class Associated
  {
    [DataMember(Name = "lists")]
    public int Lists { get; set; }

    [DataMember(Name = "feedgens")]
    public int Feedgens { get; set; }

    [DataMember(Name = "labeler")]
    public bool Labeler { get; set; }
  }

}
