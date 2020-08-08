using System;
using System.Linq;
using System.Windows.Forms;


namespace rolldados
{
    public partial class Principal : Form
    {
        public Principal()
        {        
            InitializeComponent();
        }

        private Form ativarForm = null;

        //Abre outro Form em um painel, ajudanto configurações como Borda e Dock
        private void AbrirFormFilho(Form FormFilho)
        {        
                if (ativarForm != null) ativarForm.Close();
                ativarForm = FormFilho;
                FormFilho.TopLevel = false;
                FormFilho.FormBorderStyle = FormBorderStyle.None;
                FormFilho.Dock = DockStyle.Fill;
                panel2.Controls.Add(FormFilho);
                panel2.Tag = FormFilho;
                FormFilho.BringToFront();
                FormFilho.Show();
        }
        private void DiceRollerBtn_Click(object sender, EventArgs e)
        {
            //valida se existe se o form já esta aberto
            if (Application.OpenForms.OfType<Roll>().Count() > 0)
            {
                //Mensagem avisando que já tem um Form/Janela Aberto
                MessageBox.Show("Esta janela já está aberta!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Abre o Form (o que determina o form para abrir é o "Roll")
                AbrirFormFilho(new Roll());               
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            Application.Exit();
        }
        private void restoreBtn_Click_1(object sender, EventArgs e)
        {
            //se a janela não estiver maximizada, ela irá maximizar
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                //caso esteja, voltara ao normal
                WindowState = FormWindowState.Normal;
            }
        }
        private void minimizeBtn_Click_1(object sender, EventArgs e)
        {
            //minimiza a janela
            WindowState = FormWindowState.Minimized;
        }
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Clicando no link levar ao meu GitHub
            System.Diagnostics.Process.Start("https://github.com/bruno-bento"); 
        }
        private void fichaBtn_Click(object sender, EventArgs e)
        {
            //validação para verificar se o form está aberto
            if (Application.OpenForms.OfType<Ficha>().Count() > 0)
            {
                MessageBox.Show("Esta janela já está aberta!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AbrirFormFilho(new Ficha());
            }
        }      
    }  
}
