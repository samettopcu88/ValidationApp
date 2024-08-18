using System.ComponentModel.DataAnnotations;

namespace ValidationApp.Models.Validation
{
    public class IdentificationNumberValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            //int toplam = 0, ciftToplam = 0, tekToplam = 0;

            if (value == null) return false;

            string id=value.ToString();

            //11 karakter olmalı
            if(id.Length!=11 )
                return false;

            //ilk karakter 0 dan farklı olmalı
            if (id[0] == '0')
                return false;

            //tüm karakterler sayısal olmalı
            for (int i = 0; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i]))
                    return false;
            }

            ////TODO : ilk 10 karkterin toplamının 10 a bölümü son karakteri vermeli
            //int[] tcNumber = new int[11];
            //for (int i = 0;i < 11;i++)
            //{
            //    tcNumber[i] = int.Parse(id[i].ToString());
            //}
            ////char[] tcNUmber = id.ToCharArray();
            //int tenDigit = 0;
            //for (int i = 0;i<10;i++)
            //{
            //    tenDigit += tcNumber[i];
            //}

            //if (tenDigit != tcNumber[10])
            //    return false;


            return true;
            //return base.IsValid(value);
        }
    }
}
