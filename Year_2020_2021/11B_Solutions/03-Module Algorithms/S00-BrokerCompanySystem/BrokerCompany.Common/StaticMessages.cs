namespace BrokerCompany.Common
{
    public static class StaticMessages
    {
        //Building exception messages
        public const string BuildingInvalidNameValue = "Building name must not be null or empty!";
        public const string BuildingCityInvalidNameValue = "City must not be null or empty!";
        public const string BuildingStarsInvalidValue = "Stars cannot be less than 0 or above 5!";
        public const string BuildingRentAmaountInvalidValue = "Rent amount cannot be less or equal to 0!";

        //Building ToString() messages
        public const string BuildingNameAndStars = "****Building: {0} <{1}>";
        public const string BuildingLocation = "****Location: {0}";
        public const string BuildingRentAmount = "****RentAmount: {0:f2}";
        public const string BuildingIsAvailable = "****Is Available: {0}";

        //Hotel exception messages
        public const string HotelInvalidNameValue = "Name of hotel buildings should end on Hotel!";
    }
}
