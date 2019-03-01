using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GladiatusBot
{
    public partial class MainForm : Form
    {

        #region Variables
        TolunayClass tClass = new TolunayClass();
        HtmlDocument webDocument;
        public string creqGet = "GET";
        public string creqPost = "POST";
        public string creqPostData;
        public string responseHtml;
        public string vURL;
        public string loginURL = "https://tr.gladiatus.gameforge.com/game/";
        public string refererURL = "";
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            responseHtml = tClass.creq(loginURL, refererURL, creqPostData, creqPost);
            string respo = responseHtml.Substring(responseHtml.IndexOf("İller"), responseHtml.Length- responseHtml.IndexOf("İller"));
            string p="x";
        }
    }
}
