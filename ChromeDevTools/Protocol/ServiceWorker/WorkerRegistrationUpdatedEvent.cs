using ChromeDevTools;

namespace ChromeDevTools.Protocol.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerRegistrationUpdated)]
	public class WorkerRegistrationUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Registrations
		/// </summary>
		public ServiceWorkerRegistration[] Registrations { get; set; }
	}
}
