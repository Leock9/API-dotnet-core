using System.Collections.Generic;
using System.Threading.Tasks;
using TesteApi.AlunoModel;

namespace TesteApi.Interface.Services.IAlunoService
{
    public interface IAlunoService
    {
        Aluno Obter(int matricula);

        Task<IEnumerable<Aluno>> ObterAlunos();
    
        void AdicionarAluno(string aluno);
    }
}