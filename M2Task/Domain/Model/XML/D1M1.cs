#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
using System.Xml.Serialization;

namespace M2Task.Domain.Model.XML;

/// <remarks/>
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false, ElementName = "offer")]
public partial class D1M1Offer : IXmlModel
{
    private OfferProducts productsField;

    private string file_formatField;

    private decimal versionField;

    private string generatedField;

    /// <remarks/>
    [XmlElement("products")]
    public OfferProducts Products
    {
        get
        {
            return productsField;
        }
        set
        {
            productsField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute("file_format")]
    public string FileFormat
    {
        get
        {
            return file_formatField;
        }
        set
        {
            file_formatField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute()]
    public decimal Version
    {
        get
        {
            return versionField;
        }
        set
        {
            versionField = value;
        }
    }

    /// <remarks/>
    [XmlAttribute()]
    public string Generated
    {
        get
        {
            return generatedField;
        }
        set
        {
            generatedField = value;
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProducts
    {

        private OfferProductsProduct[] productField;

        private string currencyField;

        /// <remarks/>
        [XmlElement("product")]
        public OfferProductsProduct[] Products
        {
            get
            {
                return productField;
            }
            set
            {
                productField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Currency
        {
            get
            {
                return currencyField;
            }
            set
            {
                currencyField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProduct
    {

        private OfferProductsProductPrice priceField;

        private OfferProductsProductSrp srpField;

        private OfferProductsProductSizes sizesField;

        private int idField;

        /// <remarks/>
        public OfferProductsProductPrice Price
        {
            get
            {
                return priceField;
            }
            set
            {
                priceField = value;
            }
        }

        /// <remarks/>
        [XmlElement("srp")]
        public OfferProductsProductSrp Srp
        {
            get
            {
                return srpField;
            }
            set
            {
                srpField = value;
            }
        }

        /// <remarks/>
        [XmlElement("sizes")]
        public OfferProductsProductSizes Sizes
        {
            get
            {
                return sizesField;
            }
            set
            {
                sizesField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
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
        [XmlAttribute("gross")]
        public decimal Gross
        {
            get
            {
                return grossField;
            }
            set
            {
                grossField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute("net")]
        public decimal Net
        {
            get
            {
                return netField;
            }
            set
            {
                netField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute("vat")]
        public decimal Vat
        {
            get
            {
                return vatField;
            }
            set
            {
                vatField = value;
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
    public partial class OfferProductsProductSizes
    {

        private OfferProductsProductSizesSize[] sizeField;

        /// <remarks/>
        [XmlElement("size")]
        public OfferProductsProductSizesSize[] Sizes
        {
            get
            {
                return sizeField;
            }
            set
            {
                sizeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductSizesSize
    {

        private OfferProductsProductSizesSizeStock stockField;

        private int idField;

        private string codeProducerField;

        private string codeField;

        private decimal weightField;

        /// <remarks/>
        [XmlElement("stock")]
        public OfferProductsProductSizesSizeStock Stock
        {
            get
            {
                return stockField;
            }
            set
            {
                stockField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute("id")]
        public int Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        /// EAN
        [XmlAttribute("code_producer")]
        public string CodeProducer
        {
            get
            {
                return codeProducerField;
            }
            set
            {
                codeProducerField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute("code")]
        public string Code
        {
            get
            {
                return codeField;
            }
            set
            {
                codeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Weight
        {
            get
            {
                return weightField;
            }
            set
            {
                weightField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class OfferProductsProductSizesSizeStock
    {

        private int idField;

        private int quantityField;

        /// <remarks/>
        [XmlAttribute("is")]
        public int Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute("quantity")]
        public int Quantity
        {
            get
            {
                return quantityField;
            }
            set
            {
                quantityField = value;
            }
        }
    }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.