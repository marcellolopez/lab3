using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio_n3
{
   
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            /**
             *Habilita el modo testing, el cual ingresa valores en los campos
             *cambiar true por false para que no realice el proceso
             *cuando realicen la entrega
             */
            testing(true);
        }

        /**
         * btn_calcular()
         * Realiza los calculos correspondientes
         * y los muestra en los TextBox de resultados 
         */
        private void btn_calcular(object sender, EventArgs e)
        {
            //Declaración de variables
            Double Vg               = Convert.ToDouble(txt_pt_tensionRms.Text);
            Double f                = Convert.ToDouble(txt_pt_frecuencia.Text);
            Double angulo           = Convert.ToDouble(txt_pt_angulo.Text);
            Double R                = Convert.ToDouble(txt_pc_r.Text);
            Double L                = Convert.ToDouble(txt_pc_l.Text);
            Double C                = Convert.ToDouble(txt_pc_c.Text);
            Double XL;
            Double XC;
            Double Z;
            Double i;
            Double P;
            Double ZP;
            Double Q;
            Double S;

            /**
             * Math.Pi obtiene el valor de PI desde la librería Math, utilizada para operaciones matemáticas comúnes
             */
            Double M_PI = Math.PI;


            // Validación de parámetros
            if (R < 0 || L < 0 || C < 0 || f <= 0 || angulo < -90 || angulo > 90)
            {
                // Mostrar una alerta con el MessageBox
                MessageBox.Show("Error", "Parámetros no válidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cálculo de reactancias
            XL = 2 * M_PI * f * L / 1000;
            XC = 1 / (2 * M_PI * f * C * 0.000001);

            // Cálculo de impedancia y corriente
            Z = calcularImpedanciaRectangular(R, XL, XC);
            i = calcularCorriente(Vg, Z);

            // Cálculo de potencia activa
            P = calcularPotencia(Vg, i, angulo, M_PI);

            // Cálculo de impedancia polar
            ZP = calcularImpedanciaPolar(R, XL, XC, M_PI);

            // Cálculo de potencia reactiva
            Q = calcularPotenciaReactiva(Vg, i, angulo);

            // Cálculo de potencia aparente
            S = calcularPotenciaAparente(i, Vg);

            // Mostrar resultados
            /**
             * Envía los resultados a los TextBox correspondientes
             * debemos convertir de número a string para setearlos en los resultados
             * por eso se usa Convert.ToString()
             */
            txt_r_zRectangular.Text = Convert.ToString(Z);
            txt_r_zPolar.Text       = Convert.ToString(ZP);
            txt_r_i.Text            = Convert.ToString(i);
            txt_r_p.Text            = Convert.ToString(P);
            txt_r_q.Text            = Convert.ToString(Q);
            txt_r_s.Text            = Convert.ToString(S);
        }

        /**
         * testing(test)
         * el valor test puede ser true o false
         * inicia los campos para realizar los cálculos
         */
        private void testing(bool test)
        {
            //Si el valor es true, inicia los TextBox con valores
            if (test)
            {
                txt_pt_tensionRms.Text      = Convert.ToString(110);
                txt_pt_frecuencia.Text      = Convert.ToString(60);
                txt_pt_angulo.Text          = Convert.ToString(90);
                txt_pc_r.Text               = Convert.ToString(10);
                txt_pc_l.Text               = Convert.ToString(40);
                txt_pc_c.Text               = Convert.ToString(265);
            }
        }

        /**
         * Funciones que realizan los cálculos
         */

        Double calcularImpedanciaRectangular(Double R, Double XL, Double XC)
        {
            return R + (XL - XC);
        }

        Double calcularImpedanciaPolar(Double R, Double XL, Double XC, Double M_PI)
        {
            Double modulo = Math.Sqrt(Math.Pow(R, 2) + Math.Pow(XL - XC, 2));
            Double angulo = Math.Atan2(XL - XC, R) * 180 / M_PI;
            return modulo * Math.Exp(angulo * M_PI / 180);
        }

        Double calcularCorriente(Double Vg, Double Z)
        {
            return Vg / Z;
        }

        Double calcularPotencia(Double Vg, Double i, Double angulo, Double M_PI)
        {
            return Vg * i * Math.Cos(angulo * M_PI / 180);
        }

        Double calcularPotenciaReactiva(Double Vg, Double i, Double angulo)
        {
            return Vg * i * Math.Sin(angulo);
        }

        Double calcularPotenciaAparente(Double i, Double Vg)
        {
            return (i * Vg);
        }

        /**
         * cb_circuito_SelectedIndexChanged
         * Maneja la selección de circuito, según selección muestra la imagen correspondiente
         */
        private void cb_circuito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_circuito.Text == "LCR")
            {
                img_LCR.Visible = true;
                img_CRL.Visible = false;
            }
            else
            {
                img_LCR.Visible = false;
                img_CRL.Visible = true;
            }
        }

        /**
         * btn_limpiar
         * Limpia los primeros 6 campos
         * las comillas ("") es porqué le envío un texto vacío para mostrar
         */
        private void btn_limpiar(object sender, EventArgs e)
        {
            txt_pt_tensionRms.Text      = "";
            txt_pt_frecuencia.Text      = "";
            txt_pt_angulo.Text          = "";
            txt_pc_c.Text               = "";
            txt_pc_r.Text               = "";
            txt_pc_l.Text               = "";
        }
    }

}
