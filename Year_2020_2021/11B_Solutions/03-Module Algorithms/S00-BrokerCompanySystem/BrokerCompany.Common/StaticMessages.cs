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
        public static string buildingNameAndStars = string.Format("****Building: {Name} <{Stars}>");
        public static string buildingLocation = string.Format("****Location: {City}");
        public static string buildingRentAmount = string.Format("****RentAmount: {RentAmount:f2}");
        public static string buildingIsAvailable = string.Format("****Is Available: {IsAvailable}");

        //Hotel exception messages
        public const string HotelInvalidNameValue = "Name of hotel buildings should end on Hotel!";
    }
}
