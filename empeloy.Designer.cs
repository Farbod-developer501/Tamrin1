namespace Tamrin1
{
    partial class empeloy
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
            NameTextBox = new TextBox();
            LNameTextBox = new TextBox();
            PhonenumTextBox = new TextBox();
            NationalCdTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SubmitButton = new Button();
            MaleRadioButton = new RadioButton();
            FemaleRadioButton = new RadioButton();
            StatusGroupBox = new GroupBox();
            GenderLable = new Label();
            BossLinkLabel = new LinkLabel();
            EmployDataGridView = new DataGridView();
            StatusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployDataGridView).BeginInit();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(235, 30);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(553, 34);
            NameTextBox.TabIndex = 0;
            // 
            // LNameTextBox
            // 
            LNameTextBox.Location = new Point(235, 70);
            LNameTextBox.Multiline = true;
            LNameTextBox.Name = "LNameTextBox";
            LNameTextBox.Size = new Size(553, 34);
            LNameTextBox.TabIndex = 1;
            // 
            // PhonenumTextBox
            // 
            PhonenumTextBox.Location = new Point(235, 110);
            PhonenumTextBox.Multiline = true;
            PhonenumTextBox.Name = "PhonenumTextBox";
            PhonenumTextBox.Size = new Size(553, 34);
            PhonenumTextBox.TabIndex = 2;
            // 
            // NationalCdTextBox
            // 
            NationalCdTextBox.Location = new Point(235, 150);
            NationalCdTextBox.Multiline = true;
            NationalCdTextBox.Name = "NationalCdTextBox";
            NationalCdTextBox.Size = new Size(553, 34);
            NationalCdTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 153);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 4;
            label1.Text = "National Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 113);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 5;
            label2.Text = "Phonenumber";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 73);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 44);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Name";
            // 
            // SubmitButton
            // 
            SubmitButton.Cursor = Cursors.Hand;
            SubmitButton.Location = new Point(72, 371);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(141, 58);
            SubmitButton.TabIndex = 8;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Cursor = Cursors.Hand;
            MaleRadioButton.Location = new Point(26, 22);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(63, 24);
            MaleRadioButton.TabIndex = 9;
            MaleRadioButton.Text = "Male";
            MaleRadioButton.TextAlign = ContentAlignment.TopCenter;
            MaleRadioButton.UseVisualStyleBackColor = true;
            MaleRadioButton.CheckedChanged += MaleRadioButton_CheckedChanged;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.BackgroundImageLayout = ImageLayout.None;
            FemaleRadioButton.Cursor = Cursors.Hand;
            FemaleRadioButton.Location = new Point(95, 22);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(78, 24);
            FemaleRadioButton.TabIndex = 10;
            FemaleRadioButton.Text = "Female";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            FemaleRadioButton.CheckedChanged += FemaleRadioButton_CheckedChanged;
            // 
            // StatusGroupBox
            // 
            StatusGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatusGroupBox.Controls.Add(FemaleRadioButton);
            StatusGroupBox.Controls.Add(MaleRadioButton);
            StatusGroupBox.Location = new Point(59, 269);
            StatusGroupBox.Name = "StatusGroupBox";
            StatusGroupBox.RightToLeft = RightToLeft.Yes;
            StatusGroupBox.Size = new Size(179, 52);
            StatusGroupBox.TabIndex = 12;
            StatusGroupBox.TabStop = false;
            StatusGroupBox.Text = "Gender";
            // 
            // GenderLable
            // 
            GenderLable.AutoSize = true;
            GenderLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            GenderLable.Location = new Point(99, 324);
            GenderLable.Name = "GenderLable";
            GenderLable.Size = new Size(91, 31);
            GenderLable.TabIndex = 13;
            GenderLable.Text = "Gender";
            // 
            // BossLinkLabel
            // 
            BossLinkLabel.AutoSize = true;
            BossLinkLabel.Location = new Point(99, 246);
            BossLinkLabel.Name = "BossLinkLabel";
            BossLinkLabel.Size = new Size(84, 20);
            BossLinkLabel.TabIndex = 11;
            BossLinkLabel.TabStop = true;
            BossLinkLabel.Text = "I am admin";
            BossLinkLabel.LinkClicked += BossLinkLabel_LinkClicked;
            // 
            // EmployDataGridView
            // 
            EmployDataGridView.BackgroundColor = Color.White;
            EmployDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployDataGridView.Location = new Point(244, 213);
            EmployDataGridView.Name = "EmployDataGridView";
            EmployDataGridView.RowHeadersWidth = 51;
            EmployDataGridView.RowTemplate.Height = 29;
            EmployDataGridView.Size = new Size(544, 216);
            EmployDataGridView.TabIndex = 14;
            // 
            // empeloy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(EmployDataGridView);
            Controls.Add(GenderLable);
            Controls.Add(StatusGroupBox);
            Controls.Add(BossLinkLabel);
            Controls.Add(SubmitButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NationalCdTextBox);
            Controls.Add(PhonenumTextBox);
            Controls.Add(LNameTextBox);
            Controls.Add(NameTextBox);
            Name = "empeloy";
            Text = "Tamrin1";
            StatusGroupBox.ResumeLayout(false);
            StatusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox LNameTextBox;
        private TextBox PhonenumTextBox;
        private TextBox NationalCdTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SubmitButton;
        private RadioButton MaleRadioButton;
        private RadioButton FemaleRadioButton;
        private GroupBox StatusGroupBox;
        private Label GenderLable;
        private LinkLabel BossLinkLabel;
        private DataGridView EmployDataGridView;
    }
}