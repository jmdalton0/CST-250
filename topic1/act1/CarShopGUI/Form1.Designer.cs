namespace CarShopGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createGroupBox = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.inventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.cartGroupBox = new System.Windows.Forms.GroupBox();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.createGroupBox.SuspendLayout();
            this.inventoryGroupBox.SuspendLayout();
            this.cartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createGroupBox
            // 
            this.createGroupBox.Controls.Add(this.createButton);
            this.createGroupBox.Controls.Add(this.priceTextBox);
            this.createGroupBox.Controls.Add(this.priceLabel);
            this.createGroupBox.Controls.Add(this.modelTextBox);
            this.createGroupBox.Controls.Add(this.modelLabel);
            this.createGroupBox.Controls.Add(this.makeTextBox);
            this.createGroupBox.Controls.Add(this.makeLabel);
            this.createGroupBox.Location = new System.Drawing.Point(12, 12);
            this.createGroupBox.Name = "createGroupBox";
            this.createGroupBox.Size = new System.Drawing.Size(250, 177);
            this.createGroupBox.TabIndex = 0;
            this.createGroupBox.TabStop = false;
            this.createGroupBox.Text = "Create a Car:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(62, 122);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 29);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create Car";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(62, 89);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(182, 27);
            this.priceTextBox.TabIndex = 5;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 89);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(62, 56);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(182, 27);
            this.modelTextBox.TabIndex = 3;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(6, 56);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(55, 20);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(62, 23);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(182, 27);
            this.makeTextBox.TabIndex = 1;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(6, 23);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(48, 20);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make:";
            // 
            // inventoryGroupBox
            // 
            this.inventoryGroupBox.Controls.Add(this.addButton);
            this.inventoryGroupBox.Controls.Add(this.inventoryListBox);
            this.inventoryGroupBox.Location = new System.Drawing.Point(268, 12);
            this.inventoryGroupBox.Name = "inventoryGroupBox";
            this.inventoryGroupBox.Size = new System.Drawing.Size(250, 332);
            this.inventoryGroupBox.TabIndex = 1;
            this.inventoryGroupBox.TabStop = false;
            this.inventoryGroupBox.Text = "Car Inventory:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 273);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(238, 29);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add to Cart";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 20;
            this.inventoryListBox.Location = new System.Drawing.Point(3, 23);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(241, 244);
            this.inventoryListBox.TabIndex = 0;
            // 
            // cartGroupBox
            // 
            this.cartGroupBox.Controls.Add(this.totalValueLabel);
            this.cartGroupBox.Controls.Add(this.totalLabel);
            this.cartGroupBox.Controls.Add(this.checkoutButton);
            this.cartGroupBox.Location = new System.Drawing.Point(524, 12);
            this.cartGroupBox.Name = "cartGroupBox";
            this.cartGroupBox.Size = new System.Drawing.Size(250, 332);
            this.cartGroupBox.TabIndex = 0;
            this.cartGroupBox.TabStop = false;
            this.cartGroupBox.Text = "Shopping Cart:";
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Location = new System.Drawing.Point(90, 305);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(0, 20);
            this.totalValueLabel.TabIndex = 10;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(6, 305);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(78, 20);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total Cost:";
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(6, 273);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(238, 29);
            this.checkoutButton.TabIndex = 8;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 20;
            this.cartListBox.Location = new System.Drawing.Point(530, 35);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(241, 244);
            this.cartListBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 351);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.cartGroupBox);
            this.Controls.Add(this.inventoryGroupBox);
            this.Controls.Add(this.createGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.createGroupBox.ResumeLayout(false);
            this.createGroupBox.PerformLayout();
            this.inventoryGroupBox.ResumeLayout(false);
            this.cartGroupBox.ResumeLayout(false);
            this.cartGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox createGroupBox;
        private TextBox priceTextBox;
        private Label priceLabel;
        private TextBox modelTextBox;
        private Label modelLabel;
        private TextBox makeTextBox;
        private Label makeLabel;
        private Button createButton;
        private GroupBox inventoryGroupBox;
        private Button addButton;
        private ListBox inventoryListBox;
        private GroupBox cartGroupBox;
        private Label totalValueLabel;
        private Label totalLabel;
        private Button checkoutButton;
        private ListBox cartListBox;
    }
}