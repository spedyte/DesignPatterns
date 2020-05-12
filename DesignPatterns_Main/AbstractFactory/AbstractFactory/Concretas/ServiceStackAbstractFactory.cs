using AbstractFactory.Factory.Abstractas;
using AbstractFactory.Factory.Concretas;
using static AbstractFactory.Constantes.Constantes;

namespace AbstractFactory.AbstractFactory.Concretas
{
    public class ServiceStackAbstractFactory
    {
        public static IServiceStackAbstractFactory createServiceFactory(ServiceType type)
        {
            switch (type)
            {
                case ServiceType.SOAP:
                    return new SoapServiceStackImpl();
                case ServiceType.REST_FULL:
                    return new RestServiceStackImpl();
                default:
                    return null;
            }
        }
    }
}
