using FluentValidation;
using static WebApiWithOnion.bl.Validato.IBaseValidor;

namespace WebApiWithOnion.bl.Validato
{
    public abstract class BaseValidator<T> : AbstractValidator<T>, IBaseValidator
    {

        /// <summary>
        /// Este metodo se encarga de decidir cual RuleSet se se ejecutara, en base a una evaluacion del objeto enviado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public virtual string[] GetRulerelativeName(object dto)
        {
            return new string[] { "default" };
        }
    }
}