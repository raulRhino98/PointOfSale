namespace PuntoDeVenta
{
    partial class F_Home
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Home));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.TopMenu = new System.Windows.Forms.Panel();
            this.Btn_Restaurar = new System.Windows.Forms.PictureBox();
            this.Btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.Btn_Maximizar = new System.Windows.Forms.PictureBox();
            this.Btn_Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Btn_Ganancias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Proveedores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Compras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Ventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Productos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Wrapper = new System.Windows.Forms.Panel();
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TopMenu.Controls.Add(this.Btn_Restaurar);
            this.TopMenu.Controls.Add(this.Btn_Minimizar);
            this.TopMenu.Controls.Add(this.Btn_Maximizar);
            this.TopMenu.Controls.Add(this.Btn_Salir);
            this.TopMenu.Controls.Add(this.label1);
            this.TopMenu.Controls.Add(this.MenuSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.TopMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.TopMenu, BunifuAnimatorNS.DecorationType.None);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1386, 80);
            this.TopMenu.TabIndex = 0;
            // 
            // Btn_Restaurar
            // 
            this.Btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Btn_Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Btn_Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Restaurar.Image = global::PuntoDeVenta.Properties.Resources.Maximizar;
            this.Btn_Restaurar.Location = new System.Drawing.Point(1308, 24);
            this.Btn_Restaurar.Name = "Btn_Restaurar";
            this.Btn_Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Restaurar.TabIndex = 9;
            this.Btn_Restaurar.TabStop = false;
            this.Btn_Restaurar.Visible = false;
            this.Btn_Restaurar.Click += new System.EventHandler(this.Btn_Restaurar_Click);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Btn_Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Btn_Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Minimizar.Image = global::PuntoDeVenta.Properties.Resources.Minimizar1;
            this.Btn_Minimizar.Location = new System.Drawing.Point(1272, 24);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Minimizar.TabIndex = 8;
            this.Btn_Minimizar.TabStop = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_Maximizar
            // 
            this.Btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Btn_Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Btn_Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Maximizar.Image = global::PuntoDeVenta.Properties.Resources.Maximizar;
            this.Btn_Maximizar.Location = new System.Drawing.Point(1308, 24);
            this.Btn_Maximizar.Name = "Btn_Maximizar";
            this.Btn_Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Maximizar.TabIndex = 7;
            this.Btn_Maximizar.TabStop = false;
            this.Btn_Maximizar.Click += new System.EventHandler(this.Btn_Maximizar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Btn_Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Btn_Salir, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Salir.Image = global::PuntoDeVenta.Properties.Resources.Cerrar;
            this.Btn_Salir.Location = new System.Drawing.Point(1344, 24);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(30, 30);
            this.Btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ESCRITORIO";
            // 
            // MenuSidebar
            // 
            this.MenuSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(34, 24);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 1;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 80);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 708);
            this.SidebarWrapper.TabIndex = 10;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.Btn_Ganancias);
            this.Sidebar.Controls.Add(this.Btn_Proveedores);
            this.Sidebar.Controls.Add(this.Btn_Clientes);
            this.Sidebar.Controls.Add(this.Btn_Compras);
            this.Sidebar.Controls.Add(this.Btn_Ventas);
            this.Sidebar.Controls.Add(this.Btn_Productos);
            this.Sidebar.Controls.Add(this.bunifuFlatButton1);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.Sidebar.Location = new System.Drawing.Point(15, 18);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 672);
            this.Sidebar.TabIndex = 1;
            // 
            // Btn_Ganancias
            // 
            this.Btn_Ganancias.Activecolor = System.Drawing.Color.DimGray;
            this.Btn_Ganancias.AutoSize = true;
            this.Btn_Ganancias.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Ganancias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ganancias.BorderRadius = 0;
            this.Btn_Ganancias.ButtonText = "            GANANCIAS";
            this.Btn_Ganancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Btn_Ganancias, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Btn_Ganancias, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Ganancias.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Ganancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ganancias.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Ganancias.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Ganancias.Iconimage")));
            this.Btn_Ganancias.Iconimage_right = null;
            this.Btn_Ganancias.Iconimage_right_Selected = null;
            this.Btn_Ganancias.Iconimage_Selected = null;
            this.Btn_Ganancias.IconMarginLeft = 0;
            this.Btn_Ganancias.IconMarginRight = 0;
            this.Btn_Ganancias.IconRightVisible = true;
            this.Btn_Ganancias.IconRightZoom = 0D;
            this.Btn_Ganancias.IconVisible = true;
            this.Btn_Ganancias.IconZoom = 50D;
            this.Btn_Ganancias.IsTab = false;
            this.Btn_Ganancias.Location = new System.Drawing.Point(0, 543);
            this.Btn_Ganancias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Ganancias.Name = "Btn_Ganancias";
            this.Btn_Ganancias.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_Ganancias.OnHovercolor = System.Drawing.Color.Black;
            this.Btn_Ganancias.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Ganancias.selected = false;
            this.Btn_Ganancias.Size = new System.Drawing.Size(270, 76);
            this.Btn_Ganancias.TabIndex = 14;
            this.Btn_Ganancias.Text = "            GANANCIAS";
            this.Btn_Ganancias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ganancias.Textcolor = System.Drawing.Color.LightGray;
            this.Btn_Ganancias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Proveedores
            // 
            this.Btn_Proveedores.Activecolor = System.Drawing.Color.DimGray;
            this.Btn_Proveedores.AutoSize = true;
            this.Btn_Proveedores.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Proveedores.BorderRadius = 0;
            this.Btn_Proveedores.ButtonText = "            PROVEEDORES";
            this.Btn_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Btn_Proveedores, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Btn_Proveedores, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Proveedores.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Proveedores.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Proveedores.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Proveedores.Iconimage")));
            this.Btn_Proveedores.Iconimage_right = null;
            this.Btn_Proveedores.Iconimage_right_Selected = null;
            this.Btn_Proveedores.Iconimage_Selected = null;
            this.Btn_Proveedores.IconMarginLeft = 0;
            this.Btn_Proveedores.IconMarginRight = 0;
            this.Btn_Proveedores.IconRightVisible = true;
            this.Btn_Proveedores.IconRightZoom = 0D;
            this.Btn_Proveedores.IconVisible = true;
            this.Btn_Proveedores.IconZoom = 50D;
            this.Btn_Proveedores.IsTab = false;
            this.Btn_Proveedores.Location = new System.Drawing.Point(0, 464);
            this.Btn_Proveedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Proveedores.Name = "Btn_Proveedores";
            this.Btn_Proveedores.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_Proveedores.OnHovercolor = System.Drawing.Color.Black;
            this.Btn_Proveedores.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Proveedores.selected = false;
            this.Btn_Proveedores.Size = new System.Drawing.Size(270, 76);
            this.Btn_Proveedores.TabIndex = 13;
            this.Btn_Proveedores.Text = "            PROVEEDORES";
            this.Btn_Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Proveedores.Textcolor = System.Drawing.Color.LightGray;
            this.Btn_Proveedores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Proveedores.Click += new System.EventHandler(this.Btn_Proveedores_Click);
            // 
            // Btn_Clientes
            // 
            this.Btn_Clientes.Activecolor = System.Drawing.Color.DimGray;
            this.Btn_Clientes.AutoSize = true;
            this.Btn_Clientes.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Clientes.BorderRadius = 0;
            this.Btn_Clientes.ButtonText = "            CLIENTES";
            this.Btn_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Btn_Clientes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Btn_Clientes, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Clientes.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Clientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Clientes.Iconimage")));
            this.Btn_Clientes.Iconimage_right = null;
            this.Btn_Clientes.Iconimage_right_Selected = null;
            this.Btn_Clientes.Iconimage_Selected = null;
            this.Btn_Clientes.IconMarginLeft = 0;
            this.Btn_Clientes.IconMarginRight = 0;
            this.Btn_Clientes.IconRightVisible = true;
            this.Btn_Clientes.IconRightZoom = 0D;
            this.Btn_Clientes.IconVisible = true;
            this.Btn_Clientes.IconZoom = 50D;
            this.Btn_Clientes.IsTab = false;
            this.Btn_Clientes.Location = new System.Drawing.Point(0, 385);
            this.Btn_Clientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Clientes.Name = "Btn_Clientes";
            this.Btn_Clientes.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_Clientes.OnHovercolor = System.Drawing.Color.Black;
            this.Btn_Clientes.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Clientes.selected = false;
            this.Btn_Clientes.Size = new System.Drawing.Size(270, 76);
            this.Btn_Clientes.TabIndex = 12;
            this.Btn_Clientes.Text = "            CLIENTES";
            this.Btn_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Clientes.Textcolor = System.Drawing.Color.LightGray;
            this.Btn_Clientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clientes.Click += new System.EventHandler(this.Btn_Clientes_Click);
            // 
            // Btn_Compras
            // 
            this.Btn_Compras.Activecolor = System.Drawing.Color.DimGray;
            this.Btn_Compras.AutoSize = true;
            this.Btn_Compras.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Compras.BorderRadius = 0;
            this.Btn_Compras.ButtonText = "            COMPRAS";
            this.Btn_Compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Btn_Compras, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Btn_Compras, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Compras.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Compras.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Compras.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Compras.Iconimage")));
            this.Btn_Compras.Iconimage_right = null;
            this.Btn_Compras.Iconimage_right_Selected = null;
            this.Btn_Compras.Iconimage_Selected = null;
            this.Btn_Compras.IconMarginLeft = 0;
            this.Btn_Compras.IconMarginRight = 0;
            this.Btn_Compras.IconRightVisible = true;
            this.Btn_Compras.IconRightZoom = 0D;
            this.Btn_Compras.IconVisible = true;
            this.Btn_Compras.IconZoom = 50D;
            this.Btn_Compras.IsTab = false;
            this.Btn_Compras.Location = new System.Drawing.Point(0, 306);
            this.Btn_Compras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Compras.Name = "Btn_Compras";
            this.Btn_Compras.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_Compras.OnHovercolor = System.Drawing.Color.Black;
            this.Btn_Compras.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Compras.selected = false;
            this.Btn_Compras.Size = new System.Drawing.Size(270, 76);
            this.Btn_Compras.TabIndex = 11;
            this.Btn_Compras.Text = "            COMPRAS";
            this.Btn_Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Compras.Textcolor = System.Drawing.Color.LightGray;
            this.Btn_Compras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Compras.Click += new System.EventHandler(this.Btn_Compras_Click);
            // 
            // Btn_Ventas
            // 
            this.Btn_Ventas.Activecolor = System.Drawing.Color.DimGray;
            this.Btn_Ventas.AutoSize = true;
            this.Btn_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ventas.BorderRadius = 0;
            this.Btn_Ventas.ButtonText = "            VENTAS";
            this.Btn_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Btn_Ventas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Btn_Ventas, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Ventas.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ventas.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Ventas.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Ventas.Iconimage")));
            this.Btn_Ventas.Iconimage_right = null;
            this.Btn_Ventas.Iconimage_right_Selected = null;
            this.Btn_Ventas.Iconimage_Selected = null;
            this.Btn_Ventas.IconMarginLeft = 0;
            this.Btn_Ventas.IconMarginRight = 0;
            this.Btn_Ventas.IconRightVisible = true;
            this.Btn_Ventas.IconRightZoom = 0D;
            this.Btn_Ventas.IconVisible = true;
            this.Btn_Ventas.IconZoom = 50D;
            this.Btn_Ventas.IsTab = false;
            this.Btn_Ventas.Location = new System.Drawing.Point(0, 230);
            this.Btn_Ventas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Ventas.Name = "Btn_Ventas";
            this.Btn_Ventas.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_Ventas.OnHovercolor = System.Drawing.Color.Black;
            this.Btn_Ventas.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Ventas.selected = false;
            this.Btn_Ventas.Size = new System.Drawing.Size(270, 73);
            this.Btn_Ventas.TabIndex = 10;
            this.Btn_Ventas.Text = "            VENTAS";
            this.Btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ventas.Textcolor = System.Drawing.Color.LightGray;
            this.Btn_Ventas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ventas.Click += new System.EventHandler(this.Btn_Ventas_Click);
            // 
            // Btn_Productos
            // 
            this.Btn_Productos.Activecolor = System.Drawing.Color.DimGray;
            this.Btn_Productos.AutoSize = true;
            this.Btn_Productos.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Productos.BorderRadius = 0;
            this.Btn_Productos.ButtonText = "            PRODUCTOS";
            this.Btn_Productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.Btn_Productos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Btn_Productos, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Productos.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Productos.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Productos.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Productos.Iconimage")));
            this.Btn_Productos.Iconimage_right = null;
            this.Btn_Productos.Iconimage_right_Selected = null;
            this.Btn_Productos.Iconimage_Selected = null;
            this.Btn_Productos.IconMarginLeft = 0;
            this.Btn_Productos.IconMarginRight = 0;
            this.Btn_Productos.IconRightVisible = true;
            this.Btn_Productos.IconRightZoom = 0D;
            this.Btn_Productos.IconVisible = true;
            this.Btn_Productos.IconZoom = 50D;
            this.Btn_Productos.IsTab = false;
            this.Btn_Productos.Location = new System.Drawing.Point(0, 153);
            this.Btn_Productos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Productos.Name = "Btn_Productos";
            this.Btn_Productos.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_Productos.OnHovercolor = System.Drawing.Color.Black;
            this.Btn_Productos.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Productos.selected = false;
            this.Btn_Productos.Size = new System.Drawing.Size(270, 73);
            this.Btn_Productos.TabIndex = 9;
            this.Btn_Productos.Text = "            PRODUCTOS";
            this.Btn_Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Productos.Textcolor = System.Drawing.Color.LightGray;
            this.Btn_Productos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Productos.Click += new System.EventHandler(this.Btn_Productos_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.AutoSize = true;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "            EMPLEADOS";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::PuntoDeVenta.Properties.Resources.Empleado;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 77);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(270, 73);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "            EMPLEADOS";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "50 INDUSTRIAL";
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.AnimacionSidebar.DefaultAnimation = animation1;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Wrapper.BackgroundImage = global::PuntoDeVenta.Properties.Resources.logo__2_;
            this.Wrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1086, 708);
            this.Wrapper.TabIndex = 11;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation2;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.TopMenu;
            this.MoverDashboard.Vertical = true;
            // 
            // F_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.TopMenu);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_Home_Load);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.PictureBox Btn_Restaurar;
        private System.Windows.Forms.PictureBox Btn_Minimizar;
        private System.Windows.Forms.PictureBox Btn_Maximizar;
        private System.Windows.Forms.PictureBox Btn_Salir;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Ganancias;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Proveedores;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Clientes;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Compras;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Ventas;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Productos;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
    }
}

