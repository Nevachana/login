using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace security
{
    public class Action
    {
        public string wat;

        public bool login(string username, string password,bool crypt,Key key) // this strings MUST be encrypted so,, we must ask for key in case we use always a random one
        {  //so,, it would be like login("LyOrbyawzjF1/veOj3pBWByAnGwMgqWgwRq6fSgBTkimVnDPGS/m9yvanHj3i","0tYdq2p2sgedxhc+IJHfPzg7k8Lcbjj2FpNiaYGa6spJqMsWZmlALHyruHsZOy3FQAm1ipTVJg3hYPZ/+wes=",our_int);
            //that moment when ur ending the project and find that some parts are dumb
            //OKAY i think this is ok.
            //ADD KEYS AND VALUES TO DICTIONARY
            //First generate a random KEY           
            //after you should crypt your stirngs like string a = security.crypstring(value,key);
            //emh, just login(?)

            if (webrequest(username,password,key))
                return true;
            else
                return false;
                //we will send a requet to w.e/name.php?    name=X    &psw=Y    &key=Z
                //the key will be used when the server decrypts the params so he knows what encryption password "he" has to use.          
        }


        public bool webrequest(string user,string psw,Key key)
        {

                WebClient w = new WebClient();
                w.Headers["User-Agent"] = security.Settings.useragent;
                w.Headers["Content-Type"] = "application/x-www-form-urlencoded";
                Byte[] r = w.UploadValues(security.Settings.getServer(),new NameValueCollection()
       {
           { Settings.login,user },
           { Settings.password,psw },
           { Settings.key,key.VALUE },


       });
                if (procces(Encoding.Default.GetString(r),key))
                    return true;
                else
                    return false;

        }
        public bool procces(string resp,Key key)
        {
            wat = resp;

            switch (Security.Decrypt(resp,key.VALUE,true)) //meh, i dont feel like this part is ok :/
            {
                case "TRUE":
                    return true;
                default:
                    return false;
                
            }
        }
    }
}
