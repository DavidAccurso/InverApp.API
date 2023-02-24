using System.Transactions;

namespace InversiApp.API.Repository
{
    public abstract class GenericRepository
    {
        public GenericRepository() { }

        public async Task<T> LogExceptionAndRollbackTransactionIfFail<T>(ILogger logger, Func<Task<T>> func)
        {
            try
            {
                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    T response = await func();
                    scope.Complete();
                    return response;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} for {ex.Data}");
                throw;
            }
        }

        public async Task<T> LogExceptionIfFail<T>(ILogger logger, Func<Task<T>> func)
        {
            try
            {
                T response = await func();
                return response;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} for {ex.Data}");
                throw;
            }
        }
    }
}
