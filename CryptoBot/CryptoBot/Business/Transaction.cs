using System;

namespace CryptoBot.Business
{
  internal class Transaction
  {
    public DateTime BuyDate { get; set; }
    
    public decimal BuyPrice { get; set; }

    public decimal CurrentEstimatedProfit { get; set; }

    public DateTime SellDate { get; set; }
    
    public decimal SellPrice { get; set; }

  }
}
