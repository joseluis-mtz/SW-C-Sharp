using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace servicioPrueba
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataSet ventas_articulo(string articulo);
        [OperationContract]
        DataSet ventas_globales();
        [OperationContract]
        DataSet articulos_mas_vendidos(string numero);
        [OperationContract]
        DataSet productos_existentes();
        [OperationContract]
        DataSet notificacion_compra();
    }
}
