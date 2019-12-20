namespace PuntoDeVenta
{
    partial class F_Agregar_Cliente
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Btn_Salir = new System.Windows.Forms.PictureBox();
            this.Tb_Direccion = new System.Windows.Forms.TextBox();
            this.Tb_Telefono = new System.Windows.Forms.TextBox();
            this.Tb_RFC = new System.Windows.Forms.TextBox();
            this.Lb_Id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.Btn_Salir);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 45);
            this.TopPanel.TabIndex = 244;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir.Image = global::PuntoDeVenta.Properties.Resources.Close_Window_Black;
            this.Btn_Salir.Location = new System.Drawing.Point(767, 12);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(20, 20);
            this.Btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Salir.TabIndex = 186;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Tb_Direccion
            // 
            this.Tb_Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Direccion.Location = new System.Drawing.Point(189, 233);
            this.Tb_Direccion.MaxLength = 6;
            this.Tb_Direccion.Name = "Tb_Direccion";
            this.Tb_Direccion.Size = new System.Drawing.Size(359, 20);
            this.Tb_Direccion.TabIndex = 259;
            // 
            // Tb_Telefono
            // 
            this.Tb_Telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Telefono.Location = new System.Drawing.Point(189, 206);
            this.Tb_Telefono.MaxLength = 15;
            this.Tb_Telefono.Name = "Tb_Telefono";
            this.Tb_Telefono.Size = new System.Drawing.Size(359, 20);
            this.Tb_Telefono.TabIndex = 258;
            // 
            // Tb_RFC
            // 
            this.Tb_RFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_RFC.Location = new System.Drawing.Point(189, 179);
            this.Tb_RFC.MaxLength = 50;
            this.Tb_RFC.Name = "Tb_RFC";
            this.Tb_RFC.Size = new System.Drawing.Size(359, 20);
            this.Tb_RFC.TabIndex = 257;
            // 
            // Lb_Id
            // 
            this.Lb_Id.AutoSize = true;
            this.Lb_Id.Location = new System.Drawing.Point(24, 86);
            this.Lb_Id.Name = "Lb_Id";
            this.Lb_Id.Size = new System.Drawing.Size(54, 13);
            this.Lb_Id.TabIndex = 256;
            this.Lb_Id.Text = "Id_Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuntoDeVenta.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(604, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 255;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancelar.BorderRadius = 0;
            this.Btn_Cancelar.ButtonText = "CANCELAR";
            this.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancelar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Cancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Cancelar.Iconimage = null;
            this.Btn_Cancelar.Iconimage_right = null;
            this.Btn_Cancelar.Iconimage_right_Selected = null;
            this.Btn_Cancelar.Iconimage_Selected = null;
            this.Btn_Cancelar.IconMarginLeft = 0;
            this.Btn_Cancelar.IconMarginRight = 0;
            this.Btn_Cancelar.IconRightVisible = true;
            this.Btn_Cancelar.IconRightZoom = 0D;
            this.Btn_Cancelar.IconVisible = true;
            this.Btn_Cancelar.IconZoom = 90D;
            this.Btn_Cancelar.IsTab = false;
            this.Btn_Cancelar.Location = new System.Drawing.Point(633, 380);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Cancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Cancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cancelar.selected = false;
            this.Btn_Cancelar.Size = new System.Drawing.Size(135, 48);
            this.Btn_Cancelar.TabIndex = 254;
            this.Btn_Cancelar.TabStop = false;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cancelar.Textcolor = System.Drawing.Color.White;
            this.Btn_Cancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guardar.BorderRadius = 0;
            this.Btn_Guardar.ButtonText = "GUARDAR";
            this.Btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Guardar.Iconimage = null;
            this.Btn_Guardar.Iconimage_right = null;
            this.Btn_Guardar.Iconimage_right_Selected = null;
            this.Btn_Guardar.Iconimage_Selected = null;
            this.Btn_Guardar.IconMarginLeft = 0;
            this.Btn_Guardar.IconMarginRight = 0;
            this.Btn_Guardar.IconRightVisible = true;
            this.Btn_Guardar.IconRightZoom = 0D;
            this.Btn_Guardar.IconVisible = true;
            this.Btn_Guardar.IconZoom = 90D;
            this.Btn_Guardar.IsTab = false;
            this.Btn_Guardar.Location = new System.Drawing.Point(466, 380);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Guardar.selected = false;
            this.Btn_Guardar.Size = new System.Drawing.Size(135, 48);
            this.Btn_Guardar.TabIndex = 253;
            this.Btn_Guardar.TabStop = false;
            this.Btn_Guardar.Text = "GUARDAR";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Guardar.Textcolor = System.Drawing.Color.White;
            this.Btn_Guardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 251;
            this.label2.Text = "RFC";
            // 
            // Tb_Nombre
            // 
            this.Tb_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Nombre.Location = new System.Drawing.Point(189, 153);
            this.Tb_Nombre.MaxLength = 15;
            this.Tb_Nombre.Name = "Tb_Nombre";
            this.Tb_Nombre.Size = new System.Drawing.Size(359, 20);
            this.Tb_Nombre.TabIndex = 248;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 249;
            this.label8.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 250;
            this.label6.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 252;
            this.label1.Text = "Nombre";
            // 
            // F_Agregar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tb_Direccion);
            this.Controls.Add(this.Tb_Telefono);
            this.Controls.Add(this.Tb_RFC);
            this.Controls.Add(this.Lb_Id);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_Nombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Agregar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Agregar_Cliente";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox Btn_Salir;
        public System.Windows.Forms.TextBox Tb_Direccion;
        public System.Windows.Forms.TextBox Tb_Telefono;
        public System.Windows.Forms.TextBox Tb_RFC;
        public System.Windows.Forms.Label Lb_Id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cancelar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Guardar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Tb_Nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}