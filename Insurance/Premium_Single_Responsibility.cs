using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    internal class Premium_Single_Responsibility
    {
        private readonly Logger log;
        private readonly PolicySource policySource;
        private readonly PolicySourceSerializer policySourceSerializer;
        private readonly Premiumengine premiumengine;

            

        public Premium_Single_Responsibility(Logger log,PolicySource policySource
            ,PolicySourceSerializer policySourceSerializer,Premiumengine premiumengine)
        {
            this.log = log;
            this.policySource = policySource;
            this.premiumengine = premiumengine;
            this.policySourceSerializer = policySourceSerializer;
        }
        public decimal CalculatePremium()
        {
            decimal premium = 0;

            // Three different types any change in loging or reading or buisness rule effect the class
            ///Logging
            log.info("Calculating Premium");

            //Reading

            var policyJson = policySource.GetPolicyfromSource();

            //Convert or encoding
            var policyObject = policySourceSerializer.GetPolicyfromJson(policyJson);
            if (policyObject == null)
            {
                log.error("No policy decined");
                throw new Exception("policy doesn't exits");
            }
            //Buisness rules

            premium = premiumengine.GetPremiume(policyObject)
          
            return premium;

        }
    }
}
