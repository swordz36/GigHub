using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value)
                , "dd MMM yyyy"
                , CultureInfo.CurrentCulture
                , DateTimeStyles.None, out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }

    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value)
                , "HH:mm"
                , CultureInfo.CurrentCulture
                , DateTimeStyles.None, out dateTime);
            return (isValid);
        }
    }
}
