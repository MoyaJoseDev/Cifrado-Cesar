namespace Cifrado_Cesar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cuadroTexto = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cuadroResultado = new System.Windows.Forms.TextBox();
            this.botonTraducir = new System.Windows.Forms.Button();
            this.botonCifrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cifrado en codigo Cesar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cuadroTexto
            // 
            this.cuadroTexto.Location = new System.Drawing.Point(229, 109);
            this.cuadroTexto.Multiline = true;
            this.cuadroTexto.Name = "cuadroTexto";
            this.cuadroTexto.Size = new System.Drawing.Size(815, 190);
            this.cuadroTexto.TabIndex = 1;
            this.cuadroTexto.TextChanged += new System.EventHandler(this.cuadroTexto_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cuadroResultado
            // 
            this.cuadroResultado.Location = new System.Drawing.Point(229, 399);
            this.cuadroResultado.Multiline = true;
            this.cuadroResultado.Name = "cuadroResultado";
            this.cuadroResultado.Size = new System.Drawing.Size(815, 190);
            this.cuadroResultado.TabIndex = 3;
            this.cuadroResultado.TextChanged += new System.EventHandler(this.cuadroResultado_TextChanged);
            // 
            // botonTraducir
            // 
            this.botonTraducir.Location = new System.Drawing.Point(698, 333);
            this.botonTraducir.Name = "botonTraducir";
            this.botonTraducir.Size = new System.Drawing.Size(128, 46);
            this.botonTraducir.TabIndex = 4;
            this.botonTraducir.Text = "TRADUCIR";
            this.botonTraducir.UseVisualStyleBackColor = true;
            this.botonTraducir.Click += new System.EventHandler(this.botonTraducir_Click);
            // 
            // botonCifrar
            // 
            this.botonCifrar.Location = new System.Drawing.Point(492, 333);
            this.botonCifrar.Name = "botonCifrar";
            this.botonCifrar.Size = new System.Drawing.Size(128, 46);
            this.botonCifrar.TabIndex = 5;
            this.botonCifrar.Text = "CIFRAR";
            this.botonCifrar.UseVisualStyleBackColor = true;
            this.botonCifrar.Click += new System.EventHandler(this.botonCifrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1093, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 105);
            this.button1.TabIndex = 6;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1106, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "MoyaJoseDev";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonCifrar);
            this.Controls.Add(this.botonTraducir);
            this.Controls.Add(this.cuadroResultado);
            this.Controls.Add(this.cuadroTexto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cuadroTexto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox cuadroResultado;
        private System.Windows.Forms.Button botonTraducir;
        private System.Windows.Forms.Button botonCifrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

