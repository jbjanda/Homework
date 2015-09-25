namespace JJanda_Assignment1
{
    partial class PizzaShop
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
            this.labelPizzaSign = new System.Windows.Forms.Label();
            this.labelPizzaOrder = new System.Windows.Forms.Label();
            this.labelPizzaNumber = new System.Windows.Forms.Label();
            this.labelUserOrder = new System.Windows.Forms.Label();
            this.labelOrderMessage = new System.Windows.Forms.Label();
            this.txtBoxPizzaNumber = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPizzaSign
            // 
            this.labelPizzaSign.AutoSize = true;
            this.labelPizzaSign.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPizzaSign.Location = new System.Drawing.Point(12, 9);
            this.labelPizzaSign.Name = "labelPizzaSign";
            this.labelPizzaSign.Size = new System.Drawing.Size(298, 17);
            this.labelPizzaSign.TabIndex = 0;
            this.labelPizzaSign.Text = "Welcome to Jeff Janda\'s Pizza Shop";
            // 
            // labelPizzaOrder
            // 
            this.labelPizzaOrder.AutoSize = true;
            this.labelPizzaOrder.Location = new System.Drawing.Point(115, 54);
            this.labelPizzaOrder.Name = "labelPizzaOrder";
            this.labelPizzaOrder.Size = new System.Drawing.Size(86, 13);
            this.labelPizzaOrder.TabIndex = 1;
            this.labelPizzaOrder.Text = "Enter Your Order";
            // 
            // labelPizzaNumber
            // 
            this.labelPizzaNumber.AutoSize = true;
            this.labelPizzaNumber.Location = new System.Drawing.Point(90, 93);
            this.labelPizzaNumber.Name = "labelPizzaNumber";
            this.labelPizzaNumber.Size = new System.Drawing.Size(89, 13);
            this.labelPizzaNumber.TabIndex = 2;
            this.labelPizzaNumber.Text = "Number of Pizzas";
            // 
            // labelUserOrder
            // 
            this.labelUserOrder.AutoSize = true;
            this.labelUserOrder.Location = new System.Drawing.Point(123, 169);
            this.labelUserOrder.Name = "labelUserOrder";
            this.labelUserOrder.Size = new System.Drawing.Size(58, 13);
            this.labelUserOrder.TabIndex = 3;
            this.labelUserOrder.Text = "Your Order";
            // 
            // labelOrderMessage
            // 
            this.labelOrderMessage.Location = new System.Drawing.Point(27, 194);
            this.labelOrderMessage.Name = "labelOrderMessage";
            this.labelOrderMessage.Size = new System.Drawing.Size(277, 39);
            this.labelOrderMessage.TabIndex = 4;
            // 
            // txtBoxPizzaNumber
            // 
            this.txtBoxPizzaNumber.Location = new System.Drawing.Point(192, 86);
            this.txtBoxPizzaNumber.Name = "txtBoxPizzaNumber";
            this.txtBoxPizzaNumber.Size = new System.Drawing.Size(26, 20);
            this.txtBoxPizzaNumber.TabIndex = 5;
            this.txtBoxPizzaNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(15, 257);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonOrder.TabIndex = 6;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 286);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(229, 286);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(229, 257);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomer.TabIndex = 9;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // PizzaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 314);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.txtBoxPizzaNumber);
            this.Controls.Add(this.labelOrderMessage);
            this.Controls.Add(this.labelUserOrder);
            this.Controls.Add(this.labelPizzaNumber);
            this.Controls.Add(this.labelPizzaOrder);
            this.Controls.Add(this.labelPizzaSign);
            this.Name = "PizzaShop";
            this.Text = "Jeff Janda\'s Pizza Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPizzaSign;
        private System.Windows.Forms.Label labelPizzaOrder;
        private System.Windows.Forms.Label labelPizzaNumber;
        private System.Windows.Forms.Label labelUserOrder;
        private System.Windows.Forms.Label labelOrderMessage;
        private System.Windows.Forms.TextBox txtBoxPizzaNumber;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCustomer;
    }
}

