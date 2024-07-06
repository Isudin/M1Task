
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
namespace M2Task.Domain.Model.XML;

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class offer
{

    private offerProducts productsField;

    private string file_formatField;

    private string generatedField;

    private string currencyField;

    private decimal versionField;

    private string extensionsField;

    /// <remarks/>
    public offerProducts products
    {
        get
        {
            return this.productsField;
        }
        set
        {
            this.productsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string file_format
    {
        get
        {
            return this.file_formatField;
        }
        set
        {
            this.file_formatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string generated
    {
        get
        {
            return this.generatedField;
        }
        set
        {
            this.generatedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extensions
    {
        get
        {
            return this.extensionsField;
        }
        set
        {
            this.extensionsField = value;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProducts
    {

        private offerProductsProduct productField;

        private string languageField;

        /// <remarks/>
        public offerProductsProduct product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProduct
    {

        private offerProductsProductProducer producerField;

        private offerProductsProductCategory categoryField;

        private offerProductsProductUnit unitField;

        private offerProductsProductWarranty warrantyField;

        private offerProductsProductCard cardField;

        private offerProductsProductDescription descriptionField;

        private offerProductsProductPrice priceField;

        private offerProductsProductSrp srpField;

        private offerProductsProductImages imagesField;

        private icons iconsField;

        private offerProductsProductSizes sizesField;

        private offerProductsProductParameter[] parametersField;

        private offerProductsProductGroup groupField;

        private ushort idField;

        private string currencyField;

        private string code_producerField;

        private byte siteField;

        /// <remarks/>
        public offerProductsProductProducer producer
        {
            get
            {
                return this.producerField;
            }
            set
            {
                this.producerField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductCategory category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductUnit unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductWarranty warranty
        {
            get
            {
                return this.warrantyField;
            }
            set
            {
                this.warrantyField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductCard card
        {
            get
            {
                return this.cardField;
            }
            set
            {
                this.cardField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductDescription description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductPrice price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductSrp srp
        {
            get
            {
                return this.srpField;
            }
            set
            {
                this.srpField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductImages images
        {
            get
            {
                return this.imagesField;
            }
            set
            {
                this.imagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public icons icons
        {
            get
            {
                return this.iconsField;
            }
            set
            {
                this.iconsField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductSizes sizes
        {
            get
            {
                return this.sizesField;
            }
            set
            {
                this.sizesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable = false)]
        public offerProductsProductParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductGroup group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code_producer
        {
            get
            {
                return this.code_producerField;
            }
            set
            {
                this.code_producerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public byte site
        {
            get
            {
                return this.siteField;
            }
            set
            {
                this.siteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductProducer
    {

        private uint idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductCategory
    {

        private uint idField;

        private string langField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductUnit
    {

        private byte idField;

        private string langField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductWarranty
    {

        private byte idField;

        private string typeField;

        private byte periodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public byte period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductCard
    {

        private string urlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductDescription
    {

        private offerProductsProductDescriptionName[] nameField;

        private offerProductsProductDescriptionVersion versionField;

        private offerProductsProductDescriptionLong_desc[] long_descField;

        private offerProductsProductDescriptionShort_desc[] short_descField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public offerProductsProductDescriptionName[] name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductDescriptionVersion version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("long_desc")]
        public offerProductsProductDescriptionLong_desc[] long_desc
        {
            get
            {
                return this.long_descField;
            }
            set
            {
                this.long_descField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("short_desc")]
        public offerProductsProductDescriptionShort_desc[] short_desc
        {
            get
            {
                return this.short_descField;
            }
            set
            {
                this.short_descField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductDescriptionName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductDescriptionVersion
    {

        private offerProductsProductDescriptionVersionName[] nameField;

        private decimal name1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public offerProductsProductDescriptionVersionName[] name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public decimal name1
        {
            get
            {
                return this.name1Field;
            }
            set
            {
                this.name1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductDescriptionVersionName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductDescriptionLong_desc
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductDescriptionShort_desc
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductPrice
    {

        private decimal grossField;

        private decimal netField;

        private decimal vatField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal gross
        {
            get
            {
                return this.grossField;
            }
            set
            {
                this.grossField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal net
        {
            get
            {
                return this.netField;
            }
            set
            {
                this.netField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductSrp
    {

        private decimal grossField;

        private decimal netField;

        private decimal vatField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal gross
        {
            get
            {
                return this.grossField;
            }
            set
            {
                this.grossField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal net
        {
            get
            {
                return this.netField;
            }
            set
            {
                this.netField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal vat
        {
            get
            {
                return this.vatField;
            }
            set
            {
                this.vatField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductImages
    {

        private offerProductsProductImagesImage[] largeField;

        private offerProductsProductImagesIcons iconsField;

        private originalsImage[] originalsField;

        private string externalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("image", IsNullable = false)]
        public offerProductsProductImagesImage[] large
        {
            get
            {
                return this.largeField;
            }
            set
            {
                this.largeField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductImagesIcons icons
        {
            get
            {
                return this.iconsField;
            }
            set
            {
                this.iconsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        [System.Xml.Serialization.XmlArrayItemAttribute("image", IsNullable = false)]
        public originalsImage[] originals
        {
            get
            {
                return this.originalsField;
            }
            set
            {
                this.originalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public string external
        {
            get
            {
                return this.externalField;
            }
            set
            {
                this.externalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductImagesImage
    {

        private string urlField;

        private string url2Field;

        private string date_changedField;

        private string hashField;

        private ushort widthField;

        private ushort heightField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public string url2
        {
            get
            {
                return this.url2Field;
            }
            set
            {
                this.url2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date_changed
        {
            get
            {
                return this.date_changedField;
            }
            set
            {
                this.date_changedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductImagesIcons
    {

        private offerProductsProductImagesIconsIcon iconField;

        /// <remarks/>
        public offerProductsProductImagesIconsIcon icon
        {
            get
            {
                return this.iconField;
            }
            set
            {
                this.iconField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductImagesIconsIcon
    {

        private string urlField;

        private string url2Field;

        private string date_changedField;

        private string hashField;

        private ushort widthField;

        private ushort heightField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public string url2
        {
            get
            {
                return this.url2Field;
            }
            set
            {
                this.url2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date_changed
        {
            get
            {
                return this.date_changedField;
            }
            set
            {
                this.date_changedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public partial class originalsImage
    {

        private string urlField;

        private ushort widthField;

        private ushort heightField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml", IsNullable = false)]
    public partial class icons
    {

        private iconsAuction_icon auction_iconField;

        /// <remarks/>
        public iconsAuction_icon auction_icon
        {
            get
            {
                return this.auction_iconField;
            }
            set
            {
                this.auction_iconField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public partial class iconsAuction_icon
    {

        private string date_changedField;

        private string hashField;

        private ushort heightField;

        private ushort widthField;

        private string urlField;

        private string url2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date_changed
        {
            get
            {
                return this.date_changedField;
            }
            set
            {
                this.date_changedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string url2
        {
            get
            {
                return this.url2Field;
            }
            set
            {
                this.url2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductSizes
    {

        private offerProductsProductSizesSize sizeField;

        /// <remarks/>
        public offerProductsProductSizesSize size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductSizesSize
    {

        private offerProductsProductSizesSizePrice priceField;

        private offerProductsProductSizesSizeSrp srpField;

        private offerProductsProductSizesSizeStock stockField;

        private byte idField;

        private ulong code_producerField;

        private string codeField;

        private byte weightField;

        /// <remarks/>
        public offerProductsProductSizesSizePrice price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductSizesSizeSrp srp
        {
            get
            {
                return this.srpField;
            }
            set
            {
                this.srpField = value;
            }
        }

        /// <remarks/>
        public offerProductsProductSizesSizeStock stock
        {
            get
            {
                return this.stockField;
            }
            set
            {
                this.stockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong code_producer
        {
            get
            {
                return this.code_producerField;
            }
            set
            {
                this.code_producerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductSizesSizePrice
    {

        private decimal grossField;

        private decimal netField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal gross
        {
            get
            {
                return this.grossField;
            }
            set
            {
                this.grossField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal net
        {
            get
            {
                return this.netField;
            }
            set
            {
                this.netField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductSizesSizeSrp
    {

        private decimal grossField;

        private decimal netField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal gross
        {
            get
            {
                return this.grossField;
            }
            set
            {
                this.grossField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal net
        {
            get
            {
                return this.netField;
            }
            set
            {
                this.netField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductSizesSizeStock
    {

        private byte idField;

        private byte quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductParameter
    {

        private offerProductsProductParameterValue[] valueField;

        private ushort idField;

        private string langField;

        private string nameField;

        private byte priorityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public offerProductsProductParameterValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public byte priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductParameterValue
    {

        private ushort idField;

        private string langField;

        private string nameField;

        private byte priorityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public byte priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductGroup
    {

        private offerProductsProductGroupGroup_by_parameter group_by_parameterField;

        private ushort idField;

        /// <remarks/>
        public offerProductsProductGroupGroup_by_parameter group_by_parameter
        {
            get
            {
                return this.group_by_parameterField;
            }
            set
            {
                this.group_by_parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductGroupGroup_by_parameter
    {

        private offerProductsProductGroupGroup_by_parameterProduct_value product_valueField;

        private string idField;

        private string nameField;

        /// <remarks/>
        public offerProductsProductGroupGroup_by_parameterProduct_value product_value
        {
            get
            {
                return this.product_valueField;
            }
            set
            {
                this.product_valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class offerProductsProductGroupGroup_by_parameterProduct_value
    {

        private string idField;

        private decimal nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml", IsNullable = false)]
    public partial class originals
    {

        private originalsImage[] imageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("image")]
        public originalsImage[] image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }
    }
}