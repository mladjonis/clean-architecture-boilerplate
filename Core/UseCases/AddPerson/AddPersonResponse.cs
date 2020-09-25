using Core.Entities.Enums;

namespace Core.UseCases.AddPerson
{
    public struct AddPersonResponse
    {
        public string ValidationMessage { get; set; }
        public int PersonId { get; set; }
        public PersonResponseStatus ResponseStatus { get; set; }
    }
}
