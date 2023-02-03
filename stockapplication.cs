// stockapplication.cs

using System;
using Stock;

namespace StockApplication 
{
	class Program
	{
		static void Main(string[] args) 
		{
			Stocks stock1 = new Stocks("Technology",160, 5, 15); 
			Stocks stock2 = new Stocks("Retail",30, 2, 6); 
			Stocks stock3 = new Stocks("Banking", 90, 4, 10); 
			Stocks stock4 = new Stocks("Commodity", 500, 20, 50);
			
			StockBroker b1 = new StockBroker("Broker 1"); 
			b1.AddStock(stock1); 
			b1.AddStock(stock2); 
			
			StockBroker b2 = new StockBroker("Broker 2"); 
			b2.AddStock(stock1); 
			b2.AddStock(stock3); 
			b2.AddStock(stock4); 
			
			StockBroker b3 = new StockBroker("Broker 3"); 
			b3.AddStock(stock1); 
			b3.AddStock(stock3); 
			
			StockBroker b4 = new StockBroker("Broker 4"); 
			b4.AddStock(stock1); 
			b4.AddStock(stock2); 
			b4.AddStock(stock3); 
			b4.AddStock(stock4);
		}
	}
} 