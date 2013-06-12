namespace MyCodex
{
    partial class frmCodex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodex));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tcTop = new System.Windows.Forms.TabControl();
            this.tpPages = new System.Windows.Forms.TabPage();
            this.tpCreate = new System.Windows.Forms.TabPage();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tcFooter = new System.Windows.Forms.TabControl();
            this.tpRequirements = new System.Windows.Forms.TabPage();
            this.tpNotes = new System.Windows.Forms.TabPage();
            this.tpHistory = new System.Windows.Forms.TabPage();
            this.tlpMain.SuspendLayout();
            this.tcTop.SuspendLayout();
            this.tcFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tcTop, 0, 0);
            this.tlpMain.Controls.Add(this.tcFooter, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.63971F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.36029F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tlpMain.Size = new System.Drawing.Size(527, 750);
            this.tlpMain.TabIndex = 0;
            // 
            // tcTop
            // 
            this.tcTop.Controls.Add(this.tpPages);
            this.tcTop.Controls.Add(this.tpCreate);
            this.tcTop.Controls.Add(this.tpSearch);
            this.tcTop.Controls.Add(this.tpSettings);
            this.tcTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcTop.Location = new System.Drawing.Point(3, 3);
            this.tcTop.Name = "tcTop";
            this.tcTop.SelectedIndex = 0;
            this.tcTop.Size = new System.Drawing.Size(521, 185);
            this.tcTop.TabIndex = 1;
            // 
            // tpPages
            // 
            this.tpPages.Location = new System.Drawing.Point(4, 25);
            this.tpPages.Name = "tpPages";
            this.tpPages.Padding = new System.Windows.Forms.Padding(3);
            this.tpPages.Size = new System.Drawing.Size(513, 156);
            this.tpPages.TabIndex = 0;
            this.tpPages.Text = "Browse";
            this.tpPages.UseVisualStyleBackColor = true;
            // 
            // tpCreate
            // 
            this.tpCreate.Location = new System.Drawing.Point(4, 25);
            this.tpCreate.Name = "tpCreate";
            this.tpCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreate.Size = new System.Drawing.Size(513, 138);
            this.tpCreate.TabIndex = 1;
            this.tpCreate.Text = "Create / Edit";
            this.tpCreate.UseVisualStyleBackColor = true;
            // 
            // tpSearch
            // 
            this.tpSearch.Location = new System.Drawing.Point(4, 25);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(513, 138);
            this.tpSearch.TabIndex = 2;
            this.tpSearch.Text = "Search";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            this.tpSettings.Location = new System.Drawing.Point(4, 25);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(513, 138);
            this.tpSettings.TabIndex = 3;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tcFooter
            // 
            this.tcFooter.Controls.Add(this.tpRequirements);
            this.tcFooter.Controls.Add(this.tpNotes);
            this.tcFooter.Controls.Add(this.tpHistory);
            this.tcFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFooter.Location = new System.Drawing.Point(3, 570);
            this.tcFooter.Name = "tcFooter";
            this.tcFooter.SelectedIndex = 0;
            this.tcFooter.Size = new System.Drawing.Size(521, 177);
            this.tcFooter.TabIndex = 2;
            // 
            // tpRequirements
            // 
            this.tpRequirements.Location = new System.Drawing.Point(4, 24);
            this.tpRequirements.Name = "tpRequirements";
            this.tpRequirements.Padding = new System.Windows.Forms.Padding(3);
            this.tpRequirements.Size = new System.Drawing.Size(513, 149);
            this.tpRequirements.TabIndex = 0;
            this.tpRequirements.Text = "Requirements";
            this.tpRequirements.UseVisualStyleBackColor = true;
            // 
            // tpNotes
            // 
            this.tpNotes.Location = new System.Drawing.Point(4, 24);
            this.tpNotes.Name = "tpNotes";
            this.tpNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tpNotes.Size = new System.Drawing.Size(513, 149);
            this.tpNotes.TabIndex = 1;
            this.tpNotes.Text = "Notes";
            this.tpNotes.UseVisualStyleBackColor = true;
            // 
            // tpHistory
            // 
            this.tpHistory.Location = new System.Drawing.Point(4, 24);
            this.tpHistory.Name = "tpHistory";
            this.tpHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tpHistory.Size = new System.Drawing.Size(513, 149);
            this.tpHistory.TabIndex = 2;
            this.tpHistory.Text = "History";
            this.tpHistory.UseVisualStyleBackColor = true;
            // 
            // frmCodex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 750);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCodex";
            this.Text = "Codex";
            this.tlpMain.ResumeLayout(false);
            this.tcTop.ResumeLayout(false);
            this.tcFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TabControl tcTop;
        private System.Windows.Forms.TabPage tpPages;
        private System.Windows.Forms.TabPage tpCreate;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabControl tcFooter;
        private System.Windows.Forms.TabPage tpRequirements;
        private System.Windows.Forms.TabPage tpNotes;
        private System.Windows.Forms.TabPage tpHistory;

    }
}

