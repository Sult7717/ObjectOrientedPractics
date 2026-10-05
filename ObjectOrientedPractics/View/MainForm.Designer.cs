#nullable disable
namespace ObjectOrientedPractics.View
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsView = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CustomersView = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.MainTabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ItemsTabPage);
            this.MainTabControl.Controls.Add(this.CustomersTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(884, 561);
            this.MainTabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsView);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Size = new System.Drawing.Size(876, 533);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsView
            // 
            this.ItemsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsView.Location = new System.Drawing.Point(0, 0);
            this.ItemsView.Name = "ItemsView";
            this.ItemsView.Size = new System.Drawing.Size(876, 533);
            this.ItemsView.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.CustomersView);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 24);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Size = new System.Drawing.Size(876, 533);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersView
            // 
            this.CustomersView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersView.Location = new System.Drawing.Point(0, 0);
            this.CustomersView.Name = "CustomersView";
            this.CustomersView.Size = new System.Drawing.Size(876, 533);
            this.CustomersView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.MainTabControl);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Object Oriented Practics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private ObjectOrientedPractics.View.Tabs.ItemsTab ItemsView;
        private ObjectOrientedPractics.View.Tabs.CustomersTab CustomersView;
    }
}
