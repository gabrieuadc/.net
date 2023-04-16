using Microsoft.AspNetCore.Mvc;
using padrao.Models;
using padrao.Repositories;
using padrao.Repositories.Interfaces;

namespace padrao.Controllers{


    [Route("/service")]
    [ApiController]
    public class ServicesController:ControllerBase{

        private readonly IServiceRepository _servicerepository;

        public ServicesController(IServiceRepository serviceRepository){
            _servicerepository= serviceRepository;

        }


        [HttpGet]
        public async Task<ActionResult<List<ServiceModel>>> FindAll(){
            try {
                List<ServiceModel> services = await _servicerepository.FindAllService();
                return Ok(services);
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }

        }


        [HttpGet("{id}")]
        public async Task <ActionResult<ServiceModel>> FindById(int id){
            try{
                ServiceModel services = await _servicerepository.FindById(id);
                return Ok(services);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceModel>> Add([FromBody] ServiceModel serviceModel){
            try{
                ServiceModel services = await _servicerepository.Add(serviceModel);
                return Ok(services);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceModel>> Patch([FromBody] ServiceModel serviceModel, int id){
            try{
                serviceModel.id= id;
                ServiceModel services = await _servicerepository.Patch(serviceModel,id);
                return Ok(services);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceModel>> Delete(int id){
            try{
                bool apagado= await _servicerepository.Delete(id);
                return Ok(apagado);
            }
            catch(Exception ex){
                return StatusCode(StatusCodes.Status502BadGateway,$"Error:{ex.Message}");
            }
        }




    }

}
    