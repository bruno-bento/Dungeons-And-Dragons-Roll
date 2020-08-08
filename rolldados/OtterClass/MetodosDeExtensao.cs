using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;


namespace rolldados.OtterClass
{
    static class MetodosDeExtensao
    {
        //busca em todo o formulario e limpa todas as listbox
        public static void LimparControles(this Form formulario)
        {
            foreach (Control ctl in formulario.Controls)
            {
                if (ctl is ListBox)
                {
                    (ctl as ListBox).Items.Clear();
                }
            }
        }
        public static string LimparTextboxNbr(this TextBox valorAntigo)
        {
            valorAntigo.ToString();
            return valorAntigo.Text = "1";
        }
        public static string LimparTextboxMod(this TextBox valorAntigo)
        {
            valorAntigo.ToString();
            return valorAntigo.Text = "0";
        }
    }
}
