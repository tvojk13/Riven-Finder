using System.Windows.Forms;

namespace Riven_finder
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainLayout = new TableLayoutPanel();
            headerPanel = new TableLayoutPanel();
            controlLayout = new TableLayoutPanel();
            createTask = new Button();
            totalTasks = new Label();
            totalLabel = new Label();
            tasksDataGrid = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            priceColumn = new DataGridViewTextBoxColumn();
            statusColumn = new DataGridViewTextBoxColumn();
            picColumn = new DataGridViewImageColumn();
            runColumn = new DataGridViewImageColumn();
            pauseColumn = new DataGridViewImageColumn();
            editColumn = new DataGridViewImageColumn();
            deleteColumn = new DataGridViewImageColumn();
            tasksBindingSource = new BindingSource(components);
            mainLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            controlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tasksDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tasksBindingSource).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(headerPanel, 0, 0);
            mainLayout.Controls.Add(tasksDataGrid, 0, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            mainLayout.Size = new Size(767, 453);
            mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.ColumnCount = 3;
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 473F));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            headerPanel.ColumnStyles.Add(new ColumnStyle());
            headerPanel.Controls.Add(controlLayout, 3, 0);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.RowCount = 1;
            headerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            headerPanel.Size = new Size(761, 52);
            headerPanel.TabIndex = 0;
            // 
            // controlLayout
            // 
            controlLayout.ColumnCount = 3;
            controlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            controlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            controlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
            controlLayout.Controls.Add(createTask, 0, 0);
            controlLayout.Controls.Add(totalTasks, 2, 0);
            controlLayout.Controls.Add(totalLabel, 1, 0);
            controlLayout.Dock = DockStyle.Fill;
            controlLayout.Location = new Point(594, 3);
            controlLayout.Name = "controlLayout";
            controlLayout.RowCount = 1;
            controlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlLayout.Size = new Size(164, 46);
            controlLayout.TabIndex = 6;
            // 
            // createTask
            // 
            createTask.Anchor = AnchorStyles.Right;
            createTask.Location = new Point(5, 8);
            createTask.Name = "createTask";
            createTask.Size = new Size(29, 29);
            createTask.TabIndex = 2;
            createTask.Text = "+";
            createTask.UseVisualStyleBackColor = true;
            createTask.Click += createTask_Click;
            // 
            // totalTasks
            // 
            totalTasks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalTasks.AutoSize = true;
            totalTasks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            totalTasks.Location = new Point(94, 13);
            totalTasks.Name = "totalTasks";
            totalTasks.Size = new Size(67, 20);
            totalTasks.TabIndex = 5;
            totalTasks.Text = "#";
            totalTasks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(43, 13);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(45, 20);
            totalLabel.TabIndex = 3;
            totalLabel.Text = "Total:";
            // 
            // tasksDataGrid
            // 
            tasksDataGrid.AutoGenerateColumns = false;
            tasksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tasksDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tasksDataGrid.ColumnHeadersHeight = 30;
            tasksDataGrid.Columns.AddRange(new DataGridViewColumn[] { idColumn, nameColumn, priceColumn, statusColumn, picColumn, runColumn, pauseColumn, editColumn, deleteColumn });
            tasksDataGrid.DataSource = tasksBindingSource;
            tasksDataGrid.Dock = DockStyle.Fill;
            tasksDataGrid.Location = new Point(3, 61);
            tasksDataGrid.MultiSelect = false;
            tasksDataGrid.Name = "tasksDataGrid";
            tasksDataGrid.ReadOnly = true;
            tasksDataGrid.RowHeadersVisible = false;
            tasksDataGrid.RowHeadersWidth = 51;
            tasksDataGrid.RowTemplate.Height = 64;
            tasksDataGrid.Size = new Size(761, 389);
            tasksDataGrid.TabIndex = 1;
            tasksDataGrid.CellClick += tasksDataGrid_CellClick;
            tasksDataGrid.CellDoubleClick += tasksDataGrid_CellDoubleClick;
            tasksDataGrid.CellFormatting += tasksDataGrid_CellFormatting;
            // 
            // idColumn
            // 
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "ID";
            idColumn.MinimumWidth = 40;
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            idColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            idColumn.Width = 53;
            // 
            // nameColumn
            // 
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameColumn.DataPropertyName = "TaskName";
            nameColumn.HeaderText = "Name";
            nameColumn.MinimumWidth = 220;
            nameColumn.Name = "nameColumn";
            nameColumn.ReadOnly = true;
            nameColumn.Width = 220;
            // 
            // priceColumn
            // 
            priceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            priceColumn.DataPropertyName = "MaxPrice";
            priceColumn.HeaderText = "Price";
            priceColumn.MinimumWidth = 85;
            priceColumn.Name = "priceColumn";
            priceColumn.ReadOnly = true;
            priceColumn.Width = 85;
            // 
            // statusColumn
            // 
            statusColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            statusColumn.DataPropertyName = "Status";
            statusColumn.HeaderText = "Status";
            statusColumn.MinimumWidth = 6;
            statusColumn.Name = "statusColumn";
            statusColumn.ReadOnly = true;
            statusColumn.Width = 78;
            // 
            // picColumn
            // 
            picColumn.DataPropertyName = "ItemImage";
            picColumn.HeaderText = "Picture";
            picColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            picColumn.MinimumWidth = 64;
            picColumn.Name = "picColumn";
            picColumn.ReadOnly = true;
            // 
            // runColumn
            // 
            runColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            runColumn.HeaderText = "Run";
            runColumn.Image = Properties.Resources.run;
            runColumn.MinimumWidth = 64;
            runColumn.Name = "runColumn";
            runColumn.ReadOnly = true;
            runColumn.Resizable = DataGridViewTriState.False;
            runColumn.Width = 64;
            // 
            // pauseColumn
            // 
            pauseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pauseColumn.HeaderText = "Pause";
            pauseColumn.Image = Properties.Resources.pause;
            pauseColumn.MinimumWidth = 64;
            pauseColumn.Name = "pauseColumn";
            pauseColumn.ReadOnly = true;
            pauseColumn.Resizable = DataGridViewTriState.False;
            pauseColumn.Width = 64;
            // 
            // editColumn
            // 
            editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            editColumn.HeaderText = "Edit";
            editColumn.Image = Properties.Resources.edit;
            editColumn.MinimumWidth = 64;
            editColumn.Name = "editColumn";
            editColumn.ReadOnly = true;
            editColumn.Resizable = DataGridViewTriState.False;
            editColumn.Width = 64;
            // 
            // deleteColumn
            // 
            deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Image = Properties.Resources.delete;
            deleteColumn.MinimumWidth = 64;
            deleteColumn.Name = "deleteColumn";
            deleteColumn.ReadOnly = true;
            deleteColumn.Resizable = DataGridViewTriState.False;
            deleteColumn.Width = 64;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 453);
            Controls.Add(mainLayout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(785, 200);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riven finder";
            mainLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            controlLayout.ResumeLayout(false);
            controlLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tasksDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)tasksBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel headerPanel;
        private DataGridView tasksDataGrid;
        private Button createTask;
        private Label totalLabel;
        private BindingSource tasksBindingSource;
        private TableLayoutPanel controlLayout;
        private Label totalTasks;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn priceColumn;
        private DataGridViewTextBoxColumn statusColumn;
        private DataGridViewImageColumn picColumn;
        private DataGridViewImageColumn runColumn;
        private DataGridViewImageColumn pauseColumn;
        private DataGridViewImageColumn editColumn;
        private DataGridViewImageColumn deleteColumn;
    }
}
