using AbstractFactory.Factory.Abstractas;
using AbstractFactory.Servicios.Abstractas;
using AbstractFactory.Servicios.Concretas.Soap;

namespace AbstractFactory.Factory.Concretas
{
    class SoapServiceStackImpl : IServiceStackAbstractFactory
    {
        public IEmployeeService getEmployeeService()
        {
            return new EmployeeServiceSoap();
        }

        public IProductService getProductService()
        {
            return new ProductServiceSoap();
        }
    }
}
