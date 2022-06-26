namespace Word_Pantalla_Principal
{
    partial class frmListaNiveles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaNiveles));
            this.btnBasico = new System.Windows.Forms.Button();
            this.btnMedio = new System.Windows.Forms.Button();
            this.btnAvanzado = new System.Windows.Forms.Button();
            this.pbSalida = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.CuadroPie = new System.Windows.Forms.FlowLayoutPanel();
            this.CuadroEncabezado = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CuadroEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBasico
            // 
            this.btnBasico.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBasico.Location = new System.Drawing.Point(70, 123);
            this.btnBasico.Name = "btnBasico";
            this.btnBasico.Size = new System.Drawing.Size(95, 87);
            this.btnBasico.TabIndex = 0;
            this.btnBasico.Text = "Básico";
            this.btnBasico.UseVisualStyleBackColor = false;
            this.btnBasico.Click += new System.EventHandler(this.btnBasico_Click);
            // 
            // btnMedio
            // 
            this.btnMedio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMedio.Location = new System.Drawing.Point(217, 123);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(95, 87);
            this.btnMedio.TabIndex = 1;
            this.btnMedio.Text = "Medio";
            this.btnMedio.UseVisualStyleBackColor = false;
            this.btnMedio.Click += new System.EventHandler(this.btnMedio_Click);
            // 
            // btnAvanzado
            // 
            this.btnAvanzado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAvanzado.Location = new System.Drawing.Point(365, 123);
            this.btnAvanzado.Name = "btnAvanzado";
            this.btnAvanzado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAvanzado.Size = new System.Drawing.Size(95, 87);
            this.btnAvanzado.TabIndex = 2;
            this.btnAvanzado.Text = "Avanzado";
            this.btnAvanzado.UseVisualStyleBackColor = false;
            this.btnAvanzado.Click += new System.EventHandler(this.btnAvanzado_Click);
            // 
            // pbSalida
            // 
            this.pbSalida.Image = global::Word_Pantalla_Principal.Properties.Resources.icons8_galón_izquierdo_30;
            this.pbSalida.Location = new System.Drawing.Point(3, 3);
            this.pbSalida.Name = "pbSalida";
            this.pbSalida.Size = new System.Drawing.Size(28, 24);
            this.pbSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalida.TabIndex = 6;
            this.pbSalida.TabStop = false;
            this.pbSalida.Click += new System.EventHandler(this.pbSalida_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Word_Pantalla_Principal.Properties.Resources.casa;
            this.pictureBox2.Location = new System.Drawing.Point(475, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Word_Pantalla_Principal.Properties.Resources.ajuste;
            this.pictureBox1.Location = new System.Drawing.Point(511, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(204, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(97, 18);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Uso de Word";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(71, 62);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(389, 39);
            this.lblTexto.TabIndex = 10;
            this.lblTexto.Text = resources.GetString("lblTexto.Text");
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTexto.Click += new System.EventHandler(this.label2_Click);
            // 
            // CuadroPie
            // 
            this.CuadroPie.BackColor = System.Drawing.SystemColors.Highlight;
            this.CuadroPie.Location = new System.Drawing.Point(377, 305);
            this.CuadroPie.Name = "CuadroPie";
            this.CuadroPie.Size = new System.Drawing.Size(178, 37);
            this.CuadroPie.TabIndex = 11;
            // 
            // CuadroEncabezado
            // 
            this.CuadroEncabezado.BackColor = System.Drawing.SystemColors.Highlight;
            this.CuadroEncabezado.Controls.Add(this.pbSalida);
            this.CuadroEncabezado.Location = new System.Drawing.Point(1, -1);
            this.CuadroEncabezado.Name = "CuadroEncabezado";
            this.CuadroEncabezado.Size = new System.Drawing.Size(178, 37);
            this.CuadroEncabezado.TabIndex = 12;
            // 
            // frmListaNiveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(545, 339);
            this.Controls.Add(this.CuadroPie);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAvanzado);
            this.Controls.Add(this.btnMedio);
            this.Controls.Add(this.btnBasico);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.CuadroEncabezado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaNiveles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CuadroEncabezado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasico;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button btnAvanzado;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbSalida;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.FlowLayoutPanel CuadroPie;
        private System.Windows.Forms.FlowLayoutPanel CuadroEncabezado;
    }
}

