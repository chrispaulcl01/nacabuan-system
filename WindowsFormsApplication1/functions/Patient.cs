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
                                    FROM dss_database.vaccination WHERE date_format(date, '%m/%d/%y') = @date";

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
                            //val.PetID = dt.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dt.Rows[0].Field<string>("owners_name");
                            // val.Patientname = dt.Rows[0].Field<string>("patient_name");
                            val.Contactno = dt.Rows[0].Field<string>("contact_no");
                            //val.Gender = dt.Rows[0].Field<string>("gender");
                            //val.Birthday = dt.Rows[0].Field<string>("birthday");
                            // val.Age = dt.Rows[0].Field<string>("age");
                            // val.Animalspecies = dt.Rows[0].Field<string>("animal_species");
                            //val.Pet_breed = dt.Rows[0].Field<string>("animal_breed");

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
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Operation'
                                    FROM dss_database.crastration";

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

        public void LoaddVaccination(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operations AS 'Operation'
                                    FROM dss_database.vaccination";

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

        public void LoaddCrastration(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Operation'
                                    FROM dss_database.crastration";

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

        public void LoaddLygaidae(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Operation'
                                    FROM dss_database.lygaeidae";

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

        public void loadPatientSched(DataGridView grid)
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

        public bool DeleteSkinPatientData(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"DELETE from dss_database.skintreatment WHERE pet_id = @pet_id;";


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

        public bool PatientInfoViewerLygaedae(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.lygaeidae WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_weight = dat.Rows[0].Field<string>("pet_weight");
                            val.Pet_skinallergies = dat.Rows[0].Field<string>("pet_allergies");
                            val.Pet_existdisease = dat.Rows[0].Field<string>("pet_existdisease");
                            val.Operation = dat.Rows[0].Field<string>("operation");
                            val.Op_date = dat.Rows[0].Field<DateTime>("op_date");
                            val.Op_time = dat.Rows[0].Field<string>("op_time");


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

        public bool PatientInfoViewerBloodResult(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.mammary_result WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("superchen");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("totalprotein");
                            val.Pet_name = dat.Rows[0].Field<string>("albumin");
                            


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

        public bool PatientInfoViewerCrastration(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.crastration WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_weight = dat.Rows[0].Field<string>("pet_weight");
                            val.Pet_skinallergies = dat.Rows[0].Field<string>("pet_allergies");
                            val.Pet_existdisease = dat.Rows[0].Field<string>("pet_existdisease");
                            val.Operation = dat.Rows[0].Field<string>("operation");
                            val.Op_date = dat.Rows[0].Field<DateTime>("op_date");
                            val.Op_time = dat.Rows[0].Field<string>("op_time");


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


        public bool PatientInfoViewerSkin(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.skintreatment WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name= dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_weight = dat.Rows[0].Field<string>("pet_weight");
                            val.Pet_skinallergies = dat.Rows[0].Field<string>("pet_skinallergies");
                            val.Pet_existdisease = dat.Rows[0].Field<string>("pet_existdisease");
                            val.Operation = dat.Rows[0].Field<string>("operation");
                            val.Op_date = dat.Rows[0].Field<DateTime>("op_date");
                            val.Op_time = dat.Rows[0].Field<string>("op_time");


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

        public bool PatientInfoViewerCPT(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.CPTest WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_weight = dat.Rows[0].Field<string>("pet_weight");
                            val.Pet_skinallergies= dat.Rows[0].Field<string>("pet_allergies");
                            val.Pet_existdisease = dat.Rows[0].Field<string>("pet_existdisease");
                            val.Testkit = dat.Rows[0].Field<string>("pet_testkit");
                            val.Operation = dat.Rows[0].Field<string>("operation");
                            val.Op_date = dat.Rows[0].Field<DateTime>("op_date");
                            val.Op_time = dat.Rows[0].Field<string>("op_time");


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

        public bool PatientInfoViewerCDT(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.CDTest WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_weight = dat.Rows[0].Field<string>("pet_weight");
                            val.Pet_skinallergies = dat.Rows[0].Field<string>("pet_allergies");
                            val.Pet_existdisease = dat.Rows[0].Field<string>("pet_existdisease");
                            val.Testkit = dat.Rows[0].Field<string>("pet_testkit");
                            val.Operation = dat.Rows[0].Field<string>("operation");
                            val.Op_date = dat.Rows[0].Field<DateTime>("op_date");
                            val.Op_time = dat.Rows[0].Field<string>("op_time");


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

        public bool PatientInfoViewerBloodTest(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.bloodparasite WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_weight = dat.Rows[0].Field<string>("pet_weight");
                            val.Pet_skinallergies = dat.Rows[0].Field<string>("pet_allergies");
                            val.Pet_existdisease = dat.Rows[0].Field<string>("pet_existdisease");
                            val.Operation = dat.Rows[0].Field<string>("operation");
                            val.Typevax = dat.Rows[0].Field<string>("typevax");
                            val.Vaxdate = dat.Rows[0].Field<DateTime>("vaxdate");

                            val.Superchen = dat.Rows[0].Field<string>("superchen");
                            val.Totalprotein = dat.Rows[0].Field<string>("totalprotein");
                            val.Albumin = dat.Rows[0].Field<string>("albumin");
                            val.Globulin = dat.Rows[0].Field<string>("globulin");



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

        public bool PatientInfoViewerMammaryGland(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.mammarry WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_weight = dat.Rows[0].Field<string>("pet_weight");
                            val.Pet_skinallergies = dat.Rows[0].Field<string>("pet_allergies");
                            val.Pet_existdisease = dat.Rows[0].Field<string>("pet_existdisease");
                            val.Operation = dat.Rows[0].Field<string>("operation");
                            val.Typevax = dat.Rows[0].Field<string>("typevax");
                            val.Vaxdate = dat.Rows[0].Field<DateTime>("vaxdate");

                            val.Superchen = dat.Rows[0].Field<string>("superchen");
                            val.Totalprotein = dat.Rows[0].Field<string>("totalprotein");
                            val.Albumin = dat.Rows[0].Field<string>("albumin");
                            val.Globulin = dat.Rows[0].Field<string>("globulin");

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

        public bool PatientInfoViewerDeworming(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.deworming WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed"); 
                            val.Operation = dat.Rows[0].Field<string>("service");

                            val.Deworn_2weeks_date = dat.Rows[0].Field<string>("deworn_2weeks_date");
                            val.Deworn_2weeks_medicine = dat.Rows[0].Field<string>("deworn_2weeks_medicine");
                            val.Deworn_4weeks_date = dat.Rows[0].Field<string>("deworn_2weeks_date");
                            val.Deworn_4weeks_medicine = dat.Rows[0].Field<string>("deworn_4weeks_medicine");
                            val.Deworn_6weeks_date = dat.Rows[0].Field<string>("deworn_6weeks_date");
                            val.Deworn_6weeks_medicine = dat.Rows[0].Field<string>("deworn_6weeks_medicine");
                            val.Deworn_8weeks_date = dat.Rows[0].Field<string>("deworn_8weeks_date");
                            val.Deworn_8weeks_medicine = dat.Rows[0].Field<string>("deworn_8weeks_medicine");
                            val.Deworn_10weeks_date = dat.Rows[0].Field<string>("deworn_10weeks_date");
                            val.Deworn_10weeks_medicine = dat.Rows[0].Field<string>("deworn_10weeks_medicine");
                            val.Deworn_12weeks_date = dat.Rows[0].Field<string>("deworn_12weeks_date");
                            val.Deworn_12weeks_medicine = dat.Rows[0].Field<string>("deworn_12weeks_medicine");


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

        public bool PatientInfoViewerPregCesarean(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.preg_cesarian WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_weight = dat.Rows[0].Field<string>("pet_weight");
                            val.Pet_skinallergies = dat.Rows[0].Field<string>("pet_allergies");
                            val.Pet_existdisease = dat.Rows[0].Field<string>("pet_existdesease");
                            val.Operation = dat.Rows[0].Field<string>("operation");
                            val.Op_date = dat.Rows[0].Field<DateTime>("op_date");
                            val.Op_time = dat.Rows[0].Field<string>("op_time");

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

        public bool PatientInfoViewerEarOperation(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.earoperation WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_weight = dat.Rows[0].Field<string>("pet_weight");
                            val.Pet_skinallergies = dat.Rows[0].Field<string>("pet_allergies");
                            val.Curren_med = dat.Rows[0].Field<string>("pet_currmed");
                            val.Operation = dat.Rows[0].Field<string>("operation");                           
                            val.Op_date = dat.Rows[0].Field<DateTime>("op_date");
                            val.Op_time = dat.Rows[0].Field<string>("op_time");

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

        public bool PatientInfoViewerEyeOperation(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.eyeoperation WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_weight = dat.Rows[0].Field<string>("pet_weight");
                            val.Pet_skinallergies = dat.Rows[0].Field<string>("pet_allergies");
                            val.Curren_med = dat.Rows[0].Field<string>("pet_currmed");
                            val.Operation = dat.Rows[0].Field<string>("operation");
                            val.Op_date = dat.Rows[0].Field<DateTime>("op_date");
                            val.Op_time = dat.Rows[0].Field<string>("op_time");

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

        public bool PatientSkinRX(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.skintreatment WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            //val.PetID = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            //val.Patientname = dat.Rows[0].Field<string>("patient_name");
                            //val.Age = dat.Rows[0].Field<string>("age");
                            //val.Gender = dat.Rows[0].Field<string>("gender");
                            //val.Birthday = dat.Rows[0].Field<string>("birthday");
                            //val.Animalspecies = dat.Rows[0].Field<string>("animal_species");
                            //val.Pet_breed = dat.Rows[0].Field<string>("animal_breed");
                            val.Contactno = dat.Rows[0].Field<string>("contact_no");
                            val.Temp = dat.Rows[0].Field<double>("temperature");
                            val.lastvacinedate = dat.Rows[0].Field<DateTime>("last_vaccine_date");
                            val.Exsist_con = dat.Rows[0].Field<string>("exsist_condition");
                           // val.Allergies = dat.Rows[0].Field<string>("allergies");
                            val.Type_vaccine = dat.Rows[0].Field<string>("type_vaccine");
                            //val.Pet_weight = dat.Rows[0].Field<double>("weight");
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


        public bool PatientInfoViewerVaccination(string pet_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * FROM dss_database.vaccination WHERE pet_id = @pet_id";

                    using (MySqlCommand cmb = new MySqlCommand(sql, connection))
                    {
                        cmb.Parameters.AddWithValue("@pet_id", pet_id);
                        MySqlDataAdapter daa = new MySqlDataAdapter(cmb);
                        DataTable dat = new DataTable();
                        daa.Fill(dat);

                        if (dat.Rows.Count == 1)
                        {
                            val.Pet_id = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            val.Phone_num = dat.Rows[0].Field<string>("phone_num");
                            val.Address = dat.Rows[0].Field<string>("address");
                            val.Pet_name = dat.Rows[0].Field<string>("pet_name");
                            val.Pet_age = dat.Rows[0].Field<int>("pet_age");
                            val.Pet_gender = dat.Rows[0].Field<string>("pet_gender");
                            val.Pet_bday = dat.Rows[0].Field<string>("pet_bday");
                            val.Pet_species = dat.Rows[0].Field<string>("pet_species");
                            val.Pet_breed = dat.Rows[0].Field<string>("pet_breed");
                            val.Pet_skinallergies = dat.Rows[0].Field<string>("pet_allergies");
                            val.Operation = dat.Rows[0].Field<string>("operations");

                            val.First_boost_distemper = dat.Rows[0].Field<string>("first_boost_distemper");
                            val.First_date_distemper = dat.Rows[0].Field<string>("first_date_distemper");

                            val.Second_boost_distemper = dat.Rows[0].Field<string>("second_boost_distemper");
                            val.Second_date_distemper = dat.Rows[0].Field<string>("second_date_distemper");

                            val.Third_boost_distemper = dat.Rows[0].Field<string>("third_boost_distemper");
                            val.Third_date_distemper = dat.Rows[0].Field<string>("third_date_distemper");

                            val.First_boost_feline = dat.Rows[0].Field<string>("first_boost_feline");
                            val.First_date_feline= dat.Rows[0].Field<string>("first_date_feline");

                            val.Second_boost_feline = dat.Rows[0].Field<string>("second_boost_feline");
                            val.Second_date_feline= dat.Rows[0].Field<string>("second_date_feline");

                            val.First_boost_rabies = dat.Rows[0].Field<string>("first_boost_rabies");
                            val.First_date_rabies= dat.Rows[0].Field<string>("first_date_rabies");


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
                            //val.PetID = dat.Rows[0].Field<string>("pet_id");
                            val.OwnersName = dat.Rows[0].Field<string>("owners_name");
                            //val.Patientname = dat.Rows[0].Field<string>("patient_name");
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

        public void TransactionHistorySearchFilter(string keyword, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id, owners_name, patient_name, total_fee , amount_pay, rchange, TimeDate_rx
                    from dss_database.reciept WHERE owners_name like @keyword or pet_id like @keyword";

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
                Console.WriteLine("error View Transaction History" + ex.ToString());
            }
        }

        public void NameFilterSkin(string keyword, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id, owners_name, pet_name, pet_gender , pet_bday, pet_age, pet_breed, operation
                    from dss_database.skintreatment WHERE owners_name like @keyword or pet_id like @keyword";

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

        public void NameFilterCPT(string keyword, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id, owners_name, pet_name, pet_gender , pet_bday, pet_age, pet_breed, operation
                    from dss_database.CPTest WHERE owners_name like @keyword or pet_id like @keyword";

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

        public bool UpdatePatientVaccine(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_allergies, string operations,
            string first_boost_distemper, string first_date_distemper, string second_boost_distemper, string second_date_distemper, string third_boost_distemper,
            string third_date_distemper, string first_boost_feline, string first_date_feline, string second_boost_feline, string second_date_feline, string first_boost_rabies, string first_date_rabies)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.vaccination set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name, pet_age = @pet_age,
                                pet_gender = @pet_gender, pet_bday = @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_allergies = @pet_allergies, operations = @operations,

                                first_boost_distemper = @first_boost_distemper, first_date_distemper = @first_date_distemper, second_boost_distemper = @second_boost_distemper,
                                second_date_distemper = @second_date_distemper, third_boost_distemper = @third_boost_distemper, third_date_distemper = @third_date_distemper, first_boost_feline = @first_boost_feline,
                                first_date_feline = @first_date_feline, second_boost_feline = @second_boost_feline,
                                second_date_feline = @second_date_feline, first_boost_rabies = @first_boost_rabies, first_date_rabies = @first_date_rabies  WHERE pet_id = @pet_id";
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
                        cmd.Parameters.AddWithValue("@pet_allergies", pet_allergies);
                        cmd.Parameters.AddWithValue("@operations", operations);

                        cmd.Parameters.AddWithValue("@first_boost_distemper", first_boost_distemper);
                        cmd.Parameters.AddWithValue("@first_date_distemper", first_date_distemper);
                        cmd.Parameters.AddWithValue("@second_boost_distemper", second_boost_distemper);
                        cmd.Parameters.AddWithValue("@second_date_distemper", second_date_distemper);
                        cmd.Parameters.AddWithValue("@third_boost_distemper", third_boost_distemper);
                        cmd.Parameters.AddWithValue("@third_date_distemper", third_date_distemper);

                        cmd.Parameters.AddWithValue("@first_boost_feline", first_boost_feline);
                        cmd.Parameters.AddWithValue("@first_date_feline", first_date_feline);
                        cmd.Parameters.AddWithValue("@second_boost_feline", second_boost_feline);
                        cmd.Parameters.AddWithValue("@second_date_feline", second_date_feline);

                        cmd.Parameters.AddWithValue("@first_boost_rabies", first_boost_rabies);
                        cmd.Parameters.AddWithValue("@first_date_rabies", first_date_rabies);


                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateSkinPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_skinallergies, string pet_existdisease,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.skintreatment set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name, pet_age = @pet_age, pet_gender = @pet_gender, pet_bday = 
                                    @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_weight = @pet_weight, pet_skinallergies = @pet_skinallergies, pet_existdisease = @pet_existdisease, operation = @operation, op_date = @op_date,
                                    op_time = @op_time WHERE pet_id = @pet_id";

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
                        cmd.Parameters.AddWithValue("@pet_skinallergies", pet_skinallergies);
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);
                        

                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error View Skin Patient" + ex.ToString());
                return false;
            }
        }

        public bool UpdateCDTPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string pet_testkit, string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.CDTest set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name, pet_age = @pet_age, pet_gender = @pet_gender, pet_bday = 
                                    @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_weight = @pet_weight, pet_allergies = @pet_allergies, pet_existdisease = @pet_existdisease, pet_testkit = @pet_testkit, 
                                    operation = @operation, op_date = @op_date, op_time = @op_time WHERE pet_id = @pet_id";

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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@pet_testkit", pet_testkit);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);


                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Update CDT Patient" + ex.ToString());
                return false;
            }
        }

        public bool UpdateCPTPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string pet_testkit, string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.CPTest set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name, pet_age = @pet_age, pet_gender = @pet_gender, pet_bday = 
                                    @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_weight = @pet_weight, pet_allergies = @pet_allergies, pet_existdisease = @pet_existdisease, pet_testkit = @pet_testkit, 
                                    operation = @operation, op_date = @op_date, op_time = @op_time WHERE pet_id = @pet_id";

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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@pet_testkit", pet_testkit);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);


                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Update CPT Patient" + ex.ToString());
                return false;
            }
        }

        public bool UpdateBloodTestPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, string pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string operation, string typevax, DateTime vaxdate, string superchen, string totalprotein, string albumin, string globulin)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.bloodparasite set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name,
                                pet_age = @pet_age, pet_gender = @pet_gender, pet_bday = @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_weight = @pet_weight, pet_allergies = @pet_allergies,
                                pet_existdisease = @pet_existdisease, operation = @operation, typevax = @typevax, vaxdate = @vaxdate, superchen = @superchen, totalprotein = @totalprotein, 
                                albumin = @albumin, globulin = @globulin  WHERE pet_id = @pet_id";

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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@typevax", typevax);
                        cmd.Parameters.AddWithValue("@vaxdate", vaxdate);

                        cmd.Parameters.AddWithValue("@superchen", superchen);
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);



                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Update BloodTest Patient" + ex.ToString());
                return false;
            }
        }

        public bool UpdatePatientBloodTestResult(string pet_id, string superchen, string totalprotein, string albumin, string globulin)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.bloodtest_result set superchen = superchen, totalprotein = totalprotein, albumin = albumin, globulin = globulin WHERE pet_id = @pet_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@superchen", superchen);
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);
                        //cmd.Parameters.AddWithValue("@ag_Ration", ag_Ration);
                        //cmd.Parameters.AddWithValue("@AST_SGOT", AST_SGOT);
                        //cmd.Parameters.AddWithValue("@ALT_SGPT", ALT_SGPT);
                        //cmd.Parameters.AddWithValue("@alk_phosphatese", alk_phosphatese);
                        //cmd.Parameters.AddWithValue("@gct", gct);
                        //cmd.Parameters.AddWithValue("@totalbilirubin", totalbilirubin);
                        //cmd.Parameters.AddWithValue("@bun", bun);
                        //cmd.Parameters.AddWithValue("@creatinine", creatinine);
                        //cmd.Parameters.AddWithValue("@renaltech", renaltech);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateMammaryGlandPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, string pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string operation, string typevax, DateTime vaxdate, string superchen, string totalprotein, string albumin, string globulin)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.mammarry set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name,
                                pet_age = @pet_age, pet_gender = @pet_gender, pet_bday = @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_weight = @pet_weight, pet_allergies = @pet_allergies,
                                pet_existdisease = @pet_existdisease, operation = @operation, typevax = @typevax, vaxdate = @vaxdate, superchen = @superchen, totalprotein = @totalprotein, 
                                albumin = @albumin, globulin = @globulin  WHERE pet_id = @pet_id";

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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@typevax", typevax);
                        cmd.Parameters.AddWithValue("@vaxdate", vaxdate);

                        cmd.Parameters.AddWithValue("@superchen", superchen);
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);



                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Update Mammary Patient" + ex.ToString());
                return false;
            }
        }

        public bool UpdateDewormPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, string pet_bday, string pet_species, string pet_breed, string service, string deworn_2weeks_date, string deworn_2weeks_medicine,
            string deworn_4weeks_date, string deworn_4weeks_medicine, string deworn_6weeks_date, string deworn_6weeks_medicine, string deworn_8weeks_date,
            string deworn_8weeks_medicine, string deworn_10weeks_date, string deworn_10weeks_medicine, string deworn_12weeks_date, string deworn_12weeks_medicine)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.deworming set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name, pet_age = @pet_age,
                                pet_gender = @pet_gender, pet_bday = @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, service = @service, deworn_2weeks_date = @deworn_2weeks_date,deworn_2weeks_medicine = @deworn_2weeks_medicine, 
                                deworn_4weeks_date = @deworn_4weeks_date, deworn_4weeks_medicine = @deworn_4weeks_medicine,
                                deworn_6weeks_date = @deworn_6weeks_date, deworn_6weeks_medicine = @deworn_6weeks_medicine, deworn_8weeks_date = @deworn_8weeks_date, deworn_8weeks_medicine = @deworn_8weeks_medicine,
                                deworn_10weeks_medicine = @deworn_10weeks_date, deworn_10weeks_medicine = @deworn_10weeks_medicine, deworn_12weeks_date = @deworn_12weeks_date, deworn_12weeks_medicine = @deworn_12weeks_medicine 
                                WHERE pet_id = @pet_id";

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
                        cmd.Parameters.AddWithValue("@service", service);
                        cmd.Parameters.AddWithValue("@deworn_2weeks_date", deworn_2weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_2weeks_medicine", deworn_2weeks_medicine);
                        cmd.Parameters.AddWithValue("@deworn_4weeks_date", deworn_4weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_4weeks_medicine", deworn_4weeks_medicine);
                        cmd.Parameters.AddWithValue("@deworn_6weeks_date", deworn_6weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_6weeks_medicine", deworn_6weeks_medicine);
                        cmd.Parameters.AddWithValue("@deworn_8weeks_date", deworn_8weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_8weeks_medicine", deworn_8weeks_medicine);
                        cmd.Parameters.AddWithValue("@deworn_10weeks_date", deworn_10weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_10weeks_medicine", deworn_10weeks_medicine);
                        cmd.Parameters.AddWithValue("@deworn_12weeks_date", deworn_12weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_12weeks_medicine", deworn_12weeks_medicine);


                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Update Deworming Patient" + ex.ToString());
                return false;
            }
        }

        

        public bool UpdatePregnCersarPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, string pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdesease,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.preg_cesarian set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name, pet_age = @pet_age,
                                pet_gender = @pet_gender, pet_bday = @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_weight = @pet_weight, pet_allergies = @pet_allergies,
                                pet_existdesease = @pet_existdesease, operation = @operation, op_date = @op_date, op_time = @op_time
                                WHERE pet_id = @pet_id";

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
            catch (Exception ex)
            {
                Console.WriteLine("error Update Pregancy Patient" + ex.ToString());
                return false;
            }
        }

        public bool UpdateEarOpPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, string pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_currmed,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.earoperation set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name, pet_age = @pet_age,
                                pet_gender = @pet_gender, pet_bday = @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_weight = @pet_weight, pet_allergies = @pet_allergies,
                                pet_currmed = @pet_currmed, operation = @operation, op_date = @op_date, op_time = @op_time
                                WHERE pet_id = @pet_id";

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
                        cmd.Parameters.AddWithValue("@pet_currmed", pet_currmed);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);



                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Update Ear Operation Patient" + ex.ToString());
                return false;
            }
        }

        public bool UpdateEyeOpPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, string pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_currmed,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.eyeoperation set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name, pet_age = @pet_age,
                                pet_gender = @pet_gender, pet_bday = @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_weight = @pet_weight, pet_allergies = @pet_allergies,
                                pet_currmed = @pet_currmed, operation = @operation, op_date = @op_date, op_time = @op_time
                                WHERE pet_id = @pet_id";

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
                        cmd.Parameters.AddWithValue("@pet_currmed", pet_currmed);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);



                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Update Eye Operation Patient" + ex.ToString());
                return false;
            }
        }

        public bool UpdateLygaedaeOpPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, string pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.lygaeidae set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name, pet_age = @pet_age,
                                pet_gender = @pet_gender, pet_bday = @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_weight = @pet_weight, pet_allergies = @pet_allergies,
                                pet_existdisease = @pet_existdisease, operation = @operation, op_date = @op_date, op_time = @op_time
                                WHERE pet_id = @pet_id";

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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);



                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Update Lygaeidae Patient" + ex.ToString());
                return false;
            }
        }

        public bool UpdateCrastrationOpPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, string pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"update dss_database.crastration set owners_name = @owners_name, phone_num = @phone_num, address = @address, pet_name = @pet_name, pet_age = @pet_age,
                                pet_gender = @pet_gender, pet_bday = @pet_bday, pet_species = @pet_species, pet_breed = @pet_breed, pet_weight = @pet_weight, pet_allergies = @pet_allergies,
                                pet_existdisease = @pet_existdisease, operation = @operation, op_date = @op_date, op_time = @op_time
                                WHERE pet_id = @pet_id";

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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);



                        connection.Open();
                        cmd.ExecuteReader();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Update Lygaeidae Patient" + ex.ToString());
                return false;
            }
        }


        public void CountTotalSkinPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.skintreatment WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients SKIN DOGS: " + ex.ToString());
            }
        }

        public void CountTotalCDTPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.CDTest WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients CDT DOG: " + ex.ToString());
            }
        }

        public void CountTotalCPTPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.CPTest WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients CPT DOG: " + ex.ToString());
            }
        }

        public void CountTotalBloodPPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.bloodparasite WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients BlOODPARASITE DOG: " + ex.ToString());
            }
        }

        public void CountTotalPregnancyPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.preg_cesarian WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients PREGNANCY DOG: " + ex.ToString());
            }
        }

        public void CountTotalEyeOpPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.eyeoperation WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients EYE OPERARION DOG: " + ex.ToString());
            }
        }

        public void CountTotalEarOpPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.earoperation WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients EAR OPERARION DOG: " + ex.ToString());
            }
        }

        public void CountTotalMammaryPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.mammarry WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients MAMMARY GLAND DOG: " + ex.ToString());
            }
        }

        public void CountTotalVaccinePatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.vaccination WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients  VACCINE DOG: " + ex.ToString());
            }
        }

        public void CountTotalCrastraionPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.crastration WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients CRASTRATION DOG: " + ex.ToString());
            }
        }

        public void CountTotalLygPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.lygaeidae WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients lygaeidae DOG: " + ex.ToString());
            }
        }

        public void CountTotalDewormingPatientDog()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.deworming WHERE pet_species = 'DOG'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients DEWORMING DOG: " + ex.ToString());
            }
        }


        public void CountTotalSkinPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.skintreatment WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients SKIN CAT: " + ex.ToString());
            }
        }

        public void CountTotalCDTPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.CDTest WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients CDT CAT: " + ex.ToString());
            }
        }

        public void CountTotalCPTPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.CPTest WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients CPT CAT: " + ex.ToString());
            }
        }

        public void CountTotalBloodPPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.bloodparasite WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients BlOODPARASITE CAT: " + ex.ToString());
            }
        }

        public void CountTotalPregnancyPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.preg_cesarian WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients PREGNANCY CAT: " + ex.ToString());
            }
        }

        public void CountTotalEyeOpPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.eyeoperation WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients EYE OPERARION CAT: " + ex.ToString());
            }
        }

        public void CountTotalEarOpPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.earoperation WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients EAR OPERARION CAT: " + ex.ToString());
            }
        }

        public void CountTotalMammaryPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.mammarry WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients MAMMARY GLAND CAT: " + ex.ToString());
            }
        }

        public void CountTotalVaccinePatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.vaccination WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients  VACCINE CAT: " + ex.ToString());
            }
        }

        public void CountTotalCrastraionPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.crastration WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients CRASTRATION CAT: " + ex.ToString());
            }
        }

        public void CountTotalLygPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.lygaeidae WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients lygaeidae CAT: " + ex.ToString());
            }
        }

        public void CountTotalDewormingPatientCAT()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.deworming WHERE pet_species = 'CAT'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients DEWORMING CAT: " + ex.ToString());
            }
        }


        public void CountTotalSkinPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.skintreatment WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients SKIN BIRD: " + ex.ToString());
            }
        }

        public void CountTotalCDTPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.CDTest WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients CDT BIRD: " + ex.ToString());
            }
        }

        public void CountTotalCPTPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.CPTest WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients CPT BIRD: " + ex.ToString());
            }
        }

        public void CountTotalBloodPPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.bloodparasite WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients BlOODPARASITE BIRD: " + ex.ToString());
            }
        }

        public void CountTotalPregnancyPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.preg_cesarian WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients PREGNANCY BIRD: " + ex.ToString());
            }
        }

        public void CountTotalEyeOpPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.eyeoperation WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients EYE OPERARION BIRD: " + ex.ToString());
            }
        }

        public void CountTotalEarOpPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.earoperation WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients EAR OPERARION BIRD: " + ex.ToString());
            }
        }

        public void CountTotalMammaryPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.mammarry WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients MAMMARY GLAND BIRD: " + ex.ToString());
            }
        }

        public void CountTotalVaccinePatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.vaccination WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients  VACCINE BIRD: " + ex.ToString());
            }
        }

        public void CountTotalCrastraionPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.crastration WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients CRASTRATION BIRD: " + ex.ToString());
            }
        }

        public void CountTotalLygPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.lygaeidae WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients lygaeidae BIRD: " + ex.ToString());
            }
        }

        public void CountTotalDewormingPatientBIRD()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.deworming WHERE pet_species = 'BIRD'; ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {


                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        val.Totaldogs = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total of patients DEWORMING BIRD: " + ex.ToString());
            }
        }



        public void CountTotalPatientDog(string date_month, string date_year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM dss_database.skintreatment
                                    WHERE pet_species = 'DOG' AND DATE_FORMAT(primary_date, '%m') = @date_month
                                    AND DATE_FORMAT(primary_date, '%y') = @date_year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@date_month", date_month);
                        cmd.Parameters.AddWithValue("@date_year", date_year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connection.Open();
                        //val.Totaldogs = int.Parse(cmd.ExecuteScalar().ToString());
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
            catch (Exception ex)
            {
                Console.WriteLine("Error saving pregnancy cesarean: " + ex.ToString());
                return false;
            }
        }

        public bool SaveEarPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_currmed,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.earoperation(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_weight, pet_allergies, pet_currmed, operation, op_date, op_time)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_weight, @pet_allergies, @pet_currmed, @operation, @op_date, @op_time)";
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
                        cmd.Parameters.AddWithValue("@pet_currmed", pet_currmed);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }

        }

        public bool SaveEyePatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_currmed,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.eyeoperation(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_weight, pet_allergies, pet_currmed, operation, op_date, op_time)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_weight, @pet_allergies, @pet_currmed, @operation, @op_date, @op_time)";
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
                        cmd.Parameters.AddWithValue("@pet_currmed", pet_currmed);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SaveSkinTreatment(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_skinallergies, string pet_existdisease,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.skintreatment(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_weight, pet_skinallergies, pet_existdisease, operation, op_date, op_time)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_weight, @pet_skinallergies, @pet_existdisease, @operation, @op_date, @op_time)";
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
                        cmd.Parameters.AddWithValue("@pet_skinallergies", pet_skinallergies);
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SaveCDTestPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string pet_testkit, string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.CDTest(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_weight, pet_allergies, pet_existdisease, pet_testkit, operation, op_date, op_time)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_weight, @pet_allergies, @pet_existdisease, @pet_testkit, @operation, @op_date, @op_time)";
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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@pet_testkit", pet_testkit);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SaveCPTestPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string pet_testkit, string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.CPTest(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_weight, pet_allergies, pet_existdisease, pet_testkit, operation, op_date, op_time)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_weight, @pet_allergies, @pet_existdisease, pet_testkit, @operation, @op_date, @op_time)";
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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@pet_testkit", pet_testkit);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SaveMammryPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string operation, string typevax, DateTime vaxdate, string superchen, string totalprotein, string albumin, string globulin)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.mammarry(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_weight, pet_allergies, pet_existdisease, operation, typevax, vaxdate, superchen, totalprotein, albumin, globulin)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_weight, @pet_allergies, @pet_existdisease,@operation, @typevax, @vaxdate, @superchen, @totalprotein, @albumin, @globulin)";
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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@typevax", typevax);
                        cmd.Parameters.AddWithValue("@vaxdate", vaxdate);

                        cmd.Parameters.AddWithValue("@superchen", superchen);
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SaveBloodtestPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, string pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string operation, string typevax, DateTime vaxdate, string superchen, string totalprotein, string albumin, string globulin)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.bloodparasite(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_weight, pet_allergies, pet_existdisease, operation, typevax, vaxdate, superchen, totalprotein, albumin, globulin)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_weight, @pet_allergies, @pet_existdisease, @operation,
                                @typevax, @vaxdate, @superchen, @totalprotein, @albumin, @globulin)";
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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@typevax", typevax);
                        cmd.Parameters.AddWithValue("@vaxdate", vaxdate);
                        cmd.Parameters.AddWithValue("@superchen", superchen);                        
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);


                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SavePatientMammaryResult(string pet_id, string superchen, string totalprotein, string albumin, string globulin, string ag_Ration,
            string AST_SGOT, string ALT_SGPT, string alk_phosphatese, string gct, string totalbilirubin, string bun, string creatinine,
            string renaltech)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.mammary_result(pet_id, superchen, totalprotein, albumin, globulin, ag_Ration,
                                AST_SGOT, ALT_SGPT, alk_phosphatese, gct, totalbilirubin, bun, creatinine, renaltech)
                                values(@pet_id, @superchen, @totalprotein, @albumin, @globulin, @ag_Ration,
                                @AST_SGOT, @ALT_SGPT, @alk_phosphatese, @gct, @totalbilirubin, @bun, @creatinine,@renaltech)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@superchen", superchen);
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);
                        cmd.Parameters.AddWithValue("@ag_Ration", ag_Ration);
                        cmd.Parameters.AddWithValue("@AST_SGOT", AST_SGOT);
                        cmd.Parameters.AddWithValue("@ALT_SGPT", ALT_SGPT);
                        cmd.Parameters.AddWithValue("@alk_phosphatese", alk_phosphatese);
                        cmd.Parameters.AddWithValue("@gct", gct);
                        cmd.Parameters.AddWithValue("@totalbilirubin", totalbilirubin);
                        cmd.Parameters.AddWithValue("@bun", bun);
                        cmd.Parameters.AddWithValue("@creatinine", creatinine);
                        cmd.Parameters.AddWithValue("@renaltech", renaltech);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SavePatientMammaryRange(string pet_id, string superchen, string totalprotein, string albumin, string globulin, string ag_Ration,
            string AST_SGOT, string ALT_SGPT, string alk_phosphatese, string gct, string totalbilirubin, string bun, string creatinine,
            string renaltech)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.mammary_adult_reference_range(pet_id, superchen, totalprotein, albumin, globulin, ag_Ration,
                                AST_SGOT, ALT_SGPT, alk_phosphatese, gct, totalbilirubin, bun, creatinine, renaltech)
                                values(@pet_id, @superchen, @totalprotein, @albumin, @globulin, @ag_Ration,
                                @AST_SGOT, @ALT_SGPT, @alk_phosphatese, @gct, @totalbilirubin, @bun, @creatinine,@renaltech)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@superchen", superchen);
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);
                        cmd.Parameters.AddWithValue("@ag_Ration", ag_Ration);
                        cmd.Parameters.AddWithValue("@AST_SGOT", AST_SGOT);
                        cmd.Parameters.AddWithValue("@ALT_SGPT", ALT_SGPT);
                        cmd.Parameters.AddWithValue("@alk_phosphatese", alk_phosphatese);
                        cmd.Parameters.AddWithValue("@gct", gct);
                        cmd.Parameters.AddWithValue("@totalbilirubin", totalbilirubin);
                        cmd.Parameters.AddWithValue("@bun", bun);
                        cmd.Parameters.AddWithValue("@creatinine", creatinine);
                        cmd.Parameters.AddWithValue("@renaltech", renaltech);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SavePatientMammaryUnits(string pet_id, string superchen, string totalprotein, string albumin, string globulin, string ag_Ration,
            string AST_SGOT, string ALT_SGPT, string alk_phosphatese, string gct, string totalbilirubin, string bun, string creatinine,
            string renaltech)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.mammary_units(pet_id, superchen, totalprotein, albumin, globulin, ag_Ration,
                                AST_SGOT, ALT_SGPT, alk_phosphatese, gct, totalbilirubin, bun, creatinine, renaltech)
                                values(@pet_id, @superchen, @totalprotein, @albumin, @globulin, @ag_Ration,
                                @AST_SGOT, @ALT_SGPT, @alk_phosphatese, @gct, @totalbilirubin, @bun, @creatinine,@renaltech)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@superchen", superchen);
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);
                        cmd.Parameters.AddWithValue("@ag_Ration", ag_Ration);
                        cmd.Parameters.AddWithValue("@AST_SGOT", AST_SGOT);
                        cmd.Parameters.AddWithValue("@ALT_SGPT", ALT_SGPT);
                        cmd.Parameters.AddWithValue("@alk_phosphatese", alk_phosphatese);
                        cmd.Parameters.AddWithValue("@gct", gct);
                        cmd.Parameters.AddWithValue("@totalbilirubin", totalbilirubin);
                        cmd.Parameters.AddWithValue("@bun", bun);
                        cmd.Parameters.AddWithValue("@creatinine", creatinine);
                        cmd.Parameters.AddWithValue("@renaltech", renaltech);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SavePatientBloodTestResult(string pet_id, string superchen, string totalprotein, string albumin, string globulin)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.bloodtest_result(pet_id, superchen, totalprotein, albumin, globulin)
                                values(@pet_id, @superchen, @totalprotein, @albumin, @globulin)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@superchen", superchen);
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);
                        //cmd.Parameters.AddWithValue("@ag_Ration", ag_Ration);
                        //cmd.Parameters.AddWithValue("@AST_SGOT", AST_SGOT);
                        //cmd.Parameters.AddWithValue("@ALT_SGPT", ALT_SGPT);
                        //cmd.Parameters.AddWithValue("@alk_phosphatese", alk_phosphatese);
                        //cmd.Parameters.AddWithValue("@gct", gct);
                        //cmd.Parameters.AddWithValue("@totalbilirubin", totalbilirubin);
                        //cmd.Parameters.AddWithValue("@bun", bun);
                        //cmd.Parameters.AddWithValue("@creatinine", creatinine);
                        //cmd.Parameters.AddWithValue("@renaltech", renaltech);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SavePatientBloodTestRange(string pet_id, string superchen, string totalprotein, string albumin, string globulin, string ag_Ration,
            string AST_SGOT, string ALT_SGPT, string alk_phosphatese, string gct, string totalbilirubin, string bun, string creatinine,
            string renaltech)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.bloodtest_adult_reference_range(pet_id, superchen, totalprotein, albumin, globulin, ag_Ration,
                                AST_SGOT, ALT_SGPT, alk_phosphatese, gct, totalbilirubin, bun, creatinine, renaltech)
                                values(@pet_id, @superchen, @totalprotein, @albumin, @globulin, @ag_Ration,
                                @AST_SGOT, @ALT_SGPT, @alk_phosphatese, @gct, @totalbilirubin, @bun, @creatinine,@renaltech)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@superchen", superchen);
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);
                        cmd.Parameters.AddWithValue("@ag_Ration", ag_Ration);
                        cmd.Parameters.AddWithValue("@AST_SGOT", AST_SGOT);
                        cmd.Parameters.AddWithValue("@ALT_SGPT", ALT_SGPT);
                        cmd.Parameters.AddWithValue("@alk_phosphatese", alk_phosphatese);
                        cmd.Parameters.AddWithValue("@gct", gct);
                        cmd.Parameters.AddWithValue("@totalbilirubin", totalbilirubin);
                        cmd.Parameters.AddWithValue("@bun", bun);
                        cmd.Parameters.AddWithValue("@creatinine", creatinine);
                        cmd.Parameters.AddWithValue("@renaltech", renaltech);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SavePatientBloodTestUnits(string pet_id, string superchen, string totalprotein, string albumin, string globulin, string ag_Ration,
            string AST_SGOT, string ALT_SGPT, string alk_phosphatese, string gct, string totalbilirubin, string bun, string creatinine,
            string renaltech)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.bloodtest_units(pet_id, superchen, totalprotein, albumin, globulin, ag_Ration,
                                AST_SGOT, ALT_SGPT, alk_phosphatese, gct, totalbilirubin, bun, creatinine, renaltech)
                                values(@pet_id, @superchen, @totalprotein, @albumin, @globulin, @ag_Ration,
                                @AST_SGOT, @ALT_SGPT, @alk_phosphatese, @gct, @totalbilirubin, @bun, @creatinine,@renaltech)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@pet_id", pet_id);
                        cmd.Parameters.AddWithValue("@superchen", superchen);
                        cmd.Parameters.AddWithValue("@totalprotein", totalprotein);
                        cmd.Parameters.AddWithValue("@albumin", albumin);
                        cmd.Parameters.AddWithValue("@globulin", globulin);
                        cmd.Parameters.AddWithValue("@ag_Ration", ag_Ration);
                        cmd.Parameters.AddWithValue("@AST_SGOT", AST_SGOT);
                        cmd.Parameters.AddWithValue("@ALT_SGPT", ALT_SGPT);
                        cmd.Parameters.AddWithValue("@alk_phosphatese", alk_phosphatese);
                        cmd.Parameters.AddWithValue("@gct", gct);
                        cmd.Parameters.AddWithValue("@totalbilirubin", totalbilirubin);
                        cmd.Parameters.AddWithValue("@bun", bun);
                        cmd.Parameters.AddWithValue("@creatinine", creatinine);
                        cmd.Parameters.AddWithValue("@renaltech", renaltech);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SaveDewormedPatient(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string service, string deworn_2weeks_date, string deworn_2weeks_medicine,
            string deworn_4weeks_date, string deworn_4weeks_medicine, string deworn_6weeks_date, string deworn_6weeks_medicine, string deworn_8weeks_date,
            string deworn_8weeks_medicine, string deworn_10weeks_date, string deworn_10weeks_medicine, string deworn_12weeks_date, string deworn_12weeks_medicine)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.deworming(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, service, deworn_2weeks_date, deworn_2weeks_medicine, deworn_4weeks_date, deworn_4weeks_medicine,
                                deworn_6weeks_date, deworn_6weeks_medicine, deworn_8weeks_date, deworn_8weeks_medicine, deworn_10weeks_date, deworn_10weeks_medicine, deworn_12weeks_date, deworn_12weeks_medicine)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @service, @deworn_2weeks_date, @deworn_2weeks_medicine, @deworn_4weeks_date, @deworn_4weeks_medicine,
                                @deworn_6weeks_date, @deworn_6weeks_medicine, @deworn_8weeks_date, @deworn_8weeks_medicine, @deworn_10weeks_date, @deworn_10weeks_medicine, @deworn_12weeks_date, @deworn_12weeks_medicine)";
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
                        cmd.Parameters.AddWithValue("@service", service);
                        cmd.Parameters.AddWithValue("@deworn_2weeks_date", deworn_2weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_2weeks_medicine", deworn_2weeks_medicine);
                        cmd.Parameters.AddWithValue("@deworn_4weeks_date", deworn_4weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_4weeks_medicine", deworn_4weeks_medicine);
                        cmd.Parameters.AddWithValue("@deworn_6weeks_date", deworn_6weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_6weeks_medicine", deworn_6weeks_medicine);
                        cmd.Parameters.AddWithValue("@deworn_8weeks_date", deworn_8weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_8weeks_medicine", deworn_8weeks_medicine);
                        cmd.Parameters.AddWithValue("@deworn_10weeks_date", deworn_10weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_10weeks_medicine", deworn_10weeks_medicine);
                        cmd.Parameters.AddWithValue("@deworn_12weeks_date", deworn_12weeks_date);
                        cmd.Parameters.AddWithValue("@deworn_12weeks_medicine", deworn_12weeks_medicine);


                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SavePatientVaccination(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_allergies, string operations,
            string first_boost_distemper, string first_date_distemper, string second_boost_distemper, string second_date_distemper, string third_boost_distemper,
            string third_date_distemper, string first_boost_feline, string first_date_feline, string second_boost_feline, string second_date_feline, string first_boost_rabies, string first_date_rabies)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.vaccination(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_allergies, operations, first_boost_distemper, first_date_distemper, second_boost_distemper,
                                second_date_distemper, third_boost_distemper, third_date_distemper, first_boost_feline, first_date_feline, second_boost_feline,
                                second_date_feline, first_boost_rabies, first_date_rabies)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_allergies, @operations, @first_boost_distemper, @first_date_distemper, @second_boost_distemper,
                                @second_date_distemper, @third_boost_distemper, @third_date_distemper, @first_boost_feline, @first_date_feline, @second_boost_feline,
                                @second_date_feline, @first_boost_rabies, @first_date_rabies)";
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
                        cmd.Parameters.AddWithValue("@pet_allergies", pet_allergies);
                        cmd.Parameters.AddWithValue("@operations", operations);

                        cmd.Parameters.AddWithValue("@first_boost_distemper", first_boost_distemper);
                        cmd.Parameters.AddWithValue("@first_date_distemper", first_date_distemper);
                        cmd.Parameters.AddWithValue("@second_boost_distemper", second_boost_distemper);
                        cmd.Parameters.AddWithValue("@second_date_distemper", second_date_distemper);
                        cmd.Parameters.AddWithValue("@third_boost_distemper", third_boost_distemper);
                        cmd.Parameters.AddWithValue("@third_date_distemper", third_date_distemper);

                        cmd.Parameters.AddWithValue("@first_boost_feline", first_boost_feline);
                        cmd.Parameters.AddWithValue("@first_date_feline", first_date_feline);
                        cmd.Parameters.AddWithValue("@second_boost_feline", second_boost_feline);
                        cmd.Parameters.AddWithValue("@second_date_feline", second_date_feline);

                        cmd.Parameters.AddWithValue("@first_boost_rabies", first_boost_rabies);
                        cmd.Parameters.AddWithValue("@first_date_rabies", first_date_rabies);


                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public bool SavePatientCrastration(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.crastration(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_weight, pet_allergies, pet_existdisease, operation, op_date, op_time)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_weight, @pet_allergies, @pet_existdisease,  @operation, @op_date, @op_time)";
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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }
        public bool SavePatientLygaeidae(string pet_id, string owners_name, string phone_num, string address, string pet_name, int pet_age,
            string pet_gender, DateTime pet_bday, string pet_species, string pet_breed, string pet_weight, string pet_allergies, string pet_existdisease,
            string operation, DateTime op_date, string op_time)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"insert into dss_database.lygaeidae(pet_id, owners_name, phone_num, address, pet_name, pet_age,
                                pet_gender, pet_bday, pet_species, pet_breed, pet_weight, pet_allergies, pet_existdisease, operation, op_date, op_time)
                                values(@pet_id, @owners_name, @phone_num, @address, @pet_name, @pet_age,
                                @pet_gender, @pet_bday, @pet_species, @pet_breed, @pet_weight, @pet_allergies, @pet_existdisease,  @operation, @op_date, @op_time)";
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
                        cmd.Parameters.AddWithValue("@pet_existdisease", pet_existdisease);
                        cmd.Parameters.AddWithValue("@operation", operation);
                        cmd.Parameters.AddWithValue("@op_date", op_date);
                        cmd.Parameters.AddWithValue("@op_time", op_time);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving Patient: " + ex.ToString());
                return false;
            }
        }

        public void LoadSkinTreatment(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Services'
                                    FROM dss_database.skintreatment";

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

        public void LoadCPT(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Services'
                                    FROM dss_database.CPTest";

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

        public void LoadCDT(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Services'
                                    FROM dss_database.CDTest";

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

        public void LoadBloodParasite(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Services'
                                    FROM dss_database.bloodparasite";

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

        public void LoadDeworming(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', service AS 'Service'
                                    FROM dss_database.deworming";

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

        public void LoadPregCesarean(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Operation'
                                    FROM dss_database.preg_cesarian";

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

        public void LoadEyeOperation(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Operation'
                                    FROM dss_database.eyeoperation";

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

        public void LoadEarOperation(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Operation'
                                    FROM dss_database.earoperation";

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

        public void LoadMammary(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT pet_id AS 'Pet ID', owners_name AS 'Owners Name', pet_name AS 'Patient Name', 
                                    pet_gender AS 'Gender', pet_bday AS 'Birthdate', pet_age AS 'Age', pet_breed AS 'Animal Breed', operation AS 'Operation'
                                    FROM dss_database.mammarry";

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
    }
}
