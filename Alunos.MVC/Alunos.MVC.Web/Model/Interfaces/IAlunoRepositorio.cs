using Alunos.MVC.Web.Model.Entidades;

namespace Alunos.MVC.Web.Model.Interfaces
{
	public interface IAlunoRepositorio
	{
		void Alterar(Aluno entity);


		List<Aluno> BuscarTodos();


		Aluno BuscarPorId(int id);


		void Excluir(int id);

		void Inserir(Aluno entity);

	}
}
