using Microsoft.AspNet.SignalR;
using Quartz;
using SO.AutoRefreshLabel.Hubs;
using System;

namespace SO.AutoRefreshLabel.Jobs
{
    /// <summary>
    /// A simple job to emulate your ThreadPool
    /// </summary>
    public class SimpleJob : IJob
    {
        /// <summary>
        /// Called when the Job is executed (per ~/App_Data/QuartzConfig.cs, this will occur
        /// every 5 seconds).
        /// </summary>
        /// <param name="context"></param>
        public void Execute(IJobExecutionContext context)
        {
            // Grab the SignalR hub context
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<SimpleHub>();

            // Call our created method (I've named it updateLabel, but it could be
            // whatever you'd like. You'll notice that "All" is a dynamic data-type,
            // so whatever you name your method here is what you need to reference
            // in your JavaScript code.
            hubContext.Clients.All.updateLabel(DateTime.Now.TimeOfDay.ToString());
        }
    }
}