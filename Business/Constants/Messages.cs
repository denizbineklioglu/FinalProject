using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProducNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string ProductListed="Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExist="Bu isimde zaten başka bir ürün var.";
    }
}
