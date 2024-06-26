﻿using System;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        double primerNumero = 0;
        double segundoNumero = 0;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;

        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;

        }
        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;

        }
        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;

        }
        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;

        }
        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;

        }



        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            // Verificar si el TextBox no está vacío
            if (!string.IsNullOrWhiteSpace(txtPantalla.Text))
            {
                // Si hay un valor válido en el TextBox, realizar la operación de resta
                operacion = "*";
                primerNumero = double.Parse(txtPantalla.Text);
                txtPantalla.Text = "";
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada si el TextBox está vacío
                MessageBox.Show("No hay ningún número para multiplicar");
            }

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            // Verificar si el TextBox no está vacío
            if (!string.IsNullOrWhiteSpace(txtPantalla.Text))
            {
                // Si hay un valor válido en el TextBox, realizar la operación de resta
                operacion = "/";
                primerNumero = double.Parse(txtPantalla.Text);
                txtPantalla.Text = "";
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada si el TextBox está vacío
                MessageBox.Show("No hay ningún número para dividir");
            }

        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Verificar si el TextBox no está vacío
            if (!string.IsNullOrWhiteSpace(txtPantalla.Text))
            {
                // Si hay un valor válido en el TextBox, realizar la operación de resta
                operacion = "+";
                primerNumero = double.Parse(txtPantalla.Text);
                txtPantalla.Text = "";
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada si el TextBox está vacío
                MessageBox.Show("No hay ningún número para sumar");
            }

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // Verificar si el TextBox no está vacío
            if (!string.IsNullOrWhiteSpace(txtPantalla.Text))
            {
                // Si hay un valor válido en el TextBox, realizar la operación de resta
                operacion = "-";
                primerNumero = double.Parse(txtPantalla.Text);
                txtPantalla.Text = "";
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada si el TextBox está vacío
                MessageBox.Show("No hay ningún número para restar");
            }

        }


        private void btnIgual_Click(object sender, EventArgs e)
        {

            // Verificar si el TextBox no está vacío
            if (!string.IsNullOrWhiteSpace(txtPantalla.Text))
            {
                segundoNumero = double.Parse(txtPantalla.Text);
                double resultado = RealizarCalculo(primerNumero, segundoNumero, operacion);
                txtPantalla.Text = resultado.ToString();
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada si el TextBox está vacío
                MessageBox.Show("Cargue una operacion");
            }

                 

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
            primerNumero = 0;
            segundoNumero = 0;
            operacion = "";
        }


        private double RealizarCalculo(double primerNumero, double segundoNumero, string operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    if (segundoNumero != 0)
                        resultado = primerNumero / segundoNumero;
                    else
                        MessageBox.Show("No se puede dividir por cero");
                    break;
            }
            return resultado;
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

            // Alinear el texto a la derecha
            txtPantalla.TextAlign = HorizontalAlignment.Right;

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            txtPantalla.Text += btn.Text;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Establecer el valor inicial del cuadro de texto a "0"
            txtPantalla.Text = "0";


        }



    }
}
