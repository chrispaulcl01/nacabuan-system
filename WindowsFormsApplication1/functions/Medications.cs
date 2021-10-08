using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1.functions
{
    class Medications
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public bool UpdateMedication(string pet_id, string medication)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE dss_database.medication
                                    SET medication = @medication
                                    WHERE pet_id = @pet_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@medication", medication);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating medication: " + ex.ToString());
                return false;
            }
        }
    }
}
