using WebApi.Abstractions;
using WebApi.Classes;

namespace WebApi.Providers
{
    public class PruebaProvider
    {
        SingletonPruebaProvider SingletonPruebaProvider;
        public PruebaProvider(){
            SingletonPruebaProvider = new SingletonPruebaProvider();
        }

        public ServiceResponse Test(){
            ServiceResponse Response = new ServiceResponse();
            
            Response.result = true;
            Response.object_result = new {
                test = "Prueba"
            };

            return Response;
        }
        
    }
    
}