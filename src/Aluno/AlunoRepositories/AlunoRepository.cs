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
            return _alunos
            .AsNoTracking()
            .SingleOrDefault(aluno => aluno.Matricula == matricula);
        }

        public async Task<IEnumerable<Aluno>> ObterAlunos()
        {
            return await _alunos
            .AsNoTracking()
            .ToListAsync();
        }

        public void Adicionar(Aluno aluno)
        {
            _alunos.Add(aluno);
        }

        public bool Existe(int matricula) 
        {
            return _alunos.Any(aluno => aluno.Matricula == matricula);
        }

        public void Atualizar(Aluno aluno) 
        {
           _alunos.Update(aluno);
        }

        public void Excluir(int matricula) 
        {
            var aluno = _alunos.SingleOrDefault(aluno => aluno.Matricula == matricula);

           _alunos.Remove(aluno);
        }
    }
}