using System.Runtime.Serialization;

namespace WebApplication1;
[DataContract]
public class Request
{
    [DataMember(Name = "a")]
    public int First { get; set; }
    [DataMember(Name = "b")]
    public int Second { get; set; }
    [DataMember(Name = "c")]
    public int Third { get; set; }
}
