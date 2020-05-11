using LibraryCoreProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Core.Helpers
{
    public static class EnumerableExpressionHelper
    {
        public static Expression<Func<TSource, string>> CreateEnumToStringExpression<TSource, TMember>(
       Expression<Func<TSource, TMember>> memberAccess, string defaultValue = "")
        {
            var type = typeof(TMember);
            if (!type.IsEnum)
            {
                throw new InvalidOperationException("TMember must be an Enum type");
            }

            var enumNames = Enum.GetNames(type);
            var enumValues = (TMember[])Enum.GetValues(type);

            var inner = (Expression)Expression.Constant(defaultValue);

            var parameter = memberAccess.Parameters[0];

            for (int i = 0; i < enumValues.Length; i++)
            {
                inner = Expression.Condition(
                Expression.Equal(memberAccess.Body, Expression.Constant(enumValues[i])),
                Expression.Constant(enumNames[i]),
                inner);
            }

            var expression = Expression.Lambda<Func<TSource, string>>(inner, parameter);

            return expression;
        }

        public static string GetStringFromEnumInt(int value)
        {
            var res = Enum.GetName(typeof(Category), value);
            return res;
        }
    }
}
