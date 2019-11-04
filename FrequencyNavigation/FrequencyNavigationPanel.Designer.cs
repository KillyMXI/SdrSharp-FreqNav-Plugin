namespace SDRSharp.FrequencyNavigation
{
    partial class FrequencyNavigationPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.stepDownButton = new SDRSharp.FrequencyNavigation.RepeatButton();
            this.stepUpButton = new SDRSharp.FrequencyNavigation.RepeatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.stepSizeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repeatIntervalComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.orderLabel = new System.Windows.Forms.Label();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.decreaseButton = new SDRSharp.FrequencyNavigation.RepeatButton();
            this.increaseButton = new SDRSharp.FrequencyNavigation.RepeatButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveLeftButton.Location = new System.Drawing.Point(3, 27);
            this.moveLeftButton.Name = "moveLeftButton";
            this.tableLayoutPanel3.SetRowSpan(this.moveLeftButton, 2);
            this.moveLeftButton.Size = new System.Drawing.Size(56, 86);
            this.moveLeftButton.TabIndex = 0;
            this.moveLeftButton.Text = "←";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 242);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.stepDownButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.stepUpButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.stepSizeTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.repeatIntervalComboBox, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 126);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(248, 116);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // stepDownButton
            // 
            this.stepDownButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepDownButton.Location = new System.Drawing.Point(3, 16);
            this.stepDownButton.Name = "stepDownButton";
            this.tableLayoutPanel2.SetRowSpan(this.stepDownButton, 4);
            this.stepDownButton.Size = new System.Drawing.Size(56, 97);
            this.stepDownButton.TabIndex = 4;
            this.stepDownButton.Text = "-";
            this.stepDownButton.UseVisualStyleBackColor = true;
            this.stepDownButton.Repeat += new System.EventHandler(this.stepDownButton_Repeat);
            this.stepDownButton.Click += new System.EventHandler(this.stepDownButton_Click);
            // 
            // stepUpButton
            // 
            this.stepUpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepUpButton.Location = new System.Drawing.Point(189, 16);
            this.stepUpButton.Name = "stepUpButton";
            this.tableLayoutPanel2.SetRowSpan(this.stepUpButton, 4);
            this.stepUpButton.Size = new System.Drawing.Size(56, 97);
            this.stepUpButton.TabIndex = 5;
            this.stepUpButton.Text = "+";
            this.stepUpButton.UseVisualStyleBackColor = true;
            this.stepUpButton.Repeat += new System.EventHandler(this.stepUpButton_Repeat);
            this.stepUpButton.Click += new System.EventHandler(this.stepUpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(65, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Step size (Hz)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stepSizeTextBox
            // 
            this.stepSizeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepSizeTextBox.Location = new System.Drawing.Point(65, 16);
            this.stepSizeTextBox.Name = "stepSizeTextBox";
            this.stepSizeTextBox.Size = new System.Drawing.Size(118, 29);
            this.stepSizeTextBox.TabIndex = 6;
            this.stepSizeTextBox.Text = "400k";
            this.stepSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stepSizeTextBox.DoubleClick += new System.EventHandler(this.stepSizeTextBox_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(65, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Autorepeat (ms)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repeatIntervalComboBox
            // 
            this.repeatIntervalComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repeatIntervalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.repeatIntervalComboBox.FormattingEnabled = true;
            this.repeatIntervalComboBox.Items.AddRange(new object[] {
            "25",
            "50",
            "100",
            "250",
            "500",
            "750",
            "1000",
            "1500"});
            this.repeatIntervalComboBox.Location = new System.Drawing.Point(65, 92);
            this.repeatIntervalComboBox.Name = "repeatIntervalComboBox";
            this.repeatIntervalComboBox.Size = new System.Drawing.Size(118, 21);
            this.repeatIntervalComboBox.TabIndex = 9;
            this.repeatIntervalComboBox.SelectedIndexChanged += new System.EventHandler(this.repeatIntervalComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.orderLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.moveRightButton, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.moveLeftButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.decreaseButton, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.increaseButton, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(248, 116);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.orderLabel, 3);
            this.orderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderLabel.Location = new System.Drawing.Point(3, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(242, 24);
            this.orderLabel.TabIndex = 7;
            this.orderLabel.Text = "order";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderLabel.DoubleClick += new System.EventHandler(this.orderLabel_DoubleClick);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveRightButton.Location = new System.Drawing.Point(189, 27);
            this.moveRightButton.Name = "moveRightButton";
            this.tableLayoutPanel3.SetRowSpan(this.moveRightButton, 2);
            this.moveRightButton.Size = new System.Drawing.Size(56, 86);
            this.moveRightButton.TabIndex = 3;
            this.moveRightButton.Text = "→";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // decreaseButton
            // 
            this.decreaseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decreaseButton.Location = new System.Drawing.Point(65, 73);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(118, 40);
            this.decreaseButton.TabIndex = 2;
            this.decreaseButton.Text = "-";
            this.decreaseButton.UseVisualStyleBackColor = true;
            this.decreaseButton.Repeat += new System.EventHandler(this.decreaseButton_Repeat);
            this.decreaseButton.Click += new System.EventHandler(this.decreaseButton_Click);
            // 
            // increaseButton
            // 
            this.increaseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.increaseButton.Location = new System.Drawing.Point(65, 27);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(118, 40);
            this.increaseButton.TabIndex = 1;
            this.increaseButton.Text = "+";
            this.increaseButton.UseVisualStyleBackColor = true;
            this.increaseButton.Repeat += new System.EventHandler(this.increaseButton_Repeat);
            this.increaseButton.Click += new System.EventHandler(this.increaseButton_Click);
            // 
            // FrequencyNavigationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrequencyNavigationPanel";
            this.Size = new System.Drawing.Size(248, 242);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RepeatButton decreaseButton;
        private RepeatButton increaseButton;
        private System.Windows.Forms.Button moveRightButton;
        private RepeatButton stepDownButton;
        private RepeatButton stepUpButton;
        private System.Windows.Forms.TextBox stepSizeTextBox;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox repeatIntervalComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
