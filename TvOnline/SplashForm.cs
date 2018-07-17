using System;
using System.Windows.Forms;

namespace TvOnline
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            
        }
        //temporizador da barra de carregamento
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (splash_progBar.Value < splash_progBar.Maximum)
            {
                splash_progBar.Value += 3;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Form1 tv = new Form1();
                tv.Show();
                //this.Close();
                   
            }
        }
    }
}
