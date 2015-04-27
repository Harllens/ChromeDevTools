using ChromeDevTools;

namespace ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to open.
	/// </summary>
	[Event(ProtocolName.Page.JavascriptDialogOpening)]
	public class JavascriptDialogOpeningEvent
	{
		/// <summary>
		/// Gets or sets Message that will be displayed by the dialog.
		/// </summary>
		public string Message { get; set; }
	}
}
