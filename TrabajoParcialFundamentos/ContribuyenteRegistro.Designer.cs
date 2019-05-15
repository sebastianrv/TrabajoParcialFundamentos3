namespace TrabajoParcialFundamentos
{
    partial class ContribuyenteRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContribuyenteRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.txboxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txboxDNI = new System.Windows.Forms.TextBox();
            this.cmBoxDomicilio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmBoxMunicipalidad = new System.Windows.Forms.ComboBox();
            this.pctBoxMunicipalidad = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMunicipalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre completo:";
            // 
            // txboxNombre
            // 
            this.txboxNombre.Location = new System.Drawing.Point(251, 322);
            this.txboxNombre.Name = "txboxNombre";
            this.txboxNombre.Size = new System.Drawing.Size(274, 22);
            this.txboxNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domicilio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "D.N.I:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Location = new System.Drawing.Point(231, 567);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(156, 49);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txboxDNI
            // 
            this.txboxDNI.Location = new System.Drawing.Point(251, 415);
            this.txboxDNI.Name = "txboxDNI";
            this.txboxDNI.Size = new System.Drawing.Size(274, 22);
            this.txboxDNI.TabIndex = 9;
            // 
            // cmBoxDomicilio
            // 
            this.cmBoxDomicilio.FormattingEnabled = true;
            this.cmBoxDomicilio.Location = new System.Drawing.Point(251, 370);
            this.cmBoxDomicilio.Name = "cmBoxDomicilio";
            this.cmBoxDomicilio.Size = new System.Drawing.Size(274, 24);
            this.cmBoxDomicilio.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Municipalidad";
            // 
            // cmBoxMunicipalidad
            // 
            this.cmBoxMunicipalidad.FormattingEnabled = true;
            this.cmBoxMunicipalidad.Items.AddRange(new object[] {
            "Chorrillos",
            "Santiago de Surco",
            "San Juan Miraflores",
            "San Isidro"});
            this.cmBoxMunicipalidad.Location = new System.Drawing.Point(288, 51);
            this.cmBoxMunicipalidad.Name = "cmBoxMunicipalidad";
            this.cmBoxMunicipalidad.Size = new System.Drawing.Size(190, 24);
            this.cmBoxMunicipalidad.TabIndex = 16;
            this.cmBoxMunicipalidad.SelectedIndexChanged += new System.EventHandler(this.cmBoxMunicipalidad_SelectedIndexChanged);
            // 
            // pctBoxMunicipalidad
            // 
            this.pctBoxMunicipalidad.Location = new System.Drawing.Point(288, 94);
            this.pctBoxMunicipalidad.Name = "pctBoxMunicipalidad";
            this.pctBoxMunicipalidad.Size = new System.Drawing.Size(190, 162);
            this.pctBoxMunicipalidad.TabIndex = 17;
            this.pctBoxMunicipalidad.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(410, 567);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 49);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ContribuyenteRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 705);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pctBoxMunicipalidad);
            this.Controls.Add(this.cmBoxMunicipalidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmBoxDomicilio);
            this.Controls.Add(this.txboxDNI);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txboxNombre);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContribuyenteRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContribuyenteRegistro";
            this.Load += new System.EventHandler(this.ContribuyenteRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMunicipalidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txboxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmBoxDomicilio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmBoxMunicipalidad;
        private System.Windows.Forms.PictureBox pctBoxMunicipalidad;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.TextBox txboxDNI;
    }
}