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
            public const string PriceMaxValue = "5000";
            public const string PriceMinValue = "0";
            //public const int ImageMaxLength = 1000;
        }

        public static class Category
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 3;
            //public const int ImageMaxLength = 1000;
        }

        public static class Review
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 2;
            public const int CommentMaxLength = 500;
            public const int CommentMinLength = 2;
        }

        public static class Brand
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 5;
            //public const int ImageMaxLength = 1000;
        }

        public static class OrderStatus
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 3;
        }

        public static class Customer
        {
            public const int AddressMaxLength = 100;
            public const int AddressMinLength = 10;
            public const int CityMaxLength = 100;
            public const int CityMinLength = 3;
            public const int StateMaxLength = 50;
            public const int StateMinLength = 2;
            public const int ZipMaxLength = 4;
            public const int ZipMinLength = 4;
        }

    }
}
