using System;
using System.Collections.Generic;
using CamundaClient.Dto;
using CamundaClient.Worker;

namespace basic_dmn.Tasks
{
    [ExternalTaskTopic("reportCategory")]
    public class ReportCategory : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            Console.WriteLine($"Categorized temperature: {externalTask.Variables["category"].Value}");
        }
    }
}