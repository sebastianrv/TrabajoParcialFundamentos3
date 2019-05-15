namespace TrabajoParcialFundamentos
{
    partial class OpcionAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionAdministrador));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.pctboxAtras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Location = new System.Drawing.Point(210, 240);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(174, 54);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultas.BackgroundImage")));
            this.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultas.Location = new System.Drawing.Point(210, 420);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(174, 52);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // pctboxAtras
            // 
            this.pctboxAtras.BackColor = System.Drawing.Color.Transparent;
            this.pctboxAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctboxAtras.BackgroundImage")));
            this.pctboxAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctboxAtras.Location = new System.Drawing.Point(12, 618);
            this.pctboxAtras.Name = "pctboxAtras";
            this.pctboxAtras.Size = new System.Drawing.Size(114, 75);
            this.pctboxAtras.TabIndex = 2;
            this.pctboxAtras.TabStop = false;
            this.pctboxAtras.Click += new System.EventHandler(this.pctboxAtras_Click);
            // 
            // OpcionAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TrabajoParcialFundamentos.Properties.Resources.fondo_Opciones;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 705);
            this.Controls.Add(this.pctboxAtras);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnRegistrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpcionAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpcionAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.pctboxAtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.PictureBox pctboxAtras;
    }
}