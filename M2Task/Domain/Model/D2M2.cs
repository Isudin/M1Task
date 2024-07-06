
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

    private byte templateField;

    private byte versionField;

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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte template
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte version
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

    private string nameField;

    private string descField;

    private string urlField;

    private productsProductCategory[] categoriesField;

    private object attributesField;

    private string unitField;

    private string weightField;

    private string pKWiUField;

    private string inStockField;

    private byte qtyField;

    private object availabilityField;

    private string requiredBoxField;

    private byte quantityPerBoxField;

    private string priceAfterDiscountNetField;

    private byte vatField;

    private byte retailPriceGrossField;

    private productsProductPhoto[] photosField;

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
    public string desc
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
    [System.Xml.Serialization.XmlArrayItemAttribute("category", IsNullable = false)]
    public productsProductCategory[] categories
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
    public object attributes
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
    public string unit
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
    public string weight
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

    /// <remarks/>
    public string requiredBox
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
    public byte quantityPerBox
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
    public string priceAfterDiscountNet
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
    public byte vat
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
    public byte retailPriceGross
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
    [System.Xml.Serialization.XmlArrayItemAttribute("photo", IsNullable = false)]
    public productsProductPhoto[] photos
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
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class productsProductCategory
{

    private ulong idField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ulong id
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
public partial class productsProductPhoto
{

    private ushort idField;

    private byte mainField;

    private string valueField;

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
    public byte main
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

