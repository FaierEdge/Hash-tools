namespace HashTool
{
    partial class HashCheck
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Comparate = new Button();
            label4 = new Label();
            label5 = new Label();
            Back = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(550, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(271, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 46);
            label1.TabIndex = 2;
            label1.Text = "Hash check";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(310, 41);
            label2.TabIndex = 3;
            label2.Text = "Введите первый хеш:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(304, 41);
            label3.TabIndex = 4;
            label3.Text = "Введите второй хеш:";
            // 
            // Comparate
            // 
            Comparate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Comparate.Location = new Point(570, 316);
            Comparate.Name = "Comparate";
            Comparate.Size = new Size(200, 75);
            Comparate.TabIndex = 5;
            Comparate.Text = "Сравнить";
            Comparate.UseVisualStyleBackColor = true;
            Comparate.Click += Comparate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 312);
            label4.Name = "label4";
            label4.Size = new Size(166, 41);
            label4.TabIndex = 6;
            label4.Text = "Результат:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 353);
            label5.Name = "label5";
            label5.Size = new Size(363, 41);
            label5.TabIndex = 7;
            label5.Text = "Результат появится здесь";
            // 
            // Back
            // 
            Back.BackgroundImage = Properties.Resources.Back;
            Back.BackgroundImageLayout = ImageLayout.Stretch;
            Back.Location = new Point(720, 12);
            Back.Name = "Back";
            Back.Size = new Size(50, 50);
            Back.TabIndex = 8;
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // HashCheck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 403);
            Controls.Add(Back);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Comparate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HashCheck";
            Text = "Hash check";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Comparate;
        private Label label4;
        private Label label5;
        private Button Back;
    }
}