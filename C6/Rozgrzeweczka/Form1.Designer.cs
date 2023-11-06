namespace Rozgrzeweczka
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            polski = new TextBox();
            matma = new TextBox();
            fizyka = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(123, 129);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Sprawdź";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 34);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Język Polski";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 73);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Matematyka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 103);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Fizyka";
            // 
            // polski
            // 
            polski.Location = new Point(123, 31);
            polski.Name = "polski";
            polski.Size = new Size(100, 23);
            polski.TabIndex = 4;
            // 
            // matma
            // 
            matma.Location = new Point(123, 65);
            matma.Name = "matma";
            matma.Size = new Size(100, 23);
            matma.TabIndex = 5;
            // 
            // fizyka
            // 
            fizyka.Location = new Point(123, 100);
            fizyka.Name = "fizyka";
            fizyka.Size = new Size(100, 23);
            fizyka.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 179);
            Controls.Add(fizyka);
            Controls.Add(matma);
            Controls.Add(polski);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox polski;
        private TextBox matma;
        private TextBox fizyka;
    }
}