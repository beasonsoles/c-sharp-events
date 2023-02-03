//stockbroker.cs
// CECS475 - Lab 1
// Beatriz Sonsoles Encinas Muñoz

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace Stock
{
	//!NOTE!: Class StockBroker has fields broker name and a list of Stock named stocks.
	// addStock method registers the Notify listener with the stock (in addition to
	// adding it to the lsit of stocks held by the broker). This notify method outputs
	// to the console the name, value, and the number of changes of the stock whose
	// value is out of the range given the stock's notification threshold.
	public class StockBroker
	{
		public string BrokerName { get; set; }
		
		public List<Stocks> stocks = new List<Stocks>();
		
		public static ReaderWriterLockSlim myLock = new ReaderWriterLockSlim();
		//readonly string docPath = @"C:\Users\Documents\CECS 475\Lab3_output.txt";
		
		readonly string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lab1_output.txt");
		
		public string titles = "Broker".PadRight(10) + "Stock".PadRight(15) + 
			"Value".PadRight(10) + "Changes".PadRight(10) + "Date and Time";
		
		/// <summary>
		/// The stockbroker object
		/// </summary>
		/// <param name="brokerName">The stockbroker's name</param>
		public StockBroker(string brokerName)
		{
			BrokerName = brokerName;
		}
		
		/// <summary>
		/// Adds stock objects to the stock list
		/// </summary>
		/// <param name="stock">Stock object</param>
		public void AddStock(Stocks stock)
		{
			//stocks._____________________________
			//stock.____________________________________
		}
		
		/// <summary>
		/// The eventhandler that raises the event of a change
		/// </summary>
		/// <param name="sender">The sender that indicated a change</param>
		/// <param name="e">Event arguments</param>
		void EventHandler(Object sender, EventArgs e)
		{
			//try
			//{ //LOCK Mechanism
			//	______________________________
			//	Stocks newStock = (Stocks)sender;
			//	//string statement;
			//	//!NOTE!: Check out C#events, pg.4
			//	// Display the output to the console windows
			//	Console.WriteLine(BrokerName.PadRight(16)
			//	______________________________________________);
			//	//Display the output to the file
			//	using (StreamWriter outputFile
			//	=________________________________________________)
			//	{
			//	________________________________________________
			//	}
			//	//RELEASE the lock
			//	____________________
			//}
			//finally
			//{
				
			//}
		}
	}
}