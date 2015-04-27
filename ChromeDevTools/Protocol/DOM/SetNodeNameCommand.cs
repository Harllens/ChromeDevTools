using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets node name for a node with given id.
	/// </summary>
	[Command(ProtocolName.DOM.SetNodeName)]
	public class SetNodeNameCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to set name for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets New node's name.
		/// </summary>
		public string Name { get; set; }
	}
}
