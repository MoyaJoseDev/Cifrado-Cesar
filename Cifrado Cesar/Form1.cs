using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cifrado_Cesar
{
    public partial class Form1 : Form
    {
        string texto = "";
        string resultado = "";
        
        public string cifrarTexto(string texto)
        {
            for (int i = 0;i < texto.Length; i++)
            {
                switch (texto.Substring(i, 1))
                {
                    case "A": resultado += "D";
                        break;
                    case "B": resultado += "E";
                        break;
                    case "C":
                        resultado += "F";
                        break;
                    case "D":
                        resultado += "G";
                        break;
                    case "E":
                        resultado += "H";
                        break;
                    case "F":
                        resultado += "I";
                        break;
                    case "G":
                        resultado += "J";
                        break;
                    case "H":
                        resultado += "K";
                        break;
                    case "I":
                        resultado += "L";
                        break;
                    case "J":
                        resultado += "M";
                        break;
                    case "K":
                        resultado += "N";
                        break;
                    case "L":
                        resultado += "Ñ";
                        break;
                    case "M":
                        resultado += "O";
                        break;
                    case "N":
                        resultado += "P";
                        break;
                    case "Ñ":
                        resultado += "Q";
                        break;
                    case "O":
                        resultado += "R";
                        break;
                    case "P":
                        resultado += "S";
                        break;
                    case "Q":
                        resultado += "T";
                        break;
                    case "R":
                        resultado += "U";
                        break;
                    case "S":
                        resultado += "V";
                        break;
                    case "T":
                        resultado += "W";
                        break;
                    case "U":
                        resultado += "X";
                        break;
                    case "V":
                        resultado += "Y";
                        break;
                    case "W":
                        resultado += "Z";
                        break;
                    case "X":
                        resultado += "A";
                        break;
                    case "Y":
                        resultado += "B";
                        break;
                    case "Z":
                        resultado += "C";
                        break;
                    case " ":
                        resultado += " ";
                        break;

                }
            }
            return resultado;
        }

        public string traducirTexto(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                switch (texto.Substring(i, 1))
                {
                    case "A":
                        resultado += "X";
                        break;
                    case "B":
                        resultado += "Y";
                        break;
                    case "C":
                        resultado += "Z";
                        break;
                    case "D":
                        resultado += "A";
                        break;
                    case "E":
                        resultado += "B";
                        break;
                    case "F":
                        resultado += "C";
                        break;
                    case "G":
                        resultado += "D";
                        break;
                    case "H":
                        resultado += "E";
                        break;
                    case "I":
                        resultado += "F";
                        break;
                    case "J":
                        resultado += "G";
                        break;
                    case "K":
                        resultado += "H";
                        break;
                    case "L":
                        resultado += "I";
                        break;
                    case "M":
                        resultado += "J";
                        break;
                    case "N":
                        resultado += "K";
                        break;
                    case "Ñ":
                        resultado += "L";
                        break;
                    case "O":
                        resultado += "M";
                        break;
                    case "P":
                        resultado += "N";
                        break;
                    case "Q":
                        resultado += "Ñ";
                        break;
                    case "R":
                        resultado += "O";
                        break;
                    case "S":
                        resultado += "P";
                        break;
                    case "T":
                        resultado += "Q";
                        break;
                    case "U":
                        resultado += "R";
                        break;
                    case "V":
                        resultado += "S";
                        break;
                    case "W":
                        resultado += "T";
                        break;
                    case "X":
                        resultado += "U";
                        break;
                    case "Y":
                        resultado += "V";
                        break;
                    case "Z":
                        resultado += "W";
                        break;
                    case " ":
                        resultado += " ";
                        break;

                }
            }
            return resultado;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cuadroTexto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cuadroResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonCifrar_Click(object sender, EventArgs e)
        {
            cuadroResultado.Clear();
            texto = cuadroTexto.Text;
            cuadroResultado.Text = cifrarTexto(texto.ToUpper());
            resultado = "";
        }

        private void botonTraducir_Click(object sender, EventArgs e)
        {
            cuadroResultado.Clear();
            texto = cuadroTexto.Text;
            cuadroResultado.Text = traducirTexto(texto.ToUpper());
            resultado = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/MoyaJoseDev");
        }
    }
}
