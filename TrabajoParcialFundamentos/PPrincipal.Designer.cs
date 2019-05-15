namespace TrabajoParcialFundamentos
{
    partial class PPrincipal
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
            this.pctBoxAdministrador = new System.Windows.Forms.PictureBox();
            this.pctBoxContribuyente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxContribuyente)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBoxAdministrador
            // 
            this.pctBoxAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxAdministrador.BackgroundImage = global::TrabajoParcialFundamentos.Properties.Resources.AdministradorImage;
            this.pctBoxAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxAdministrador.Location = new System.Drawing.Point(45, 194);
            this.pctBoxAdministrador.Name = "pctBoxAdministrador";
            this.pctBoxAdministrador.Size = new System.Drawing.Size(201, 250);
            this.pctBoxAdministrador.TabIndex = 0;
            this.pctBoxAdministrador.TabStop = false;
            this.pctBoxAdministrador.Click += new System.EventHandler(this.pctBoxAdministrador_Click);
            this.pctBoxAdministrador.MouseLeave += new System.EventHandler(this.pctBoxAdministrador_MouseLeave);
            this.pctBoxAdministrador.MouseHover += new System.EventHandler(this.pctBoxAdministrador_MouseHover);
            // 
            // pctBoxContribuyente
            // 
            this.pctBoxContribuyente.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxContribuyente.BackgroundImage = global::TrabajoParcialFundamentos.Properties.Resources.ContribuyenteImagen;
            this.pctBoxContribuyente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBoxContribuyente.Location = new System.Drawing.Point(365, 194);
            this.pctBoxContribuyente.Name = "pctBoxContribuyente";
            this.pctBoxContribuyente.Size = new System.Drawing.Size(201, 250);
            this.pctBoxContribuyente.TabIndex = 1;
            this.pctBoxContribuyente.TabStop = false;
            this.pctBoxContribuyente.Click += new System.EventHandler(this.pctBoxContribuyente_Click);
            this.pctBoxContribuyente.MouseLeave += new System.EventHandler(this.pctBoxContribuyente_MouseLeave);
            this.pctBoxContribuyente.MouseHover += new System.EventHandler(this.pctBoxContribuyente_MouseHover);
            // 
            // PPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoParcialFundamentos.Properties.Resources.Fondo_Principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 705);
            this.Controls.Add(this.pctBoxContribuyente);
            this.Controls.Add(this.pctBoxAdministrador);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPrincipal";
            this.Load += new System.EventHandler(this.PPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxContribuyente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBoxAdministrador;
        private System.Windows.Forms.PictureBox pctBoxContribuyente;
    }
}