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
    class Booking
    {

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void LoadBooking(string schedule, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT name AS 'Name', pet_type AS 'Pet Type', contacts AS 'Contacts', schedule AS 'Date Schedule'
                                    FROM dss_database.add_booking
                                    WHERE schedule = @schedule;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@schedule", schedule);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading booking: " + ex.ToString());
            }
        }
    }
}
