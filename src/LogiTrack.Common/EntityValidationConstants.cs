namespace LogiTrack.Common
{
    public static class EntityValidationConstants
    {
        public class Driver
        {
            public const int FirstNameMinValue = 1;
            public const int FirstNameMaxValue = 20;

            public const int LastNameMinValue = 1;
            public const int LastNameMaxValue = 20;

            public const int PhoneNumberMinLength = 8;
            public const int PhoneNumberMaxLength = 20;
        }

        public class Vehicle
        {
            public const int BrandMinLength = 1;
            public const int BrandMaxLength = 20;

            public const int ModelMinLength = 1;
            public const int ModelMaxLength = 20;

            public const int PlateNumberMinValue = 7;
            public const int PlateNumberMaxValue = 8;
        }

        public class Shipment
        {
            public const int OriginAddressMinValue = 5;
            public const int OriginAddressMaxValue = 250;

            public const int DestinationAddressMinValue = 5;
            public const int DestinationAddressMaxValue = 250;
        }
    }
}
