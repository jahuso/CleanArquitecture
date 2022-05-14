﻿using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArquitecture.Application.Behaviors
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {

        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        //public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        //{
        //    if (_validators.Any())
        //    {
        //        var context = new ValidationContext<TRequest>(request);

        //        var validationResults = Task.WhenAll(_validators.Select(v => v.ValidateAsync(context,cancellationToken);
        //    }
        //}
    }
}