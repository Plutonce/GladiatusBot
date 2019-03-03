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
using System.Runtime.InteropServices;

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
        public int selectedLocation;
        public string combatReport;
        public string attackURL;
        public int minute = 60;
        public int minute10 = 600;
        public int minute2 = 120;
        public int minute5 = 300;
        public Boolean x5Server=false;
        public Boolean centurio=false;
        public Boolean autoAttack = false;

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


            #region Close Attack Button
            btnAttack.Enabled = false;
            #endregion

            #region Close Location Button
            btnSelectLocation.Enabled = false;
            #endregion
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region Login
            if (check5x.Checked == true)
                x5Server = true;
            if (checkCent.Checked == true)
                centurio = true;
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
            charstats = charstats.Replace(";;;;", ";");
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
            locationsText = locationsText.Replace("İ", "I").Replace("ğ", "G");
            locations = locationsText.Split(';');
            for (int i = 1; i < locations.Length - 1; i++)
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

            #region Open Location Button
            btnSelectLocation.Enabled = true;
            #endregion

            ExpeditionPoints(loginURL);

        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            #region GoTo Locations

            selectedLocation = cbxLocation.SelectedIndex;
            refererURL = "https://s" + getServer + "-tr.gladiatus.gameforge.com/game/index.php?mod=overview&login=1&cnt=0&sh=" + globalBuff;

            if (selectedLocation == 1)
            {
                creqPostData = "mod=location";
                creqPostData += "&loc=0";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(loginURL, creqPostData, refererURL, creqPost);
            }
            else if (selectedLocation == 2)
            {
                creqPostData = "mod=location";
                creqPostData += "&loc=1";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(loginURL, creqPostData, refererURL, creqPost);
            }
            else if (selectedLocation == 3)
            {
                creqPostData = "mod=location";
                creqPostData += "&loc=2";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(loginURL, creqPostData, refererURL, creqPost);
            }
            else if (selectedLocation == 4)
            {
                creqPostData = "mod=location";
                creqPostData += "&loc=3";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(loginURL, creqPostData, refererURL, creqPost);
            }
            else if (selectedLocation == 5)
            {
                creqPostData = "mod=location";
                creqPostData += "&loc=4";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(loginURL, creqPostData, refererURL, creqPost);
            }
            else if (selectedLocation == 6)
            {
                creqPostData = "mod=location";
                creqPostData += "&loc=5";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(loginURL, creqPostData, refererURL, creqPost);
            }
            else if (selectedLocation == 7)
            {
                creqPostData = "mod=location";
                creqPostData += "&loc=6";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(loginURL, creqPostData, refererURL, creqPost);
            }
            else
            {
                MessageBox.Show("Please select mob location.", "Gladiatus Bot", MessageBoxButtons.OK);
            }
            #endregion

            #region Fill Mob Orders
            for (int i = 1; i < 5; i++)
            {
                if (i != 4)
                    cbxMobOrder.Items.Add(i);
                else
                    cbxMobOrder.Items.Add("Boss");
            }
            #endregion

            #region Open Attack Button
            btnAttack.Enabled = true;
            #endregion
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            #region Mob Attack
            if(checkAttack.Checked==true)
            {
                autoAttack = true;
            }
            var mobOrder = cbxMobOrder.Text;
            attackURL = "https://s" + getServer + "-tr.gladiatus.gameforge.com/game/ajax.php?";
            refererURL = "https://s" + getServer + "-tr.gladiatus.gameforge.com/game/index.php?mod=location&loc=" + (selectedLocation - 1) + "&sh=" + globalBuff;


            if (mobOrder == "1")
            {
                creqPostData = "mod=location";
                creqPostData += "&submod=attack";
                creqPostData += "&location=" + (selectedLocation - 1);
                creqPostData += "&stage=" + mobOrder;
                creqPostData += "&premium=0";
                creqPostData += "&a=";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(attackURL, creqPostData, refererURL, creqPost);
                responseHtml = responseHtml.Substring(responseHtml.IndexOf("="), responseHtml.IndexOf(";") - responseHtml.IndexOf("="));
                responseHtml = responseHtml.Replace("=\"", "");
                responseHtml = responseHtml.Replace("\"", "");
                combatReport = tClass.creq("https://s" + getServer + "-tr.gladiatus.gameforge.com/game/" + responseHtml, "", "", creqGet);

            }
            else if (mobOrder == "2")
            {
                creqPostData = "mod=location";
                creqPostData += "&submod=attack";
                creqPostData += "&location=" + (selectedLocation - 1);
                creqPostData += "&stage=" + mobOrder;
                creqPostData += "&premium=0";
                creqPostData += "&a=";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(attackURL, creqPostData, refererURL, creqPost);
                responseHtml = responseHtml.Substring(responseHtml.IndexOf("="), responseHtml.IndexOf(";") - responseHtml.IndexOf("="));
                responseHtml = responseHtml.Replace("=\"", "");
                responseHtml = responseHtml.Replace("\"", "");
                combatReport = tClass.creq("https://s" + getServer + "-tr.gladiatus.gameforge.com/game/" + responseHtml, "", "", creqGet);
            }
            else if (mobOrder == "3")
            {
                creqPostData = "mod=location";
                creqPostData += "&submod=attack";
                creqPostData += "&location=" + (selectedLocation - 1);
                creqPostData += "&stage=" + mobOrder;
                creqPostData += "&premium=0";
                creqPostData += "&a=";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(attackURL, creqPostData, refererURL, creqPost);
                responseHtml = responseHtml.Substring(responseHtml.IndexOf("="), responseHtml.IndexOf(";") - responseHtml.IndexOf("="));
                responseHtml = responseHtml.Replace("=\"", "");
                responseHtml = responseHtml.Replace("\"", "");
                combatReport = tClass.creq("https://s" + getServer + "-tr.gladiatus.gameforge.com/game/" + responseHtml, "", "", creqGet);
            }
            else if (mobOrder == "Boss")
            {
                creqPostData = "mod=location";
                creqPostData += "&submod=attack";
                creqPostData += "&location=" + (selectedLocation - 1);
                creqPostData += "&stage=4";
                creqPostData += "&premium=0";
                creqPostData += "&a=";
                creqPostData += "&sh=" + globalBuff;
                responseHtml = tClass.creq(attackURL, creqPostData, refererURL, creqPost);
                responseHtml = responseHtml.Substring(responseHtml.IndexOf("="), responseHtml.IndexOf(";") - responseHtml.IndexOf("="));
                responseHtml = responseHtml.Replace("=\"", "");
                responseHtml = responseHtml.Replace("\"", "");
                combatReport = tClass.creq("https://s" + getServer + "-tr.gladiatus.gameforge.com/game/" + responseHtml, "", "", creqGet);
            }


            #endregion

            #region Combat Report

            #region Combat Winner Parse
            try
            {
                var combatWinner = combatReport.Substring(combatReport.IndexOf("reportHeader"), combatReport.IndexOf("itibar kazandı") - combatReport.IndexOf("reportHeader"));
                combatWinner = combatWinner.Substring(combatWinner.IndexOf("</a>\n                            </td>\n            <td>"), combatWinner.IndexOf("</td>\n            <td va") - combatWinner.IndexOf("</a>\n                            </td>\n            <td>"));
                combatWinner = combatWinner.Replace("</a>\n", "").Replace("</td>\n", "").Replace("<td>", "");
                combatWinner = combatWinner.Replace("  ", "");
                tClass.logWriter(combatWinner, tbxLog);
            }
            catch
            {
                tClass.logWriter("Lose! Change your enemy.", tbxLog);
            }
            #endregion

            #region Combat Rewards Parse
            try
            {
                var CombatRewards = combatReport.Substring(combatReport.IndexOf("Ödül"), combatReport.IndexOf("itibar kazandı") - combatReport.IndexOf("Ödül"));
                CombatRewards = CombatRewards.Replace("  ", "").Replace(",", "\n");
                string[] findRewards = CombatRewards.Split('\n');
                tClass.logWriter(findRewards[7].Split(' ')[0] + " Gold", tbxLog);
                tClass.logWriter(findRewards[10].Split(' ')[1] + " Experience", tbxLog);
                tClass.logWriter(findRewards[13].Split(' ')[1] + " Fame Point", tbxLog);
            }
            catch
            {
                tClass.logWriter("---------------", tbxLog);
            }
            #endregion

            #endregion

            ExpeditionPoints("https://s" + getServer + "-tr.gladiatus.gameforge.com/game/" + responseHtml);
            ExpeditionTimes();
        }

        void ExpeditionPoints(string lastURL)
        {
            creqPostData = "index.php?mod=overview";
            creqPostData += "&sh=" + globalBuff;
            webDocument.LoadHtml(tClass.creq("https://s" + getServer + "-tr.gladiatus.gameforge.com/game/", creqPostData, lastURL, creqPost));
            var expeditionP = webDocument.GetElementbyId("expeditionpoints_value_point").InnerText;
            var dungeonP = webDocument.GetElementbyId("dungeonpoints_value_point").InnerText;
            tbxExpeditionPoints.Text = expeditionP;
            tbxDungeonPoints.Text = dungeonP;

            #region Character Stats
            var charstats = webDocument.GetElementbyId("charstats").InnerText;
            charstats = charstats.Replace("\r", "");
            charstats = charstats.Replace("\n", ";");
            charstats = charstats.Replace(" ", "");
            charstats = charstats.Replace(";;;;", ";");
            charstats = charstats.Replace(";;;", ";");
            charstats = charstats.Replace(";;", "; ");
            characterStats = charstats.Split(';');
            lblLevel.Text ="Level: "+characterStats[2];
            lblHP.Text ="HP: " +characterStats[4];
            lblExp.Text ="Experience: "+characterStats[6];
            #endregion
        }

        public void ExpeditionTimes()
        {
            tmrExpedition.Start();

        }

        private void tmrExpedition_Tick(object sender, EventArgs e)
        {

            #region Server - Centurio Timer Control

            if (x5Server == true)
            {
                if (centurio == true)
                {
                    tbxExTimer.Text = minute.ToString();
                    minute--;
                    if (minute == 0)
                    {
                        minute = 60;
                        tbxExTimer.Text = "";
                        tmrExpedition.Stop();
                        if(checkAttack.Checked==true)
                            btnAttack.PerformClick();
                        
                    }
                }
                else
                {
                    tbxExTimer.Text = minute2.ToString();
                    minute2--;
                    if (minute2 == 0)
                    {
                        minute2 = 120;
                        tbxExTimer.Text = "";
                        tmrExpedition.Stop();
                        if (checkAttack.Checked == true)
                            btnAttack.PerformClick();
                    }
                }
            }
            else
            {
                if (centurio == true)
                {
                    tbxExTimer.Text = minute5.ToString();
                    minute5--;
                    if (minute5 == 0)
                    {
                        minute5 = 300;
                        tbxExTimer.Text = "";
                        tmrExpedition.Stop();
                        if (checkAttack.Checked == true)
                            btnAttack.PerformClick();
                    }
                }
                else
                {
                    tbxExTimer.Text = minute10.ToString();
                    minute10--;
                    if (minute10 == 0)
                    {
                        minute10 = 600;
                        tbxExTimer.Text = "";
                        tmrExpedition.Stop();
                        if (checkAttack.Checked == true)
                            btnAttack.PerformClick();
                    }
                }
            }
            #endregion
        }
    }
}
