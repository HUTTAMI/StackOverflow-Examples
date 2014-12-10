using Quartz;
using Quartz.Impl;
using SO.AutoRefreshLabel.Jobs;

namespace SO.AutoRefreshLabel
{
    /// <summary>
    /// This simply wires up the Quartz job.
    /// Creates a schedulerFactory, a scheduler, and jobs to add to that schedule.
    /// </summary>
    public class QuartzConfig
    {
        public static void RegisterServices()
        {
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            IScheduler scheduler = schedulerFactory.GetScheduler();
            scheduler.Start();

            BuildSchedule(scheduler);
        }

        private static void BuildSchedule(IScheduler scheduler)
        {
            IJobDetail jobDetail = JobBuilder.Create<SimpleJob>()
                .WithIdentity("Job1", "Group1")
                .Build();
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("Trigger1", "Group1")
                .StartNow()
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever()) // every 5 seconds
                .Build();
            scheduler.ScheduleJob(jobDetail, trigger);
        }
    }
}