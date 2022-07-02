namespace Cifrado_Cesar
{
    partial class CifradoCesar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CifradoCesar));
            this.label1 = new System.Windows.Forms.Label();
            this.cuadroTexto = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cuadroResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copyButton = new Cifrado_Cesar.clases.RJButton();
            this.traducirV2 = new Cifrado_Cesar.clases.RJButton();
            this.cifrarV2 = new Cifrado_Cesar.clases.RJButton();
            this.GitHub_Button = new Cifrado_Cesar.clases.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(486, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cifrador en codigo Cesar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cuadroTexto
            // 
            this.cuadroTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cuadroTexto.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroTexto.Location = new System.Drawing.Point(229, 109);
            this.cuadroTexto.Multiline = true;
            this.cuadroTexto.Name = "cuadroTexto";
            this.cuadroTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cuadroTexto.Size = new System.Drawing.Size(815, 190);
            this.cuadroTexto.TabIndex = 1;
            this.cuadroTexto.Text = "Escribe aquí lo que quieras codificar o traducir !\r\n";
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
            this.cuadroResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cuadroResultado.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroResultado.Location = new System.Drawing.Point(229, 399);
            this.cuadroResultado.Multiline = true;
            this.cuadroResultado.Name = "cuadroResultado";
            this.cuadroResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cuadroResultado.Size = new System.Drawing.Size(815, 190);
            this.cuadroResultado.TabIndex = 3;
            this.cuadroResultado.TextChanged += new System.EventHandler(this.cuadroResultado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1101, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "MoyaJoseDev";
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.copyButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.copyButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.copyButton.BorderRadius = 20;
            this.copyButton.BorderSize = 0;
            this.copyButton.FlatAppearance.BorderSize = 0;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.ForeColor = System.Drawing.Color.White;
            this.copyButton.Location = new System.Drawing.Point(602, 596);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(150, 40);
            this.copyButton.TabIndex = 11;
            this.copyButton.Text = "COPIAR TEXTO";
            this.copyButton.TextColor = System.Drawing.Color.White;
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // traducirV2
            // 
            this.traducirV2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.traducirV2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.traducirV2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.traducirV2.BorderRadius = 20;
            this.traducirV2.BorderSize = 0;
            this.traducirV2.FlatAppearance.BorderSize = 0;
            this.traducirV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.traducirV2.ForeColor = System.Drawing.Color.White;
            this.traducirV2.Location = new System.Drawing.Point(728, 330);
            this.traducirV2.Name = "traducirV2";
            this.traducirV2.Size = new System.Drawing.Size(150, 40);
            this.traducirV2.TabIndex = 10;
            this.traducirV2.Text = "TRADUCIR";
            this.traducirV2.TextColor = System.Drawing.Color.White;
            this.traducirV2.UseVisualStyleBackColor = false;
            this.traducirV2.Click += new System.EventHandler(this.traducirV2_Click);
            // 
            // cifrarV2
            // 
            this.cifrarV2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cifrarV2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cifrarV2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cifrarV2.BorderRadius = 20;
            this.cifrarV2.BorderSize = 0;
            this.cifrarV2.FlatAppearance.BorderSize = 0;
            this.cifrarV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cifrarV2.ForeColor = System.Drawing.Color.White;
            this.cifrarV2.Location = new System.Drawing.Point(437, 330);
            this.cifrarV2.Name = "cifrarV2";
            this.cifrarV2.Size = new System.Drawing.Size(150, 40);
            this.cifrarV2.TabIndex = 9;
            this.cifrarV2.Text = "CIFRAR";
            this.cifrarV2.TextColor = System.Drawing.Color.White;
            this.cifrarV2.UseVisualStyleBackColor = false;
            this.cifrarV2.Click += new System.EventHandler(this.cifrarV2_Click);
            // 
            // GitHub_Button
            // 
            this.GitHub_Button.BackColor = System.Drawing.Color.Transparent;
            this.GitHub_Button.BackgroundColor = System.Drawing.Color.Transparent;
            this.GitHub_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GitHub_Button.BackgroundImage")));
            this.GitHub_Button.BorderColor = System.Drawing.Color.Turquoise;
            this.GitHub_Button.BorderRadius = 50;
            this.GitHub_Button.BorderSize = 0;
            this.GitHub_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHub_Button.FlatAppearance.BorderSize = 0;
            this.GitHub_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitHub_Button.ForeColor = System.Drawing.Color.Transparent;
            this.GitHub_Button.Location = new System.Drawing.Point(1117, 300);
            this.GitHub_Button.Name = "GitHub_Button";
            this.GitHub_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GitHub_Button.Size = new System.Drawing.Size(100, 100);
            this.GitHub_Button.TabIndex = 8;
            this.GitHub_Button.TextColor = System.Drawing.Color.Transparent;
            this.GitHub_Button.UseMnemonic = false;
            this.GitHub_Button.UseVisualStyleBackColor = false;
            this.GitHub_Button.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // CifradoCesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.traducirV2);
            this.Controls.Add(this.cifrarV2);
            this.Controls.Add(this.GitHub_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cuadroResultado);
            this.Controls.Add(this.cuadroTexto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CifradoCesar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifrado César por MoyaJoseDev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cuadroTexto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox cuadroResultado;
        private System.Windows.Forms.Label label2;
        private clases.RJButton GitHub_Button;
        private clases.RJButton cifrarV2;
        private clases.RJButton traducirV2;
        private clases.RJButton copyButton;
    }
}

