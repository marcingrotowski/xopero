namespace Zadanie_3
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
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.changeText = new System.Windows.Forms.Button();
            this.labelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Checked = true;
            this.enableCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckbox.Location = new System.Drawing.Point(330, 12);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(142, 19);
            this.enableCheckbox.TabIndex = 0;
            this.enableCheckbox.Text = "Włącz zmianę etykiety";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            // 
            // changeText
            // 
            this.changeText.Location = new System.Drawing.Point(12, 8);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(178, 23);
            this.changeText.TabIndex = 1;
            this.changeText.Text = "Kliknij aby zmienić etykietę";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(0, 67);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(484, 23);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Naciśnij przycisk, aby zmienić tekst";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 91);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.changeText);
            this.Controls.Add(this.enableCheckbox);
            this.Name = "Form1";
            this.Text = "Aplikacja Windows Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox enableCheckbox;
        private Button changeText;
        private Label labelToChange;
    }
}