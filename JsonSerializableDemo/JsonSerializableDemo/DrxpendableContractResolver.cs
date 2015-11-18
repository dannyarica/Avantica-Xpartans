using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Reflection;

namespace JsonSerializableDemo
{
    public class DrxpendableContractResolver : DefaultContractResolver
    {        
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            property.ShouldSerialize = instance => { return false; };
            var customAttributes = member.CustomAttributes;
            if (customAttributes != null && customAttributes.ToList().Any())
            {
                property.ShouldSerialize = instance =>
                {
                    var customAttributeName = customAttributes.ToList().Select(x => x.AttributeType);
                    return customAttributeName.Select(x => x.Name.Equals("DrxpendableAttribute")).Any();
                };
            }
            return property;
        }
    }
}