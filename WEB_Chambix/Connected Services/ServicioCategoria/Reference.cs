//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_Chambix.ServicioCategoria {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoriaBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_Chambix")]
    [System.SerializableAttribute()]
    public partial class CategoriaBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime create_atField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string create_byField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short idCategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreCategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime update_atField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string update_byField;
        
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
        public System.DateTime create_at {
            get {
                return this.create_atField;
            }
            set {
                if ((this.create_atField.Equals(value) != true)) {
                    this.create_atField = value;
                    this.RaisePropertyChanged("create_at");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string create_by {
            get {
                return this.create_byField;
            }
            set {
                if ((object.ReferenceEquals(this.create_byField, value) != true)) {
                    this.create_byField = value;
                    this.RaisePropertyChanged("create_by");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short idCategoria {
            get {
                return this.idCategoriaField;
            }
            set {
                if ((this.idCategoriaField.Equals(value) != true)) {
                    this.idCategoriaField = value;
                    this.RaisePropertyChanged("idCategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreCategoria {
            get {
                return this.nombreCategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreCategoriaField, value) != true)) {
                    this.nombreCategoriaField = value;
                    this.RaisePropertyChanged("nombreCategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime update_at {
            get {
                return this.update_atField;
            }
            set {
                if ((this.update_atField.Equals(value) != true)) {
                    this.update_atField = value;
                    this.RaisePropertyChanged("update_at");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string update_by {
            get {
                return this.update_byField;
            }
            set {
                if ((object.ReferenceEquals(this.update_byField, value) != true)) {
                    this.update_byField = value;
                    this.RaisePropertyChanged("update_by");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioCategoria.IServicioCategoria")]
    public interface IServicioCategoria {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCategoria/GetAllCategoria", ReplyAction="http://tempuri.org/IServicioCategoria/GetAllCategoriaResponse")]
        WEB_Chambix.ServicioCategoria.CategoriaBE[] GetAllCategoria();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCategoria/GetAllCategoria", ReplyAction="http://tempuri.org/IServicioCategoria/GetAllCategoriaResponse")]
        System.Threading.Tasks.Task<WEB_Chambix.ServicioCategoria.CategoriaBE[]> GetAllCategoriaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCategoria/InsertCategoria", ReplyAction="http://tempuri.org/IServicioCategoria/InsertCategoriaResponse")]
        bool InsertCategoria(WEB_Chambix.ServicioCategoria.CategoriaBE objcategoriaBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCategoria/InsertCategoria", ReplyAction="http://tempuri.org/IServicioCategoria/InsertCategoriaResponse")]
        System.Threading.Tasks.Task<bool> InsertCategoriaAsync(WEB_Chambix.ServicioCategoria.CategoriaBE objcategoriaBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCategoria/UpdateCategoria", ReplyAction="http://tempuri.org/IServicioCategoria/UpdateCategoriaResponse")]
        bool UpdateCategoria(WEB_Chambix.ServicioCategoria.CategoriaBE objcategoriaBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCategoria/UpdateCategoria", ReplyAction="http://tempuri.org/IServicioCategoria/UpdateCategoriaResponse")]
        System.Threading.Tasks.Task<bool> UpdateCategoriaAsync(WEB_Chambix.ServicioCategoria.CategoriaBE objcategoriaBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCategoria/DeleteCategoria", ReplyAction="http://tempuri.org/IServicioCategoria/DeleteCategoriaResponse")]
        bool DeleteCategoria(short id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCategoria/DeleteCategoria", ReplyAction="http://tempuri.org/IServicioCategoria/DeleteCategoriaResponse")]
        System.Threading.Tasks.Task<bool> DeleteCategoriaAsync(short id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioCategoriaChannel : WEB_Chambix.ServicioCategoria.IServicioCategoria, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioCategoriaClient : System.ServiceModel.ClientBase<WEB_Chambix.ServicioCategoria.IServicioCategoria>, WEB_Chambix.ServicioCategoria.IServicioCategoria {
        
        public ServicioCategoriaClient() {
        }
        
        public ServicioCategoriaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioCategoriaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioCategoriaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioCategoriaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WEB_Chambix.ServicioCategoria.CategoriaBE[] GetAllCategoria() {
            return base.Channel.GetAllCategoria();
        }
        
        public System.Threading.Tasks.Task<WEB_Chambix.ServicioCategoria.CategoriaBE[]> GetAllCategoriaAsync() {
            return base.Channel.GetAllCategoriaAsync();
        }
        
        public bool InsertCategoria(WEB_Chambix.ServicioCategoria.CategoriaBE objcategoriaBE) {
            return base.Channel.InsertCategoria(objcategoriaBE);
        }
        
        public System.Threading.Tasks.Task<bool> InsertCategoriaAsync(WEB_Chambix.ServicioCategoria.CategoriaBE objcategoriaBE) {
            return base.Channel.InsertCategoriaAsync(objcategoriaBE);
        }
        
        public bool UpdateCategoria(WEB_Chambix.ServicioCategoria.CategoriaBE objcategoriaBE) {
            return base.Channel.UpdateCategoria(objcategoriaBE);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateCategoriaAsync(WEB_Chambix.ServicioCategoria.CategoriaBE objcategoriaBE) {
            return base.Channel.UpdateCategoriaAsync(objcategoriaBE);
        }
        
        public bool DeleteCategoria(short id) {
            return base.Channel.DeleteCategoria(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteCategoriaAsync(short id) {
            return base.Channel.DeleteCategoriaAsync(id);
        }
    }
}
