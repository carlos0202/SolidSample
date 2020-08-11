using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
<<<<<<< HEAD
using System;
=======
>>>>>>> origin/ISP

namespace ArdalisRating
{
    public class JsonPolicySerializer
    {
<<<<<<< HEAD
        public Policy GetPolicyFromJsonString(string policyJson)
        {
            return JsonConvert.DeserializeObject<Policy>(
                policyJson,
                new StringEnumConverter());
        }
    }
}
=======
        public Policy GetPolicyFromJsonString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Policy>(jsonString,
                new StringEnumConverter());
        }
    }
}
>>>>>>> origin/ISP
