using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontysFactoryServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HttpServer httpServer;
            httpServer = new FFHTTPServer(8080);
            Thread thread = new Thread(new ThreadStart(httpServer.listen));
            thread.Start();
        }
    }
}
