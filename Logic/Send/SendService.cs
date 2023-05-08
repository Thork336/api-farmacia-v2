using Data.Send;
using System.Data;

namespace Logic.Send
{
    public class SendService
    {
        private SendRepository _repository;

        public DataSet list()
        {
            return this._repository.list();
        }

        public bool update(int id_shipping, int number_shipping, string address_shipping, int phone_shipping, int id_driver)
        {
            return this._repository.updatde(id_shipping, number_shipping, address_shipping, phone_shipping, id_driver);
        }

        public bool insert(int number_shipping, string address_shipping, int phone_shipping, int id_driver)
        {
            return this._repository.insert(number_shipping, address_shipping, phone_shipping, id_driver);
        }

        public bool delete(int id_shipping)
        {
            return _repository.delete(id_shipping);
        }
    }
}