using System.Collections.Generic;
using System.Threading.Tasks;
using TesteApi.AlunoModel;
using TesteApi.DTO.AlunoDTO;

namespace TesteApi.Interface.Services.IAlunoService
{
    public interface IAlunoService
    {
        AlunoDTO Obter(int matricula);

        Task<IEnumerable<Aluno>> ObterAlunos();
    
        void AdicionarAluno(AlunoDTO aluno);

        void AtualizarAluno(AlunoDTO aluno);

        void Excluir(int matricula);
    }
}