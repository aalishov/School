namespace BrokerCompany.Common
{
    public static class CompanyControllerSM
    {
        public const string CompanyCreateSuccessfully = "Company {0} was successfully registerd in the system!";
        public const string CompanyAlreadyRegistered = "Company {0} is already registered!";
        public const string CompanyNotFound = "Invalid Company: {0}. Cannot find it in system!";
        public const string CompanyCount = "Companies: {0}";
        public const string BuildingRegisterSuccessfully = "Building {0} was successfully registerd in {1} catalog!";
        public const string BuildingAlreadyRegistered = "Building {0} is already registered in {1}!";
        public const string BrokerRegisterSuccessfully = "Broker {0} was successfully hired in {1}!";
        public const string BrokerAlreadyRegistered = "Broker {0} is already part of {1}!";

        public const string RentBuildingSuccessfully = "Successfully rented {0}!\nBroker {1} earned {2:f2}!";

        public const string BuildingNotFound = "Invalid Building: {0}. Cannot find it in {1} catalog!";
        public const string BuildingAlreadeRented = "Building: {0} cannot be rented!";
        public const string BrokerNotFound = ": Invalid Broker: {0}. Cannot find employee in {1}!";

    }
}
