using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace MvcApplication.Helpers
{
    public static class HtmlExtensions
    {
        // Mimic MVC4's DisplayNameFor
        // http://stackoverflow.com/questions/3885796/get-displayname-attribute-without-using-labelfor-helper-in-asp-net-mvc
        // thanks @DarinDimitrov
        public static MvcHtmlString DisplayNameFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            var metaData = ModelMetadata.FromLambdaExpression<TModel, TProperty>(expression, htmlHelper.ViewData);
            string value = metaData.DisplayName ?? (metaData.PropertyName ?? ExpressionHelper.GetExpressionText(expression));
            return MvcHtmlString.Create(value);
        }
    }
}