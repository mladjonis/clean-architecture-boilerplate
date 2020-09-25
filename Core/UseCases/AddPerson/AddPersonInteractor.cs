using Core.Abstractions;
using Core.Abstractions.Repositories;
using Core.Abstractions.Validators.PersonValidators;
using Core.Entities;
using Core.Entities.Enums;
using System;

namespace Core.UseCases.AddPerson
{
    public class AddPersonInteractor : IRequestHandler<AddPersonRequest, AddPersonResponse>
    {
        private IAddPersonValidator _addPersonValidator;
        private IPersonRepository _personRepository;

        public AddPersonInteractor(IAddPersonValidator addPersonValidator, IPersonRepository personRepository)
        {
            this._addPersonValidator = addPersonValidator;
            this._personRepository = personRepository;
        }

        //if error returns 0 as id as indicator for not executing query
        public AddPersonResponse Handle(AddPersonRequest request)
        {
            PersonResponseStatus validationStatus = _addPersonValidator.NewPersonValidation(request);

            if (validationStatus != PersonResponseStatus.OK)
            {
                return new AddPersonResponse
                {
                    ValidationMessage = Enum.GetName(typeof(PersonResponseStatus), validationStatus),
                    PersonId = 0,
                    ResponseStatus = validationStatus
                };
            }

            var addedPerson = _personRepository.AddPerson(new Person
            {
                Name = request.Name
            });

            return new AddPersonResponse
            {
                ValidationMessage = "No problems here",
                PersonId = addedPerson,
                ResponseStatus = PersonResponseStatus.OK
            };
        }
    }
}
