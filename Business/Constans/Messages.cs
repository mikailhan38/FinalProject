﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün adı geçersiz";
        public static string MaintenanceTime = "Sistemin Bakım Zamanı Nedeniyle Liste Getirilemedi";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bu kategoride 10 dan fazla ürün eklemesi yapılamaz";
        public static string ProductUpdated = "Ürün Güncellemesi Başarılı";
        public static string ProductNameAlreadyExists="Aynı isimde zaten bir ürün var";
        public static string CategoryLimitExceded="Kategori limiti 15 ile sınırlıdır.";
        public static string AuthorizationDenied="YETKİNİZ YOK";
        public static string UserRegistered="Kullanıcı kaydedildi.";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string SuccessfulLogin="Giriş Başarılı";
        public static string UserAlreadyExists="Kullanıcı Adı Zaten Var";
        public static string AccessTokenCreated="Token Başarılı";
    }
}
