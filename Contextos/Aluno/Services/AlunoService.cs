using System.Collections.Generic;
using System.Threading.Tasks;
using TesteApi.AlunoModel;
using TesteApi.Interface.Repositories.IAlunoRepository;
using TesteApi.Interface.Services.IAlunoService;

namespace TesteApi.Services.AlunoService 
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public Aluno Obter(int matricula)
        {
            return _alunoRepository.Obter(matricula);
        }

        public async Task<IEnumerable<Aluno>> ObterAlunos()
        {
            return await _alunoRepository.ObterAlunos();
        }

        public void AdicionarAluno(string aluno)
        {
            // _alunoRepository.AdicionarAluno(aluno);
        }
    }
}