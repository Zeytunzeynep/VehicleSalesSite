using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleSalesSiteProject.Dto.Dtos.AppUserDtos;

namespace VehicleSalesSiteProject.Business.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidation : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidation() {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Domain field must be filled");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Domain field must be filled");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Domain field must be filled");
            RuleFor(x => x.Gmail).NotEmpty().WithMessage("Domain field must be filled");
            
            RuleFor(x => x.Password).NotEmpty().WithMessage("Domain field must be filled");
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Password must be  at least 6 characters long");
            RuleFor(x => x.Password).MaximumLength(8).WithMessage("Password must be  at most 8 characters long");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage(" Password didnt match , please try again");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Domain field must be filled");
            
             


        }
    }
}
