using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using LeKin.EntityFramework;

namespace LeKin.Migrator
{
    [DependsOn(typeof(LeKinDataModule))]
    public class LeKinMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<LeKinDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}