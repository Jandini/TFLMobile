using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Janda
{
	abstract class HtmlParser : TextParser
	{


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="htmlText"></param>
		/// ---------------------------------------------------------------------
		public HtmlParser(string htmlText)
			: base(htmlText)
		{

		}



		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="tag"></param>
		/// <param name="content"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		/// ---------------------------------------------------------------------
		protected MatchCollection MatchTags(string tag, string content, 
			RegexOptions options)
		{
			string pattern = "<" + tag + "\\b[^>]*>(.*?)</" + tag + ">";

			Regex expression = new Regex(pattern, options);

			return expression.Matches(content);
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="content"></param>
		/// <param name="attribute"></param>
		/// <returns></returns>
		protected string GetAttributeValue(string content, string attribute)
		{
			//alt=("[^"\r\n]*")
			string pattern = "(" + attribute + "=\"(.*?)\")*(\"(.*?)\")";
			string result = string.Empty;

			Regex expression = new Regex(pattern, RegexOptions.IgnoreCase);
			MatchCollection match = expression.Matches(content);

			if (match.Count > 0)
			{
				result = match[0].Value.Trim('"');
			}

			return result;
		}



		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="html"></param>
		/// <returns></returns>
		/// ---------------------------------------------------------------------
		protected string ReplaceHtmlCodes(string html)
		{
			string result = html.Replace("&amp;", "&");

			


			return result;
		}


		/// ---------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="tag"></param>
		/// <returns></returns>
		/// ---------------------------------------------------------------------
		protected string GetTagContent(string tag)
		{
			string pattern = ">(.*)<";
			string result = string.Empty;

			Regex expression = new Regex(pattern, RegexOptions.IgnoreCase);
			MatchCollection match = expression.Matches(tag);

			if (match.Count > 0)
			{
				result = match[0].Value.Trim(new char[] { '>', '<' });
			}

			return result;

			
		}

//    <div     id = "blah" alt=" man
//             this is ugly html "     >     fire this guy... </div> 

//		Here's a code snippet that uses this expression to match the above html. 
//		Regex regex = new Regex(@"</?\w+((\s+\w+(\s*=\s*(?:"".*?""|'.*?'|[^'"">\s]+))?)+\s*|\s*)/?>", RegexOptions.Singleline);
	}
}
