namespace PPE4._2_GSB_CE
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_PieChart = new System.Windows.Forms.Button();
            this.BT_Cat_Product = new System.Windows.Forms.Button();
            this.BT_ClientCommande = new System.Windows.Forms.Button();
            this.BT_Orders = new System.Windows.Forms.Button();
            this.BT_Commands = new System.Windows.Forms.Button();
            this.BT_Customer = new System.Windows.Forms.Button();
            this.BT_ProdductUnitPrice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entityDataSource1 = new EFWinforms.EntityDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enterprise Commitee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Northwind App";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_PieChart
            // 
            this.BT_PieChart.Location = new System.Drawing.Point(268, 315);
            this.BT_PieChart.Name = "BT_PieChart";
            this.BT_PieChart.Size = new System.Drawing.Size(75, 23);
            this.BT_PieChart.TabIndex = 4;
            this.BT_PieChart.Text = "Pie Chart";
            this.BT_PieChart.UseVisualStyleBackColor = true;
            this.BT_PieChart.Click += new System.EventHandler(this.BT_PieChart_Click);
            // 
            // BT_Cat_Product
            // 
            this.BT_Cat_Product.Location = new System.Drawing.Point(268, 356);
            this.BT_Cat_Product.Name = "BT_Cat_Product";
            this.BT_Cat_Product.Size = new System.Drawing.Size(75, 23);
            this.BT_Cat_Product.TabIndex = 5;
            this.BT_Cat_Product.Text = "CatandProduct";
            this.BT_Cat_Product.UseVisualStyleBackColor = true;
            this.BT_Cat_Product.Click += new System.EventHandler(this.BT_Cat_Product_Click);
            // 
            // BT_ClientCommande
            // 
            this.BT_ClientCommande.Location = new System.Drawing.Point(268, 397);
            this.BT_ClientCommande.Name = "BT_ClientCommande";
            this.BT_ClientCommande.Size = new System.Drawing.Size(75, 23);
            this.BT_ClientCommande.TabIndex = 6;
            this.BT_ClientCommande.Text = "ClientCommande";
            this.BT_ClientCommande.UseVisualStyleBackColor = true;
            this.BT_ClientCommande.Click += new System.EventHandler(this.BT_ClientCommande_Click);
            // 
            // BT_Orders
            // 
            this.BT_Orders.Location = new System.Drawing.Point(440, 270);
            this.BT_Orders.Name = "BT_Orders";
            this.BT_Orders.Size = new System.Drawing.Size(75, 23);
            this.BT_Orders.TabIndex = 7;
            this.BT_Orders.Text = "Orders";
            this.BT_Orders.UseVisualStyleBackColor = true;
            this.BT_Orders.Click += new System.EventHandler(this.BT_Orders_Click);
            // 
            // BT_Commands
            // 
            this.BT_Commands.Location = new System.Drawing.Point(440, 315);
            this.BT_Commands.Name = "BT_Commands";
            this.BT_Commands.Size = new System.Drawing.Size(75, 23);
            this.BT_Commands.TabIndex = 8;
            this.BT_Commands.Text = "Commandes";
            this.BT_Commands.UseVisualStyleBackColor = true;
            this.BT_Commands.Click += new System.EventHandler(this.BT_Commands_Click);
            // 
            // BT_Customer
            // 
            this.BT_Customer.Location = new System.Drawing.Point(440, 356);
            this.BT_Customer.Name = "BT_Customer";
            this.BT_Customer.Size = new System.Drawing.Size(75, 23);
            this.BT_Customer.TabIndex = 9;
            this.BT_Customer.Text = "Customer";
            this.BT_Customer.UseVisualStyleBackColor = true;
            this.BT_Customer.Click += new System.EventHandler(this.BT_Customer_Click);
            // 
            // BT_ProdductUnitPrice
            // 
            this.BT_ProdductUnitPrice.Location = new System.Drawing.Point(440, 397);
            this.BT_ProdductUnitPrice.Name = "BT_ProdductUnitPrice";
            this.BT_ProdductUnitPrice.Size = new System.Drawing.Size(75, 23);
            this.BT_ProdductUnitPrice.TabIndex = 10;
            this.BT_ProdductUnitPrice.Text = "ProductUnitPrice";
            this.BT_ProdductUnitPrice.UseVisualStyleBackColor = true;
            this.BT_ProdductUnitPrice.Click += new System.EventHandler(this.BT_ProdductUnitPrice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE4._2_GSB_CE.Properties.Resources.GSB;
            this.pictureBox1.Location = new System.Drawing.Point(43, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // entityDataSource1
            // 
            this.entityDataSource1.DbContextType = typeof(PPE4._2_GSB_CE.GSB_CEEntities);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_ProdductUnitPrice);
            this.Controls.Add(this.BT_Customer);
            this.Controls.Add(this.BT_Commands);
            this.Controls.Add(this.BT_Orders);
            this.Controls.Add(this.BT_ClientCommande);
            this.Controls.Add(this.BT_Cat_Product);
            this.Controls.Add(this.BT_PieChart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BT_PieChart;
        private System.Windows.Forms.Button BT_Cat_Product;
        private System.Windows.Forms.Button BT_ClientCommande;
        private System.Windows.Forms.Button BT_Orders;
        private System.Windows.Forms.Button BT_Commands;
        private System.Windows.Forms.Button BT_Customer;
        private System.Windows.Forms.Button BT_ProdductUnitPrice;
        private EFWinforms.EntityDataSource entityDataSource1;
    }
}

