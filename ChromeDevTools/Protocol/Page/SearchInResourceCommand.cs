using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Searches for given string in resource content.
	/// </summary>
	[Command(ProtocolName.Page.SearchInResource)]
	public class SearchInResourceCommand
	{
		/// <summary>
		/// Gets or sets Frame id for resource to search in.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets URL of the resource to search in.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets String to search for.
		/// </summary>
		public string Query { get; set; }
		/// <summary>
		/// Gets or sets If true, search is case sensitive.
		/// </summary>
		public bool CaseSensitive { get; set; }
		/// <summary>
		/// Gets or sets If true, treats string parameter as regex.
		/// </summary>
		public bool IsRegex { get; set; }
	}
}
