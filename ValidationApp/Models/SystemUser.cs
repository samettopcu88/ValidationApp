using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ValidationApp.Models.Validation;

namespace ValidationApp.Models
{

    //ASP.NET Core uses  Microsoft.AspNetCore.Mvc **ModelMetadataType** instead of System.ComponentModel.DataAnnotations.** MetadataType** 

    //[MetadataType(typeof(SystemUserValidation))]
    [ModelMetadataType(typeof(SystemUserValidation))]
    public class SystemUser 
    {
        //[Required(ErrorMessage ="Kullanıcı Adı Boş Geçilemez")]
        //[StringLength(10,ErrorMessage ="Kullanıcı Adı en az 3 en fazla 10 karakter olmalı",MinimumLength =3)]
        public string UserName { get; set; }

        //[Required(ErrorMessage ="T.C. Kimlik Numarası boş olamaz....")]
        //[IdentificationNumberValidation(ErrorMessage="Geçersiz T.C. Numarası")]

        public string IdentificationNumber {  get; set; }

        //[Required(ErrorMessage ="Puan Alanı Boş Geçilemez....")]
        //[Range(0,100,ErrorMessage ="Puan [0,100] arasında olmalıdır...")]
        public int Score {  get; set; }

        //[Required(ErrorMessage ="E-posta adresi boş olamaz...")]
        //[MailValidation(ErrorMessage="E-posta adresi @contoso.com ile sonlanmalıdır ve boşluk içermemelidir...")]
        public string EmailAddress {  get; set; }

        //[Required(ErrorMessage ="Şifre alanı boş olamaz....")]
        //[StringLength(20,ErrorMessage ="Şifre en az 8 karakter en fazla 20 karakter olmalıdır...",MinimumLength =8)]
        
        public string Password {  get; set; }

        //[NotMapped]
        //[Required(ErrorMessage ="Şifre tekrar alanı boş olamaz...")]
        //[Compare("Password",ErrorMessage ="Parola tekrarı ile parola aynı olmalıdır...")]
        public string PasswordConfirmation {  get; set; }
    }
}
