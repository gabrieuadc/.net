using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using padrao.Models;
using padrao.Repositories.Interfaces;

namespace padrao.Controllers

{
    [Route("api/[controller]")]
    [ApiController]

    public class UsuarioController: ControllerBase{
        private readonly IUsuariosRepository _usuariorepository;

        public UsuarioController(IUsuariosRepository usuariorepository){
            _usuariorepository= usuariorepository;
        }

        [HttpGet]
        public async Task <ActionResult<List<UsuarioModel>>> FindAll(){
            try{
                List<UsuarioModel> usuarios= await _usuariorepository.FindAllUser();
                return Ok(usuarios);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }

        }

        [HttpGet("{id}")]
        public async Task <ActionResult<UsuarioModel>> FindById(int id){
            try{
                UsuarioModel usuarios= await _usuariorepository.FindById(id);
                return Ok(usuarios);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }

        }

        [HttpPost()]
        public async Task <ActionResult<UsuarioModel>> Add([FromBody] UsuarioModel usuarioModel){
            try{
                UsuarioModel usuario= await _usuariorepository.Add(usuarioModel);
                return Ok(usuario);
            }
            catch(Exception ex){
                 return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }

        }

        [HttpPost("/login")]
        public async Task <ActionResult<dynamic>> Login([FromBody] UsuarioModel usuarioModel){
            try{
                UsuarioModel usuario= await _usuariorepository.FindById(usuarioModel.Id);
                if(usuario!= null){
                    var token = Authent.TokenService.GenerateToken(usuario);
                    return Ok("Autenticado "+ token);
                }
                else{
                    return StatusCode(StatusCodes.Status404NotFound,"User not found");
                }
            }
            catch(Exception ex){
                 return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }

        }


        [HttpPut("{id}")]
        public async Task <ActionResult<UsuarioModel>> Patch([FromBody] UsuarioModel usuarioModel, int id){
            try{
                usuarioModel.Id= id;
                UsuarioModel usuario= await _usuariorepository.Patch(usuarioModel,id);
                return Ok(usuario);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<UsuarioModel>> Delete(int id){
            try{
                bool apagado= await _usuariorepository.Delete(id);
                return Ok(apagado);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }



    }


}