﻿using System;
using Bit.Data.Contracts;
using Bit.Model.Contracts;

namespace Bit.Data.EntityFrameworkCore.Implementations
{
    public class EfEntityWithDefaultGuidKeyRepository<TEntity> : EfEntityWithDefaultKeyRepository<TEntity, Guid>, IEntityWithDefaultGuidKeyRepository<TEntity>
        where TEntity : class, IEntityWithDefaultGuidKey
    {
#if DEBUG
        protected EfEntityWithDefaultGuidKeyRepository()
        {
        }
#endif

        protected EfEntityWithDefaultGuidKeyRepository(EfCoreDbContextBase dbContext)
            : base(dbContext)
        {
        }

        public override Guid GetNewKey()
        {
            return Guid.NewGuid();
        }
    }
}