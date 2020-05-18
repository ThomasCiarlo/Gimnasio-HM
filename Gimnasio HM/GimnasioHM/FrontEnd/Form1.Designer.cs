namespace FrontEnd
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelBotonera = new System.Windows.Forms.Panel();
            this.lblOpc = new System.Windows.Forms.Label();
            this.PanelPadre = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHeladera = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.PanelBotonera.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBotonera
            // 
            this.PanelBotonera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.PanelBotonera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBotonera.Controls.Add(this.pictureBox1);
            this.PanelBotonera.Controls.Add(this.lblOpc);
            this.PanelBotonera.Controls.Add(this.pictureBox2);
            this.PanelBotonera.Controls.Add(this.btnHeladera);
            this.PanelBotonera.Controls.Add(this.btnMostrar);
            this.PanelBotonera.Controls.Add(this.btnCobrar);
            this.PanelBotonera.Controls.Add(this.btnModificacion);
            this.PanelBotonera.Controls.Add(this.btnAlumnos);
            this.PanelBotonera.Location = new System.Drawing.Point(0, 0);
            this.PanelBotonera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelBotonera.Name = "PanelBotonera";
            this.PanelBotonera.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelBotonera.Size = new System.Drawing.Size(285, 600);
            this.PanelBotonera.TabIndex = 0;
            // 
            // lblOpc
            // 
            this.lblOpc.AutoSize = true;
            this.lblOpc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOpc.Location = new System.Drawing.Point(59, 185);
            this.lblOpc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpc.Name = "lblOpc";
            this.lblOpc.Size = new System.Drawing.Size(103, 25);
            this.lblOpc.TabIndex = 9;
            this.lblOpc.Text = "Opciones";
            // 
            // PanelPadre
            // 
            this.PanelPadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.PanelPadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelPadre.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PanelPadre.Location = new System.Drawing.Point(285, 39);
            this.PanelPadre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(972, 561);
            this.PanelPadre.TabIndex = 1;
            this.PanelPadre.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPadre_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(284, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 39);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(936, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 170);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::FrontEnd.Properties.Resources.Portada;
            this.pictureBox2.Location = new System.Drawing.Point(4, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnHeladera
            // 
            this.btnHeladera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnHeladera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeladera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeladera.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeladera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnHeladera.Image = global::FrontEnd.Properties.Resources.bar_graph1;
            this.btnHeladera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeladera.Location = new System.Drawing.Point(7, 528);
            this.btnHeladera.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeladera.Name = "btnHeladera";
            this.btnHeladera.Size = new System.Drawing.Size(272, 55);
            this.btnHeladera.TabIndex = 6;
            this.btnHeladera.Text = "Heladera";
            this.btnHeladera.UseVisualStyleBackColor = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnMostrar.Image = global::FrontEnd.Properties.Resources.phone_book__1_1;
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(7, 452);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(272, 55);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Listar Alumnos";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCobrar.Image = global::FrontEnd.Properties.Resources.payment1;
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(7, 377);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(272, 55);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnModificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnModificacion.Image = global::FrontEnd.Properties.Resources.person_settings1;
            this.btnModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificacion.Location = new System.Drawing.Point(7, 304);
            this.btnModificacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(272, 55);
            this.btnModificacion.TabIndex = 3;
            this.btnModificacion.Text = "Modificacion";
            this.btnModificacion.UseVisualStyleBackColor = false;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAlumnos.Image = global::FrontEnd.Properties.Resources.user;
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(7, 231);
            this.btnAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(272, 55);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "Alta Alumno";
            this.btnAlumnos.UseVisualStyleBackColor = false;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelPadre);
            this.Controls.Add(this.PanelBotonera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "GimnasioHM";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelBotonera.ResumeLayout(false);
            this.PanelBotonera.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBotonera;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Panel PanelPadre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnHeladera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOpc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

