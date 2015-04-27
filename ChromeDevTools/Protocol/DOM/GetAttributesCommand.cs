using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns attributes for the specified node.
	/// </summary>
	[Command(ProtocolName.DOM.GetAttributes)]
	public class GetAttributesCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to retrieve attibutes for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
