using Core.Entities.Enums;
using Core.UseCases.AddPerson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Abstractions.Validators.PersonValidators
{
    public interface IAddPersonValidator
    {
        PersonResponseStatus NewPersonValidation(AddPersonRequest clientRequest);
    }
}
