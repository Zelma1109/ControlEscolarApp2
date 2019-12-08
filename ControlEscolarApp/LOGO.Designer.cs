namespace ControlEscolarApp
{
    partial class LOGO
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
            this.btnEliminarLago = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCancelara = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarLago
            // 
            this.btnEliminarLago.Location = new System.Drawing.Point(341, 203);
            this.btnEliminarLago.Name = "btnEliminarLago";
            this.btnEliminarLago.Size = new System.Drawing.Size(52, 23);
            this.btnEliminarLago.TabIndex = 19;
            this.btnEliminarLago.Text = "X";
            this.btnEliminarLago.UseVisualStyleBackColor = true;
            this.btnEliminarLago.Click += new System.EventHandler(this.btnEliminarLago_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(260, 203);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(59, 23);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = ". . .";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCancelara
            // 
            this.btnCancelara.Location = new System.Drawing.Point(142, 194);
            this.btnCancelara.Name = "btnCancelara";
            this.btnCancelara.Size = new System.Drawing.Size(75, 23);
            this.btnCancelara.TabIndex = 17;
            this.btnCancelara.Text = "CANCELAR";
            this.btnCancelara.UseVisualStyleBackColor = true;
            this.btnCancelara.Click += new System.EventHandler(this.btnCancelara_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(75, 165);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(23, 125);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogo.Location = new System.Drawing.Point(243, 27);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(161, 161);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 14;
            this.picLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "DIRECTOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "NOMBRE";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(23, 90);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(169, 20);
            this.txtDirector.TabIndex = 11;
            this.txtDirector.TextChanged += new System.EventHandler(this.txtDirector_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(23, 42);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(169, 20);
            this.TxtNombre.TabIndex = 10;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // LOGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 257);
            this.Controls.Add(this.btnEliminarLago);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnCancelara);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.TxtNombre);
            this.Name = "LOGO";
            this.Text = "LOGO PRUEBA";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarLago;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCancelara;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}