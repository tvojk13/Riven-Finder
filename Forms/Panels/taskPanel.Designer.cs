namespace Riven_finder
{
    partial class TaskPanel
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
            mainLayout = new TableLayoutPanel();
            infoLayout = new TableLayoutPanel();
            selectLayout = new TableLayoutPanel();
            maxRerollsLabel = new Label();
            maxRerollsNumeric = new NumericUpDown();
            masteryLabel = new Label();
            maxMasteryNumeric = new NumericUpDown();
            polarityLabel = new Label();
            polarityComboBox = new ComboBox();
            userStatusComboBox = new ComboBox();
            userStatusLabel = new Label();
            priceLabel = new Label();
            maxPriceNumeric = new NumericUpDown();
            itemNameComboBox = new ComboBox();
            itemNameLabel = new Label();
            taskNameLabel = new Label();
            taskNameTextBox = new TextBox();
            itemPicture = new PictureBox();
            footerLayout = new TableLayoutPanel();
            cancelButton = new Button();
            rightButton = new Button();
            noteLabel = new Label();
            mainLayout.SuspendLayout();
            infoLayout.SuspendLayout();
            selectLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxRerollsNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxMasteryNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxPriceNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemPicture).BeginInit();
            footerLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(infoLayout, 0, 0);
            mainLayout.Controls.Add(footerLayout, 0, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            mainLayout.Size = new Size(630, 370);
            mainLayout.TabIndex = 2;
            // 
            // infoLayout
            // 
            infoLayout.ColumnCount = 2;
            infoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            infoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            infoLayout.Controls.Add(selectLayout, 0, 0);
            infoLayout.Controls.Add(itemPicture, 1, 0);
            infoLayout.Dock = DockStyle.Fill;
            infoLayout.Location = new Point(3, 3);
            infoLayout.Name = "infoLayout";
            infoLayout.RowCount = 1;
            infoLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            infoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            infoLayout.Size = new Size(624, 290);
            infoLayout.TabIndex = 0;
            // 
            // selectLayout
            // 
            selectLayout.ColumnCount = 2;
            selectLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            selectLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            selectLayout.Controls.Add(maxRerollsLabel, 0, 6);
            selectLayout.Controls.Add(maxRerollsNumeric, 1, 6);
            selectLayout.Controls.Add(masteryLabel, 0, 5);
            selectLayout.Controls.Add(maxMasteryNumeric, 1, 5);
            selectLayout.Controls.Add(polarityLabel, 0, 4);
            selectLayout.Controls.Add(polarityComboBox, 1, 4);
            selectLayout.Controls.Add(userStatusComboBox, 1, 3);
            selectLayout.Controls.Add(userStatusLabel, 0, 3);
            selectLayout.Controls.Add(priceLabel, 0, 2);
            selectLayout.Controls.Add(maxPriceNumeric, 1, 2);
            selectLayout.Controls.Add(itemNameComboBox, 1, 1);
            selectLayout.Controls.Add(itemNameLabel, 0, 1);
            selectLayout.Controls.Add(taskNameLabel, 0, 0);
            selectLayout.Controls.Add(taskNameTextBox, 1, 0);
            selectLayout.Dock = DockStyle.Fill;
            selectLayout.Location = new Point(3, 3);
            selectLayout.Name = "selectLayout";
            selectLayout.RowCount = 7;
            selectLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            selectLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            selectLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            selectLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            selectLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            selectLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            selectLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            selectLayout.Size = new Size(306, 284);
            selectLayout.TabIndex = 0;
            // 
            // maxRerollsLabel
            // 
            maxRerollsLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maxRerollsLabel.AutoSize = true;
            maxRerollsLabel.Location = new Point(3, 252);
            maxRerollsLabel.Name = "maxRerollsLabel";
            maxRerollsLabel.Size = new Size(114, 20);
            maxRerollsLabel.TabIndex = 7;
            maxRerollsLabel.Text = "Max re-rolls:";
            // 
            // maxRerollsNumeric
            // 
            maxRerollsNumeric.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maxRerollsNumeric.Location = new Point(123, 248);
            maxRerollsNumeric.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            maxRerollsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            maxRerollsNumeric.Name = "maxRerollsNumeric";
            maxRerollsNumeric.Size = new Size(180, 27);
            maxRerollsNumeric.TabIndex = 3;
            maxRerollsNumeric.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            // 
            // masteryLabel
            // 
            masteryLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            masteryLabel.AutoSize = true;
            masteryLabel.Location = new Point(3, 210);
            masteryLabel.Name = "masteryLabel";
            masteryLabel.Size = new Size(114, 20);
            masteryLabel.TabIndex = 6;
            masteryLabel.Text = "Max mastery:";
            // 
            // maxMasteryNumeric
            // 
            maxMasteryNumeric.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maxMasteryNumeric.Location = new Point(123, 206);
            maxMasteryNumeric.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            maxMasteryNumeric.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            maxMasteryNumeric.Name = "maxMasteryNumeric";
            maxMasteryNumeric.Size = new Size(180, 27);
            maxMasteryNumeric.TabIndex = 3;
            maxMasteryNumeric.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            // 
            // polarityLabel
            // 
            polarityLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            polarityLabel.AutoSize = true;
            polarityLabel.Location = new Point(3, 170);
            polarityLabel.Name = "polarityLabel";
            polarityLabel.Size = new Size(114, 20);
            polarityLabel.TabIndex = 5;
            polarityLabel.Text = "Polarity:";
            // 
            // polarityComboBox
            // 
            polarityComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            polarityComboBox.FormattingEnabled = true;
            polarityComboBox.Location = new Point(123, 166);
            polarityComboBox.Name = "polarityComboBox";
            polarityComboBox.Size = new Size(180, 28);
            polarityComboBox.TabIndex = 1;
            // 
            // userStatusComboBox
            // 
            userStatusComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            userStatusComboBox.FormattingEnabled = true;
            userStatusComboBox.Location = new Point(123, 126);
            userStatusComboBox.Name = "userStatusComboBox";
            userStatusComboBox.Size = new Size(180, 28);
            userStatusComboBox.TabIndex = 1;
            // 
            // userStatusLabel
            // 
            userStatusLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            userStatusLabel.AutoSize = true;
            userStatusLabel.Location = new Point(3, 130);
            userStatusLabel.Name = "userStatusLabel";
            userStatusLabel.Size = new Size(114, 20);
            userStatusLabel.TabIndex = 4;
            userStatusLabel.Text = "User Status:";
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(3, 90);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(114, 20);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Max price:";
            // 
            // maxPriceNumeric
            // 
            maxPriceNumeric.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maxPriceNumeric.Location = new Point(123, 86);
            maxPriceNumeric.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            maxPriceNumeric.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            maxPriceNumeric.Name = "maxPriceNumeric";
            maxPriceNumeric.Size = new Size(180, 27);
            maxPriceNumeric.TabIndex = 3;
            maxPriceNumeric.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            // 
            // itemNameComboBox
            // 
            itemNameComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            itemNameComboBox.DisplayMember = "item_name";
            itemNameComboBox.FormattingEnabled = true;
            itemNameComboBox.Location = new Point(123, 46);
            itemNameComboBox.Name = "itemNameComboBox";
            itemNameComboBox.Size = new Size(180, 28);
            itemNameComboBox.TabIndex = 1;
            itemNameComboBox.SelectedValueChanged += nameComboBox_SelectedValueChanged;
            // 
            // itemNameLabel
            // 
            itemNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(3, 50);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(114, 20);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Item name:";
            // 
            // taskNameLabel
            // 
            taskNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            taskNameLabel.AutoSize = true;
            taskNameLabel.Location = new Point(3, 10);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new Size(114, 20);
            taskNameLabel.TabIndex = 0;
            taskNameLabel.Text = "Task name:";
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            taskNameTextBox.Location = new Point(123, 6);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(180, 27);
            taskNameTextBox.TabIndex = 8;
            // 
            // itemPicture
            // 
            itemPicture.Dock = DockStyle.Fill;
            itemPicture.Location = new Point(315, 3);
            itemPicture.Name = "itemPicture";
            itemPicture.Size = new Size(306, 284);
            itemPicture.SizeMode = PictureBoxSizeMode.Zoom;
            itemPicture.TabIndex = 1;
            itemPicture.TabStop = false;
            // 
            // footerLayout
            // 
            footerLayout.ColumnCount = 3;
            footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            footerLayout.Controls.Add(cancelButton, 0, 0);
            footerLayout.Controls.Add(rightButton, 2, 0);
            footerLayout.Controls.Add(noteLabel, 1, 0);
            footerLayout.Dock = DockStyle.Fill;
            footerLayout.Location = new Point(3, 299);
            footerLayout.Name = "footerLayout";
            footerLayout.RowCount = 1;
            footerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            footerLayout.Size = new Size(624, 68);
            footerLayout.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Left;
            cancelButton.Location = new Point(3, 13);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(78, 41);
            cancelButton.TabIndex = 0;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            rightButton.Anchor = AnchorStyles.Right;
            rightButton.Location = new Point(542, 13);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(79, 41);
            rightButton.TabIndex = 1;
            rightButton.Text = "#";
            rightButton.UseVisualStyleBackColor = true;
            // 
            // noteLabel
            // 
            noteLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            noteLabel.AutoSize = true;
            noteLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            noteLabel.ForeColor = SystemColors.GrayText;
            noteLabel.Location = new Point(96, 24);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(430, 20);
            noteLabel.TabIndex = 2;
            noteLabel.Text = "Note: set -1 if not important.";
            noteLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaskPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainLayout);
            Name = "TaskPanel";
            Size = new Size(630, 370);
            mainLayout.ResumeLayout(false);
            infoLayout.ResumeLayout(false);
            selectLayout.ResumeLayout(false);
            selectLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxRerollsNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxMasteryNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxPriceNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemPicture).EndInit();
            footerLayout.ResumeLayout(false);
            footerLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public TableLayoutPanel mainLayout;
        public TableLayoutPanel infoLayout;
        public TableLayoutPanel selectLayout;
        public Label maxRerollsLabel;
        public NumericUpDown maxRerollsNumeric;
        public Label masteryLabel;
        public NumericUpDown maxMasteryNumeric;
        public Label polarityLabel;
        public ComboBox polarityComboBox;
        public ComboBox userStatusComboBox;
        public Label userStatusLabel;
        public Label priceLabel;
        public NumericUpDown maxPriceNumeric;
        public ComboBox itemNameComboBox;
        public Label itemNameLabel;
        public Label taskNameLabel;
        public TextBox taskNameTextBox;
        public PictureBox itemPicture;
        public TableLayoutPanel footerLayout;
        public Button cancelButton;
        public Button rightButton;
        public Label noteLabel;
    }
}
