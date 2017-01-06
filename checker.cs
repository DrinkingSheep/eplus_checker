using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace checker
{
    class Program
    {
        static void Main(string[] args)
        {

            //사이트:http://north2.eplus.jp/sys/main.jsp?uji.verb=GGWP01_mousikomi&uji.bean=B.apl.web.JOAB070100Bean&uketsukeInfoKubun=001&ZScreenId=GGWA01&_ga=1.177094496.435414153.1483601896

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://north2.eplus.jp/sys/main.jsp?uji.verb=GGWP01_mousikomi&uji.bean=B.apl.web.JOAB070100Bean&uketsukeInfoKubun=001&ZScreenId=GGWA01&_ga=1.177094496.435414153.1483601896"); req.Method = "Post";

            string s = "Username=junsu&Password=test";  //아이디와 패스워드를 string으로 저장.

            // input 태크 항목을 참조할 것.
            req.CookieContainer = new CookieContainer();
            req.ContentLength = s.Length;
            req.ContentType = "application/x-www-form-urlencoded";
            TextWriter w = (TextWriter)new System.IO.StreamWriter(req.GetRequestStream());

            
            w.Write(s); w.Close();





            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            TextReader r = (TextReader)new StreamReader(resp.GetResponseStream());
            Console.WriteLine(r.ReadToEnd());


       
        }
    }
}
