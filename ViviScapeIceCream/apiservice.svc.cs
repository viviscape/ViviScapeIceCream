using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ViviScapeIceCream.models;

namespace ViviScapeIceCream
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "apiservice" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select apiservice.svc or apiservice.svc.cs at the Solution Explorer and start debugging.
    public class apiservice : Iapiservice
    {
        public List<flavor> getActiveFlavors()
        {
            List<flavor> flavors = new List<flavor>();
            //Connect to the DB using Entity Framewore to get all active flavors
            //update flavors list
            using (ViviScapeIceCreamEntities db = new ViviScapeIceCreamEntities())
            {


                var data = db.Flavors.Where(w => w.bitDiscontinued == false).ToList();


                flavors = data.Select(f => new flavor()
                {
                    flavor_name = f.strFlavor,
                    cost = f.decCost ?? 0, //metric
                    price = f.decPrice ?? 0,//metric
                    stock = f.decStock ?? 0,
                    flavor_id = f.intFlavorID,
                    discontinued = f.bitDiscontinued ?? false,
                    featured = f.bitFeatured ?? false


                }).ToList();

            }


            //return list of flavors
            return flavors;

        }
        public List<flavor> getActiveFlavorsXml()
        {
            List<flavor> flavors = new List<flavor>();
            //Connect to the DB using Entity Framewore to get all active flavors
            //update flavors list

            using (ViviScapeIceCreamEntities db = new ViviScapeIceCreamEntities())
            {


                var data = db.Flavors.Where(w => w.bitDiscontinued == false).ToList();


                flavors = data.Select(f => new flavor()
                {
                    flavor_name = f.strFlavor,
                    cost = f.decCost ?? 0, //metric
                    price = f.decPrice ?? 0,//metric
                    stock = f.decStock ?? 0,
                    flavor_id = f.intFlavorID,
                    discontinued = f.bitDiscontinued ?? false,
                    featured = f.bitFeatured ?? false


                }).ToList();

            }


            //return list of flavors
            return flavors;

        }
    }
}
