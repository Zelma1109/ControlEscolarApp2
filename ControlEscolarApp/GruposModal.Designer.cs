namespace ControlEscolarApp
{
    partial class GruposModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GruposModal));
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.dgvUnionGA = new System.Windows.Forms.DataGridView();
            this.dgvUnionGM = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEliminarA = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_guardarA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnionGA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnionGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(74, 85);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(155, 21);
            this.cmbAlumnos.TabIndex = 5;
            this.cmbAlumnos.SelectedIndexChanged += new System.EventHandler(this.cmbAlumnos_SelectedIndexChanged);
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(74, 317);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(155, 21);
            this.cmbMaterias.TabIndex = 6;
            this.cmbMaterias.SelectedIndexChanged += new System.EventHandler(this.cmbMaterias_SelectedIndexChanged);
            // 
            // dgvUnionGA
            // 
            this.dgvUnionGA.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvUnionGA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnionGA.Location = new System.Drawing.Point(250, 22);
            this.dgvUnionGA.Name = "dgvUnionGA";
            this.dgvUnionGA.Size = new System.Drawing.Size(526, 181);
            this.dgvUnionGA.TabIndex = 140;
            this.dgvUnionGA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnionGA_CellClick);
            this.dgvUnionGA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnionGA_CellContentClick);
            // 
            // dgvUnionGM
            // 
            this.dgvUnionGM.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvUnionGM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnionGM.Location = new System.Drawing.Point(250, 235);
            this.dgvUnionGM.Name = "dgvUnionGM";
            this.dgvUnionGM.Size = new System.Drawing.Size(526, 181);
            this.dgvUnionGM.TabIndex = 141;
            this.dgvUnionGM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnionGM_CellClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(98, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 145;
            this.label16.Text = "Eliminar ";
            // 
            // btnEliminarA
            // 
            this.btnEliminarA.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminarA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarA.BackgroundImage")));
            this.btnEliminarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarA.Location = new System.Drawing.Point(101, 122);
            this.btnEliminarA.Name = "btnEliminarA";
            this.btnEliminarA.Size = new System.Drawing.Size(31, 26);
            this.btnEliminarA.TabIndex = 142;
            this.btnEliminarA.UseVisualStyleBackColor = false;
            this.btnEliminarA.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(157, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 144;
            this.label11.Text = "Guardar";
            // 
            // Btn_guardarA
            // 
            this.Btn_guardarA.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_guardarA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_guardarA.BackgroundImage")));
            this.Btn_guardarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guardarA.Location = new System.Drawing.Point(160, 122);
            this.Btn_guardarA.Name = "Btn_guardarA";
            this.Btn_guardarA.Size = new System.Drawing.Size(29, 27);
            this.Btn_guardarA.TabIndex = 143;
            this.Btn_guardarA.UseVisualStyleBackColor = false;
            this.Btn_guardarA.Click += new System.EventHandler(this.Btn_guardarA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(98, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 149;
            this.label1.Text = "Eliminar ";
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminarM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarM.BackgroundImage")));
            this.btnEliminarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarM.Location = new System.Drawing.Point(101, 344);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(31, 26);
            this.btnEliminarM.TabIndex = 146;
            this.btnEliminarM.UseVisualStyleBackColor = false;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(157, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 148;
            this.label2.Text = "Guardar";
            // 
            // btnGuardarM
            // 
            this.btnGuardarM.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardarM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarM.BackgroundImage")));
            this.btnGuardarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarM.Location = new System.Drawing.Point(160, 344);
            this.btnGuardarM.Name = "btnGuardarM";
            this.btnGuardarM.Size = new System.Drawing.Size(29, 27);
            this.btnGuardarM.TabIndex = 147;
            this.btnGuardarM.UseVisualStyleBackColor = false;
            this.btnGuardarM.Click += new System.EventHandler(this.btnGuardarM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(129, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 150;
            this.label3.Text = "ALUMNOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(127, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 151;
            this.label4.Text = "MATERIAS";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(23, 74);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(45, 41);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox10.TabIndex = 152;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 153;
            this.pictureBox1.TabStop = false;
            // 
            // GruposModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarM);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnEliminarA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Btn_guardarA);
            this.Controls.Add(this.dgvUnionGM);
            this.Controls.Add(this.dgvUnionGA);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.cmbAlumnos);
            this.Name = "GruposModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GruposModal";
            this.Load += new System.EventHandler(this.GruposModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnionGA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnionGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlumnos;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.DataGridView dgvUnionGA;
        private System.Windows.Forms.DataGridView dgvUnionGM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnEliminarA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_guardarA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}