namespace Integrales1._0
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.rdButtonSumas = new System.Windows.Forms.RadioButton();
            this.rdButtonTrapecios = new System.Windows.Forms.RadioButton();
            this.rdButtonSimpson = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPedazo = new System.Windows.Forms.TextBox();
            this.TablaDeDatos = new System.Windows.Forms.DataGridView();
            this.btnX = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.BtnlLog = new System.Windows.Forms.Button();
            this.btnCot = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnCsc = new System.Windows.Forms.Button();
            this.txtIntegral = new System.Windows.Forms.TextBox();
            this.btnParentesisDerecho = new System.Windows.Forms.Button();
            this.btnParentesisIzquierdo = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdButtonDerecha = new System.Windows.Forms.CheckBox();
            this.rdButonIzquierda = new System.Windows.Forms.CheckBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.txterror = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Tag = "lblIntegral";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnCalcular
            // 
            resources.ApplyResources(this.btnCalcular, "btnCalcular");
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnMinimizar
            // 
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblCalculo
            // 
            resources.ApplyResources(this.lblCalculo, "lblCalculo");
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Tag = "lblIntegral";
            this.lblCalculo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Integrales1._0.Properties.Resources.Integral;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtA, "txtA");
            this.txtA.Name = "txtA";
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtB, "txtB");
            this.txtB.Name = "txtB";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // rdButtonSumas
            // 
            resources.ApplyResources(this.rdButtonSumas, "rdButtonSumas");
            this.rdButtonSumas.Name = "rdButtonSumas";
            this.rdButtonSumas.TabStop = true;
            this.rdButtonSumas.UseVisualStyleBackColor = true;
            this.rdButtonSumas.CheckedChanged += new System.EventHandler(this.RdButtonSumas_CheckedChanged);
            // 
            // rdButtonTrapecios
            // 
            resources.ApplyResources(this.rdButtonTrapecios, "rdButtonTrapecios");
            this.rdButtonTrapecios.Name = "rdButtonTrapecios";
            this.rdButtonTrapecios.TabStop = true;
            this.rdButtonTrapecios.UseVisualStyleBackColor = true;
            this.rdButtonTrapecios.CheckedChanged += new System.EventHandler(this.RdButtonTrapecios_CheckedChanged);
            // 
            // rdButtonSimpson
            // 
            resources.ApplyResources(this.rdButtonSimpson, "rdButtonSimpson");
            this.rdButtonSimpson.Name = "rdButtonSimpson";
            this.rdButtonSimpson.TabStop = true;
            this.rdButtonSimpson.UseVisualStyleBackColor = true;
            this.rdButtonSimpson.CheckedChanged += new System.EventHandler(this.RdButtonSimpson_CheckedChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtN, "txtN");
            this.txtN.Name = "txtN";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Tag = "lblIntegral";
            this.label4.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtArea, "txtArea");
            this.txtArea.Name = "txtArea";
            // 
            // txtPedazo
            // 
            this.txtPedazo.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtPedazo, "txtPedazo");
            this.txtPedazo.Name = "txtPedazo";
            // 
            // TablaDeDatos
            // 
            this.TablaDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.TablaDeDatos, "TablaDeDatos");
            this.TablaDeDatos.Name = "TablaDeDatos";
            // 
            // btnX
            // 
            resources.ApplyResources(this.btnX, "btnX");
            this.btnX.Name = "btnX";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSeno
            // 
            resources.ApplyResources(this.btnSeno, "btnSeno");
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.BtnSeno_Click);
            // 
            // btnCos
            // 
            resources.ApplyResources(this.btnCos, "btnCos");
            this.btnCos.Name = "btnCos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // btnTangente
            // 
            resources.ApplyResources(this.btnTangente, "btnTangente");
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.UseVisualStyleBackColor = true;
            this.btnTangente.Click += new System.EventHandler(this.BtnTangente_Click);
            // 
            // btnLn
            // 
            resources.ApplyResources(this.btnLn, "btnLn");
            this.btnLn.Name = "btnLn";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.BtnLn_Click);
            // 
            // BtnlLog
            // 
            resources.ApplyResources(this.BtnlLog, "BtnlLog");
            this.BtnlLog.Name = "BtnlLog";
            this.BtnlLog.UseVisualStyleBackColor = true;
            this.BtnlLog.Click += new System.EventHandler(this.BtnlLog_Click);
            // 
            // btnCot
            // 
            resources.ApplyResources(this.btnCot, "btnCot");
            this.btnCot.Name = "btnCot";
            this.btnCot.UseVisualStyleBackColor = true;
            this.btnCot.Click += new System.EventHandler(this.BtnCot_Click);
            // 
            // btnSec
            // 
            resources.ApplyResources(this.btnSec, "btnSec");
            this.btnSec.Name = "btnSec";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.BtnSec_Click);
            // 
            // btnCsc
            // 
            resources.ApplyResources(this.btnCsc, "btnCsc");
            this.btnCsc.Name = "btnCsc";
            this.btnCsc.UseVisualStyleBackColor = true;
            this.btnCsc.Click += new System.EventHandler(this.BtnCsc_Click);
            // 
            // txtIntegral
            // 
            this.txtIntegral.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtIntegral, "txtIntegral");
            this.txtIntegral.Name = "txtIntegral";
            // 
            // btnParentesisDerecho
            // 
            resources.ApplyResources(this.btnParentesisDerecho, "btnParentesisDerecho");
            this.btnParentesisDerecho.Name = "btnParentesisDerecho";
            this.btnParentesisDerecho.UseVisualStyleBackColor = true;
            this.btnParentesisDerecho.Click += new System.EventHandler(this.BtnParentesisDerecho_Click);
            // 
            // btnParentesisIzquierdo
            // 
            resources.ApplyResources(this.btnParentesisIzquierdo, "btnParentesisIzquierdo");
            this.btnParentesisIzquierdo.Name = "btnParentesisIzquierdo";
            this.btnParentesisIzquierdo.UseVisualStyleBackColor = true;
            this.btnParentesisIzquierdo.Click += new System.EventHandler(this.BtnParentesisIzquierdo_Click);
            // 
            // lblResultado
            // 
            resources.ApplyResources(this.lblResultado, "lblResultado");
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Tag = "lblIntegral";
            this.lblResultado.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnSuma
            // 
            resources.ApplyResources(this.btnSuma, "btnSuma");
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // btnResta
            // 
            resources.ApplyResources(this.btnResta, "btnResta");
            this.btnResta.Name = "btnResta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // btnDivision
            // 
            resources.ApplyResources(this.btnDivision, "btnDivision");
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Tag = "btnBorrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // rdButtonDerecha
            // 
            resources.ApplyResources(this.rdButtonDerecha, "rdButtonDerecha");
            this.rdButtonDerecha.Name = "rdButtonDerecha";
            this.rdButtonDerecha.UseVisualStyleBackColor = true;
            this.rdButtonDerecha.CheckedChanged += new System.EventHandler(this.rdButtonDerecha_CheckedChanged_1);
            // 
            // rdButonIzquierda
            // 
            resources.ApplyResources(this.rdButonIzquierda, "rdButonIzquierda");
            this.rdButonIzquierda.Name = "rdButonIzquierda";
            this.rdButonIzquierda.UseVisualStyleBackColor = true;
            this.rdButonIzquierda.CheckedChanged += new System.EventHandler(this.rdButonIzquierda_CheckedChanged_1);
            // 
            // lblerror
            // 
            resources.ApplyResources(this.lblerror, "lblerror");
            this.lblerror.Name = "lblerror";
            this.lblerror.Tag = "lblIntegral";
            // 
            // txterror
            // 
            this.txterror.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txterror, "txterror");
            this.txterror.Name = "txterror";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.Tag = "btnBorrar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            this.pictureBox5.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox5_DragEnter);
            // 
            // pictureBox6
            // 
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.rdButonIzquierda);
            this.Controls.Add(this.rdButtonDerecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnParentesisIzquierdo);
            this.Controls.Add(this.btnParentesisDerecho);
            this.Controls.Add(this.txtIntegral);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnTangente);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnCsc);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnCot);
            this.Controls.Add(this.BtnlLog);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.TablaDeDatos);
            this.Controls.Add(this.txtPedazo);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdButtonSimpson);
            this.Controls.Add(this.rdButtonTrapecios);
            this.Controls.Add(this.rdButtonSumas);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Opacity = 0.9D;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton rdButtonSumas;
        private System.Windows.Forms.RadioButton rdButtonTrapecios;
        private System.Windows.Forms.RadioButton rdButtonSimpson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPedazo;
        private System.Windows.Forms.DataGridView TablaDeDatos;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button BtnlLog;
        private System.Windows.Forms.Button btnCot;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnCsc;
        private System.Windows.Forms.TextBox txtIntegral;
        private System.Windows.Forms.Button btnParentesisDerecho;
        private System.Windows.Forms.Button btnParentesisIzquierdo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox rdButtonDerecha;
        private System.Windows.Forms.CheckBox rdButonIzquierda;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.TextBox txterror;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

