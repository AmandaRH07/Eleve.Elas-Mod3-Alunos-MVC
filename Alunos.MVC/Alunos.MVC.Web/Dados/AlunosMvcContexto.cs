using Alunos.MVC.Web.Dados.Map;
using Alunos.MVC.Web.Model.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Alunos.MVC.Web.Dados
{
	public class AlunosMvcContexto : DbContext
	{
		public DbSet<Aluno> Aluno { get; set; }
		//public DbSet<Professor> Professor { get; set; }
		//public DbSet<Curso> Curso { get; set; }
		//public DbSet<Matricula> Matricula { get; set; }

		public AlunosMvcContexto(DbContextOptions<AlunosMvcContexto> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AlunoMap());
			base.OnModelCreating(modelBuilder);

			//modelBuilder.ApplyConfiguration(new CursoMap());
			//base.OnModelCreating(modelBuilder);

			//modelBuilder.ApplyConfiguration(new ProfessorMap());
			//base.OnModelCreating(modelBuilder);

			//modelBuilder.ApplyConfiguration(new MatriculaMap());
			//base.OnModelCreating(modelBuilder);
		}

	}
}
