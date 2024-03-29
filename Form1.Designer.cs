namespace NumberGenerator
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnString = new System.Windows.Forms.RadioButton();
            this.rdBtnNumber = new System.Windows.Forms.RadioButton();
            this.rdBtnGuid = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpBxSelection = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBxChars = new System.Windows.Forms.GroupBox();
            this.txtCharLength = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBxSelection.SuspendLayout();
            this.grpBxChars.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 245);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(572, 281);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnString);
            this.groupBox1.Controls.Add(this.rdBtnNumber);
            this.groupBox1.Controls.Add(this.rdBtnGuid);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rdBtnString
            // 
            this.rdBtnString.AutoSize = true;
            this.rdBtnString.Location = new System.Drawing.Point(21, 86);
            this.rdBtnString.Name = "rdBtnString";
            this.rdBtnString.Size = new System.Drawing.Size(62, 20);
            this.rdBtnString.TabIndex = 2;
            this.rdBtnString.TabStop = true;
            this.rdBtnString.Text = "String";
            this.rdBtnString.UseVisualStyleBackColor = true;
            this.rdBtnString.CheckedChanged += new System.EventHandler(this.rdBtnString_CheckedChanged);
            // 
            // rdBtnNumber
            // 
            this.rdBtnNumber.AutoSize = true;
            this.rdBtnNumber.Location = new System.Drawing.Point(21, 59);
            this.rdBtnNumber.Name = "rdBtnNumber";
            this.rdBtnNumber.Size = new System.Drawing.Size(83, 20);
            this.rdBtnNumber.TabIndex = 1;
            this.rdBtnNumber.TabStop = true;
            this.rdBtnNumber.Text = "Numbers";
            this.rdBtnNumber.UseVisualStyleBackColor = true;
            this.rdBtnNumber.CheckedChanged += new System.EventHandler(this.rdBtnNumber_CheckedChanged);
            // 
            // rdBtnGuid
            // 
            this.rdBtnGuid.AutoSize = true;
            this.rdBtnGuid.Location = new System.Drawing.Point(21, 32);
            this.rdBtnGuid.Name = "rdBtnGuid";
            this.rdBtnGuid.Size = new System.Drawing.Size(61, 20);
            this.rdBtnGuid.TabIndex = 0;
            this.rdBtnGuid.TabStop = true;
            this.rdBtnGuid.Text = "GUID";
            this.rdBtnGuid.UseVisualStyleBackColor = true;
            this.rdBtnGuid.CheckedChanged += new System.EventHandler(this.rdBtnGuid_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Capital Letters",
            "Small Letters",
            "Special Characters",
            "Numbers"});
            this.checkedListBox1.Location = new System.Drawing.Point(11, 26);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(189, 134);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(15, 27);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(68, 22);
            this.txtQty.TabIndex = 3;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Location = new System.Drawing.Point(29, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 66);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "How Many?";
            // 
            // grpBxSelection
            // 
            this.grpBxSelection.Controls.Add(this.checkedListBox1);
            this.grpBxSelection.Location = new System.Drawing.Point(199, 12);
            this.grpBxSelection.Name = "grpBxSelection";
            this.grpBxSelection.Size = new System.Drawing.Size(215, 167);
            this.grpBxSelection.TabIndex = 5;
            this.grpBxSelection.TabStop = false;
            this.grpBxSelection.Text = "Selections";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(152, 199);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 31);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(305, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 31);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpBxChars
            // 
            this.grpBxChars.Controls.Add(this.txtCharLength);
            this.grpBxChars.Location = new System.Drawing.Point(420, 12);
            this.grpBxChars.Name = "grpBxChars";
            this.grpBxChars.Size = new System.Drawing.Size(143, 79);
            this.grpBxChars.TabIndex = 5;
            this.grpBxChars.TabStop = false;
            this.grpBxChars.Text = "How Many Characters?";
            // 
            // txtCharLength
            // 
            this.txtCharLength.Location = new System.Drawing.Point(6, 42);
            this.txtCharLength.Name = "txtCharLength";
            this.txtCharLength.Size = new System.Drawing.Size(68, 22);
            this.txtCharLength.TabIndex = 3;
            this.txtCharLength.TextChanged += new System.EventHandler(this.txtCharLength_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 538);
            this.Controls.Add(this.grpBxChars);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grpBxSelection);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBxSelection.ResumeLayout(false);
            this.grpBxChars.ResumeLayout(false);
            this.grpBxChars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnString;
        private System.Windows.Forms.RadioButton rdBtnNumber;
        private System.Windows.Forms.RadioButton rdBtnGuid;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpBxSelection;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBxChars;
        private System.Windows.Forms.TextBox txtCharLength;
    }
}

