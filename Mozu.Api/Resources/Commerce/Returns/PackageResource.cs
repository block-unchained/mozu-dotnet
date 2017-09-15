
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

namespace Mozu.Api.Resources.Commerce.Returns
{
	/// <summary>
	/// Use the Return Packages subresource to manage physical packages used to ship return replacement items.
	/// </summary>
	public partial class PackageResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PackageResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PackageResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PackageResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// Retrieves the package label image supplied by the carrier for a return replacement.
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package for which to retrieve the label.</param>
		/// <param name="returnAsBase64Png"></param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package label to retrieve.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var package = new Package();
		///   var stream = await package.GetPackageLabelAsync( returnId,  packageId,  returnAsBase64Png);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> GetPackageLabelAsync(string returnId, string packageId, bool? returnAsBase64Png =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Returns.PackageClient.GetPackageLabelClient( returnId,  packageId,  returnAsBase64Png);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the details of a package of return replacement items.
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var package = new Package();
		///   var package = await package.GetPackageAsync( returnId,  packageId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> GetPackageAsync(string returnId, string packageId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> response;
			var client = Mozu.Api.Clients.Commerce.Returns.PackageClient.GetPackageClient( returnId,  packageId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Creates a new physical package of return replacement items.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId">Unique identifier of the return for which to create a replacement package.</param>
		/// <param name="package">Properties of the physical package for a return replacement.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var package = new Package();
		///   var package = await package.CreatePackageAsync( pkg,  returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> CreatePackageAsync(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package pkg, string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> response;
			var client = Mozu.Api.Clients.Commerce.Returns.PackageClient.CreatePackageClient( pkg,  returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates one or more properties of a package associated with a return replacement.
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package to update.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package to update.</param>
		/// <param name="package">Properties of the return replacement package to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var package = new Package();
		///   var package = await package.UpdatePackageAsync( pkg,  returnId,  packageId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> UpdatePackageAsync(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package pkg, string returnId, string packageId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> response;
			var client = Mozu.Api.Clients.Commerce.Returns.PackageClient.UpdatePackageClient( pkg,  returnId,  packageId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes a package associated with a return replacement.
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package to delete.</param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var package = new Package();
		///   await package.DeletePackageAsync( returnId,  packageId);
		/// </code>
		/// </example>
		public virtual async Task DeletePackageAsync(string returnId, string packageId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Returns.PackageClient.DeletePackageClient( returnId,  packageId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


