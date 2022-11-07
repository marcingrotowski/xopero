namespace ćwiczenie_naleśniki_kolekcje
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
            this.addLumberjack = new System.Windows.Forms.Button();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextInLine = new System.Windows.Forms.TextBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // addLumberjack
            // 
            this.addLumberjack.Location = new System.Drawing.Point(12, 37);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(325, 23);
            this.addLumberjack.TabIndex = 0;
            this.addLumberjack.Text = "Dodaj drwala";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            // 
            // nextLumberjack
            // 
            this.nextLumberjack.Location = new System.Drawing.Point(6, 245);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(188, 23);
            this.nextLumberjack.TabIndex = 1;
            this.nextLumberjack.Text = "Następny drwal";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            this.nextLumberjack.Click += new System.EventHandler(this.nextLumberjack_Click);
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.Location = new System.Drawing.Point(6, 153);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(188, 23);
            this.addFlapjacks.TabIndex = 2;
            this.addFlapjacks.Text = "Dodaj naleśniki";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(130, 8);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(207, 23);
            this.name.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Location = new System.Drawing.Point(197, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // nextInLine
            // 
            this.nextInLine.Location = new System.Drawing.Point(6, 182);
            this.nextInLine.Multiline = true;
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.ReadOnly = true;
            this.nextInLine.Size = new System.Drawing.Size(188, 57);
            this.nextInLine.TabIndex = 12;
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(6, 24);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(120, 23);
            this.howMany.TabIndex = 11;
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(6, 53);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(87, 19);
            this.crispy.TabIndex = 6;
            this.crispy.TabStop = true;
            this.crispy.Text = "Chrupiekgo";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(6, 78);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(87, 19);
            this.soggy.TabIndex = 7;
            this.soggy.TabStop = true;
            this.soggy.Text = "Wilgotnego";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(6, 103);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(86, 19);
            this.browned.TabIndex = 8;
            this.browned.TabStop = true;
            this.browned.Text = "Rumianego";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 128);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 19);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Bananowego";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imię drwala:";
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.ItemHeight = 15;
            this.line.Location = new System.Drawing.Point(12, 98);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(179, 274);
            this.line.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kolejka do śniadania";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addLumberjack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addLumberjack;
        private Button nextLumberjack;
        private Button addFlapjacks;
        private TextBox name;
        private GroupBox groupBox1;
        private Label label1;
        private ListBox line;
        private Label label2;
        private RadioButton crispy;
        private RadioButton soggy;
        private RadioButton browned;
        private RadioButton radioButton4;
        private TextBox nextInLine;
        private NumericUpDown howMany;
    }
}