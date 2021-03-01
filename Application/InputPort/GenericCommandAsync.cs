using GPRC.core.application.OutputPort;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace GPRC.core.application.InputPort
{
    public class GenericCommandAsync<T> : IGenericCommandAsync<T> where T : class
    {
        IGenericRepositoryAsync<T> _GenericRepositoryAsync;
        public GenericCommandAsync(IGenericRepositoryAsync<T> GenericRepositoryAsync)
        {
            _GenericRepositoryAsync = GenericRepositoryAsync;
        }
        public async Task<T> AddAsync(T entity)
        {
            return await _GenericRepositoryAsync.AddAsync(entity);
                           
        }

        public Task DeleteAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _GenericRepositoryAsync.GetByIdAsync(id);

             
        }

        public Task<IReadOnlyList<T>> GetPagedReponseAsync(int pageNumber, int pageSize)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
