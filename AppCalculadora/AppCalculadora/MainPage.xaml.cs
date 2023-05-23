using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora
{
    public partial class MainPage : ContentPage
    {

        bool point = false;
        bool D1 = false;
        bool D2 = false;
        int operador = 4;
        public double N1 = 0;
        public double N2 = 0;
        public double Result;
        public MainPage()
        {
            InitializeComponent();
        }
        private void equalize_Val(String operando, int valor)
        {

            bool val_lbl = Numlbl.Text.GetType() != operador.GetType();
            bool val_Span = primerSpan.Text.GetType() != operador.GetType();
            if (Result != 0 || ((val_lbl || val_Span) || (val_lbl && val_Span))) D1 = true;
            if (D1)
                N1 = double.Parse(Numlbl.Text);
            else

                N1 = int.Parse(Numlbl.Text);
            primerSpan.Text = N1 + " ";
            Numlbl.Text = "";
            segundoSpan.Text = operando;
            operador = valor;
            point = false;

        }
        private bool space_full()
        {
            bool estaLleno = false;
            if (primerSpan.Text == "" && segundoSpan.Text == "")
                estaLleno = true;
            return estaLleno;
        }
        private void N_Insert(String numero)
        {
            if (Numlbl.Text == "" && numero != ".")
                Numlbl.Text = numero;
            else
                Numlbl.Text += numero;

        }
        private void Btn_AClearALll(object sender, EventArgs e)
        {
            N1 = 0; N2 = 0; Result = 0; point=false;
            primerSpan.Text = ""; segundoSpan.Text = ""; tercerSpan.Text = ""; Numlbl.Text = "";
        }

        private void Btn_Sum(object sender, EventArgs e)
        {
            equalize_Val("+", 0);
            if (!space_full())
                tercerSpan.Text = "";
        }
       
            private void Btn_Rest(object sender, EventArgs e)
        {
            equalize_Val("-", 1);
            if (!space_full())
                tercerSpan.Text = "";
        }
        private void Btn_X(object sender, EventArgs e)
        {
            equalize_Val("*", 2);
            if (!space_full())
                tercerSpan.Text = "";
        }
        private void Btn_div(object sender, EventArgs e)
        {
            equalize_Val("/", 3);
            if (!space_full())
                tercerSpan.Text = "";
        }
       
        private void Click_puntoDecimal(object sender, EventArgs e)
        {
            if (!point)//
            {
                N_Insert(".");
                point = true;
            }
            if (operador == 4)
                D1 = true;
            else
                D2 = false;
        }
        private void Btn_igual(object sender, EventArgs e)
        {

            if (primerSpan.Text != "" && segundoSpan.Text != "")
            {

                tercerSpan.Text = " " + Numlbl.Text;

                if (D2)

                    N2 = double.Parse(tercerSpan.Text);
                else
                    N2 = int.Parse(tercerSpan.Text);

                if (operador == 0)

                {
                    Result = N1 + N2;
                    Numlbl.Text = Result + "";

                }

                else if (operador == 1)

                {

                    Result = N1 - N2;
                    Numlbl.Text = Result + "";
                }

                else if (operador == 2)

                {

                    Result = N1 * N2;
                    Numlbl.Text = Result + "";

                }
                else

                {

                    if (N2 == 0) { N2 = 1; }
                    Result = N1 / N2;
                    Numlbl.Text = Result + "";
                }
                N1 = 0; N2 = 0; Result = 0;

                operador = 4; D1 = false; D2 = false;
            }
        }
        private void Click_Cero(object sender, EventArgs e)
        {
            N_Insert("0");
        }
        private void Click_1(object sender, EventArgs e)
        {
            N_Insert("1");
        }
        private void Click_2(object sender, EventArgs e)
        {
            N_Insert("2");
        }
        private void Click_3(object sender, EventArgs e)
        {
            N_Insert("3");
        }
        private void Click_4(object sender, EventArgs e)
        {
            N_Insert("4");
        }
        private void Click_5(object sender, EventArgs e)
        {
            N_Insert("5");
        }
        private void Click_6(object sender, EventArgs e)
        {
            N_Insert("6");
        }
        private void Click_7(object sender, EventArgs e)
        {
            N_Insert("7");
        }
        private void Click_8(object sender, EventArgs e)
        {
            N_Insert("8");
        }
        private void Click_9(object sender, EventArgs e)
        {
            N_Insert("9");
        }

    }
}
