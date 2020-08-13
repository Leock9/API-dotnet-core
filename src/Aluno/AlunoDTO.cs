using System;
using TesteApi.StatusEnum;

namespace TesteApi.DTO.AlunoDTO 
{
    public class AlunoDTO 
    {
        public Guid? Id { get; set; }
        public string Nome { get;  set; }
        public int Idade { get;  set; }
        public int Matricula { get;  set; }
        public Status Status { get;   set; }
    }
}