
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties of an attribute used to describe customers or orders.
		///
		public class Attribute
		{
			///
			///The administrator name associated with the object/data.
			///
			public string AdminName { get; set; }

			///
			///Merchant-defined code for an extensible attribute. This code may be used to generate an object's fully qualified name, such as for products.
			///
			public string AttributeCode { get; set; }

			///
			///Generated sequence that increments for each attribute and data type combination created. This value is system-supplied and read-only.
			///
			public int? AttributeDataTypeSequence { get; set; }

			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			///
			///List of metadata key-value pairs defined for an extensible attribute.
			///
			public List<AttributeMetadataItem> AttributeMetadata { get; set; }

			///
			///Generated sequence that increments for each product attribute created. This value is system-supplied and read-only.
			///
			public int? AttributeSequence { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Complex type that contains content for a language specified by LocaleCode.
			///
			public AttributeLocalizedContent Content { get; set; }

			///
			///The data type of the source product property, typically of type Bool, DateTime, Number, or String.
			///
			public string DataType { get; set; }

			///
			///The type of input selection used to define a value for the attribute, including Yes/No, Date, DateTime, List, TextBox, or TextArea.
			///
			public string InputType { get; set; }

			///
			///If true, the product attribute is an add-on configuration made by the shopper that does not represent a product variation, such as a monogram.
			///
			public bool? IsExtra { get; set; }

			///
			///If true, the product attribute is a merchant- or shopper-configurable option, such as size or color, that represents a product variation.
			///
			public bool? IsOption { get; set; }

			///
			///If true, the product attribute describes aspects of the product that do not represent an option configurable by the shopper, such as screen resolution or brand.
			///
			public bool? IsProperty { get; set; }

			///
			///The localized content of an attribute determined by the `localeCode`. This content is always in the default language of the MasterCatalog.
			///
			public List<AttributeLocalizedContent> LocalizedContent { get; set; }

			///
			///The unique identifier of the master catalog associated with the entity.
			///
			public int? MasterCatalogId { get; set; }

			///
			///If applicable, the registered namespace associated with objects, used to generate the fully qualified name. If no namespace is defined, the namespace associated with the tenant is automatically assigned.
			///
			public string Namespace { get; set; }

			///
			///This API type provides the search and indexing settings for the attribute.
			///
			public AttributeSearchSettings SearchSettings { get; set; }

			///
			///Properties used when validating a value entered for an object, including extensible attributes, products attributes, and database entries.
			///
			public AttributeValidation Validation { get; set; }

			///
			///An attribute value type is either predefined vocabulary by the admin during attribute set up or user-defined with an appropriate type (AdminEntered or ShopperEntered depending on the user). These types are used by products and attributes. The difference between predefined values versus manually entered values is such that the first choice is a set of options to choose from. AdminEntered and ShopperEntered are values that are entered rather than system-supplied and are not stored in the database, but captured during a live commerce operations such as during an order.
			///
			public string ValueType { get; set; }

			///
			///List of valid vocabulary values defined for an attribute.
			///
			public List<AttributeVocabularyValue> VocabularyValues { get; set; }

		}

}