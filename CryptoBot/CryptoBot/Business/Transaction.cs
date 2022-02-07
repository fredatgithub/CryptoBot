using System;

namespace CryptoBot.Business
{
  internal class Transaction
  {
    public DateTime BuyDate { get; set; }

    public decimal BuyPrice { get; set; }

    public decimal CurrentEstimatedProfit { get; set; } = 0;

    public decimal Fee { get; set; }

    public int FeePercentage { get; set; }

    public DateTime SellDate { get; set; }

    public decimal SellPrice { get; set; }

    public Transaction()
    {
      BuyDate = DateTime.Now;
      CurrentEstimatedProfit = 0;
    }

    public Transaction(DateTime buyDate) : this()
    {
      BuyDate = buyDate;
    }
  }
}
