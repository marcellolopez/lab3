namespace laboratorio_n3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pt_angulo = new System.Windows.Forms.TextBox();
            this.txt_pt_frecuencia = new System.Windows.Forms.TextBox();
            this.txt_pt_tensionRms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pc_r = new System.Windows.Forms.TextBox();
            this.txt_pc_l = new System.Windows.Forms.TextBox();
            this.txt_pc_c = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_r_zRectangular = new System.Windows.Forms.TextBox();
            this.txt_r_zPolar = new System.Windows.Forms.TextBox();
            this.txt_r_i = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_r_p = new System.Windows.Forms.TextBox();
            this.txt_r_q = new System.Windows.Forms.TextBox();
            this.txt_r_s = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.img_LCR = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.img_CRL = new System.Windows.Forms.PictureBox();
            this.cb_circuito = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_LCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_CRL)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pt_angulo);
            this.groupBox1.Controls.Add(this.txt_pt_frecuencia);
            this.groupBox1.Controls.Add(this.txt_pt_tensionRms);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros Tensión";
            // 
            // txt_pt_angulo
            // 
            this.txt_pt_angulo.Location = new System.Drawing.Point(112, 76);
            this.txt_pt_angulo.Name = "txt_pt_angulo";
            this.txt_pt_angulo.Size = new System.Drawing.Size(100, 20);
            this.txt_pt_angulo.TabIndex = 5;
            // 
            // txt_pt_frecuencia
            // 
            this.txt_pt_frecuencia.Location = new System.Drawing.Point(112, 47);
            this.txt_pt_frecuencia.Name = "txt_pt_frecuencia";
            this.txt_pt_frecuencia.Size = new System.Drawing.Size(100, 20);
            this.txt_pt_frecuencia.TabIndex = 4;
            // 
            // txt_pt_tensionRms
            // 
            this.txt_pt_tensionRms.Location = new System.Drawing.Point(112, 17);
            this.txt_pt_tensionRms.Name = "txt_pt_tensionRms";
            this.txt_pt_tensionRms.Size = new System.Drawing.Size(100, 20);
            this.txt_pt_tensionRms.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ángulo [º]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frencuencia [Hz]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tensión RMS [V]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "R [Ohm]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "L [mH]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "C [µF]";
            // 
            // txt_pc_r
            // 
            this.txt_pc_r.Location = new System.Drawing.Point(112, 17);
            this.txt_pc_r.Name = "txt_pc_r";
            this.txt_pc_r.Size = new System.Drawing.Size(100, 20);
            this.txt_pc_r.TabIndex = 3;
            // 
            // txt_pc_l
            // 
            this.txt_pc_l.Location = new System.Drawing.Point(112, 47);
            this.txt_pc_l.Name = "txt_pc_l";
            this.txt_pc_l.Size = new System.Drawing.Size(100, 20);
            this.txt_pc_l.TabIndex = 4;
            // 
            // txt_pc_c
            // 
            this.txt_pc_c.Location = new System.Drawing.Point(112, 76);
            this.txt_pc_c.Name = "txt_pc_c";
            this.txt_pc_c.Size = new System.Drawing.Size(100, 20);
            this.txt_pc_c.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_calcular);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_limpiar);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_pc_c);
            this.groupBox2.Controls.Add(this.txt_pc_l);
            this.groupBox2.Controls.Add(this.txt_pc_r);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros de la Carga";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Z rectangular (R+jX) [Ohm]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Z polar Z/_A°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "I [A]";
            // 
            // txt_r_zRectangular
            // 
            this.txt_r_zRectangular.Location = new System.Drawing.Point(169, 17);
            this.txt_r_zRectangular.Name = "txt_r_zRectangular";
            this.txt_r_zRectangular.Size = new System.Drawing.Size(100, 20);
            this.txt_r_zRectangular.TabIndex = 3;
            // 
            // txt_r_zPolar
            // 
            this.txt_r_zPolar.Location = new System.Drawing.Point(169, 47);
            this.txt_r_zPolar.Name = "txt_r_zPolar";
            this.txt_r_zPolar.Size = new System.Drawing.Size(100, 20);
            this.txt_r_zPolar.TabIndex = 4;
            // 
            // txt_r_i
            // 
            this.txt_r_i.Location = new System.Drawing.Point(169, 76);
            this.txt_r_i.Name = "txt_r_i";
            this.txt_r_i.Size = new System.Drawing.Size(100, 20);
            this.txt_r_i.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "P [W]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Q [VAr]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "S[VA]";
            // 
            // txt_r_p
            // 
            this.txt_r_p.Location = new System.Drawing.Point(169, 106);
            this.txt_r_p.Name = "txt_r_p";
            this.txt_r_p.Size = new System.Drawing.Size(100, 20);
            this.txt_r_p.TabIndex = 9;
            // 
            // txt_r_q
            // 
            this.txt_r_q.Location = new System.Drawing.Point(169, 136);
            this.txt_r_q.Name = "txt_r_q";
            this.txt_r_q.Size = new System.Drawing.Size(100, 20);
            this.txt_r_q.TabIndex = 10;
            // 
            // txt_r_s
            // 
            this.txt_r_s.Location = new System.Drawing.Point(169, 165);
            this.txt_r_s.Name = "txt_r_s";
            this.txt_r_s.Size = new System.Drawing.Size(100, 20);
            this.txt_r_s.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_r_s);
            this.groupBox3.Controls.Add(this.txt_r_q);
            this.groupBox3.Controls.Add(this.txt_r_p);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_r_i);
            this.groupBox3.Controls.Add(this.txt_r_zPolar);
            this.groupBox3.Controls.Add(this.txt_r_zRectangular);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 197);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // img_LCR
            // 
            this.img_LCR.Image = global::laboratorio_n3.Properties.Resources.LCR;
            this.img_LCR.Location = new System.Drawing.Point(329, 12);
            this.img_LCR.Name = "img_LCR";
            this.img_LCR.Size = new System.Drawing.Size(532, 560);
            this.img_LCR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_LCR.TabIndex = 3;
            this.img_LCR.TabStop = false;
            this.img_LCR.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Seleccione circuito";
            // 
            // img_CRL
            // 
            this.img_CRL.Image = global::laboratorio_n3.Properties.Resources.CRL;
            this.img_CRL.Location = new System.Drawing.Point(329, 12);
            this.img_CRL.Name = "img_CRL";
            this.img_CRL.Size = new System.Drawing.Size(532, 560);
            this.img_CRL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_CRL.TabIndex = 6;
            this.img_CRL.TabStop = false;
            // 
            // cb_circuito
            // 
            this.cb_circuito.FormattingEnabled = true;
            this.cb_circuito.Items.AddRange(new object[] {
            "CLR",
            "LCR"});
            this.cb_circuito.Location = new System.Drawing.Point(13, 33);
            this.cb_circuito.Name = "cb_circuito";
            this.cb_circuito.Size = new System.Drawing.Size(238, 21);
            this.cb_circuito.TabIndex = 4;
            this.cb_circuito.Text = "CLR";
            this.cb_circuito.SelectedIndexChanged += new System.EventHandler(this.cb_circuito_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 587);
            this.Controls.Add(this.img_CRL);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_circuito);
            this.Controls.Add(this.img_LCR);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Circuito RLC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_LCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_CRL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_pt_angulo;
        private System.Windows.Forms.TextBox txt_pt_frecuencia;
        private System.Windows.Forms.TextBox txt_pt_tensionRms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pc_r;
        private System.Windows.Forms.TextBox txt_pc_l;
        private System.Windows.Forms.TextBox txt_pc_c;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_r_zRectangular;
        private System.Windows.Forms.TextBox txt_r_zPolar;
        private System.Windows.Forms.TextBox txt_r_i;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_r_p;
        private System.Windows.Forms.TextBox txt_r_q;
        private System.Windows.Forms.TextBox txt_r_s;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox img_LCR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox img_CRL;
        private System.Windows.Forms.ComboBox cb_circuito;
    }
}

