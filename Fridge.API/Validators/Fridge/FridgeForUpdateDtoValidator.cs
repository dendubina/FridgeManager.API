﻿using Entities.DTO.Fridges;
using FluentValidation;

namespace Fridge.API.Validators.Fridge
{
    public class FridgeForUpdateDtoValidator : AbstractValidator<FridgeForUpdateDto>
    {
        public FridgeForUpdateDtoValidator()
        {
            RuleFor(fridge => fridge.ModelYear).GreaterThan(0).WithMessage("ModelYear must be > 0");
        }
    }
}
