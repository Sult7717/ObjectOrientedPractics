#nullable disable
namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            MainTableLayoutPanel = new TableLayoutPanel();
            ItemsTableLayoutPanel = new TableLayoutPanel();
            ItemsLabel = new Label();
            ItemsListBox = new ListBox();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            AddButton = new Button();
            RemoveButton = new Button();
            EditButton = new Button();
            GenerateButton = new Button();
            SelectedItemTableLayoutPanel = new TableLayoutPanel();
            SelectedItemLabel = new Label();
            IdLabel = new Label();
            IdTextBox = new TextBox();
            CostLabel = new Label();
            CostTextBox = new TextBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            InfoLabel = new Label();
            InfoTextBox = new TextBox();
            MainTableLayoutPanel.SuspendLayout();
            ItemsTableLayoutPanel.SuspendLayout();
            ButtonsTableLayoutPanel.SuspendLayout();
            SelectedItemTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MainTableLayoutPanel.Controls.Add(ItemsTableLayoutPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(SelectedItemTableLayoutPanel, 1, 0);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.Padding = new Padding(9, 11, 9, 11);
            MainTableLayoutPanel.RowCount = 1;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Size = new Size(914, 667);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsTableLayoutPanel
            // 
            ItemsTableLayoutPanel.ColumnCount = 1;
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ItemsTableLayoutPanel.Controls.Add(ItemsLabel, 0, 0);
            ItemsTableLayoutPanel.Controls.Add(ItemsListBox, 0, 1);
            ItemsTableLayoutPanel.Controls.Add(ButtonsTableLayoutPanel, 0, 2);
            ItemsTableLayoutPanel.Dock = DockStyle.Fill;
            ItemsTableLayoutPanel.Location = new Point(12, 15);
            ItemsTableLayoutPanel.Margin = new Padding(3, 4, 9, 4);
            ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            ItemsTableLayoutPanel.RowCount = 3;
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle());
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            ItemsTableLayoutPanel.Size = new Size(346, 637);
            ItemsTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ItemsLabel.Location = new Point(3, 0);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(49, 20);
            ItemsLabel.TabIndex = 0;
            ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Dock = DockStyle.Top;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.IntegralHeight = false;
            ItemsListBox.Location = new Point(3, 24);
            ItemsListBox.Margin = new Padding(3, 4, 3, 4);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(340, 550);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // ButtonsTableLayoutPanel
            // 
            ButtonsTableLayoutPanel.ColumnCount = 4;
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsTableLayoutPanel.Controls.Add(AddButton, 0, 0);
            ButtonsTableLayoutPanel.Controls.Add(RemoveButton, 1, 0);
            ButtonsTableLayoutPanel.Controls.Add(EditButton, 2, 0);
            ButtonsTableLayoutPanel.Controls.Add(GenerateButton, 3, 0);
            ButtonsTableLayoutPanel.Dock = DockStyle.Fill;
            ButtonsTableLayoutPanel.Location = new Point(3, 582);
            ButtonsTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            ButtonsTableLayoutPanel.RowCount = 1;
            ButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsTableLayoutPanel.Size = new Size(340, 51);
            ButtonsTableLayoutPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 4);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(79, 43);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(88, 4);
            RemoveButton.Margin = new Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(79, 43);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // EditButton
            // 
            EditButton.Dock = DockStyle.Fill;
            EditButton.Location = new Point(173, 4);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(79, 43);
            EditButton.TabIndex = 2;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // GenerateButton
            // 
            GenerateButton.Dock = DockStyle.Fill;
            GenerateButton.Location = new Point(258, 4);
            GenerateButton.Margin = new Padding(3, 4, 3, 4);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(79, 43);
            GenerateButton.TabIndex = 3;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // SelectedItemTableLayoutPanel
            // 
            SelectedItemTableLayoutPanel.ColumnCount = 2;
            SelectedItemTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            SelectedItemTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SelectedItemTableLayoutPanel.Controls.Add(SelectedItemLabel, 0, 0);
            SelectedItemTableLayoutPanel.Controls.Add(IdLabel, 0, 1);
            SelectedItemTableLayoutPanel.Controls.Add(IdTextBox, 1, 1);
            SelectedItemTableLayoutPanel.Controls.Add(CostLabel, 0, 2);
            SelectedItemTableLayoutPanel.Controls.Add(CostTextBox, 1, 2);
            SelectedItemTableLayoutPanel.Controls.Add(NameLabel, 0, 3);
            SelectedItemTableLayoutPanel.Controls.Add(NameTextBox, 0, 4);
            SelectedItemTableLayoutPanel.Controls.Add(InfoLabel, 0, 5);
            SelectedItemTableLayoutPanel.Controls.Add(InfoTextBox, 0, 6);
            SelectedItemTableLayoutPanel.Dock = DockStyle.Fill;
            SelectedItemTableLayoutPanel.Location = new Point(370, 15);
            SelectedItemTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            SelectedItemTableLayoutPanel.Name = "SelectedItemTableLayoutPanel";
            SelectedItemTableLayoutPanel.RowCount = 7;
            SelectedItemTableLayoutPanel.RowStyles.Add(new RowStyle());
            SelectedItemTableLayoutPanel.RowStyles.Add(new RowStyle());
            SelectedItemTableLayoutPanel.RowStyles.Add(new RowStyle());
            SelectedItemTableLayoutPanel.RowStyles.Add(new RowStyle());
            SelectedItemTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            SelectedItemTableLayoutPanel.RowStyles.Add(new RowStyle());
            SelectedItemTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            SelectedItemTableLayoutPanel.Size = new Size(532, 637);
            SelectedItemTableLayoutPanel.TabIndex = 1;
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.Anchor = AnchorStyles.Left;
            SelectedItemLabel.AutoSize = true;
            SelectedItemTableLayoutPanel.SetColumnSpan(SelectedItemLabel, 2);
            SelectedItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectedItemLabel.Location = new Point(3, 0);
            SelectedItemLabel.Margin = new Padding(3, 0, 3, 8);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(104, 20);
            SelectedItemLabel.TabIndex = 0;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // IdLabel
            // 
            IdLabel.Anchor = AnchorStyles.Left;
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 35);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Left;
            IdTextBox.Location = new Point(50, 32);
            IdTextBox.Margin = new Padding(3, 4, 3, 4);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(159, 27);
            IdTextBox.TabIndex = 2;
            // 
            // CostLabel
            // 
            CostLabel.Anchor = AnchorStyles.Left;
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(3, 70);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(41, 20);
            CostLabel.TabIndex = 3;
            CostLabel.Text = "Cost:";
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Left;
            CostTextBox.Location = new Point(50, 67);
            CostTextBox.Margin = new Padding(3, 4, 3, 4);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(159, 27);
            CostTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Left;
            NameLabel.AutoSize = true;
            SelectedItemTableLayoutPanel.SetColumnSpan(NameLabel, 2);
            NameLabel.Location = new Point(3, 98);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            SelectedItemTableLayoutPanel.SetColumnSpan(NameTextBox, 2);
            NameTextBox.Dock = DockStyle.Fill;
            NameTextBox.Location = new Point(3, 122);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ScrollBars = ScrollBars.Vertical;
            NameTextBox.Size = new Size(526, 166);
            NameTextBox.TabIndex = 6;
            // 
            // InfoLabel
            // 
            InfoLabel.Anchor = AnchorStyles.Left;
            InfoLabel.AutoSize = true;
            SelectedItemTableLayoutPanel.SetColumnSpan(InfoLabel, 2);
            InfoLabel.Location = new Point(3, 292);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(88, 20);
            InfoLabel.TabIndex = 7;
            InfoLabel.Text = "Description:";
            // 
            // InfoTextBox
            // 
            SelectedItemTableLayoutPanel.SetColumnSpan(InfoTextBox, 2);
            InfoTextBox.Dock = DockStyle.Top;
            InfoTextBox.Location = new Point(3, 316);
            InfoTextBox.Margin = new Padding(3, 4, 3, 4);
            InfoTextBox.Multiline = true;
            InfoTextBox.Name = "InfoTextBox";
            InfoTextBox.ScrollBars = ScrollBars.Vertical;
            InfoTextBox.Size = new Size(526, 317);
            InfoTextBox.TabIndex = 8;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTableLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItemsTab";
            Size = new Size(914, 667);
            MainTableLayoutPanel.ResumeLayout(false);
            ItemsTableLayoutPanel.ResumeLayout(false);
            ItemsTableLayoutPanel.PerformLayout();
            ButtonsTableLayoutPanel.ResumeLayout(false);
            SelectedItemTableLayoutPanel.ResumeLayout(false);
            SelectedItemTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ItemsTableLayoutPanel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TableLayoutPanel SelectedItemTableLayoutPanel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox InfoTextBox;
    }
}