using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
namespace CollectBlue.Parameters
{
  [DataContract]
  internal class CreateSettionParameter
  {
    [DataMember(Name = "identifier")]
    public string Identifier { get; private set; }
    [DataMember(Name = "password")]
    public string Password { get; private set; }

    public CreateSettionParameter(string identifier, string password)
    {
      Identifier = identifier;
      Password = password;
    }
    public string ToJson()
    {
      using (var stream = new MemoryStream())
      {
        new DataContractJsonSerializer(typeof(CreateSettionParameter))
          .WriteObject(stream, this);
        stream.Seek(0, SeekOrigin.Begin);
        using (var reader = new StreamReader(stream))
        {
          return reader.ReadToEnd();
        }
      }
    }
  }
}
