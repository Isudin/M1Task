
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
using System.Xml.Serialization;

namespace M2Task.Domain.Model.XML;

/// <remarks/>
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(AnonymousType = true, TypeName = "products")]
[XmlRoot(Namespace = "", IsNullable = false, ElementName = "products")]
public partial class D2Products : IXmlModel
{
    private productsProduct[] productsField;

    private ushort elmentsField;

    private uint clientidField;

    private string langField;

    private string datetimeField;

    private byte templateField;

    private byte versionField;

    /// <remarks/>
    public productsProduct[] Products
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
    public ushort Elments
    {
        get
        {
            return this.elmentsField;
        }
        set
        {
            this.elmentsField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute()]
    public uint ClientId
    {
        get
        {
            return this.clientidField;
        }
        set
        {
            this.clientidField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute()]
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
    public string DateTime
    {
        get
        {
            return this.datetimeField;
        }
        set
        {
            this.datetimeField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute()]
    public byte Template
    {
        get
        {
            return this.templateField;
        }
        set
        {
            this.templateField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute()]
    public byte Version
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class productsProduct
    {

        private string eanField;

        private byte idField;

        private string skuField;

        private string nameField;

        private string descField;

        private string urlField;

        private ProductsProductCategory[] categoriesField;

        private object attributesField;

        private string unitField;

        private string weightField;

        private string pKWiUField;

        private string inStockField;

        private byte qtyField;

        private object availabilityField;

        private string requiredBoxField;

        private byte quantityPerBoxField;

        private decimal priceAfterDiscountNetField;

        private byte vatField;

        private byte retailPriceGrossField;

        private ProductsProductPhoto[] photosField;

        /// <remarks/>
        public string Ean
        {
            get
            {
                return this.eanField;
            }
            set
            {
                this.eanField = value;
            }
        }

        /// <remarks/>
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
        public string Sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        /// <remarks/>
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
        public string Desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }

        /// <remarks/>
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
        [XmlArrayItem("category", IsNullable = false)]
        public ProductsProductCategory[] Categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
            }
        }

        /// <remarks/>
        public object Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        public string Unit
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
        public string Weight
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

        /// <remarks/>
        public string PKWiU
        {
            get
            {
                return this.pKWiUField;
            }
            set
            {
                this.pKWiUField = value;
            }
        }

        /// <remarks/>
        public string InStock
        {
            get
            {
                return this.inStockField;
            }
            set
            {
                this.inStockField = value;
            }
        }

        /// <remarks/>
        public byte Qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }

        /// <remarks/>
        public object Availability
        {
            get
            {
                return this.availabilityField;
            }
            set
            {
                this.availabilityField = value;
            }
        }

        /// <remarks/>
        public string RequiredBox
        {
            get
            {
                return this.requiredBoxField;
            }
            set
            {
                this.requiredBoxField = value;
            }
        }

        /// <remarks/>
        public byte QuantityPerBox
        {
            get
            {
                return this.quantityPerBoxField;
            }
            set
            {
                this.quantityPerBoxField = value;
            }
        }

        /// <remarks/>
        public decimal PriceAfterDiscountNet
        {
            get
            {
                return this.priceAfterDiscountNetField;
            }
            set
            {
                this.priceAfterDiscountNetField = value;
            }
        }

        /// <remarks/>
        public byte Vat
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

        /// <remarks/>
        public byte RetailPriceGross
        {
            get
            {
                return this.retailPriceGrossField;
            }
            set
            {
                this.retailPriceGrossField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("photo", IsNullable = false)]
        public ProductsProductPhoto[] Photos
        {
            get
            {
                return this.photosField;
            }
            set
            {
                this.photosField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ProductsProductCategory
    {

        private ulong idField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public ulong Id
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
    public partial class ProductsProductPhoto
    {

        private int idField;

        private byte mainField;

        private string valueField;

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
        public byte Main
        {
            get
            {
                return this.mainField;
            }
            set
            {
                this.mainField = value;
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
}

