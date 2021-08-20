using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        int bandera = 0;
        int ban = 0;
        int operacion;
        int banderaM2;


        public Calculadora()
        {
            InitializeComponent();
        }
        //Validacion de pantalla vacia
        private bool vacio()

        {
            if (lbl_pantalla.Text == "")
            {
                return (true);

            }
            return (false);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + "2";
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + "4";
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + "7";

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = lbl_pantalla.Text + ",";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Close();
        }

        //BORRAR PANTALLA
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            lbl_pantalla.Text = string.Empty;
        }

        //programacion del boton suma
        private void btn_suma_Click(object sender, EventArgs e)
        {
            operacion = 1;
            //suma
            //validacion de pantalla vacia
            if (vacio() == false)
            {
                if (bandera == 0)
                {
                    //ingreso de variables por primera vez
                    variables a = new variables();
                    a.Pnum1 = double.Parse(lbl_pantalla.Text);
                    bandera = 1;
                    lbl_resultado.Text = lbl_pantalla.Text;
                    a.Pnum2 = double.Parse(lbl_resultado.Text);
                    lbl_pantalla.Text = string.Empty;
                }
                else
                {
                    //validacion por si la pantalla queda vacia
                    if (lbl_pantalla.Text == "")
                    {
                        return;
                    }
                    else
                    {
                        //suma sucesiva
                        variables a = new variables();
                        a.Pnum1 = double.Parse(lbl_pantalla.Text);
                        a.Pnum2 = double.Parse(lbl_resultado.Text);
                        a.Pop = operacion;
                        a.Calcular();
                        lbl_resultado.Text = Convert.ToString(a.Presultado);
                        lbl_pantalla.Text = string.Empty;
                    }
                }
            }

        }
        //boton igual
        private void button11_Click(object sender, EventArgs e)
        {
            if (vacio() == false)
            {
                switch (operacion)
                {
                    case 1:
                        //suma
                        variables a = new variables();
                        a.Pnum1 = double.Parse(lbl_pantalla.Text);
                        a.Pnum2 = double.Parse(lbl_resultado.Text);
                        a.Pop = operacion;
                        a.Calcular();
                        lbl_resultado.Text = (a.Presultado).ToString();
                        lbl_pantalla.Text = string.Empty;
                        operacion = 0;
                        break;
                    case 2:
                        //Resta
                        variables b = new variables();
                        b.Pnum1 = double.Parse(lbl_resultado.Text);
                        b.Pnum2 = double.Parse(lbl_pantalla.Text);
                        b.Pop = operacion;
                        b.Calcular();
                        lbl_resultado.Text = (b.Presultado).ToString();
                        lbl_pantalla.Text = string.Empty;
                        operacion = 0;
                        break;
                    case 3:
                        //Divicion
                        variables d = new variables();
                        d.Pnum1 = double.Parse(lbl_resultado.Text);
                        d.Pnum2 = double.Parse(lbl_pantalla.Text);
                        d.Pop = operacion;
                        d.Calcular();
                        lbl_resultado.Text = (d.Presultado).ToString();
                        lbl_pantalla.Text = string.Empty;
                        operacion = 0;
                        break;
                    case 4:
                        //multiplicacion
                        variables m = new variables();
                        m.Pnum1 = double.Parse(lbl_resultado.Text);
                        m.Pnum2 = double.Parse(lbl_pantalla.Text);
                        m.Pop = operacion;
                        m.Calcular();
                        lbl_resultado.Text = (m.Presultado).ToString();
                        lbl_pantalla.Text = string.Empty;
                        operacion = 0;
                        break;
                    case 5:
                        //potencia
                        variables p = new variables();
                        p.Pnum1 = double.Parse(lbl_resultado.Text);
                        p.Pnum2 = double.Parse(lbl_pantalla.Text);
                        p.Pop = operacion;
                        p.Calcular();
                        lbl_resultado.Text = (p.Presultado).ToString();
                        lbl_pantalla.Text = string.Empty;
                        operacion = 0;
                        break;
                    default:
                        operacion = 0;
                        break;
                }

                if (lbl_resultado.Text == "")
                {
                    lbl_resultado.Text = lbl_pantalla.Text;
                    lbl_pantalla.Text = string.Empty;
                }
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacion = 2;
            //resta
            //validacion de pantalla vacia
            if (vacio() == false)
            {
                if (bandera == 0)
                {
                    //ingreso de variables por primera vez
                    variables r = new variables();
                    r.Pnum1 = double.Parse(lbl_pantalla.Text);
                    lbl_resultado.Text = lbl_pantalla.Text;
                    r.Pnum2 = double.Parse(lbl_resultado.Text);
                    lbl_pantalla.Text = string.Empty;
                    bandera = 1;
                }
                else
                {
                    //validacion por si la pantalla queda vacia
                    if (lbl_pantalla.Text == "")
                    {
                        return;
                    }
                    else
                    {
                        //resta sucesiva
                        variables r = new variables();
                        r.Pnum1 = double.Parse(lbl_resultado.Text);
                        r.Pnum2 = double.Parse(lbl_pantalla.Text);
                        r.Pop = operacion;
                        r.Calcular();
                        lbl_resultado.Text = Convert.ToString(r.Presultado);
                        lbl_pantalla.Text = string.Empty;
                    }
                }
            }


        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacion = 3;
            //divicion
            if (vacio() == false)
            {
                if (bandera == 0)
                {
                    //ingreso de variables por primera vez
                    variables d = new variables();
                    d.Pnum1 = double.Parse(lbl_pantalla.Text);
                    bandera = 1;
                    lbl_resultado.Text = lbl_pantalla.Text;
                    d.Pnum2 = double.Parse(lbl_resultado.Text);
                    lbl_pantalla.Text = string.Empty;
                }
                else
                {
                    //validacion por si la pantalla queda vacia
                    if (lbl_pantalla.Text == "")
                    {
                        return;
                    }
                    else
                    {
                        //Divicion sucesiva
                        variables d = new variables();
                        d.Pnum1 = double.Parse(lbl_resultado.Text);
                        d.Pnum2 = double.Parse(lbl_pantalla.Text);
                        d.Pop = operacion;
                        d.Calcular();
                        lbl_resultado.Text = Convert.ToString(d.Presultado);
                        lbl_pantalla.Text = string.Empty;
                    }
                }
            }
        }
        //Borrar totales
        private void btn_borratotal_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = string.Empty;
            lbl_M1.Text = string.Empty;
            lbl_M2.Text = string.Empty;
            lbl_pantalla.Text = string.Empty;
            bandera = 0;
            ban = 0;

        }


        //boton guardar resultados
        private void btn_m_Click(object sender, EventArgs e)
        {

            if (ban == 0)
            {
                //guardar resultado M1
                variables b = new variables();
                b.Pnum1 = Convert.ToDouble(lbl_resultado.Text);
                lbl_M1.Text = lbl_resultado.Text;
                ban = 1;
                return;
            }
            else
            {
                //guardar resultado 2
                variables b = new variables();
                b.Pnum2 = Convert.ToDouble(lbl_resultado.Text);
                lbl_M2.Text = lbl_resultado.Text;
            }


        }
        //borrar resultados guardados
        private void btn_BM_Click(object sender, EventArgs e)
        {
            if (banderaM2 == 0)
            {
                lbl_M2.Text = string.Empty;
                banderaM2 = 1;
            }
            else
            {
                lbl_M1.Text = String.Empty;
                banderaM2 = 0;

            }

        }

        private void btn_multiplica_Click(object sender, EventArgs e)
        {
            operacion = 4;
            //Multiplicacion
            //validacion de pantalla vacia
            if (vacio() == false)
            {
                if (bandera == 0)
                {
                    //ingreso de variables por primera vez
                    variables m = new variables();
                    m.Pnum1 = double.Parse(lbl_pantalla.Text);
                    bandera = 1;
                    lbl_resultado.Text = lbl_pantalla.Text;
                    m.Pnum2 = double.Parse(lbl_resultado.Text);
                    lbl_pantalla.Text = string.Empty;
                }
                else
                {
                    //validacion por si la pantalla queda vacia
                    if (lbl_pantalla.Text == "")
                    {
                        return;
                    }
                    else
                    {
                        //Multiplicacion sucesiva
                        variables m = new variables();
                        m.Pnum1 = double.Parse(lbl_pantalla.Text);
                        m.Pnum2 = double.Parse(lbl_resultado.Text);
                        m.Pop = operacion;
                        m.Calcular();
                        lbl_resultado.Text = (m.Presultado).ToString();
                        lbl_pantalla.Text = string.Empty;
                    }

                }
            }

        }

        private void btn_pot_Click(object sender, EventArgs e)
        {
            operacion = 5;
            //potencia
            if (vacio() == false)
            {
                if (bandera == 0)
                {
                    //ingreso de variables por primera vez
                    variables p = new variables();
                    p.Pnum1 = double.Parse(lbl_pantalla.Text);
                    lbl_resultado.Text = lbl_pantalla.Text;
                    p.Pnum2 = double.Parse(lbl_resultado.Text);
                    lbl_pantalla.Text = string.Empty;
                    bandera = 1;
                }
                else
                {
                    //validacion por si la pantalla queda vacia
                    if (lbl_pantalla.Text == "")
                    {
                        return;
                    }
                    else
                    {

                        variables p = new variables();
                        p.Pnum1 = double.Parse(lbl_resultado.Text);
                        p.Pnum2 = double.Parse(lbl_pantalla.Text);
                        p.Pop = operacion;
                        p.Calcular(); lbl_resultado.Text = (p.Presultado).ToString();
                        lbl_pantalla.Text = string.Empty;
                    }
                }
            }
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            operacion = 6;
            //Raiz
            variables r = new variables();
            r.Pnum1 = Convert.ToDouble(lbl_pantalla.Text);
            r.Pop = operacion;
            r.Calcular();
            lbl_resultado.Text = Convert.ToString(r.Presultado);
            lbl_pantalla.Text = string.Empty;
        }

        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                MessageBox.Show("Se presiono tecla 1");
            }
            if (e.KeyData == Keys.D2)
            {
                MessageBox.Show("Se presiono tecla 2");
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
