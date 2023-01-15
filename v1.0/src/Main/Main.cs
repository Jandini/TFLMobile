using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Scraper;


using System.Text.RegularExpressions;
using System.IO;

namespace Janda
{
	public partial class frmMain : Form
	{


		/// <summary>
		/// We are using WebScraperThread
		/// </summary>
		private WebScraper webScrapper = null;


		/// <summary>
		/// 
		/// </summary>
		MultiplePlaces frmMultiplePlaces = null;


		/// <summary>
		/// e.g sessionID=JP08_2460801264
		/// </summary>
		private string sessionID = null;

		/// <summary>
		/// 
		/// </summary>
		private SearchForm searchForm = null;


		/// <summary>
		/// 
		/// </summary>
		private bool showSummary = false;


		/// <summary>
		/// 
		/// </summary>
		private string appPath = string.Empty;

		/// <summary>
		/// 
		/// </summary>
		public frmMain()
		{
			InitializeComponent();

			webScrapper = new WebScraperThread(this);
//			webScrapper = new WebScraper();

			webScrapper.OnStart += new ScraperObject.EventHandler(webScrapper_OnStart);
			webScrapper.OnFinish += new ScraperObject.EventHandler(webScrapper_OnFinish);
			webScrapper.OnError += new ScraperObject.EventHandler(webScrapper_OnError);
			webScrapper.OnResult += new ScraperObject.EventHandler(webScrapper_OnResult);
			webScrapper.OnConnect += new ScraperObject.EventHandler(webScrapper_OnConnect);
			webScrapper.OnReceive += new ScraperObject.EventHandler(webScrapper_OnReceive);
			webScrapper.OnResponse += new ScraperObject.EventHandler(webScrapper_OnResponse);

			searchForm = new SearchForm();
			searchForm.OnCancel += new EventHandler(searchForm_OnCancel);


			webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);

			pnlTransport.SelectAll(true);

			this.appPath = GetApplicationPath();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		void webScrapper_OnResponse(ScraperObject sender)
		{
			searchForm.StatusText = Strings.strWaitForResponse;
		}



		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// -------------------------------------------------------------------
		private string GetApplicationPath()
		{
			string result = string.Empty;

			try
			{
				Assembly assembly = Assembly.GetExecutingAssembly();

				if (assembly != null)
				{
					result = Path.GetDirectoryName(assembly.GetName().CodeBase);
				}

				if (!result.EndsWith(Path.DirectorySeparatorChar.ToString()))
				{
					result = result + Path.DirectorySeparatorChar;
				}

			}
			catch (Exception)
			{

			}

			return result;
		}

		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// -------------------------------------------------------------------
		void searchForm_OnCancel(object sender, EventArgs e)
		{
			webScrapper.Abort();

			searchForm.btnCancel.Enabled = false;

			// Make sure we will close search window
			while (webScrapper.ScraperState == ScraperState.Running)
			{
				Application.DoEvents();
			}

			if (searchForm.Visible)
			{
				searchForm.Hide();
			}

			searchForm.btnCancel.Enabled = true;
		}



		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// -------------------------------------------------------------------
		void webScrapper_OnReceive(ScraperObject sender)
		{
			searchForm.StatusText = Strings.strReceivingData;
		}



		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// -------------------------------------------------------------------
		void webScrapper_OnConnect(ScraperObject sender)
		{
			searchForm.StatusText = Strings.strConnecting;
		}




		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="resultParser"></param>
		/// -------------------------------------------------------------------
		void PreparePlaceSelector(ResultParser resultParser)
		{
			if (resultParser != null)
			{
				string[] from = resultParser.MultipleFrom;
				string[] to = resultParser.MultipleTo;

				if (from != null || to != null)
				{
					frmMultiplePlaces = new MultiplePlaces();

					frmMultiplePlaces.pnlFrom.SetValues(from);
					frmMultiplePlaces.pnlTo.SetValues(to);

					// it's used to indicate wether "from multiple" must be requested
					frmMultiplePlaces.pnlFrom.Enabled = from != null;

					if (!frmMultiplePlaces.pnlFrom.Enabled)
					{
						frmMultiplePlaces.pnlFrom.PlaceName = pnlFrom.PlaceName;
					}

					// it's used to indicate wether "to multiple" must be requested
					frmMultiplePlaces.pnlTo.Enabled = to != null;

					if (!frmMultiplePlaces.pnlTo.Enabled)
					{
						frmMultiplePlaces.pnlTo.PlaceName = pnlTo.PlaceName;
					}
				}
			}
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		private void UpdateResults(ResultParser resultParser)
		{
			try
			{
				lstResults.BeginUpdate();
				lstResults.Items.Clear();

				foreach (ResultParser.ResultItem resultItem in resultParser.Results)
				{
					ListViewItem listItem = new ListViewItem(
						new string[] { 
							resultItem.option, 
							resultItem.depart,  
							resultItem.arrive,
							resultItem.duration 
						});

					string interchanges = string.Empty;


					foreach (string interchange in resultItem.interchanges)
					{
						interchanges += interchange + " ";
					}

					listItem.SubItems.Add(interchanges);

					lstResults.Items.Add(listItem);
				}

			}
			finally
			{
				bool exists = lstResults.Items.Count > 0;

				if (exists)
				{
					lstResults.Columns[4].Width = -1;
				}

				lstResults.EndUpdate();

				btnEarliest.Enabled = exists;
				btnEarlier.Enabled = exists;
				btnLater.Enabled = exists;
				btnLatest.Enabled = exists;
			}

			tabMain.SelectedIndex = 2;
			
			// this.Refresh();
			// don't focus here...

		}

		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// -------------------------------------------------------------------
		void webScrapper_OnResult(ScraperObject sender)
		{
			// Create parser for new results
			ResultParser resultParser = new ResultParser(sender.Result as string);

			searchForm.StatusText = Strings.strProcessingData;

			// Parse results
			resultParser.Parse();


			if (this.sessionID == null)
			{
				// Remember session id for result navigation (latest, erliest)
				// only if session is required
				this.sessionID = resultParser.SessionID;

				// MessageBox.Show(sessionID.ToString(), "New SessionID");
			}

			if (!showSummary)
			{
				if (resultParser.MultiplePlaces)
				{
					PreparePlaceSelector(resultParser);
				}
				else
				{
					UpdateResults(resultParser);
				}
			}
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// -------------------------------------------------------------------
		void webScrapper_OnError(ScraperObject sender)
		{
			MessageBox.Show(sender.Exception.Message, "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Hand,
				MessageBoxDefaultButton.Button1);
		}




		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		private void ShowMultiplePlaces()
		{
			if (frmMultiplePlaces.ShowDialog() == DialogResult.OK)
			{
				string to = string.Empty;
				string from = string.Empty;

				if (frmMultiplePlaces.pnlFrom.Enabled)
				{
					from = string.Format(Strings.strMultipleFromFormat,
						frmMultiplePlaces.pnlFrom.SelectedValue,
						pnlFrom.PlaceType);


					// Update from panel
					pnlFrom.PlaceName = frmMultiplePlaces.pnlFrom.Text;

				}

				if (frmMultiplePlaces.pnlTo.Enabled)
				{
					to = string.Format(Strings.strMultipleToFormat,
						frmMultiplePlaces.pnlTo.SelectedValue,
						pnlTo.PlaceType);

					// Update from panel
					pnlTo.PlaceName = frmMultiplePlaces.pnlTo.Text;

				}

				string multiplePlaces = string.Format(Strings.urlMultipleContinueFormat,
					this.sessionID, from, to);

				// MessageBox.Show(sessionID.ToString(), "Using SessionID");

				webScrapper.RequestUrl = multiplePlaces;			

				webScrapper.Run();
			}
		}


		/*void FocusTabControl()
		{
			switch (tabMain.SelectedIndex)
			{
				case 2:
					lstResults.Focus();
					break;

				case 3:
					webBrowser.Focus();
					break;
			}
		}*/

		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// -------------------------------------------------------------------
		void webScrapper_OnFinish(ScraperObject sender)
		{

			if (this.showSummary)
			{
				this.showSummary = false;

				// prepare tab first
				tabMain.SelectedIndex = 3;

				searchForm.StatusText = Strings.strProcessingData;

				//Match match = Regex.Match(sender.Result as string, "<div id=\"journey-summary\">(.*?)<table(.*?)</table>", RegexOptions.Singleline);

				string result = sender.Result as string;

				if (result != null && result != string.Empty)
				{
					Match match = Regex.Match(result, "(?<=(<h3>Journey Summary</h3>))(.*?)<table(.*?)</table>", RegexOptions.Singleline);

					if (match != null && match.Value != string.Empty)
					{
						// Add default style
						string webContent = "<html><head><style type=\"text/css\"> .routedetails { font-size: 8pt; font-family: Tahoma; } table { font-size: 8pt; font-family: Tahoma; } body { font-size: 8pt; font-family: Tahoma;} .routealert_green { color: green; } .routealert_red { color: red; } .routealert_blue { color: blue; } li {list-style: none; padding: 0; margin: 0;} ul {margin: 5px 3px 10px 5px; } </style></head><body>";

						webContent += match.Value;

						// webContent = Regex.Replace(webContent, "<a\\b[^>]*>(.*?)</a>", string.Empty, RegexOptions.Singleline);
						// leave link body instead of removing whole link
						webContent = Regex.Replace(webContent, "<a\\b[^>]*>", string.Empty, RegexOptions.Singleline);
						webContent = Regex.Replace(webContent, "</a\\b[^>]*>", string.Empty, RegexOptions.Singleline);
						webContent = webContent.Replace("Please click here to find out more information about these works.", string.Empty);


						webContent = Regex.Replace(webContent, "<td class=\"jpmapdetails\"(.*?)</td>", string.Empty, RegexOptions.Singleline);
						// webContent = Regex.Replace(webContent, "<img\\b[^>]*>(.*?)", string.Empty, RegexOptions.Singleline);

						string path = "file:" + this.appPath.Replace("\\", "/") + "assets/";

						//webContent = Regex.Replace(webContent, "assets/images/", path, RegexOptions.Singleline);
						//webContent = Regex.Replace(webContent, "mdv/images/", path, RegexOptions.Singleline);

						webContent = webContent.Replace("assets/images/", path);
						webContent = webContent.Replace("mdv/images/", path);

						webContent += "</body></html>";

						searchForm.StatusText = Strings.strLoadingData;
						
												
						webBrowser.DocumentText = webContent;

					}
					else
					{
						try
						{
							//	using (StreamWriter sw = File.CreateText("noresults.txt"))
							//	{
							//		sw.Write(sender.Result as string);
							//	}						
							Clipboard.SetDataObject(sender.Result as string);
						}
						catch
						{

						}

						webBrowser.DocumentText = Strings.strSessionExpired;
					}
				}
			}
			else
			{
				searchForm.Hide();

				// FocusTabControl();

				if (frmMultiplePlaces != null)
				{
					ShowMultiplePlaces();
					frmMultiplePlaces = null;
				}
			}
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// -------------------------------------------------------------------
		void webBrowser_DocumentCompleted(object sender, 
			WebBrowserDocumentCompletedEventArgs e)
		{
			searchForm.Hide();			
		}


		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// -------------------------------------------------------------------
		void webScrapper_OnStart(ScraperObject sender)
		{
			searchForm.Show();
			searchForm.Refresh();
		}




		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// --------------------------------------------------------------------
		private void chkSelectAll_Click(object sender, EventArgs e)
		{
			if (chkSelectAll.CheckState == CheckState.Checked)
			{
				pnlTransport.SelectAll(true);
			}

			if (chkSelectAll.CheckState == CheckState.Indeterminate)
			{
				chkSelectAll.CheckState = CheckState.Unchecked;
			}

			if (chkSelectAll.CheckState == CheckState.Unchecked)
			{
				pnlTransport.SelectAll(false);
			}
		}

		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="state"></param>
		/// --------------------------------------------------------------------
		private void pnlTransport_OnSelectionChanged(CheckState state)
		{
			chkSelectAll.CheckState = state;
		}


		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// --------------------------------------------------------------------
		private void tabTransport_Resize(object sender, EventArgs e)
		{
			// If landscape layout
			if (tabTransport.Width > 240)
			{
				btnSearchTransport.Top = 150;
				chkSelectAll.Top = 150;
			}
			else
			{
				btnSearchTransport.Top = 220;
				chkSelectAll.Top = 220;
			}
		}



		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fromName"></param>
		/// <param name="fromType"></param>
		/// <param name="toName"></param>
		/// <param name="toType"></param>
		/// --------------------------------------------------------------------
		protected void RequestLeaveNow(string fromName, string fromType,
			string toName, string toType)
		{
			// New session id is required
			this.sessionID = null;

			webScrapper.RequestUrl = string.Format(Strings.urlLeaveNowFormat,
				fromName, fromType, toName, toType);

			webScrapper.Run();
		}

		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// --------------------------------------------------------------------
		private void btnLeaveNow_Click(object sender, EventArgs e)
		{
			RequestLeaveNow(pnlFrom.PlaceName, pnlFrom.PlaceType,
				pnlTo.PlaceName, pnlTo.PlaceType);
		}



		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// --------------------------------------------------------------------
		private void btnSearchTransport_Click(object sender, EventArgs e)
		{
			// New session id is required
			this.sessionID = null;

			webScrapper.RequestUrl = string.Format(Strings.urlSearchFormat,
				pnlFrom.PlaceName, pnlFrom.PlaceType,
				pnlTo.PlaceName, pnlTo.PlaceType, pnlTransport.RequestParameters);

			webScrapper.Run();
		}


		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// --------------------------------------------------------------------
		private void chkReverse_CheckStateChanged(object sender, EventArgs e)
		{
			string place = pnlTo.PlaceName;
			string type = pnlTo.PlaceType;

			pnlTo.PlaceName = pnlFrom.PlaceName;
			pnlTo.PlaceType = pnlFrom.PlaceType;

			pnlFrom.PlaceName = place;
			pnlFrom.PlaceType = type;			
		}



		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// --------------------------------------------------------------------
		private void btnEarliest_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;

			if (button != null)
			{
				// MessageBox.Show(sessionID.ToString(), "Using SessionID");

				string urlTrip = string.Format(Strings.urlTripFormat,
					this.sessionID, button.Tag);


				webScrapper.RequestUrl = urlTrip;

				webScrapper.Run();
			}
		}


		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// --------------------------------------------------------------------
		private void btnSearchRoute_Click(object sender, EventArgs e)
		{

		}



		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// --------------------------------------------------------------------
		private void tabDetails_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black),
				webBrowser.Left - 1,
				webBrowser.Top - 1,
				webBrowser.Width + 1,
				webBrowser.Height + 1);
		}


		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// --------------------------------------------------------------------
		protected void RequestSummary(int index)
		{
			showSummary = true;

			webScrapper.RequestUrl = string.Format(Strings.urlSummaryFormat,
				this.sessionID, index);

			webScrapper.Run();
		}


		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// --------------------------------------------------------------------
		private void lstResults_ItemActivate(object sender, EventArgs e)
		{
			ListViewItem item = lstResults.FocusedItem;

			if (item != null)
			{
				RequestSummary(item.Index + 1);
			}
		}



/*		/// --------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		/// --------------------------------------------------------------------
		protected override void OnLoad(EventArgs e)
		{			
			base.OnLoad(e);

			pnlFrom.PlaceName = "Kingston";
			pnlTo.PlaceName = "Bank";

			btnLeaveNow_Click(btnLeaveNow, new EventArgs());
		}*/
	}
}