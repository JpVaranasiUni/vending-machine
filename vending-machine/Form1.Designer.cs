namespace vending_machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            prodContainer = new Label();
            basketContainer = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            burgerBtn = new Button();
            drinksBtn = new Button();
            pizzaBtn = new Button();
            crispsBtn = new Button();
            friesBtn = new Button();
            wrapBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(120, 38);
            label1.TabIndex = 0;
            label1.Text = "Products";
            label1.Click += label1_Click;
            // 
            // prodContainer
            // 
            prodContainer.BorderStyle = BorderStyle.FixedSingle;
            prodContainer.Location = new Point(50, 100);
            prodContainer.Name = "prodContainer";
            prodContainer.Size = new Size(460, 320);
            prodContainer.TabIndex = 1;
            prodContainer.Text = "label2";
            prodContainer.Click += prodContainer_Click;
            // 
            // basketContainer
            // 
            basketContainer.BorderStyle = BorderStyle.FixedSingle;
            basketContainer.Location = new Point(589, 100);
            basketContainer.Name = "basketContainer";
            basketContainer.Size = new Size(179, 320);
            basketContainer.TabIndex = 2;
            basketContainer.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(387, 128);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(228, 273);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(228, 128);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(66, 273);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 100);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(387, 273);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 100);
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // burgerBtn
            // 
            burgerBtn.Location = new Point(82, 234);
            burgerBtn.Name = "burgerBtn";
            burgerBtn.Size = new Size(75, 23);
            burgerBtn.TabIndex = 9;
            burgerBtn.Text = "Add  →";
            burgerBtn.UseVisualStyleBackColor = true;
            burgerBtn.Click += burgerBtn_Click;
            // 
            // drinksBtn
            // 
            drinksBtn.Location = new Point(401, 234);
            drinksBtn.Name = "drinksBtn";
            drinksBtn.Size = new Size(75, 23);
            drinksBtn.TabIndex = 10;
            drinksBtn.Text = "Add  →";
            drinksBtn.UseVisualStyleBackColor = true;
            // 
            // pizzaBtn
            // 
            pizzaBtn.Location = new Point(242, 234);
            pizzaBtn.Name = "pizzaBtn";
            pizzaBtn.Size = new Size(75, 23);
            pizzaBtn.TabIndex = 11;
            pizzaBtn.Text = "Add  →";
            pizzaBtn.UseVisualStyleBackColor = true;
            pizzaBtn.Click += pizzaBtn_Click;
            // 
            // crispsBtn
            // 
            crispsBtn.Location = new Point(242, 379);
            crispsBtn.Name = "crispsBtn";
            crispsBtn.Size = new Size(75, 23);
            crispsBtn.TabIndex = 14;
            crispsBtn.Text = "Add  →";
            crispsBtn.UseVisualStyleBackColor = true;
            // 
            // friesBtn
            // 
            friesBtn.Location = new Point(401, 379);
            friesBtn.Name = "friesBtn";
            friesBtn.Size = new Size(75, 23);
            friesBtn.TabIndex = 13;
            friesBtn.Text = "Add  →";
            friesBtn.UseVisualStyleBackColor = true;
            // 
            // wrapBtn
            // 
            wrapBtn.Location = new Point(82, 379);
            wrapBtn.Name = "wrapBtn";
            wrapBtn.Size = new Size(75, 23);
            wrapBtn.TabIndex = 12;
            wrapBtn.Text = "Add  →";
            wrapBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(crispsBtn);
            Controls.Add(friesBtn);
            Controls.Add(wrapBtn);
            Controls.Add(pizzaBtn);
            Controls.Add(drinksBtn);
            Controls.Add(burgerBtn);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(basketContainer);
            Controls.Add(prodContainer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label prodContainer;
        private Label basketContainer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button burgerBtn;
        private Button drinksBtn;
        private Button pizzaBtn;
        private Button crispsBtn;
        private Button friesBtn;
        private Button wrapBtn;
    }
}
