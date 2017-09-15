
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

namespace Mozu.Api.Resources.Content.Documentlists
{
	/// <summary>
	/// Use the document tree subresource to retrieve documents and manage content within the document hierarchy.
	/// </summary>
	public partial class DocumentTreeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public DocumentTreeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public DocumentTreeResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new DocumentTreeResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public DocumentTreeResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				

		/// <summary>
		/// Retrieve the content associated with the document, such as a product image or PDF specifications file.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var stream = await documenttree.GetTreeDocumentContentAsync(_dataViewMode,  documentListName,  documentName);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> GetTreeDocumentContentAsync(string documentListName, string documentName, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.GetTreeDocumentContentClient(_dataViewMode,  documentListName,  documentName);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="crop"></param>
		/// <param name="documentListName"></param>
		/// <param name="documentName"></param>
		/// <param name="height"></param>
		/// <param name="max"></param>
		/// <param name="maxHeight"></param>
		/// <param name="maxWidth"></param>
		/// <param name="quality"></param>
		/// <param name="width"></param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var stream = await documenttree.TransformTreeDocumentContentAsync( documentListName,  documentName,  width,  height,  max,  maxWidth,  maxHeight,  crop,  quality);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> TransformTreeDocumentContentAsync(string documentListName, string documentName, int? width =  null, int? height =  null, int? max =  null, int? maxWidth =  null, int? maxHeight =  null, string crop =  null, int? quality =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.TransformTreeDocumentContentClient( documentListName,  documentName,  width,  height,  max,  maxWidth,  maxHeight,  crop,  quality);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a document based on its document list and folder path in the document hierarchy.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <param name="includeInactive"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var document = await documenttree.GetTreeDocumentAsync(_dataViewMode,  documentListName,  documentName,  includeInactive,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.Document> GetTreeDocumentAsync(string documentListName, string documentName, bool? includeInactive =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.GetTreeDocumentClient(_dataViewMode,  documentListName,  documentName,  includeInactive,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates the content associated with a document, such as a product image or PDF specifications file, based on the document's position in the document hierarchy.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <param name="stream">Input output stream that delivers information.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   await documenttree.UpdateTreeDocumentContentAsync( stream,  documentListName,  documentName,  contentType);
		/// </code>
		/// </example>
		public virtual async Task UpdateTreeDocumentContentAsync(System.IO.Stream stream, string documentListName, string documentName, String  contentType= null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.UpdateTreeDocumentContentClient( stream,  documentListName,  documentName,  contentType);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// Deletes the content associated with a document, such as a product image or PDF specifications file.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <param name="stream">Input output stream that delivers information.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   await documenttree.DeleteTreeDocumentContentAsync( stream,  documentListName,  documentName,  contentType);
		/// </code>
		/// </example>
		public virtual async Task DeleteTreeDocumentContentAsync(System.IO.Stream stream, string documentListName, string documentName, String  contentType= null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.DeleteTreeDocumentContentClient( stream,  documentListName,  documentName,  contentType);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


