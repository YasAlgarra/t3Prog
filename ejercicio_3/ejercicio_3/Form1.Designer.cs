﻿namespace ejercicio_3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarCuadrados = new System.Windows.Forms.Button();
            this.btnMostrarCirculos = new System.Windows.Forms.Button();
            this.btnMostrarFiguras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAutorrelleno = new System.Windows.Forms.Button();
            this.btnIntroducirCuadrado = new System.Windows.Forms.Button();
            this.btnIntroducirCirculo = new System.Windows.Forms.Button();
            this.btnIntroducirTriangulo = new System.Windows.Forms.Button();
            this.btnIntroducirRectangulo = new System.Windows.Forms.Button();
            this.btnIntroducirHexagono = new System.Windows.Forms.Button();
            this.btnMostrarTriangulos = new System.Windows.Forms.Button();
            this.btnMostrarRectangulos = new System.Windows.Forms.Button();
            this.btnMostrarHexagono = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarHexagono);
            this.groupBox2.Controls.Add(this.btnMostrarRectangulos);
            this.groupBox2.Controls.Add(this.btnMostrarTriangulos);
            this.groupBox2.Controls.Add(this.btnMostrarCuadrados);
            this.groupBox2.Controls.Add(this.btnMostrarCirculos);
            this.groupBox2.Controls.Add(this.btnMostrarFiguras);
            this.groupBox2.Location = new System.Drawing.Point(410, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 620);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnMostrarCuadrados
            // 
            this.btnMostrarCuadrados.Location = new System.Drawing.Point(39, 141);
            this.btnMostrarCuadrados.Name = "btnMostrarCuadrados";
            this.btnMostrarCuadrados.Size = new System.Drawing.Size(238, 67);
            this.btnMostrarCuadrados.TabIndex = 6;
            this.btnMostrarCuadrados.Text = "Mostrar Cuadrados";
            this.btnMostrarCuadrados.UseVisualStyleBackColor = true;
            this.btnMostrarCuadrados.Click += new System.EventHandler(this.btnMostrarCuadrados_Click_1);
            // 
            // btnMostrarCirculos
            // 
            this.btnMostrarCirculos.Location = new System.Drawing.Point(39, 51);
            this.btnMostrarCirculos.Name = "btnMostrarCirculos";
            this.btnMostrarCirculos.Size = new System.Drawing.Size(238, 67);
            this.btnMostrarCirculos.TabIndex = 5;
            this.btnMostrarCirculos.Text = "Mostrar Círculos";
            this.btnMostrarCirculos.UseVisualStyleBackColor = true;
            this.btnMostrarCirculos.Click += new System.EventHandler(this.btnMostrarCirculos_Click_1);
            // 
            // btnMostrarFiguras
            // 
            this.btnMostrarFiguras.Location = new System.Drawing.Point(39, 529);
            this.btnMostrarFiguras.Name = "btnMostrarFiguras";
            this.btnMostrarFiguras.Size = new System.Drawing.Size(238, 67);
            this.btnMostrarFiguras.TabIndex = 4;
            this.btnMostrarFiguras.Text = "Mostrar Todas Las Figuras";
            this.btnMostrarFiguras.UseVisualStyleBackColor = true;
            this.btnMostrarFiguras.Click += new System.EventHandler(this.btnMostrarFiguras_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIntroducirHexagono);
            this.groupBox1.Controls.Add(this.btnIntroducirRectangulo);
            this.groupBox1.Controls.Add(this.btnIntroducirTriangulo);
            this.groupBox1.Controls.Add(this.btnAutorrelleno);
            this.groupBox1.Controls.Add(this.btnIntroducirCuadrado);
            this.groupBox1.Controls.Add(this.btnIntroducirCirculo);
            this.groupBox1.Location = new System.Drawing.Point(48, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 620);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnAutorrelleno
            // 
            this.btnAutorrelleno.Location = new System.Drawing.Point(39, 529);
            this.btnAutorrelleno.Name = "btnAutorrelleno";
            this.btnAutorrelleno.Size = new System.Drawing.Size(238, 67);
            this.btnAutorrelleno.TabIndex = 4;
            this.btnAutorrelleno.Text = "Autorrelleno";
            this.btnAutorrelleno.UseVisualStyleBackColor = true;
            this.btnAutorrelleno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIntroducirCuadrado
            // 
            this.btnIntroducirCuadrado.Location = new System.Drawing.Point(39, 141);
            this.btnIntroducirCuadrado.Name = "btnIntroducirCuadrado";
            this.btnIntroducirCuadrado.Size = new System.Drawing.Size(238, 67);
            this.btnIntroducirCuadrado.TabIndex = 3;
            this.btnIntroducirCuadrado.Text = "Introducir Cuadrado";
            this.btnIntroducirCuadrado.UseVisualStyleBackColor = true;
            // 
            // btnIntroducirCirculo
            // 
            this.btnIntroducirCirculo.Location = new System.Drawing.Point(39, 51);
            this.btnIntroducirCirculo.Name = "btnIntroducirCirculo";
            this.btnIntroducirCirculo.Size = new System.Drawing.Size(238, 67);
            this.btnIntroducirCirculo.TabIndex = 2;
            this.btnIntroducirCirculo.Text = "Introducir Círculo";
            this.btnIntroducirCirculo.UseVisualStyleBackColor = true;
            this.btnIntroducirCirculo.Click += new System.EventHandler(this.btnIntroducirCirculo_Click);
            // 
            // btnIntroducirTriangulo
            // 
            this.btnIntroducirTriangulo.Location = new System.Drawing.Point(39, 228);
            this.btnIntroducirTriangulo.Name = "btnIntroducirTriangulo";
            this.btnIntroducirTriangulo.Size = new System.Drawing.Size(238, 67);
            this.btnIntroducirTriangulo.TabIndex = 5;
            this.btnIntroducirTriangulo.Text = "Introducir Triángulo Equiátero";
            this.btnIntroducirTriangulo.UseVisualStyleBackColor = true;
            this.btnIntroducirTriangulo.Click += new System.EventHandler(this.btnIntroducirTriangulo_Click);
            // 
            // btnIntroducirRectangulo
            // 
            this.btnIntroducirRectangulo.Location = new System.Drawing.Point(39, 314);
            this.btnIntroducirRectangulo.Name = "btnIntroducirRectangulo";
            this.btnIntroducirRectangulo.Size = new System.Drawing.Size(238, 67);
            this.btnIntroducirRectangulo.TabIndex = 6;
            this.btnIntroducirRectangulo.Text = "Introducir Rectángulo";
            this.btnIntroducirRectangulo.UseVisualStyleBackColor = true;
            this.btnIntroducirRectangulo.Click += new System.EventHandler(this.btnIntroducirRectangulo_Click);
            // 
            // btnIntroducirHexagono
            // 
            this.btnIntroducirHexagono.Location = new System.Drawing.Point(39, 402);
            this.btnIntroducirHexagono.Name = "btnIntroducirHexagono";
            this.btnIntroducirHexagono.Size = new System.Drawing.Size(238, 67);
            this.btnIntroducirHexagono.TabIndex = 7;
            this.btnIntroducirHexagono.Text = "Introducir Hexágono Regular";
            this.btnIntroducirHexagono.UseVisualStyleBackColor = true;
            this.btnIntroducirHexagono.Click += new System.EventHandler(this.btnIntroducirHexagono_Click);
            // 
            // btnMostrarTriangulos
            // 
            this.btnMostrarTriangulos.Location = new System.Drawing.Point(39, 228);
            this.btnMostrarTriangulos.Name = "btnMostrarTriangulos";
            this.btnMostrarTriangulos.Size = new System.Drawing.Size(238, 67);
            this.btnMostrarTriangulos.TabIndex = 7;
            this.btnMostrarTriangulos.Text = "Mostrar Triángulos";
            this.btnMostrarTriangulos.UseVisualStyleBackColor = true;
            this.btnMostrarTriangulos.Click += new System.EventHandler(this.btnMostrarTriangulos_Click);
            // 
            // btnMostrarRectangulos
            // 
            this.btnMostrarRectangulos.Location = new System.Drawing.Point(39, 314);
            this.btnMostrarRectangulos.Name = "btnMostrarRectangulos";
            this.btnMostrarRectangulos.Size = new System.Drawing.Size(238, 67);
            this.btnMostrarRectangulos.TabIndex = 8;
            this.btnMostrarRectangulos.Text = "Mostrar Rectángulos";
            this.btnMostrarRectangulos.UseVisualStyleBackColor = true;
            this.btnMostrarRectangulos.Click += new System.EventHandler(this.btnMostrarRectangulos_Click);
            // 
            // btnMostrarHexagono
            // 
            this.btnMostrarHexagono.Location = new System.Drawing.Point(39, 402);
            this.btnMostrarHexagono.Name = "btnMostrarHexagono";
            this.btnMostrarHexagono.Size = new System.Drawing.Size(238, 67);
            this.btnMostrarHexagono.TabIndex = 9;
            this.btnMostrarHexagono.Text = "Mostrar Hexágonos";
            this.btnMostrarHexagono.UseVisualStyleBackColor = true;
            this.btnMostrarHexagono.Click += new System.EventHandler(this.btnMostrarHexagono_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 691);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarCuadrados;
        private System.Windows.Forms.Button btnMostrarCirculos;
        private System.Windows.Forms.Button btnMostrarFiguras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIntroducirCuadrado;
        private System.Windows.Forms.Button btnIntroducirCirculo;
        private System.Windows.Forms.Button btnAutorrelleno;
        private System.Windows.Forms.Button btnMostrarHexagono;
        private System.Windows.Forms.Button btnMostrarRectangulos;
        private System.Windows.Forms.Button btnMostrarTriangulos;
        private System.Windows.Forms.Button btnIntroducirHexagono;
        private System.Windows.Forms.Button btnIntroducirRectangulo;
        private System.Windows.Forms.Button btnIntroducirTriangulo;
    }
}

