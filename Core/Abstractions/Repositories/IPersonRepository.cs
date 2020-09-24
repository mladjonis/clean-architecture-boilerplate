using Core.Entities;
using System.Collections.Generic;

namespace Core.Abstractions.Repositories
{
    public interface IPersonRepository
    {
        int AddPerson(Person person);
        void EditPerson(Person person);
        void DeletePerson(int personID);
        Person GetByName(string name);
        IEnumerable<Person> GetAll();
    }
}
