namespace EnduroProject.Data
{
    public class DataConstants
    {
        public class Event
        {
            public const int NameMaxLength = 20;
            public const int NameMinLength = 5;
            public const int DescriptionMinLenght = 5;
            public const int LocationMaxLength = 100;
            public const int LocationMinLength = 5;
            public const int ContactInfoMaxLength = 15;
            public const int ContactInfoMinLength = 5;
        }

        public class User
        {
            public const int FullNameMinLength = 5;
            public const int FullNameMaxLength = 40;
            public const int PassWordMinLenght = 6;
            public const int PassWordMaxLenght = 100;
        }

        public class Category
        {
            public const int NameMaxLength = 10;
        }
    }
}
