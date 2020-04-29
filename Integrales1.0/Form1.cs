using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.IO;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using Calculus;


namespace Integrales1._0
{
    public partial class FormPrincipal : Form
    {
        Calculo AF = new Calculo();
        int n;
        public FormPrincipal()
        {
            InitializeComponent();
            rdButtonSumas.Checked = true;
            if(txtIntegral.TextLength == 0)
            {
                button1.Enabled = false;   
            }
            
        }
        double Solvesimp(int ped, double a, double b)
        {
            if (a > b)
            {
                double ext = a;
                a = b;
                b = ext;
            }
            double del = (b - a) / ped;
            txtPedazo.Text = Convert.ToString(del);
            double s = 0, res;
            int i;
            //manda a llamar a estos arreglos
            double[] sumatoria = new double[n+1];
            //Creando tabla 
            DataSet datos = new DataSet("Sumas");
            DataTable tabla = new DataTable("Tabla_Sumas");
            tabla.Columns.Add(new DataColumn("Paso", Type.GetType("System.String")));
            tabla.Columns.Add(new DataColumn("Valor f(x)", Type.GetType("System.String")));
            tabla.Columns.Add(new DataColumn("Sumatoria", Type.GetType("System.String")));
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == ped)
                {
                    s += AF.EvaluaFx(a);
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        s += (2 * AF.EvaluaFx(a));
                    }
                    else
                    {
                        s += (4 * AF.EvaluaFx(a));
                    }
                }
                sumatoria[i] = s;
                a += del;
            }
            res = s * del / 3;
            for (int ii = 0; ii <= n; ii++)
            {
                if(ii==0 || ii==n-1)
                    tabla.Rows.Add('x' + ii.ToString(), "f(" + Convert.ToString(ii) + ")", sumatoria[ii].ToString());
                else if(ii%2==0)
                    tabla.Rows.Add('x' + ii.ToString(), "2*f(" + Convert.ToString(ii) + ")", sumatoria[ii].ToString());
                else
                    tabla.Rows.Add('x' + ii.ToString(), "4*f(" + Convert.ToString(ii) + ")", sumatoria[ii].ToString());
            }


            datos.Tables.Add(tabla);
            TablaDeDatos.DataSource = tabla;
            return res;
        }
        double simpson(int ped,double a, double b)
        {
            if (a > b)
            {
                double ext = a;
                a = b;
                b = ext;
            }
            double del = (b - a) / ped;
            double s=0,res;
            int i;
            for( i = 0; i <= ped; i++)
            {
                if (i == 0 || i==ped)
                {
                    s += AF.EvaluaFx(a);
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        s += (2 * AF.EvaluaFx(a));
                    }
                    else
                    {
                        s += (4 * AF.EvaluaFx(a));
                    }
                }
                a += del;
            }
            res = s * del / 3;            
            return res;
        }
        double abs(double a)
        {
            if (a < 0)
            {
                return -1 * a;
            }
            return a;
        }
        double solvetrap(int ped, double a, double b){
            if (a > b) {
                double ext = a;
                a = b;
                b = ext;
            }
            double del = (b - a) / ped, s = 0;
            double j;
            
            //manda a llamar a estos arreglos
            double[] valorf = new double[n];
            double[] sumatoria = new double[n];
            
            txtPedazo.Text = del.ToString();
            //Creando tabla 
            DataSet datos = new DataSet("Sumas");
            DataTable tabla = new DataTable("Tabla_Sumas");
            tabla.Columns.Add(new DataColumn("Paso", Type.GetType("System.String")));
            tabla.Columns.Add(new DataColumn("Valor f(x)", Type.GetType("System.String")));
            tabla.Columns.Add(new DataColumn("Sumatoria", Type.GetType("System.String")));
            //CREA LOS ARREGLOS SIGUIENTES 
            for (int i = 0; i < n; i++)
            {
                double prom = (AF.EvaluaFx(a+del)+AF.EvaluaFx(a)) / 2;
                j = prom * del;
                valorf[i] = j;
                s += prom * del;
                sumatoria[i] = s; 
                //tabla.Rows.Add();
                a += del;
            }
            for(int i =0; i<n; i++)
            {
                tabla.Rows.Add('x' + i.ToString(), valorf[i].ToString(), sumatoria[i].ToString());
            }
            

            datos.Tables.Add(tabla);
            TablaDeDatos.DataSource = tabla;
            /*

            for (int i = 0; i < ped; i++)
            {
                double pro = (AF.EvaluaFx(a+del) + AF.EvaluaFx(a)) / 2;
                //tabular
                //cout << " x" << i << "           " << pro * del << "         " << s << endl;
                s += pro * del;
                a += del;
            }*/
            return s;
        }
        double solveRfor(int ped, double a, double b, char l)
        {
            if (a > b)
            {
                double ext = a;
                a = b;
                b = ext;
            }
            double del = (b - a) / ped, s = 0;
            txtPedazo.Text = Convert.ToString(del);
            //manda a llamar a estos arreglos
            double[] valorf = new double[n];
            double[] sumatoria = new double[n];
            //Creando tabla 
            DataSet datos = new DataSet("Sumas");
            DataTable tabla = new DataTable("Tabla_Sumas");
            tabla.Columns.Add(new DataColumn("Paso", Type.GetType("System.String")));
            tabla.Columns.Add(new DataColumn("Valor f(x)", Type.GetType("System.String")));
            tabla.Columns.Add(new DataColumn("Sumatoria", Type.GetType("System.String")));
            //cout << "paso :\tval en f(x):\tsumatoria:" << endl;
            if (l == 'd')
            {
                a += del;
                b += del;
            }
            for (int i = 0; i < ped; i++)
            {
                //cout << " x" << i << "           " << f(a) << "         " << s << endl;
                
                s += AF.EvaluaFx(a) * del;
                valorf[i] = AF.EvaluaFx(a);
                sumatoria[i] = s;
                a += del;
            }
            for (int i = 0; i < n; i++)
            {
                tabla.Rows.Add('x' + i.ToString(), valorf[i].ToString(), sumatoria[i].ToString());
            }
            datos.Tables.Add(tabla);
            TablaDeDatos.DataSource = tabla;
            return s;
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double a, b,area=0,f;
            string funcion;
            funcion = txtIntegral.Text;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            n = Convert.ToInt32(txtN.Text);            
            if (AF.Sintaxis(funcion, 'x'))
            {
                if (rdButtonSumas.Checked == true)
                {
                    if (rdButonIzquierda.Checked == true)
                        area=solveRfor(n, a, b, 'i');
                    else if (rdButtonDerecha.Checked == true)
                        area=solveRfor(n, a, b, 'd');
                }
                else if (rdButtonTrapecios.Checked == true)
                {
                    area=solvetrap(n, a, b);
                }
                else if (rdButtonSimpson.Checked == true)
                {
                    area = Solvesimp(n, a, b);
                }
            }
            else
            {
                MessageBox.Show("Error de sintaxis, verificala");
            }
            int g = Convert.ToInt32((b - a) / 2);
            f = simpson(g, a, b);
            //double perfecto = simpson();
            txtArea.Text = Convert.ToString(area);
            //txterror.Text = Convert.ToString(sol(simpson(1000, a, b),area));
            txterror.Text = Convert.ToString(abs(f-area));
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quieres cerrar la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtIntegral_TextChanged(object sender, EventArgs e)
         {

         }
        //PARTE DE LOS BOTONES DE LA CALCULADORA
        private void Button1_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "x";
            button1.Enabled = true;
        }

        private void BtnSeno_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "sin(";
            button1.Enabled = true;
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "cos(";
            button1.Enabled = true;
        }

        private void BtnTangente_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "tan(";
            button1.Enabled = true;
        }

        private void BtnCot_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "asn(";
            button1.Enabled = true;
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "acs(";
            button1.Enabled = true;
        }

        private void BtnCsc_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "atn(";
            button1.Enabled = true;
        }

        private void BtnLn_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "Ln(";
            button1.Enabled = true;
        }

        private void BtnlLog_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "sqr(";
            button1.Enabled = true;
        }

        private void BtnParentesisDerecho_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + ")";
            button1.Enabled = true;
        }

        private void BtnParentesisIzquierdo_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "(";
            button1.Enabled = true;
        }

        private void RdButtonSumas_CheckedChanged(object sender, EventArgs e)
        {
            lblCalculo.Text = "Calculo de integral por Sumas de Reiman";
            rdButonIzquierda.Visible = true;
            rdButtonDerecha.Visible = true;
        }

        private void RdButtonTrapecios_CheckedChanged(object sender, EventArgs e)
        {
            lblCalculo.Text = "Calculo de integral por Trapecios";
            rdButonIzquierda.Visible = false;
            rdButtonDerecha.Visible = false;
        }

        private void RdButtonSimpson_CheckedChanged(object sender, EventArgs e)
        {
            lblCalculo.Text = "Calculo de integral por Ley de Simpson";
            rdButonIzquierda.Visible = false;
            rdButtonDerecha.Visible = false;
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "-";
            button1.Enabled = true;
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "+";
            button1.Enabled = true;
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            txtIntegral.Text = txtIntegral.Text + "/";
            button1.Enabled = true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (txtIntegral.Text.Length == 1)
                txtIntegral.Text = "";
            if(txtIntegral.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
                txtIntegral.Text = txtIntegral.Text.Substring(0, txtIntegral.Text.Length - 1);
        }

        private void rdButtonDerecha_CheckedChanged(object sender, EventArgs e)
        {
            rdButtonSumas.Checked = true;
        }

        private void rdButonIzquierda_CheckedChanged(object sender, EventArgs e)
        {
            rdButtonSumas.Checked = true;
        }

        private void rdButonIzquierda_CheckedChanged_1(object sender, EventArgs e)
        {
            rdButtonDerecha.Checked = false;
        }

        private void rdButtonDerecha_CheckedChanged_1(object sender, EventArgs e)
        {
            rdButonIzquierda.Checked = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIntegral.Text += "exp(";
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtIntegral.Text += "abs(";
            button1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtIntegral.Text += "*";
            button1.Enabled = true;
        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creadores:");
            MessageBox.Show("Carlos Morales y Suárez Elizalde");
            MessageBox.Show("Co-creadores:");
            MessageBox.Show("Cano Jimenez");
            MessageBox.Show("Acosta Flores");
            MessageBox.Show("Serrano Carreño");
            MessageBox.Show("Roldan Gomez");
        }
    }
}
