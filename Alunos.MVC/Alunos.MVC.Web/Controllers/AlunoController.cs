using Alunos.MVC.Web.Dados;
using Alunos.MVC.Web.Model.Entidades;
using Alunos.MVC.Web.Model.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Alunos.MVC.Web.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class AlunoController : ControllerBase
	{
		protected readonly AlunosMvcContexto _contexto;

		public AlunoController(AlunosMvcContexto contexto)
		{
			_contexto = contexto;
		}

		// GET: api/<AlunoController>
		[HttpGet]
		public IActionResult Get()
		{
			AlunoService alunoService = new AlunoService(_contexto);
			return Ok(alunoService.BuscarTodos());
		}

		// GET api/<AlunoController>/5
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			AlunoService alunoService = new AlunoService(_contexto);
			return Ok(alunoService.BuscarPorId(id));
		}

		// POST api/<AlunoController>
		[HttpPost]
		public IActionResult Post([FromBody] Aluno aluno)
		{
			AlunoService alunoService = new AlunoService(_contexto);
			alunoService.IncluirAluno(aluno);

			return Ok(aluno);
		}

		// PUT api/<AlunoController>/5
		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] Aluno editValues)
		{
			AlunoService alunoService = new AlunoService(_contexto);
			var aluno = alunoService.BuscarPorId(id);

			aluno.AlterarAluno(editValues.Nome, editValues.Endereco, editValues.Email, editValues.Status);

			alunoService.AlterarAluno(aluno);
			return Ok(aluno);
		}

		// DELETE api/<AlunoController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			AlunoService alunoService = new AlunoService(_contexto);

			alunoService.ExcluirAluno(id);
			return Ok();
		}
	}
}
