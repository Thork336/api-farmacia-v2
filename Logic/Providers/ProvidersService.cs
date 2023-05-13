using Data.Providers;
using System.Data;

namespace Logic.Providers
{
    public class ProvidersService
    {
        private ProvidersRepository Repository = new ProvidersRepository();

        public DataSet list()
        {
            return this.Repository.list();
        }

        public bool update(int id_provider, int nit_provider, string name_provider, string city_provider)
        {
            return this.Repository.update(id_provider, nit_provider, name_provider, city_provider);
        }

        public bool insert(int nit_provider, string name_provider, string city_provider)
        {
            return this.Repository.insert(nit_provider, name_provider, city_provider);
        }

        public bool delete(int id_provider)
        {
            return this.Repository.delete(id_provider);
        }
    }
}