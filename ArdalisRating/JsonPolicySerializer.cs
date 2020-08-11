using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace ArdalisRating
{
    public class JsonPolicySerializer
    {
        public Policy GetPolicyFromJsonString(string policyJson)
        {
            return JsonConvert.DeserializeObject<Policy>(
                policyJson,
                new StringEnumConverter());
        }
    }
}