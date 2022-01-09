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
    class Patient
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void LoadPatients(DataGridView grid, string date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owner Name', patient_name AS 'Patient Name', 
                                    gender AS 'Gender', birthday AS 'Birthdate', age AS 'Age'
                                    FROM dss_database.add_animal WHERE date_format(date, '%m/%d/%y') = @date";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@date", date);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading patients: " + ex.ToString());
            }

        }
        public bool GetPatient(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * from dss_database.add_animal WHERE pet_id = @pet_id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.PetID = dt.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dt.Rows[0].Field<string>("owners_name");
                            val.Patientname = dt.Rows[0].Field<string>("patient_name");
                            val.Contactno = dt.Rows[0].Field<string>("contact_no");
                            val.Gender = dt.Rows[0].Field<string>("gender");
                            val.Birthday = dt.Rows[0].Field<string>("birthday");
                            val.Age = dt.Rows[0].Field<string>("age");
                            val.Animalspecies = dt.Rows[0].Field<string>("animal_species");
                            val.Animalbreed = dt.Rows[0].Field<string>("animal_breed");

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting patient" + ex.ToString());

                return false;

            }
        }
        public void LoaddPatients(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owner Name', patient_name AS 'Patient Name', 
                                    gender AS 'Gender', birthday AS 'Birthdate', age AS 'Age', animal_breed AS 'Animal Breed'
                                    FROM dss_database.add_animal";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading patients: " + ex.ToString());
            }

        }
        public bool Symptoms(string pet_id, string body_temp, string stool, string behav_att, string appetite, string drink, string weight, string notice, string diagnosis)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO dss_database.symptoms(pet_id, body_temp, stool, behav_att, appetite, drink, weight, notice, diagnosis)
                                                              values (@pet_id, @body_temp, @stool, @behav_att, @appetite, @drink, @weight, @notice, @diagnosis)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@body_temp", body_temp);
                        cmd.Parameters.AddWithValue("@stool", stool);
                        cmd.Parameters.AddWithValue("@behav_att", behav_att);
                        cmd.Parameters.AddWithValue("@appetite", appetite);
                        cmd.Parameters.AddWithValue("@drink", drink);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@notice", notice);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                return false;
            }
        }

        public bool Savedpatient(string pet_id, string owners_name, string patient_name, string age, string gender, string birthday, string animal_species,
            string animal_breed, string contact_no, double temperature, DateTime last_vaccine_date, string exsist_condition, string allergies,
            string type_vaccine, double weight, string question, string stool, string behave_attitude, string apptite, string drink, string diagnosis)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO dss_database.saved_patient(pet_id, owners_name, patient_name, age, gender, birthday, animal_species,
                                    animal_breed, contact_no, temperature, last_vaccine_date, exsist_condition, allergies, type_vaccine, weight,
                                    question, stool, behav_att, appetite, drink, diagnosis)
                                                                   VALUES(@pet_id, @owners_name, @patient_name, @age, @gender, @birthday, @animal_species,
                                    @animal_breed, @contact_no, @temperature, @last_vaccine_date, @exsist_condition, @allergies, @type_vaccine, @weight,
                                    @question, @stool, @behav_att, @appetite, @drink, @diagnosis);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@owners_name", owners_name);
                        cmd.Parameters.AddWithValue("@patient_name", patient_name);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@birthday", birthday);
                        cmd.Parameters.AddWithValue("@animal_species", animal_species);
                        cmd.Parameters.AddWithValue("@animal_breed", animal_breed);
                        cmd.Parameters.AddWithValue("@contact_no", contact_no);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@last_vaccine_date", last_vaccine_date);
                        cmd.Parameters.AddWithValue("@exsist_condition", exsist_condition);
                        cmd.Parameters.AddWithValue("@allergies", allergies);
                        cmd.Parameters.AddWithValue("@type_vaccine", type_vaccine);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@question", question);
                        cmd.Parameters.AddWithValue("@stool", stool);
                        cmd.Parameters.AddWithValue("@behav_att", behave_attitude);
                        cmd.Parameters.AddWithValue("@appetite", apptite);
                        cmd.Parameters.AddWithValue("@drink", drink);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving patient: " + ex.ToString());
                return false;
            }
        }

        public void loadpatientlist(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owner Name', patient_name AS 'Patient Name', 
                                    gender AS 'Gender', birthday AS 'Birthdate', age AS 'Age', animal_breed AS 'Animal Breed'
                                    FROM dss_database.saved_patient";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading patients: " + ex.ToString());
            }

        }

        public bool DeletePatientlist(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"DELETE from dss_database.add_animal WHERE pet_id = @pet_id;";


                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Deleted patient list: " + ex.ToString());
                return false;
            }
        }
        public bool PatientInfoViewer(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.saved_patient WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.PetID = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Patientname = dat.Rows[0].Field<string>("patient_name");
                            val.Age = dat.Rows[0].Field<string>("age");
                            val.Gender = dat.Rows[0].Field<string>("gender");
                            val.Birthday = dat.Rows[0].Field<string>("birthday");
                            val.Animalspecies = dat.Rows[0].Field<string>("animal_species");
                            val.Animalbreed = dat.Rows[0].Field<string>("animal_breed");
                            val.Contactno = dat.Rows[0].Field<string>("contact_no");
                            val.Temp = dat.Rows[0].Field<double>("temperature");
                            val.lastvacinedate = dat.Rows[0].Field<DateTime>("last_vaccine_date");
                            val.Exsist_con = dat.Rows[0].Field<string>("exsist_condition");
                            val.Allergies = dat.Rows[0].Field<string>("allergies");
                            val.Type_vaccine = dat.Rows[0].Field<string>("type_vaccine");
                            val.Weight = dat.Rows[0].Field<double>("weight");
                            val.Question = dat.Rows[0].Field<string>("question");
                            val.Stool = dat.Rows[0].Field<string>("stool");
                            val.Behav_att = dat.Rows[0].Field<string>("behav_att");
                            val.Appetite = dat.Rows[0].Field<string>("appetite");
                            val.Drink = dat.Rows[0].Field<string>("drink");
                            val.Diagnosis = dat.Rows[0].Field<string>("diagnosis");



                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error View Patient" + ex.ToString());
                return false;
            }
        }

        public void PatientInfoViewerNotice(string pet_id, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT notice AS 'Notice' FROM dss_database.add_notice WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        grid.DataSource = dat;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error View Patient" + ex.ToString());
                
            }
        }

        public bool PrescriptionRx(string pet_id, string owmers_name, string patient_name, string prescription)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO dss_database.save_RX(pet_id, owners_name, patient_name, prescription)
                                                              values (@pet_id, @owners_name, @patient_name, @prescription)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@owners_name", owmers_name);
                        cmd.Parameters.AddWithValue("@patient_name", patient_name);
                        cmd.Parameters.AddWithValue("@prescription", prescription);

                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                return false;
            }
        }

        public bool Reciept(string pet_id, string owmers_name, string patient_name, string total_fee, string amount_pay,
            string rchange)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO dss_database.reciept(pet_id, owners_name, patient_name, total_fee, amount_pay, rchange)
                                                              values (@pet_id, @owners_name, @patient_name, @total_fee,@amount_pay, @rchange)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@owners_name", owmers_name);
                        cmd.Parameters.AddWithValue("@patient_name", patient_name);
                        cmd.Parameters.AddWithValue("@total_fee", total_fee);
                        cmd.Parameters.AddWithValue("@amount_pay", amount_pay);
                        cmd.Parameters.AddWithValue("@rchange", rchange);

                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                return false;
            }
        }

        public void TransactionViewer(DataGridView grid_transactionHistory)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.reciept";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {

                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);


                        grid_transactionHistory.DataSource = dat;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error View Patient Transaction" + ex.ToString());

            }
        }
        public bool ViewRXHistory(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.save_RX WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.PetID = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Patientname = dat.Rows[0].Field<string>("patient_name");
                            val.Datee = dat.Rows[0].Field<DateTime>("TimeDate_rx");
                            val.Prescription = dat.Rows[0].Field<string>("prescription");

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error View Patient" + ex.ToString());
                return false;
            }
        }

        public void NameFilter(string keyword, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id, owners_name, patient_name from dss_database.saved_patient WHERE owners_name like @keyword";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@keyword", string.Format("{0}{1}{2}", "%", keyword, "%"));
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        grid.DataSource = dat;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error View Patient" + ex.ToString());
            }
        }

        public bool UpdatePatient(string pet_id, string owners_name, string patient_name, int age, string gender, string birthday, string animal_species,
            string animal_breed, string contact_no, double temperature, DateTime last_vaccine_date, string exsist_condition, string allergies,
            string type_vaccine, double weight, string question, string stool, string behave_attitude, string apptite, string drink, string diagnosis)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.saved_patient set owners_name = @owners_name, patient_name = @patient_name, age = @age, gender = @gender, birthday = @birthday, animal_species = @animal_species, animal_breed = 
                                    @animal_breed, contact_no = @contact_no, temperature = @temperature, last_vaccine_date = @last_vaccine_date, exsist_condition = @exsist_condition, allergies = @allergies, type_vaccine = @type_vaccine, weight = @weight,
                                    question = @question, stool = @stool, behav_att = @behav_att, appetite = @appetite, drink = @drink, diagnosis = @diagnosis WHERE pet_id = @pet_id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@owners_name", owners_name);
                        cmd.Parameters.AddWithValue("@patient_name", patient_name);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@birthday", birthday);
                        cmd.Parameters.AddWithValue("@animal_species", animal_species);
                        cmd.Parameters.AddWithValue("@animal_breed", animal_breed);
                        cmd.Parameters.AddWithValue("@contact_no", contact_no);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@last_vaccine_date", last_vaccine_date);
                        cmd.Parameters.AddWithValue("@exsist_condition", exsist_condition);
                        cmd.Parameters.AddWithValue("@allergies", allergies);
                        cmd.Parameters.AddWithValue("@type_vaccine", type_vaccine);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@question", question);
                        cmd.Parameters.AddWithValue("@stool", stool);
                        cmd.Parameters.AddWithValue("@behav_att", behave_attitude);
                        cmd.Parameters.AddWithValue("@appetite", apptite);
                        cmd.Parameters.AddWithValue("@drink", drink);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);

                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error View Patient" + ex.ToString());
                return false;
            }
        }
        public void CountTotalPatientDog(string date_month, string date_year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.saved_patient
                                    WHERE animal_species = 'DOG' AND DATE_FORMAT(primary_date, '%m') = @date_month
                                    AND DATE_FORMAT(primary_date, '%y') = @date_year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@date_month", date_month);
                        cmd.Parameters.AddWithValue("@date_year", date_year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients month: " + ex.ToString());
            }
        }
        public void CountTotalPatientCat(string date_month, string date_year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.saved_patient
                                    WHERE animal_species = 'CATS' AND DATE_FORMAT(primary_date, '%m') = @date_month
                                    AND DATE_FORMAT(primary_date, '%y') = @date_year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@date_month", date_month);
                        cmd.Parameters.AddWithValue("@date_year", date_year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totalcat = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients month: " + ex.ToString());
            }
        }
        public void CountTotalPatientBird(string date_month, string date_year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.saved_patient
                                    WHERE animal_species = 'BIRD' AND DATE_FORMAT(primary_date, '%m') = @date_month
                                    AND DATE_FORMAT(primary_date, '%y') = @date_year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@date_month", date_month);
                        cmd.Parameters.AddWithValue("@date_year", date_year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totalbird = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients month: " + ex.ToString());
            }
        }
        public void CountTotalPatientsToday(string date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                FROM dss_database.saved_patient
                                WHERE DATE_FORMAT(date, '%m/%d/%y') = @date;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@date", date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.TotalCountPatientsToday = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting total patients today: " + ex.ToString());
            }
        }
        public void TotalSalesToday(string date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT SUM(total_fee)
                                    FROM dss_database.reciept
                                    WHERE DATE_FORMAT(TimeDate_rx, '%m/%d/%y') = @TimeDate_rx;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@TimeDate_rx", date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.TotalSalesToday = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total sales today: " + ex.ToString());
            }
        }
        public void TotalSalesMonth(string date_month, string date_year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT SUM(total_fee)
                                    FROM dss_database.reciept
                                    WHERE DATE_FORMAT(TimeDate_rx, '%m') = @date_month
                                    AND DATE_FORMAT(TimeDate_rx, '%y') = @date_year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@date_month", date_month);
                        cmd.Parameters.AddWithValue("@date_year", date_year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.TotalSalesMonth = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total sales month: " + ex.ToString());
            }
        }
        public void TotalSalesYear(string date_year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT SUM(total_fee)
                                    FROM dss_database.reciept
                                    WHERE DATE_FORMAT(TimeDate_rx, '%y') = @date_year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@date_year", date_year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.TotalSalesYear = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total sales year: " + ex.ToString());
            }
        }
        public void Totalpatient(string patient_total)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(patient_name)
                                    FROM dss_database.reciept
                                    WHERE DATE_FORMAT(TimeDate_rx, '%y') = @patient_total;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_total", patient_total);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totalpatient = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total sales year: " + ex.ToString());
            }
        }

        public bool SavePregnant(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdesease,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.preg_cesarian(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_weight, pet_allergies, pet_existdesease, operation, op_date, op_time)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_weight, @pet_allergies, @pet_existdesease, @operation, @op_date, @op_time)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@owners_name", owners_name);
                        cmd.Parameters.AddWithValue("@phone_num", phone_num);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@pet_name", pet_name);
                        cmd.Parameters.AddWithValue("@pet_age", pet_age);
                        cmd.Parameters.AddWithValue("@pet_gender", pet_gender);
                        cmd.Parameters.AddWithValue("@pet_bday", pet_bday);
                        cmd.Parameters.AddWithValue("@pet_species", pet_species);
                        cmd.Parameters.AddWithValue("@pet_breed", pet_breed);
                        cmd.Parameters.AddWithValue("@pet_weight", pet_weight);
                        cmd.Parameters.AddWithValue("@pet_allergies", pet_allergies);
                        cmd.Parameters.AddWithValue("@pet_existdesease", pet_existdesease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error saving pregnancy cesarean: " + ex.ToString());
                return false;
            }
        }
    }
}
