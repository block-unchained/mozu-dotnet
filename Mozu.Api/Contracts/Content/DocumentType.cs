
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
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.Content
{
		///
		///	The type of documents used in the CMS such as "web_page" or "template" or "image_url".
		///
		public class DocumentType
		{
			///
			///The administrator name associated with the object/data.
			///
			public string AdminName { get; set; }

			///
			///Fully qualified name of the document type. 
			///
			public string DocumentTypeFQN { get; set; }

			///
			///The package of document lists and content documents to be installed.
			///
			public string InstallationPackage { get; set; }

			///
			///Metadata content for entities, used by document lists, document type lists, document type, views, entity lists, and list views.
			///
			public JObject Metadata { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///If applicable, the registered namespace associated with objects, used to generate the fully qualified name. If no namespace is defined, the namespace associated with the tenant is automatically assigned.
			///
			public string Namespace { get; set; }

			///
			///Collection of property attributes defined for the object. Properties are associated to all objects within Mozu, including documents, products, and product types.
			///
			public List<Property> Properties { get; set; }

			///
			///The current version number of the order, wish list, document list, or document type list.
			///
			public string Version { get; set; }

		}

}