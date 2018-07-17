using System;
using System.Windows.Forms;
using TvOnline.Modelo;
using TvOnline.Repositorio;

namespace TvOnline
{
    public partial class CanalForm : Form
    {
        public static Canal ch = new Canal();

        public CanalForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Define que ação será tomada em vários sentidos dentro do Form
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public bool setAction(string action, Canal c)
        {

            lblAction.Text = action + " Canal";
            
            if(action == "Novo")
            {
                this.Text = "Inserindo Novo Canal";
                lblInfo.Visible = true;
                btnExcluir.Visible = false;
                btnCancelar.Click += sairCanalForm;
                btnSalvar.Click += InsereCanal_Click;
                return true;
            }
            else if (action == "Visualizar")
            {
                this.Text = "Visualizando Dados do Canal"; 
                preencheForm(c); 
                bloqueioDeCampos();
                lblInfo.Visible = false;
                btnExcluir.Visible = false;
                btnCancelar.Click -= cancelaEditar_Click;
                btnCancelar.Click += sairCanalForm;
                btnSalvar.Text = "Editar";
                btnSalvar.Image = Properties.Resources.pencil_green;
                btnSalvar.Click -= InsereCanal_Click;
                btnSalvar.Click -= AlterarCanal_Click;
                btnSalvar.Click += ModoEditar_Click;
                return true;
            }
            else if (action == "Editar")
            {
                this.Text = "Editando Dados do Canal";
                bloqueioDeCampos();
                lblInfo.Visible = false;
                btnExcluir.Visible = true;
                btnExcluir.Click += ExcluiCanal_Click;
                btnCancelar.Click -= sairCanalForm;
                btnCancelar.Click += cancelaEditar_Click;
                btnSalvar.Text = "Salvar";
                btnSalvar.Image = Properties.Resources.save_tick;
                btnSalvar.Click -= InsereCanal_Click;
                btnSalvar.Click -= ModoEditar_Click;
                btnSalvar.Click += AlterarCanal_Click;
                return true;
            }
            else
            { //caso não consiga definir a ação, exibe uma mensagem
                this.Dispose();
                MessageBox.Show("Houve algum problema ao abrir a janela.", "Erro");
                return false;
            }
        }


        /// <summary>
        /// Referente ao botão de salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsereCanal_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" || txtTvUrl.Text.Trim() == "")
            {
                MessageBox.Show("Campos marcados com * (asterisco) são obrigatórios!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Canal c = new Canal();
                c.Nome = txtNome.Text.Trim();
                c.TvUrl = txtTvUrl.Text.Trim();
                c.LogoUrl = txtLogoUrl.Text.Trim();
                c.Grupo = txtGrupo.Text.Trim();
                c.Pais = txtPais.Text.Trim();

                TvBD bd = new TvBD();
                if (bd.InsereCanal(c))
                {
                    MessageBox.Show("Canal " + c.Nome + " inserido!",
                        "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Algo saiu errado! \nCanal '" + c.Nome + "' NÃO inserido! \nVerifique e tente novamente!",
                        "ERRO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Usado para alterar o canal no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlterarCanal_Click(object sender, EventArgs e)
        {
            Canal c = new Canal();
            c.Numero = int.Parse(txtNumero.Text);
            c.Nome = txtNome.Text.Trim();
            c.TvUrl = txtTvUrl.Text.Trim();
            c.LogoUrl = txtLogoUrl.Text.Trim();
            c.Grupo = txtGrupo.Text.Trim();
            c.Pais = txtPais.Text.Trim();

            TvBD db = new TvBD();
            if (db.AlteraUmCanal(c))
            {
                MessageBox.Show("Canal " + c.Nome + " alterado!",
                    "Mensagem",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Algo saiu errado! \nCanal '" + c.Nome + "' NÃO ALTERADO! \nVerifique e tente novamente!",
                    "ERRO!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Usado na exclusão de um cana do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExcluiCanal_Click(object sender, EventArgs e)
        {
            DialogResult dialogoYesNo = MessageBox.Show("Deseja realmente remover '"+ txtNome.Text +"'?" ,
                "Remover?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogoYesNo == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txtNumero.Text))
                {
                    int numCanal = int.Parse(txtNumero.Text);
                    TvBD db = new TvBD();
                    if (db.ExcluiUmCanal(numCanal))
                        MessageBox.Show("Canal removido!", "Confirmação de exclusão",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            
        }



        /// <summary>
        /// Referente ao botão de editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModoEditar_Click(object sender, EventArgs e)
        {
            //guardando todos os campos num objeto Canal do form
            if (string.IsNullOrEmpty(txtNumero.Text)) ch.Numero = 0;
            else ch.Numero = int.Parse(txtNumero.Text);
            ch.Nome = txtNome.Text.Trim();
            ch.TvUrl = txtTvUrl.Text.Trim(); 
            ch.LogoUrl = txtLogoUrl.Text.Trim();
            ch.Grupo = txtGrupo.Text.Trim();
            ch.Pais = txtPais.Text.Trim();

            setAction("Editar", ch);
        }

        /// <summary>
        /// Usado quando o usuário cancela a ação de editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelaEditar_Click(object sender, EventArgs e)
        {
            setAction("Visualizar", ch);
        }


        /// <summary>
        /// Simplesmente sai da janela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairCanalForm(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Preenche os campos na tela
        /// </summary>
        /// <param name="c"></param>
        private void preencheForm(Canal c)
        {
            //preenchendo campos na tela
            txtNumero.Text = c.Numero.ToString();
            txtNome.Text = c.Nome;
            txtTvUrl.Text = c.TvUrl;
            txtLogoUrl.Text = c.LogoUrl;
            txtGrupo.Text = c.Grupo;
            txtPais.Text = c.Pais;
        }

        /// <summary>
        /// Bloqueia / desbloqueia vários campos do formulário para edição.
        /// </summary>
        private void bloqueioDeCampos()
        {
            txtNome.Enabled = !txtNome.Enabled;
            txtTvUrl.Enabled = !txtTvUrl.Enabled;
            txtLogoUrl.Enabled = !txtLogoUrl.Enabled;
            txtGrupo.Enabled = !txtGrupo.Enabled;
            txtPais.Enabled = !txtPais.Enabled;
        }

        /// <summary>
        /// Limpa os campos ao ao cancelar durante acão de inserir novo registro
        /// </summary>
        private void limpaCampos()
        {
            txtNome.Text = "";
            txtTvUrl.Text = "";
            txtLogoUrl.Text = "";
            txtGrupo.Text = "";
            txtPais.Text = "";
        }

    }
}
