using System;
using System.Data.SqlClient;

namespace Update_Data.Folder
{
    public class ContactRepository
    {
        private static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=123456;";

        // دالة البحث
        public static bool SearchContactByID(int contactID, ref stcontact contact)
        {
            bool isExist = false;
            string query = "SELECT * FROM Contacts WHERE ContactID = @contactID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@contactID", contactID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            contact.ContactsID = (int)reader["ContactID"];
                            contact.FirstName = (string)reader["FirstName"];
                            contact.LastName = (string)reader["LastName"];
                            contact.Email = (string)reader["Email"];
                            contact.Phone = (string)reader["Phone"];
                            contact.Address = (string)reader["Address"];
                            contact.CountryID = (int)reader["CountryID"];
                            isExist = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in Search: " + ex.Message);
                }
            }
            return isExist;
        }

        // دالة التحديث
        public static bool UpdateRecordContact(stcontact contact)
        {
            bool isUpdated = false;
            string query = @"UPDATE Contacts  
                             SET FirstName = @FirstName,
                                 LastName = @LastName,
                                 Email = @Email, 
                                 Phone = @Phone,
                                 Address = @Address,
                                 CountryID = @CountryID 
                             WHERE ContactID = @ContactsID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ContactsID", contact.ContactsID);
                command.Parameters.AddWithValue("@LastName", contact.LastName);
                command.Parameters.AddWithValue("@FirstName", contact.FirstName);
                command.Parameters.AddWithValue("@Email", contact.Email);
                command.Parameters.AddWithValue("@Phone", contact.Phone);
                command.Parameters.AddWithValue("@Address", contact.Address);
                command.Parameters.AddWithValue("@CountryID", contact.CountryID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isUpdated = (rowsAffected > 0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in Update: " + ex.Message);
                }
            }
            return isUpdated;
        }

        // دالة الحذف
        public static bool DeleteContact(int contactID)
        {
            bool isDeleted = false;
            string query = "DELETE FROM Contacts WHERE ContactID = @contactID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@contactID", contactID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    
                    isDeleted = (rowsAffected > 0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in Delete: " + ex.Message);
                }
            }
            return isDeleted;
        }
    }


}