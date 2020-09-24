using System.ComponentModel.DataAnnotations;

namespace Core.UseCases.AddPerson
{
    public struct AddPersonRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
