﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientReservasi_20190140015.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CekLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class CekLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string deskripsiSingkatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaLokasiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string deskripsiSingkat {
            get {
                return this.deskripsiSingkatField;
            }
            set {
                if ((object.ReferenceEquals(this.deskripsiSingkatField, value) != true)) {
                    this.deskripsiSingkatField = value;
                    this.RaisePropertyChanged("deskripsiSingkat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idLokasi {
            get {
                return this.idLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.idLokasiField, value) != true)) {
                    this.idLokasiField = value;
                    this.RaisePropertyChanged("idLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string namaLokasi {
            get {
                return this.namaLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.namaLokasiField, value) != true)) {
                    this.namaLokasiField = value;
                    this.RaisePropertyChanged("namaLokasi");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class DetailLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string deskripsiFullField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int kuotaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaLokasiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string deskripsiFull {
            get {
                return this.deskripsiFullField;
            }
            set {
                if ((object.ReferenceEquals(this.deskripsiFullField, value) != true)) {
                    this.deskripsiFullField = value;
                    this.RaisePropertyChanged("deskripsiFull");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idLokasi {
            get {
                return this.idLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.idLokasiField, value) != true)) {
                    this.idLokasiField = value;
                    this.RaisePropertyChanged("idLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int kuota {
            get {
                return this.kuotaField;
            }
            set {
                if ((this.kuotaField.Equals(value) != true)) {
                    this.kuotaField = value;
                    this.RaisePropertyChanged("kuota");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string namaLokasi {
            get {
                return this.namaLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.namaLokasiField, value) != true)) {
                    this.namaLokasiField = value;
                    this.RaisePropertyChanged("namaLokasi");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pemesanan", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class Pemesanan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idPemesananField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int jumlahPemesananField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaCustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noTeleponField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lokasi {
            get {
                return this.LokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.LokasiField, value) != true)) {
                    this.LokasiField = value;
                    this.RaisePropertyChanged("Lokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idPemesanan {
            get {
                return this.idPemesananField;
            }
            set {
                if ((object.ReferenceEquals(this.idPemesananField, value) != true)) {
                    this.idPemesananField = value;
                    this.RaisePropertyChanged("idPemesanan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int jumlahPemesanan {
            get {
                return this.jumlahPemesananField;
            }
            set {
                if ((this.jumlahPemesananField.Equals(value) != true)) {
                    this.jumlahPemesananField = value;
                    this.RaisePropertyChanged("jumlahPemesanan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string namaCustomer {
            get {
                return this.namaCustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.namaCustomerField, value) != true)) {
                    this.namaCustomerField = value;
                    this.RaisePropertyChanged("namaCustomer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string noTelepon {
            get {
                return this.noTeleponField;
            }
            set {
                if ((object.ReferenceEquals(this.noTeleponField, value) != true)) {
                    this.noTeleponField = value;
                    this.RaisePropertyChanged("noTelepon");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        string pemesanan(string idPemesanan, string namaCustomer, string noTelepon, int jumlahPemesanan, string idLokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        System.Threading.Tasks.Task<string> pemesananAsync(string idPemesanan, string namaCustomer, string noTelepon, int jumlahPemesanan, string idLokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        string editPemesanan(string idPemesanan, string namaCustomer, string noTelepon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        System.Threading.Tasks.Task<string> editPemesananAsync(string idPemesanan, string namaCustomer, string noTelepon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        string deletePemesanan(string idPemesanan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        System.Threading.Tasks.Task<string> deletePemesananAsync(string idPemesanan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        ClientReservasi_20190140015.ServiceReference1.CekLokasi[] ReviewLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        System.Threading.Tasks.Task<ClientReservasi_20190140015.ServiceReference1.CekLokasi[]> ReviewLokasiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        ClientReservasi_20190140015.ServiceReference1.DetailLokasi[] DetailLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        System.Threading.Tasks.Task<ClientReservasi_20190140015.ServiceReference1.DetailLokasi[]> DetailLokasiAsync();
        
        // CODEGEN: Generating message contract since the wrapper name (Pemesanan) of message PemesananRequest does not match the default value (Pemesanan1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        ClientReservasi_20190140015.ServiceReference1.PemesananResponse Pemesanan1(ClientReservasi_20190140015.ServiceReference1.PemesananRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        System.Threading.Tasks.Task<ClientReservasi_20190140015.ServiceReference1.PemesananResponse> Pemesanan1Async(ClientReservasi_20190140015.ServiceReference1.PemesananRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Pemesanan", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananRequest {
        
        public PemesananRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PemesananResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ClientReservasi_20190140015.ServiceReference1.Pemesanan[] PemesananResult;
        
        public PemesananResponse() {
        }
        
        public PemesananResponse(ClientReservasi_20190140015.ServiceReference1.Pemesanan[] PemesananResult) {
            this.PemesananResult = PemesananResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientReservasi_20190140015.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientReservasi_20190140015.ServiceReference1.IService1>, ClientReservasi_20190140015.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string pemesanan(string idPemesanan, string namaCustomer, string noTelepon, int jumlahPemesanan, string idLokasi) {
            return base.Channel.pemesanan(idPemesanan, namaCustomer, noTelepon, jumlahPemesanan, idLokasi);
        }
        
        public System.Threading.Tasks.Task<string> pemesananAsync(string idPemesanan, string namaCustomer, string noTelepon, int jumlahPemesanan, string idLokasi) {
            return base.Channel.pemesananAsync(idPemesanan, namaCustomer, noTelepon, jumlahPemesanan, idLokasi);
        }
        
        public string editPemesanan(string idPemesanan, string namaCustomer, string noTelepon) {
            return base.Channel.editPemesanan(idPemesanan, namaCustomer, noTelepon);
        }
        
        public System.Threading.Tasks.Task<string> editPemesananAsync(string idPemesanan, string namaCustomer, string noTelepon) {
            return base.Channel.editPemesananAsync(idPemesanan, namaCustomer, noTelepon);
        }
        
        public string deletePemesanan(string idPemesanan) {
            return base.Channel.deletePemesanan(idPemesanan);
        }
        
        public System.Threading.Tasks.Task<string> deletePemesananAsync(string idPemesanan) {
            return base.Channel.deletePemesananAsync(idPemesanan);
        }
        
        public ClientReservasi_20190140015.ServiceReference1.CekLokasi[] ReviewLokasi() {
            return base.Channel.ReviewLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_20190140015.ServiceReference1.CekLokasi[]> ReviewLokasiAsync() {
            return base.Channel.ReviewLokasiAsync();
        }
        
        public ClientReservasi_20190140015.ServiceReference1.DetailLokasi[] DetailLokasi() {
            return base.Channel.DetailLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_20190140015.ServiceReference1.DetailLokasi[]> DetailLokasiAsync() {
            return base.Channel.DetailLokasiAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientReservasi_20190140015.ServiceReference1.PemesananResponse ClientReservasi_20190140015.ServiceReference1.IService1.Pemesanan1(ClientReservasi_20190140015.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1(request);
        }
        
        public ClientReservasi_20190140015.ServiceReference1.Pemesanan[] Pemesanan1() {
            ClientReservasi_20190140015.ServiceReference1.PemesananRequest inValue = new ClientReservasi_20190140015.ServiceReference1.PemesananRequest();
            ClientReservasi_20190140015.ServiceReference1.PemesananResponse retVal = ((ClientReservasi_20190140015.ServiceReference1.IService1)(this)).Pemesanan1(inValue);
            return retVal.PemesananResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientReservasi_20190140015.ServiceReference1.PemesananResponse> ClientReservasi_20190140015.ServiceReference1.IService1.Pemesanan1Async(ClientReservasi_20190140015.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1Async(request);
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_20190140015.ServiceReference1.PemesananResponse> Pemesanan1Async() {
            ClientReservasi_20190140015.ServiceReference1.PemesananRequest inValue = new ClientReservasi_20190140015.ServiceReference1.PemesananRequest();
            return ((ClientReservasi_20190140015.ServiceReference1.IService1)(this)).Pemesanan1Async(inValue);
        }
    }
}
