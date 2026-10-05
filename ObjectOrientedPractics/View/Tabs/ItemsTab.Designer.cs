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
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SelectedItemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.ItemsTableLayoutPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.SelectedItemTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainTableLayoutPanel.Controls.Add(this.ItemsTableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.SelectedItemTableLayoutPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(800, 500);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsTableLayoutPanel
            // 
            this.ItemsTableLayoutPanel.ColumnCount = 1;
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsLabel, 0, 0);
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsListBox, 0, 1);
            this.ItemsTableLayoutPanel.Controls.Add(this.ButtonsTableLayoutPanel, 0, 2);
            this.ItemsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTableLayoutPanel.Location = new System.Drawing.Point(11, 11);
            this.ItemsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            this.ItemsTableLayoutPanel.RowCount = 3;
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.ItemsTableLayoutPanel.Size = new System.Drawing.Size(305, 478);
            this.ItemsTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(40, 15);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.IntegralHeight = false;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 18);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(299, 413);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.GenerateButton, 2, 0);
            this.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 437);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(299, 38);
            this.ButtonsTableLayoutPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 32);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(102, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(93, 32);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateButton.Location = new System.Drawing.Point(201, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(95, 32);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SelectedItemTableLayoutPanel
            // 
            this.SelectedItemTableLayoutPanel.ColumnCount = 2;
            this.SelectedItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SelectedItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedItemTableLayoutPanel.Controls.Add(this.SelectedItemLabel, 0, 0);
            this.SelectedItemTableLayoutPanel.Controls.Add(this.IdLabel, 0, 1);
            this.SelectedItemTableLayoutPanel.Controls.Add(this.IdTextBox, 1, 1);
            this.SelectedItemTableLayoutPanel.Controls.Add(this.CostLabel, 0, 2);
            this.SelectedItemTableLayoutPanel.Controls.Add(this.CostTextBox, 1, 2);
            this.SelectedItemTableLayoutPanel.Controls.Add(this.NameLabel, 0, 3);
            this.SelectedItemTableLayoutPanel.Controls.Add(this.NameTextBox, 0, 4);
            this.SelectedItemTableLayoutPanel.Controls.Add(this.InfoLabel, 0, 5);
            this.SelectedItemTableLayoutPanel.Controls.Add(this.InfoTextBox, 0, 6);
            this.SelectedItemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemTableLayoutPanel.Location = new System.Drawing.Point(327, 11);
            this.SelectedItemTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3);
            this.SelectedItemTableLayoutPanel.Name = "SelectedItemTableLayoutPanel";
            this.SelectedItemTableLayoutPanel.RowCount = 7;
            this.SelectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SelectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SelectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SelectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SelectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.SelectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SelectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.SelectedItemTableLayoutPanel.Size = new System.Drawing.Size(462, 478);
            this.SelectedItemTableLayoutPanel.TabIndex = 1;
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedItemTableLayoutPanel.SetColumnSpan(this.SelectedItemLabel, 2);
            this.SelectedItemLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedItemLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(81, 15);
            this.SelectedItemLabel.TabIndex = 0;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 25);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 15);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "ID:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdTextBox.Location = new System.Drawing.Point(50, 21);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(140, 23);
            this.IdTextBox.TabIndex = 2;
            // 
            // CostLabel
            // 
            this.CostLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(3, 54);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(34, 15);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CostTextBox.Location = new System.Drawing.Point(50, 50);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(140, 23);
            this.CostTextBox.TabIndex = 4;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.SelectedItemTableLayoutPanel.SetColumnSpan(this.NameLabel, 2);
            this.NameLabel.Location = new System.Drawing.Point(3, 83);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.SelectedItemTableLayoutPanel.SetColumnSpan(this.NameTextBox, 2);
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Location = new System.Drawing.Point(3, 101);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NameTextBox.Size = new System.Drawing.Size(456, 130);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InfoLabel.AutoSize = true;
            this.SelectedItemTableLayoutPanel.SetColumnSpan(this.InfoLabel, 2);
            this.InfoLabel.Location = new System.Drawing.Point(3, 241);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(70, 15);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "Description:";
            // 
            // InfoTextBox
            // 
            this.SelectedItemTableLayoutPanel.SetColumnSpan(this.InfoTextBox, 2);
            this.InfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTextBox.Location = new System.Drawing.Point(3, 259);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoTextBox.Size = new System.Drawing.Size(456, 216);
            this.InfoTextBox.TabIndex = 8;
            this.InfoTextBox.TextChanged += new System.EventHandler(this.InfoTextBox_TextChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(800, 500);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.ItemsTableLayoutPanel.ResumeLayout(false);
            this.ItemsTableLayoutPanel.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.SelectedItemTableLayoutPanel.ResumeLayout(false);
            this.SelectedItemTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ItemsTableLayoutPanel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
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
