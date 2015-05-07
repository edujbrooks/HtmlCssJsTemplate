using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlCssJsTemplate
{
    public partial class frmMain : Form
    {
       
        public frmMain()
        {
            InitializeComponent();
            lblVersion.Text = webBrowser1.Version.ToString();
            pintarWeb();
        }

        private void txtHtml_TextChanged(object sender, EventArgs e)
        {
            pintarWeb();
        }

        private void txtCss_TextChanged(object sender, EventArgs e)
        {
            pintarWeb();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser1.DocumentText);
            //MessageBox.Show(webBrowser1.Version.ToString());
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(webBrowser1.DocumentText);
        }

        private void btnIe_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("test.htm", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    string fullHTML = cadenaHtml();
                    w.WriteLine(fullHTML);
                }
            }
            System.Diagnostics.Process.Start("test.htm");
        }

        private void pintarWeb()
        {
            string fullHTML = cadenaHtml();
            webBrowser1.DocumentText = fullHTML;
        }

        string cadenaHtml()
        {
            StringBuilder fullHTML = new StringBuilder();
            fullHTML.AppendLine("<!DOCTYPE html>");  //DOCTYPE
            fullHTML.AppendLine("<head>");
            fullHTML.AppendLine("<meta charset='UTF-8'>");
            fullHTML.AppendLine("<title>Title :)</title>");
            fullHTML.AppendLine("<script src='http://code.jquery.com/jquery-1.10.2.js'></script>");
            fullHTML.AppendLine("</head>");
            fullHTML.AppendLine("<html>");
            fullHTML.Append(txtHtml.Text); //HTML
            fullHTML.AppendLine("<style>" + txtCss.Text + "</style>"); //CSS
            if (chkJs.Checked)
            {
                fullHTML.AppendLine("<script>" + txtJs.Text + "</script>"); //JS
            }
            fullHTML.AppendLine("</html>");

            return fullHTML.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pintarWeb();
        }

    }
}
