
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

namespace Mozu.Api.Clients.Commerce.Customer.Credits
{
	/// <summary>
	/// Use the Customer Credit Audit Entries subresource to retrieve entries logged in the audit report of a store credit or gift card applied to a customer account. The system creates a new audit entry when the credit is created, deleted, activated, or deactivated. The system then creates a new audit entry each time the credit is updated or redeemed in a transaction.
	/// </summary>
	public partial class CreditAuditEntryClient 	{
		
		/// <summary>
		/// Retrieves the list of audit entries for the credit, according to any filter or sort criteria specified in the request.
		/// </summary>
		/// <param name="code">User-defined code of the credit for which to retrieve audit entries.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Credit.CreditAuditEntryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAuditEntries( code,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var creditAuditEntryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditAuditEntryCollection> GetAuditEntriesClient(string code, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Credits.CreditAuditEntryUrl.GetAuditEntriesUrl(code, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditAuditEntryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


