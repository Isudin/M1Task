#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
using System.Xml.Serialization;

namespace M2Task.Domain.Model.XML;

/// <remarks/>
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
public partial class D1M2Offer
{

    private OfferProducts productsField;

    private string file_formatField;

    private string generatedField;

    private string currencyField;

    private decimal versionField;

    private string extensionsField;

    /// <remarks/>
    public OfferProducts Products
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
    [XmlAttribute()]
    [XmlElement("file_format")]
    public string FileFormat
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
    [XmlAttribute()]
    public string Generated
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
    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public string Currency
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
    [XmlAttribute()]
    public decimal Version
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
    [XmlAttribute()]
    public string Extensions
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProducts
    {

        private OfferProductsProduct productField;

        private string languageField;

        /// <remarks/>
        public OfferProductsProduct Product
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
        [XmlAttribute()]
        public string Language
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProduct
    {

        private OfferProductsProductProducer producerField;

        private OfferProductsProductCategory categoryField;

        private OfferProductsProductUnit unitField;

        private OfferProductsProductWarranty warrantyField;

        private OfferProductsProductCard cardField;

        private OfferProductsProductDescription descriptionField;

        private OfferProductsProductPrice priceField;

        private OfferProductsProductSrp srpField;

        private OfferProductsProductImages imagesField;

        private Icons iconsField;

        private OfferProductsProductSizes sizesField;

        private offerProductsProductParameter[] parametersField;

        private OfferProductsProductGroup groupField;

        private ushort idField;

        private string currencyField;

        private string code_producerField;

        private byte siteField;

        /// <remarks/>
        public OfferProductsProductProducer Producer
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
        public OfferProductsProductCategory Category
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
        public OfferProductsProductUnit Unit
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
        public OfferProductsProductWarranty Warranty
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
        public OfferProductsProductCard Card
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
        public OfferProductsProductDescription Description
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
        public OfferProductsProductPrice Price
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
        public OfferProductsProductSrp Srp
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
        public OfferProductsProductImages Images
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
        [XmlElement(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public Icons Icons
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
        public OfferProductsProductSizes Sizes
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
        [XmlArrayItem("parameter", IsNullable = false)]
        public offerProductsProductParameter[] Parameters
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
        public OfferProductsProductGroup Group
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
        [XmlAttribute()]
        public ushort Id
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
        [XmlAttribute()]
        public string Currency
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
        [XmlAttribute()]
        [XmlElement("code_producer")]
        public string CodeProducer
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public byte Site
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductProducer
    {

        private uint idField;

        private string nameField;

        /// <remarks/>
        [XmlAttribute()]
        public uint Id
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
        [XmlAttribute()]
        public string Name
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductCategory
    {

        private uint idField;

        private string langField;

        private string nameField;

        /// <remarks/>
        [XmlAttribute()]
        public uint Id
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang
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
        [XmlAttribute()]
        public string Name
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductUnit
    {

        private byte idField;

        private string langField;

        private string nameField;

        /// <remarks/>
        [XmlAttribute()]
        public byte Id
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang
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
        [XmlAttribute()]
        public string Name
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductWarranty
    {

        private byte idField;

        private string typeField;

        private byte periodField;

        /// <remarks/>
        [XmlAttribute()]
        public byte Id
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public string Type
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public byte Period
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductCard
    {

        private string urlField;

        /// <remarks/>
        [XmlAttribute()]
        public string Url
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductDescription
    {

        private OfferProductsProductDescriptionName[] nameField;

        private OfferProductsProductDescriptionVersion versionField;

        private OfferProductsProductDescriptionLong_desc[] long_descField;

        private OfferProductsProductDescriptionShort_desc[] short_descField;

        /// <remarks/>
        [XmlElement("name")]
        public OfferProductsProductDescriptionName[] Name
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
        public OfferProductsProductDescriptionVersion Version
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
        [XmlElement("long_desc")]
        public OfferProductsProductDescriptionLong_desc[] LongDesc
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
        [XmlElement("short_desc")]
        public OfferProductsProductDescriptionShort_desc[] ShortDesc
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductDescriptionName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang
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
        [XmlText()]
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductDescriptionVersion
    {

        private OfferProductsProductDescriptionVersionName[] nameField;

        private decimal name1Field;

        /// <remarks/>
        [XmlElement("name")]
        public OfferProductsProductDescriptionVersionName[] Name
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
        [XmlAttribute("name")]
        public decimal NameAttribute
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductDescriptionVersionName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang
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
        [XmlText()]
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductDescriptionLong_desc
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang
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
        [XmlText()]
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductDescriptionShort_desc
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang
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
        [XmlText()]
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductPrice
    {

        private decimal grossField;

        private decimal netField;

        private decimal vatField;

        /// <remarks/>
        [XmlAttribute()]
        public decimal Gross
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
        [XmlAttribute()]
        public decimal Net
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
        [XmlAttribute()]
        public decimal Vat
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductSrp : OfferProductsProductPrice { }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductImages
    {

        private OfferProductsProductImagesImage[] largeField;

        private OfferProductsProductImagesIcons iconsField;

        private OriginalsImage[] originalsField;

        private string externalField;

        /// <remarks/>
        [XmlArrayItem("image", IsNullable = false)]
        public OfferProductsProductImagesImage[] Large
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
        public OfferProductsProductImagesIcons Icons
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
        [XmlArray(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        [XmlArrayItem("image", IsNullable = false)]
        public OriginalsImage[] Originals
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public string External
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductImagesImage
    {

        private string urlField;

        private string url2Field;

        private string date_changedField;

        private string hashField;

        private ushort widthField;

        private ushort heightField;

        /// <remarks/>
        [XmlAttribute()]
        public string Url
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public string Url2
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
        [XmlAttribute()]
        [XmlElement("date_changed")]
        public string DateChanged
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
        [XmlAttribute()]
        public string Hash
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public ushort Width
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public ushort Height
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductImagesIcons
    {

        private OfferProductsProductImagesIconsIcon iconField;

        /// <remarks/>
        public OfferProductsProductImagesIconsIcon Icon
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductImagesIconsIcon : OfferProductsProductImagesImage { }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public partial class OriginalsImage
    {

        private string urlField;

        private ushort widthField;

        private ushort heightField;

        /// <remarks/>
        [XmlAttribute()]
        public string Url
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
        [XmlAttribute()]
        public ushort Width
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
        [XmlAttribute()]
        public ushort Height
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    [XmlRoot(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml", IsNullable = false)]
    public partial class Icons
    {

        private AuctionIcon auction_iconField;

        /// <remarks/>
        [XmlElement("auction_icon")]
        public AuctionIcon AuctionIcon
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml", TypeName = "iconsAuction_icon")]
    public partial class AuctionIcon : OfferProductsProductImagesImage { }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductSizes
    {

        private OfferProductsProductSizesSize sizeField;

        /// <remarks/>
        public OfferProductsProductSizesSize Size
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductSizesSize
    {

        private OfferProductsProductSizesSizePrice priceField;

        private OfferProductsProductSizesSizeSrp srpField;

        private offerProductsProductSizesSizeStock stockField;

        private int idField;

        private ulong code_producerField;

        private string codeField;

        private byte weightField;

        /// <remarks/>
        public OfferProductsProductSizesSizePrice Price
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
        public OfferProductsProductSizesSizeSrp Srp
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
        public offerProductsProductSizesSizeStock Stock
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
        [XmlAttribute()]
        public int Id
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
        [XmlAttribute()]
        public ulong CodeProducer
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
        [XmlAttribute()]
        public string Code
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
        [XmlAttribute()]
        public byte Weight
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductSizesSizePrice
    {

        private decimal grossField;

        private decimal netField;

        /// <remarks/>
        [XmlAttribute()]
        public decimal Gross
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
        [XmlAttribute()]
        public decimal Net
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductSizesSizeSrp
    {

        private decimal grossField;

        private decimal netField;

        /// <remarks/>
        [XmlAttribute()]
        public decimal Gross
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
        [XmlAttribute()]
        public decimal Net
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class offerProductsProductSizesSizeStock
    {

        private int idField;

        private byte quantityField;

        /// <remarks/>
        [XmlAttribute()]
        public int Id
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
        [XmlAttribute()]
        public byte Quantity
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class offerProductsProductParameter
    {

        private OfferProductsProductParameterValue[] valueField;

        private ushort idField;

        private string langField;

        private string nameField;

        private byte priorityField;

        /// <remarks/>
        [XmlElement("value")]
        public OfferProductsProductParameterValue[] value
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
        [XmlAttribute()]
        public ushort Id
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang
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
        [XmlAttribute()]
        public string Name
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public byte Priority
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductParameterValue
    {

        private ushort idField;

        private string langField;

        private string nameField;

        private byte priorityField;

        /// <remarks/>
        [XmlAttribute()]
        public ushort Id
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang
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
        [XmlAttribute()]
        public string Name
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
        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
        public byte Priority
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductGroup
    {

        private OfferProductsProductGroupGroup_by_parameter group_by_parameterField;

        private ushort idField;

        /// <remarks/>
        public OfferProductsProductGroupGroup_by_parameter group_by_parameter
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
        [XmlAttribute()]
        public ushort Id
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductGroupGroup_by_parameter
    {

        private OfferProductsProductGroupGroup_by_parameterProduct_value product_valueField;

        private string idField;

        private string nameField;

        /// <remarks/>
        public OfferProductsProductGroupGroup_by_parameterProduct_value product_value
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
        [XmlAttribute()]
        public string Id
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
        [XmlAttribute()]
        public string Name
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductGroupGroup_by_parameterProduct_value
    {

        private string idField;

        private decimal nameField;

        /// <remarks/>
        [XmlAttribute()]
        public string Id
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
        [XmlAttribute()]
        public decimal Name
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    [XmlRoot(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml", IsNullable = false)]
    public partial class Originals
    {

        private OriginalsImage[] imageField;

        /// <remarks/>
        [XmlElement("image")]
        public OriginalsImage[] Image
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
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.