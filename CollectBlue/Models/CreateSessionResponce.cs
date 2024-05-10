using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
namespace CollectBlue.Models
{
  [DataContract]
  internal class CreateSessionResponce
  {
    [DataMember(Name = "error")]
    public string Error { get; set; }
    public bool Scceeded { get { return string.IsNullOrEmpty(Error); } }

    [DataMember(Name = "message")]
    public string Message { get; set; }

    [DataMember(Name = "did")]
    public string DId { get; set; }

    [DataMember(Name = "didDoc")]
    public DIdDoc DIdDoc { get; set; }

    [DataMember(Name = "handle")]
    public string Handle { get; set; }

    [DataMember(Name = "email")]
    public string Email { get; set; }

    [DataMember(Name = "emailConfirmed")]
    public string EmailConfirmed { get; set; }

    [DataMember(Name = "emailAuthFactor")]
    public string EmailAuthFactor { get; set; }

    [DataMember(Name = "accessJwt")]
    public string AccessJwt { get; set; }

    [DataMember(Name = "refreshJwt")]
    public string RefreshJwt { get; set; }

    public static CreateSessionResponce Create(Stream responceStream)
    {
      var result = new DataContractJsonSerializer(typeof(CreateSessionResponce))
        .ReadObject(responceStream) as CreateSessionResponce;
      if (result == null)
      {
        throw new Exception("TODO");
      }
      return result;
    }
  }

}
