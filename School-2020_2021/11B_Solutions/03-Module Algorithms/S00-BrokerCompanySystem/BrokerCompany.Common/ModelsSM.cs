namespace BrokerCompany.Common
{
    public static class ModelsSM
    {
        //Exception messages
        public const string InvalidNameValue = "{0} name must not be null or empty!";
        public const string CityInvalidNameValue = "City must not be null or empty!";

        //Output messages
        public const string Location = "****Location: {0}";

        //Building exception messages
        public const string HotelInvalidTypeNameValue = "Name of hotel buildings should end on {0}!";
        public const string BuildingStarsInvalidValue = "Stars cannot be less than 0 or above 5!";
        public const string BuildingRentAmaountInvalidValue = "Rent amount cannot be less or equal to 0!";

        //Building ToString() messages
        public const string BuildingNameAndStars = "****Building: {0} <{1}>";

        public const string BuildingRentAmount = "****RentAmount: {0:f2}";
        public const string BuildingIsAvailable = "****Is Available: {0}";

        //Broker exception messages
        public const string BrokerInvalidAge = "Broker's age cannot be less than 16 or above 70!";

        //Broker ToString() messages
        public const string BrokerNameAndAge = "****Broker: {0} <{1}>";
        public const string BrokerBonus = "****Bonus: {0:f2}";
        public const string BrokerBuilding = "****** {0}";

        //Company ToString() messages
        public const string CompanyName = "Company: {0}";
        public const string CompanyBrokersCount = "##Brokers: {0}";
        public const string CompanyBuildingsCount = "##Buildings: {0}";
    }
}
