using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    internal class Student
    {
        My_DB mydb = new My_DB();

        public bool insertStudent(int id, string fname, string lname, DateTime bdate, string gender, int phone, string email, string address, MemoryStream picture, string depart, string major, string htown)
        {

           

            SqlCommand command = new SqlCommand("INSERT INTO Student (id,firstname,lastname,bday,gender,phone,email,address,picture,department,major,hometown)" +
            "VALUES (@id,@fn,@ln,@bday,@gdr,@phn,@ema,@adrs,@pic,@dpt,@maj,@town)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;

            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;

            command.Parameters.Add("@bday", SqlDbType.DateTime).Value = bdate;

            command.Parameters.Add("@gdr", SqlDbType.NChar).Value = gender;

            command.Parameters.Add("@phn", SqlDbType.Int).Value = phone;

            command.Parameters.Add("@ema", SqlDbType.NVarChar).Value = email;

            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;

            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            command.Parameters.Add("@dpt", SqlDbType.NVarChar).Value = depart;

            command.Parameters.Add("@maj", SqlDbType.NVarChar).Value = major;

            command.Parameters.Add("@town", SqlDbType.NVarChar).Value = htown;


            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        
        }

        public DataTable getStudent(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, int phone, string email, string address, MemoryStream picture, string depart, string major, string htowm)
        {
            SqlCommand command = new SqlCommand("UPDATE Student " +
                "SET id=@id,firstname=@fn,lastname=@ln,bday=@bday,gender=@gdr,phone=@phn,email=@ema," +
                "address=@adrs,picture=@pic,department=@dpt,major=@maj,hometown=@town WHERE id=@id", mydb.getConnection);
            command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;

            command.Parameters.AddWithValue("@fn", SqlDbType.NVarChar).Value = fname;

            command.Parameters.AddWithValue("@ln", SqlDbType.NVarChar).Value = lname;

            command.Parameters.AddWithValue("@bday", SqlDbType.DateTime).Value = bdate;

            command.Parameters.AddWithValue("@gdr", SqlDbType.NChar).Value = gender;

            command.Parameters.AddWithValue("@phn", SqlDbType.Int).Value = phone;

            command.Parameters.AddWithValue("@ema", SqlDbType.NVarChar).Value = email;

            command.Parameters.AddWithValue("@adrs", SqlDbType.NVarChar).Value = address;

            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            command.Parameters.AddWithValue("@dpt", SqlDbType.NVarChar).Value = depart;

            command.Parameters.AddWithValue("@maj", SqlDbType.NVarChar).Value = major;

            command.Parameters.AddWithValue("@town", SqlDbType.NVarChar).Value = htowm;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Student WHERE id = " + id, mydb.getConnection);
            
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false ;
            }
        }

    }
}
