namespace Message {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://AdvWorks.Messaging.CustomerInfov1.0",@"CustomerInfo")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CustomerInfo"})]
    public sealed class CustomerInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://AdvWorks.Messaging.CustomerInfov1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://AdvWorks.Messaging.CustomerInfov1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CustomerInfo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Residence"" type=""Address"" />
        <xs:element name=""BillingAddress"" type=""Address"" />
        <xs:element minOccurs=""0"" name=""Income"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""MonthlyIncome"">
                <xs:complexType>
                  <xs:attribute name=""Primary"" type=""xs:string"" />
                  <xs:attribute name=""Other"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
            <xs:attribute name=""Employer"" type=""xs:string"" />
            <xs:attribute name=""MonthsEmployed"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""ID"" type=""xs:string"" />
      <xs:attribute name=""CustomerName"" type=""xs:string"" />
      <xs:attribute name=""MonthsAtResidence"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""Address"">
    <xs:sequence>
      <xs:element name=""Street"" type=""xs:string"" />
      <xs:element name=""City"" type=""xs:string"" />
      <xs:element name=""State"" type=""xs:string"" />
      <xs:element name=""PostalCode"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public CustomerInfo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CustomerInfo";
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
