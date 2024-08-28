using Alunos.MVC.Web.Model.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Alunos.MVC.Web.Dados.Map
{
	public class AlunoMap : IEntityTypeConfiguration<Aluno>
	{
		public void Configure(EntityTypeBuilder<Aluno> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Nome)
				.HasColumnType("nvarchar(150)")
				.IsRequired();

			builder.Property(x => x.Endereco)
				.HasColumnType("nvarchar(150)")
				.IsRequired();

			builder.Property(x => x.Email)
				.HasColumnType("nvarchar(150)")
				.IsRequired();

			//builder.Property(x => x.Status)
			//	.IsRequired();

		}
	}
}
