using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteApi.AlunoModel;
using TesteApi.DTO.AlunoDTO;
using TesteApi.Interface.Services.IAlunoService;

namespace TesteApi.AlunoController
{
    [Route("Aluno")]
    public class AlunoController : Controller
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [Route("Obter/Matricula")]
        [HttpGet]
        public IActionResult Obter([FromQuery] int matricula)
        {
           return Ok (_alunoService.Obter(matricula)); 
        }

        [Route("Obter/Alunos")]
        [HttpGet]
        public async Task<IEnumerable<Aluno>> ObterAlunos()
        {
            return await _alunoService.ObterAlunos();
        }

        [Route("Adicionar")]
        [HttpPost]
        public void AdicionarAluno([FromBody] AlunoDTO aluno)
        {
            _alunoService.AdicionarAluno(aluno);
        }

        [Route("Atualizar")]
        [HttpPut]
        public void AtualizarAluno([FromBody] AlunoDTO aluno) 
        {
            _alunoService.AtualizarAluno(aluno);
        }

        [Route("Excluir")]
        [HttpDelete]
        public void Excluir([FromQuery] int matricula) 
        {
            _alunoService.Excluir(matricula);
        }
    }    
}