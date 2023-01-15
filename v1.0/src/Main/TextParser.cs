using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Janda
{
	abstract class TextParser : ParserObject
	{

		/// <summary>
		/// 
		/// </summary>
		protected string text = null;


		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		public TextParser(string text)
		{
			this.text = text;
		}



		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// <param name="exression"></param>
		/// <param name="content"></param>
		/// -------------------------------------------------------------------
		private void ReplaceExpression(string exression, string value, ref string content)
		{
			Regex exp = new Regex(exression, RegexOptions.IgnoreCase);

			MatchCollection matchList = exp.Matches(content);

			for (int i = matchList.Count - 1; i >= 0; i--)
			{
				Match match = matchList[i];

				content = content.Remove(match.Index, match.Length);

				if (value != null && value != string.Empty)
				{
					content = content.Insert(match.Index, value);
				}
			}
		}



		/// -------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		/// -------------------------------------------------------------------
		public string Text
		{
			get
			{
				return this.text;
			}

			set
			{
				this.text = value;
			}
		}
	}
}
