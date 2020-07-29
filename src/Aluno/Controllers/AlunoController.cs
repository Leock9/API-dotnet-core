using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteApi.AlunoModel;
using TesteApi.DTO.AlunoDTO;
using TesteApi.Interface.Services.IAlunoService;

namespace TesteApi.AlunoController
{
    [Route("alunos")]
    public class AlunoController : Controller
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [Route("{matricula:int}")]
        [HttpGet]
        public ActionResult Obter(int matricula)
        {
           return Ok (_alunoService.Obter(matricula)); 
        }

        [HttpGet]
        public async Task<IEnumerable<Aluno>> ObterAlunos()
        {
            return await _alunoService.ObterAlunos();
        }

        [HttpPost]
        public void Adicionar([FromBody] AlunoDTO aluno)
        {
            _alunoService.AdicionarAluno(aluno);
        }

        [HttpPut]
        public void Atualizar([FromBody] AlunoDTO aluno) 
        {
            _alunoService.AtualizarAluno(aluno);
        }

        [HttpDelete]
        public void Excluir([FromQuery] int matricula) 
        {
            _alunoService.Excluir(matricula);
        }
    }    
}