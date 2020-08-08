using TesteApi.Data.DataContext;
using TesteApi.Interface.IUnitOfWork;

namespace TesteApi.ConfigUnitOfWork.UnitOfWork 
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Salvar()
        {
            _dataContext.SaveChanges();
        }
    }
}