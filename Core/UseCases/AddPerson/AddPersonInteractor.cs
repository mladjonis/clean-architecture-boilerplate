using Core.Abstractions;
using System;

namespace Core.UseCases.AddPerson
{
    public class AddPersonInteractor : IRequestHandler<AddPersonRequest, AddPersonResponse>
    {
        public AddPersonInteractor()
        {

        }

        public AddPersonResponse Handle(AddPersonRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
