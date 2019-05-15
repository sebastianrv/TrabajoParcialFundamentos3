namespace TrabajoParcialFundamentos
{
    partial class AdministradorRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorRegistro));
            this.comboBoxDistrito = new System.Windows.Forms.ComboBox();
            this.checkBoxLIndeterminada = new System.Windows.Forms.CheckBox();
            this.checkBoxLTemporal = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDistrito
            // 
            this.comboBoxDistrito.FormattingEnabled = true;
            this.comboBoxDistrito.Items.AddRange(new object[] {
            "Chorrillos",
            "Santiago de Surco",
            "San Juan Miraflores",
            "San Isidro"});
            this.comboBoxDistrito.Location = new System.Drawing.Point(195, 178);
            this.comboBoxDistrito.Name = "comboBoxDistrito";
            this.comboBoxDistrito.Size = new System.Drawing.Size(188, 24);
            this.comboBoxDistrito.TabIndex = 1;
            // 
            // checkBoxLIndeterminada
            // 
            this.checkBoxLIndeterminada.AutoSize = true;
            this.checkBoxLIndeterminada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBoxLIndeterminada.BackgroundImage")));
            this.checkBoxLIndeterminada.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLIndeterminada.ForeColor = System.Drawing.Color.Black;
            this.checkBoxLIndeterminada.Location = new System.Drawing.Point(12, 384);
            this.checkBoxLIndeterminada.Name = "checkBoxLIndeterminada";
            this.checkBoxLIndeterminada.Size = new System.Drawing.Size(426, 24);
            this.checkBoxLIndeterminada.TabIndex = 3;
            this.checkBoxLIndeterminada.Text = "Licencia funcionamiento Indeterminada/Temporal";
            this.checkBoxLIndeterminada.UseVisualStyleBackColor = true;
            // 
            // checkBoxLTemporal
            // 
            this.checkBoxLTemporal.AutoSize = true;
            this.checkBoxLTemporal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBoxLTemporal.BackgroundImage")));
            this.checkBoxLTemporal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLTemporal.ForeColor = System.Drawing.Color.Black;
            this.checkBoxLTemporal.Location = new System.Drawing.Point(12, 464);
            this.checkBoxLTemporal.Name = "checkBoxLTemporal";
            this.checkBoxLTemporal.Size = new System.Drawing.Size(581, 24);
            this.checkBoxLTemporal.TabIndex = 4;
            this.checkBoxLTemporal.Text = "Licencia de funcionamiento para Utilizacion Temporal de la Vía Pública";
            this.checkBoxLTemporal.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(122, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 67);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(122, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(306, 584);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 49);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRegistrar.BackgroundImage")));
            this.buttonRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegistrar.Location = new System.Drawing.Point(122, 584);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(156, 49);
            this.buttonRegistrar.TabIndex = 5;
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // AdministradorRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 705);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.checkBoxLTemporal);
            this.Controls.Add(this.checkBoxLIndeterminada);
            this.Controls.Add(this.comboBoxDistrito);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministradorRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministradorRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxDistrito;
        private System.Windows.Forms.CheckBox checkBoxLIndeterminada;
        private System.Windows.Forms.CheckBox checkBoxLTemporal;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}