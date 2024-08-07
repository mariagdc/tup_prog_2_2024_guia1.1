namespace Guia1._1
{
    partial class Form2
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
            this.lbxresultados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarmodal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxresultados
            // 
            this.lbxresultados.FormattingEnabled = true;
            this.lbxresultados.Location = new System.Drawing.Point(27, 101);
            this.lbxresultados.Name = "lbxresultados";
            this.lbxresultados.Size = new System.Drawing.Size(343, 147);
            this.lbxresultados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultados";
            // 
            // btnCerrarmodal
            // 
            this.btnCerrarmodal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrarmodal.Location = new System.Drawing.Point(149, 304);
            this.btnCerrarmodal.Name = "btnCerrarmodal";
            this.btnCerrarmodal.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarmodal.TabIndex = 2;
            this.btnCerrarmodal.Text = "Cerrar";
            this.btnCerrarmodal.UseVisualStyleBackColor = true;
            this.btnCerrarmodal.Click += new System.EventHandler(this.btnCerrarmodal_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarmodal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxresultados);
            this.Name = "Form2";
            this.Text = "Ver resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lbxresultados;
        private System.Windows.Forms.Button btnCerrarmodal;
    }
}