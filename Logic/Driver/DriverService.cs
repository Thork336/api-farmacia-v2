using Data;
using Data.Driver;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic.Driver
{
    public class DriverService
    {
        private DriverRepository Repository = new DriverRepository();

        public DataSet list()
        {
            return this.Repository.list();
        }

        public bool update(int id_driver, int identification_driver, string numberLicence_driver,
            string name_driver, string surname_driver, string phone_driver, int age_driver, string gender_driver,
            string type_license)
        {
            return this.Repository.update(id_driver, identification_driver, numberLicence_driver,
            name_driver, surname_driver, phone_driver, age_driver, gender_driver,
            type_license);
        }

        public bool insert(int identification_driver, string numberLicence_driver,
            string name_driver, string surname_driver, string phone_driver, int age_driver, string gender_driver,
            string type_license)
        {
            return this.Repository.insert(identification_driver, numberLicence_driver,
            name_driver, surname_driver, phone_driver, age_driver, gender_driver,
            type_license);
        }

        public bool delete(int id_driver)
        {
            return this.Repository.delete(id_driver);
        }
    }
}