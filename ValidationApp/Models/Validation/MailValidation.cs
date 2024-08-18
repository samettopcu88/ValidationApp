using System.ComponentModel.DataAnnotations;

namespace ValidationApp.Models.Validation
{
    public class MailValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string kontrolEdilecekVeri = string.Empty;
            if (value == null) return false;

            kontrolEdilecekVeri = value.ToString();

            if (kontrolEdilecekVeri.Where(x => x == ' ').ToList().Count() > 0)
                return false;

            if (kontrolEdilecekVeri.Split('@').Count() > 2)
                return false;

            if (kontrolEdilecekVeri.EndsWith("@contoso.com"))
                return true;

            return false;
            //return base.IsValid(value);
        }
    }
}
