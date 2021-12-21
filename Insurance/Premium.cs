using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Insurance
{
    public class Premium
    {
        public decimal CalculatePremium()
        {
            decimal premium = 0;

            ///Logging
            Console.WriteLine("Calculating Premium");
            var policy = File.ReadAllText("file.json");

            //reading
            var policyObject = JsonConvert.DeserializeObject<Policy>(policy);
            if(policyObject == null)
            {
                Console.WriteLine("policy doesn't exits");
                throw new Exception("policy doesn't exits");
            }

            //Buisness rules
            switch (policyObject.PolicyType)
            {
                case (int)PolicyType.HomeRental:
                    premium = policyObject.MotorHomePrice;
                   //Other buisness rules
                    break;
                case (int)PolicyType.WaterCraft:
                      premium = policyObject.WaterCraftPrice;
                     //Other buisness rules
                      break;
            }

            return

        }
    }
}
