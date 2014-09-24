using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace FontysFactoryServer
{
    public class FFHTTPServer : HttpServer
    {
        public FFHTTPServer(int port)
            : base(port) {
        }

        public override void handleGETRequest(HttpProcessor p)
        {

        }

        public override void handlePOSTRequest(HttpProcessor p, StreamReader inputData)
        {
            Console.WriteLine("POST request: {0}", p.http_url);
            string data = inputData.ReadToEnd();

            p.writeSuccess();
            p.outputStream.WriteLine("<html><body><h1>test server</h1>");
            p.outputStream.WriteLine("<a href=/test>return</a><p>");
            p.outputStream.WriteLine("postbody: <pre>{0}</pre>", data);
            Console.WriteLine("hasdfasdfasdfa");


        }
    }
}
