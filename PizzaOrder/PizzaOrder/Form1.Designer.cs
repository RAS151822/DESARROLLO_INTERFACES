namespace PizzaOrder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.largePizza = new System.Windows.Forms.RadioButton();
            this.companyLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.sizeOptions = new System.Windows.Forms.GroupBox();
            this.smallPizza = new System.Windows.Forms.RadioButton();
            this.customerName = new System.Windows.Forms.TextBox();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.toppings = new System.Windows.Forms.CheckedListBox();
            this.orden = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.sizeOptions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.AccessibleDescription = "Porción de pizza";
            this.Logo.AccessibleName = "Logotipo de la compañía";
            this.Logo.Image = global::PizzaOrder.Properties.Resources.pizzalogo;
            this.Logo.Location = new System.Drawing.Point(54, 44);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(137, 119);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // largePizza
            // 
            this.largePizza.AccessibleDescription = "Pizza grande";
            this.largePizza.AccessibleName = "Pizza grande";
            this.largePizza.AutoSize = true;
            this.largePizza.Location = new System.Drawing.Point(35, 63);
            this.largePizza.Name = "largePizza";
            this.largePizza.Size = new System.Drawing.Size(102, 20);
            this.largePizza.TabIndex = 1;
            this.largePizza.TabStop = true;
            this.largePizza.Text = "&Large $10.00";
            this.largePizza.UseVisualStyleBackColor = true;
            // 
            // companyLabel
            // 
            this.companyLabel.AccessibleDescription = "Nombre de la compañía";
            this.companyLabel.AccessibleName = "Nombre de la compañía";
            this.companyLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.Yellow;
            this.companyLabel.Location = new System.Drawing.Point(251, 70);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(282, 43);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Good Pizza";
            this.companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerLabel
            // 
            this.customerLabel.AccessibleDescription = "Etiqueta de nombre de cliente";
            this.customerLabel.AccessibleName = "Etiqueta de nombre de cliente";
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(314, 159);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(57, 16);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "&Nombre";
            // 
            // sizeOptions
            // 
            this.sizeOptions.AccessibleDescription = "Opciones de tamaño de pizza";
            this.sizeOptions.AccessibleName = "Opciones de tamaño de pizza";
            this.sizeOptions.Controls.Add(this.largePizza);
            this.sizeOptions.Controls.Add(this.smallPizza);
            this.sizeOptions.Location = new System.Drawing.Point(54, 216);
            this.sizeOptions.Name = "sizeOptions";
            this.sizeOptions.Size = new System.Drawing.Size(200, 100);
            this.sizeOptions.TabIndex = 4;
            this.sizeOptions.TabStop = false;
            this.sizeOptions.Text = "Pizza size";
            // 
            // smallPizza
            // 
            this.smallPizza.AccessibleDescription = "Pizza pequeña";
            this.smallPizza.AccessibleName = "Pizza pequeña";
            this.smallPizza.AutoSize = true;
            this.smallPizza.Location = new System.Drawing.Point(36, 37);
            this.smallPizza.Name = "smallPizza";
            this.smallPizza.Size = new System.Drawing.Size(94, 20);
            this.smallPizza.TabIndex = 0;
            this.smallPizza.TabStop = true;
            this.smallPizza.Text = "&Small $6.00";
            this.smallPizza.UseVisualStyleBackColor = true;
            // 
            // customerName
            // 
            this.customerName.AccessibleDescription = "Nombre del cliente";
            this.customerName.AccessibleName = "Nombre del cliente";
            this.customerName.Location = new System.Drawing.Point(377, 153);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(156, 22);
            this.customerName.TabIndex = 3;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AccessibleDescription = "Etiqueta de ingredientes";
            this.toppingsLabel.AccessibleName = "Etiqueta de ingredientes";
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(374, 194);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(141, 16);
            this.toppingsLabel.TabIndex = 5;
            this.toppingsLabel.Text = "&Toppings ($0.75 each)";
            // 
            // toppings
            // 
            this.toppings.AccessibleDescription = "Ingredientes disponibles";
            this.toppings.AccessibleName = "Ingredientes disponibles";
            this.toppings.FormattingEnabled = true;
            this.toppings.Items.AddRange(new object[] {
            "Pedro albondiga",
            "Cubi chili",
            "Carrasco Platano",
            "Laura sweet"});
            this.toppings.Location = new System.Drawing.Point(377, 213);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(138, 89);
            this.toppings.TabIndex = 6;
            // 
            // orden
            // 
            this.orden.AccessibleDescription = "Total del pedido";
            this.orden.AccessibleName = "Total del pedido";
            this.orden.Location = new System.Drawing.Point(377, 336);
            this.orden.Name = "orden";
            this.orden.Size = new System.Drawing.Size(75, 23);
            this.orden.TabIndex = 7;
            this.orden.Text = "&Ordenar";
            this.orden.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.AccessibleDescription = "Cancelar el pedido";
            this.cancel.AccessibleName = "Cancelar el pedido";
            this.cancel.Location = new System.Drawing.Point(214, 336);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "&Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCommands,
            this.exitApp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileCommands
            // 
            this.fileCommands.Name = "fileCommands";
            this.fileCommands.Size = new System.Drawing.Size(60, 20);
            this.fileCommands.Text = "&Archivo";
            // 
            // exitApp
            // 
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(41, 20);
            this.exitApp.Text = "&Salir";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Formulario de pedido";
            this.AccessibleName = "Formulario de pedido";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 371);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.orden);
            this.Controls.Add(this.toppings);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.sizeOptions);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.Load += new System.EventHandler(this.customerLabel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.sizeOptions.ResumeLayout(false);
            this.sizeOptions.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.RadioButton largePizza;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.GroupBox sizeOptions;
        private System.Windows.Forms.RadioButton smallPizza;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.CheckedListBox toppings;
        private System.Windows.Forms.Button orden;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileCommands;
        private System.Windows.Forms.ToolStripMenuItem exitApp;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

