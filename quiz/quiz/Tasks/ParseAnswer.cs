using System;
using System.IO;
using System.Collections.Generic;
using CamundaClient.Dto;
using CamundaClient.Worker;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SimpleCalculationProcess
{
    
    [ExternalTaskTopic("parseanswer")]

    class PaserAnswer : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            Console.WriteLine("--- Result variables ---");
            foreach (var item in externalTask.Variables) {
                Console.WriteLine(item.Key.ToString().PadRight(18) + ": " + item.Value.Value.ToString() );
            }
            
            foreach (var item in resultVariables){
                Console.WriteLine(item.Key.ToString());
            }
            Console.WriteLine("------------------------");
            JObject quiz = JObject.Parse(File.ReadAllText(@"..\rest\simple-response.json"));
            var expected =  (string)quiz["quiz"]["sport"]["q1"]["answer"];
            Console.WriteLine("Expected answer:  " + expected);
            var result = string.Equals(expected, externalTask.Variables["answer"].Value);
            Console.WriteLine("correct?          : " + result);
            resultVariables.Add("correct", result);
        }
    }
}