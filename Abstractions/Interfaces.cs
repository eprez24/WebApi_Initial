using WebApi.Providers;

namespace WebApi.Abstractions
{
    public interface IProvider<T>
    {
        T Instance { get; set; }
    }

    public interface IPruebaProvider : IProvider<PruebaProvider>
    {        
    }
    public class SingletonPruebaProvider : IPruebaProvider
    {
        PruebaProvider instance;
        public PruebaProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PruebaProvider();
                }
                return instance;
            }
            set { instance = value; }
        }       
    }
    
}