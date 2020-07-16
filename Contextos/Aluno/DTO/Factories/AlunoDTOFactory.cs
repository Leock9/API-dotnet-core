using TesteApi.AlunoModel;
using TesteApi.DTO.AlunoDTO;

namespace TesteApi.Factories.AlunoDTOFactory 
{
    public static class AlunoDTOFactory 
    {
        public static AlunoDTO Criar(Aluno aluno) 
        {
            return new AlunoDTO 
            {
                Id = aluno.Id,
                Nome = aluno.Nome,
                Idade = aluno.Idade,
                Matricula = aluno.Matricula,
                Status = aluno.Status
            };
        }
    }
}