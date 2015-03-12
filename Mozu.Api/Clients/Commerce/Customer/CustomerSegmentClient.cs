
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

namespace Mozu.Api.Clients.Commerce.Customer
{
	/// <summary>
	/// Use the Customer Segments resource to manage the segments that enable a client to manage groups of customers and target discounts for these segments. After a customer segment is defined, you can associate any number of customer accounts with it.
	/// </summary>
	public partial class CustomerSegmentClient 	{
		
		/// <summary>
		/// Retrieves a list of defined customer segments according to any filter and sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerSegmentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSegments( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var customerSegmentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerSegmentCollection> GetSegmentsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.GetSegmentsUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerSegmentCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the customer segment specified in the request. This operation does not return a list of the customer accounts associated with the segment.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSegment( id,  responseFields);
		///   var customerSegmentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> GetSegmentClient(int id, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.GetSegmentUrl(id, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new customer segments. New customer segments do not have any associated customer accounts.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="segment">The Customer Segment object includes properties of a defined customer segment used to group customer accounts.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddSegment( segment,  responseFields);
		///   var customerSegmentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> AddSegmentClient(Mozu.Api.Contracts.Customer.CustomerSegment segment, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.AddSegmentUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerSegment>(segment);
			return mozuClient;

		}

		/// <summary>
		/// Adds one or more customer accounts to a defined customer segment.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="accountIds">List of customer account IDs to add to the customer segment specified in the request.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddSegmentAccounts( accountIds,  id);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient AddSegmentAccountsClient(List<int> accountIds, int id)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.AddSegmentAccountsUrl(id);
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(accountIds);
			return mozuClient;

		}

		/// <summary>
		/// Updates the details of the customer segment specified in the request.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="segment">The Customer Segment object includes properties of a defined customer segment used to group customer accounts.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerSegment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateSegment( segment,  id,  responseFields);
		///   var customerSegmentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment> UpdateSegmentClient(Mozu.Api.Contracts.Customer.CustomerSegment segment, int id, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.UpdateSegmentUrl(id, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerSegment>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerSegment>(segment);
			return mozuClient;

		}

		/// <summary>
		/// Deletes a customer segment specified by its unique identifier. Deleting a segment removes any customer account associations, but does not delete the customer account itself.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteSegment( id);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteSegmentClient(int id)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.DeleteSegmentUrl(id);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Removes single account from a segment.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveSegmentAccount( id,  accountId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient RemoveSegmentAccountClient(int id, int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerSegmentUrl.RemoveSegmentAccountUrl(id, accountId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}

