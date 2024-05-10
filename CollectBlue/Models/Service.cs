using System.Runtime.Serialization;
namespace CollectBlue.Models
{
  [DataContract]
  internal class Service
  {
    [DataMember(Name = "id")]
    public string Id { get; set; }

    [DataMember(Name = "type")]
    public string Type { get; set; }

    [DataMember(Name = "serviceEndpoint")]
    public string ServiceEndpoint { get; set; }
  }

}
