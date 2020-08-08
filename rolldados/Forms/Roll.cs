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
            try
            {
                /*converte o valor da txt box que pega a quantidade de vezes para lançar o dado e converte
                para inteiro*/
                int nbr1 = Ehinteiro(nbr4txtBox);

                //declaro a variavel resultado, e converto o valor da txt box pegando o valor do modificador
                int resul, mod1 = Ehinteiro(mod4txtBox);
                Random aleatorio = new Random();//crio a variavel aleatorio

                //só entra no loop se a quantidade de vezes para lançar o dado for maior ou igual a 1
                if (nbr1 >= 1)
                {
                    /*para cada vez que o dado for lançado, ele entrara neste ciclo e irá gerar um número aleatório*/
                    for (int i = 0; nbr1 > i; i++)  
                    {
                        //gera um numero aleatorio entre 1 e 4 e converte para inteiro
                        int rand = Convert.ToInt32(aleatorio.Next(1, 5));
                        //soma o numero aleatorio + o modificador
                        resul = rand + mod1;
                        //adiciona o resultado na listbox ao lado do botão
                        listBox1.Items.Add(resul.ToString());
                        //adiciona no histórico, mostrando o calculo 
                        resultadolistBox.Items.Add(rand.ToString() + " + " + mod1.ToString() + " = " + resul.ToString());
                    }
                }
            }
            //"Pega" a exceção do TryCatch para verificar se é inteiro e aplica a mensagem
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int i, nbr1 = Ehinteiro(nbr6txtBox);
                int resul, mod1 = Ehinteiro(mod6txtBox);
                Random aleatorio = new Random();
                if (nbr1 >= 1)
                {
                    for (i = 0; nbr1 > i; i++)
                    {
                        int rand = Convert.ToInt32(aleatorio.Next(1, 7));
                        resul = rand + mod1;
                        listBox3.Items.Add(resul.ToString());
                        resultadolistBox.Items.Add(rand.ToString() + " + " + mod1.ToString() + " = " + resul.ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void d6Btn_Click(object sender, EventArgs e)
        {
            try
            {
                int i, nbr1 = Convert.ToInt32(nbr8txtBox.Text);
                int resul, mod1 = Convert.ToInt32(mod8txtBox.Text);
                Random aleatorio = new Random();
                if (nbr1 >= 1)
                {
                    for (i = 0; nbr1 > i; i++)
                    {
                        int rand = Convert.ToInt32(aleatorio.Next(1, 9));
                        resul = rand + mod1;
                        listBox4.Items.Add(resul.ToString());
                        resultadolistBox.Items.Add(rand.ToString() + " + " + mod1.ToString() + " = " + resul.ToString());
                    }
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int i, nbr1 = Convert.ToInt32(nbr10txtBox.Text);
                int resul, mod1 = Convert.ToInt32(mod10txtBox.Text);
                Random aleatorio = new Random();
                if (nbr1 >= 1)
                {
                    for (i = 0; nbr1 > i; i++)
                    {
                        int rand = Convert.ToInt32(aleatorio.Next(1, 11));
                        resul = rand + mod1;
                        listBox5.Items.Add(resul.ToString());
                        resultadolistBox.Items.Add(rand.ToString() + " + " + mod1.ToString() + " = " + resul.ToString());
                    }
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int i, nbr1 = Ehinteiro(nbr12txtBox);
                int resul, mod1 = Ehinteiro(mod12txtBox);
                Random aleatorio = new Random();
                if (nbr1 >= 1)
                {
                    for (i = 0; nbr1 > i; i++)
                    {
                        int rand = Convert.ToInt32(aleatorio.Next(1, 13));
                        resul = rand + mod1;
                        listBox6.Items.Add(resul.ToString());
                        resultadolistBox.Items.Add(rand.ToString() + " + " + mod1.ToString() + " = " + resul.ToString());
                    }
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int i, nbr1 = Ehinteiro(nbr20txtBox);
                int resul, mod1 = Ehinteiro(mod20txtBox);
                Random aleatorio = new Random();
                if (nbr1 >= 1)
                {
                    for (i = 0; nbr1 > i; i++)
                    {
                        int rand = Convert.ToInt32(aleatorio.Next(1, 21));
                        resul = rand + mod1;
                        listBox7.Items.Add(resul.ToString());
                        resultadolistBox.Items.Add(rand.ToString() + " + " + mod1.ToString() + " = " + resul.ToString());
                    }
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int i, nbr1 = Ehinteiro(nbr100txtBox);
                int resul, mod1 = Ehinteiro(mod100txtBox);
                Random aleatorio = new Random();
                if (nbr1 >= 1)
                {
                    for (i = 0; nbr1 > i; i++)
                    {
                        int rand = Convert.ToInt32(aleatorio.Next(1, 101));
                        resul = rand + mod1;
                        listBox8.Items.Add(resul.ToString());
                        resultadolistBox.Items.Add(rand.ToString() + " + " + mod1.ToString() + " = " + resul.ToString());
                    }
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            //fecha o formulario sobre rolar os dados
            this.Close();
        }
    }
}
