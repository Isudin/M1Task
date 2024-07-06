
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class products
{

    private productsProduct productField;

    private ushort elmentsField;

    private uint clientidField;

    private string langField;

    private string datetimeField;

    /// <remarks/>
    public productsProduct product
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
    public ushort elments
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint clientid
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public string datetime
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class productsProduct
{

    private string eanField;

    private byte idField;

    private string skuField;

    private string inStockField;

    private byte qtyField;

    private object availabilityField;

    /// <remarks/>
    public string ean
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
    public string sku
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
    public string inStock
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
    public byte qty
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
    public object availability
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
}

