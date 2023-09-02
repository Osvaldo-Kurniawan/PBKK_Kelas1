namespace Kuliah1
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
            WELCOME = new Label();
            lbfirst = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            OKbutton = new Button();
            button2 = new Button();
            Salam = new Label();
            SuspendLayout();
            // 
            // WELCOME
            // 
            WELCOME.AutoSize = true;
            WELCOME.Font = new Font("MS UI Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            WELCOME.ForeColor = Color.FromArgb(116, 86, 174);
            WELCOME.Location = new Point(28, 68);
            WELCOME.Name = "WELCOME";
            WELCOME.Size = new Size(240, 40);
            WELCOME.TabIndex = 0;
            WELCOME.Text = "WELCOME !!";
            // 
            // lbfirst
            // 
            lbfirst.AutoSize = true;
            lbfirst.ForeColor = Color.LightSlateGray;
            lbfirst.Location = new Point(28, 136);
            lbfirst.Name = "lbfirst";
            lbfirst.Size = new Size(111, 28);
            lbfirst.TabIndex = 1;
            lbfirst.Text = "First name";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(28, 167);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(411, 37);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(230, 231, 233);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("MS UI Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(28, 260);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(411, 37);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightSlateGray;
            label2.Location = new Point(28, 229);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 3;
            label2.Text = "Last name";
            // 
            // OKbutton
            // 
            OKbutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OKbutton.BackColor = Color.FromArgb(116, 86, 174);
            OKbutton.ForeColor = Color.White;
            OKbutton.Location = new Point(28, 405);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(411, 53);
            OKbutton.TabIndex = 5;
            OKbutton.Text = "OK";
            OKbutton.UseVisualStyleBackColor = false;
            OKbutton.Click += OKbutton_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(28, 464);
            button2.Name = "button2";
            button2.Size = new Size(411, 53);
            button2.TabIndex = 6;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Salam
            // 
            Salam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Salam.AutoSize = true;
            Salam.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Salam.ForeColor = Color.DimGray;
            Salam.Location = new Point(28, 324);
            Salam.MaximumSize = new Size(5301, 80);
            Salam.Name = "Salam";
            Salam.Size = new Size(0, 28);
            Salam.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(471, 565);
            Controls.Add(Salam);
            Controls.Add(button2);
            Controls.Add(OKbutton);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(lbfirst);
            Controls.Add(WELCOME);
            Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Violet;
            Name = "Form1";
            Text = "Welcome APP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WELCOME;
        private Label lbfirst;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button OKbutton;
        private Button button2;
        private Label Salam;
    }
}