using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //constants - sabitler
    public static class Messages
    {
        public static string ProductAddedd = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductListed = "Ürünler listelendi" ;
        public static string MaintenceTime = "Bakım zamanı";
        public static string ProductNameAlreadyExists = "Böyle bir ürün ismi zaten mevcut.";
        public static string AuthorizationDenied = "Yetkisiz işlem";
        internal static string UserRegistered = "Üye olma başarılı";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string PasswordError = "Şifre hatası";
        internal static string SuccessfulLogin = "Giriş başarılı";
        internal static string UserAlreadyExists = "Kullanıcı mevcut";
        internal static string AccessTokenCreated ="Token oluşturuldu.";
    }
}
