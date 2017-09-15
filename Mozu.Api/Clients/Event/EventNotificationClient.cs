
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace Mozu.Api.Clients.Event
{
	/// <summary>
	/// Events are notifications Mozu publishes to the application when a create, read, update, or delete operation is performed. If the application subscribes to the event, you can use the Events resource to query for recent events Mozu published to your application or events that were not published successfully.
	/// </summary>
	public partial class EventNotificationClient 	{
		
		/// <summary>
		/// Retrieves a list of events.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Event.EventCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEvents( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var eventCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Event.EventCollection> GetEventsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Event.EventNotificationUrl.GetEventsUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Event.EventCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves an event by providing the event ID.
		/// </summary>
		/// <param name="eventId">The unique identifier of the event being retrieved. An event is a notification about a create, read, update, or delete on an order, product, discount or category.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Event.Event"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEvent( eventId,  responseFields);
		///   var eventClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Event.Event> GetEventClient(string eventId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Event.EventNotificationUrl.GetEventUrl(eventId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Event.Event>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


