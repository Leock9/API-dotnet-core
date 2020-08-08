using System;

namespace TesteApi.DTO.AlunoDTO 
{
    public class AlunoDTO 
    {
        public Guid? Id { get; set; }
        public string Nome { get;  set; }
        public int Idade { get;  set; }
        public int Matricula { get;  set; }
        public bool Status { get;   set; }
    }
}