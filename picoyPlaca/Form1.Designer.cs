namespace picoyPlaca
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtNumeroPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHora = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(448, 89);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(77, 29);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar Datos";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtNumeroPlaca
            // 
            this.txtNumeroPlaca.Location = new System.Drawing.Point(58, 95);
            this.txtNumeroPlaca.Name = "txtNumeroPlaca";
            this.txtNumeroPlaca.Size = new System.Drawing.Size(114, 22);
            this.txtNumeroPlaca.TabIndex = 1;
            this.txtNumeroPlaca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de Placa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "INGRESE LOS SIGUIENTES DATOS";
            // 
            // mtxtFecha
            // 
            this.mtxtFecha.Location = new System.Drawing.Point(242, 95);
            this.mtxtFecha.Mask = "00/00/0000";
            this.mtxtFecha.Name = "mtxtFecha";
            this.mtxtFecha.Size = new System.Drawing.Size(80, 22);
            this.mtxtFecha.TabIndex = 6;
            this.mtxtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHora
            // 
            this.mtxtHora.Location = new System.Drawing.Point(371, 95);
            this.mtxtHora.Mask = "00:00";
            this.mtxtHora.Name = "mtxtHora";
            this.mtxtHora.Size = new System.Drawing.Size(41, 22);
            this.mtxtHora.TabIndex = 7;
            this.mtxtHora.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(58, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 84);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 326);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtHora);
            this.Controls.Add(this.mtxtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroPlaca);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Pico y PLaca ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtNumeroPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtFecha;
        private System.Windows.Forms.MaskedTextBox mtxtHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

