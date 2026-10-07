namespace HashTool
{
    partial class GetHash
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            Get_Hash = new Button();
            Copy = new Button();
            label4 = new Label();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(499, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 46);
            label1.TabIndex = 0;
            label1.Text = "Get hash";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(212, 41);
            label2.TabIndex = 1;
            label2.Text = "Введите текст:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(750, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(175, 41);
            label3.TabIndex = 3;
            label3.Text = "Хеш текста:";
            // 
            // Get_Hash
            // 
            Get_Hash.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Get_Hash.Location = new Point(1020, 266);
            Get_Hash.Name = "Get_Hash";
            Get_Hash.Size = new Size(150, 75);
            Get_Hash.TabIndex = 4;
            Get_Hash.Text = "Get hash";
            Get_Hash.UseVisualStyleBackColor = true;
            Get_Hash.Click += Get_Hash_Click;
            // 
            // Copy
            // 
            Copy.BackgroundImage = Properties.Resources.Copy;
            Copy.BackgroundImageLayout = ImageLayout.Stretch;
            Copy.Location = new Point(12, 207);
            Copy.Name = "Copy";
            Copy.Size = new Size(50, 50);
            Copy.TabIndex = 5;
            Copy.UseVisualStyleBackColor = true;
            Copy.Click += Copy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(62, 207);
            label4.Name = "label4";
            label4.Size = new Size(0, 41);
            label4.TabIndex = 6;
            // 
            // Back
            // 
            Back.BackgroundImage = Properties.Resources.Back;
            Back.BackgroundImageLayout = ImageLayout.Stretch;
            Back.Location = new Point(1120, 12);
            Back.Name = "Back";
            Back.Size = new Size(50, 50);
            Back.TabIndex = 7;
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // GetHash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 353);
            Controls.Add(Back);
            Controls.Add(label4);
            Controls.Add(Copy);
            Controls.Add(Get_Hash);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GetHash";
            Text = "Get hash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button Get_Hash;
        private Button Copy;
        private Label label4;
        private Button Back;
    }
}