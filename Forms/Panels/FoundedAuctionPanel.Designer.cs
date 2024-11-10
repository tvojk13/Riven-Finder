namespace Riven_finder
{
    partial class FoundedAuctionPanel
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ownerPanel = new TableLayoutPanel();
            itemNameLabel = new Label();
            ownerStatusLabel = new Label();
            ownerNameLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            priceLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            mrLabel = new Label();
            ranksLabel = new Label();
            rerollsLabel = new Label();
            polarityLabel = new Label();
            updatedLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ownerPanel.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.313448F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.686554F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(989, 103);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ownerPanel, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(105, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(881, 97);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // ownerPanel
            // 
            ownerPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ownerPanel.ColumnCount = 3;
            ownerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ownerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ownerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ownerPanel.Controls.Add(itemNameLabel, 0, 0);
            ownerPanel.Controls.Add(ownerStatusLabel, 2, 0);
            ownerPanel.Controls.Add(ownerNameLabel, 1, 0);
            ownerPanel.Dock = DockStyle.Fill;
            ownerPanel.Location = new Point(4, 4);
            ownerPanel.Name = "ownerPanel";
            ownerPanel.RowCount = 1;
            ownerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ownerPanel.Size = new Size(873, 25);
            ownerPanel.TabIndex = 0;
            // 
            // itemNameLabel
            // 
            itemNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            itemNameLabel.Location = new Point(4, 2);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(283, 20);
            itemNameLabel.TabIndex = 3;
            itemNameLabel.Text = "itemName";
            itemNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            itemNameLabel.Click += itemNameLabel_Click;
            // 
            // ownerStatusLabel
            // 
            ownerStatusLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ownerStatusLabel.AutoSize = true;
            ownerStatusLabel.Location = new Point(584, 2);
            ownerStatusLabel.Name = "ownerStatusLabel";
            ownerStatusLabel.Size = new Size(285, 20);
            ownerStatusLabel.TabIndex = 2;
            ownerStatusLabel.Text = "ownerStatus";
            ownerStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ownerNameLabel
            // 
            ownerNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ownerNameLabel.AutoSize = true;
            ownerNameLabel.Location = new Point(294, 2);
            ownerNameLabel.Name = "ownerNameLabel";
            ownerNameLabel.Size = new Size(283, 20);
            ownerNameLabel.TabIndex = 1;
            ownerNameLabel.Text = "ownerName";
            ownerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.69697F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.30303F));
            tableLayoutPanel4.Controls.Add(priceLabel, 1, 0);
            tableLayoutPanel4.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 68);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(873, 25);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(827, 1);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(42, 20);
            priceLabel.TabIndex = 1;
            priceLabel.Text = "price";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(1, 1);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(780, 23);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.Controls.Add(mrLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(ranksLabel, 1, 0);
            tableLayoutPanel5.Controls.Add(rerollsLabel, 2, 0);
            tableLayoutPanel5.Controls.Add(polarityLabel, 3, 0);
            tableLayoutPanel5.Controls.Add(updatedLabel, 4, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(4, 36);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(873, 25);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // mrLabel
            // 
            mrLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mrLabel.AutoSize = true;
            mrLabel.Location = new Point(4, 2);
            mrLabel.Name = "mrLabel";
            mrLabel.Size = new Size(167, 20);
            mrLabel.TabIndex = 4;
            mrLabel.Text = "Mr. ";
            mrLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ranksLabel
            // 
            ranksLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ranksLabel.AutoSize = true;
            ranksLabel.Location = new Point(178, 2);
            ranksLabel.Name = "ranksLabel";
            ranksLabel.Size = new Size(167, 20);
            ranksLabel.TabIndex = 5;
            ranksLabel.Text = "Ranks: ";
            ranksLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rerollsLabel
            // 
            rerollsLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rerollsLabel.AutoSize = true;
            rerollsLabel.Location = new Point(352, 2);
            rerollsLabel.Name = "rerollsLabel";
            rerollsLabel.Size = new Size(167, 20);
            rerollsLabel.TabIndex = 6;
            rerollsLabel.Text = "Re-rolls: ";
            rerollsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // polarityLabel
            // 
            polarityLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            polarityLabel.AutoSize = true;
            polarityLabel.Location = new Point(526, 2);
            polarityLabel.Name = "polarityLabel";
            polarityLabel.Size = new Size(167, 20);
            polarityLabel.TabIndex = 7;
            polarityLabel.Text = "polarity";
            polarityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // updatedLabel
            // 
            updatedLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            updatedLabel.AutoSize = true;
            updatedLabel.Location = new Point(700, 2);
            updatedLabel.Name = "updatedLabel";
            updatedLabel.Size = new Size(169, 20);
            updatedLabel.TabIndex = 0;
            updatedLabel.Text = "updated";
            updatedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FoundedAuctionPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FoundedAuctionPanel";
            Size = new Size(989, 103);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ownerPanel.ResumeLayout(false);
            ownerPanel.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel ownerPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private Label updatedLabel;
        private Label ownerNameLabel;
        private Label ownerStatusLabel;
        private Label priceLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label itemNameLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label mrLabel;
        private Label ranksLabel;
        private Label rerollsLabel;
        private Label polarityLabel;
    }
}
