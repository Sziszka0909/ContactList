using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ThirdWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyService" in both code and config file together.
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string Message();

        [OperationContract]
        bool Login(string username, string password);

        [OperationContract]
        void Logout(string username);

        [OperationContract]
        string addContact(string username, string phonenumber);

        [OperationContract]
        string deleteContact(string username);

        [OperationContract]
        Dictionary<string,string> showContact();

    }
}
