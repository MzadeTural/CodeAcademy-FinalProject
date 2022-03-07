using FluentValidation;
using StudentInformationSysteam.Business.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.Validators.Account
{
    public class LoginVMValidation: AbstractValidator<LoginVM>
    {
        public LoginVMValidation()
        {
            RuleFor(r=>r.Identifier).NotNull().NotNull();
            RuleFor(r => r.Password).NotNull().NotEmpty();
        }
    }
}
