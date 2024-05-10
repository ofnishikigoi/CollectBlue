using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
namespace CollectBlue.Models
{
  [DataContract]
  public class PostCollection
  {
    [DataMember(Name = "error")]
    public string Error { get; set; }
    public bool Scceeded { get { return string.IsNullOrEmpty(Error); } }

    [DataMember(Name = "message")]
    public string Message { get; set; }

    [DataMember(Name = "posts")]
    public Post[] Posts { get; set; }

    [DataMember(Name = "cursor")]
    public string Cursor { get; set; }

    public static PostCollection CreateFromJson(string json)
    {
      using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
      {
        return CreateFromJson(stream);
      }
    }

    internal static PostCollection CreateFromJson(Stream stream)
    {
      var result = new DataContractJsonSerializer(typeof(PostCollection))
        .ReadObject(stream) as PostCollection;
      if (result == null)
      {
        throw new Exception("TODO");
      }
      return result;
    }
  }
}
