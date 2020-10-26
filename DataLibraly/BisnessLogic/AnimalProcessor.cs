using DataLibraly;
using DataLibraly.DataAccess;
using DataLibraly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibraly.BisnessLogic
{
    public static class AnimalProcessor
    {
        public static int CreateAnimal(int id, string first_name, string last_name, string message)
        {
            AnimalModel data = new AnimalModel
            {
                id = id,
                first_name = first_name,
                last_name = last_name,
                message = message
            };

            string sql = @"INSERT INTO db.Owners(id, first_name, last_name, message) VALUE (@id, @first_name, @last_name, @message);";

            return SqlDataAccess.SaveData(sql,data);
        }

        public static List<AnimalModel>LoadAnimal()
        {
            string sql = "SELECT * FROM db.Owners;";
        
            return SqlDataAccess.LoadData<AnimalModel>(sql);
        }
    }
}