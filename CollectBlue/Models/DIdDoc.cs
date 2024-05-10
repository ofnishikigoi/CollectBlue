using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  internal class DIdDoc
  {
    [DataMember(Name = "@context")]
    public string[] Context { get; set; }

    [DataMember(Name = "id")]
    public string Id { get; set; }

    [DataMember(Name = "alsoKnownAs")]
    public string[] AlsoKnownAsArray { get; set; }

    [DataMember(Name = "verificationMethod")]
    public VerificationMethod[] VerificationMethods { get; set; }
    [DataMember(Name = "service")]
    public Service[] Service { get; set; }
  }

}
