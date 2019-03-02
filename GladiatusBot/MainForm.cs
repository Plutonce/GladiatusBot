using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace GladiatusBot
{
    public partial class MainForm : Form
    {

        #region Variables
        TolunayClass tClass = new TolunayClass();
        HtmlAgilityPack.HtmlDocument webDocument = new HtmlAgilityPack.HtmlDocument();
        public string creqGet = "GET";
        public string creqPost = "POST";
        public string creqPostData;
        public string responseHtml;
        public string[] serverList;
        public string mainURL = "https://tr.gladiatus.gameforge.com/game/";
        public string loginURL;
        public string refererURL = "";
        public string getServer;
        public string cLevel;
        public string cHp;
        public string cExp;
        public string cStrength;
        public string cDexterity;
        public string cAgility;
        public string cConstitution;
        public string cCharisma;
        public string cIntelligence;
        public string cArmor;
        public string cDamage;
        public string cHealing;
        public string[] characterStats;
        public string[] locations;
        public string globalBuff;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Server Combobox
            responseHtml = tClass.creq(mainURL, refererURL, creqPostData, creqPost);
            webDocument.LoadHtml(responseHtml);
            var slist = webDocument.DocumentNode.SelectSingleNode("//optgroup");
            serverList = slist.InnerText.Split('<');
            serverList[0] = serverList[0].Replace("\n", ";").Replace(" ", "");
            serverList[0] = serverList[0].Replace(";;;", "");
            serverList[0] = serverList[0].Replace(";;", ";");
            serverList[0] = serverList[0].Replace("İ", "I");
            serverList = serverList[0].Split(';');
            for (int i = 0; i < serverList.Length - 1; i++)
            {
                cbxServer.Items.Add(serverList[i]);
            }
            #endregion
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region Login
            getServer = cbxServer.Text.Replace("Il", "");
            loginURL = "https://s" + getServer + "-tr.gladiatus.gameforge.com/game/index.php?";
            creqPostData = "mod=start";
            creqPostData += "&submod=login";
            creqPostData += "&name=" + tbxUsername.Text;
            creqPostData += "&pass=" + tbxPass.Text;
            creqPostData += "&login_server=" + loginURL;
            responseHtml = tClass.creq(loginURL, creqPostData, mainURL, creqPost);
            #endregion

            #region Character Stats
            webDocument.LoadHtml(responseHtml);
            var charstats = webDocument.GetElementbyId("charstats").InnerText;
            charstats = charstats.Replace("\r", "");
            charstats = charstats.Replace("\n", ";");
            charstats = charstats.Replace(" ", "");
            charstats=charstats.Replace(";;;;", ";");
            charstats = charstats.Replace(";;;", ";");
            charstats = charstats.Replace(";;", "; ");
            characterStats = charstats.Split(';');
            lblLevel.Text += cLevel = characterStats[2];
            lblHP.Text += cHp = characterStats[4];
            lblExp.Text += cExp = characterStats[6];
            lblStrength.Text += cStrength = characterStats[8];
            lblDexterity.Text += cDexterity = characterStats[10];
            lblAgility.Text += cAgility = characterStats[12];
            lblConstitution.Text += cConstitution = characterStats[14];
            lblCharisma.Text += cCharisma = characterStats[16];
            lblIntelligence.Text += cIntelligence = characterStats[18];
            lblArmor.Text += cArmor = characterStats[20];
            lblDamage.Text += cDamage = characterStats[22];
            lblHealing.Text += cHealing = characterStats[24];
            #endregion

            #region Locations
            var locationsText = webDocument.GetElementbyId("submenu2").InnerText;
            locationsText = locationsText.Replace("\n", ";");
            locationsText = locationsText.Replace("  ", "");
            locationsText = locationsText.Replace(";;;", ";");
            locationsText = locationsText.Replace(";;", ";");
            locationsText = locationsText.Replace("İ", "I").Replace("ğ","G");
            locations = locationsText.Split(';');
            for (int i = 1; i < locations.Length-1; i++)
            {
                cbxLocation.Items.Add(locations[i]);
            }
            #endregion

            #region Get Global Buff
            globalBuff = webDocument.GetElementbyId("globalBuffs").InnerHtml;
            globalBuff = globalBuff.Substring(globalBuff.IndexOf("&sh="), globalBuff.IndexOf("title") - globalBuff.IndexOf("&sh="));
            globalBuff = globalBuff.Replace("&sh=", "");
            globalBuff = globalBuff.Replace("\"", "");
            globalBuff = globalBuff.Replace(" ", "");
            #endregion

        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            var selectedLocation = cbxLocation.SelectedIndex;
            refererURL = "https://s37-tr.gladiatus.gameforge.com/game/index.php?mod=overview&login=1&cnt=0&sh=" +globalBuff;

            if (selectedLocation == 1)
            {
                creqPostData = "mod=location";
                creqPostData += "&loc=0";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(loginURL, creqPostData, refererURL, creqPost);
            }
            else if (selectedLocation == 2)
            {

            }
            else if (selectedLocation == 3)
            {

            }
            else if (selectedLocation == 4)
            {

            }
            else if (selectedLocation == 5)
            {

            }
            else if (selectedLocation == 6)
            {

            }
            else if (selectedLocation == 7)
            {

            }
        }
    }
}
