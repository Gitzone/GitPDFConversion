﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDFConversionAPP.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        PDFConversionAPP.ServiceReference1.HelloWorldResponse HelloWorld(PDFConversionAPP.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.HelloWorldResponse> HelloWorldAsync(PDFConversionAPP.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name Type from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertTOPdf", ReplyAction="*")]
        PDFConversionAPP.ServiceReference1.ConvertTOPdfResponse ConvertTOPdf(PDFConversionAPP.ServiceReference1.ConvertTOPdfRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertTOPdf", ReplyAction="*")]
        System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.ConvertTOPdfResponse> ConvertTOPdfAsync(PDFConversionAPP.ServiceReference1.ConvertTOPdfRequest request);
        
        // CODEGEN: Generating message contract since element name docbinaryarray from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveDocument", ReplyAction="*")]
        PDFConversionAPP.ServiceReference1.SaveDocumentResponse SaveDocument(PDFConversionAPP.ServiceReference1.SaveDocumentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveDocument", ReplyAction="*")]
        System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.SaveDocumentResponse> SaveDocumentAsync(PDFConversionAPP.ServiceReference1.SaveDocumentRequest request);
        
        // CODEGEN: Generating message contract since element name MergDocumentsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MergDocuments", ReplyAction="*")]
        PDFConversionAPP.ServiceReference1.MergDocumentsResponse MergDocuments(PDFConversionAPP.ServiceReference1.MergDocumentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MergDocuments", ReplyAction="*")]
        System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.MergDocumentsResponse> MergDocumentsAsync(PDFConversionAPP.ServiceReference1.MergDocumentsRequest request);
        
        // CODEGEN: Generating message contract since element name DocumentName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDocumentLen", ReplyAction="*")]
        PDFConversionAPP.ServiceReference1.GetDocumentLenResponse GetDocumentLen(PDFConversionAPP.ServiceReference1.GetDocumentLenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDocumentLen", ReplyAction="*")]
        System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.GetDocumentLenResponse> GetDocumentLenAsync(PDFConversionAPP.ServiceReference1.GetDocumentLenRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public PDFConversionAPP.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(PDFConversionAPP.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public PDFConversionAPP.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(PDFConversionAPP.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertTOPdfRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertTOPdf", Namespace="http://tempuri.org/", Order=0)]
        public PDFConversionAPP.ServiceReference1.ConvertTOPdfRequestBody Body;
        
        public ConvertTOPdfRequest() {
        }
        
        public ConvertTOPdfRequest(PDFConversionAPP.ServiceReference1.ConvertTOPdfRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertTOPdfRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Type;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sourcePath;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ExportPath;
        
        public ConvertTOPdfRequestBody() {
        }
        
        public ConvertTOPdfRequestBody(string Type, string sourcePath, string ExportPath) {
            this.Type = Type;
            this.sourcePath = sourcePath;
            this.ExportPath = ExportPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertTOPdfResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertTOPdfResponse", Namespace="http://tempuri.org/", Order=0)]
        public PDFConversionAPP.ServiceReference1.ConvertTOPdfResponseBody Body;
        
        public ConvertTOPdfResponse() {
        }
        
        public ConvertTOPdfResponse(PDFConversionAPP.ServiceReference1.ConvertTOPdfResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ConvertTOPdfResponseBody {
        
        public ConvertTOPdfResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveDocumentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveDocument", Namespace="http://tempuri.org/", Order=0)]
        public PDFConversionAPP.ServiceReference1.SaveDocumentRequestBody Body;
        
        public SaveDocumentRequest() {
        }
        
        public SaveDocumentRequest(PDFConversionAPP.ServiceReference1.SaveDocumentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveDocumentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] docbinaryarray;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string docname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string docType;
        
        public SaveDocumentRequestBody() {
        }
        
        public SaveDocumentRequestBody(byte[] docbinaryarray, string docname, string docType) {
            this.docbinaryarray = docbinaryarray;
            this.docname = docname;
            this.docType = docType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveDocumentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveDocumentResponse", Namespace="http://tempuri.org/", Order=0)]
        public PDFConversionAPP.ServiceReference1.SaveDocumentResponseBody Body;
        
        public SaveDocumentResponse() {
        }
        
        public SaveDocumentResponse(PDFConversionAPP.ServiceReference1.SaveDocumentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveDocumentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool SaveDocumentResult;
        
        public SaveDocumentResponseBody() {
        }
        
        public SaveDocumentResponseBody(bool SaveDocumentResult) {
            this.SaveDocumentResult = SaveDocumentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MergDocumentsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MergDocuments", Namespace="http://tempuri.org/", Order=0)]
        public PDFConversionAPP.ServiceReference1.MergDocumentsRequestBody Body;
        
        public MergDocumentsRequest() {
        }
        
        public MergDocumentsRequest(PDFConversionAPP.ServiceReference1.MergDocumentsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class MergDocumentsRequestBody {
        
        public MergDocumentsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MergDocumentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MergDocumentsResponse", Namespace="http://tempuri.org/", Order=0)]
        public PDFConversionAPP.ServiceReference1.MergDocumentsResponseBody Body;
        
        public MergDocumentsResponse() {
        }
        
        public MergDocumentsResponse(PDFConversionAPP.ServiceReference1.MergDocumentsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MergDocumentsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] MergDocumentsResult;
        
        public MergDocumentsResponseBody() {
        }
        
        public MergDocumentsResponseBody(byte[] MergDocumentsResult) {
            this.MergDocumentsResult = MergDocumentsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDocumentLenRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDocumentLen", Namespace="http://tempuri.org/", Order=0)]
        public PDFConversionAPP.ServiceReference1.GetDocumentLenRequestBody Body;
        
        public GetDocumentLenRequest() {
        }
        
        public GetDocumentLenRequest(PDFConversionAPP.ServiceReference1.GetDocumentLenRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDocumentLenRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DocumentName;
        
        public GetDocumentLenRequestBody() {
        }
        
        public GetDocumentLenRequestBody(string DocumentName) {
            this.DocumentName = DocumentName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDocumentLenResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDocumentLenResponse", Namespace="http://tempuri.org/", Order=0)]
        public PDFConversionAPP.ServiceReference1.GetDocumentLenResponseBody Body;
        
        public GetDocumentLenResponse() {
        }
        
        public GetDocumentLenResponse(PDFConversionAPP.ServiceReference1.GetDocumentLenResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDocumentLenResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int GetDocumentLenResult;
        
        public GetDocumentLenResponseBody() {
        }
        
        public GetDocumentLenResponseBody(int GetDocumentLenResult) {
            this.GetDocumentLenResult = GetDocumentLenResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : PDFConversionAPP.ServiceReference1.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<PDFConversionAPP.ServiceReference1.Service1Soap>, PDFConversionAPP.ServiceReference1.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PDFConversionAPP.ServiceReference1.HelloWorldResponse PDFConversionAPP.ServiceReference1.Service1Soap.HelloWorld(PDFConversionAPP.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            PDFConversionAPP.ServiceReference1.HelloWorldRequest inValue = new PDFConversionAPP.ServiceReference1.HelloWorldRequest();
            inValue.Body = new PDFConversionAPP.ServiceReference1.HelloWorldRequestBody();
            PDFConversionAPP.ServiceReference1.HelloWorldResponse retVal = ((PDFConversionAPP.ServiceReference1.Service1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.HelloWorldResponse> PDFConversionAPP.ServiceReference1.Service1Soap.HelloWorldAsync(PDFConversionAPP.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            PDFConversionAPP.ServiceReference1.HelloWorldRequest inValue = new PDFConversionAPP.ServiceReference1.HelloWorldRequest();
            inValue.Body = new PDFConversionAPP.ServiceReference1.HelloWorldRequestBody();
            return ((PDFConversionAPP.ServiceReference1.Service1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PDFConversionAPP.ServiceReference1.ConvertTOPdfResponse PDFConversionAPP.ServiceReference1.Service1Soap.ConvertTOPdf(PDFConversionAPP.ServiceReference1.ConvertTOPdfRequest request) {
            return base.Channel.ConvertTOPdf(request);
        }
        
        public void ConvertTOPdf(string Type, string sourcePath, string ExportPath) {
            PDFConversionAPP.ServiceReference1.ConvertTOPdfRequest inValue = new PDFConversionAPP.ServiceReference1.ConvertTOPdfRequest();
            inValue.Body = new PDFConversionAPP.ServiceReference1.ConvertTOPdfRequestBody();
            inValue.Body.Type = Type;
            inValue.Body.sourcePath = sourcePath;
            inValue.Body.ExportPath = ExportPath;
            PDFConversionAPP.ServiceReference1.ConvertTOPdfResponse retVal = ((PDFConversionAPP.ServiceReference1.Service1Soap)(this)).ConvertTOPdf(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.ConvertTOPdfResponse> PDFConversionAPP.ServiceReference1.Service1Soap.ConvertTOPdfAsync(PDFConversionAPP.ServiceReference1.ConvertTOPdfRequest request) {
            return base.Channel.ConvertTOPdfAsync(request);
        }
        
        public System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.ConvertTOPdfResponse> ConvertTOPdfAsync(string Type, string sourcePath, string ExportPath) {
            PDFConversionAPP.ServiceReference1.ConvertTOPdfRequest inValue = new PDFConversionAPP.ServiceReference1.ConvertTOPdfRequest();
            inValue.Body = new PDFConversionAPP.ServiceReference1.ConvertTOPdfRequestBody();
            inValue.Body.Type = Type;
            inValue.Body.sourcePath = sourcePath;
            inValue.Body.ExportPath = ExportPath;
            return ((PDFConversionAPP.ServiceReference1.Service1Soap)(this)).ConvertTOPdfAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PDFConversionAPP.ServiceReference1.SaveDocumentResponse PDFConversionAPP.ServiceReference1.Service1Soap.SaveDocument(PDFConversionAPP.ServiceReference1.SaveDocumentRequest request) {
            return base.Channel.SaveDocument(request);
        }
        
        public bool SaveDocument(byte[] docbinaryarray, string docname, string docType) {
            PDFConversionAPP.ServiceReference1.SaveDocumentRequest inValue = new PDFConversionAPP.ServiceReference1.SaveDocumentRequest();
            inValue.Body = new PDFConversionAPP.ServiceReference1.SaveDocumentRequestBody();
            inValue.Body.docbinaryarray = docbinaryarray;
            inValue.Body.docname = docname;
            inValue.Body.docType = docType;
            PDFConversionAPP.ServiceReference1.SaveDocumentResponse retVal = ((PDFConversionAPP.ServiceReference1.Service1Soap)(this)).SaveDocument(inValue);
            return retVal.Body.SaveDocumentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.SaveDocumentResponse> PDFConversionAPP.ServiceReference1.Service1Soap.SaveDocumentAsync(PDFConversionAPP.ServiceReference1.SaveDocumentRequest request) {
            return base.Channel.SaveDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.SaveDocumentResponse> SaveDocumentAsync(byte[] docbinaryarray, string docname, string docType) {
            PDFConversionAPP.ServiceReference1.SaveDocumentRequest inValue = new PDFConversionAPP.ServiceReference1.SaveDocumentRequest();
            inValue.Body = new PDFConversionAPP.ServiceReference1.SaveDocumentRequestBody();
            inValue.Body.docbinaryarray = docbinaryarray;
            inValue.Body.docname = docname;
            inValue.Body.docType = docType;
            return ((PDFConversionAPP.ServiceReference1.Service1Soap)(this)).SaveDocumentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PDFConversionAPP.ServiceReference1.MergDocumentsResponse PDFConversionAPP.ServiceReference1.Service1Soap.MergDocuments(PDFConversionAPP.ServiceReference1.MergDocumentsRequest request) {
            return base.Channel.MergDocuments(request);
        }
        
        public byte[] MergDocuments() {
            PDFConversionAPP.ServiceReference1.MergDocumentsRequest inValue = new PDFConversionAPP.ServiceReference1.MergDocumentsRequest();
            inValue.Body = new PDFConversionAPP.ServiceReference1.MergDocumentsRequestBody();
            PDFConversionAPP.ServiceReference1.MergDocumentsResponse retVal = ((PDFConversionAPP.ServiceReference1.Service1Soap)(this)).MergDocuments(inValue);
            return retVal.Body.MergDocumentsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.MergDocumentsResponse> PDFConversionAPP.ServiceReference1.Service1Soap.MergDocumentsAsync(PDFConversionAPP.ServiceReference1.MergDocumentsRequest request) {
            return base.Channel.MergDocumentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.MergDocumentsResponse> MergDocumentsAsync() {
            PDFConversionAPP.ServiceReference1.MergDocumentsRequest inValue = new PDFConversionAPP.ServiceReference1.MergDocumentsRequest();
            inValue.Body = new PDFConversionAPP.ServiceReference1.MergDocumentsRequestBody();
            return ((PDFConversionAPP.ServiceReference1.Service1Soap)(this)).MergDocumentsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PDFConversionAPP.ServiceReference1.GetDocumentLenResponse PDFConversionAPP.ServiceReference1.Service1Soap.GetDocumentLen(PDFConversionAPP.ServiceReference1.GetDocumentLenRequest request) {
            return base.Channel.GetDocumentLen(request);
        }
        
        public int GetDocumentLen(string DocumentName) {
            PDFConversionAPP.ServiceReference1.GetDocumentLenRequest inValue = new PDFConversionAPP.ServiceReference1.GetDocumentLenRequest();
            inValue.Body = new PDFConversionAPP.ServiceReference1.GetDocumentLenRequestBody();
            inValue.Body.DocumentName = DocumentName;
            PDFConversionAPP.ServiceReference1.GetDocumentLenResponse retVal = ((PDFConversionAPP.ServiceReference1.Service1Soap)(this)).GetDocumentLen(inValue);
            return retVal.Body.GetDocumentLenResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.GetDocumentLenResponse> PDFConversionAPP.ServiceReference1.Service1Soap.GetDocumentLenAsync(PDFConversionAPP.ServiceReference1.GetDocumentLenRequest request) {
            return base.Channel.GetDocumentLenAsync(request);
        }
        
        public System.Threading.Tasks.Task<PDFConversionAPP.ServiceReference1.GetDocumentLenResponse> GetDocumentLenAsync(string DocumentName) {
            PDFConversionAPP.ServiceReference1.GetDocumentLenRequest inValue = new PDFConversionAPP.ServiceReference1.GetDocumentLenRequest();
            inValue.Body = new PDFConversionAPP.ServiceReference1.GetDocumentLenRequestBody();
            inValue.Body.DocumentName = DocumentName;
            return ((PDFConversionAPP.ServiceReference1.Service1Soap)(this)).GetDocumentLenAsync(inValue);
        }
    }
}
