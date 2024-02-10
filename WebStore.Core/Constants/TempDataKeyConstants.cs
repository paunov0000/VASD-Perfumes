using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Core.Constants
{
    public static class TempDataKeyConstants
    {

        public static class Status
        {
            public const string Error = "Error";
            public const string Success = "Success";
            public const string Info = "Info";
        }

        public static class Product
        {
            public const string SuccessOnAddMessage = "Успешно добавихте артикул.";

            public const string SuccessOnEditMessage = "Успешно редактирахте артикул.";

            public const string SuccessOnDeleteMessage = "Успешно изтрихте артикул.";

            public const string InvalidInputMessage = "Невалидни данни, опитай отново.";
        }

    }
}
