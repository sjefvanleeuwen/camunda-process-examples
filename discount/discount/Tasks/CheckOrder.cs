using System.Collections.Generic;
using CamundaClient.Dto;
using CamundaClient.Worker;
using discount.Controllers;

namespace discount.Tasks
{   
    [ExternalTaskTopic("checkOrder")]
    public class CheckOrder : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            var orderId = (string)externalTask.Variables["orderId"].Value;
            using (var controller = new OrderController())
            {
                resultVariables["orderExists"] = controller.Exists(orderId); 
            }
        }
    }
}