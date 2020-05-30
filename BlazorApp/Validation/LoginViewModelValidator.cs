using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Models;
using FluentValidation;

namespace BlazorApp.Validation
{
    public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
    {
        public LoginViewModelValidator()
        {
            RuleFor(l => l.Email).NotEmpty().WithMessage("Please enter an Email");
            RuleFor(l => l.Password).NotEmpty().WithMessage("Please enter a Password");
        }
    }
}
