namespace EjercicioArchivos
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
            this.bIniciar = new System.Windows.Forms.Button();
            this.bLeer = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bVer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(12, 12);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(75, 23);
            this.bIniciar.TabIndex = 0;
            this.bIniciar.Text = "Iniciar";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // bLeer
            // 
            this.bLeer.Location = new System.Drawing.Point(12, 41);
            this.bLeer.Name = "bLeer";
            this.bLeer.Size = new System.Drawing.Size(97, 35);
            this.bLeer.TabIndex = 1;
            this.bLeer.Text = "Leer Archvio";
            this.bLeer.UseVisualStyleBackColor = true;
            this.bLeer.Click += new System.EventHandler(this.bLeer_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(115, 41);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(90, 35);
            this.bGuardar.TabIndex = 2;
            this.bGuardar.Text = "guardar Informe";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(211, 41);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(101, 35);
            this.bVer.TabIndex = 3;
            this.bVer.Text = "Ver";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 95);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bLeer);
            this.Controls.Add(this.bIniciar);
            this.Name = "Form1";
            this.Text = "0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Button bLeer;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

