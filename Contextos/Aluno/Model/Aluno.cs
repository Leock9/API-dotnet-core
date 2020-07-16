using System;

namespace TesteApi.AlunoModel
{
    public sealed class Aluno
    {
        public Aluno(string nome, int idade, int matricula, bool status)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
            Status = status;
        }

        public Aluno(Guid id, string nome, int idade, int matricula, bool status)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
            Status = status;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public int Matricula { get; private set; }
        public bool Status { get; private set; }
    }
}