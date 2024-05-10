using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
namespace CollectBlue.Models
{
  [DataContract]
  public class Profile
  {
    [DataMember(Name = "error")]
    public string Error { get; set; }
    public bool Scceeded { get { return string.IsNullOrEmpty(Error); } }

    [DataMember(Name = "message")]
    public string Message { get; set; }

    [DataMember(Name = "did")]
    public string DId { get; set; }

    [DataMember(Name = "handle")]
    public string Handle { get; set; }

    [DataMember(Name = "displayName")]
    public string DisplayName { get; set; }

    [DataMember(Name = "avatar")]
    public string Avatar { get; set; }

    [DataMember(Name = "labels")]
    public LabelData[] Labels { get; set; }

    [DataMember(Name = "associated")]
    public Associated Associated { get; set; }

    [DataMember(Name = "viewer")]
    public Viewer Viewer { get; set; }

    [DataMember(Name = "description")]
    public string Description { get; set; }

    [DataMember(Name = "indexedAt")]
    public string IndexedAt { get; set; }

    [DataMember(Name = "banner")]
    public string Banner { get; set; }

    [DataMember(Name = "followersCount")]
    public int FollowersCount { get; set; }

    [DataMember(Name = "followsCount")]
    public int FollowsCount { get; set; }

    [DataMember(Name = "postsCount")]
    public int postsCount { get; set; }

    public static Profile CreateFromJson(string json)
    {
      using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
      {
        return CreateFromJson(stream);
      }
    }

    internal static Profile CreateFromJson(Stream stream)
    {
      var result = new DataContractJsonSerializer(typeof(Profile))
        .ReadObject(stream) as Profile;
      if (result == null)
      {
        throw new Exception("TODO");
      }
      return result;
    }
  }

}
