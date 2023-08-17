using AdministracionUsuario.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AdministracionUsuario.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        public readonly ApplicationDbContext context;
        public UsuarioController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuarios>>> GetUsuarios()
        {
            return await context.Usuarios.ToListAsync();
        }

        [HttpGet("Departamento")]
        public async Task<ActionResult<List<Departamento>>> GetDepartamentos()
        {
            return await context.Departamento.ToListAsync();
        }

        [HttpGet("Cargos")]
        public async Task<ActionResult<List<cargos>>> GetCargos()
        {
            return await context.cargos.ToListAsync();
        }

       
        [HttpPost]
        public async Task<ActionResult> Post(Usuarios usuarios)
        {
            context.Add(usuarios);
            await context.SaveChangesAsync();
            return Ok();//prueba
            //prueb
        } 

        [HttpPut]
        public async Task<ActionResult> Put(Usuarios usuarios)
        {
            
            context.Update(usuarios);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{usuario}")]
        public async Task<IActionResult> Delete(string usuario)
        {
            var userToDelete = await context.Usuarios.FirstOrDefaultAsync(u => u.usuario == usuario);

            if (userToDelete == null)
            {
                return NotFound(); // Retorna un código 404 si el usuario no existe
            }

            context.Usuarios.Remove(userToDelete);
            await context.SaveChangesAsync();

            return NoContent(); // Retorna un código 204 (sin contenido) para una eliminación exitosa
        }



    }
}
