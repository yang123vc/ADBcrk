﻿namespace ADBCrk
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_AI = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStato = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istruzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiECondizioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AE = new System.Windows.Forms.Button();
            this.btn_LR = new System.Windows.Forms.Button();
            this.btn_AU = new System.Windows.Forms.Button();
            this.btn_ID = new System.Windows.Forms.Button();
            this.btn_DW = new System.Windows.Forms.Button();
            this.btn_MU = new System.Windows.Forms.Button();
            this.btn_FL = new System.Windows.Forms.Button();
            this.btn_PL = new System.Windows.Forms.Button();
            this.btn_PR = new System.Windows.Forms.Button();
            this.btn_PS = new System.Windows.Forms.Button();
            this.btn_SG = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_VisualizzaLOG = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chk_BackupFirst = new System.Windows.Forms.CheckBox();
            this.chk_ProgrammaNonDisponibile = new System.Windows.Forms.CheckBox();
            this.lbl_Descrizione = new System.Windows.Forms.Label();
            this.prBar = new System.Windows.Forms.ProgressBar();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lbldescrizioneinformazioni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AI
            // 
            this.btn_AI.BackColor = System.Drawing.Color.Transparent;
            this.btn_AI.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AI.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_AI.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_AI.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AI.Image = ((System.Drawing.Image)(resources.GetObject("btn_AI.Image")));
            this.btn_AI.Location = new System.Drawing.Point(118, 170);
            this.btn_AI.Name = "btn_AI";
            this.btn_AI.Size = new System.Drawing.Size(78, 75);
            this.btn_AI.TabIndex = 0;
            this.btn_AI.UseVisualStyleBackColor = false;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightGreen;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStato});
            this.statusStrip.Location = new System.Drawing.Point(0, 450);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(400, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStato
            // 
            this.lblStato.Name = "lblStato";
            this.lblStato.Size = new System.Drawing.Size(12, 17);
            this.lblStato.Text = "/";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFOToolStripMenuItem,
            this.chiudiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // iNFOToolStripMenuItem
            // 
            this.iNFOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istruzioniToolStripMenuItem,
            this.terminiECondizioniToolStripMenuItem,
            this.infoToolStripMenuItem1});
            this.iNFOToolStripMenuItem.Name = "iNFOToolStripMenuItem";
            this.iNFOToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.iNFOToolStripMenuItem.Text = "INFO";
            // 
            // istruzioniToolStripMenuItem
            // 
            this.istruzioniToolStripMenuItem.Name = "istruzioniToolStripMenuItem";
            this.istruzioniToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.istruzioniToolStripMenuItem.Text = "Istruzioni";
            this.istruzioniToolStripMenuItem.Click += new System.EventHandler(this.istruzioniToolStripMenuItem_Click);
            // 
            // terminiECondizioniToolStripMenuItem
            // 
            this.terminiECondizioniToolStripMenuItem.Name = "terminiECondizioniToolStripMenuItem";
            this.terminiECondizioniToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.terminiECondizioniToolStripMenuItem.Text = "Termini e Condizioni";
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.infoToolStripMenuItem1.Text = "Info";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.chiudiToolStripMenuItem.Text = "Chiudi";
            // 
            // btn_AE
            // 
            this.btn_AE.BackColor = System.Drawing.Color.Transparent;
            this.btn_AE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AE.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_AE.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_AE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AE.Image = ((System.Drawing.Image)(resources.GetObject("btn_AE.Image")));
            this.btn_AE.Location = new System.Drawing.Point(204, 356);
            this.btn_AE.Name = "btn_AE";
            this.btn_AE.Size = new System.Drawing.Size(78, 75);
            this.btn_AE.TabIndex = 3;
            this.btn_AE.UseVisualStyleBackColor = false;
            // 
            // btn_LR
            // 
            this.btn_LR.BackColor = System.Drawing.Color.Transparent;
            this.btn_LR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_LR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_LR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_LR.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_LR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_LR.Image = ((System.Drawing.Image)(resources.GetObject("btn_LR.Image")));
            this.btn_LR.Location = new System.Drawing.Point(204, 263);
            this.btn_LR.Name = "btn_LR";
            this.btn_LR.Size = new System.Drawing.Size(78, 75);
            this.btn_LR.TabIndex = 4;
            this.btn_LR.UseVisualStyleBackColor = false;
            // 
            // btn_AU
            // 
            this.btn_AU.BackColor = System.Drawing.Color.Transparent;
            this.btn_AU.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AU.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_AU.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_AU.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AU.Image = ((System.Drawing.Image)(resources.GetObject("btn_AU.Image")));
            this.btn_AU.Location = new System.Drawing.Point(204, 170);
            this.btn_AU.Name = "btn_AU";
            this.btn_AU.Size = new System.Drawing.Size(78, 75);
            this.btn_AU.TabIndex = 4;
            this.btn_AU.UseVisualStyleBackColor = false;
            // 
            // btn_ID
            // 
            this.btn_ID.BackColor = System.Drawing.Color.Transparent;
            this.btn_ID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ID.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ID.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_ID.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ID.Image = ((System.Drawing.Image)(resources.GetObject("btn_ID.Image")));
            this.btn_ID.Location = new System.Drawing.Point(118, 263);
            this.btn_ID.Name = "btn_ID";
            this.btn_ID.Size = new System.Drawing.Size(78, 75);
            this.btn_ID.TabIndex = 4;
            this.btn_ID.UseVisualStyleBackColor = false;
            // 
            // btn_DW
            // 
            this.btn_DW.BackColor = System.Drawing.Color.Transparent;
            this.btn_DW.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_DW.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_DW.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_DW.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DW.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_DW.Image = ((System.Drawing.Image)(resources.GetObject("btn_DW.Image")));
            this.btn_DW.Location = new System.Drawing.Point(32, 170);
            this.btn_DW.Name = "btn_DW";
            this.btn_DW.Size = new System.Drawing.Size(78, 75);
            this.btn_DW.TabIndex = 4;
            this.btn_DW.UseVisualStyleBackColor = false;
            // 
            // btn_MU
            // 
            this.btn_MU.BackColor = System.Drawing.Color.Transparent;
            this.btn_MU.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_MU.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_MU.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_MU.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_MU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MU.Image = ((System.Drawing.Image)(resources.GetObject("btn_MU.Image")));
            this.btn_MU.Location = new System.Drawing.Point(290, 263);
            this.btn_MU.Name = "btn_MU";
            this.btn_MU.Size = new System.Drawing.Size(78, 75);
            this.btn_MU.TabIndex = 4;
            this.btn_MU.UseVisualStyleBackColor = false;
            // 
            // btn_FL
            // 
            this.btn_FL.BackColor = System.Drawing.Color.Transparent;
            this.btn_FL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_FL.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_FL.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_FL.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_FL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_FL.Image = ((System.Drawing.Image)(resources.GetObject("btn_FL.Image")));
            this.btn_FL.Location = new System.Drawing.Point(290, 356);
            this.btn_FL.Name = "btn_FL";
            this.btn_FL.Size = new System.Drawing.Size(78, 75);
            this.btn_FL.TabIndex = 4;
            this.btn_FL.UseVisualStyleBackColor = false;
            // 
            // btn_PL
            // 
            this.btn_PL.BackColor = System.Drawing.Color.Transparent;
            this.btn_PL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_PL.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_PL.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_PL.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_PL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_PL.Image = ((System.Drawing.Image)(resources.GetObject("btn_PL.Image")));
            this.btn_PL.Location = new System.Drawing.Point(32, 263);
            this.btn_PL.Name = "btn_PL";
            this.btn_PL.Size = new System.Drawing.Size(78, 75);
            this.btn_PL.TabIndex = 5;
            this.btn_PL.UseVisualStyleBackColor = false;
            // 
            // btn_PR
            // 
            this.btn_PR.BackColor = System.Drawing.Color.Transparent;
            this.btn_PR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_PR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_PR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_PR.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_PR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_PR.Image = ((System.Drawing.Image)(resources.GetObject("btn_PR.Image")));
            this.btn_PR.Location = new System.Drawing.Point(118, 357);
            this.btn_PR.Name = "btn_PR";
            this.btn_PR.Size = new System.Drawing.Size(78, 75);
            this.btn_PR.TabIndex = 7;
            this.btn_PR.UseVisualStyleBackColor = false;
            // 
            // btn_PS
            // 
            this.btn_PS.BackColor = System.Drawing.Color.Transparent;
            this.btn_PS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_PS.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_PS.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_PS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_PS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_PS.Image = ((System.Drawing.Image)(resources.GetObject("btn_PS.Image")));
            this.btn_PS.Location = new System.Drawing.Point(290, 170);
            this.btn_PS.Name = "btn_PS";
            this.btn_PS.Size = new System.Drawing.Size(78, 75);
            this.btn_PS.TabIndex = 8;
            this.btn_PS.UseVisualStyleBackColor = false;
            this.btn_PS.Click += new System.EventHandler(this.btn_PS_Click);
            // 
            // btn_SG
            // 
            this.btn_SG.BackColor = System.Drawing.Color.Transparent;
            this.btn_SG.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SG.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_SG.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_SG.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SG.Image = ((System.Drawing.Image)(resources.GetObject("btn_SG.Image")));
            this.btn_SG.Location = new System.Drawing.Point(32, 357);
            this.btn_SG.Name = "btn_SG";
            this.btn_SG.Size = new System.Drawing.Size(78, 75);
            this.btn_SG.TabIndex = 9;
            this.btn_SG.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_VisualizzaLOG);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.chk_BackupFirst);
            this.groupBox1.Controls.Add(this.chk_ProgrammaNonDisponibile);
            this.groupBox1.Controls.Add(this.lbl_Descrizione);
            this.groupBox1.Location = new System.Drawing.Point(32, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 137);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADBcrk";
            // 
            // chk_VisualizzaLOG
            // 
            this.chk_VisualizzaLOG.AutoSize = true;
            this.chk_VisualizzaLOG.Location = new System.Drawing.Point(172, 76);
            this.chk_VisualizzaLOG.Name = "chk_VisualizzaLOG";
            this.chk_VisualizzaLOG.Size = new System.Drawing.Size(97, 17);
            this.chk_VisualizzaLOG.TabIndex = 4;
            this.chk_VisualizzaLOG.Text = "Visualizza LOG";
            this.chk_VisualizzaLOG.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(172, 99);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(163, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Accetto Termini  e Condizioni";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // chk_BackupFirst
            // 
            this.chk_BackupFirst.AutoSize = true;
            this.chk_BackupFirst.Location = new System.Drawing.Point(9, 76);
            this.chk_BackupFirst.Name = "chk_BackupFirst";
            this.chk_BackupFirst.Size = new System.Drawing.Size(85, 17);
            this.chk_BackupFirst.TabIndex = 2;
            this.chk_BackupFirst.Text = "Backup First";
            this.chk_BackupFirst.UseVisualStyleBackColor = true;
            // 
            // chk_ProgrammaNonDisponibile
            // 
            this.chk_ProgrammaNonDisponibile.AutoSize = true;
            this.chk_ProgrammaNonDisponibile.Location = new System.Drawing.Point(9, 99);
            this.chk_ProgrammaNonDisponibile.Name = "chk_ProgrammaNonDisponibile";
            this.chk_ProgrammaNonDisponibile.Size = new System.Drawing.Size(152, 17);
            this.chk_ProgrammaNonDisponibile.TabIndex = 1;
            this.chk_ProgrammaNonDisponibile.Text = "Programma non disponibile";
            this.chk_ProgrammaNonDisponibile.UseVisualStyleBackColor = true;
            this.chk_ProgrammaNonDisponibile.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_Descrizione
            // 
            this.lbl_Descrizione.AutoSize = true;
            this.lbl_Descrizione.Location = new System.Drawing.Point(6, 25);
            this.lbl_Descrizione.Name = "lbl_Descrizione";
            this.lbl_Descrizione.Size = new System.Drawing.Size(12, 13);
            this.lbl_Descrizione.TabIndex = 0;
            this.lbl_Descrizione.Text = "/";
            // 
            // prBar
            // 
            this.prBar.Location = new System.Drawing.Point(0, 437);
            this.prBar.Name = "prBar";
            this.prBar.Size = new System.Drawing.Size(400, 23);
            this.prBar.TabIndex = 12;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlInfo.Controls.Add(this.lbldescrizioneinformazioni);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.button1);
            this.pnlInfo.Location = new System.Drawing.Point(0, 124);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(400, 250);
            this.pnlInfo.TabIndex = 13;
            this.pnlInfo.Visible = false;
            // 
            // lbldescrizioneinformazioni
            // 
            this.lbldescrizioneinformazioni.AutoSize = true;
            this.lbldescrizioneinformazioni.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbldescrizioneinformazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.lbldescrizioneinformazioni.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbldescrizioneinformazioni.Location = new System.Drawing.Point(3, 45);
            this.lbldescrizioneinformazioni.Name = "lbldescrizioneinformazioni";
            this.lbldescrizioneinformazioni.Size = new System.Drawing.Size(35, 13);
            this.lbldescrizioneinformazioni.TabIndex = 2;
            this.lbldescrizioneinformazioni.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORMAZIONI";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(344, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "chiudi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 472);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_SG);
            this.Controls.Add(this.btn_PL);
            this.Controls.Add(this.btn_PR);
            this.Controls.Add(this.btn_PS);
            this.Controls.Add(this.btn_FL);
            this.Controls.Add(this.btn_DW);
            this.Controls.Add(this.btn_MU);
            this.Controls.Add(this.btn_ID);
            this.Controls.Add(this.btn_AU);
            this.Controls.Add(this.btn_LR);
            this.Controls.Add(this.btn_AE);
            this.Controls.Add(this.btn_AI);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.prBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AI;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istruzioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiECondizioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.Button btn_AE;
        private System.Windows.Forms.Button btn_LR;
        private System.Windows.Forms.Button btn_AU;
        private System.Windows.Forms.Button btn_ID;
        private System.Windows.Forms.Button btn_DW;
        private System.Windows.Forms.Button btn_MU;
        private System.Windows.Forms.Button btn_FL;
        private System.Windows.Forms.Button btn_PL;
        private System.Windows.Forms.Button btn_PR;
        private System.Windows.Forms.Button btn_PS;
        private System.Windows.Forms.Button btn_SG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Descrizione;
        private System.Windows.Forms.CheckBox chk_BackupFirst;
        private System.Windows.Forms.CheckBox chk_ProgrammaNonDisponibile;
        private System.Windows.Forms.CheckBox chk_VisualizzaLOG;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ToolStripStatusLabel lblStato;
        private System.Windows.Forms.ProgressBar prBar;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbldescrizioneinformazioni;
        private System.Windows.Forms.Label label1;
    }
}

