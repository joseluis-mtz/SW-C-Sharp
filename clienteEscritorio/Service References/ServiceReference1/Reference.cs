﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clienteEscritorio.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ventas_articulo", ReplyAction="http://tempuri.org/IService1/ventas_articuloResponse")]
        System.Data.DataSet ventas_articulo(string articulo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ventas_globales", ReplyAction="http://tempuri.org/IService1/ventas_globalesResponse")]
        System.Data.DataSet ventas_globales();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/articulos_mas_vendidos", ReplyAction="http://tempuri.org/IService1/articulos_mas_vendidosResponse")]
        System.Data.DataSet articulos_mas_vendidos(string numero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/productos_existentes", ReplyAction="http://tempuri.org/IService1/productos_existentesResponse")]
        System.Data.DataSet productos_existentes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/notificacion_compra", ReplyAction="http://tempuri.org/IService1/notificacion_compraResponse")]
        System.Data.DataSet notificacion_compra();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : clienteEscritorio.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<clienteEscritorio.ServiceReference1.IService1>, clienteEscritorio.ServiceReference1.IService1 {
        
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
        
        public System.Data.DataSet ventas_articulo(string articulo) {
            return base.Channel.ventas_articulo(articulo);
        }
        
        public System.Data.DataSet ventas_globales() {
            return base.Channel.ventas_globales();
        }
        
        public System.Data.DataSet articulos_mas_vendidos(string numero) {
            return base.Channel.articulos_mas_vendidos(numero);
        }
        
        public System.Data.DataSet productos_existentes() {
            return base.Channel.productos_existentes();
        }
        
        public System.Data.DataSet notificacion_compra() {
            return base.Channel.notificacion_compra();
        }
    }
}
