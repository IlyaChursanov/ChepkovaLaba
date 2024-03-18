using Npgsql;
using System;
using System.Data;
using System.Net;

namespace WinFormsApp2
{
    public class DatabaseManager
    {
        private const string ConnectionString = "Host=localhost;Username=postgres;Password=1111;Database=Fakel";

        public DataTable GetAllRepairs()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Repairs";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public void AddRepair(string equipment, string faultType, string problemDescription, string client, string initialStatus)
        {
            DateTime dateAdded = DateTime.Now;
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Repairs (DateAdded, Equipment, FaultType, ProblemDescription, Client, Status) 
                         VALUES (@DateAdded, @Equipment, @FaultType, @ProblemDescription, @Client, @InitialStatus)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DateAdded", dateAdded);
                    command.Parameters.AddWithValue("@Equipment", equipment);
                    command.Parameters.AddWithValue("@FaultType", faultType);
                    command.Parameters.AddWithValue("@ProblemDescription", problemDescription);
                    command.Parameters.AddWithValue("@Client", client);
                    command.Parameters.AddWithValue("@InitialStatus", initialStatus);
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetAllRepairsForUser(string username)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Repairs WHERE Client = @Username";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public void UpdateRepairStatus(int requestId, string newStatus, string faultType)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Repairs SET Status = @NewStatus, FaultType = @FaultType WHERE RequestNumber = @RequestId";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewStatus", newStatus);
                    command.Parameters.AddWithValue("@FaultType", faultType);
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateRepair(int requestId, string equipment, string faultType, string problemDescription, string client, string status)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"UPDATE Repairs 
                         SET Equipment = @Equipment, 
                             FaultType = @FaultType, 
                             ProblemDescription = @ProblemDescription, 
                             Client = @Client, 
                             Status = @Status 
                         WHERE RequestNumber = @RequestId";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Equipment", equipment);
                    command.Parameters.AddWithValue("@FaultType", faultType);
                    command.Parameters.AddWithValue("@ProblemDescription", problemDescription);
                    command.Parameters.AddWithValue("@Client", client);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}