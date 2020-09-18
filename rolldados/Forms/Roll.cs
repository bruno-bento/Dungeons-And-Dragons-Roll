using System;
using System.Windows.Forms;
using rolldados.OtterClass;

namespace rolldados
{
    public partial class Roll : Form
    {
        public Roll()
        {
            InitializeComponent();   
        }
        //Verifica se o numero vai ser inteiro utilizando o Try-Catch
        private int Ehinteiro(TextBox txt)
        {
            try
            {
                //pega o valor de todas as txt box para validar se é inteiro
                return Convert.ToInt32(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("O valor informado deve ser numérico");
            }
        }
        private void resetarBtn_Click(object sender, EventArgs e)
        {
            //Chama o metodo para Limpa todas as listbox pegando os comandos na classe "MetodosDeExtensao"
            this.LimparControles();

            //Chama o metodo para Limpar todas as txtbox, retornando elas ao seu valor inicial
            LimparTextBox();
        }

        private void LimparTextBox()
        {      
            nbr4txtBox.LimparTextboxNbr();
            nbr6txtBox.LimparTextboxNbr();
            nbr8txtBox.LimparTextboxNbr();
            nbr10txtBox.LimparTextboxNbr();
            nbr12txtBox.LimparTextboxNbr();
            nbr20txtBox.LimparTextboxNbr();
            nbr100txtBox.LimparTextboxNbr();

            mod4txtBox.LimparTextboxMod();
            mod6txtBox.LimparTextboxMod();
            mod8txtBox.LimparTextboxMod();
            mod10txtBox.LimparTextboxMod();
            mod12txtBox.LimparTextboxMod();
            mod20txtBox.LimparTextboxMod();
            mod100txtBox.LimparTextboxMod();
        }

        private void d4Btn_Click(object sender, EventArgs e)
        {
            RolarDados(5, nbr4txtBox, mod4txtBox, listBox1);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            RolarDados(7, nbr6txtBox, mod6txtBox, listBox3);

        }
        private void d6Btn_Click(object sender, EventArgs e)
        {
            RolarDados(9, nbr8txtBox, mod8txtBox, listBox4);              
        }
        private void button4_Click(object sender, EventArgs e)
        {
            RolarDados(11, nbr10txtBox, mod10txtBox, listBox5);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            RolarDados(13, nbr12txtBox, mod12txtBox, listBox6);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            RolarDados(21, nbr20txtBox, mod20txtBox, listBox7);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            RolarDados(101, nbr100txtBox, mod100txtBox, listBox8);
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            //fecha o formulario sobre rolar os dados
            this.Close();
        }

        public void RolarDados(int maiorNumRandom, TextBox nbr, TextBox mod, ListBox listBox)
        {
            try
            {
                /*converte o valor da txt box que pega a quantidade de vezes para lançar o dado e converte
                para inteiro*/
                int nbr1 = Ehinteiro(nbr);
                //declaro a variavel resultado, e converto o valor da txt box pegando o valor do modificador
                int resul, mod1 = Ehinteiro(mod);
                Random aleatorio = new Random();

                //só entra no loop se a quantidade de vezes para lançar o dado for maior ou igual a 1
                if (nbr1 >= 1)
                {
                    /*para cada vez que o dado for lançado, ele entrara neste ciclo e irá gerar um número aleatório*/
                    for (int i = 0; nbr1 > i; i++)
                    {
                        //gera um numero aleatorio e converte para inteiro
                        int rand = Convert.ToInt32(aleatorio.Next(1, maiorNumRandom));
                        resul = rand + mod1;
                        listBox.Items.Add(resul.ToString());
                        resultadolistBox.Items.Add(rand.ToString() + " + " + mod1.ToString() + " = " + resul.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
