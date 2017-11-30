using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace LeKin.EntityFramework.Repositories
{
    public abstract class LeKinRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<LeKinDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected LeKinRepositoryBase(IDbContextProvider<LeKinDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class LeKinRepositoryBase<TEntity> : LeKinRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected LeKinRepositoryBase(IDbContextProvider<LeKinDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
