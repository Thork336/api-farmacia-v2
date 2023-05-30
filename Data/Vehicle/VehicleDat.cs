using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Data.Vehicle
{
    public class VehicleDat
    {
        Persistence objPer = new Persistence();
        public DataSet showVehicle()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procSelectVehicle";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.CloseConnection();
            return objData;
        }
        public DataSet showVehicleDDL()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procSelectDriverDDL";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.CloseConnection();
            return objData;
        }

        public bool saveVehicle(string _plate_vehicle, int _model_vehicle, string _type_vehicle, string _capacityLoading_vehicle, int _id_driver)
        {
            bool executed = false;
            int row;
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procInsertVehicle";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("plate_vehicle", MySqlDbType.VarChar).Value = _plate_vehicle;
            objSelectCmd.Parameters.Add("model_vehicle", MySqlDbType.Int32).Value = _model_vehicle;
            objSelectCmd.Parameters.Add("type_vehicle", MySqlDbType.VarChar).Value = _type_vehicle;
            objSelectCmd.Parameters.Add("capacityLoading_vehicle", MySqlDbType.VarChar).Value = _capacityLoading_vehicle;
            objSelectCmd.Parameters.Add("id_driver", MySqlDbType.Int32).Value = _id_driver;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.ToString());
            }
            objPer.CloseConnection();
            return executed;
        }

        public bool updateVehicle(int _id_vehicle, string _plate_vehicle, int _model_vehicle, string _type_vehicle, string _capacityLoading_vehicle, int _id_driver)
        {
            bool executed = false;
            int row;
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procUpdateVehicle";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_vehicle", MySqlDbType.Int32).Value = _id_vehicle;
            objSelectCmd.Parameters.Add("plate_vehicle", MySqlDbType.VarChar).Value = _plate_vehicle;
            objSelectCmd.Parameters.Add("model_vehicle", MySqlDbType.Int32).Value = _model_vehicle;
            objSelectCmd.Parameters.Add("type_vehicle", MySqlDbType.VarChar).Value = _type_vehicle;
            objSelectCmd.Parameters.Add("capacityLoading_vehicle", MySqlDbType.VarChar).Value = _capacityLoading_vehicle;
            objSelectCmd.Parameters.Add("id_driver", MySqlDbType.Int32).Value = _id_driver;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.ToString());
            }
            objPer.CloseConnection();
            return executed;
        }

        public bool deleteVehicle(int _id_vehicle)
        {
            bool executed = false;
            int row;
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procDeleteVehicle";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_vehicle", MySqlDbType.Int32).Value = _id_vehicle;
            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.ToString());
            }
            objPer.CloseConnection();
            return executed;
        }
    }
}
