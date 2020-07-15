using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteApi.AlunoModel;
using TesteApi.Data.DataContext;
using TesteApi.Interface.Repositories.IAlunoRepository;

namespace TesteApi.Repositories.AlunoRepository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly DataContext _dataContext;
        private readonly DbSet<Aluno> _alunos;

        public AlunoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _alunos = dataContext.Set<Aluno>();
        }

        public Aluno Obter(int matricula)
        {
            return _alunos.AsNoTracking()
            .SingleOrDefault(aluno => aluno.Matricula == matricula);
        }

        public async Task<IEnumerable<Aluno>> ObterAlunos()
        {
            return await _alunos.AsNoTracking().ToListAsync();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            _alunos.Add(aluno);
        }
    }
}