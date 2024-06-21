using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebApi.Models;
using System.Linq;

namespace SmartSchool.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome= "Marcos",
                Sobrenome = "Bart",
                Telefone = "12345678"
            },
            new Aluno(){
                Id = 2,
                Nome= "Aurelio",
                Sobrenome = "Simpson",
                Telefone = "3425345345"
            },
            new Aluno(){
                Id = 3,
                Nome= "Santos",
                Sobrenome = "sk8",
                Telefone = "08798768"
            }
        };
        public AlunoController(){}

        [HttpGet]
        public IActionResult Get(){
            return Ok(Alunos);
        }
        
         [HttpGet("ById/{id}")]
        public IActionResult GetById(int id){
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("o aluno não foi encontrado");
            return Ok(aluno);
        }

         [HttpGet("{ByName}")]
        public IActionResult GetByName(string nome, string Sobrenome){
            var aluno = Alunos.FirstOrDefault(a => 
            a.Nome.Contains(nome) && a.Sobrenome.Contains(Sobrenome)
            );
            if (aluno == null) return BadRequest("o aluno não foi encontrado");
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno){
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno){
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno){
            return Ok(aluno);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            return Ok();
        }
    }
}