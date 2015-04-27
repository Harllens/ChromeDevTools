using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular operation with DOM.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetDOMBreakpoint)]
	public class SetDOMBreakpointCommandResponse
	{
	}
}
