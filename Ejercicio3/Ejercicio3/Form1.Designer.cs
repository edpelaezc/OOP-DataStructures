namespace Ejercicio3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IngresarNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.IngresarNum2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.IngresarNumero3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // IngresarNum
            // 
            this.IngresarNum.Location = new System.Drawing.Point(157, 72);
            this.IngresarNum.Name = "IngresarNum";
            this.IngresarNum.Size = new System.Drawing.Size(114, 23);
            this.IngresarNum.TabIndex = 1;
            this.IngresarNum.Text = "Ingresar Número 1";
            this.IngresarNum.UseVisualStyleBackColor = true;
            this.IngresarNum.Click += new System.EventHandler(this.IngresarNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "EJERCICIO 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese los números";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // IngresarNum2
            // 
            this.IngresarNum2.Location = new System.Drawing.Point(157, 112);
            this.IngresarNum2.Name = "IngresarNum2";
            this.IngresarNum2.Size = new System.Drawing.Size(114, 23);
            this.IngresarNum2.TabIndex = 5;
            this.IngresarNum2.Text = "Ingresar Número 2";
            this.IngresarNum2.UseVisualStyleBackColor = true;
            this.IngresarNum2.Click += new System.EventHandler(this.IngresarNum2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // IngresarNumero3
            // 
            this.IngresarNumero3.Location = new System.Drawing.Point(157, 153);
            this.IngresarNumero3.Name = "IngresarNumero3";
            this.IngresarNumero3.Size = new System.Drawing.Size(114, 23);
            this.IngresarNumero3.TabIndex = 7;
            this.IngresarNumero3.Text = "Ingresar Número 3";
            this.IngresarNumero3.UseVisualStyleBackColor = true;
            this.IngresarNumero3.Click += new System.EventHandler(this.IngresarNumero3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "Identificar Mayor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 59);
            this.button2.TabIndex = 9;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 324);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IngresarNumero3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.IngresarNum2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngresarNum);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Introducción a la Programación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button IngresarNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button IngresarNum2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button IngresarNumero3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

