using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using padrao.Data;
using padrao.Models;
using padrao.Repositories;
using padrao.Repositories.Interfaces;

namespace padrao.Controllers{

    [Route("api/[controller]")]
    [ApiController]

    public class ImpostosController: ControllerBase{

        private readonly IImpostosRepository _impostosRepository;
        private readonly ImpostosDBContex _context;


        public ImpostosController(IImpostosRepository impostoRepository, ImpostosDBContex context){
            _impostosRepository = impostoRepository;
            _context= context;
        }

        [HttpGet]
        public async Task <ActionResult<List<ImpModels>>> FindAll(){
            try{
            List<ImpModels> imps= await _impostosRepository.FindAllImp();
            return Ok(imps);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task <ActionResult<ImpModels>> FindById(int id){
            try{
            ImpModels imps= await _impostosRepository.FindOneImp(id);
            return Ok(imps);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }

        }

                // using (var context =new ImpostosDBContex(new DbContextOptions<ImpostosDBContex>()))
        [HttpGet("/porimp")]
        public async Task <ActionResult<List<ImpModels>>> FindByExerc(){
            try{
                    var teste = _context.Imp.Where(p=> p.exercicio== "2022");
                    return Ok(teste);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }

        }

        [HttpPost()]
        public async Task <ActionResult<ImpModels>> Add([FromBody] ImpModels impModels){
            try{
            ImpModels imps= await _impostosRepository.AddImp(impModels);
            return Ok(imps);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }

        }

        [HttpPut("{id}")]
        public async Task <ActionResult<ImpModels>> Patch([FromBody] ImpModels impModels, int id){
            try{
                impModels.Id= id;
                ImpModels imposto= await _impostosRepository.PatchImp(impModels,id);
                return Ok(imposto);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ImpModels>> Delete(int id){
            try{
                bool apagado= await _impostosRepository.DeleteImp(id);
                return Ok(apagado);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }
        
        
    }


}

// teste branch