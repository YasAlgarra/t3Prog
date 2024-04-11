namespace ejercicio_3
{
    partial class frmIntroducirRectangulo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPosicionY = new System.Windows.Forms.TextBox();
            this.txtPosicionX = new System.Windows.Forms.TextBox();
            this.btnAgregarRectangulo = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPosicionY = new System.Windows.Forms.Label();
            this.lblPosicionX = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAltura);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.txtBase);
            this.groupBox1.Controls.Add(this.lblBase);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtPosicionY);
            this.groupBox1.Controls.Add(this.txtPosicionX);
            this.groupBox1.Controls.Add(this.btnAgregarRectangulo);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.lblPosicionY);
            this.groupBox1.Controls.Add(this.lblPosicionX);
            this.groupBox1.Location = new System.Drawing.Point(153, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 465);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca Los Datos Del Rectángulo";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(94, 308);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(55, 20);
            this.lblAltura.TabIndex = 12;
            this.lblAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(160, 308);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(161, 26);
            this.txtAltura.TabIndex = 11;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(160, 250);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(161, 26);
            this.txtBase.TabIndex = 10;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(94, 256);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(46, 20);
            this.lblBase.TabIndex = 9;
            this.lblBase.Text = "Base";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(160, 195);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(161, 26);
            this.txtColor.TabIndex = 7;
            // 
            // txtPosicionY
            // 
            this.txtPosicionY.Location = new System.Drawing.Point(160, 139);
            this.txtPosicionY.Name = "txtPosicionY";
            this.txtPosicionY.Size = new System.Drawing.Size(161, 26);
            this.txtPosicionY.TabIndex = 6;
            // 
            // txtPosicionX
            // 
            this.txtPosicionX.Location = new System.Drawing.Point(160, 79);
            this.txtPosicionX.Name = "txtPosicionX";
            this.txtPosicionX.Size = new System.Drawing.Size(161, 26);
            this.txtPosicionX.TabIndex = 5;
            // 
            // btnAgregarRectangulo
            // 
            this.btnAgregarRectangulo.Location = new System.Drawing.Point(79, 385);
            this.btnAgregarRectangulo.Name = "btnAgregarRectangulo";
            this.btnAgregarRectangulo.Size = new System.Drawing.Size(308, 50);
            this.btnAgregarRectangulo.TabIndex = 4;
            this.btnAgregarRectangulo.Text = "Añadir Rectángulo";
            this.btnAgregarRectangulo.UseVisualStyleBackColor = true;
            this.btnAgregarRectangulo.Click += new System.EventHandler(this.btnAgregarRectangulo_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(91, 191);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 20);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // lblPosicionY
            // 
            this.lblPosicionY.AutoSize = true;
            this.lblPosicionY.Location = new System.Drawing.Point(53, 139);
            this.lblPosicionY.Name = "lblPosicionY";
            this.lblPosicionY.Size = new System.Drawing.Size(87, 20);
            this.lblPosicionY.TabIndex = 1;
            this.lblPosicionY.Text = "Posición Y:";
            // 
            // lblPosicionX
            // 
            this.lblPosicionX.AutoSize = true;
            this.lblPosicionX.Location = new System.Drawing.Point(53, 82);
            this.lblPosicionX.Name = "lblPosicionX";
            this.lblPosicionX.Size = new System.Drawing.Size(87, 20);
            this.lblPosicionX.TabIndex = 0;
            this.lblPosicionX.Text = "Posición X:";
            // 
            // frmIntroducirRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIntroducirRectangulo";
            this.Text = "frmIntroducirRectangulo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPosicionY;
        private System.Windows.Forms.TextBox txtPosicionX;
        private System.Windows.Forms.Button btnAgregarRectangulo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPosicionY;
        private System.Windows.Forms.Label lblPosicionX;
    }
}