using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P00_Market
{
    public class Investor
    {
        private readonly List<Stock> portfolio;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            portfolio = new List<Stock>();
        }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Count { get { return portfolio.Count; } }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && MoneyToInvest > stock.PricePerShare)
            {
                portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            Stock stock = FindStock(companyName);
            if (stock == null)
            {
                return $"{companyName} does not exist.";
            }
            if (stock.PricePerShare<=sellPrice)
            {
                portfolio.Remove(stock);
                MoneyToInvest += sellPrice;
                return $"{companyName} was sold.";
            }
            return $"Cannot sell {companyName}.";
        }

        public Stock FindStock(string companyName)
        {
            return portfolio.FirstOrDefault(x => x.CompanyName == companyName);
        }

        public Stock FindBiggestCompany()
        {
            return portfolio.OrderBy(x => x.MarketCapitalization).LastOrDefault();
        }

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var stock in portfolio)
            {
                sb.AppendLine(stock.ToString());
            }  
            return sb.ToString().TrimEnd();
        }
    }
}
