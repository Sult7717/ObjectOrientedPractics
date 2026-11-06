#nullable disable
namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            components = new System.ComponentModel.Container();
            MainTableLayoutPanel = new TableLayoutPanel();
            DeliveryAddressLabel = new Label();
            PostIndexLabel = new Label();
            PostIndexTextBox = new TextBox();
            CountryLabel = new Label();
            CountryTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            StreetLabel = new Label();
            StreetTextBox = new TextBox();
            BuildingLabel = new Label();
            BuildingTextBox = new TextBox();
            ApartmentLabel = new Label();
            ApartmentTextBox = new TextBox();
            ErrorToolTip = new ToolTip(components);
            MainTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 4;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainTableLayoutPanel.Controls.Add(DeliveryAddressLabel, 0, 0);
            MainTableLayoutPanel.Controls.Add(PostIndexLabel, 0, 1);
            MainTableLayoutPanel.Controls.Add(PostIndexTextBox, 1, 1);
            MainTableLayoutPanel.Controls.Add(CountryLabel, 0, 2);
            MainTableLayoutPanel.Controls.Add(CountryTextBox, 1, 2);
            MainTableLayoutPanel.Controls.Add(CityLabel, 2, 2);
            MainTableLayoutPanel.Controls.Add(CityTextBox, 3, 2);
            MainTableLayoutPanel.Controls.Add(StreetLabel, 0, 3);
            MainTableLayoutPanel.Controls.Add(StreetTextBox, 1, 3);
            MainTableLayoutPanel.Controls.Add(BuildingLabel, 0, 4);
            MainTableLayoutPanel.Controls.Add(BuildingTextBox, 1, 4);
            MainTableLayoutPanel.Controls.Add(ApartmentLabel, 2, 4);
            MainTableLayoutPanel.Controls.Add(ApartmentTextBox, 3, 4);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Margin = new Padding(0);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 5;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.RowStyles.Add(new RowStyle());
            MainTableLayoutPanel.Size = new Size(520, 180);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.Anchor = AnchorStyles.Left;
            DeliveryAddressLabel.AutoSize = true;
            MainTableLayoutPanel.SetColumnSpan(DeliveryAddressLabel, 4);
            DeliveryAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DeliveryAddressLabel.Location = new Point(3, 0);
            DeliveryAddressLabel.Margin = new Padding(3, 0, 3, 8);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(121, 20);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.Anchor = AnchorStyles.Left;
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(3, 35);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(78, 20);
            PostIndexLabel.TabIndex = 1;
            PostIndexLabel.Text = "Post Index:";
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Anchor = AnchorStyles.Left;
            PostIndexTextBox.Location = new Point(87, 32);
            PostIndexTextBox.Margin = new Padding(3, 4, 3, 4);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(125, 27);
            PostIndexTextBox.TabIndex = 2;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // CountryLabel
            // 
            CountryLabel.Anchor = AnchorStyles.Left;
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(3, 70);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(62, 20);
            CountryLabel.TabIndex = 3;
            CountryLabel.Text = "Country:";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Dock = DockStyle.Fill;
            CountryTextBox.Location = new Point(87, 67);
            CountryTextBox.Margin = new Padding(3, 4, 3, 4);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(173, 27);
            CountryTextBox.TabIndex = 4;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // CityLabel
            // 
            CityLabel.Anchor = AnchorStyles.Left;
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(269, 70);
            CityLabel.Margin = new Padding(6, 0, 3, 0);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(36, 20);
            CityLabel.TabIndex = 5;
            CityLabel.Text = "City:";
            // 
            // CityTextBox
            // 
            CityTextBox.Dock = DockStyle.Fill;
            CityTextBox.Location = new Point(311, 67);
            CityTextBox.Margin = new Padding(3, 4, 3, 4);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(206, 27);
            CityTextBox.TabIndex = 6;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // StreetLabel
            // 
            StreetLabel.Anchor = AnchorStyles.Left;
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(3, 105);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(49, 20);
            StreetLabel.TabIndex = 7;
            StreetLabel.Text = "Street:";
            // 
            // StreetTextBox
            // 
            MainTableLayoutPanel.SetColumnSpan(StreetTextBox, 3);
            StreetTextBox.Dock = DockStyle.Fill;
            StreetTextBox.Location = new Point(87, 102);
            StreetTextBox.Margin = new Padding(3, 4, 3, 4);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(430, 27);
            StreetTextBox.TabIndex = 8;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // BuildingLabel
            // 
            BuildingLabel.Anchor = AnchorStyles.Left;
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(3, 140);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(65, 20);
            BuildingLabel.TabIndex = 9;
            BuildingLabel.Text = "Building:";
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Left;
            BuildingTextBox.Location = new Point(87, 137);
            BuildingTextBox.Margin = new Padding(3, 4, 3, 4);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(100, 27);
            BuildingTextBox.TabIndex = 10;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.Anchor = AnchorStyles.Left;
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(269, 140);
            ApartmentLabel.Margin = new Padding(6, 0, 3, 0);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(81, 20);
            ApartmentLabel.TabIndex = 11;
            ApartmentLabel.Text = "Apartment:";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Left;
            ApartmentTextBox.Location = new Point(356, 137);
            ApartmentTextBox.Margin = new Padding(3, 4, 3, 4);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(100, 27);
            ApartmentTextBox.TabIndex = 12;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTableLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddressControl";
            Size = new Size(520, 180);
            MainTableLayoutPanel.ResumeLayout(false);
            MainTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Label DeliveryAddressLabel;
        private System.Windows.Forms.Label PostIndexLabel;
        private System.Windows.Forms.TextBox PostIndexTextBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.TextBox BuildingTextBox;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.TextBox ApartmentTextBox;
        private System.Windows.Forms.ToolTip ErrorToolTip;
    }
}
