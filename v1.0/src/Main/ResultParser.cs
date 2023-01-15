using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Janda
{

	class ResultParser : HtmlParser
	{

		/// <summary>
		/// Result item
		/// </summary>
		public class ResultItem
		{
			public string option = string.Empty;
			public string depart = string.Empty;
			public string arrive = string.Empty;
			public string duration = string.Empty;
			public string[] interchanges = null;			
		}
		

		/// <summary>
		/// List of result items
		/// </summary>
		private List<ResultItem> resultList = new List<ResultItem>();


		/// <summary>
		/// recived session id e.g sessionID=JP09_2414425217
		/// </summary>
		private string sessionID = string.Empty;


		/// <summary>
		/// This value will be filled when multiple From options will be given
		/// </summary>
		private string[] multipleFrom = null;


		/// <summary>
		/// This value will be filled when multiple To options will be given
		/// </summary>
		private string[] multipleTo = null;


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="result"></param>
		/// ---------------------------------------------------------------------
		public ResultParser(string result)
			: base(result)
		{

		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="content"></param>
		/// <param name="item"></param>
		/// ---------------------------------------------------------------------
		private void ParseInterchanges(string content, ref ResultItem item)
		{

			// find any alt="..."
			const string interchangePattern = "(?<=alt=)(\"[^\"\\r\\n]*\")";

			Regex interchangeExpression = 
				new Regex(interchangePattern, RegexOptions.IgnoreCase);

			MatchCollection interchangeList = interchangeExpression.Matches(content);
			
			item.interchanges = new string[interchangeList.Count];

			for (int i = 0; i < interchangeList.Count; i++)
			{
				item.interchanges[i] = interchangeList[i].Value.Trim('"');
			}
		}



		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		/// <param name="item"></param>
		/// ---------------------------------------------------------------------
		private void ParseItem(string text, ref ResultItem item)
		{
			string attribute = GetAttributeValue(text, "class");
			string content = GetTagContent(text);

			switch (attribute)
			{
				case "option":
					item.option = content;
					break;

				case "depart":
					item.depart = content;
					break;

				case "arrive":
					item.arrive = content;
					break;

				case "duration":
					item.duration = content;
					break;

				case "interchanges":
					ParseInterchanges(content, ref item);
					break;
	
			}
			
			
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// Parse Journey Options and prepare result list
		/// </summary>
		/// ---------------------------------------------------------------------
		private void ParseOptions()
		{
			// this one didn't include the last option
			//	const string optionsPattern = "<td class=\"option\">(.*?)<th class=\"viewheader\">";
			const string optionsPattern = "<td class=\"option\">(.*?)</td><td>";

			Regex optionsExpression = new Regex(optionsPattern, RegexOptions.IgnoreCase);
			MatchCollection optionsList = optionsExpression.Matches(text);

			foreach (Match option in optionsList)
			{
				// Create new result item
				ResultItem item = new ResultItem();

				const string columnsPattern = "<td\\b[^>]*>(.*?)</td>";

				Regex columnsExpression = new Regex(columnsPattern, 
					RegexOptions.IgnoreCase);

				MatchCollection columnsList = columnsExpression.Matches(option.Value);

				foreach (Match column in columnsList)
				{
					ParseItem(column.Value, ref item);
				}

				resultList.Add(item);
			}
		}






		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="array"></param>
		/// ---------------------------------------------------------------------
		private void ParsePlace(string options, ref string[] array)
		{
			MatchCollection optionsList = MatchTags("option", options,
									RegexOptions.IgnoreCase | RegexOptions.Singleline);

			array = new string[optionsList.Count];

			for (int i = 0; i < optionsList.Count; i++)
			{
				string content = optionsList[i].Value;

				string value = GetAttributeValue(content, "value");
				string name = GetTagContent(content);

				array[i] = ReplaceHtmlCodes(name) + "|" + value;
			}					
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="multipleList"></param>
		/// ---------------------------------------------------------------------
		private void ParseMultiple(MatchCollection multipleList)
		{
			foreach (Match match in multipleList)
			{
				string value = match.Value;

				if (GetAttributeValue(value, "id") == "from-multiple")
				{
					ParsePlace(value, ref this.multipleFrom);
				}


				if (GetAttributeValue(value, "id") == "to-multiple")
				{
					ParsePlace(value, ref this.multipleTo);
				}
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public override void Parse()
		{			
			Match sessionMatch = Regex.Match(text, "sessionID=\\w+(?=&)");

			if (sessionMatch != null)
			{
				this.sessionID = sessionMatch.Value;

				if (this.sessionID == "sessionID=0")
				{
					sessionMatch = Regex.Match(text, "(?<=\"sessionID\"\\s*value\\s*=\\s*\")([^\"]*)", 
						RegexOptions.Singleline);

					if (sessionMatch != null)
					{
						this.sessionID = "sessionID=" + sessionMatch.Value;
					}
				}

			}


			// Check if there are any multiple from/to options. Serach for <fieldset> tags
			MatchCollection multipleList = MatchTags("fieldset", text, 
				RegexOptions.IgnoreCase | RegexOptions.Singleline); 

			if (multipleList.Count > 0)
			{
				ParseMultiple(multipleList);
			}
			else
			{
				ParseOptions();
			}
		}




		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public List<ResultItem> Results
		{
			get
			{
				return this.resultList;
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public string SessionID
		{
			get
			{
				return this.sessionID;
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public string[] MultipleFrom
		{

			get
			{
				return this.multipleFrom;
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public string[] MultipleTo
		{

			get
			{
				return this.multipleTo;
			}
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// ---------------------------------------------------------------------
		public bool MultiplePlaces
		{
			get
			{
				return this.multipleTo != null || this.multipleFrom != null;
			}
		}
	}
}
