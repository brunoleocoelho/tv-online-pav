using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TvOnline.Modelo;
using TvOnline.Repositorio;

namespace TvOnline
{
    public partial class MenuForm : Form
    {
        List<Canal> listaDeCanais;

        /** CONSTRUTOR */
        public MenuForm()
        {
            InitializeComponent();
            TvBD listaBD = new TvBD();
            listaDeCanais = new List<Canal>();
            listaDeCanais = listaBD.BuscaTodosCanais();
            if (listaDeCanais != null && listaDeCanais.Count > 0)
                PreencheLista(listaDeCanais);
            else
                MessageBox.Show("ATENÇÂO! \nNão há canais registrados.", "Lista de Canais vazia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }


        /** METODOS PUBLICOS*/

        /// <summary>
        /// Usado para preenchimento da lista de canais na tela
        /// </summary>
        /// <param name="ch"></param>
        public void PreencheLista(List<Canal> ch)
        {
            listViewMenu.Items.Clear();
            foreach (var um in ch)
            {
                ListViewItem item = new ListViewItem(um.Numero.ToString("000"));
                item.Tag = um;
                item.SubItems.Add(um.Nome);
                item.SubItems.Add(um.Grupo);
                item.SubItems.Add(um.Pais);
                listViewMenu.Items.Add(item);
            }
        }

        /// <summary>
        /// Atualiza a listagem de canais em memoria
        /// </summary>
        public void AtualizaListaCh()
        {
            if (listaDeCanais != null)
                listaDeCanais.Clear();
            listaDeCanais = new List<Canal>();
            TvBD canaisBD = new TvBD();
            listaDeCanais = canaisBD.BuscaTodosCanais();
        }


        /** METODOS PRIVADOS*/

        /// <summary>
        /// Usaado ao clicar sobre o botão "Adic.Canal"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void novo_Click(object sender, EventArgs e)
        {
            CanalForm formNovo = new CanalForm();
            Canal c = new Canal();
            if (formNovo.setAction("Novo", c))
                formNovo.ShowDialog();
            
            AtualizaListaCh();
            PreencheLista(listaDeCanais);

        }

        /// <summary>
        /// Usado ao clique-duplo sobre um item da lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visualizar_DoubleClick(object sender, EventArgs e)
        {
            ListView lista = (ListView)sender;
            Canal c = (Canal)lista.SelectedItems[0].Tag;
            CanalForm formVisualizar = new CanalForm();
            if (formVisualizar.setAction("Visualizar", c))
                formVisualizar.ShowDialog();

            AtualizaListaCh();
            PreencheLista(listaDeCanais);
        }

        /// <summary>
        /// Usado para o clique-duplo no item na listview na tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            visualizar_DoubleClick(sender, e);
        }

        private void skinTv_DoubleClick(object sender, EventArgs e)
        {
            PictureBox skin = (PictureBox)sender;
            Form1.mudaSkin(skin.Image);
            this.Dispose();
        }
    }
}

