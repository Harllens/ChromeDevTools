using ChromeDevTools;

namespace ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when EventSource message is received.
	/// </summary>
	[Event(ProtocolName.Network.EventSourceMessageReceived)]
	public class EventSourceMessageReceivedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Message type.
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// Gets or sets Message identifier.
		/// </summary>
		public string EventId { get; set; }
		/// <summary>
		/// Gets or sets Message content.
		/// </summary>
		public string Data { get; set; }
	}
}
