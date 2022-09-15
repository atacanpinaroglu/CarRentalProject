using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarNameOrDailyPriceInvalid = "Araba ismi veya günlük ücret miktarı geçersiz";
        public static string AllCarsListed = "Bütün Arabalar listelendi";
        public static string AllCarsDetailsListed = "Bütün Arabaların özellikleri listelendi";
        public static string CarListedById = "Araba listelendi";
        public static string AllCarsListedByBrandId = "Bütün Arabalar markaya göre listelendi";
        public static string AllCarsListedByColorId = "Bütün Arabalar renge göre listelendi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string AllBrandsListed = "Bütün markalar listelendi";
        public static string BrandListedById = "Marka listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string AllColorsListed = "Bütün renkler listelendi";
        public static string ColorListedById = "Renk listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string AllCustomersListed = "Bütün müşteriler listelendi";
        public static string CustomerListedById = "Müşteri listelendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string AllUsersListed = "Bütün kullanıcılar listelendi";
        public static string UserListedById = "Kullanıcı listelendi";

        public static string RentalAdded = "Kiralama eklendi";       
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string AllRentalsListed = "Bütün kiralamalar listelendi";
        public static string RentalListedById = "Kiralama listelendi";
        public static string RentalCarNotAvailable = "Kiralamak istediğiniz araba şu anda müsait değil";

        public static string CarImageAdded = "Resim eklendi";
        public static string CarImageUpdated = "Resim güncellendi";
        public static string CarImageDeleted = "Resim silindi";
        public static string CarImagesListedByCarId = "Arabaya ait bütün resimler listelendi";
        public static string CarImageLimitExceeded = "Bir arabının en fazla 5 resmi olabilir";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string SuccessfulRegistered = "Kayıt olma başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut değil";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
