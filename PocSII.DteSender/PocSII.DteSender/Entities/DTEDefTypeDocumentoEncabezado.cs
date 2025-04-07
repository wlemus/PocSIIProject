using PocSII.DteProcessor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteProcessor.Entities
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezado {

        private DTEDefTypeDocumentoEncabezadoIdDoc idDocField;

        private DTEDefTypeDocumentoEncabezadoEmisor emisorField;

        private string rUTMandanteField;

        private DTEDefTypeDocumentoEncabezadoReceptor receptorField;

        private string rUTSolicitaField;

        private DTEDefTypeDocumentoEncabezadoTransporte transporteField;

        private DTEDefTypeDocumentoEncabezadoTotales totalesField;

        private DTEDefTypeDocumentoEncabezadoOtraMoneda otraMonedaField;

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoIdDoc IdDoc {
            get {
                return this.idDocField;
            }
            set {
                this.idDocField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoEmisor Emisor {
            get {
                return this.emisorField;
            }
            set {
                this.emisorField = value;
            }
        }

        /// <remarks/>
        public string RUTMandante {
            get {
                return this.rUTMandanteField;
            }
            set {
                this.rUTMandanteField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoReceptor Receptor {
            get {
                return this.receptorField;
            }
            set {
                this.receptorField = value;
            }
        }

        /// <remarks/>
        public string RUTSolicita {
            get {
                return this.rUTSolicitaField;
            }
            set {
                this.rUTSolicitaField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoTransporte Transporte {
            get {
                return this.transporteField;
            }
            set {
                this.transporteField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoTotales Totales {
            get {
                return this.totalesField;
            }
            set {
                this.totalesField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoOtraMoneda OtraMoneda {
            get {
                return this.otraMonedaField;
            }
            set {
                this.otraMonedaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoIdDoc {

        private DTEType tipoDTEField;

        private string folioField;

        private System.DateTime fchEmisField;

        private DTEDefTypeDocumentoEncabezadoIdDocIndNoRebaja indNoRebajaField;

        private bool indNoRebajaFieldSpecified;

        private DTEDefTypeDocumentoEncabezadoIdDocTipoDespacho tipoDespachoField;

        private bool tipoDespachoFieldSpecified;

        private DTEDefTypeDocumentoEncabezadoIdDocIndTraslado indTrasladoField;

        private bool indTrasladoFieldSpecified;

        private DTEDefTypeDocumentoEncabezadoIdDocTpoImpresion tpoImpresionField;

        private bool tpoImpresionFieldSpecified;

        private DTEDefTypeDocumentoEncabezadoIdDocIndServicio indServicioField;

        private bool indServicioFieldSpecified;

        private DTEDefTypeDocumentoEncabezadoIdDocMntBruto mntBrutoField;

        private bool mntBrutoFieldSpecified;

        private TipoTransCOMPRA tpoTranCompraField;

        private bool tpoTranCompraFieldSpecified;

        private TipoTransVENTA tpoTranVentaField;

        private bool tpoTranVentaFieldSpecified;

        private DTEDefTypeDocumentoEncabezadoIdDocFmaPago fmaPagoField;

        private bool fmaPagoFieldSpecified;

        private string fmaPagExpField;

        private System.DateTime fchCancelField;

        private bool fchCancelFieldSpecified;

        private string mntCancelField;

        private string saldoInsolField;

        private DTEDefTypeDocumentoEncabezadoIdDocMntPagos[] mntPagosField;

        private System.DateTime periodoDesdeField;

        private bool periodoDesdeFieldSpecified;

        private System.DateTime periodoHastaField;

        private bool periodoHastaFieldSpecified;

        private MedioPagoType medioPagoField;

        private bool medioPagoFieldSpecified;

        private DTEDefTypeDocumentoEncabezadoIdDocTpoCtaPago tpoCtaPagoField;

        private bool tpoCtaPagoFieldSpecified;

        private string numCtaPagoField;

        private string bcoPagoField;

        private string termPagoCdgField;

        private string termPagoGlosaField;

        private string termPagoDiasField;

        private System.DateTime fchVencField;

        private bool fchVencFieldSpecified;

        private DTEDefTypeDocumentoEncabezadoIdDocTipoFactEsp tipoFactEspField;

        private bool tipoFactEspFieldSpecified;

        /// <remarks/>
        public DTEType TipoDTE {
            get {
                return this.tipoDTEField;
            }
            set {
                this.tipoDTEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string Folio {
            get {
                return this.folioField;
            }
            set {
                this.folioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FchEmis {
            get {
                return this.fchEmisField;
            }
            set {
                this.fchEmisField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoIdDocIndNoRebaja IndNoRebaja {
            get {
                return this.indNoRebajaField;
            }
            set {
                this.indNoRebajaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndNoRebajaSpecified {
            get {
                return this.indNoRebajaFieldSpecified;
            }
            set {
                this.indNoRebajaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoIdDocTipoDespacho TipoDespacho {
            get {
                return this.tipoDespachoField;
            }
            set {
                this.tipoDespachoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoDespachoSpecified {
            get {
                return this.tipoDespachoFieldSpecified;
            }
            set {
                this.tipoDespachoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoIdDocIndTraslado IndTraslado {
            get {
                return this.indTrasladoField;
            }
            set {
                this.indTrasladoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndTrasladoSpecified {
            get {
                return this.indTrasladoFieldSpecified;
            }
            set {
                this.indTrasladoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoIdDocTpoImpresion TpoImpresion {
            get {
                return this.tpoImpresionField;
            }
            set {
                this.tpoImpresionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TpoImpresionSpecified {
            get {
                return this.tpoImpresionFieldSpecified;
            }
            set {
                this.tpoImpresionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoIdDocIndServicio IndServicio {
            get {
                return this.indServicioField;
            }
            set {
                this.indServicioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndServicioSpecified {
            get {
                return this.indServicioFieldSpecified;
            }
            set {
                this.indServicioFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoIdDocMntBruto MntBruto {
            get {
                return this.mntBrutoField;
            }
            set {
                this.mntBrutoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MntBrutoSpecified {
            get {
                return this.mntBrutoFieldSpecified;
            }
            set {
                this.mntBrutoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TipoTransCOMPRA TpoTranCompra {
            get {
                return this.tpoTranCompraField;
            }
            set {
                this.tpoTranCompraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TpoTranCompraSpecified {
            get {
                return this.tpoTranCompraFieldSpecified;
            }
            set {
                this.tpoTranCompraFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TipoTransVENTA TpoTranVenta {
            get {
                return this.tpoTranVentaField;
            }
            set {
                this.tpoTranVentaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TpoTranVentaSpecified {
            get {
                return this.tpoTranVentaFieldSpecified;
            }
            set {
                this.tpoTranVentaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoIdDocFmaPago FmaPago {
            get {
                return this.fmaPagoField;
            }
            set {
                this.fmaPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FmaPagoSpecified {
            get {
                return this.fmaPagoFieldSpecified;
            }
            set {
                this.fmaPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string FmaPagExp {
            get {
                return this.fmaPagExpField;
            }
            set {
                this.fmaPagExpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FchCancel {
            get {
                return this.fchCancelField;
            }
            set {
                this.fchCancelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FchCancelSpecified {
            get {
                return this.fchCancelFieldSpecified;
            }
            set {
                this.fchCancelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string MntCancel {
            get {
                return this.mntCancelField;
            }
            set {
                this.mntCancelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string SaldoInsol {
            get {
                return this.saldoInsolField;
            }
            set {
                this.saldoInsolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MntPagos")]
        public DTEDefTypeDocumentoEncabezadoIdDocMntPagos[] MntPagos {
            get {
                return this.mntPagosField;
            }
            set {
                this.mntPagosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime PeriodoDesde {
            get {
                return this.periodoDesdeField;
            }
            set {
                this.periodoDesdeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodoDesdeSpecified {
            get {
                return this.periodoDesdeFieldSpecified;
            }
            set {
                this.periodoDesdeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime PeriodoHasta {
            get {
                return this.periodoHastaField;
            }
            set {
                this.periodoHastaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodoHastaSpecified {
            get {
                return this.periodoHastaFieldSpecified;
            }
            set {
                this.periodoHastaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public MedioPagoType MedioPago {
            get {
                return this.medioPagoField;
            }
            set {
                this.medioPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MedioPagoSpecified {
            get {
                return this.medioPagoFieldSpecified;
            }
            set {
                this.medioPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoIdDocTpoCtaPago TpoCtaPago {
            get {
                return this.tpoCtaPagoField;
            }
            set {
                this.tpoCtaPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TpoCtaPagoSpecified {
            get {
                return this.tpoCtaPagoFieldSpecified;
            }
            set {
                this.tpoCtaPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string NumCtaPago {
            get {
                return this.numCtaPagoField;
            }
            set {
                this.numCtaPagoField = value;
            }
        }

        /// <remarks/>
        public string BcoPago {
            get {
                return this.bcoPagoField;
            }
            set {
                this.bcoPagoField = value;
            }
        }

        /// <remarks/>
        public string TermPagoCdg {
            get {
                return this.termPagoCdgField;
            }
            set {
                this.termPagoCdgField = value;
            }
        }

        /// <remarks/>
        public string TermPagoGlosa {
            get {
                return this.termPagoGlosaField;
            }
            set {
                this.termPagoGlosaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string TermPagoDias {
            get {
                return this.termPagoDiasField;
            }
            set {
                this.termPagoDiasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FchVenc {
            get {
                return this.fchVencField;
            }
            set {
                this.fchVencField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FchVencSpecified {
            get {
                return this.fchVencFieldSpecified;
            }
            set {
                this.fchVencFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoIdDocTipoFactEsp TipoFactEsp {
            get {
                return this.tipoFactEspField;
            }
            set {
                this.tipoFactEspField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoFactEspSpecified {
            get {
                return this.tipoFactEspFieldSpecified;
            }
            set {
                this.tipoFactEspFieldSpecified = value;
            }
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoIdDocIndNoRebaja {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoIdDocTipoDespacho {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoIdDocIndTraslado {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoIdDocTpoImpresion {

        /// <remarks/>
        N,

        /// <remarks/>
        T,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoIdDocIndServicio {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoIdDocMntBruto {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }




    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoIdDocFmaPago {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoIdDocMntPagos {

        private System.DateTime fchPagoField;

        private string mntPagoField;

        private string glosaPagosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FchPago {
            get {
                return this.fchPagoField;
            }
            set {
                this.fchPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string MntPago {
            get {
                return this.mntPagoField;
            }
            set {
                this.mntPagoField = value;
            }
        }

        /// <remarks/>
        public string GlosaPagos {
            get {
                return this.glosaPagosField;
            }
            set {
                this.glosaPagosField = value;
            }
        }
    }





    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoIdDocTpoCtaPago {

        /// <remarks/>
        AHORRO,

        /// <remarks/>
        CORRIENTE,

        /// <remarks/>
        VISTA,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoIdDocTipoFactEsp {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoEmisor {

        private string rUTEmisorField;

        private string rznSocField;

        private string giroEmisField;

        private string[] telefonoField;

        private string correoEmisorField;

        private string[] actecoField;

        private DTEDefTypeDocumentoEncabezadoEmisorGuiaExport guiaExportField;

        private string sucursalField;

        private string cdgSIISucurField;

        private string dirOrigenField;

        private string cmnaOrigenField;

        private string ciudadOrigenField;

        private string cdgVendedorField;

        private string idAdicEmisorField;

        private string rUTProveedorField;

        private string rznSocProveedorField;

        /// <remarks/>
        public string RUTEmisor {
            get {
                return this.rUTEmisorField;
            }
            set {
                this.rUTEmisorField = value;
            }
        }

        /// <remarks/>
        public string RznSoc {
            get {
                return this.rznSocField;
            }
            set {
                this.rznSocField = value;
            }
        }

        /// <remarks/>
        public string GiroEmis {
            get {
                return this.giroEmisField;
            }
            set {
                this.giroEmisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Telefono")]
        public string[] Telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
            }
        }

        /// <remarks/>
        public string CorreoEmisor {
            get {
                return this.correoEmisorField;
            }
            set {
                this.correoEmisorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Acteco", DataType = "positiveInteger")]
        public string[] Acteco {
            get {
                return this.actecoField;
            }
            set {
                this.actecoField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoEmisorGuiaExport GuiaExport {
            get {
                return this.guiaExportField;
            }
            set {
                this.guiaExportField = value;
            }
        }

        /// <remarks/>
        public string Sucursal {
            get {
                return this.sucursalField;
            }
            set {
                this.sucursalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CdgSIISucur {
            get {
                return this.cdgSIISucurField;
            }
            set {
                this.cdgSIISucurField = value;
            }
        }

        /// <remarks/>
        public string DirOrigen {
            get {
                return this.dirOrigenField;
            }
            set {
                this.dirOrigenField = value;
            }
        }

        /// <remarks/>
        public string CmnaOrigen {
            get {
                return this.cmnaOrigenField;
            }
            set {
                this.cmnaOrigenField = value;
            }
        }

        /// <remarks/>
        public string CiudadOrigen {
            get {
                return this.ciudadOrigenField;
            }
            set {
                this.ciudadOrigenField = value;
            }
        }

        /// <remarks/>
        public string CdgVendedor {
            get {
                return this.cdgVendedorField;
            }
            set {
                this.cdgVendedorField = value;
            }
        }

        /// <remarks/>
        public string IdAdicEmisor {
            get {
                return this.idAdicEmisorField;
            }
            set {
                this.idAdicEmisorField = value;
            }
        }

        /// <remarks/>
        public string RUTProveedor {
            get {
                return this.rUTProveedorField;
            }
            set {
                this.rUTProveedorField = value;
            }
        }

        /// <remarks/>
        public string RznSocProveedor {
            get {
                return this.rznSocProveedorField;
            }
            set {
                this.rznSocProveedorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoEmisorGuiaExport {

        private DTEDefTypeDocumentoEncabezadoEmisorGuiaExportCdgTraslado cdgTrasladoField;

        private bool cdgTrasladoFieldSpecified;

        private string folioAutField;

        private System.DateTime fchAutField;

        private bool fchAutFieldSpecified;

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoEmisorGuiaExportCdgTraslado CdgTraslado {
            get {
                return this.cdgTrasladoField;
            }
            set {
                this.cdgTrasladoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CdgTrasladoSpecified {
            get {
                return this.cdgTrasladoFieldSpecified;
            }
            set {
                this.cdgTrasladoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string FolioAut {
            get {
                return this.folioAutField;
            }
            set {
                this.folioAutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FchAut {
            get {
                return this.fchAutField;
            }
            set {
                this.fchAutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FchAutSpecified {
            get {
                return this.fchAutFieldSpecified;
            }
            set {
                this.fchAutFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoEmisorGuiaExportCdgTraslado {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoReceptor {

        private string rUTRecepField;

        private string cdgIntRecepField;

        private string rznSocRecepField;

        private DTEDefTypeDocumentoEncabezadoReceptorExtranjero extranjeroField;

        private string giroRecepField;

        private string contactoField;

        private string correoRecepField;

        private string dirRecepField;

        private string cmnaRecepField;

        private string ciudadRecepField;

        private string dirPostalField;

        private string cmnaPostalField;

        private string ciudadPostalField;

        /// <remarks/>
        public string RUTRecep {
            get {
                return this.rUTRecepField;
            }
            set {
                this.rUTRecepField = value;
            }
        }

        /// <remarks/>
        public string CdgIntRecep {
            get {
                return this.cdgIntRecepField;
            }
            set {
                this.cdgIntRecepField = value;
            }
        }

        /// <remarks/>
        public string RznSocRecep {
            get {
                return this.rznSocRecepField;
            }
            set {
                this.rznSocRecepField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoReceptorExtranjero Extranjero {
            get {
                return this.extranjeroField;
            }
            set {
                this.extranjeroField = value;
            }
        }

        /// <remarks/>
        public string GiroRecep {
            get {
                return this.giroRecepField;
            }
            set {
                this.giroRecepField = value;
            }
        }

        /// <remarks/>
        public string Contacto {
            get {
                return this.contactoField;
            }
            set {
                this.contactoField = value;
            }
        }

        /// <remarks/>
        public string CorreoRecep {
            get {
                return this.correoRecepField;
            }
            set {
                this.correoRecepField = value;
            }
        }

        /// <remarks/>
        public string DirRecep {
            get {
                return this.dirRecepField;
            }
            set {
                this.dirRecepField = value;
            }
        }

        /// <remarks/>
        public string CmnaRecep {
            get {
                return this.cmnaRecepField;
            }
            set {
                this.cmnaRecepField = value;
            }
        }

        /// <remarks/>
        public string CiudadRecep {
            get {
                return this.ciudadRecepField;
            }
            set {
                this.ciudadRecepField = value;
            }
        }

        /// <remarks/>
        public string DirPostal {
            get {
                return this.dirPostalField;
            }
            set {
                this.dirPostalField = value;
            }
        }

        /// <remarks/>
        public string CmnaPostal {
            get {
                return this.cmnaPostalField;
            }
            set {
                this.cmnaPostalField = value;
            }
        }

        /// <remarks/>
        public string CiudadPostal {
            get {
                return this.ciudadPostalField;
            }
            set {
                this.ciudadPostalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoReceptorExtranjero {

        private string numIdField;

        private string nacionalidadField;

        private DTEDefTypeDocumentoEncabezadoReceptorExtranjeroTipoDocID tipoDocIDField;

        private bool tipoDocIDFieldSpecified;

        /// <remarks/>
        public string NumId {
            get {
                return this.numIdField;
            }
            set {
                this.numIdField = value;
            }
        }

        /// <remarks/>
        public string Nacionalidad {
            get {
                return this.nacionalidadField;
            }
            set {
                this.nacionalidadField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoReceptorExtranjeroTipoDocID TipoDocID {
            get {
                return this.tipoDocIDField;
            }
            set {
                this.tipoDocIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoDocIDSpecified {
            get {
                return this.tipoDocIDFieldSpecified;
            }
            set {
                this.tipoDocIDFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoEncabezadoReceptorExtranjeroTipoDocID {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoTransporte {

        private string patenteField;

        private string rUTTransField;

        private DTEDefTypeDocumentoEncabezadoTransporteChofer choferField;

        private string dirDestField;

        private string cmnaDestField;

        private string ciudadDestField;

        private DTEDefTypeDocumentoEncabezadoTransporteAduana aduanaField;

        /// <remarks/>
        public string Patente {
            get {
                return this.patenteField;
            }
            set {
                this.patenteField = value;
            }
        }

        /// <remarks/>
        public string RUTTrans {
            get {
                return this.rUTTransField;
            }
            set {
                this.rUTTransField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoTransporteChofer Chofer {
            get {
                return this.choferField;
            }
            set {
                this.choferField = value;
            }
        }

        /// <remarks/>
        public string DirDest {
            get {
                return this.dirDestField;
            }
            set {
                this.dirDestField = value;
            }
        }

        /// <remarks/>
        public string CmnaDest {
            get {
                return this.cmnaDestField;
            }
            set {
                this.cmnaDestField = value;
            }
        }

        /// <remarks/>
        public string CiudadDest {
            get {
                return this.ciudadDestField;
            }
            set {
                this.ciudadDestField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoTransporteAduana Aduana {
            get {
                return this.aduanaField;
            }
            set {
                this.aduanaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoTransporteChofer {

        private string rUTChoferField;

        private string nombreChoferField;

        /// <remarks/>
        public string RUTChofer {
            get {
                return this.rUTChoferField;
            }
            set {
                this.rUTChoferField = value;
            }
        }

        /// <remarks/>
        public string NombreChofer {
            get {
                return this.nombreChoferField;
            }
            set {
                this.nombreChoferField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoTransporteAduana {

        private string codModVentaField;

        private string codClauVentaField;

        private decimal totClauVentaField;

        private bool totClauVentaFieldSpecified;

        private string codViaTranspField;

        private string nombreTranspField;

        private string rUTCiaTranspField;

        private string nomCiaTranspField;

        private string idAdicTranspField;

        private string bookingField;

        private string operadorField;

        private string codPtoEmbarqueField;

        private string idAdicPtoEmbField;

        private string codPtoDesembField;

        private string idAdicPtoDesembField;

        private string taraField;

        private string codUnidMedTaraField;

        private decimal pesoBrutoField;

        private bool pesoBrutoFieldSpecified;

        private string codUnidPesoBrutoField;

        private decimal pesoNetoField;

        private bool pesoNetoFieldSpecified;

        private string codUnidPesoNetoField;

        private string totItemsField;

        private string totBultosField;

        private DTEDefTypeDocumentoEncabezadoTransporteAduanaTipoBultos[] tipoBultosField;

        private decimal mntFleteField;

        private bool mntFleteFieldSpecified;

        private decimal mntSeguroField;

        private bool mntSeguroFieldSpecified;

        private string codPaisRecepField;

        private string codPaisDestinField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodModVenta {
            get {
                return this.codModVentaField;
            }
            set {
                this.codModVentaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodClauVenta {
            get {
                return this.codClauVentaField;
            }
            set {
                this.codClauVentaField = value;
            }
        }

        /// <remarks/>
        public decimal TotClauVenta {
            get {
                return this.totClauVentaField;
            }
            set {
                this.totClauVentaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotClauVentaSpecified {
            get {
                return this.totClauVentaFieldSpecified;
            }
            set {
                this.totClauVentaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodViaTransp {
            get {
                return this.codViaTranspField;
            }
            set {
                this.codViaTranspField = value;
            }
        }

        /// <remarks/>
        public string NombreTransp {
            get {
                return this.nombreTranspField;
            }
            set {
                this.nombreTranspField = value;
            }
        }

        /// <remarks/>
        public string RUTCiaTransp {
            get {
                return this.rUTCiaTranspField;
            }
            set {
                this.rUTCiaTranspField = value;
            }
        }

        /// <remarks/>
        public string NomCiaTransp {
            get {
                return this.nomCiaTranspField;
            }
            set {
                this.nomCiaTranspField = value;
            }
        }

        /// <remarks/>
        public string IdAdicTransp {
            get {
                return this.idAdicTranspField;
            }
            set {
                this.idAdicTranspField = value;
            }
        }

        /// <remarks/>
        public string Booking {
            get {
                return this.bookingField;
            }
            set {
                this.bookingField = value;
            }
        }

        /// <remarks/>
        public string Operador {
            get {
                return this.operadorField;
            }
            set {
                this.operadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodPtoEmbarque {
            get {
                return this.codPtoEmbarqueField;
            }
            set {
                this.codPtoEmbarqueField = value;
            }
        }

        /// <remarks/>
        public string IdAdicPtoEmb {
            get {
                return this.idAdicPtoEmbField;
            }
            set {
                this.idAdicPtoEmbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodPtoDesemb {
            get {
                return this.codPtoDesembField;
            }
            set {
                this.codPtoDesembField = value;
            }
        }

        /// <remarks/>
        public string IdAdicPtoDesemb {
            get {
                return this.idAdicPtoDesembField;
            }
            set {
                this.idAdicPtoDesembField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string Tara {
            get {
                return this.taraField;
            }
            set {
                this.taraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodUnidMedTara {
            get {
                return this.codUnidMedTaraField;
            }
            set {
                this.codUnidMedTaraField = value;
            }
        }

        /// <remarks/>
        public decimal PesoBruto {
            get {
                return this.pesoBrutoField;
            }
            set {
                this.pesoBrutoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PesoBrutoSpecified {
            get {
                return this.pesoBrutoFieldSpecified;
            }
            set {
                this.pesoBrutoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodUnidPesoBruto {
            get {
                return this.codUnidPesoBrutoField;
            }
            set {
                this.codUnidPesoBrutoField = value;
            }
        }

        /// <remarks/>
        public decimal PesoNeto {
            get {
                return this.pesoNetoField;
            }
            set {
                this.pesoNetoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PesoNetoSpecified {
            get {
                return this.pesoNetoFieldSpecified;
            }
            set {
                this.pesoNetoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodUnidPesoNeto {
            get {
                return this.codUnidPesoNetoField;
            }
            set {
                this.codUnidPesoNetoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string TotItems {
            get {
                return this.totItemsField;
            }
            set {
                this.totItemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string TotBultos {
            get {
                return this.totBultosField;
            }
            set {
                this.totBultosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TipoBultos")]
        public DTEDefTypeDocumentoEncabezadoTransporteAduanaTipoBultos[] TipoBultos {
            get {
                return this.tipoBultosField;
            }
            set {
                this.tipoBultosField = value;
            }
        }

        /// <remarks/>
        public decimal MntFlete {
            get {
                return this.mntFleteField;
            }
            set {
                this.mntFleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MntFleteSpecified {
            get {
                return this.mntFleteFieldSpecified;
            }
            set {
                this.mntFleteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal MntSeguro {
            get {
                return this.mntSeguroField;
            }
            set {
                this.mntSeguroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MntSeguroSpecified {
            get {
                return this.mntSeguroFieldSpecified;
            }
            set {
                this.mntSeguroFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodPaisRecep {
            get {
                return this.codPaisRecepField;
            }
            set {
                this.codPaisRecepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodPaisDestin {
            get {
                return this.codPaisDestinField;
            }
            set {
                this.codPaisDestinField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoTransporteAduanaTipoBultos {

        private string codTpoBultosField;

        private string cantBultosField;

        private string marcasField;

        private string idContainerField;

        private string selloField;

        private string emisorSelloField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CodTpoBultos {
            get {
                return this.codTpoBultosField;
            }
            set {
                this.codTpoBultosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string CantBultos {
            get {
                return this.cantBultosField;
            }
            set {
                this.cantBultosField = value;
            }
        }

        /// <remarks/>
        public string Marcas {
            get {
                return this.marcasField;
            }
            set {
                this.marcasField = value;
            }
        }

        /// <remarks/>
        public string IdContainer {
            get {
                return this.idContainerField;
            }
            set {
                this.idContainerField = value;
            }
        }

        /// <remarks/>
        public string Sello {
            get {
                return this.selloField;
            }
            set {
                this.selloField = value;
            }
        }

        /// <remarks/>
        public string EmisorSello {
            get {
                return this.emisorSelloField;
            }
            set {
                this.emisorSelloField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoTotales {

        private string mntNetoField;

        private string mntExeField;

        private string mntBaseField;

        private string mntMargenComField;

        private decimal tasaIVAField;

        private bool tasaIVAFieldSpecified;

        private string iVAField;

        private string iVAPropField;

        private string iVATercField;

        private DTEDefTypeDocumentoEncabezadoTotalesImptoReten[] imptoRetenField;

        private string iVANoRetField;

        private string credECField;

        private string grntDepField;

        private DTEDefTypeDocumentoEncabezadoTotalesComisiones comisionesField;

        private string mntTotalField;

        private string montoNFField;

        private string montoPeriodoField;

        private string saldoAnteriorField;

        private string vlrPagarField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string MntNeto {
            get {
                return this.mntNetoField;
            }
            set {
                this.mntNetoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string MntExe {
            get {
                return this.mntExeField;
            }
            set {
                this.mntExeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string MntBase {
            get {
                return this.mntBaseField;
            }
            set {
                this.mntBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string MntMargenCom {
            get {
                return this.mntMargenComField;
            }
            set {
                this.mntMargenComField = value;
            }
        }

        /// <remarks/>
        public decimal TasaIVA {
            get {
                return this.tasaIVAField;
            }
            set {
                this.tasaIVAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TasaIVASpecified {
            get {
                return this.tasaIVAFieldSpecified;
            }
            set {
                this.tasaIVAFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string IVA {
            get {
                return this.iVAField;
            }
            set {
                this.iVAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string IVAProp {
            get {
                return this.iVAPropField;
            }
            set {
                this.iVAPropField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string IVATerc {
            get {
                return this.iVATercField;
            }
            set {
                this.iVATercField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImptoReten")]
        public DTEDefTypeDocumentoEncabezadoTotalesImptoReten[] ImptoReten {
            get {
                return this.imptoRetenField;
            }
            set {
                this.imptoRetenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string IVANoRet {
            get {
                return this.iVANoRetField;
            }
            set {
                this.iVANoRetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string CredEC {
            get {
                return this.credECField;
            }
            set {
                this.credECField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string GrntDep {
            get {
                return this.grntDepField;
            }
            set {
                this.grntDepField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezadoTotalesComisiones Comisiones {
            get {
                return this.comisionesField;
            }
            set {
                this.comisionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string MntTotal {
            get {
                return this.mntTotalField;
            }
            set {
                this.mntTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string MontoNF {
            get {
                return this.montoNFField;
            }
            set {
                this.montoNFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string MontoPeriodo {
            get {
                return this.montoPeriodoField;
            }
            set {
                this.montoPeriodoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string SaldoAnterior {
            get {
                return this.saldoAnteriorField;
            }
            set {
                this.saldoAnteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string VlrPagar {
            get {
                return this.vlrPagarField;
            }
            set {
                this.vlrPagarField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoTotalesImptoReten {

        private ImpAdicDTEType tipoImpField;

        private decimal tasaImpField;

        private bool tasaImpFieldSpecified;

        private string montoImpField;

        /// <remarks/>
        public ImpAdicDTEType TipoImp {
            get {
                return this.tipoImpField;
            }
            set {
                this.tipoImpField = value;
            }
        }

        /// <remarks/>
        public decimal TasaImp {
            get {
                return this.tasaImpField;
            }
            set {
                this.tasaImpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TasaImpSpecified {
            get {
                return this.tasaImpFieldSpecified;
            }
            set {
                this.tasaImpFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string MontoImp {
            get {
                return this.montoImpField;
            }
            set {
                this.montoImpField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoTotalesComisiones {

        private string valComNetoField;

        private string valComExeField;

        private string valComIVAField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string ValComNeto {
            get {
                return this.valComNetoField;
            }
            set {
                this.valComNetoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string ValComExe {
            get {
                return this.valComExeField;
            }
            set {
                this.valComExeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string ValComIVA {
            get {
                return this.valComIVAField;
            }
            set {
                this.valComIVAField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoOtraMoneda {

        private TipMonType tpoMonedaField;

        private decimal tpoCambioField;

        private bool tpoCambioFieldSpecified;

        private decimal mntNetoOtrMndaField;

        private bool mntNetoOtrMndaFieldSpecified;

        private decimal mntExeOtrMndaField;

        private bool mntExeOtrMndaFieldSpecified;

        private decimal mntFaeCarneOtrMndaField;

        private bool mntFaeCarneOtrMndaFieldSpecified;

        private decimal mntMargComOtrMndaField;

        private bool mntMargComOtrMndaFieldSpecified;

        private decimal iVAOtrMndaField;

        private bool iVAOtrMndaFieldSpecified;

        private DTEDefTypeDocumentoEncabezadoOtraMonedaImpRetOtrMnda[] impRetOtrMndaField;

        private decimal iVANoRetOtrMndaField;

        private bool iVANoRetOtrMndaFieldSpecified;

        private decimal mntTotOtrMndaField;

        /// <remarks/>
        public TipMonType TpoMoneda {
            get {
                return this.tpoMonedaField;
            }
            set {
                this.tpoMonedaField = value;
            }
        }

        /// <remarks/>
        public decimal TpoCambio {
            get {
                return this.tpoCambioField;
            }
            set {
                this.tpoCambioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TpoCambioSpecified {
            get {
                return this.tpoCambioFieldSpecified;
            }
            set {
                this.tpoCambioFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal MntNetoOtrMnda {
            get {
                return this.mntNetoOtrMndaField;
            }
            set {
                this.mntNetoOtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MntNetoOtrMndaSpecified {
            get {
                return this.mntNetoOtrMndaFieldSpecified;
            }
            set {
                this.mntNetoOtrMndaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal MntExeOtrMnda {
            get {
                return this.mntExeOtrMndaField;
            }
            set {
                this.mntExeOtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MntExeOtrMndaSpecified {
            get {
                return this.mntExeOtrMndaFieldSpecified;
            }
            set {
                this.mntExeOtrMndaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal MntFaeCarneOtrMnda {
            get {
                return this.mntFaeCarneOtrMndaField;
            }
            set {
                this.mntFaeCarneOtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MntFaeCarneOtrMndaSpecified {
            get {
                return this.mntFaeCarneOtrMndaFieldSpecified;
            }
            set {
                this.mntFaeCarneOtrMndaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal MntMargComOtrMnda {
            get {
                return this.mntMargComOtrMndaField;
            }
            set {
                this.mntMargComOtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MntMargComOtrMndaSpecified {
            get {
                return this.mntMargComOtrMndaFieldSpecified;
            }
            set {
                this.mntMargComOtrMndaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal IVAOtrMnda {
            get {
                return this.iVAOtrMndaField;
            }
            set {
                this.iVAOtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IVAOtrMndaSpecified {
            get {
                return this.iVAOtrMndaFieldSpecified;
            }
            set {
                this.iVAOtrMndaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImpRetOtrMnda")]
        public DTEDefTypeDocumentoEncabezadoOtraMonedaImpRetOtrMnda[] ImpRetOtrMnda {
            get {
                return this.impRetOtrMndaField;
            }
            set {
                this.impRetOtrMndaField = value;
            }
        }

        /// <remarks/>
        public decimal IVANoRetOtrMnda {
            get {
                return this.iVANoRetOtrMndaField;
            }
            set {
                this.iVANoRetOtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IVANoRetOtrMndaSpecified {
            get {
                return this.iVANoRetOtrMndaFieldSpecified;
            }
            set {
                this.iVANoRetOtrMndaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal MntTotOtrMnda {
            get {
                return this.mntTotOtrMndaField;
            }
            set {
                this.mntTotOtrMndaField = value;
            }
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoEncabezadoOtraMonedaImpRetOtrMnda {

        private ImpAdicDTEType tipoImpOtrMndaField;

        private decimal tasaImpOtrMndaField;

        private bool tasaImpOtrMndaFieldSpecified;

        private decimal vlrImpOtrMndaField;

        /// <remarks/>
        public ImpAdicDTEType TipoImpOtrMnda {
            get {
                return this.tipoImpOtrMndaField;
            }
            set {
                this.tipoImpOtrMndaField = value;
            }
        }

        /// <remarks/>
        public decimal TasaImpOtrMnda {
            get {
                return this.tasaImpOtrMndaField;
            }
            set {
                this.tasaImpOtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TasaImpOtrMndaSpecified {
            get {
                return this.tasaImpOtrMndaFieldSpecified;
            }
            set {
                this.tasaImpOtrMndaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal VlrImpOtrMnda {
            get {
                return this.vlrImpOtrMndaField;
            }
            set {
                this.vlrImpOtrMndaField = value;
            }
        }
    }

}
