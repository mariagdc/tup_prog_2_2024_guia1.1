namespace Guia1._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTasa = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorFabric = new System.Windows.Forms.TextBox();
            this.upAño = new System.Windows.Forms.NumericUpDown();
            this.upAñoCalcular = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.upAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upAñoCalcular)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(264, 335);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(83, 48);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(140, 335);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 48);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular Costo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tasa de depreciación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vida Útil (Años)";
            // 
            // tbTasa
            // 
            this.tbTasa.Location = new System.Drawing.Point(442, 81);
            this.tbTasa.Name = "tbTasa";
            this.tbTasa.Size = new System.Drawing.Size(100, 20);
            this.tbTasa.TabIndex = 8;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(442, 125);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tbVidaUtil.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo(Año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año a calcular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor de fabricación $";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(107, 36);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 10;
            // 
            // tbValorFabric
            // 
            this.tbValorFabric.Location = new System.Drawing.Point(140, 148);
            this.tbValorFabric.Name = "tbValorFabric";
            this.tbValorFabric.Size = new System.Drawing.Size(67, 20);
            this.tbValorFabric.TabIndex = 11;
            // 
            // upAño
            // 
            this.upAño.Location = new System.Drawing.Point(107, 71);
            this.upAño.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.upAño.Name = "upAño";
            this.upAño.Size = new System.Drawing.Size(100, 20);
            this.upAño.TabIndex = 12;
            // 
            // upAñoCalcular
            // 
            this.upAñoCalcular.Location = new System.Drawing.Point(107, 115);
            this.upAñoCalcular.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.upAñoCalcular.Name = "upAñoCalcular";
            this.upAñoCalcular.Size = new System.Drawing.Size(100, 20);
            this.upAñoCalcular.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMarca);
            this.groupBox1.Controls.Add(this.upAñoCalcular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.upAño);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbValorFabric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(33, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 180);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.tbTasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCerrar);
            this.Name = "Form1";
            this.Text = "Tasación de motos";
            ((System.ComponentModel.ISupportInitialize)(this.upAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upAñoCalcular)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnCalcular;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox tbMarca;
        public System.Windows.Forms.NumericUpDown upAño;
        public System.Windows.Forms.NumericUpDown upAñoCalcular;
        public System.Windows.Forms.TextBox tbValorFabric;
        public System.Windows.Forms.TextBox tbTasa;
        public System.Windows.Forms.TextBox tbVidaUtil;
    }
}

