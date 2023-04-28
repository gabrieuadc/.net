using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using padrao.Data;
using padrao.Models;
using padrao.Repositories.Interfaces;

namespace padrao.Controllers{


    [Route("/custo")]
    [ApiController]
    public class CustoController: ControllerBase{

        private readonly ICustoRepository _custoRepository;
        private readonly CustoDBContext _context;

        public CustoController(ICustoRepository icustoRepository, CustoDBContext custoDBContext){
            this._context= custoDBContext;
            this._custoRepository= icustoRepository;
        }
        
        [Authorize]
        [HttpGet]
        public async Task <ActionResult<List<CustoModel>>> FindAll(){
        try{
            List<CustoModel> custos= await _custoRepository.FindAllCusto();
            return Ok(custos);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task <ActionResult<CustoModel>>  FindOne(int id){
            try{
                CustoModel custo = await _custoRepository.FindOneCusto(id);
                return(custo);

            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }

        [HttpPost]
        public async Task <ActionResult<CustoModel>>  Add([FromBody]CustoModel custoModel){
            try{
                CustoModel custo = await _custoRepository.AddCusto(custoModel);
                return(custo);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }


        }

        [HttpPut("{id}")]
        public async Task <ActionResult<CustoModel>>  Patch([FromBody] CustoModel custoModel, int id){
            try{
                custoModel.id= id;
                CustoModel custo= await _custoRepository.PatchCusto(custoModel,id);
                return Ok(custo);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task <ActionResult<CustoModel>> Delete(int id){
        try{
                bool apagado= await _custoRepository.DeleteCusto(id);
                return Ok(apagado);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }



    }


}