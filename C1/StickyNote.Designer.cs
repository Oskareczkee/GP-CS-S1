namespace C1
{
    partial class StickyNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickyNote));
            Add = new Button();
            note = new TextBox();
            colorDialog = new ColorDialog();
            changeColor = new Button();
            SuspendLayout();
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(44, 44, 44);
            Add.FlatAppearance.BorderColor = Color.Red;
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Add.ForeColor = Color.WhiteSmoke;
            Add.Location = new Point(-2, -4);
            Add.Name = "Add";
            Add.Size = new Size(249, 63);
            Add.TabIndex = 0;
            Add.TabStop = false;
            Add.Text = "+";
            Add.TextAlign = ContentAlignment.MiddleLeft;
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // note
            // 
            note.BackColor = Color.FromArgb(44, 44, 44);
            note.BorderStyle = BorderStyle.None;
            note.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            note.ForeColor = Color.WhiteSmoke;
            note.Location = new Point(-2, 53);
            note.Multiline = true;
            note.Name = "note";
            note.Size = new Size(322, 227);
            note.TabIndex = 1;
            note.Text = "Utwórz notatkę...";
            // 
            // changeColor
            // 
            changeColor.BackColor = Color.FromArgb(44, 44, 44);
            changeColor.FlatAppearance.BorderSize = 0;
            changeColor.FlatStyle = FlatStyle.Flat;
            changeColor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            changeColor.ForeColor = Color.WhiteSmoke;
            changeColor.Location = new Point(245, -4);
            changeColor.Name = "changeColor";
            changeColor.Size = new Size(75, 63);
            changeColor.TabIndex = 3;
            changeColor.Text = "🎨";
            changeColor.UseVisualStyleBackColor = false;
            changeColor.Click += changeColor_Click;
            // 
            // StickyNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(321, 277);
            Controls.Add(changeColor);
            Controls.Add(note);
            Controls.Add(Add);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "StickyNote";
            Text = "Notes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private TextBox note;
        private ColorDialog colorDialog;
        private Button changeColor;
    }
}