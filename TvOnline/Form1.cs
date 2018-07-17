using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TvOnline.Modelo;
using TvOnline.Repositorio;

namespace TvOnline
{
    public partial class Form1 : Form
    {
        List<Canal> listaCh;
        int chAtual;
        bool ligado;
        bool listaOn;
        public static Image skin;

        /** CONSTRUTOR */
        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.RetroTv;

            ligado = false;                         //controla se Tv lidada / desligada
            chAtual = 1;                            //numero do canal atual inicial (não o índice de array ou lista)
            listaOn = false;                        //controla exibição da lista de canais
            chListView.SendToBack();                //lista de canais na tela
            lblCh.SendToBack();                     //label do canal na tela
            lblVol.Text = axVLC.volume.ToString();  //label que exibe o volume do audio
            skin = Properties.Resources.old_tv_clipart_47;
        }


        /// <summary>
        /// Metodo da classe sobrescrito para fechar toda a aplicação
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.Dispose();
            Application.Exit();
        }


        /// <summary>
        /// Liga ou desliga a TV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ligarDesligar(object sender, EventArgs e)
        {
            if (!ligado)
            {
                AtualizaListaCh();

                if (listaCh != null && listaCh.Count > 0)
                {
                    //btnPower.Text = "Desl";
                    exibirCanal(listaCh[-1 + chAtual]);
                    toolTip1.SetToolTip(TVpic, "Clique duplo sobre a tela para FULLSCREEN");
                }
                else
                {
                    chAtual = 0;
                    chuviscoPic.BringToFront();
                    rotularCanal("Fora do ar!", "Não há canais registrados");
                }
            }
            else
            {
                listaCh.Clear();
                //btnPower.Text = "Liga";
                rotularCanal("", "Deligado!");
                picLogo.Image = Properties.Resources.RetroTvPNG;
                listaOn = false;
                axVLC.playlist.stop();
                TVpic.BringToFront();
                toolTip1.SetToolTip(TVpic, "");
            }
            ligado = !ligado;
        }

        /// <summary>
        /// Atualiza a lista na aplicação buscando no BD
        /// </summary>
        private void AtualizaListaCh()
        {
            if (listaCh != null) listaCh.Clear();
            listaCh = new List<Canal>();
            TvBD canaisBD = new TvBD();
            listaCh = canaisBD.BuscaTodosCanais();
            TVpic.Image = skin;
        }

        /// <summary>
        /// Exibe e carrega o canal através do link, trazendo pra frente no layout
        /// </summary>
        /// <param name="channel">O canal que será carregado</param>
        private void exibirCanal (Canal channel)
        {
            axVLC.playlist.stop();
            try
            {
                listaOn = false;
                string absUri = new Uri(channel.TvUrl).AbsoluteUri.ToString();
                if (!string.IsNullOrEmpty(absUri))
                {
                    axVLC.playlist.items.clear();
                    axVLC.playlist.add(absUri);
                    axVLC.playlist.play();
                    axVLC.BringToFront();
                }
                else
                {
                    picLogo.Image = Properties.Resources.RetroTvPNG;
                    chuviscoPic.BringToFront();
                }

                rotularCanal(channel);
                //(channel.Numero).ToString("000"), channel.Nome
            }
            catch (Exception ex)
            {
                chuviscoPic.BringToFront();
                picLogo.Image = Properties.Resources.RetroTvPNG;
                rotularCanal(ex.Message, "Fora do ar! :-(");
            }
        }


        /// <summary>
        /// Rotula a tela e a barra de titulo, se um canal for passado como parametro.
        /// </summary>
        /// <param name="channel">objeto Canal de onde são retiradas as informações de rotulagem</param>
        private void rotularCanal(Canal channel)
        {
            this.Text = Properties.Resources.AppName +" - Canal " + channel.Numero.ToString("000") + ": " + channel.Nome;
            lblCh.Text = "Canal " + channel.Numero.ToString("000") + ": "+ channel.Nome;

            if (!string.IsNullOrEmpty(channel.LogoUrl))
            {
                string picUri = new Uri(channel.LogoUrl).AbsoluteUri.ToString();
                picLogo.Load(picUri);
            }
            else
                picLogo.Image = Properties.Resources.RetroTvPNG;

            lblCh.BringToFront();
        }


        /// <summary>
        /// Rotula a tela e a barra de título com strings passadas como parametro.
        /// </summary>
        /// <param name="rotulo">Uma string contendo o texto a ser exibido na tela. Se vazio somente titulo preenchido</param>
        /// <param name="titulo">String contendo o texto a exibir na barra de titulo</param>
        private void rotularCanal(string rotulo, string titulo)
        {
            if (string.IsNullOrEmpty(rotulo))
            {
                this.Text = Properties.Resources.AppName + " - "+ titulo;
            }
            else
            {
                this.Text = Properties.Resources.AppName + " - Canal: "+ chAtual.ToString("000") +" "+ titulo;
                lblCh.Text = "Canal: "+ chAtual.ToString("000") +" - "+ rotulo;
                lblCh.BringToFront();
            }

        }


        /// <summary>
        /// Chamado pelo botão para mudar o canal em exibição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chMudar(object sender, EventArgs e)
        {
            if (ligado) {

                //verificando primeiro o objeto origem da chamada
                var obj = new Control();
                if (sender.GetType().Name == "ListView")
                    obj = (ListView)sender;
                else if (sender.GetType().Name == "Button")
                    obj = (Button)sender;

                switch (obj.Name)
                {
                    case "btnChMais":
                        if (chAtual < listaCh.Count) chAtual += 1;
                        else chAtual = 1;
                        if (listaCh != null && listaCh.Count > 0)
                            exibirCanal(listaCh.ElementAt(-1 + chAtual)); //exibirCanal(listaCh[(-1+chAtual)]);
                        break;

                    case "btnChMenos":
                        if (chAtual > 1) chAtual -= 1;
                        else chAtual = listaCh.Count;
                        if (listaCh != null && listaCh.Count > 0)
                            exibirCanal(listaCh.ElementAt(-1+chAtual));
                        break;

                    case "chListView":
                        if (chAtual != (chListView.SelectedItems[0].Index + 1))
                        {
                            chAtual = (chListView.SelectedItems[0].Index + 1);
                            if (listaCh != null && listaCh.Count > 0)
                                exibirCanal(listaCh.ElementAt(-1 + chAtual)); //exibirCanal(listaCh[(-1+chAtual)]);
                        }
                        else
                        {
                            listarCanais(obj, e); //tira a lista de exibição
                        }
                        break;

                    default:
                        break;
                }
                
            }
        }


        /// <summary>
        /// Chamado pelo botão para listar os canais.
        /// Alterna entre mostrar ou ocultar a lista de canais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listarCanais (object sender, EventArgs e)
        {
            if (ligado)
            {
                chListView.Items.Clear();

                if (listaOn)
                    chListView.SendToBack();
                else
                {
                    chListView.BringToFront();
                    carregaLista();
                }

                listaOn = !listaOn;
            }
        }


        /// <summary>
        /// Carrega a lista de canais
        /// </summary>
        private void carregaLista()
        {   
            if (listaCh != null && listaCh.Count > 0)
            {
                foreach (var um in listaCh)
                {
                    ListViewItem item = new ListViewItem(um.Numero.ToString("000"));
                    item.SubItems.Add(um.Nome);
                    item.SubItems.Add(um.Grupo);
                    item.SubItems.Add(um.Pais);

                    chListView.Items.Add(item);
                }
            }   
        }


        /// <summary>
        ///Metodo chamado no double-click sobre um item na lista de canais 
        /// </summary>
        private void chListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chMudar(sender, e);
        }


        //exibe uma tela sobre o desenvolvimento da aplicação
        private void btnSobre_Click(object sender, EventArgs e)
        {
            SobreForm janelaSobre = new SobreForm();
            janelaSobre.ShowDialog();
        }


        /// <summary>
        /// Usado para aumentar, abaixar, ou mutar o volume
        /// </summary>
        private void volumeHandler(object sender, EventArgs e)
        {
            if (ligado)
            {
                Button clicado = (Button)sender;
                if (clicado == btnMute)
                {
                    axVLC.audio.toggleMute();
                    muteVisualChange();
                }
                else
                {
                    if (axVLC.audio.mute) axVLC.audio.toggleMute();
                    
                    if (clicado == btnVolMais && axVLC.volume < 100)
                        axVLC.volume += 10;
                    else if (clicado == btnVolMenos && axVLC.volume > 0)
                        axVLC.volume -= 10;

                    muteVisualChange();
                }
            }
        }

        
        /// <summary>
        /// Troca o visual do botão de MUTE e label de volume
        /// </summary>
        private void muteVisualChange()
        {
            if (axVLC.audio.mute)
            {
                btnMute.Image = Properties.Resources.sound;
                btnMute.ForeColor = Color.GreenYellow;
                lblVol.Text = "MUTE";
                //lblVol.ForeColor = Color.Red;
            }
            else
            {
                btnMute.Image = Properties.Resources.mute;
                btnMute.ForeColor = Color.White;
                lblVol.Text = axVLC.volume.ToString();
                //lblVol.ForeColor = Color.Black;
            }
        }

        /// <summary>
        //Abre o menu da TV pssando a lista de canais
        /// </summary>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (ligado)
            {
                if (listaOn)
                {
                    chListView.SendToBack();
                    listaOn = false;
                }
                MenuForm menu = new MenuForm();
                menu.ShowDialog();
                AtualizaListaCh();
            }
        }

        public static void mudaSkin(Image novaSkin)
        {
            skin = novaSkin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OnClosed(e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //panelLeft.Visible = !panelLeft.Visible;
            if (panelLeft.Width > 0)
            {
                this.Width -= panelLeft.Width;
                panelMain.Width = panelMain.Width - panelLeft.Width;
                panelTop.Width = panelTop.Width - panelLeft.Width;
                panelLeft.Width = 0;
            }
            else
            {
                panelLeft.Width = 145;
                panelTop.Width = panelTop.Width + panelLeft.Width;
                panelMain.Width = panelMain.Width + panelLeft.Width;
                this.Width += panelLeft.Width;
            }
        }

        private Point MouseDownLocation;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = MouseDownLocation = e.Location;
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void btnFechar_MouseHover(object sender, EventArgs e)
        {
            //if (btnFechar.BackColor == Color.SkyBlue)
                btnFechar.BackColor = Color.Red;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.SkyBlue;
        }
    }
}
