
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition.Attributes
{
	/// <summary>
	/// 
	/// </summary>
	public partial class AttributeLocalizedContentResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AttributeLocalizedContentResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public AttributeLocalizedContentResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new AttributeLocalizedContentResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attributelocalizedcontent = new AttributeLocalizedContent();
		///   var attributeLocalizedContent = await attributelocalizedcontent.GetAttributeLocalizedContentsAsync( attributeFQN);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>> GetAttributeLocalizedContentsAsync(string attributeFQN, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentClient.GetAttributeLocalizedContentsClient( attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode">Language used for the entity. Currently, only "en-US" is supported.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributelocalizedcontent = new AttributeLocalizedContent();
		///   var attributeLocalizedContent = await attributelocalizedcontent.GetAttributeLocalizedContentAsync( attributeFQN,  localeCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> GetAttributeLocalizedContentAsync(string attributeFQN, string localeCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentClient.GetAttributeLocalizedContentClient( attributeFQN,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributelocalizedcontent = new AttributeLocalizedContent();
		///   var attributeLocalizedContent = await attributelocalizedcontent.AddLocalizedContentAsync( localizedContent,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> AddLocalizedContentAsync(Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent localizedContent, string attributeFQN, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentClient.AddLocalizedContentClient( localizedContent,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attributelocalizedcontent = new AttributeLocalizedContent();
		///   var attributeLocalizedContent = await attributelocalizedcontent.UpdateLocalizedContentsAsync( localizedContent,  attributeFQN);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>> UpdateLocalizedContentsAsync(List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> localizedContent, string attributeFQN, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentClient.UpdateLocalizedContentsClient( localizedContent,  attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode">Language used for the entity. Currently, only "en-US" is supported.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributelocalizedcontent = new AttributeLocalizedContent();
		///   var attributeLocalizedContent = await attributelocalizedcontent.UpdateLocalizedContentAsync( localizedContent,  attributeFQN,  localeCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> UpdateLocalizedContentAsync(Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent localizedContent, string attributeFQN, string localeCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentClient.UpdateLocalizedContentClient( localizedContent,  attributeFQN,  localeCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode">Language used for the entity. Currently, only "en-US" is supported.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var attributelocalizedcontent = new AttributeLocalizedContent();
		///   await attributelocalizedcontent.DeleteLocalizedContentAsync( attributeFQN,  localeCode);
		/// </code>
		/// </example>
		public virtual async Task DeleteLocalizedContentAsync(string attributeFQN, string localeCode, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentClient.DeleteLocalizedContentClient( attributeFQN,  localeCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


