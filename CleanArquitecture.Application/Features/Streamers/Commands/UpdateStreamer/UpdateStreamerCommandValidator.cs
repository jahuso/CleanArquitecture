using FluentValidation;

namespace CleanArquitecture.Application.Features.Streamers.Commands.UpdateStreamer
{
    public  class UpdateStreamerCommandValidator: AbstractValidator<UpdateStreamerCommand>
    {
        public UpdateStreamerCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotNull().WithMessage("{Url} no permite valores nulos");
        }
    }
}
