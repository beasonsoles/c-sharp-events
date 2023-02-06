//stock.cs
// CECS475 - Lab 1
// Beatriz Sonsoles Encinas Muñoz

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Stock
{
	public class Stocks
	{
		public event EventHandler<StockNotification> StockEvent;

        //Name of our stock.
        public string StockName { get; set; }
        //Starting value of the stock.
        public int InitialValue { get; set; }
        //Max change of the stock that is possible.
        public int CurrentValue { get; set; }
        //Threshold value where we notify subscribers to the event.
        public int MaxChange { get; set; }
        //Amount of changes the stock goes through.
        public int Threshold { get; set; }
        //Current value of the stock.
        public int NumChanges { get; set; }

        //Thread that modifies the stock value every 500 milliseconds
        private readonly Thread _thread;

		/// <summary>
		/// Stock class that contains all the information and changes of the stock
		/// </summary>
		/// <param name="name">Stock name</param>
		/// <param name="startingValue">Starting stock value</param>
		/// <param name="maxChange">The max value change of the stock</param>
		/// <param name="threshold">The range for the stock</param>
		public Stocks(string name, int startingValue, int maxChange, int threshold)
		{
            StockName = name;
            InitialValue = startingValue;
            CurrentValue = InitialValue;
            MaxChange = maxChange;
            Threshold = threshold;
			this._thread = new Thread(new ThreadStart(Activate));
			_thread.Start();
		}

		/// <summary>
		/// Activates the threads synchronizations
		/// </summary>
		public void Activate()
		{
			for (int i = 0; i < 25; i++)
			{
				Thread.Sleep(500); // 1/2 second
				ChangeStockValue();
			}
		}

		// delegate
		//public delegate void StockNotifications(String stockName, int currentValue, int numberChanges);
		// event
		//public event StockNotifications ProcessComplete;

		//      public void Notify(String stockName, int currentValue, int numberChanges)
		//      {
		//          OnProcessCompleted(stockName, currentValue, numberChanges);
		//      }
		//protected virtual void OnProcessCompleted(String stockName, int currentValue, int numberChanges)
		//      {
		//          // if the process is completed, then call delegate to raise the event
		//          ProcessComplete?.Invoke(stockName, currentValue, numberChanges);
		//      }

		/// <summary>
		/// Changes the stock value and also raising the event of stock value changes
		/// </summary>
		public void ChangeStockValue()
		{
			var rand = new Random();
			CurrentValue += rand.Next(1, MaxChange);
			NumChanges++;
			if ((CurrentValue - InitialValue) > Threshold)
			{ //RAISE THE EVENT
				StockEvent?.Invoke(this, new StockNotification(StockName, CurrentValue, NumChanges));
			}
		}
	}
}