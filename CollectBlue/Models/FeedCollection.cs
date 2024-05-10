using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
namespace CollectBlue.Models
{
  [DataContract]
  public class FeedCollection
  {
    [DataMember(Name = "error")]
    public string Error { get; set; }
    public bool Scceeded { get { return string.IsNullOrEmpty(Error); } }

    [DataMember(Name = "message")]
    public string Message { get; set; }

    [DataMember(Name = "feed")]
    public Feed[] Feeds { get; set; }

    [DataMember(Name = "cursor")]
    public string Cursor { get; set; }

    public static FeedCollection CreateFromJson(string json)
    {
      using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
      {
        return CreateFromJson(stream);
      }
    }

    internal static FeedCollection CreateFromJson(Stream stream)
    {
      var result = new DataContractJsonSerializer(typeof(FeedCollection))
        .ReadObject(stream) as FeedCollection;
      if (result == null)
      {
        throw new Exception("TODO");
      }
      return result;
    }
  }
}
