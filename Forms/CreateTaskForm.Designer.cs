namespace Riven_finder
{
    partial class CreateTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTaskForm));
            this.taskPanel = new TaskPanel();
            SuspendLayout();
            // 
            // taskPanel
            // 
            this.taskPanel.Name = "taskPanel";
            // 
            // CreateTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 370);
            Controls.Add(this.taskPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTaskForm";
            Text = "CreateTask";
            ResumeLayout(false);
        }

        #endregion

        private TaskPanel taskPanel;
    }
}