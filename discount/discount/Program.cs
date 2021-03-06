﻿using System;
using System.Globalization;
using System.Threading;
using CamundaClient;

namespace discount {
    class Program
    {
private static string logo = @"
 __      __.___  ________________     _____ .______________ 
/  \    /  |   |/  _____/\_____  \   /  |  ||   \__    ___/ 
\   \/\/   |   /   \  ___ /   |   \ /   |  ||   | |    |    
 \        /|   \    \_\  /    |    /    ^   |   | |    |    
  \__/\  / |___|\______  \_______  \____   ||___| |____|    
       \/              \/        \/     |__|                
       
discount camunda processes";

        private static readonly AutoResetEvent _closing = new AutoResetEvent(false);
        private static void Main(string[] args)
        {
            var culture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            
            Console.WriteLine( logo + "\n\n" + "Deploying models and start External Task Workers.\n\nPRESS Ctrl-C TO STOP WORKERS.\n\n");

            CamundaEngineClient camunda = new CamundaEngineClient();            
            camunda.Startup(); // Deploys all models to Camunda and Start all found ExternalTask-Workers
            Console.CancelKeyPress += new ConsoleCancelEventHandler(OnExit);
            _closing.WaitOne();
            camunda.Shutdown(); // Stop Task Workers
        }

        protected static void OnExit(object sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("Exit");
            _closing.Set();
        }

        private static void writeTasksToConsole(CamundaEngineClient camunda)
        {
            var tasks = camunda.HumanTaskService.LoadTasks();
            foreach (var task in tasks)
            {
                Console.WriteLine(task.Name);
            }
        }
    }
}
