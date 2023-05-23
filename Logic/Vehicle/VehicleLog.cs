using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Send;
using Data.Vehicle;

namespace Logic.Vehicle
{
    public class VehicleLog
    {
        VehicleDat objVehicle = new VehicleDat();
        public DataSet showVehicle()
        {
            return objVehicle.showVehicle();
        }
        public bool saveVehicle(string _plate_vehicle, int _model_vehicle, string _type_vehicle, string _capacityLoading_vehicle, int _id_driver)
        {
            return objVehicle.saveVehicle(_plate_vehicle, _model_vehicle, _type_vehicle, _capacityLoading_vehicle, _id_driver);
        }

        public bool updateVehicle(int _id_vehicle, string _plate_vehicle, int _model_vehicle, string _type_vehicle, string _capacityLoading_vehicle, int _id_driver)
        {
            return objVehicle.updateVehicle(_id_vehicle, _plate_vehicle, _model_vehicle, _type_vehicle, _capacityLoading_vehicle, _id_driver);

        }

        public bool deleteVehicle(int _id_vehicle)
        {
            return objVehicle.deleteVehicle(_id_vehicle);
        }
    }
}
