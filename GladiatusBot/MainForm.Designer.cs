namespace GladiatusBot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbxServer = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.grpCharStats = new System.Windows.Forms.GroupBox();
            this.lblHealing = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblCharisma = new System.Windows.Forms.Label();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.lblAgility = new System.Windows.Forms.Label();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectLocation = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.cbxMobOrder = new System.Windows.Forms.ComboBox();
            this.lblMobOrder = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.grpExpPoints = new System.Windows.Forms.GroupBox();
            this.lblExpPoints = new System.Windows.Forms.Label();
            this.lblDungPoints = new System.Windows.Forms.Label();
            this.tbxExpeditionPoints = new System.Windows.Forms.TextBox();
            this.tbxDungeonPoints = new System.Windows.Forms.TextBox();
            this.lblExpTimer = new System.Windows.Forms.Label();
            this.grpExpTimers = new System.Windows.Forms.GroupBox();
            this.lblDungTimer = new System.Windows.Forms.Label();
            this.tmrExpedition = new System.Windows.Forms.Timer(this.components);
            this.tmrDungeon = new System.Windows.Forms.Timer(this.components);
            this.tbxDungTimer = new System.Windows.Forms.TextBox();
            this.tbxExTimer = new System.Windows.Forms.TextBox();
            this.check5x = new System.Windows.Forms.CheckBox();
            this.checkCent = new System.Windows.Forms.CheckBox();
            this.checkAttack = new System.Windows.Forms.CheckBox();
            this.grpLogin.SuspendLayout();
            this.grpCharStats.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpExpPoints.SuspendLayout();
            this.grpExpTimers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(76, 30);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 21);
            this.tbxUsername.TabIndex = 0;
            // 
            // tbxPass
            // 
            this.tbxPass.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.Location = new System.Drawing.Point(76, 56);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(100, 21);
            this.tbxPass.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(293, 30);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 74);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbxServer
            // 
            this.cbxServer.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServer.FormattingEnabled = true;
            this.cbxServer.Location = new System.Drawing.Point(76, 83);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Size = new System.Drawing.Size(100, 21);
            this.cbxServer.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(5, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(3, 59);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(70, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(22, 86);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(48, 13);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "Server:";
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.checkCent);
            this.grpLogin.Controls.Add(this.check5x);
            this.grpLogin.Controls.Add(this.cbxServer);
            this.grpLogin.Controls.Add(this.lblServer);
            this.grpLogin.Controls.Add(this.tbxUsername);
            this.grpLogin.Controls.Add(this.lblPass);
            this.grpLogin.Controls.Add(this.tbxPass);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpLogin.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F);
            this.grpLogin.Location = new System.Drawing.Point(8, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(374, 125);
            this.grpLogin.TabIndex = 4;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // grpCharStats
            // 
            this.grpCharStats.Controls.Add(this.lblHealing);
            this.grpCharStats.Controls.Add(this.lblDamage);
            this.grpCharStats.Controls.Add(this.lblArmor);
            this.grpCharStats.Controls.Add(this.lblIntelligence);
            this.grpCharStats.Controls.Add(this.lblCharisma);
            this.grpCharStats.Controls.Add(this.lblConstitution);
            this.grpCharStats.Controls.Add(this.lblAgility);
            this.grpCharStats.Controls.Add(this.lblDexterity);
            this.grpCharStats.Controls.Add(this.lblStrength);
            this.grpCharStats.Controls.Add(this.lblExp);
            this.grpCharStats.Controls.Add(this.lblHP);
            this.grpCharStats.Controls.Add(this.lblLevel);
            this.grpCharStats.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F);
            this.grpCharStats.Location = new System.Drawing.Point(8, 143);
            this.grpCharStats.Name = "grpCharStats";
            this.grpCharStats.Size = new System.Drawing.Size(153, 326);
            this.grpCharStats.TabIndex = 5;
            this.grpCharStats.TabStop = false;
            this.grpCharStats.Text = "Character Stats";
            // 
            // lblHealing
            // 
            this.lblHealing.AutoSize = true;
            this.lblHealing.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealing.Location = new System.Drawing.Point(40, 301);
            this.lblHealing.Name = "lblHealing";
            this.lblHealing.Size = new System.Drawing.Size(63, 13);
            this.lblHealing.TabIndex = 15;
            this.lblHealing.Text = "Healing: ";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamage.Location = new System.Drawing.Point(41, 275);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(62, 13);
            this.lblDamage.TabIndex = 14;
            this.lblDamage.Text = "Damage: ";
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmor.Location = new System.Drawing.Point(49, 250);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(54, 13);
            this.lblArmor.TabIndex = 13;
            this.lblArmor.Text = "Armor: ";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntelligence.Location = new System.Drawing.Point(12, 225);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(91, 13);
            this.lblIntelligence.TabIndex = 10;
            this.lblIntelligence.Text = "Intelligence: ";
            // 
            // lblCharisma
            // 
            this.lblCharisma.AutoSize = true;
            this.lblCharisma.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharisma.Location = new System.Drawing.Point(33, 201);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(70, 13);
            this.lblCharisma.TabIndex = 11;
            this.lblCharisma.Text = "Charisma: ";
            // 
            // lblConstitution
            // 
            this.lblConstitution.AutoSize = true;
            this.lblConstitution.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstitution.Location = new System.Drawing.Point(3, 177);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(100, 13);
            this.lblConstitution.TabIndex = 12;
            this.lblConstitution.Text = "Constitution: ";
            // 
            // lblAgility
            // 
            this.lblAgility.AutoSize = true;
            this.lblAgility.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgility.Location = new System.Drawing.Point(46, 151);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(57, 13);
            this.lblAgility.TabIndex = 7;
            this.lblAgility.Text = "Agility: ";
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDexterity.Location = new System.Drawing.Point(29, 125);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(74, 13);
            this.lblDexterity.TabIndex = 8;
            this.lblDexterity.Text = "Dexterity: ";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(31, 99);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(72, 13);
            this.lblStrength.TabIndex = 9;
            this.lblStrength.Text = "Strength: ";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExp.Location = new System.Drawing.Point(25, 75);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(78, 13);
            this.lblExp.TabIndex = 4;
            this.lblExp.Text = "Experience: ";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(75, 52);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(28, 13);
            this.lblHP.TabIndex = 5;
            this.lblHP.Text = "HP: ";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(58, 27);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(45, 13);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "Level: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkAttack);
            this.groupBox1.Controls.Add(this.btnAttack);
            this.groupBox1.Controls.Add(this.btnSelectLocation);
            this.groupBox1.Controls.Add(this.lblMobOrder);
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.Controls.Add(this.cbxMobOrder);
            this.groupBox1.Controls.Add(this.cbxLocation);
            this.groupBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(170, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MOB Attack";
            // 
            // btnSelectLocation
            // 
            this.btnSelectLocation.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectLocation.Location = new System.Drawing.Point(9, 51);
            this.btnSelectLocation.Name = "btnSelectLocation";
            this.btnSelectLocation.Size = new System.Drawing.Size(197, 22);
            this.btnSelectLocation.TabIndex = 4;
            this.btnSelectLocation.Text = "Select Location";
            this.btnSelectLocation.UseVisualStyleBackColor = true;
            this.btnSelectLocation.Click += new System.EventHandler(this.btnSelectLocation_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(6, 27);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(74, 13);
            this.lblLocation.TabIndex = 16;
            this.lblLocation.Text = "Location: ";
            // 
            // cbxLocation
            // 
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Location = new System.Drawing.Point(85, 24);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(121, 21);
            this.cbxLocation.TabIndex = 0;
            // 
            // cbxMobOrder
            // 
            this.cbxMobOrder.FormattingEnabled = true;
            this.cbxMobOrder.Location = new System.Drawing.Point(85, 83);
            this.cbxMobOrder.Name = "cbxMobOrder";
            this.cbxMobOrder.Size = new System.Drawing.Size(121, 21);
            this.cbxMobOrder.TabIndex = 0;
            // 
            // lblMobOrder
            // 
            this.lblMobOrder.AutoSize = true;
            this.lblMobOrder.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobOrder.Location = new System.Drawing.Point(6, 86);
            this.lblMobOrder.Name = "lblMobOrder";
            this.lblMobOrder.Size = new System.Drawing.Size(77, 13);
            this.lblMobOrder.TabIndex = 16;
            this.lblMobOrder.Text = "Mob Order:";
            // 
            // btnAttack
            // 
            this.btnAttack.Enabled = false;
            this.btnAttack.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(9, 110);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(197, 22);
            this.btnAttack.TabIndex = 4;
            this.btnAttack.Text = "Attack!";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxLog);
            this.groupBox2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(388, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 121);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Panel";
            // 
            // tbxLog
            // 
            this.tbxLog.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbxLog.ForeColor = System.Drawing.Color.Lime;
            this.tbxLog.Location = new System.Drawing.Point(6, 20);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.Size = new System.Drawing.Size(388, 95);
            this.tbxLog.TabIndex = 0;
            this.tbxLog.Text = "Gladiatus - Log Panel\r\n";
            // 
            // grpExpPoints
            // 
            this.grpExpPoints.Controls.Add(this.tbxDungeonPoints);
            this.grpExpPoints.Controls.Add(this.tbxExpeditionPoints);
            this.grpExpPoints.Controls.Add(this.lblDungPoints);
            this.grpExpPoints.Controls.Add(this.lblExpPoints);
            this.grpExpPoints.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F);
            this.grpExpPoints.Location = new System.Drawing.Point(167, 143);
            this.grpExpPoints.Name = "grpExpPoints";
            this.grpExpPoints.Size = new System.Drawing.Size(206, 85);
            this.grpExpPoints.TabIndex = 8;
            this.grpExpPoints.TabStop = false;
            this.grpExpPoints.Text = "Expedition Points";
            // 
            // lblExpPoints
            // 
            this.lblExpPoints.AutoSize = true;
            this.lblExpPoints.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpPoints.Location = new System.Drawing.Point(19, 23);
            this.lblExpPoints.Name = "lblExpPoints";
            this.lblExpPoints.Size = new System.Drawing.Size(124, 13);
            this.lblExpPoints.TabIndex = 17;
            this.lblExpPoints.Text = "Expedition Points: ";
            // 
            // lblDungPoints
            // 
            this.lblDungPoints.AutoSize = true;
            this.lblDungPoints.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDungPoints.Location = new System.Drawing.Point(25, 52);
            this.lblDungPoints.Name = "lblDungPoints";
            this.lblDungPoints.Size = new System.Drawing.Size(118, 13);
            this.lblDungPoints.TabIndex = 18;
            this.lblDungPoints.Text = "Dungeon Points: ";
            // 
            // tbxExpeditionPoints
            // 
            this.tbxExpeditionPoints.Enabled = false;
            this.tbxExpeditionPoints.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExpeditionPoints.Location = new System.Drawing.Point(149, 20);
            this.tbxExpeditionPoints.Name = "tbxExpeditionPoints";
            this.tbxExpeditionPoints.Size = new System.Drawing.Size(32, 21);
            this.tbxExpeditionPoints.TabIndex = 4;
            // 
            // tbxDungeonPoints
            // 
            this.tbxDungeonPoints.Enabled = false;
            this.tbxDungeonPoints.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDungeonPoints.Location = new System.Drawing.Point(149, 49);
            this.tbxDungeonPoints.Name = "tbxDungeonPoints";
            this.tbxDungeonPoints.Size = new System.Drawing.Size(32, 21);
            this.tbxDungeonPoints.TabIndex = 19;
            // 
            // lblExpTimer
            // 
            this.lblExpTimer.AutoSize = true;
            this.lblExpTimer.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpTimer.Location = new System.Drawing.Point(19, 26);
            this.lblExpTimer.Name = "lblExpTimer";
            this.lblExpTimer.Size = new System.Drawing.Size(116, 13);
            this.lblExpTimer.TabIndex = 20;
            this.lblExpTimer.Text = "Expedition Timer: ";
            // 
            // grpExpTimers
            // 
            this.grpExpTimers.Controls.Add(this.tbxDungTimer);
            this.grpExpTimers.Controls.Add(this.tbxExTimer);
            this.grpExpTimers.Controls.Add(this.lblDungTimer);
            this.grpExpTimers.Controls.Add(this.lblExpTimer);
            this.grpExpTimers.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F);
            this.grpExpTimers.Location = new System.Drawing.Point(167, 233);
            this.grpExpTimers.Name = "grpExpTimers";
            this.grpExpTimers.Size = new System.Drawing.Size(206, 86);
            this.grpExpTimers.TabIndex = 21;
            this.grpExpTimers.TabStop = false;
            this.grpExpTimers.Text = "Expedition Timers";
            // 
            // lblDungTimer
            // 
            this.lblDungTimer.AutoSize = true;
            this.lblDungTimer.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDungTimer.Location = new System.Drawing.Point(25, 53);
            this.lblDungTimer.Name = "lblDungTimer";
            this.lblDungTimer.Size = new System.Drawing.Size(110, 13);
            this.lblDungTimer.TabIndex = 21;
            this.lblDungTimer.Text = "Dungeon Timer: ";
            // 
            // tmrExpedition
            // 
            this.tmrExpedition.Interval = 1000;
            this.tmrExpedition.Tick += new System.EventHandler(this.tmrExpedition_Tick);
            // 
            // tmrDungeon
            // 
            this.tmrDungeon.Interval = 1000;
            // 
            // tbxDungTimer
            // 
            this.tbxDungTimer.Enabled = false;
            this.tbxDungTimer.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDungTimer.Location = new System.Drawing.Point(141, 50);
            this.tbxDungTimer.Name = "tbxDungTimer";
            this.tbxDungTimer.Size = new System.Drawing.Size(40, 21);
            this.tbxDungTimer.TabIndex = 21;
            // 
            // tbxExTimer
            // 
            this.tbxExTimer.Enabled = false;
            this.tbxExTimer.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExTimer.Location = new System.Drawing.Point(141, 23);
            this.tbxExTimer.Name = "tbxExTimer";
            this.tbxExTimer.Size = new System.Drawing.Size(40, 21);
            this.tbxExTimer.TabIndex = 20;
            // 
            // check5x
            // 
            this.check5x.AutoSize = true;
            this.check5x.Location = new System.Drawing.Point(196, 46);
            this.check5x.Name = "check5x";
            this.check5x.Size = new System.Drawing.Size(83, 17);
            this.check5x.TabIndex = 4;
            this.check5x.Text = "5x Server";
            this.check5x.UseVisualStyleBackColor = true;
            // 
            // checkCent
            // 
            this.checkCent.AutoSize = true;
            this.checkCent.Location = new System.Drawing.Point(196, 69);
            this.checkCent.Name = "checkCent";
            this.checkCent.Size = new System.Drawing.Size(85, 17);
            this.checkCent.TabIndex = 4;
            this.checkCent.Text = "Centurio";
            this.checkCent.UseVisualStyleBackColor = true;
            // 
            // checkAttack
            // 
            this.checkAttack.AutoSize = true;
            this.checkAttack.Location = new System.Drawing.Point(212, 114);
            this.checkAttack.Name = "checkAttack";
            this.checkAttack.Size = new System.Drawing.Size(109, 17);
            this.checkAttack.TabIndex = 17;
            this.checkAttack.Text = "Auto Attack";
            this.checkAttack.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.grpExpTimers);
            this.Controls.Add(this.grpExpPoints);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCharStats);
            this.Controls.Add(this.grpLogin);
            this.Name = "MainForm";
            this.Text = "Gladiatus Bot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpCharStats.ResumeLayout(false);
            this.grpCharStats.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpExpPoints.ResumeLayout(false);
            this.grpExpPoints.PerformLayout();
            this.grpExpTimers.ResumeLayout(false);
            this.grpExpTimers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cbxServer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.GroupBox grpCharStats;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblCharisma;
        private System.Windows.Forms.Label lblConstitution;
        private System.Windows.Forms.Label lblHealing;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnSelectLocation;
        private System.Windows.Forms.Label lblMobOrder;
        private System.Windows.Forms.ComboBox cbxMobOrder;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.GroupBox grpExpPoints;
        private System.Windows.Forms.TextBox tbxDungeonPoints;
        private System.Windows.Forms.TextBox tbxExpeditionPoints;
        private System.Windows.Forms.Label lblDungPoints;
        private System.Windows.Forms.Label lblExpPoints;
        private System.Windows.Forms.Label lblExpTimer;
        private System.Windows.Forms.GroupBox grpExpTimers;
        private System.Windows.Forms.TextBox tbxDungTimer;
        private System.Windows.Forms.TextBox tbxExTimer;
        private System.Windows.Forms.Label lblDungTimer;
        private System.Windows.Forms.Timer tmrExpedition;
        private System.Windows.Forms.Timer tmrDungeon;
        private System.Windows.Forms.CheckBox checkCent;
        private System.Windows.Forms.CheckBox check5x;
        private System.Windows.Forms.CheckBox checkAttack;
    }
}

