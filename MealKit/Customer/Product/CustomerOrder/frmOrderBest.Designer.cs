namespace MealKit.Customer.Product.CustomerOrder.Customer.Product.CustomerOrder
{
    partial class frmOrderBest
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
            this.productInfo1 = new MealKit.Controls.ProductInfo();
            this.SuspendLayout();
            // 
            // productInfo1
            // 
            this.productInfo1.Location = new System.Drawing.Point(12, 12);
            this.productInfo1.Name = "productInfo1";
            this.productInfo1.Size = new System.Drawing.Size(334, 317);
            this.productInfo1.TabIndex = 0;
            // 
            // frmOrderBest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productInfo1);
            this.Name = "frmOrderBest";
            this.Text = "frmOrderBest";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ProductInfo productInfo1;
    }
}