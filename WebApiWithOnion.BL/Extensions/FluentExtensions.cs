﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiWithOnion.bl.Extensions
{
    public  static class FluentExtensions
    {
        public static IRuleBuilderOptions<T, TProperty> WithMessage<T, TProperty>(this IRuleBuilderOptions<T, TProperty> rule, string errorMessage, Func<T, TProperty, string> predicate)
        {
            return rule.WithMessage(string.Format(errorMessage, ""));

        }
    }
}
