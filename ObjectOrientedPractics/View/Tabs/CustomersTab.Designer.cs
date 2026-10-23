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
            MainTableLayoutPanel = new TableLayoutPanel();
            CustomersTableLayoutPanel = new TableLayoutPanel();
            CustomersLabel = new Label();
            CustomersListBox = new ListBox();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            AddButton = new Button();
            RemoveButton = new Button();
            EditButton = new Button();
            GenerateButton = new Button();
            RightTableLayoutPanel = new TableLayoutPanel();
            SelectedCustomerTableLayoutPanel = new TableLayoutPanel();
            SelectedCustomerLabel = new Label();
            IdLabel = new Label();
            IdTextBox = new TextBox();
            FullnameLabel = new Label();
            FullnameTextBox = new TextBox();
            AddressLabel = new Label();
            AddressTextBox = new TextBox();
            ReservedPanel = new Panel();
            MainTableLayoutPanel.SuspendLayout();
            CustomersTableLayoutPanel.SuspendLayout();
            ButtonsTableLayoutPanel.SuspendLayout();
            RightTableLayoutPanel.SuspendLayout();
            SelectedCustomerTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MainTableLayoutPanel.Controls.Add(CustomersTableLayoutPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(RightTableLayoutPanel, 1, 0);
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
            // CustomersTableLayoutPanel
            // 
            CustomersTableLayoutPanel.ColumnCount = 1;
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CustomersTableLayoutPanel.Controls.Add(CustomersLabel, 0, 0);
            CustomersTableLayoutPanel.Controls.Add(CustomersListBox, 0, 1);
            CustomersTableLayoutPanel.Controls.Add(ButtonsTableLayoutPanel, 0, 2);
            CustomersTableLayoutPanel.Dock = DockStyle.Fill;
            CustomersTableLayoutPanel.Location = new Point(12, 15);
            CustomersTableLayoutPanel.Margin = new Padding(3, 4, 9, 4);
            CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            CustomersTableLayoutPanel.RowCount = 3;
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle());
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            CustomersTableLayoutPanel.Size = new Size(346, 637);
            CustomersTableLayoutPanel.TabIndex = 0;
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CustomersLabel.Location = new Point(3, 0);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(84, 20);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            CustomersListBox.Dock = DockStyle.Fill;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.IntegralHeight = false;
            CustomersListBox.Location = new Point(3, 24);
            CustomersListBox.Margin = new Padding(3, 4, 3, 4);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(340, 550);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
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
            // RightTableLayoutPanel
            // 
            RightTableLayoutPanel.ColumnCount = 1;
            RightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            RightTableLayoutPanel.Controls.Add(SelectedCustomerTableLayoutPanel, 0, 0);
            RightTableLayoutPanel.Controls.Add(ReservedPanel, 0, 1);
            RightTableLayoutPanel.Dock = DockStyle.Fill;
            RightTableLayoutPanel.Location = new Point(370, 15);
            RightTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            RightTableLayoutPanel.Name = "RightTableLayoutPanel";
            RightTableLayoutPanel.RowCount = 2;
            RightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            RightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            RightTableLayoutPanel.Size = new Size(532, 637);
            RightTableLayoutPanel.TabIndex = 1;
            // 
            // SelectedCustomerTableLayoutPanel
            // 
            SelectedCustomerTableLayoutPanel.ColumnCount = 2;
            SelectedCustomerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            SelectedCustomerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SelectedCustomerTableLayoutPanel.Controls.Add(SelectedCustomerLabel, 0, 0);
            SelectedCustomerTableLayoutPanel.Controls.Add(IdLabel, 0, 1);
            SelectedCustomerTableLayoutPanel.Controls.Add(IdTextBox, 1, 1);
            SelectedCustomerTableLayoutPanel.Controls.Add(FullnameLabel, 0, 2);
            SelectedCustomerTableLayoutPanel.Controls.Add(FullnameTextBox, 1, 2);
            SelectedCustomerTableLayoutPanel.Controls.Add(AddressLabel, 0, 3);
            SelectedCustomerTableLayoutPanel.Controls.Add(AddressTextBox, 1, 3);
            SelectedCustomerTableLayoutPanel.Dock = DockStyle.Fill;
            SelectedCustomerTableLayoutPanel.Location = new Point(3, 4);
            SelectedCustomerTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            SelectedCustomerTableLayoutPanel.Name = "SelectedCustomerTableLayoutPanel";
            SelectedCustomerTableLayoutPanel.RowCount = 4;
            SelectedCustomerTableLayoutPanel.RowStyles.Add(new RowStyle());
            SelectedCustomerTableLayoutPanel.RowStyles.Add(new RowStyle());
            SelectedCustomerTableLayoutPanel.RowStyles.Add(new RowStyle());
            SelectedCustomerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            SelectedCustomerTableLayoutPanel.Size = new Size(526, 246);
            SelectedCustomerTableLayoutPanel.TabIndex = 0;
            SelectedCustomerTableLayoutPanel.Paint += SelectedCustomerTableLayoutPanel_Paint;
            // 
            // SelectedCustomerLabel
            // 
            SelectedCustomerLabel.Anchor = AnchorStyles.Left;
            SelectedCustomerLabel.AutoSize = true;
            SelectedCustomerTableLayoutPanel.SetColumnSpan(SelectedCustomerLabel, 2);
            SelectedCustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectedCustomerLabel.Location = new Point(3, 0);
            SelectedCustomerLabel.Margin = new Padding(3, 0, 3, 8);
            SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            SelectedCustomerLabel.Size = new Size(139, 20);
            SelectedCustomerLabel.TabIndex = 0;
            SelectedCustomerLabel.Text = "Selected Customer";
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
            IdTextBox.Location = new Point(88, 32);
            IdTextBox.Margin = new Padding(3, 4, 3, 4);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(159, 27);
            IdTextBox.TabIndex = 2;
            // 
            // FullnameLabel
            // 
            FullnameLabel.Anchor = AnchorStyles.Left;
            FullnameLabel.AutoSize = true;
            FullnameLabel.Location = new Point(3, 70);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(79, 20);
            FullnameLabel.TabIndex = 3;
            FullnameLabel.Text = "Full Name:";
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Dock = DockStyle.Fill;
            FullnameTextBox.Location = new Point(88, 67);
            FullnameTextBox.Margin = new Padding(3, 4, 3, 4);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(435, 27);
            FullnameTextBox.TabIndex = 4;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(3, 107);
            AddressLabel.Margin = new Padding(3, 9, 3, 0);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(65, 20);
            AddressLabel.TabIndex = 5;
            AddressLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Dock = DockStyle.Fill;
            AddressTextBox.Location = new Point(88, 102);
            AddressTextBox.Margin = new Padding(3, 4, 3, 4);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.ScrollBars = ScrollBars.Vertical;
            AddressTextBox.Size = new Size(435, 140);
            AddressTextBox.TabIndex = 6;
            // 
            // ReservedPanel
            // 
            ReservedPanel.Dock = DockStyle.Fill;
            ReservedPanel.Location = new Point(3, 258);
            ReservedPanel.Margin = new Padding(3, 4, 3, 4);
            ReservedPanel.Name = "ReservedPanel";
            ReservedPanel.Size = new Size(526, 375);
            ReservedPanel.TabIndex = 1;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTableLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomersTab";
            Size = new Size(914, 667);
            MainTableLayoutPanel.ResumeLayout(false);
            CustomersTableLayoutPanel.ResumeLayout(false);
            CustomersTableLayoutPanel.PerformLayout();
            ButtonsTableLayoutPanel.ResumeLayout(false);
            RightTableLayoutPanel.ResumeLayout(false);
            SelectedCustomerTableLayoutPanel.ResumeLayout(false);
            SelectedCustomerTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
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