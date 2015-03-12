using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using log4net;

namespace LogSample
{
    public partial class Form1 : Form
    {
        private ILog logger;

        public Form1()
        {
            InitializeComponent();

            logger = Log.getLogger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logger.Info("Button Clicked!");
        }
    }
}
