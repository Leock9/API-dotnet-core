using System.Collections.Generic;
using System.Threading.Tasks;
using TesteApi.AlunoModel;
using TesteApi.DTO.AlunoDTO;
using TesteApi.Factories.AlunoFactory;
using TesteApi.Interface.IUnitOfWork;
using TesteApi.Interface.Repositories.IAlunoRepository;
using TesteApi.Interface.Services.IAlunoService;

namespace TesteApi.Services.AlunoService
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AlunoService(IAlunoRepository alunoRepository, IUnitOfWork unitOfWork)
        {
            _alunoRepository = alunoRepository;
            _unitOfWork = unitOfWork;
        }

        public AlunoDTO Obter(int matricula)
        {
            var aluno = _alunoRepository.Obter(matricula);

            return AlunoFactory.Criar(aluno);
        }

        public async Task<IEnumerable<Aluno>> ObterAlunos()
        {
            return await _alunoRepository.ObterAlunos();
        }

        public void Adicionar(AlunoDTO aluno)
        {
            var alunoExiste = _alunoRepository.Existe(aluno.Matricula);

            if (alunoExiste)
            {
                return;
            }

            var alunoModel = AlunoFactory.CriarAdicionar(aluno);

            _alunoRepository.Adicionar(alunoModel);

            _unitOfWork.Salvar();
        }

        public void Atualizar(AlunoDTO aluno)
        {
            var alunoExiste = _alunoRepository.Existe(aluno.Matricula);

            if (!alunoExiste)
            {
                return;
            }

            var alunoModel = AlunoFactory.CriarAtualizar(aluno);

            _alunoRepository.Atualizar(alunoModel);

            _unitOfWork.Salvar();
        }

        public void Excluir(int matricula)
        {
            _alunoRepository.Excluir(matricula);

            _unitOfWork.Salvar();
        }
    }
}