
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class produkty
{

    private produktyProdukt produktField;

    /// <remarks/>
    public produktyProdukt produkt
    {
        get
        {
            return this.produktField;
        }
        set
        {
            this.produktField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class produktyProdukt
{

    private string idField;

    private string nazwaField;

    private string nazwa_plField;

    private string nazwa_enField;

    private string dlugi_opisField;

    private string dlugi_opis_plField;

    private string dlugi_opis_enField;

    private string kodField;

    private string eanField;

    private string statusField;

    private string cena_zewnetrzna_hurtField;

    private string cena_sugerowanaField;

    private string kod_dostawcyField;

    private string vatField;

    private string rozmiarField;

    private string kolorField;

    private string catField;

    private string cat_plField;

    private string cat_enField;

    private produktyProduktZdjecia zdjeciaField;

    /// <remarks/>
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
    public string nazwa
    {
        get
        {
            return this.nazwaField;
        }
        set
        {
            this.nazwaField = value;
        }
    }

    /// <remarks/>
    public string nazwa_pl
    {
        get
        {
            return this.nazwa_plField;
        }
        set
        {
            this.nazwa_plField = value;
        }
    }

    /// <remarks/>
    public string nazwa_en
    {
        get
        {
            return this.nazwa_enField;
        }
        set
        {
            this.nazwa_enField = value;
        }
    }

    /// <remarks/>
    public string dlugi_opis
    {
        get
        {
            return this.dlugi_opisField;
        }
        set
        {
            this.dlugi_opisField = value;
        }
    }

    /// <remarks/>
    public string dlugi_opis_pl
    {
        get
        {
            return this.dlugi_opis_plField;
        }
        set
        {
            this.dlugi_opis_plField = value;
        }
    }

    /// <remarks/>
    public string dlugi_opis_en
    {
        get
        {
            return this.dlugi_opis_enField;
        }
        set
        {
            this.dlugi_opis_enField = value;
        }
    }

    /// <remarks/>
    public string kod
    {
        get
        {
            return this.kodField;
        }
        set
        {
            this.kodField = value;
        }
    }

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
    public string status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    public string cena_zewnetrzna_hurt
    {
        get
        {
            return this.cena_zewnetrzna_hurtField;
        }
        set
        {
            this.cena_zewnetrzna_hurtField = value;
        }
    }

    /// <remarks/>
    public string cena_sugerowana
    {
        get
        {
            return this.cena_sugerowanaField;
        }
        set
        {
            this.cena_sugerowanaField = value;
        }
    }

    /// <remarks/>
    public string kod_dostawcy
    {
        get
        {
            return this.kod_dostawcyField;
        }
        set
        {
            this.kod_dostawcyField = value;
        }
    }

    /// <remarks/>
    public string vat
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
    public string rozmiar
    {
        get
        {
            return this.rozmiarField;
        }
        set
        {
            this.rozmiarField = value;
        }
    }

    /// <remarks/>
    public string kolor
    {
        get
        {
            return this.kolorField;
        }
        set
        {
            this.kolorField = value;
        }
    }

    /// <remarks/>
    public string cat
    {
        get
        {
            return this.catField;
        }
        set
        {
            this.catField = value;
        }
    }

    /// <remarks/>
    public string cat_pl
    {
        get
        {
            return this.cat_plField;
        }
        set
        {
            this.cat_plField = value;
        }
    }

    /// <remarks/>
    public string cat_en
    {
        get
        {
            return this.cat_enField;
        }
        set
        {
            this.cat_enField = value;
        }
    }

    /// <remarks/>
    public produktyProduktZdjecia zdjecia
    {
        get
        {
            return this.zdjeciaField;
        }
        set
        {
            this.zdjeciaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class produktyProduktZdjecia
{

    private produktyProduktZdjeciaZdjecie zdjecieField;

    /// <remarks/>
    public produktyProduktZdjeciaZdjecie zdjecie
    {
        get
        {
            return this.zdjecieField;
        }
        set
        {
            this.zdjecieField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class produktyProduktZdjeciaZdjecie
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

