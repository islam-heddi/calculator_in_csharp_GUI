namespace calculatrice
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
            screen = new Panel();
            num = new Label();
            equal = new Button();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            b6 = new Button();
            b5 = new Button();
            b4 = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            b0 = new Button();
            division = new Button();
            product = new Button();
            sub = new Button();
            sum = new Button();
            C = new Button();
            undo = new Button();
            screen.SuspendLayout();
            SuspendLayout();
            // 
            // screen
            // 
            screen.BackColor = Color.White;
            screen.BorderStyle = BorderStyle.Fixed3D;
            screen.Controls.Add(num);
            screen.ImeMode = ImeMode.Disable;
            screen.Location = new Point(21, 12);
            screen.Name = "screen";
            screen.Size = new Size(300, 48);
            screen.TabIndex = 0;
            // 
            // num
            // 
            num.AutoSize = true;
            num.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            num.ForeColor = SystemColors.ActiveCaptionText;
            num.Location = new Point(18, 10);
            num.Name = "num";
            num.RightToLeft = RightToLeft.Yes;
            num.Size = new Size(22, 25);
            num.TabIndex = 0;
            num.Text = "0";
            // 
            // equal
            // 
            equal.Location = new Point(202, 166);
            equal.Name = "equal";
            equal.Size = new Size(89, 23);
            equal.TabIndex = 1;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // b9
            // 
            b9.Location = new Point(161, 166);
            b9.Name = "b9";
            b9.Size = new Size(35, 23);
            b9.TabIndex = 2;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b8
            // 
            b8.Location = new Point(120, 166);
            b8.Name = "b8";
            b8.Size = new Size(35, 23);
            b8.TabIndex = 3;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b7
            // 
            b7.Location = new Point(79, 166);
            b7.Name = "b7";
            b7.Size = new Size(35, 23);
            b7.TabIndex = 4;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b6
            // 
            b6.Location = new Point(161, 137);
            b6.Name = "b6";
            b6.Size = new Size(35, 23);
            b6.TabIndex = 5;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b5
            // 
            b5.Location = new Point(120, 137);
            b5.Name = "b5";
            b5.Size = new Size(35, 23);
            b5.TabIndex = 6;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b4
            // 
            b4.Location = new Point(79, 137);
            b4.Name = "b4";
            b4.Size = new Size(35, 23);
            b4.TabIndex = 7;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b3
            // 
            b3.Location = new Point(161, 108);
            b3.Name = "b3";
            b3.Size = new Size(35, 23);
            b3.TabIndex = 8;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b2
            // 
            b2.Location = new Point(120, 108);
            b2.Name = "b2";
            b2.Size = new Size(35, 23);
            b2.TabIndex = 9;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b1
            // 
            b1.Location = new Point(79, 108);
            b1.Name = "b1";
            b1.Size = new Size(35, 23);
            b1.TabIndex = 10;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b0
            // 
            b0.Location = new Point(41, 108);
            b0.Name = "b0";
            b0.Size = new Size(32, 81);
            b0.TabIndex = 11;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // division
            // 
            division.Location = new Point(202, 137);
            division.Name = "division";
            division.Size = new Size(89, 23);
            division.TabIndex = 12;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += division_Click;
            // 
            // product
            // 
            product.Location = new Point(202, 108);
            product.Name = "product";
            product.Size = new Size(89, 23);
            product.TabIndex = 13;
            product.Text = "X";
            product.UseVisualStyleBackColor = true;
            product.Click += product_Click;
            // 
            // sub
            // 
            sub.Location = new Point(120, 79);
            sub.Name = "sub";
            sub.Size = new Size(76, 23);
            sub.TabIndex = 14;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            sub.Click += sub_Click;
            // 
            // sum
            // 
            sum.Location = new Point(41, 79);
            sum.Name = "sum";
            sum.Size = new Size(73, 23);
            sum.TabIndex = 15;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = true;
            sum.Click += sum_Click;
            // 
            // C
            // 
            C.Location = new Point(251, 79);
            C.Name = "C";
            C.Size = new Size(40, 23);
            C.TabIndex = 16;
            C.Text = "C";
            C.UseVisualStyleBackColor = true;
            C.Click += C_Click;
            // 
            // undo
            // 
            undo.Location = new Point(202, 79);
            undo.Name = "undo";
            undo.Size = new Size(40, 23);
            undo.TabIndex = 17;
            undo.Text = "<-";
            undo.UseVisualStyleBackColor = true;
            undo.Click += undo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 226);
            Controls.Add(undo);
            Controls.Add(C);
            Controls.Add(sum);
            Controls.Add(sub);
            Controls.Add(product);
            Controls.Add(division);
            Controls.Add(b0);
            Controls.Add(b1);
            Controls.Add(b2);
            Controls.Add(b3);
            Controls.Add(b4);
            Controls.Add(b5);
            Controls.Add(b6);
            Controls.Add(b7);
            Controls.Add(b8);
            Controls.Add(b9);
            Controls.Add(equal);
            Controls.Add(screen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculatrice";
            Load += Form1_Load;
            screen.ResumeLayout(false);
            screen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel screen;
        private Button equal;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button b0;
        private Button division;
        private Button product;
        private Button sub;
        private Button sum;
        private Button C;
        private Button undo;
        private Label num;
    }
}