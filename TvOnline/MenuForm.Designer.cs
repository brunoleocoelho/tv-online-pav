namespace TvOnline
{
    partial class MenuForm
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGerCanais = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.listViewMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageSkin = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageGerCanais.SuspendLayout();
            this.tabPageSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(6, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(267, 15);
            label2.TabIndex = 2;
            label2.Text = "Clique-duplo sobre o canal desejado para abri-lo.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TV Online - Menu";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGerCanais);
            this.tabControl.Controls.Add(this.tabPageSkin);
            this.tabControl.Location = new System.Drawing.Point(6, 42);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(553, 345);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageGerCanais
            // 
            this.tabPageGerCanais.Controls.Add(this.btnNovo);
            this.tabPageGerCanais.Controls.Add(label2);
            this.tabPageGerCanais.Controls.Add(this.listViewMenu);
            this.tabPageGerCanais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageGerCanais.Location = new System.Drawing.Point(4, 22);
            this.tabPageGerCanais.Name = "tabPageGerCanais";
            this.tabPageGerCanais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGerCanais.Size = new System.Drawing.Size(545, 319);
            this.tabPageGerCanais.TabIndex = 0;
            this.tabPageGerCanais.Text = "Gerenciar Canais";
            this.tabPageGerCanais.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.Black;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(415, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(124, 38);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Adic. Canal";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnNovo, "Adiciona Novo Canal");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.novo_Click);
            // 
            // listViewMenu
            // 
            this.listViewMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewMenu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMenu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.listViewMenu.FullRowSelect = true;
            this.listViewMenu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMenu.HideSelection = false;
            this.listViewMenu.Location = new System.Drawing.Point(9, 50);
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.Size = new System.Drawing.Size(530, 263);
            this.listViewMenu.TabIndex = 1;
            this.listViewMenu.TabStop = false;
            this.listViewMenu.UseCompatibleStateImageBehavior = false;
            this.listViewMenu.View = System.Windows.Forms.View.Details;
            this.listViewMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewMenu_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Ch";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Grupo";
            this.columnHeader3.Width = 168;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pais";
            this.columnHeader4.Width = 141;
            // 
            // tabPageSkin
            // 
            this.tabPageSkin.Controls.Add(this.label6);
            this.tabPageSkin.Controls.Add(this.label5);
            this.tabPageSkin.Controls.Add(this.label4);
            this.tabPageSkin.Controls.Add(this.label3);
            this.tabPageSkin.Controls.Add(this.picBox3);
            this.tabPageSkin.Controls.Add(this.picBox4);
            this.tabPageSkin.Controls.Add(this.picBox1);
            this.tabPageSkin.Controls.Add(this.picBox2);
            this.tabPageSkin.Location = new System.Drawing.Point(4, 22);
            this.tabPageSkin.Name = "tabPageSkin";
            this.tabPageSkin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSkin.Size = new System.Drawing.Size(545, 319);
            this.tabPageSkin.TabIndex = 1;
            this.tabPageSkin.Text = "Trocar Skin";
            this.tabPageSkin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Anos 90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Anos 60";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Anos 80";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anos 70";
            // 
            // picBox3
            // 
            this.picBox3.Image = global::TvOnline.Properties.Resources.tv_80s;
            this.picBox3.Location = new System.Drawing.Point(62, 165);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(193, 135);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox3.TabIndex = 1;
            this.picBox3.TabStop = false;
            this.picBox3.DoubleClick += new System.EventHandler(this.skinTv_DoubleClick);
            // 
            // picBox4
            // 
            this.picBox4.Image = global::TvOnline.Properties.Resources.tv_90s;
            this.picBox4.Location = new System.Drawing.Point(346, 165);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(193, 135);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox4.TabIndex = 1;
            this.picBox4.TabStop = false;
            this.picBox4.DoubleClick += new System.EventHandler(this.skinTv_DoubleClick);
            // 
            // picBox1
            // 
            this.picBox1.Image = global::TvOnline.Properties.Resources.OLD_SCHOOL_TV;
            this.picBox1.Location = new System.Drawing.Point(62, 6);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(193, 135);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            this.picBox1.DoubleClick += new System.EventHandler(this.skinTv_DoubleClick);
            // 
            // picBox2
            // 
            this.picBox2.Image = global::TvOnline.Properties.Resources.old_tv_clipart_47;
            this.picBox2.Location = new System.Drawing.Point(346, 6);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(193, 135);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 0;
            this.picBox2.TabStop = false;
            this.picBox2.DoubleClick += new System.EventHandler(this.skinTv_DoubleClick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 392);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TV Online - Menu";
            this.tabControl.ResumeLayout(false);
            this.tabPageGerCanais.ResumeLayout(false);
            this.tabPageGerCanais.PerformLayout();
            this.tabPageSkin.ResumeLayout(false);
            this.tabPageSkin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGerCanais;
        private System.Windows.Forms.ListView listViewMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPageSkin;
        private System.Windows.Forms.PictureBox picBox4;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}