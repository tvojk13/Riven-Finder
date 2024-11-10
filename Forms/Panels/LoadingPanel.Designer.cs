namespace Riven_finder
{
    partial class LoadingPanel
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
            loadingLabel = new Label();
            progressBarLoading = new ProgressBar();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(loadingLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(progressBarLoading, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(220, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // loadingLabel
            // 
            loadingLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loadingLabel.AutoSize = true;
            loadingLabel.Location = new Point(3, 27);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.Size = new Size(214, 20);
            loadingLabel.TabIndex = 0;
            loadingLabel.Text = "Loading";
            loadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBarLoading
            // 
            progressBarLoading.Dock = DockStyle.Fill;
            progressBarLoading.Location = new Point(3, 3);
            progressBarLoading.Name = "progressBarLoading";
            progressBarLoading.Size = new Size(214, 19);
            progressBarLoading.Style = ProgressBarStyle.Marquee;
            progressBarLoading.TabIndex = 1;
            // 
            // LoadingPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 50);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingPanel";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label loadingLabel;
        private ProgressBar progressBarLoading;
    }
}
