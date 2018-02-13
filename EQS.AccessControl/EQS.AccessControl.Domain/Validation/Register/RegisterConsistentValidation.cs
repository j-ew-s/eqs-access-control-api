using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Domain.Specification.Credential;
using EQS.AccessControl.Domain.Specification.Person;
using EQS.AccessControl.Domain.Validation.Base;

namespace EQS.AccessControl.Domain.Validation.Register
{
    public class RegisterConsistentValidation
    {
        public BaseValidation BaseValidation { get; set; }
        public RegisterConsistentValidation(Entities.Person person)
        {
            BaseValidation = new BaseValidation();

            var nameSpecification = new NameIsNotNullSpecification();
            BaseValidation.AddSpecification("Name-Specification",
                nameSpecification.IsSatisfyedBy(person),
                "Name is null.");

            var usernameSpecification = new UsernameIsNotNullSpecification();
            BaseValidation.AddSpecification("Username-Specification", 
                usernameSpecification.IsSatisfyedBy(person.Credential), 
                "Username is null.");

            var passwordSpecification = new PasswordIsNotNullSpecification();
            BaseValidation.AddSpecification("Password-Specification", 
                passwordSpecification.IsSatisfyedBy(person.Credential), 
                "Password is null.");

        }
    }
}
