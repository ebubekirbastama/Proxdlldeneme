using SeleniumProxyConnect;
using System;
using System.Windows.Forms;
namespace Proxdlldeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dr = BastamaProxy.Proxyconneciton("", textBox1.Text);
            dr.FindElementByXPath("//span[contains(text(),'ra Bulucu')]").Click();
        }
    }
}
