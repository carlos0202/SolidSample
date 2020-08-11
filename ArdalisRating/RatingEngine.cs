using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public decimal Rating { get; set; }
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
        public FilePolicySource PolicySource { get; set; } = new FilePolicySource();
        public JsonPolicySerializer PolicySerializer { get; set; } = new JsonPolicySerializer();
        public void Rate()
        {
            Logger.Log("Starting rate.");

            Logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyJson = PolicySource.GetPolicyFromSource();

            Policy policy = PolicySerializer.GetPolicyFromJsonString(policyJson);

            var factory = new RaterFactory();

            Rater rater = factory.Create(policy, this);

            rater.Rate(policy);

            Logger.Log("Rating completed.");
        }
    }
}
