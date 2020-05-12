using AbstractFactory.Servicios.Abstractas;

namespace AbstractFactory.Factory.Abstractas
{
    public interface IServiceStackAbstractFactory
    {
        public IEmployeeService getEmployeeService();

        public IProductService getProductService();
    }
}
