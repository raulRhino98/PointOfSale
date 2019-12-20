namespace PuntoDeVenta
{
    partial class F_Detalles_Venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Lb_Venta = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.PictureBox();
            this.Btn_Agregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Lb_Id_Venta = new System.Windows.Forms.Label();
            this.Dgv_Ventas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_Producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Cantidad = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.Lb_Venta);
            this.TopPanel.Controls.Add(this.Btn_Salir);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 45);
            this.TopPanel.TabIndex = 246;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown_1);
            // 
            // Lb_Venta
            // 
            this.Lb_Venta.AutoSize = true;
            this.Lb_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Venta.Location = new System.Drawing.Point(290, 12);
            this.Lb_Venta.Name = "Lb_Venta";
            this.Lb_Venta.Size = new System.Drawing.Size(174, 20);
            this.Lb_Venta.TabIndex = 269;
            this.Lb_Venta.Text = "Productos en venta: ";
            this.Lb_Venta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lb_Venta_MouseDown);
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
            // Btn_Agregar
            // 
            this.Btn_Agregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Agregar.BorderRadius = 0;
            this.Btn_Agregar.ButtonText = "AGREGAR";
            this.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Agregar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Agregar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Agregar.Iconimage = null;
            this.Btn_Agregar.Iconimage_right = null;
            this.Btn_Agregar.Iconimage_right_Selected = null;
            this.Btn_Agregar.Iconimage_Selected = null;
            this.Btn_Agregar.IconMarginLeft = 0;
            this.Btn_Agregar.IconMarginRight = 0;
            this.Btn_Agregar.IconRightVisible = true;
            this.Btn_Agregar.IconRightZoom = 0D;
            this.Btn_Agregar.IconVisible = true;
            this.Btn_Agregar.IconZoom = 90D;
            this.Btn_Agregar.IsTab = false;
            this.Btn_Agregar.Location = new System.Drawing.Point(652, 390);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Agregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Agregar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Agregar.selected = false;
            this.Btn_Agregar.Size = new System.Drawing.Size(135, 48);
            this.Btn_Agregar.TabIndex = 267;
            this.Btn_Agregar.TabStop = false;
            this.Btn_Agregar.Text = "AGREGAR";
            this.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Agregar.Textcolor = System.Drawing.Color.White;
            this.Btn_Agregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Eliminar.BorderRadius = 0;
            this.Btn_Eliminar.ButtonText = "ELIMINAR";
            this.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Eliminar.Iconimage = null;
            this.Btn_Eliminar.Iconimage_right = null;
            this.Btn_Eliminar.Iconimage_right_Selected = null;
            this.Btn_Eliminar.Iconimage_Selected = null;
            this.Btn_Eliminar.IconMarginLeft = 0;
            this.Btn_Eliminar.IconMarginRight = 0;
            this.Btn_Eliminar.IconRightVisible = true;
            this.Btn_Eliminar.IconRightZoom = 0D;
            this.Btn_Eliminar.IconVisible = true;
            this.Btn_Eliminar.IconZoom = 90D;
            this.Btn_Eliminar.IsTab = false;
            this.Btn_Eliminar.Location = new System.Drawing.Point(12, 390);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Eliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Eliminar.selected = false;
            this.Btn_Eliminar.Size = new System.Drawing.Size(135, 48);
            this.Btn_Eliminar.TabIndex = 268;
            this.Btn_Eliminar.TabStop = false;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Eliminar.Textcolor = System.Drawing.Color.White;
            this.Btn_Eliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Lb_Id_Venta
            // 
            this.Lb_Id_Venta.AutoSize = true;
            this.Lb_Id_Venta.Location = new System.Drawing.Point(401, 52);
            this.Lb_Id_Venta.Name = "Lb_Id_Venta";
            this.Lb_Id_Venta.Size = new System.Drawing.Size(35, 13);
            this.Lb_Id_Venta.TabIndex = 270;
            this.Lb_Id_Venta.Text = "label3";
            // 
            // Dgv_Ventas
            // 
            this.Dgv_Ventas.AllowUserToAddRows = false;
            this.Dgv_Ventas.AllowUserToDeleteRows = false;
            this.Dgv_Ventas.AllowUserToResizeColumns = false;
            this.Dgv_Ventas.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_Ventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Dgv_Ventas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dgv_Ventas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgv_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgv_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Ventas.DefaultCellStyle = dataGridViewCellStyle13;
            this.Dgv_Ventas.DoubleBuffered = true;
            this.Dgv_Ventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_Ventas.EnableHeadersVisualStyles = false;
            this.Dgv_Ventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Dgv_Ventas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Dgv_Ventas.HeaderForeColor = System.Drawing.Color.Black;
            this.Dgv_Ventas.Location = new System.Drawing.Point(40, 108);
            this.Dgv_Ventas.MultiSelect = false;
            this.Dgv_Ventas.Name = "Dgv_Ventas";
            this.Dgv_Ventas.ReadOnly = true;
            this.Dgv_Ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Ventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Dgv_Ventas.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Dgv_Ventas.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.Dgv_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Ventas.ShowCellErrors = false;
            this.Dgv_Ventas.ShowCellToolTips = false;
            this.Dgv_Ventas.ShowEditingIcon = false;
            this.Dgv_Ventas.ShowRowErrors = false;
            this.Dgv_Ventas.Size = new System.Drawing.Size(572, 266);
            this.Dgv_Ventas.TabIndex = 271;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(89, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 274;
            this.label3.Text = "Producto";
            // 
            // Cb_Producto
            // 
            this.Cb_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Producto.FormattingEnabled = true;
            this.Cb_Producto.Location = new System.Drawing.Point(93, 71);
            this.Cb_Producto.Name = "Cb_Producto";
            this.Cb_Producto.Size = new System.Drawing.Size(121, 21);
            this.Cb_Producto.TabIndex = 275;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(249, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 276;
            this.label1.Text = "Cantidad";
            // 
            // Tb_Cantidad
            // 
            this.Tb_Cantidad.Location = new System.Drawing.Point(253, 71);
            this.Tb_Cantidad.Name = "Tb_Cantidad";
            this.Tb_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.Tb_Cantidad.TabIndex = 277;
            this.Tb_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Cantidad_KeyPress);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(618, 108);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(59, 20);
            this.Total.TabIndex = 279;
            this.Total.Text = "Total: ";
            // 
            // F_Detalles_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Tb_Cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_Producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dgv_Ventas);
            this.Controls.Add(this.Lb_Id_Venta);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Detalles_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Detalles_Venta";
            this.Load += new System.EventHandler(this.F_Detalles_Venta_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox Btn_Salir;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Agregar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Eliminar;
        public System.Windows.Forms.Label Lb_Venta;
        public System.Windows.Forms.Label Lb_Id_Venta;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Dgv_Ventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Cantidad;
        private System.Windows.Forms.Label Total;
    }
}