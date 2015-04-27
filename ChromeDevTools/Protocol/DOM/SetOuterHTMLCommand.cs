using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets node HTML markup, returns new node id.
	/// </summary>
	[Command(ProtocolName.DOM.SetOuterHTML)]
	public class SetOuterHTMLCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to set markup for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Outer HTML markup to set.
		/// </summary>
		public string OuterHTML { get; set; }
	}
}
