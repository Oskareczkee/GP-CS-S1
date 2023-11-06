namespace Zgadywanka
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tryCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zgadnij jaka liczba się wylosowała (zakres 1-1000)";
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(148, 83);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(225, 20);
            this.numberInput.TabIndex = 1;
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.DarkViolet;
            this.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckButton.Location = new System.Drawing.Point(67, 81);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Sprawdź";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liczba prób:";
            // 
            // tryCount
            // 
            this.tryCount.AutoSize = true;
            this.tryCount.Location = new System.Drawing.Point(145, 116);
            this.tryCount.Name = "tryCount";
            this.tryCount.Size = new System.Drawing.Size(13, 13);
            this.tryCount.TabIndex = 4;
            this.tryCount.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(441, 183);
            this.Controls.Add(this.tryCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zgadywanka";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tryCount;
    }
}

