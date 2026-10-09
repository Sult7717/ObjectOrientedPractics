#nullable disable
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.CustomersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.RightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedCustomerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.FullnameTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ReservedPanel = new System.Windows.Forms.Panel();
            this.MainTableLayoutPanel.SuspendLayout();
            this.CustomersTableLayoutPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.RightTableLayoutPanel.SuspendLayout();
            this.SelectedCustomerTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainTableLayoutPanel.Controls.Add(this.CustomersTableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.RightTableLayoutPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(800, 500);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // CustomersTableLayoutPanel
            // 
            this.CustomersTableLayoutPanel.ColumnCount = 1;
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersLabel, 0, 0);
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersListBox, 0, 1);
            this.CustomersTableLayoutPanel.Controls.Add(this.ButtonsTableLayoutPanel, 0, 2);
            this.CustomersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTableLayoutPanel.Location = new System.Drawing.Point(11, 11);
            this.CustomersTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            this.CustomersTableLayoutPanel.RowCount = 3;
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.CustomersTableLayoutPanel.Size = new System.Drawing.Size(305, 478);
            this.CustomersTableLayoutPanel.TabIndex = 0;
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersLabel.Location = new System.Drawing.Point(3, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(66, 15);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.IntegralHeight = false;
            this.CustomersListBox.ItemHeight = 15;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 18);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(299, 413);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 4;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.GenerateButton, 3, 0);
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
            this.AddButton.Size = new System.Drawing.Size(68, 32);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(77, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(68, 32);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditButton.Location = new System.Drawing.Point(151, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(68, 32);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateButton.Location = new System.Drawing.Point(225, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(71, 32);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // RightTableLayoutPanel
            // 
            this.RightTableLayoutPanel.ColumnCount = 1;
            this.RightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightTableLayoutPanel.Controls.Add(this.SelectedCustomerTableLayoutPanel, 0, 0);
            this.RightTableLayoutPanel.Controls.Add(this.ReservedPanel, 0, 1);
            this.RightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightTableLayoutPanel.Location = new System.Drawing.Point(327, 11);
            this.RightTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3);
            this.RightTableLayoutPanel.Name = "RightTableLayoutPanel";
            this.RightTableLayoutPanel.RowCount = 2;
            this.RightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.RightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.RightTableLayoutPanel.Size = new System.Drawing.Size(462, 478);
            this.RightTableLayoutPanel.TabIndex = 1;
            // 
            // SelectedCustomerTableLayoutPanel
            // 
            this.SelectedCustomerTableLayoutPanel.ColumnCount = 2;
            this.SelectedCustomerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SelectedCustomerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.SelectedCustomerLabel, 0, 0);
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.IdLabel, 0, 1);
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.IdTextBox, 1, 1);
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.FullnameLabel, 0, 2);
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.FullnameTextBox, 1, 2);
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.AddressLabel, 0, 3);
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.AddressTextBox, 1, 3);
            this.SelectedCustomerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedCustomerTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.SelectedCustomerTableLayoutPanel.Name = "SelectedCustomerTableLayoutPanel";
            this.SelectedCustomerTableLayoutPanel.RowCount = 4;
            this.SelectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SelectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SelectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SelectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedCustomerTableLayoutPanel.Size = new System.Drawing.Size(456, 185);
            this.SelectedCustomerTableLayoutPanel.TabIndex = 0;
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerTableLayoutPanel.SetColumnSpan(this.SelectedCustomerLabel, 2);
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedCustomerLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(105, 15);
            this.SelectedCustomerLabel.TabIndex = 0;
            this.SelectedCustomerLabel.Text = "Selected Customer";
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
            this.IdTextBox.Location = new System.Drawing.Point(72, 21);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(140, 23);
            this.IdTextBox.TabIndex = 2;
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.Location = new System.Drawing.Point(3, 54);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(63, 15);
            this.FullnameLabel.TabIndex = 3;
            this.FullnameLabel.Text = "Full Name:";
            // 
            // FullnameTextBox
            // 
            this.FullnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullnameTextBox.Location = new System.Drawing.Point(72, 50);
            this.FullnameTextBox.Name = "FullnameTextBox";
            this.FullnameTextBox.Size = new System.Drawing.Size(381, 23);
            this.FullnameTextBox.TabIndex = 4;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(3, 82);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(52, 15);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressTextBox.Location = new System.Drawing.Point(72, 79);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddressTextBox.Size = new System.Drawing.Size(381, 103);
            this.AddressTextBox.TabIndex = 6;
            // 
            // ReservedPanel
            // 
            this.ReservedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservedPanel.Location = new System.Drawing.Point(3, 194);
            this.ReservedPanel.Name = "ReservedPanel";
            this.ReservedPanel.Size = new System.Drawing.Size(456, 281);
            this.ReservedPanel.TabIndex = 1;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(800, 500);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.CustomersTableLayoutPanel.ResumeLayout(false);
            this.CustomersTableLayoutPanel.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.RightTableLayoutPanel.ResumeLayout(false);
            this.SelectedCustomerTableLayoutPanel.ResumeLayout(false);
            this.SelectedCustomerTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel CustomersTableLayoutPanel;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TableLayoutPanel RightTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel SelectedCustomerTableLayoutPanel;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.TextBox FullnameTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Panel ReservedPanel;
    }
}