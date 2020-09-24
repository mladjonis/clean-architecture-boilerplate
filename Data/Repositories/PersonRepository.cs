using Core.Abstractions.Repositories;
using Core.Entities;
using System;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public int AddPerson(Person person)
        {
            throw new NotImplementedException();
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
