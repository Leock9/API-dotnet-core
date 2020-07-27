using System.Collections.Generic;
using System.Threading.Tasks;
using TesteApi.AlunoModel;
using TesteApi.DTO.AlunoDTO;
using TesteApi.Factories.AlunoDTOFactory;
using TesteApi.Factories.AlunoFactory;
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

        public AlunoDTO Obter(int matricula)
        {
            var aluno = _alunoRepository.Obter(matricula);

            return AlunoDTOFactory.Criar(aluno);
        }

        public async Task<IEnumerable<Aluno>> ObterAlunos()
        {
            return await _alunoRepository.ObterAlunos();
        }

        public void AdicionarAluno(AlunoDTO aluno)
        {
            var alunoExiste = _alunoRepository.AlunoExiste(aluno.Matricula);

            if (!alunoExiste)
            {
                var alunoModel = AlunoFactory.CriarAdicionar(aluno);

                _alunoRepository.AdicionarAluno(alunoModel);
            }
        }

        public void AtualizarAluno(AlunoDTO aluno)
        {
            var alunoExiste = _alunoRepository.AlunoExiste(aluno.Matricula);

            if (alunoExiste)
            {
                var alunoModel = AlunoFactory.CriarAtualizar(aluno);

                _alunoRepository.AtualizarAluno(alunoModel);
            }
        }

        public void Excluir(int matricula)
        {
            _alunoRepository.Excluir(matricula);
        }
    }
}