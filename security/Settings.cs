using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security
{
    public class Settings
    {
        public static string Domain = "http://hehe.com";//Maybe we should encrypt domain but,couldnt it be grabbed easily with fidderl and such?
        public static string Path = "/hue/";
        public static string file = "index.php";

        public static string useragent = "edit_me";
        public static string login = "edit_me"; //this will be like the name of our web value, /index.php?edit_me=username
        public static string password = "edit_me";//same ^
        public static string key = "edit_me"; // this will be our crypt ID
        public static string requestType = "POST"; //get;head;post ???
        

        public static string getServer()
        {
            return string.Format("{0}{1}{2}", Domain, Path,file);
        }

    }
}
