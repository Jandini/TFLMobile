using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Scraper
{
	class WebScraperThread : WebScraper
	{
		/// <summary>
		/// 
		/// </summary>
		private Thread thread = null;

		/// <summary>
		/// 
		/// </summary>
		private Control parent = null;

		/// <summary>
		/// 
		/// </summary>
		// private bool aborted = false;


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		/// -------------------------------------------------------------------
		public WebScraperThread(Control parent)
		{
			this.parent = parent;
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="requestUrl"></param>
		/// -------------------------------------------------------------------
		public WebScraperThread(string requestUrl)
			: base(requestUrl)
		{

		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		public WebScraperThread()
		{

		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		protected override void Execute()
		{
			// this.aborted = false;
			thread = new Thread(new ThreadStart(this.DoScrape));

			thread.Priority = ThreadPriority.Normal;
			thread.Start();
		}



		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// -------------------------------------------------------------------
		public override void Abort()
		{
			if (scraperState == ScraperState.Running)
			{
				thread.Abort();
				base.Abort();				
			}
		}



		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ex"></param>
		/// -------------------------------------------------------------------
		protected override void HandleError(Exception ex)
		{
			if (!(ex is ThreadAbortException))
			{
				base.HandleError(ex);
			}
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// This method is responsible for invoking method if the events
		/// are using access to Windows.Forms controls.
		/// </summary>
		/// <param name="eventHandler"></param>
		/// -------------------------------------------------------------------
		protected override void CallEvent(EventHandler eventHandler)
		{
			// Check first if invoke is required
			if (parent != null && parent.InvokeRequired)
			{
				if (eventHandler != null)
				{
					// If invoke is required we must use BeginInvoke here
					parent.BeginInvoke(eventHandler, new object[] { this });
				}				
			}
			else
			{
				base.CallEvent(eventHandler);
			}
		}
	}
}
