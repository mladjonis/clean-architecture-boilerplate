using Core.Abstractions.Repositories;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private string connectionString = string.Empty;

        //fill out command and queries -- CQRS pattern
        #region SQL Commands and Queries
        private const string InsertPersonSql = @"";

        private const string UpdatePersonSql = @"";

        private const string DeletePersonSql = @"";

        private const string SelectSinglePersonSql = @"";

        private const string SelectPersonsSql = @"";
        #endregion


        public PersonRepository(SqlConnection dbConnection)
        {
            connectionString = dbConnection.ConnectionString;
        }

        //returns automatically generated id from db -- autoincrement id
        public int AddPerson(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(InsertPersonSql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@name", person.Name);

                    connection.Open();

                    var id = (int)command.ExecuteScalar();
                    connection.Close();
                    return id;
                }
            }
        }

        public void DeletePerson(int personID)
        {
            throw new NotImplementedException();
        }

        public void EditPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
