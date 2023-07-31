namespace FSKI_ferramenta_de_competição
{
    partial class PlacarKumite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlacarKumite));
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timerKumite = new System.Windows.Forms.Timer(this.components);
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.labelT = new System.Windows.Forms.Label();
            this.labelNameAo = new System.Windows.Forms.Label();
            this.textBoxNameAo = new System.Windows.Forms.TextBox();
            this.labelAoAssociation = new System.Windows.Forms.Label();
            this.textBoxAoAssociation = new System.Windows.Forms.TextBox();
            this.labelAOPoints = new System.Windows.Forms.Label();
            this.labelSJ = new System.Windows.Forms.Label();
            this.buttonAoJogaiDown = new System.Windows.Forms.Button();
            this.buttonAoJogaiUp = new System.Windows.Forms.Button();
            this.labelAoJogai = new System.Windows.Forms.Label();
            this.labelShiroAB = new System.Windows.Forms.Label();
            this.buttonAoAtenaiBehaviorDown = new System.Windows.Forms.Button();
            this.buttonAoAtenaiBehaviorUp = new System.Windows.Forms.Button();
            this.labelAoAtenaiBehavior = new System.Windows.Forms.Label();
            this.buttonAoWazariDown = new System.Windows.Forms.Button();
            this.buttonAoWazariUp = new System.Windows.Forms.Button();
            this.labelShiroWazari = new System.Windows.Forms.Label();
            this.buttonAoIponnDown = new System.Windows.Forms.Button();
            this.buttonAoIponnUp = new System.Windows.Forms.Button();
            this.labelShiroIponn = new System.Windows.Forms.Label();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.labelNameAka = new System.Windows.Forms.Label();
            this.textBoxNameAka = new System.Windows.Forms.TextBox();
            this.labelAkaAssociation = new System.Windows.Forms.Label();
            this.textBoxAkaAssociation = new System.Windows.Forms.TextBox();
            this.labelAkaIponn = new System.Windows.Forms.Label();
            this.buttonAkaIponnUp = new System.Windows.Forms.Button();
            this.buttonAkaIponnDown = new System.Windows.Forms.Button();
            this.labelAkaWazari = new System.Windows.Forms.Label();
            this.buttonAkaWazariUp = new System.Windows.Forms.Button();
            this.buttonAkaWazariDown = new System.Windows.Forms.Button();
            this.buttonAkaAtenaiBehaviorUp = new System.Windows.Forms.Button();
            this.buttonAkaAtenaiBehaviorDown = new System.Windows.Forms.Button();
            this.labelAkaAB = new System.Windows.Forms.Label();
            this.labelAkaJogai = new System.Windows.Forms.Label();
            this.buttonAkaJogaiUp = new System.Windows.Forms.Button();
            this.buttonAkaJogaiDown = new System.Windows.Forms.Button();
            this.labelAJ = new System.Windows.Forms.Label();
            this.labelAkaName = new System.Windows.Forms.Label();
            this.panelAka = new System.Windows.Forms.Panel();
            this.labelAkaAtenaiBehavior = new System.Windows.Forms.Label();
            this.labelAkaPoints = new System.Windows.Forms.Label();
            this.pictureBoxCEEBK = new System.Windows.Forms.PictureBox();
            this.pictureBoxFSKI = new System.Windows.Forms.PictureBox();
            this.panelAka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCEEBK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFSKI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(977, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimer.BackColor = System.Drawing.Color.White;
            this.labelTimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelTimer.Font = new System.Drawing.Font("Agency FB", 140.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTimer.Location = new System.Drawing.Point(461, 1);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(431, 216);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "03:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerKumite
            // 
            this.timerKumite.Interval = 1000;
            this.timerKumite.Tick += new System.EventHandler(this.timerKumite_Tick);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(820, 702);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(83, 23);
            this.buttonReset.TabIndex = 28;
            this.buttonReset.Text = "Resetar";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMinutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Items.AddRange(new object[] {
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00"});
            this.comboBoxMinutes.Location = new System.Drawing.Point(909, 703);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(117, 21);
            this.comboBoxMinutes.TabIndex = 27;
            this.comboBoxMinutes.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinutes_SelectedIndexChanged);
            // 
            // labelT
            // 
            this.labelT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelT.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelT.Location = new System.Drawing.Point(573, 1);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(198, 20);
            this.labelT.TabIndex = 7;
            this.labelT.Text = "TEMPO";
            this.labelT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameAo
            // 
            this.labelNameAo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameAo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelNameAo.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameAo.Location = new System.Drawing.Point(1086, 1);
            this.labelNameAo.Name = "labelNameAo";
            this.labelNameAo.Size = new System.Drawing.Size(37, 20);
            this.labelNameAo.TabIndex = 8;
            this.labelNameAo.Text = "Nome";
            this.labelNameAo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNameAo
            // 
            this.textBoxNameAo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameAo.BackColor = System.Drawing.Color.Navy;
            this.textBoxNameAo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNameAo.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameAo.Location = new System.Drawing.Point(895, 38);
            this.textBoxNameAo.Name = "textBoxNameAo";
            this.textBoxNameAo.Size = new System.Drawing.Size(454, 65);
            this.textBoxNameAo.TabIndex = 1;
            this.textBoxNameAo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAoAssociation
            // 
            this.labelAoAssociation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAoAssociation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAoAssociation.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAoAssociation.Location = new System.Drawing.Point(1076, 119);
            this.labelAoAssociation.Name = "labelAoAssociation";
            this.labelAoAssociation.Size = new System.Drawing.Size(62, 20);
            this.labelAoAssociation.TabIndex = 10;
            this.labelAoAssociation.Text = "Equipe";
            this.labelAoAssociation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAoAssociation
            // 
            this.textBoxAoAssociation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAoAssociation.BackColor = System.Drawing.Color.Navy;
            this.textBoxAoAssociation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAoAssociation.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAoAssociation.Location = new System.Drawing.Point(895, 152);
            this.textBoxAoAssociation.Name = "textBoxAoAssociation";
            this.textBoxAoAssociation.Size = new System.Drawing.Size(454, 65);
            this.textBoxAoAssociation.TabIndex = 2;
            this.textBoxAoAssociation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAOPoints
            // 
            this.labelAOPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAOPoints.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAOPoints.Font = new System.Drawing.Font("Agency FB", 300F, System.Drawing.FontStyle.Bold);
            this.labelAOPoints.Location = new System.Drawing.Point(1050, 274);
            this.labelAOPoints.Name = "labelAOPoints";
            this.labelAOPoints.Size = new System.Drawing.Size(299, 447);
            this.labelAOPoints.TabIndex = 12;
            this.labelAOPoints.Text = "0";
            this.labelAOPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSJ
            // 
            this.labelSJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSJ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelSJ.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSJ.Location = new System.Drawing.Point(888, 274);
            this.labelSJ.Name = "labelSJ";
            this.labelSJ.Size = new System.Drawing.Size(68, 42);
            this.labelSJ.TabIndex = 47;
            this.labelSJ.Text = "C1";
            this.labelSJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAoJogaiDown
            // 
            this.buttonAoJogaiDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAoJogaiDown.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAoJogaiDown.Location = new System.Drawing.Point(853, 270);
            this.buttonAoJogaiDown.Name = "buttonAoJogaiDown";
            this.buttonAoJogaiDown.Size = new System.Drawing.Size(29, 46);
            this.buttonAoJogaiDown.TabIndex = 46;
            this.buttonAoJogaiDown.Text = "↓";
            this.buttonAoJogaiDown.UseVisualStyleBackColor = true;
            this.buttonAoJogaiDown.Click += new System.EventHandler(this.buttonAoJogaiDown_Click);
            // 
            // buttonAoJogaiUp
            // 
            this.buttonAoJogaiUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAoJogaiUp.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAoJogaiUp.Location = new System.Drawing.Point(821, 270);
            this.buttonAoJogaiUp.Name = "buttonAoJogaiUp";
            this.buttonAoJogaiUp.Size = new System.Drawing.Size(29, 46);
            this.buttonAoJogaiUp.TabIndex = 45;
            this.buttonAoJogaiUp.Text = "↑";
            this.buttonAoJogaiUp.UseVisualStyleBackColor = true;
            this.buttonAoJogaiUp.Click += new System.EventHandler(this.buttonAoJogaiUp_Click);
            // 
            // labelAoJogai
            // 
            this.labelAoJogai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAoJogai.AutoSize = true;
            this.labelAoJogai.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAoJogai.Location = new System.Drawing.Point(974, 257);
            this.labelAoJogai.Name = "labelAoJogai";
            this.labelAoJogai.Size = new System.Drawing.Size(0, 77);
            this.labelAoJogai.TabIndex = 44;
            this.labelAoJogai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShiroAB
            // 
            this.labelShiroAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShiroAB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelShiroAB.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShiroAB.Location = new System.Drawing.Point(888, 380);
            this.labelShiroAB.Name = "labelShiroAB";
            this.labelShiroAB.Size = new System.Drawing.Size(80, 43);
            this.labelShiroAB.TabIndex = 43;
            this.labelShiroAB.Text = "C2";
            this.labelShiroAB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAoAtenaiBehaviorDown
            // 
            this.buttonAoAtenaiBehaviorDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAoAtenaiBehaviorDown.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAoAtenaiBehaviorDown.Location = new System.Drawing.Point(853, 377);
            this.buttonAoAtenaiBehaviorDown.Name = "buttonAoAtenaiBehaviorDown";
            this.buttonAoAtenaiBehaviorDown.Size = new System.Drawing.Size(29, 46);
            this.buttonAoAtenaiBehaviorDown.TabIndex = 42;
            this.buttonAoAtenaiBehaviorDown.Text = "↓";
            this.buttonAoAtenaiBehaviorDown.UseVisualStyleBackColor = true;
            this.buttonAoAtenaiBehaviorDown.Click += new System.EventHandler(this.buttonAoAtenaiBehaviorDown_Click);
            // 
            // buttonAoAtenaiBehaviorUp
            // 
            this.buttonAoAtenaiBehaviorUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAoAtenaiBehaviorUp.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAoAtenaiBehaviorUp.Location = new System.Drawing.Point(821, 377);
            this.buttonAoAtenaiBehaviorUp.Name = "buttonAoAtenaiBehaviorUp";
            this.buttonAoAtenaiBehaviorUp.Size = new System.Drawing.Size(29, 46);
            this.buttonAoAtenaiBehaviorUp.TabIndex = 41;
            this.buttonAoAtenaiBehaviorUp.Text = "↑";
            this.buttonAoAtenaiBehaviorUp.UseVisualStyleBackColor = true;
            this.buttonAoAtenaiBehaviorUp.Click += new System.EventHandler(this.buttonAoAtenaiBehaviorUp_Click);
            // 
            // labelAoAtenaiBehavior
            // 
            this.labelAoAtenaiBehavior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAoAtenaiBehavior.AutoSize = true;
            this.labelAoAtenaiBehavior.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAoAtenaiBehavior.Location = new System.Drawing.Point(974, 360);
            this.labelAoAtenaiBehavior.Name = "labelAoAtenaiBehavior";
            this.labelAoAtenaiBehavior.Size = new System.Drawing.Size(0, 77);
            this.labelAoAtenaiBehavior.TabIndex = 40;
            this.labelAoAtenaiBehavior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAoWazariDown
            // 
            this.buttonAoWazariDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAoWazariDown.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAoWazariDown.Location = new System.Drawing.Point(942, 504);
            this.buttonAoWazariDown.Name = "buttonAoWazariDown";
            this.buttonAoWazariDown.Size = new System.Drawing.Size(29, 46);
            this.buttonAoWazariDown.TabIndex = 35;
            this.buttonAoWazariDown.Text = "↓";
            this.buttonAoWazariDown.UseVisualStyleBackColor = true;
            this.buttonAoWazariDown.Click += new System.EventHandler(this.buttonAoWazariDown_Click);
            // 
            // buttonAoWazariUp
            // 
            this.buttonAoWazariUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAoWazariUp.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAoWazariUp.Location = new System.Drawing.Point(821, 505);
            this.buttonAoWazariUp.Name = "buttonAoWazariUp";
            this.buttonAoWazariUp.Size = new System.Drawing.Size(29, 46);
            this.buttonAoWazariUp.TabIndex = 34;
            this.buttonAoWazariUp.Text = "↑";
            this.buttonAoWazariUp.UseVisualStyleBackColor = true;
            this.buttonAoWazariUp.Click += new System.EventHandler(this.buttonAoWazariUp_Click);
            // 
            // labelShiroWazari
            // 
            this.labelShiroWazari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShiroWazari.AutoSize = true;
            this.labelShiroWazari.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShiroWazari.Location = new System.Drawing.Point(846, 508);
            this.labelShiroWazari.Name = "labelShiroWazari";
            this.labelShiroWazari.Size = new System.Drawing.Size(97, 39);
            this.labelShiroWazari.TabIndex = 33;
            this.labelShiroWazari.Text = "WAZARI";
            // 
            // buttonAoIponnDown
            // 
            this.buttonAoIponnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAoIponnDown.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAoIponnDown.Location = new System.Drawing.Point(942, 453);
            this.buttonAoIponnDown.Name = "buttonAoIponnDown";
            this.buttonAoIponnDown.Size = new System.Drawing.Size(29, 44);
            this.buttonAoIponnDown.TabIndex = 32;
            this.buttonAoIponnDown.Text = "↓";
            this.buttonAoIponnDown.UseVisualStyleBackColor = true;
            this.buttonAoIponnDown.Click += new System.EventHandler(this.buttonAoIponnDown_Click);
            // 
            // buttonAoIponnUp
            // 
            this.buttonAoIponnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAoIponnUp.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAoIponnUp.Location = new System.Drawing.Point(821, 451);
            this.buttonAoIponnUp.Name = "buttonAoIponnUp";
            this.buttonAoIponnUp.Size = new System.Drawing.Size(29, 46);
            this.buttonAoIponnUp.TabIndex = 31;
            this.buttonAoIponnUp.Text = "↑";
            this.buttonAoIponnUp.UseVisualStyleBackColor = true;
            this.buttonAoIponnUp.Click += new System.EventHandler(this.buttonAoIponnUp_Click);
            // 
            // labelShiroIponn
            // 
            this.labelShiroIponn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShiroIponn.AutoSize = true;
            this.labelShiroIponn.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShiroIponn.Location = new System.Drawing.Point(853, 451);
            this.labelShiroIponn.Name = "labelShiroIponn";
            this.labelShiroIponn.Size = new System.Drawing.Size(83, 39);
            this.labelShiroIponn.TabIndex = 30;
            this.labelShiroIponn.Text = "IPONN";
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStartPause.Location = new System.Drawing.Point(445, 697);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(84, 26);
            this.buttonStartPause.TabIndex = 10;
            this.buttonStartPause.Text = "Iniciar";
            this.buttonStartPause.UseVisualStyleBackColor = true;
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // labelNameAka
            // 
            this.labelNameAka.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelNameAka.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameAka.Location = new System.Drawing.Point(211, 0);
            this.labelNameAka.Name = "labelNameAka";
            this.labelNameAka.Size = new System.Drawing.Size(0, 20);
            this.labelNameAka.TabIndex = 7;
            this.labelNameAka.Text = "Name";
            this.labelNameAka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNameAka
            // 
            this.textBoxNameAka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNameAka.BackColor = System.Drawing.Color.Red;
            this.textBoxNameAka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNameAka.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameAka.Location = new System.Drawing.Point(3, 37);
            this.textBoxNameAka.Name = "textBoxNameAka";
            this.textBoxNameAka.Size = new System.Drawing.Size(454, 65);
            this.textBoxNameAka.TabIndex = 23;
            this.textBoxNameAka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAkaAssociation
            // 
            this.labelAkaAssociation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAkaAssociation.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAkaAssociation.Location = new System.Drawing.Point(198, 118);
            this.labelAkaAssociation.Name = "labelAkaAssociation";
            this.labelAkaAssociation.Size = new System.Drawing.Size(62, 20);
            this.labelAkaAssociation.TabIndex = 9;
            this.labelAkaAssociation.Text = "Equipe";
            this.labelAkaAssociation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAkaAssociation
            // 
            this.textBoxAkaAssociation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAkaAssociation.BackColor = System.Drawing.Color.Red;
            this.textBoxAkaAssociation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAkaAssociation.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAkaAssociation.Location = new System.Drawing.Point(3, 151);
            this.textBoxAkaAssociation.Name = "textBoxAkaAssociation";
            this.textBoxAkaAssociation.Size = new System.Drawing.Size(454, 65);
            this.textBoxAkaAssociation.TabIndex = 24;
            this.textBoxAkaAssociation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAkaIponn
            // 
            this.labelAkaIponn.AutoSize = true;
            this.labelAkaIponn.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAkaIponn.Location = new System.Drawing.Point(409, 452);
            this.labelAkaIponn.Name = "labelAkaIponn";
            this.labelAkaIponn.Size = new System.Drawing.Size(83, 39);
            this.labelAkaIponn.TabIndex = 12;
            this.labelAkaIponn.Text = "IPONN";
            // 
            // buttonAkaIponnUp
            // 
            this.buttonAkaIponnUp.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAkaIponnUp.Location = new System.Drawing.Point(498, 452);
            this.buttonAkaIponnUp.Name = "buttonAkaIponnUp";
            this.buttonAkaIponnUp.Size = new System.Drawing.Size(29, 46);
            this.buttonAkaIponnUp.TabIndex = 8;
            this.buttonAkaIponnUp.Text = "↑";
            this.buttonAkaIponnUp.UseVisualStyleBackColor = true;
            this.buttonAkaIponnUp.Click += new System.EventHandler(this.buttonAkaIponnUp_Click);
            // 
            // buttonAkaIponnDown
            // 
            this.buttonAkaIponnDown.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAkaIponnDown.Location = new System.Drawing.Point(377, 453);
            this.buttonAkaIponnDown.Name = "buttonAkaIponnDown";
            this.buttonAkaIponnDown.Size = new System.Drawing.Size(29, 44);
            this.buttonAkaIponnDown.TabIndex = 9;
            this.buttonAkaIponnDown.Text = "↓";
            this.buttonAkaIponnDown.UseVisualStyleBackColor = true;
            this.buttonAkaIponnDown.Click += new System.EventHandler(this.buttonAkaIponnDown_Click);
            // 
            // labelAkaWazari
            // 
            this.labelAkaWazari.AutoSize = true;
            this.labelAkaWazari.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAkaWazari.Location = new System.Drawing.Point(402, 501);
            this.labelAkaWazari.Name = "labelAkaWazari";
            this.labelAkaWazari.Size = new System.Drawing.Size(97, 39);
            this.labelAkaWazari.TabIndex = 15;
            this.labelAkaWazari.Text = "WAZARI";
            // 
            // buttonAkaWazariUp
            // 
            this.buttonAkaWazariUp.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAkaWazariUp.Location = new System.Drawing.Point(498, 498);
            this.buttonAkaWazariUp.Name = "buttonAkaWazariUp";
            this.buttonAkaWazariUp.Size = new System.Drawing.Size(29, 46);
            this.buttonAkaWazariUp.TabIndex = 6;
            this.buttonAkaWazariUp.Text = "↑";
            this.buttonAkaWazariUp.UseVisualStyleBackColor = true;
            this.buttonAkaWazariUp.Click += new System.EventHandler(this.buttonAkaWazariUp_Click);
            // 
            // buttonAkaWazariDown
            // 
            this.buttonAkaWazariDown.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAkaWazariDown.Location = new System.Drawing.Point(377, 499);
            this.buttonAkaWazariDown.Name = "buttonAkaWazariDown";
            this.buttonAkaWazariDown.Size = new System.Drawing.Size(29, 46);
            this.buttonAkaWazariDown.TabIndex = 7;
            this.buttonAkaWazariDown.Text = "↓";
            this.buttonAkaWazariDown.UseVisualStyleBackColor = true;
            this.buttonAkaWazariDown.Click += new System.EventHandler(this.buttonAkaWazariDown_Click);
            // 
            // buttonAkaAtenaiBehaviorUp
            // 
            this.buttonAkaAtenaiBehaviorUp.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAkaAtenaiBehaviorUp.Location = new System.Drawing.Point(500, 376);
            this.buttonAkaAtenaiBehaviorUp.Name = "buttonAkaAtenaiBehaviorUp";
            this.buttonAkaAtenaiBehaviorUp.Size = new System.Drawing.Size(29, 46);
            this.buttonAkaAtenaiBehaviorUp.TabIndex = 2;
            this.buttonAkaAtenaiBehaviorUp.Text = "↑";
            this.buttonAkaAtenaiBehaviorUp.UseVisualStyleBackColor = true;
            this.buttonAkaAtenaiBehaviorUp.Click += new System.EventHandler(this.buttonAkaAtenaiBehaviorUp_Click);
            // 
            // buttonAkaAtenaiBehaviorDown
            // 
            this.buttonAkaAtenaiBehaviorDown.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAkaAtenaiBehaviorDown.Location = new System.Drawing.Point(465, 377);
            this.buttonAkaAtenaiBehaviorDown.Name = "buttonAkaAtenaiBehaviorDown";
            this.buttonAkaAtenaiBehaviorDown.Size = new System.Drawing.Size(29, 46);
            this.buttonAkaAtenaiBehaviorDown.TabIndex = 3;
            this.buttonAkaAtenaiBehaviorDown.Text = "↓";
            this.buttonAkaAtenaiBehaviorDown.UseVisualStyleBackColor = true;
            this.buttonAkaAtenaiBehaviorDown.Click += new System.EventHandler(this.buttonAkaAtenaiBehaviorDown_Click);
            // 
            // labelAkaAB
            // 
            this.labelAkaAB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAkaAB.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAkaAB.Location = new System.Drawing.Point(374, 379);
            this.labelAkaAB.Name = "labelAkaAB";
            this.labelAkaAB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAkaAB.Size = new System.Drawing.Size(83, 43);
            this.labelAkaAB.TabIndex = 25;
            this.labelAkaAB.Text = "C2";
            this.labelAkaAB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAkaJogai
            // 
            this.labelAkaJogai.AutoSize = true;
            this.labelAkaJogai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAkaJogai.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAkaJogai.Location = new System.Drawing.Point(266, 256);
            this.labelAkaJogai.Name = "labelAkaJogai";
            this.labelAkaJogai.Size = new System.Drawing.Size(0, 77);
            this.labelAkaJogai.TabIndex = 26;
            this.labelAkaJogai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAkaJogaiUp
            // 
            this.buttonAkaJogaiUp.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAkaJogaiUp.Location = new System.Drawing.Point(501, 269);
            this.buttonAkaJogaiUp.Name = "buttonAkaJogaiUp";
            this.buttonAkaJogaiUp.Size = new System.Drawing.Size(29, 46);
            this.buttonAkaJogaiUp.TabIndex = 0;
            this.buttonAkaJogaiUp.Text = "↑";
            this.buttonAkaJogaiUp.UseVisualStyleBackColor = true;
            this.buttonAkaJogaiUp.Click += new System.EventHandler(this.buttonAkaJogaiUp_Click);
            // 
            // buttonAkaJogaiDown
            // 
            this.buttonAkaJogaiDown.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAkaJogaiDown.Location = new System.Drawing.Point(465, 269);
            this.buttonAkaJogaiDown.Name = "buttonAkaJogaiDown";
            this.buttonAkaJogaiDown.Size = new System.Drawing.Size(29, 46);
            this.buttonAkaJogaiDown.TabIndex = 1;
            this.buttonAkaJogaiDown.Text = "↓";
            this.buttonAkaJogaiDown.UseVisualStyleBackColor = true;
            this.buttonAkaJogaiDown.Click += new System.EventHandler(this.buttonAkaJogaiDown_Click);
            // 
            // labelAJ
            // 
            this.labelAJ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAJ.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAJ.Location = new System.Drawing.Point(391, 273);
            this.labelAJ.Name = "labelAJ";
            this.labelAJ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAJ.Size = new System.Drawing.Size(68, 42);
            this.labelAJ.TabIndex = 29;
            this.labelAJ.Text = "C1";
            this.labelAJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAkaName
            // 
            this.labelAkaName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAkaName.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAkaName.Location = new System.Drawing.Point(211, 0);
            this.labelAkaName.Name = "labelAkaName";
            this.labelAkaName.Size = new System.Drawing.Size(37, 20);
            this.labelAkaName.TabIndex = 48;
            this.labelAkaName.Text = "Nome";
            this.labelAkaName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAka
            // 
            this.panelAka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAka.BackColor = System.Drawing.Color.Red;
            this.panelAka.Controls.Add(this.buttonAkaIponnDown);
            this.panelAka.Controls.Add(this.labelAkaName);
            this.panelAka.Controls.Add(this.labelAJ);
            this.panelAka.Controls.Add(this.buttonAkaJogaiDown);
            this.panelAka.Controls.Add(this.buttonAkaJogaiUp);
            this.panelAka.Controls.Add(this.labelAkaJogai);
            this.panelAka.Controls.Add(this.labelAkaAB);
            this.panelAka.Controls.Add(this.buttonAkaAtenaiBehaviorDown);
            this.panelAka.Controls.Add(this.buttonAkaAtenaiBehaviorUp);
            this.panelAka.Controls.Add(this.labelAkaAtenaiBehavior);
            this.panelAka.Controls.Add(this.buttonAkaWazariDown);
            this.panelAka.Controls.Add(this.buttonAkaWazariUp);
            this.panelAka.Controls.Add(this.labelAkaWazari);
            this.panelAka.Controls.Add(this.buttonAkaIponnUp);
            this.panelAka.Controls.Add(this.labelAkaIponn);
            this.panelAka.Controls.Add(this.labelAkaPoints);
            this.panelAka.Controls.Add(this.textBoxAkaAssociation);
            this.panelAka.Controls.Add(this.labelAkaAssociation);
            this.panelAka.Controls.Add(this.textBoxNameAka);
            this.panelAka.Controls.Add(this.labelNameAka);
            this.panelAka.Controls.Add(this.buttonStartPause);
            this.panelAka.Location = new System.Drawing.Point(1, 1);
            this.panelAka.Name = "panelAka";
            this.panelAka.Size = new System.Drawing.Size(653, 728);
            this.panelAka.TabIndex = 0;
            // 
            // labelAkaAtenaiBehavior
            // 
            this.labelAkaAtenaiBehavior.AutoSize = true;
            this.labelAkaAtenaiBehavior.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAkaAtenaiBehavior.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAkaAtenaiBehavior.Location = new System.Drawing.Point(266, 359);
            this.labelAkaAtenaiBehavior.Name = "labelAkaAtenaiBehavior";
            this.labelAkaAtenaiBehavior.Size = new System.Drawing.Size(0, 77);
            this.labelAkaAtenaiBehavior.TabIndex = 22;
            this.labelAkaAtenaiBehavior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAkaPoints
            // 
            this.labelAkaPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAkaPoints.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAkaPoints.Font = new System.Drawing.Font("Agency FB", 300F, System.Drawing.FontStyle.Bold);
            this.labelAkaPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAkaPoints.Location = new System.Drawing.Point(3, 281);
            this.labelAkaPoints.Name = "labelAkaPoints";
            this.labelAkaPoints.Size = new System.Drawing.Size(299, 447);
            this.labelAkaPoints.TabIndex = 11;
            this.labelAkaPoints.Text = "0";
            this.labelAkaPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCEEBK
            // 
            this.pictureBoxCEEBK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCEEBK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCEEBK.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCEEBK.Image")));
            this.pictureBoxCEEBK.Location = new System.Drawing.Point(537, 474);
            this.pictureBoxCEEBK.Name = "pictureBoxCEEBK";
            this.pictureBoxCEEBK.Size = new System.Drawing.Size(277, 255);
            this.pictureBoxCEEBK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCEEBK.TabIndex = 48;
            this.pictureBoxCEEBK.TabStop = false;
            // 
            // pictureBoxFSKI
            // 
            this.pictureBoxFSKI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFSKI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFSKI.Image")));
            this.pictureBoxFSKI.Location = new System.Drawing.Point(537, 214);
            this.pictureBoxFSKI.Name = "pictureBoxFSKI";
            this.pictureBoxFSKI.Size = new System.Drawing.Size(277, 261);
            this.pictureBoxFSKI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFSKI.TabIndex = 0;
            this.pictureBoxFSKI.TabStop = false;
            // 
            // PlacarKumite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.pictureBoxCEEBK);
            this.Controls.Add(this.labelSJ);
            this.Controls.Add(this.buttonAoWazariUp);
            this.Controls.Add(this.labelAOPoints);
            this.Controls.Add(this.buttonAoJogaiDown);
            this.Controls.Add(this.textBoxAoAssociation);
            this.Controls.Add(this.buttonAoJogaiUp);
            this.Controls.Add(this.labelAoAssociation);
            this.Controls.Add(this.labelAoJogai);
            this.Controls.Add(this.textBoxNameAo);
            this.Controls.Add(this.labelShiroAB);
            this.Controls.Add(this.labelNameAo);
            this.Controls.Add(this.buttonAoAtenaiBehaviorDown);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.buttonAoAtenaiBehaviorUp);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelAoAtenaiBehavior);
            this.Controls.Add(this.pictureBoxFSKI);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAoWazariDown);
            this.Controls.Add(this.comboBoxMinutes);
            this.Controls.Add(this.panelAka);
            this.Controls.Add(this.labelShiroWazari);
            this.Controls.Add(this.labelShiroIponn);
            this.Controls.Add(this.buttonAoIponnDown);
            this.Controls.Add(this.buttonAoIponnUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PlacarKumite";
            this.Text = "Placar Kumite";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlacarKumite_KeyDown);
            this.panelAka.ResumeLayout(false);
            this.panelAka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCEEBK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFSKI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerKumite;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.PictureBox pictureBoxFSKI;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboBoxMinutes;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelNameAo;
        private System.Windows.Forms.TextBox textBoxNameAo;
        private System.Windows.Forms.Label labelAoAssociation;
        private System.Windows.Forms.TextBox textBoxAoAssociation;
        private System.Windows.Forms.Label labelAOPoints;
        private System.Windows.Forms.Label labelSJ;
        private System.Windows.Forms.Button buttonAoJogaiDown;
        private System.Windows.Forms.Button buttonAoJogaiUp;
        private System.Windows.Forms.Label labelAoJogai;
        private System.Windows.Forms.Label labelShiroAB;
        private System.Windows.Forms.Button buttonAoAtenaiBehaviorDown;
        private System.Windows.Forms.Button buttonAoAtenaiBehaviorUp;
        private System.Windows.Forms.Label labelAoAtenaiBehavior;
        private System.Windows.Forms.Button buttonAoWazariDown;
        private System.Windows.Forms.Button buttonAoWazariUp;
        private System.Windows.Forms.Label labelShiroWazari;
        private System.Windows.Forms.Button buttonAoIponnDown;
        private System.Windows.Forms.Button buttonAoIponnUp;
        private System.Windows.Forms.Label labelShiroIponn;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.Label labelNameAka;
        private System.Windows.Forms.TextBox textBoxNameAka;
        private System.Windows.Forms.Label labelAkaAssociation;
        private System.Windows.Forms.TextBox textBoxAkaAssociation;
        private System.Windows.Forms.Label labelAkaIponn;
        private System.Windows.Forms.Button buttonAkaIponnUp;
        private System.Windows.Forms.Button buttonAkaIponnDown;
        private System.Windows.Forms.Label labelAkaWazari;
        private System.Windows.Forms.Button buttonAkaWazariUp;
        private System.Windows.Forms.Button buttonAkaWazariDown;
        private System.Windows.Forms.Button buttonAkaAtenaiBehaviorUp;
        private System.Windows.Forms.Button buttonAkaAtenaiBehaviorDown;
        private System.Windows.Forms.Label labelAkaAB;
        private System.Windows.Forms.Label labelAkaJogai;
        private System.Windows.Forms.Button buttonAkaJogaiUp;
        private System.Windows.Forms.Button buttonAkaJogaiDown;
        private System.Windows.Forms.Label labelAJ;
        private System.Windows.Forms.Label labelAkaName;
        private System.Windows.Forms.Panel panelAka;
        private System.Windows.Forms.Label labelAkaAtenaiBehavior;
        private System.Windows.Forms.Label labelAkaPoints;
        private System.Windows.Forms.PictureBox pictureBoxCEEBK;
    }
}