﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PocSII.DteProcessor.Enums;
using PocSII.DteProcessor.Entities;
using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sii.cl/SiiDte")]
public partial class DTEDefTypeDocumentoTED {
    
    private DTEDefTypeDocumentoTEDDD ddField;
    
    private DTEDefTypeDocumentoTEDFRMT fRMTField;
    
    private string versionField;
    
    public DTEDefTypeDocumentoTED() {
        this.versionField = "1.0";
    }
    
    /// <remarks/>
    public DTEDefTypeDocumentoTEDDD DD {
        get {
            return this.ddField;
        }
        set {
            this.ddField = value;
        }
    }
    
    /// <remarks/>
    public DTEDefTypeDocumentoTEDFRMT FRMT {
        get {
            return this.fRMTField;
        }
        set {
            this.fRMTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sii.cl/SiiDte")]
public partial class DTEDefTypeDocumentoTEDDD {
    
    private string reField;
    
    private DTEType tdField;
    
    private string fField;
    
    private System.DateTime feField;
    
    private string rrField;
    
    private string rSRField;
    
    private decimal mNTField;
    
    private string iT1Field;
    
    private DTEDefTypeDocumentoTEDDDCAF cAFField;
    
    private System.DateTime tSTEDField;
    
    /// <remarks/>
    public string RE {
        get {
            return this.reField;
        }
        set {
            this.reField = value;
        }
    }
    
    /// <remarks/>
    public DTEType TD {
        get {
            return this.tdField;
        }
        set {
            this.tdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string F {
        get {
            return this.fField;
        }
        set {
            this.fField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime FE {
        get {
            return this.feField;
        }
        set {
            this.feField = value;
        }
    }
    
    /// <remarks/>
    public string RR {
        get {
            return this.rrField;
        }
        set {
            this.rrField = value;
        }
    }
    
    /// <remarks/>
    public string RSR {
        get {
            return this.rSRField;
        }
        set {
            this.rSRField = value;
        }
    }
    
    /// <remarks/>
    public decimal MNT {
        get {
            return this.mNTField;
        }
        set {
            this.mNTField = value;
        }
    }
    
    /// <remarks/>
    public string IT1 {
        get {
            return this.iT1Field;
        }
        set {
            this.iT1Field = value;
        }
    }
    
    /// <remarks/>
    public DTEDefTypeDocumentoTEDDDCAF CAF {
        get {
            return this.cAFField;
        }
        set {
            this.cAFField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime TSTED {
        get {
            return this.tSTEDField;
        }
        set {
            this.tSTEDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sii.cl/SiiDte")]
public partial class DTEDefTypeDocumentoTEDDDCAF {
    
    private DTEDefTypeDocumentoTEDDDCAFDA daField;
    
    private DTEDefTypeDocumentoTEDDDCAFFRMA fRMAField;
    
    private string versionField;
    
    public DTEDefTypeDocumentoTEDDDCAF() {
        this.versionField = "1.0";
    }
    
    /// <remarks/>
    public DTEDefTypeDocumentoTEDDDCAFDA DA {
        get {
            return this.daField;
        }
        set {
            this.daField = value;
        }
    }
    
    /// <remarks/>
    public DTEDefTypeDocumentoTEDDDCAFFRMA FRMA {
        get {
            return this.fRMAField;
        }
        set {
            this.fRMAField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sii.cl/SiiDte")]
public partial class DTEDefTypeDocumentoTEDDDCAFDA {
    
    private string reField;
    
    private string rsField;
    
    private DTEType tdField;
    
    private DTEDefTypeDocumentoTEDDDCAFDARNG rNGField;
    
    private System.DateTime faField;
    
    private object itemField;
    
    private long iDKField;
    
    /// <remarks/>
    public string RE {
        get {
            return this.reField;
        }
        set {
            this.reField = value;
        }
    }
    
    /// <remarks/>
    public string RS {
        get {
            return this.rsField;
        }
        set {
            this.rsField = value;
        }
    }
    
    /// <remarks/>
    public DTEType TD {
        get {
            return this.tdField;
        }
        set {
            this.tdField = value;
        }
    }
    
    /// <remarks/>
    public DTEDefTypeDocumentoTEDDDCAFDARNG RNG {
        get {
            return this.rNGField;
        }
        set {
            this.rNGField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime FA {
        get {
            return this.faField;
        }
        set {
            this.faField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DSAPK", typeof(DTEDefTypeDocumentoTEDDDCAFDADSAPK))]
    [System.Xml.Serialization.XmlElementAttribute("RSAPK", typeof(DTEDefTypeDocumentoTEDDDCAFDARSAPK))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    public long IDK {
        get {
            return this.iDKField;
        }
        set {
            this.iDKField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sii.cl/SiiDte")]
public partial class DTEDefTypeDocumentoTEDDDCAFDARNG {
    
    private string dField;
    
    private string hField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string D {
        get {
            return this.dField;
        }
        set {
            this.dField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
    public string H {
        get {
            return this.hField;
        }
        set {
            this.hField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sii.cl/SiiDte")]
public partial class DTEDefTypeDocumentoTEDDDCAFDADSAPK {
    
    private byte[] pField;
    
    private byte[] qField;
    
    private byte[] gField;
    
    private byte[] yField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] P {
        get {
            return this.pField;
        }
        set {
            this.pField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Q {
        get {
            return this.qField;
        }
        set {
            this.qField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] G {
        get {
            return this.gField;
        }
        set {
            this.gField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Y {
        get {
            return this.yField;
        }
        set {
            this.yField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sii.cl/SiiDte")]
public partial class DTEDefTypeDocumentoTEDDDCAFDARSAPK {
    
    private byte[] mField;
    
    private byte[] eField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] M {
        get {
            return this.mField;
        }
        set {
            this.mField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] E {
        get {
            return this.eField;
        }
        set {
            this.eField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sii.cl/SiiDte")]
public partial class DTEDefTypeDocumentoTEDDDCAFFRMA {
    
    private string algoritmoField;
    
    private byte[] valueField;
    
    public DTEDefTypeDocumentoTEDDDCAFFRMA() {
        this.algoritmoField = "SHA1withRSA";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string algoritmo {
        get {
            return this.algoritmoField;
        }
        set {
            this.algoritmoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
    public byte[] Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sii.cl/SiiDte")]
public partial class DTEDefTypeDocumentoTEDFRMT {
    
    private DTEDefTypeDocumentoTEDFRMTAlgoritmo algoritmoField;
    
    private byte[] valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DTEDefTypeDocumentoTEDFRMTAlgoritmo algoritmo {
        get {
            return this.algoritmoField;
        }
        set {
            this.algoritmoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
    public byte[] Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sii.cl/SiiDte")]
public enum DTEDefTypeDocumentoTEDFRMTAlgoritmo {
    
    /// <remarks/>
    SHA1withRSA,
    
    /// <remarks/>
    SHA1withDSA,
}











