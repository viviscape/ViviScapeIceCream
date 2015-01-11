using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ViviScapeIceCream.models;

namespace ViviScapeIceCream
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iapiservice" in both code and config file together.
    [ServiceContract]
    public interface Iapiservice
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<flavor> getActiveFlavors();
         
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Xml)]
        List<flavor> getActiveFlavorsXml();
    }
}
