using System.Data.Common;
using Abp.Zero.EntityFramework;
using LeKin.Authorization.Roles;
using LeKin.Authorization.Users;
using LeKin.MultiTenancy;

namespace LeKin.EntityFramework
{
    public class LeKinDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public LeKinDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in LeKinDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of LeKinDbContext since ABP automatically handles it.
         */
        public LeKinDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public LeKinDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public LeKinDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
