using FactoryMethod.Adaptadores.Abstractas;
using FactoryMethod.Adaptadores.Concretas;
using static FactoryMethod.Constantes.Enumeraciones;

namespace FactoryMethod.Factory
{
    public class DBFactoryAdapter
    {
        public static IDBAdapter getAdapter(DBTypeDB type) {
            switch (type)
            {
                case DBTypeDB.MYSQL:
                    return new MySQLAdapter();
                case DBTypeDB.ORACLE:
                    return new OracleAdapter();
                default:
                    return null;
            }
        }
    }
}
