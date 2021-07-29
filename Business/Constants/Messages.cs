using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    //static olunca newlenmiyor direkt çalışıyor
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExistsError = "Böyle ürün ismi zaten var";
        public static string CategoryLimitExceded="kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="TOken oluşturuldu";
    }
}
