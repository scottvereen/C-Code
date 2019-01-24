using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   
using System.Data;  

namespace Class
{
    public class Person
    {


        private string fName;
        private string mName;
        private string lName;
        private string street1;
        private string street2;
        private string city;
        private string zip;
        private string state;
        private string phone;
        private string email;
        private DateTime bday;
        public string feedback = "";
        
        
        public Int32 Person_ID = 0;


        public Validation valid = new Validation();

        

        public string Feedback
        {
            get
            {
                return feedback;
            }

        }




        public string FName
        {
            get
            {
                return fName;
            }          //returns the value stored in private
            set
            {
                if (Validation.IsStringClean(value) == false)
                    feedback += "Error: First Name is Wrong";
                else if (Validation.IsItFilledIn(value) == false)//was else if (Validation.IsItFilledIn(value,1) == false) why did the 1 not work?
                    feedback += "Error: Your First Name is invaled";
                else
                    fName = value;

            }
        }









        public string MName
        {

            get
            {

                return mName;
            }

            set
            {

                if (Validation.IsStringClean(value) == false)
                    feedback += "Error: Your Middle Name is Wrong";
                else if (Validation.IsItFilledIn(value) == false)//was else if (Validation.IsItFilledIn(value,1) == false) why did the 1 not work?
                    feedback += "Error: Your middle name entery is invalade thier must be atleast one character in your name";
                else
                    mName = value;
            }



        }
        public string LName
        {

            get
            {

                return lName;
            }

            set
            {

                if (Validation.IsStringClean(value) == false)
                    feedback += "Error: Your Last Name entery is invalad";
                else if (Validation.IsItFilledIn(value) == false)//was else if (Validation.IsItFilledIn(value,1) == false) why did the 1 not work?
                    feedback += "Error: Your Last Name entery is invalade thier must be atleast one character in your name";
                else
                    lName = value;
            }



        }
        
        public string City
        {

            get
            {

                return city;
            }

            set
            {

                city = value;
            }



        }
        public string Zip
        {

            get
            {

                return zip;
            }

            set
            {
                if (Validation.IsNumeric(value) == false)
                    feedback += "Error: Your Zip entery is invalad";         //??Cannot get to work gives error message saying validation class must be defined as a non generic class??//

                else

                    zip = value;
            }



        }

        public string State
        {

            get
            {

                return state;
            }

            set
            {

                state = value;
            }



        }
        public string Phone
        {

            get
            {

                return phone;
            }

            set
            {

                phone = value;
            }



        }
        public string Street1
        {

            get
            {

                return street1;
            }

            set
            {

                street1 = value;
            }




        }
        public string Street2
        {

            get
            {

                return street2;
            }

            set
            {

                street2 = value;
            }



        }

        public string Email
        {

            get
            {

                return email;
            }

            set
            {

                if (Validation.IsValidEmail(value) == false)
                    feedback += "Error: Your Email entery is invalad";
                else if (Validation.IsValidEmail(value) == false)
                    feedback += "Error: Incorrect email";
                else
                    email = value;
            }



        }
        public DateTime Bday
        {
            get
            {
                return bday;
            }
            set
            {
                bday = value;
            }
        }


        public string GetConnectionString()
        {
            return "Server=sql.neit.edu; Database=SE255_SVereen; User Id=SE255_SVereen; Password=001391252;";
        }

        //Adding in the contacts
        public string AddContact()
        {
            string strFeedback = "";

            
            //Creating SQL command string
            string strSQL = "INSERT INTO Persons (fName,mName,lName,city,state,phone,email,street1) VALUES(@FName,@MName,@LName,@City,@State,@Phone,@Email,@Street1)";


            //Create a connection to Data Base       <!--Error commmand-->
            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

            //Create the who, what, where of the Data Base ??Im guessing this puts the information in the Data Base??
            string strConn = @GetConnectionString();
            conn.ConnectionString = strConn;

            //Bark out our command??sends out information??
            //SqlCommand comm = new SqlCommand();

            comm.CommandText = strSQL;  //Commander knows what to say


            comm.Connection = conn; //Where's the phone? Here it is

            //Filling in the paramaters (Has to be created in the same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@FName", fName);
            comm.Parameters.AddWithValue("@MName", mName);
            comm.Parameters.AddWithValue("@LName", lName);
            comm.Parameters.AddWithValue("@City", city);
            comm.Parameters.AddWithValue("@State", state);
            comm.Parameters.AddWithValue("@Phone", phone);
            comm.Parameters.AddWithValue("@Email", email);
            comm.Parameters.AddWithValue("@Street1", street1);




            //comm.Parameters.AddWithValue("@Salary", salary);

            try
            {
                //Open the connection
                conn.Open();

                //Bark command and Hangup
                strFeedback = comm.ExecuteNonQuery().ToString() + "Records Added";
                conn.Close(); //Disconnect
            }

            catch (Exception err)
            {
                strFeedback = "ERROR: " + err.Message;
            }
            return strFeedback;
        }

        public int GetAge()
        {
            int age = DateTime.Today.Year - bday.Year;
            return age;
        }







        //default constructor
        ///<remarks>This is the constructor that was in conflict with the one above</remarks>
        public Person()
        {
            //start by giving feedback in an emplty string
            feedback = "";


           
        }

       
        public Person(string fName, string mName, string lName, string street1, string street2, DateTime bday)//must be atleast 5
        {
            this.FName = fName;
            this.MName = mName;
            this.LName = lName;
            this.Street1 = street1;
            this.Street2 = street2;
            this.Bday = bday;

            feedback = "";


        }




        public DataSet SearchContacts(String FName, String LName)
        {

           
            DataSet ds = new DataSet();

            
            SqlCommand comm = new SqlCommand();
            
           
            String strSQL = "SELECT person_ID, fName,mName,lName FROM Persons WHERE 1=1";

            

            if (FName.Length > 0)
            {
                strSQL += " AND fName LIKE @fName";
                comm.Parameters.AddWithValue("@FName", "%" + FName + "%");

            }
            if (LName.Length > 0)
            {
                strSQL += " AND lName LIKE @lName";
                comm.Parameters.AddWithValue("@LName", "%" + LName + "%");

            }
            
            SqlConnection conn = new SqlConnection();

          

            string strConn = @MyUtilities.GetConnectionString();
            conn.ConnectionString = strConn;

           
            comm.Connection = conn;  
            comm.CommandText = strSQL; 

          
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm; 

            
            conn.Open();
            da.Fill(ds, "Person"); 
            conn.Close(); 

            
            return ds;


        }

        

        public SqlDataReader FindOnePerson(int intPerson_ID)
        {

            
            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

          
            string strConn = @MyUtilities.GetConnectionString();
            conn.ConnectionString = strConn;

            
            String sqlString = "SELECT person_ID, fName,mName,lName FROM Persons WHERE Person_ID = @Person_ID;";

            
            conn.ConnectionString = strConn;


          
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person_ID",intPerson_ID);

         
            conn.Open();

            
            return comm.ExecuteReader();

        }
       
        public Int32 DeleteOnePerson(int intPerson_ID)
        {
            Int32 intRecords = 0;

            
            SqlCommand comm = new SqlCommand();
            SqlConnection conn = new SqlConnection();

        
            string strConn = @MyUtilities.GetConnectionString();
            

            string sqlString =
           "DELETE FROM Persons WHERE Person_ID = @Person_ID;";

        
            conn.ConnectionString = strConn;

   
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

            conn.Open();

        
            intRecords = comm.ExecuteNonQuery();

     
            conn.Close();

            return intRecords;   

        }

        public Int32 UpdateAContact()
        {
            Int32 intRecords = 0;

     
            string strSQL = "UPDATE Persons SET fName = @FName, MName = @MName, LName = @LName WHERE Person_ID = @Person_ID;";

 
           SqlConnection conn = new SqlConnection();

            string strConn = @MyUtilities.GetConnectionString();
            conn.ConnectionString = strConn;

      
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  
            comm.Connection = conn;     

           
            comm.Parameters.AddWithValue("@FName", fName);
            comm.Parameters.AddWithValue("@MName", mName);
            comm.Parameters.AddWithValue("@LName", lName);
            comm.Parameters.AddWithValue("@Person_ID", Person_ID);

            try
            {
                
                conn.Open();

             
                intRecords = comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
            
                conn.Close();
            }

            return intRecords;

        }
     
    };
        
}
