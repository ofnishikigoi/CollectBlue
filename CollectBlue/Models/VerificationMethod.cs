using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  internal class VerificationMethod
  {
    [DataMember(Name = "id")]
    public string Id { get; set; }

    [DataMember(Name = "type")]
    public string Type { get; set; }

    [DataMember(Name = "controller")]
    public string Controller { get; set; }

    [DataMember(Name = "publicKeyMultibase")]
    public string PublicKeyMultibase { get; set; }
  }

}
