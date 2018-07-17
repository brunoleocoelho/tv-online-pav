using System.Drawing;
using System.Windows.Forms;

namespace TvOnline
{
    partial class Form1
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
            System.Windows.Forms.PictureBox picControle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnChMais = new System.Windows.Forms.Button();
            this.btnChMenos = new System.Windows.Forms.Button();
            this.btnVolMais = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblCh = new System.Windows.Forms.Label();
            this.btnSobre = new System.Windows.Forms.Button();
            this.chListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVolMenos = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.TVpic = new System.Windows.Forms.PictureBox();
            this.chuviscoPic = new System.Windows.Forms.PictureBox();
            this.lblVol = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.axVLC = new AxAXVLC.AxVLCPlugin2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            picControle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TVpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuviscoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLC)).BeginInit();
            this.SuspendLayout();
            // 
            // picControle
            // 
            picControle.Image = global::TvOnline.Properties.Resources.controle_remoto;
            picControle.Location = new System.Drawing.Point(12, 94);
            picControle.Name = "picControle";
            picControle.Size = new System.Drawing.Size(117, 356);
            picControle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picControle.TabIndex = 8;
            picControle.TabStop = false;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(20, 111);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(48, 13);
            this.lblVolume.TabIndex = 12;
            this.lblVolume.Text = "Volume:";
            // 
            // btnChMais
            // 
            this.btnChMais.BackColor = System.Drawing.SystemColors.Control;
            this.btnChMais.FlatAppearance.BorderSize = 0;
            this.btnChMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChMais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChMais.Location = new System.Drawing.Point(76, 175);
            this.btnChMais.Name = "btnChMais";
            this.btnChMais.Size = new System.Drawing.Size(38, 52);
            this.btnChMais.TabIndex = 3;
            this.btnChMais.Text = "CH +";
            this.btnChMais.UseVisualStyleBackColor = false;
            this.btnChMais.Click += new System.EventHandler(this.chMudar);
            // 
            // btnChMenos
            // 
            this.btnChMenos.BackColor = System.Drawing.SystemColors.Control;
            this.btnChMenos.FlatAppearance.BorderSize = 0;
            this.btnChMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChMenos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChMenos.Location = new System.Drawing.Point(76, 235);
            this.btnChMenos.Name = "btnChMenos";
            this.btnChMenos.Size = new System.Drawing.Size(38, 52);
            this.btnChMenos.TabIndex = 4;
            this.btnChMenos.Text = "CH  -";
            this.btnChMenos.UseVisualStyleBackColor = false;
            this.btnChMenos.Click += new System.EventHandler(this.chMudar);
            // 
            // btnVolMais
            // 
            this.btnVolMais.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolMais.FlatAppearance.BorderSize = 0;
            this.btnVolMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolMais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolMais.Location = new System.Drawing.Point(28, 175);
            this.btnVolMais.Name = "btnVolMais";
            this.btnVolMais.Size = new System.Drawing.Size(38, 52);
            this.btnVolMais.TabIndex = 6;
            this.btnVolMais.Text = "VOL +";
            this.btnVolMais.UseVisualStyleBackColor = false;
            this.btnVolMais.Click += new System.EventHandler(this.volumeHandler);
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLista.Location = new System.Drawing.Point(24, 351);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(90, 23);
            this.btnLista.TabIndex = 2;
            this.btnLista.Text = "Channel List";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.listarCanais);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMenu.Location = new System.Drawing.Point(24, 380);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(90, 23);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblCh
            // 
            this.lblCh.AutoSize = true;
            this.lblCh.BackColor = System.Drawing.Color.Black;
            this.lblCh.Font = new System.Drawing.Font("DS-Digital", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCh.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblCh.Location = new System.Drawing.Point(105, 71);
            this.lblCh.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblCh.Name = "lblCh";
            this.lblCh.Padding = new System.Windows.Forms.Padding(3);
            this.lblCh.Size = new System.Drawing.Size(42, 22);
            this.lblCh.TabIndex = 0;
            this.lblCh.Text = "CH 3";
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(12, 480);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(117, 28);
            this.btnSobre.TabIndex = 10;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // chListView
            // 
            this.chListView.BackColor = System.Drawing.SystemColors.MenuBar;
            this.chListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.chListView.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chListView.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chListView.FullRowSelect = true;
            this.chListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.chListView.HideSelection = false;
            this.chListView.Location = new System.Drawing.Point(108, 139);
            this.chListView.Name = "chListView";
            this.chListView.Size = new System.Drawing.Size(490, 270);
            this.chListView.TabIndex = 0;
            this.chListView.TabStop = false;
            this.chListView.UseCompatibleStateImageBehavior = false;
            this.chListView.View = System.Windows.Forms.View.Details;
            this.chListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Ch";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 172;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Grupo";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pais";
            this.columnHeader4.Width = 127;
            // 
            // btnVolMenos
            // 
            this.btnVolMenos.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolMenos.FlatAppearance.BorderSize = 0;
            this.btnVolMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolMenos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolMenos.Location = new System.Drawing.Point(28, 235);
            this.btnVolMenos.Name = "btnVolMenos";
            this.btnVolMenos.Size = new System.Drawing.Size(38, 52);
            this.btnVolMenos.TabIndex = 7;
            this.btnVolMenos.Text = "VOL -";
            this.btnVolMenos.UseVisualStyleBackColor = false;
            this.btnVolMenos.Click += new System.EventHandler(this.volumeHandler);
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.SystemColors.Control;
            this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMute.ForeColor = System.Drawing.Color.White;
            this.btnMute.Image = global::TvOnline.Properties.Resources.mute;
            this.btnMute.Location = new System.Drawing.Point(55, 300);
            this.btnMute.Margin = new System.Windows.Forms.Padding(0);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(28, 28);
            this.btnMute.TabIndex = 8;
            this.btnMute.Tag = "0";
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.volumeHandler);
            // 
            // TVpic
            // 
            this.TVpic.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TVpic.BackColor = System.Drawing.Color.Black;
            this.TVpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TVpic.Image = ((System.Drawing.Image)(resources.GetObject("TVpic.Image")));
            this.TVpic.InitialImage = ((System.Drawing.Image)(resources.GetObject("TVpic.InitialImage")));
            this.TVpic.Location = new System.Drawing.Point(0, 0);
            this.TVpic.Margin = new System.Windows.Forms.Padding(0);
            this.TVpic.Name = "TVpic";
            this.TVpic.Size = new System.Drawing.Size(850, 524);
            this.TVpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TVpic.TabIndex = 0;
            this.TVpic.TabStop = false;
            // 
            // chuviscoPic
            // 
            this.chuviscoPic.BackColor = System.Drawing.SystemColors.Window;
            this.chuviscoPic.Image = global::TvOnline.Properties.Resources.tvstatic;
            this.chuviscoPic.InitialImage = global::TvOnline.Properties.Resources.tvstatic;
            this.chuviscoPic.Location = new System.Drawing.Point(80, 71);
            this.chuviscoPic.Name = "chuviscoPic";
            this.chuviscoPic.Size = new System.Drawing.Size(559, 372);
            this.chuviscoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chuviscoPic.TabIndex = 3;
            this.chuviscoPic.TabStop = false;
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.lblVol.Font = new System.Drawing.Font("DS-Digital", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.ForeColor = System.Drawing.Color.Red;
            this.lblVol.Location = new System.Drawing.Point(27, 128);
            this.lblVol.Name = "lblVol";
            this.lblVol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVol.Size = new System.Drawing.Size(38, 19);
            this.lblVol.TabIndex = 11;
            this.lblVol.Text = "VOL";
            this.lblVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::TvOnline.Properties.Resources.RetroTvPNG;
            this.picLogo.Location = new System.Drawing.Point(28, 8);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(86, 67);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 13;
            this.picLogo.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.pictureBox3);
            this.panelLeft.Controls.Add(this.lblVolume);
            this.panelLeft.Controls.Add(this.picLogo);
            this.panelLeft.Controls.Add(this.btnChMais);
            this.panelLeft.Controls.Add(this.btnVolMais);
            this.panelLeft.Controls.Add(this.lblVol);
            this.panelLeft.Controls.Add(this.btnVolMenos);
            this.panelLeft.Controls.Add(this.btnLista);
            this.panelLeft.Controls.Add(this.btnMenu);
            this.panelLeft.Controls.Add(this.btnMute);
            this.panelLeft.Controls.Add(this.btnChMenos);
            this.panelLeft.Controls.Add(this.btnSobre);
            this.panelLeft.Controls.Add(picControle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 40);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(145, 525);
            this.panelLeft.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pictureBox3.Image = global::TvOnline.Properties.Resources.shutdown_24px;
            this.pictureBox3.Location = new System.Drawing.Point(84, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.ligarDesligar);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnFechar.Image = global::TvOnline.Properties.Resources.close_24;
            this.btnFechar.Location = new System.Drawing.Point(956, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            this.btnFechar.MouseHover += new System.EventHandler(this.btnFechar_MouseHover);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SkyBlue;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.btnFechar);
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(996, 40);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tv Online";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::TvOnline.Properties.Resources.Retro_TV_24px;
            this.pictureBox1.Location = new System.Drawing.Point(55, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(46, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::TvOnline.Properties.Resources.Hamb_Menu_24px;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.BackColor = System.Drawing.Color.SkyBlue;
            this.panelMain.Controls.Add(this.lblCh);
            this.panelMain.Controls.Add(this.chListView);
            this.panelMain.Controls.Add(this.TVpic);
            this.panelMain.Controls.Add(this.axVLC);
            this.panelMain.Controls.Add(this.chuviscoPic);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(146, 40);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(850, 525);
            this.panelMain.TabIndex = 17;
            // 
            // axVLC
            // 
            this.axVLC.Enabled = true;
            this.axVLC.Location = new System.Drawing.Point(79, 71);
            this.axVLC.Name = "axVLC";
            this.axVLC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLC.OcxState")));
            this.axVLC.Size = new System.Drawing.Size(560, 372);
            this.axVLC.TabIndex = 0;
            this.axVLC.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 565);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TV Online";
            this.TransparencyKey = System.Drawing.Color.Azure;
            ((System.ComponentModel.ISupportInitialize)(picControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TVpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuviscoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChMais;
        private System.Windows.Forms.PictureBox chuviscoPic;
        private System.Windows.Forms.Button btnChMenos;
        private System.Windows.Forms.Button btnVolMais;
        private System.Windows.Forms.Button btnVolMenos;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblCh;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.ListView chListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnMute;
        protected AxAXVLC.AxVLCPlugin2 axVLC;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox TVpic;
        private Panel panelLeft;
        private Button btnFechar;
        private Panel panelTop;
        private Label label1;
        private Panel panelMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblVolume;
    }
}

