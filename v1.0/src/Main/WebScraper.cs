using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;


using System.Windows.Forms;

namespace Scraper
{

	class WebScraper : ScraperObject
	{
		/// <summary>
		/// Request Uniform Resource Identifier object
		/// </summary>
		private Uri requestUri = null;

		/// <summary>
		/// Request Uniform Resource Locator string
		/// </summary>
		private string requestUrl = string.Empty;


		/// <summary>
		/// 
		/// </summary>
		private string postRequest = string.Empty;


		/// <summary>
		/// 
		/// </summary>
		private HttpWebRequest webRequest = null;


		/// <summary>
		/// 
		/// </summary>
		private HttpWebResponse webResponse = null;


		/// <summary>
		/// 
		/// </summary>
		public event EventHandler OnConnect = null;


		/// <summary>
		/// 
		/// </summary>
		public event EventHandler OnReceive = null;


		/// <summary>
		/// 
		/// </summary>
		public event EventHandler OnResponse = null;


		/// <summary>
		/// default WebRequest default timeout
		/// </summary>
		private int requestTimeout = 100000;


		/// <summary>
		/// by default we are using POST method
		/// </summary>
		private string requestMethod = "POST";


		/// <summary>
		/// 
		/// </summary>
		private string requestContentType = "application/x-www-form-urlencoded";


		/// <summary>
		/// 
		/// </summary>
		private string requestUserAgent = "Mozilla/4.0 (compatible; MSIE 5.5; Windows NT 5.0)";


		/// -------------------------------------------------------------------
		/// <summary>
		/// Class constructor without parameters
		/// </summary>
		/// -------------------------------------------------------------------
		public WebScraper()
		{

		}

		/// -------------------------------------------------------------------
		/// <summary>
		/// Class constructor
		/// </summary>
		/// <param name="requestUrl"></param>
		/// -------------------------------------------------------------------
		public WebScraper(string requestUrl)
		{
			RequestUrl = requestUrl;
		}




		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		protected virtual bool DoConnect()
		{
			CallEvent(OnConnect);

			bool result = false;

			try
			{
				this.webRequest = (HttpWebRequest)WebRequest.Create(requestUri);

				byte[] data = Encoding.ASCII.GetBytes(this.postRequest);

				this.webRequest.Timeout = this.requestTimeout;
				this.webRequest.UserAgent = this.requestUserAgent;
				
				this.webRequest.Method = this.requestMethod;
				this.webRequest.ContentType = this.requestContentType;
				this.webRequest.ContentLength = data.Length;				

				using (Stream requestStream = this.webRequest.GetRequestStream())
				{
					requestStream.Write(data, 0, data.Length);
				}
								
				CallEvent(OnResponse);

				this.webResponse = (HttpWebResponse)this.webRequest.GetResponse();
				
				result = this.webResponse != null;
			}
			catch (Exception ex)
			{
				HandleError(ex);
			}

			return result;
		}



		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		protected virtual bool DoReceive()
		{
			CallEvent(OnReceive);

			bool result = false;

			try
			{
				base.result = string.Empty;

				using (Stream stream = this.webResponse.GetResponseStream())
				{
					if (stream != null)
					{
						using (StreamReader reader = new StreamReader(stream))
						{
							base.result = reader.ReadToEnd();
						}
					}
				}

				result = true;
			}
			catch (Exception ex)
			{
				HandleError(ex);
			}

			return result;
		}



		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		protected virtual void DoClose()
		{
			try
			{
				if (webResponse != null)
				{
					webResponse.Close();
				}

				webResponse = null;
			}
			catch (Exception ex)
			{
				HandleError(ex);
			}
		}

		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		protected override void DoScrape()
		{
			try
			{
				if (DoConnect())
				{
					if (DoReceive())
					{
						DoResult();
					}

					DoClose();
				}

				DoFinish();
			}
			catch (Exception ex)
			{
				HandleError(ex);
			}
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		public virtual void Abort()
		{
			if (scraperState == ScraperState.Running)
			{
				wasAborted = true;

				if (webRequest != null)
				{
					webRequest.Abort();
					webRequest = null;
				}

				DoClose();
				DoFinish();
			}
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// Request Uniform Resource Identifier
		/// </summary>
		/// -------------------------------------------------------------------
		public Uri RequestUri
		{
			get
			{
				return this.requestUri;
			}

			set
			{
				this.requestUri = value;
			}
		}



		/// -------------------------------------------------------------------
		/// <summary>
		/// Request Uniform Resource Locator
		/// </summary>
		/// -------------------------------------------------------------------
		public string RequestUrl
		{
			get
			{
				return this.requestUrl;
			}

			set
			{
				string[] values = value.Split('?');

				if (values.Length > 0)
				{
					this.requestUrl = values[0];
					this.requestUri = new Uri(this.requestUrl);

					if (values.Length > 1)
					{
						this.postRequest = values[1];
					}
				}
			}
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		public string PostRequest
		{
			get
			{
				return this.postRequest;
			}

			set
			{
				this.postRequest = value;
			}
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		public string RequestResult
		{
			get
			{
				string result = string.Empty;

				if (base.result != null)
				{
					result = base.result as string;
				}

				return result;
			}
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		public int RequestTimeout
		{
			get
			{
				return this.requestTimeout;
			}
			set
			{
				this.requestTimeout = value;
			}
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		public string RequestContentType
		{
			get
			{
				return this.requestContentType;
			}

			set
			{
				this.requestContentType = value;
			}
		}
	}
}
