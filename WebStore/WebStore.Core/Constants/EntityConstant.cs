using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Core.Constants
{
    public static class EntityConstant
    {
        public static class Product
        {
            public const int NameMaxLength = 100;
            public const int DescriptionMaxLength = 1000;
            public const int PriceMaxValue = 5000;
            //public const int ImageMaxLength = 1000;
        }

        public static class ProductCategory
        {
            public const int NameMaxLength = 100;
            public const int DescriptionMaxLength = 1000;
            //public const int ImageMaxLength = 1000;
        }

        public static class Review
        {
            public const int TitleMaxLength = 50;
            public const int CommentMaxLength = 500;
        }
    }
}
