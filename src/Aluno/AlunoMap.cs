using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteApi.AlunoModel;

namespace TesteApi.Data.AlunoMap 
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(aluno => aluno.Id);

            builder.Property(aluno => aluno.Id).IsRequired();

            builder.Property(aluno => aluno.Nome).IsRequired().HasMaxLength(120);

            builder.Property(aluno => aluno.Idade).IsRequired();

            builder.Property(aluno => aluno.Matricula).IsRequired().HasMaxLength(5);

            builder.Property(aluno => aluno.Status).IsRequired().HasColumnType("bit");
        }
    }
}