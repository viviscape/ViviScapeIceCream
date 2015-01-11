using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ViviScapeIceCream
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iapiservice2" in both code and config file together.
    [ServiceContract]
    public interface Iapiservice2
    {
        [OperationContract]
        void DoWork();
    }
}
