using BlazorApp.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Validation
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage("Enter name");
            RuleFor(r => r.Name).Custom((name, context) => {
                char[] arr = name?.ToCharArray();
                bool condition = false;
                if (arr != null)
                    foreach (var s in arr)
                       if (!char.IsLetter(s))
                           condition = true;
                    
                if (condition)
                    context.AddFailure("Invalid name");
            });

            RuleFor(r => r.Email).NotEmpty().WithMessage("Enter email")
                .EmailAddress().WithMessage("Email is not a valid email address");

            RuleFor(r => r.Password).NotEmpty().WithMessage("Enter the password")
                .MinimumLength(6).WithMessage("The length of Password must be at least 6 characters");

            RuleFor(r => r.PasswordConfirm).NotEmpty().WithMessage("Enter the password again")
                .Equal(r => r.Password).WithMessage("Passwords do not match");
        }
    }
}
