using Alunos.MVC.Web.Model.Entidades;
using Alunos.MVC.Web.Model.Interfaces;

namespace Alunos.MVC.Web.Dados.Repositorios
{
    public class AlunoRepositorio : IAlunoRepositorio
	{
		protected readonly AlunosMvcContexto _contexto;

		public AlunoRepositorio(AlunosMvcContexto contexto)
		{
			_contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
		}

		public void Alterar(Aluno entity)
		{
			_contexto.Set<Aluno>().Update(entity);
			_contexto.SaveChanges();
		}

		public List<Aluno> BuscarTodos()
		{
			return _contexto.Set<Aluno>().ToList();
		}

		public Aluno BuscarPorId(int id)
		{
			return _contexto.Set<Aluno>().FirstOrDefault(x => x.Id == id);
		}

		public void Excluir(int id)
		{
			var entity = BuscarPorId(id);
			_contexto.Set<Aluno>().Remove(entity);
			_contexto.SaveChanges();
		}

		public void Inserir(Aluno entity)
		{
			_contexto.Set<Aluno>().Add(entity);
			_contexto.SaveChanges();
		}

		public void Dispose()
		{
			_contexto.Dispose();
		}
	}
}
