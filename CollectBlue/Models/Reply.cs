using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class Reply
  {
    [DataMember(Name = "root")]
    public Post Root { get; set; }

    [DataMember(Name = "parent")]
    public Post Parent { get; set; }

    [DataMember(Name = "grandparentAuthor")]
    public Author GrandParentAuthor { get; set; }
  }
}
