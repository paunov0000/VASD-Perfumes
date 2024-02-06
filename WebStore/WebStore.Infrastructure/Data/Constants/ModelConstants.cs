using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Infrastructure.Data.Constants
{
    public static class ModelConstants
    {
        public static class Product
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 3;
            public const int DescriptionMaxLength = 1000;
            public const int DescriptionMinLength = 10;
            public const int ManufacturerMaxLength = 100;
            public const int ManufacturerMinLength = 5;
            public const string PriceMaxValue = "5000";
            public const string PriceMinValue = "0";
            //public const int ImageMaxLength = 1000;
        }

        public static class ProductCategory
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 3;
            public const int DescriptionMaxLength = 1000;
            public const int DescriptionMinLength = 10;
            //public const int ImageMaxLength = 1000;
        }

        public static class Review
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 2;
            public const int CommentMaxLength = 500;
            public const int CommentMinLength = 2;
        }


    }
}
