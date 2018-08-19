using System;
using System.Collections.Generic;
using CamundaClient.Dto;
using CamundaClient.Worker;

namespace basic_dmn.Tasks
{
    [ExternalTaskTopic("measureTemperature")]
    public class MeasureTemperature : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            // Get Sensor data, hypothetically.
            var temperature = new Random().Next( -5, 40);
            Console.WriteLine($"Measured temperature: {temperature}");
            resultVariables.Add("temperature",temperature);
        }
    }
}