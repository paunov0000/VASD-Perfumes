namespace WebStore.Core.Constants
{
    public static class ErrorMessageConstants
    {
        public static class CustomIdentityErrorDescriber
        {
            public const string PasswordRequiresDigitMessage = "Паролата трябва да съдържа поне една цифра.";

            public const string PasswordRequiresLowerMessage = "Паролата трябва да съдържа поне една малка буква.";

            public const string PasswordRequiresUpperMessage = "Паролата трябва да съдържа поне една главна буква.";

            public const string PasswordTooShortMessage = "Паролата трябва да съдържа поне {0} символа.";

            public const string DuplicateUserNameMessage = "Потребителското име {0} е заето.";

            public const string DuplicateEmailMessage = "Имейл адресът {0} е регистриран.";

            public const string PasswordRequiresNonAlphanumericMessage = "Паролата трябва да съдържа поне един специален символ.";
        }

        public static class Account
        {
            public const string InvalidCredentialsMessage = "Грешенни данни за вход.";

            public const string PasswordsDoNotMatchMessage = "Паролите не съвпадат.";
        }

        public static class General
        {
            public const string RequiredFieldMessage = "Полето {0} е задължително.";
            public const string InvalidFieldLengthMessage = "Полето {0} трябва да бъде между {2} и {1} символа.";
            public const string InvalidFieldMessage = "Невалидна стойност за поле {0}.";
        }
        
        public static class Product
        {
            public const string InvalidPriceRangeMessage = "Цената трябва да бъде между {1} и {2}.";
        }

    }
}
