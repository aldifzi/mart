namespace LKSMart
{
    partial class AddToCart
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productName_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.productDescription_label = new System.Windows.Forms.Label();
            this.productPrice_label = new System.Windows.Forms.Label();
            this.product_pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.productQuantity_label = new System.Windows.Forms.Label();
            this.decrease_button = new System.Windows.Forms.Button();
            this.increase_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_pictureBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.00662F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.99338F));
            this.tableLayoutPanel1.Controls.Add(this.productName_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.product_pictureBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.submit_button, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.26563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.73438F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // productName_label
            // 
            this.productName_label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.productName_label, 2);
            this.productName_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_label.Location = new System.Drawing.Point(4, 0);
            this.productName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productName_label.Name = "productName_label";
            this.productName_label.Size = new System.Drawing.Size(596, 76);
            this.productName_label.TabIndex = 0;
            this.productName_label.Text = "Product Name";
            this.productName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.productDescription_label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.productPrice_label, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(299, 80);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.61905F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.38095F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(301, 257);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // productDescription_label
            // 
            this.productDescription_label.AutoSize = true;
            this.productDescription_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDescription_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescription_label.Location = new System.Drawing.Point(4, 45);
            this.productDescription_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productDescription_label.Name = "productDescription_label";
            this.productDescription_label.Size = new System.Drawing.Size(293, 212);
            this.productDescription_label.TabIndex = 3;
            this.productDescription_label.Text = "product description";
            // 
            // productPrice_label
            // 
            this.productPrice_label.AutoSize = true;
            this.productPrice_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPrice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice_label.Location = new System.Drawing.Point(4, 0);
            this.productPrice_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productPrice_label.Name = "productPrice_label";
            this.productPrice_label.Size = new System.Drawing.Size(293, 45);
            this.productPrice_label.TabIndex = 2;
            this.productPrice_label.Text = "product price";
            this.productPrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // product_pictureBox
            // 
            this.product_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_pictureBox.Location = new System.Drawing.Point(4, 80);
            this.product_pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.product_pictureBox.Name = "product_pictureBox";
            this.product_pictureBox.Size = new System.Drawing.Size(287, 257);
            this.product_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_pictureBox.TabIndex = 3;
            this.product_pictureBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.81579F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.18421F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel3.Controls.Add(this.productQuantity_label, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.decrease_button, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.increase_button, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 345);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 61);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // productQuantity_label
            // 
            this.productQuantity_label.AutoSize = true;
            this.productQuantity_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productQuantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantity_label.Location = new System.Drawing.Point(82, 0);
            this.productQuantity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productQuantity_label.Name = "productQuantity_label";
            this.productQuantity_label.Size = new System.Drawing.Size(116, 61);
            this.productQuantity_label.TabIndex = 4;
            this.productQuantity_label.Text = "0";
            this.productQuantity_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decrease_button
            // 
            this.decrease_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decrease_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrease_button.Location = new System.Drawing.Point(4, 4);
            this.decrease_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decrease_button.Name = "decrease_button";
            this.decrease_button.Size = new System.Drawing.Size(70, 53);
            this.decrease_button.TabIndex = 5;
            this.decrease_button.Text = "-";
            this.decrease_button.UseVisualStyleBackColor = true;
            this.decrease_button.Click += new System.EventHandler(this.decrease_button_Click);
            // 
            // increase_button
            // 
            this.increase_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.increase_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increase_button.Location = new System.Drawing.Point(206, 4);
            this.increase_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.increase_button.Name = "increase_button";
            this.increase_button.Size = new System.Drawing.Size(77, 53);
            this.increase_button.TabIndex = 6;
            this.increase_button.Text = "+";
            this.increase_button.UseVisualStyleBackColor = true;
            this.increase_button.Click += new System.EventHandler(this.increase_button_Click);
            // 
            // submit_button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.submit_button, 2);
            this.submit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(4, 414);
            this.submit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(596, 61);
            this.submit_button.TabIndex = 5;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddToCart";
            this.Text = "AddToCart";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_pictureBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label productName_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label productDescription_label;
        private System.Windows.Forms.Label productPrice_label;
        private System.Windows.Forms.PictureBox product_pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label productQuantity_label;
        private System.Windows.Forms.Button decrease_button;
        private System.Windows.Forms.Button increase_button;
        private System.Windows.Forms.Button submit_button;
    }
}