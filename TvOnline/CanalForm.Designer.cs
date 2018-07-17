namespace TvOnline
{
    partial class CanalForm
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanalForm));
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtLogoUrl = new System.Windows.Forms.TextBox();
            this.txtTvUrl = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(7, 76);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 17);
            label4.TabIndex = 11;
            label4.Text = "Núm. Canal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(7, 222);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(39, 17);
            label8.TabIndex = 12;
            label8.Text = "País:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(7, 193);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 17);
            label7.TabIndex = 13;
            label7.Text = "Grupo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(7, 164);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(96, 17);
            label6.TabIndex = 14;
            label6.Text = "URL do Logo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(7, 135);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(82, 17);
            label5.TabIndex = 15;
            label5.Text = "URL da TV:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(7, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 17);
            label3.TabIndex = 16;
            label3.Text = "Nome:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(199, 76);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(236, 13);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "O número do canal será criado automaticamente";
            this.lblInfo.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(118, 70);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(74, 23);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnCancelar.Image = global::TvOnline.Properties.Resources.cancel_yellow;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(286, 262);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(3);
            this.btnCancelar.Size = new System.Drawing.Size(98, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Green;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(390, 262);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(3);
            this.btnSalvar.Size = new System.Drawing.Size(98, 36);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(118, 216);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(217, 23);
            this.txtPais.TabIndex = 5;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.Location = new System.Drawing.Point(118, 187);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(217, 23);
            this.txtGrupo.TabIndex = 4;
            // 
            // txtLogoUrl
            // 
            this.txtLogoUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogoUrl.Location = new System.Drawing.Point(118, 158);
            this.txtLogoUrl.Name = "txtLogoUrl";
            this.txtLogoUrl.Size = new System.Drawing.Size(361, 23);
            this.txtLogoUrl.TabIndex = 3;
            // 
            // txtTvUrl
            // 
            this.txtTvUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTvUrl.Location = new System.Drawing.Point(118, 129);
            this.txtTvUrl.Name = "txtTvUrl";
            this.txtTvUrl.Size = new System.Drawing.Size(361, 23);
            this.txtTvUrl.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(118, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(12, 9);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(106, 38);
            this.lblAction.TabIndex = 27;
            this.lblAction.Text = "... Canal";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Crimson;
            this.btnExcluir.Image = global::TvOnline.Properties.Resources.delete_red;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(182, 262);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(3);
            this.btnExcluir.Size = new System.Drawing.Size(98, 36);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(54, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(89, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "*";
            // 
            // CanalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtLogoUrl);
            this.Controls.Add(this.txtTvUrl);
            this.Controls.Add(label4);
            this.Controls.Add(label8);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CanalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtLogoUrl;
        private System.Windows.Forms.TextBox txtTvUrl;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}