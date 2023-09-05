
namespace Tarea_de_progra_miercoles
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
            this.cboDesde = new System.Windows.Forms.ComboBox();
            this.cboHasta = new System.Windows.Forms.ComboBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblAdicional = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.cbNum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboDesde
            // 
            this.cboDesde.FormattingEnabled = true;
            this.cboDesde.Location = new System.Drawing.Point(108, 111);
            this.cboDesde.Name = "cboDesde";
            this.cboDesde.Size = new System.Drawing.Size(121, 28);
            this.cboDesde.TabIndex = 0;
            // 
            // cboHasta
            // 
            this.cboHasta.FormattingEnabled = true;
            this.cboHasta.Location = new System.Drawing.Point(108, 184);
            this.cboHasta.Name = "cboHasta";
            this.cboHasta.Size = new System.Drawing.Size(121, 28);
            this.cboHasta.TabIndex = 1;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(112, 334);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(150, 41);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "Empezar";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(139, 152);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 20);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(135, 77);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(56, 20);
            this.lblDesde.TabIndex = 5;
            this.lblDesde.Text = "Desde";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(325, 90);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 20);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio: ";
            this.lblPrecio.Visible = false;
            // 
            // lblAdicional
            // 
            this.lblAdicional.AutoSize = true;
            this.lblAdicional.Location = new System.Drawing.Point(325, 131);
            this.lblAdicional.Name = "lblAdicional";
            this.lblAdicional.Size = new System.Drawing.Size(81, 20);
            this.lblAdicional.TabIndex = 7;
            this.lblAdicional.Text = "Adicional: ";
            this.lblAdicional.Visible = false;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(143, 290);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(52, 20);
            this.lblRespuesta.TabIndex = 8;
            this.lblRespuesta.Text = "Total: ";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(108, 234);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(173, 26);
            this.txtMonto.TabIndex = 9;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(61, 26);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(25, 20);
            this.lblNum.TabIndex = 10;
            this.lblNum.Text = "N°";
            // 
            // cbNum
            // 
            this.cbNum.FormattingEnabled = true;
            this.cbNum.Location = new System.Drawing.Point(92, 26);
            this.cbNum.Name = "cbNum";
            this.cbNum.Size = new System.Drawing.Size(121, 28);
            this.cbNum.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 451);
            this.Controls.Add(this.cbNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblAdicional);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.cboHasta);
            this.Controls.Add(this.cboDesde);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDesde;
        private System.Windows.Forms.ComboBox cboHasta;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblAdicional;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ComboBox cbNum;
    }
}

