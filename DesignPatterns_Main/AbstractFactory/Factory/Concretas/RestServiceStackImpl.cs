using AbstractFactory.Factory.Abstractas;
using AbstractFactory.Servicios.Abstractas;
using AbstractFactory.Servicios.Concretas.RestFull;

namespace AbstractFactory.Factory.Concretas
{
    public class RestServiceStackImpl : IServiceStackAbstractFactory
    {
        public IEmployeeService getEmployeeService()
        {
            return new EmployeeServiceRestFull();
        }

        public IProductService getProductService()
        {
            return new ProductServiceRestFull();
        }
    }
}
