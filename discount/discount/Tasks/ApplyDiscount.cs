using System.Collections.Generic;
using CamundaClient.Dto;
using CamundaClient.Worker;

namespace discount.Tasks
{
    [ExternalTaskTopic("applyDiscount")]
    public class ApplyDiscount : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
        }
    }
}