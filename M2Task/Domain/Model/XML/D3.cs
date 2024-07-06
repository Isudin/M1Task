﻿
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
using System.Xml.Serialization;

namespace M2Task.Domain.Model.XML;

/// <remarks/>
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(AnonymousType = true, TypeName = "produkt")]
[XmlRoot(Namespace = "", IsNullable = false)]
public partial class D3Produkty
{

    private ProduktyProdukt produktField;

    /// <remarks/>
    public ProduktyProdukt Produkt
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

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ProduktyProdukt
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

        private ProduktyProduktZdjecia zdjeciaField;

        /// <remarks/>
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
        public string Nazwa
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
        [XmlElement("nazwa_pl")]
        public string NazwaPl
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
        [XmlElement("nazwa_en")]
        public string NazwaEn
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
        [XmlElement("dlugi_opis")]
        public string DlugiOpis
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
        [XmlElement("dlugi_opis_pl")]
        public string DlugiOpisPl
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
        [XmlElement("dlugi_opis_en")]
        public string DlugiOpisEn
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
        public string Kod
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
        public string Status
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
        [XmlElement("cena_zewnetrzna_hurt")]
        public string CenaZewnetrznaHurt
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
        [XmlElement("cena_sugerowana")]
        public string CenaSugerowana
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
        [XmlElement("cena_sugerowana")]
        public string KodDostawcy
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
        public string Vat
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
        public string Rozmiar
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
        public string Kolor
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
        public string Cat
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
        [XmlElement("cat_pl")]
        public string CatPl
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
        [XmlElement("cat_en")]
        public string CatEn
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
        public ProduktyProduktZdjecia Zdjecia
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ProduktyProduktZdjecia
    {

        private ProduktyProduktZdjeciaZdjecie zdjecieField;

        /// <remarks/>
        public ProduktyProduktZdjeciaZdjecie Zdjecie
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
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ProduktyProduktZdjeciaZdjecie
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
}