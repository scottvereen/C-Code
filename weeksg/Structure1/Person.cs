using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Structure1
{
    public class Person
    {
        private string fName; // makes strings for each
        private string mName;
        private string lName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;
        private string feedback = "";

        bool isValid = true;
        public string FName
        {
            // get means it shares a copy
            get { return fName; }

            // allows changing of values
            set 
            {

                if(Validation.FName(value) == true)
                {
                    
                    feedback += "Hello what is your First Name? \n";
                }
                else if (Validation.IsItFilledIn(value, 1 ) == true)
                {
                    feedback += "Error Invalid First Name";
                }
                else
                {
                    fName = value;
                }
               /* if (value.Contains("Poopy"))
                {
                    feedback += "ERROR: Bad Word inserted in First Name\n"; 
                }
                else
                {
                    fName = value;
                } */
            }
        }

        public string MName
        {
            // get means it shares a copy
            get { return mName; }

            // allows changing of values
            set
            {



                if (Validation.LastName(value) == true)
                {
                    isValid = false;
                    feedback += "Input your Last Name \n";
                }
                else
                {
                    mName = value;
                }
                
            }
        }

        public string LName
        {
            // get means it shares a copy
            get { return lName; }

            // allows changing of values
            set
            {

                if (Validation.LastName(value) == true)
                {
                    feedback += "Error First Name .... Contains the wrong Last name";
                }
                else if (Validation.IsItFilledIn(value, 1) == true)
                {
                    feedback += "Error Invalid Last Name";
                }
                else
                {
                    lName = value;
                }
                
                /* if (value.Contains("Fudge"))
                {
                    feedback += "ERROR: Bad Word inserted in Last Name\n";
                }
                else
                {
                    lName = value;
                }
                 * */
            }
        }

        public string Street1
        {
            // get means it shares a copy
            get { return street1; }

            // allows changing of values
            set
            {
                if (Validation.IsItFilledIn(Street1) == true)
                {
                    isValid = true;
                    feedback += "Add your street address before we find you \n";
                }
                else
                {
                    street1 = value;
                }
            }
        }     

        public string Street2
        {
            // get means it shares a copy
            get { return street2; }

            // allows changing of values
            set
            {
                if (value.Contains("Yeah"))
                {
                    feedback += "ERROR: Bad Word inserted in Street 2\n";
                }
                else
                {
                    street2 = value;
                }
            }
        }

        public string City
        {
            // get means it shares a copy
            get { return city; }

            // allows changing of values
            set
            {
                if (Validation.IsItFilledIn(City) == true)
                {
                    isValid = false;
                    feedback += "Enter Your City Plz \n";
                }
                else
                {
                    city = value;
                }
            }
        }

        public string State
        {
            // get means it shares a copy
            get { return state; }

            // allows changing of values
            set
            {
                if (Validation.IsItFilledIn(State) == true)
                {
                    isValid = false;
                    feedback += "Enter Your City Plz \n";
                }
                else
                {
                    state = value;
                }
            }
        }

        public string Zip
        {
            // get means it shares a copy
            get { return zip; }

            // allows changing of values
            set
            {
                if (Validation.IsAllDigits(Zip))
                {
                    isValid = true;
                    feedback += "Go back and input your Zip \n";
                } 
                else
                {
                    zip = value;
                }
            }
        }

        public string Phone
        {
            // get means it shares a copy
            get { return phone; }

            // allows changing of values
            set
            {
                if (Validation.IsPhoneNumberFilled(Phone))
                {
                    isValid = false;
                    feedback += "House Number plz \n";
                }
                else
                {
                    phone = value;
                }
            }
        }

        public string Email
        {
            // get means it shares a copy
            get { return email; }

            // allows changing of values
            set
            {
                if (Validation.IsValidEmail(Email))
                {
                    isValid = true;
                    feedback += "Your Email has to be 8 characters \n";
                }
                else
                {
                    email = value;
                }
            }
        }
               
            public string Feedback
        {
            // get means it shares a copy
            get { return feedback; }

            // allows changing of values
            
        }

        public string AddPerson()
        {
            string strFeedback = "";     // user feedback

            string strConn = "Server=sql.neit.edu,4500;DataBase=SE255_APacheco; User Id=SE255_APacheco;Password=001350936;";


            SqlConnection conn = new SqlConnection(); // creates a connection object
            conn.ConnectionString = strConn;    // points the connection to our connection string

            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "Insert INTO Person (FName,MName,LName,Street1,Street2,City,State,Zip,Phone,Email) Values (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email)";

            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);

            try 
            {
                conn.Open();  // opens the door

                strFeedback = comm.ExecuteNonQuery().ToString() + "Record Add";

                conn.Close(); // closes the door

                strFeedback = "All Good here";
            }
            catch (Exception err)
            {  
                strFeedback = "ERROR: " + err.Message;
            }

            return strFeedback;        // returns user feedback
        }
 
      
    } 
}

