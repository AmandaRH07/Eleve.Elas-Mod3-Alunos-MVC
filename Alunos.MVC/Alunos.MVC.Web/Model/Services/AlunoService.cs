using Alunos.MVC.Web.Dados;
using Alunos.MVC.Web.Dados.Repositorios;
using Alunos.MVC.Web.Model.Entidades;

namespace Alunos.MVC.Web.Model.Services
{
    public class AlunoService
    {
		protected readonly AlunosMvcContexto _contexto;

        public AlunoService(AlunosMvcContexto contexto)
        {
			_contexto = contexto;
		}

        public List<Aluno> BuscarTodos()
		{
			AlunoRepositorio alunoRepositorio = new AlunoRepositorio(_contexto);

			return alunoRepositorio.BuscarTodos();
		}

		public Aluno BuscarPorId(int id)
		{
			AlunoRepositorio alunoRepositorio = new AlunoRepositorio(_contexto);

			return alunoRepositorio.BuscarPorId(id);
		}

		public void IncluirAluno(Aluno aluno)
        {
			AlunoRepositorio alunoRepositorio = new AlunoRepositorio(_contexto);

			alunoRepositorio.Inserir(aluno);
		}

		public void AlterarAluno(Aluno aluno)
		{
			AlunoRepositorio alunoRepositorio = new AlunoRepositorio(_contexto);

			alunoRepositorio.Alterar(aluno);
		}

		public void ExcluirAluno(int id)
		{
			AlunoRepositorio alunoRepositorio = new AlunoRepositorio(_contexto);

			alunoRepositorio.Excluir(id);
		}
	}
}
