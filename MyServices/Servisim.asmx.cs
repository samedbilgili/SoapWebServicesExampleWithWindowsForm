using MyModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace MyServices
{
    /// <summary>
    /// Summary description for Servisim
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Servisim : System.Web.Services.WebService
    {
        public UserDetails User;
        Model1 db = new Model1();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [SoapHeader("User", Required = true)]
        public List<urunler> GetProduct()
        {
            if (User.IsValid())
                    return db.urunler.ToList();
                else
                    return null;
            
           
        }
    }

    public class UserDetails : System.Web.Services.Protocols.SoapHeader
    {
        public string userName { get; set; }
        public string password { get; set; }


        public bool IsValid()
        {
          
            return this.userName == "Samed" && this.password == "Bilgili";
          
        }
    }
}
