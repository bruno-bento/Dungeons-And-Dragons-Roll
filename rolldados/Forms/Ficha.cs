using System;
using System.Windows.Forms;

namespace rolldados
{
    public partial class Ficha : Form
    {
        public Ficha()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();//fecha o Form que estava no painel.
        }
    }
}
