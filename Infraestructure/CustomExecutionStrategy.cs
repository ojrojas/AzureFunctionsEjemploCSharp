
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infraestructure
{
    public class CustomExecutionStrategy : ExecutionStrategy
    {
        public CustomExecutionStrategy(DbContext context) :
            this(context, DefaultMaxRetryCount, DefaultMaxDelay)
        {
        }

        public CustomExecutionStrategy(DbContext context, int maxRetryCount, TimeSpan maxRetryDelay) :
            base(context, maxRetryCount, maxRetryDelay)
        {
        }

        public CustomExecutionStrategy(ExecutionStrategyDependencies dependencies) :
            this(dependencies, DefaultMaxRetryCount, DefaultMaxDelay)
        {
        }

        public CustomExecutionStrategy(ExecutionStrategyDependencies dependencies, int maxRetryCount, TimeSpan maxRetryDelay) :
            base(dependencies, maxRetryCount, maxRetryDelay)
        {
        }

        protected override bool ShouldRetryOn(Exception exception)
        {
            return exception.GetType() == typeof(DbUpdateException);
        }
    }
}