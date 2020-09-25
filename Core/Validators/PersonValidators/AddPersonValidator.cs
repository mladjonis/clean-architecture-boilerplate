using Core.Abstractions.Validators.PersonValidators;
using Core.Entities.Enums;
using Core.UseCases.AddPerson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Validators.PersonValidators
{
    public class AddPersonValidator : IAddPersonValidator
    {
        public PersonResponseStatus NewPersonValidation(AddPersonRequest clientRequest)
        {
            throw new NotImplementedException();
        }
    }
}
