namespace Shop_Simulator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dayNumber = new System.Windows.Forms.Label();
            this.billsDue = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.feed = new System.Windows.Forms.ListBox();
            this.products = new System.Windows.Forms.TextBox();
            this.advertisement = new System.Windows.Forms.TextBox();
            this.productsCostOutput = new System.Windows.Forms.Label();
            this.dayTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayNumber
            // 
            this.dayNumber.AutoSize = true;
            this.dayNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNumber.Location = new System.Drawing.Point(14, 6);
            this.dayNumber.Name = "dayNumber";
            this.dayNumber.Size = new System.Drawing.Size(83, 26);
            this.dayNumber.TabIndex = 0;
            this.dayNumber.Text = "Day: 0";
            // 
            // billsDue
            // 
            this.billsDue.AutoSize = true;
            this.billsDue.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F);
            this.billsDue.Location = new System.Drawing.Point(14, 33);
            this.billsDue.Name = "billsDue";
            this.billsDue.Size = new System.Drawing.Size(229, 26);
            this.billsDue.TabIndex = 1;
            this.billsDue.Text = "Bills due in: 30 Days";
            // 
            // balance
            // 
            this.balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balance.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F);
            this.balance.Location = new System.Drawing.Point(522, 9);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(266, 26);
            this.balance.TabIndex = 2;
            this.balance.Text = "Balance: £100";
            this.balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(289, 231);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(262, 62);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Open";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // feed
            // 
            this.feed.FormattingEnabled = true;
            this.feed.Location = new System.Drawing.Point(244, 299);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(358, 108);
            this.feed.TabIndex = 4;
            // 
            // products
            // 
            this.products.Location = new System.Drawing.Point(352, 124);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(136, 20);
            this.products.TabIndex = 5;
            this.products.Text = "0";
            this.products.TextChanged += new System.EventHandler(this.products_TextChanged);
            // 
            // advertisement
            // 
            this.advertisement.Location = new System.Drawing.Point(352, 170);
            this.advertisement.Name = "advertisement";
            this.advertisement.Size = new System.Drawing.Size(136, 20);
            this.advertisement.TabIndex = 6;
            this.advertisement.Text = "0";
            this.advertisement.TextChanged += new System.EventHandler(this.advertisement_TextChanged);
            // 
            // productsCostOutput
            // 
            this.productsCostOutput.AutoSize = true;
            this.productsCostOutput.Location = new System.Drawing.Point(494, 127);
            this.productsCostOutput.Name = "productsCostOutput";
            this.productsCostOutput.Size = new System.Drawing.Size(19, 13);
            this.productsCostOutput.TabIndex = 7;
            this.productsCostOutput.Text = "£0";
            // 
            // dayTimer
            // 
            this.dayTimer.Interval = 1000;
            this.dayTimer.Tick += new System.EventHandler(this.dayTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "How much products to buy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "How much pounds to spend on advertisement:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productsCostOutput);
            this.Controls.Add(this.advertisement);
            this.Controls.Add(this.products);
            this.Controls.Add(this.feed);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.billsDue);
            this.Controls.Add(this.dayNumber);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayNumber;
        private System.Windows.Forms.Label billsDue;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox feed;
        private System.Windows.Forms.TextBox products;
        private System.Windows.Forms.TextBox advertisement;
        private System.Windows.Forms.Label productsCostOutput;
        private System.Windows.Forms.Timer dayTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

