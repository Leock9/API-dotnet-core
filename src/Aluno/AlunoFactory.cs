using TesteApi.AlunoModel;
using TesteApi.DTO.AlunoDTO;

namespace TesteApi.Factories.AlunoFactory 
{
    public static class AlunoFactory 
    {
        public static Aluno CriarAtualizar(AlunoDTO alunoDTO) 
        {
            return new Aluno
            (
                alunoDTO.Id.Value,
                alunoDTO.Nome,
                alunoDTO.Idade,
                alunoDTO.Matricula,
                alunoDTO.Status
            );
        }

        public static Aluno CriarAdicionar(AlunoDTO alunoDTO) 
        {
            return new Aluno
            (
                alunoDTO.Nome,
                alunoDTO.Idade,
                alunoDTO.Matricula,
                alunoDTO.Status
            );
        }

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