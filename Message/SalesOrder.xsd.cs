namespace Message {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Message.SalesOrder",@"SalesOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SalesOrder"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Message.CustomerInfo", typeof(global::Message.CustomerInfo))]
    public sealed class SalesOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Message.SalesOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://AdvWorks.Messaging.CustomerInfov1.0"" targetNamespace=""http://Message.SalesOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Message.CustomerInfo"" namespace=""http://AdvWorks.Messaging.CustomerInfov1.0"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://AdvWorks.Messaging.CustomerInfov1.0"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SalesOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Detail"">
          <xs:complexType>
            <xs:attribute name=""StoreNumber"" type=""xs:string"" />
            <xs:attribute name=""Employee"" type=""xs:string"" />
            <xs:attribute name=""OrderType"" type=""xs:string"" />
            <xs:attribute name=""OrderDate"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
        <xs:element name=""Items"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Item"">
                <xs:complexType>
                  <xs:attribute name=""Qty"" type=""xs:string"" />
                  <xs:attribute name=""SKU"" type=""xs:string"" />
                  <xs:attribute name=""Price"" type=""xs:string"" />
                  <xs:attribute name=""ExtendedPrice"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Comment"" type=""xs:string"" />
        <xs:element name=""OrderTotal"" type=""xs:string"" />
        <xs:element name=""TermOfLoan"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SalesOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SalesOrder";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
