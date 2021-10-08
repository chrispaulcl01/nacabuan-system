using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.functions
{
    class Dashboard
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public bool AddData(string pet_id, string owners_name, string patient_name, string contact_no, string gender, string birthday, string age, 
            string animal_species, string animal_breed, DateTime date
            )
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO dss_database.add_animal(pet_id, owners_name, patient_name,contact_no, gender, birthday, age, animal_species,
                                                                        animal_breed, date)
                                                                VALUES(@pet_id, @owners_name, @patient_name, @contact_no, @gender, @birthday, @age,
                                                                        @animal_species, @animal_breed, @date);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@owners_name", owners_name);
                        cmd.Parameters.AddWithValue("@patient_name", patient_name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@birthday", birthday);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@animal_species", animal_species);
                        cmd.Parameters.AddWithValue("@animal_breed", animal_breed);
                        cmd.Parameters.AddWithValue("@contact_no", contact_no);
                        cmd.Parameters.AddWithValue("@date", date);
                        



                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error adding value: " + e.ToString());
                return false;
            }
        }
    }

}
