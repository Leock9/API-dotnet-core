using System.Collections.Generic;
using System.Threading.Tasks;
using TesteApi.AlunoModel;


namespace TesteApi.Interface.Repositories.IAlunoRepository
{
    public interface IAlunoRepository
    {
        Aluno Obter(int matricula);

        Task<IEnumerable<Aluno>> ObterAlunos();

        void Adicionar(Aluno aluno);

        bool Existe(int matricula);

        void Atualizar(Aluno aluno);

        void Excluir(int matricula);
    }
}