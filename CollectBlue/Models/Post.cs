using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  public class Post
  {
    [DataMember(Name = "$type")]
    public string Type { get; set; }

    [DataMember(Name = "uri")]
    public string Uri { get; set; }

    [DataMember(Name = "cid")]
    public string CId { get; set; }

    [DataMember(Name = "author")]
    public Author Author { get; set; }

    [DataMember(Name = "record")]
    public Record Record { get; set; }

    [DataMember(Name = "embed")]
    public Embed Embed { get; set; }

    [DataMember(Name = "replyCount")]
    public int ReplyCount { get; set; }

    [DataMember(Name = "repostCount")]
    public int RepostCount { get; set; }

    [DataMember(Name = "likeCount")]
    public int LikeCount { get; set; }

    [DataMember(Name = "indexedAt")]
    public string IndexedAt { get; set; }
    [IgnoreDataMember]
    public DateTime IndexedAtDateTime
    {
      get
      {
        return DateTime.Parse(IndexedAt);
      }
    }

    [DataMember(Name = "viewer")]
    public Viewer Viewer { get; set; }

    [DataMember(Name = "labels")]
    public LabelData[] Labels { get; set; }

  }
}
