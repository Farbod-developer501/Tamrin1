namespace Tamrin1
{
    partial class AdminForm
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
            AdNmTXtBox = new TextBox();
            LNTxtBox = new TextBox();
            PHTxtBox = new TextBox();
            AdNcTxtBox = new TextBox();
            ManagmentCodeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ADSubmitButton = new Button();
            StatusGroupBox = new GroupBox();
            FemaleRadioButton = new RadioButton();
            MaleRadioButton = new RadioButton();
            GenderLable = new Label();
            linkLabel1 = new LinkLabel();
            AdminDataGridveiw = new DataGridView();
            StatusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminDataGridveiw).BeginInit();
            SuspendLayout();
            // 
            // AdNmTXtBox
            // 
            AdNmTXtBox.Location = new Point(220, 12);
            AdNmTXtBox.Multiline = true;
            AdNmTXtBox.Name = "AdNmTXtBox";
            AdNmTXtBox.Size = new Size(555, 34);
            AdNmTXtBox.TabIndex = 0;
            // 
            // LNTxtBox
            // 
            LNTxtBox.Location = new Point(220, 52);
            LNTxtBox.Multiline = true;
            LNTxtBox.Name = "LNTxtBox";
            LNTxtBox.Size = new Size(555, 34);
            LNTxtBox.TabIndex = 0;
            // 
            // PHTxtBox
            // 
            PHTxtBox.Location = new Point(220, 92);
            PHTxtBox.Multiline = true;
            PHTxtBox.Name = "PHTxtBox";
            PHTxtBox.Size = new Size(555, 34);
            PHTxtBox.TabIndex = 0;
            // 
            // AdNcTxtBox
            // 
            AdNcTxtBox.Location = new Point(220, 130);
            AdNcTxtBox.Multiline = true;
            AdNcTxtBox.Name = "AdNcTxtBox";
            AdNcTxtBox.Size = new Size(555, 34);
            AdNcTxtBox.TabIndex = 0;
            // 
            // ManagmentCodeTextBox
            // 
            ManagmentCodeTextBox.Location = new Point(220, 170);
            ManagmentCodeTextBox.Multiline = true;
            ManagmentCodeTextBox.Name = "ManagmentCodeTextBox";
            ManagmentCodeTextBox.Size = new Size(555, 34);
            ManagmentCodeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 66);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Lastname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 106);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 3;
            label3.Text = "PhoneNumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 144);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 4;
            label4.Text = "NationalCode";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 173);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 5;
            label5.Text = "ManagementCode";
            // 
            // ADSubmitButton
            // 
            ADSubmitButton.Location = new Point(51, 366);
            ADSubmitButton.Name = "ADSubmitButton";
            ADSubmitButton.Size = new Size(128, 58);
            ADSubmitButton.TabIndex = 7;
            ADSubmitButton.Text = "Submit";
            ADSubmitButton.UseVisualStyleBackColor = true;
            ADSubmitButton.Click += ADSubmitButton_Click;
            // 
            // StatusGroupBox
            // 
            StatusGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatusGroupBox.Controls.Add(FemaleRadioButton);
            StatusGroupBox.Controls.Add(MaleRadioButton);
            StatusGroupBox.Location = new Point(34, 242);
            StatusGroupBox.Name = "StatusGroupBox";
            StatusGroupBox.RightToLeft = RightToLeft.Yes;
            StatusGroupBox.Size = new Size(179, 52);
            StatusGroupBox.TabIndex = 13;
            StatusGroupBox.TabStop = false;
            StatusGroupBox.Text = "Gender";
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
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Cursor = Cursors.Hand;
            MaleRadioButton.Location = new Point(17, 22);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(63, 24);
            MaleRadioButton.TabIndex = 9;
            MaleRadioButton.Text = "Male";
            MaleRadioButton.TextAlign = ContentAlignment.TopCenter;
            MaleRadioButton.UseVisualStyleBackColor = true;
            MaleRadioButton.CheckedChanged += MaleRadioButton_CheckedChanged;
            // 
            // GenderLable
            // 
            GenderLable.AutoSize = true;
            GenderLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            GenderLable.Location = new Point(75, 297);
            GenderLable.Name = "GenderLable";
            GenderLable.Size = new Size(91, 31);
            GenderLable.TabIndex = 14;
            GenderLable.Text = "Gender";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(64, 328);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(120, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I am regular user";
            // 
            // AdminDataGridveiw
            // 
            AdminDataGridveiw.BackgroundColor = Color.White;
            AdminDataGridveiw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminDataGridveiw.Location = new Point(220, 210);
            AdminDataGridveiw.Name = "AdminDataGridveiw";
            AdminDataGridveiw.RowHeadersWidth = 51;
            AdminDataGridveiw.RowTemplate.Height = 29;
            AdminDataGridveiw.Size = new Size(555, 235);
            AdminDataGridveiw.TabIndex = 15;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(AdminDataGridveiw);
            Controls.Add(linkLabel1);
            Controls.Add(GenderLable);
            Controls.Add(StatusGroupBox);
            Controls.Add(ADSubmitButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ManagmentCodeTextBox);
            Controls.Add(AdNcTxtBox);
            Controls.Add(PHTxtBox);
            Controls.Add(LNTxtBox);
            Controls.Add(AdNmTXtBox);
            Name = "AdminForm";
            Text = "AdminForm";
            StatusGroupBox.ResumeLayout(false);
            StatusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminDataGridveiw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AdNmTXtBox;
        private TextBox LNTxtBox;
        private TextBox PHTxtBox;
        private TextBox AdNcTxtBox;
        private TextBox ManagmentCodeTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button ADSubmitButton;
        private GroupBox StatusGroupBox;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
        private Label GenderLable;
        private LinkLabel linkLabel1;
        private DataGridView AdminDataGridveiw;
    }
}