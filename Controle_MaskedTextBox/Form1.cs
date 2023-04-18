using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /* 
             * Para números são usados os seguintes caracteres:
             * 0 -> Para números OBRIGATÓRIOS
             * # -> Para números OPCIONAIS
            */
            maskedTextBox1_Numeros.Mask = "0000"; // 4 números obrigatórios 
            // maskedTextBox1_Numeros.Mask = "####"; // 4 números opcionais
            // maskedTextBox1_Numeros.Mask = "0#"; // 1 obrigatório e 1 opcional


            /*
             * Para letras são usados os caracteres:
             * L -> Para letras OBRIGATÓRIAS
             * T -> Para letras OPCIONAIS
            */
            maskedTextBox2_Letras.Mask = "LLLLLL"; // 6 letras obrigatórias
                                                   // maskedTextBox2_Letras.Mask = "TTTTTT"; // 6 letras opcionais
                                                   // maskedTextBox2_Letras.Mask = "LLTT"; // 2 obrigatórias e 2 opcionais


            /*
             * Para datas:
            */
            maskedTextBox3_Datas.Mask = "00/00/0000";


            /*
             * Para placas veículares:
            */
            maskedTextBox4_PlacaDeCarro.Mask = "LLL - 0000";


            /*
             * Para horas: 
            */
            maskedTextBox5_Hora.Mask = "00:00:00";


            /*
             * Para decimais:
            */
            maskedTextBox6_Decimais.Mask = "00.0000"; // O marcador de decial é o "."


            /*
             * Para senhas:
            */
            maskedTextBox7_Senha.Mask = "0000";
            maskedTextBox7_Senha.PasswordChar = '*'; // Substitui os nºs por "*"


            /*
             * Para celular:
            */
            maskedTextBox8_Celular.Mask = "(00) \\90000-0000";
            // "(\\000) \\90000-0000" | obs.: "\\" força o caracter seguinte
        }

        private void button_Verificar_Click(object sender, EventArgs e)
        {
            bool todosPreenchidos = this.Controls.OfType<MaskedTextBox>().All(mtb => mtb.MaskCompleted);

            if (todosPreenchidos) MessageBox.Show("Formulário totalmente preenchido");
            else MessageBox.Show("Preencha " + this.Name +" corretamente.");
        }
    }
}
