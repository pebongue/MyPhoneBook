namespace MyPhoneBook.PL.Forms
{
    partial class fviewSearchContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fviewSearchContact));
            this.statusStripSearch = new System.Windows.Forms.StatusStrip();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbSearchBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbSearchKeyword = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSearchGo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearchClose = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateSearchAddedTo = new DevExpress.XtraEditors.DateEdit();
            this.chkboxSearchAddedFrom = new DevExpress.XtraEditors.CheckEdit();
            this.dateSearchAddedFrom = new DevExpress.XtraEditors.DateEdit();
            this.chkboxSearchAddedTo = new DevExpress.XtraEditors.CheckEdit();
            this.lstviewSearchResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSearchStartOver = new DevExpress.XtraEditors.SimpleButton();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchKeyword.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchAddedTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchAddedTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxSearchAddedFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchAddedFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchAddedFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxSearchAddedTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripSearch
            // 
            this.statusStripSearch.Location = new System.Drawing.Point(0, 461);
            this.statusStripSearch.Name = "statusStripSearch";
            this.statusStripSearch.Size = new System.Drawing.Size(793, 22);
            this.statusStripSearch.TabIndex = 2;
            this.statusStripSearch.Text = "statusStrip1";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupControl1.Controls.Add(this.cbSearchBy);
            this.groupControl1.Controls.Add(this.cbSearchKeyword);
            this.groupControl1.Controls.Add(this.btnSearchGo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnSearchClose);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(769, 178);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Search";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.Location = new System.Drawing.Point(132, 57);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.cbSearchBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSearchBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSearchBy.Size = new System.Drawing.Size(233, 20);
            this.cbSearchBy.TabIndex = 12;
            // 
            // cbSearchKeyword
            // 
            this.cbSearchKeyword.Location = new System.Drawing.Point(71, 28);
            this.cbSearchKeyword.Name = "cbSearchKeyword";
            this.cbSearchKeyword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.cbSearchKeyword.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSearchKeyword.Size = new System.Drawing.Size(400, 20);
            this.cbSearchKeyword.TabIndex = 5;
            // 
            // btnSearchGo
            // 
            this.btnSearchGo.Location = new System.Drawing.Point(477, 28);
            this.btnSearchGo.Name = "btnSearchGo";
            this.btnSearchGo.Size = new System.Drawing.Size(43, 20);
            this.btnSearchGo.TabIndex = 3;
            this.btnSearchGo.Text = "&GO";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(71, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Search by:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Search for:";
            // 
            // btnSearchClose
            // 
            this.btnSearchClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSearchClose.Location = new System.Drawing.Point(688, 139);
            this.btnSearchClose.Name = "btnSearchClose";
            this.btnSearchClose.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClose.TabIndex = 0;
            this.btnSearchClose.Text = "&Close";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateSearchAddedTo);
            this.groupBox1.Controls.Add(this.chkboxSearchAddedFrom);
            this.groupBox1.Controls.Add(this.dateSearchAddedFrom);
            this.groupBox1.Controls.Add(this.chkboxSearchAddedTo);
            this.groupBox1.Location = new System.Drawing.Point(132, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 82);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Added";
            // 
            // dateSearchAddedTo
            // 
            this.dateSearchAddedTo.EditValue = new System.DateTime(2011, 1, 10, 16, 45, 24, 0);
            this.dateSearchAddedTo.Location = new System.Drawing.Point(62, 44);
            this.dateSearchAddedTo.Name = "dateSearchAddedTo";
            this.dateSearchAddedTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSearchAddedTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateSearchAddedTo.Size = new System.Drawing.Size(165, 20);
            this.dateSearchAddedTo.TabIndex = 10;
            // 
            // chkboxSearchAddedFrom
            // 
            this.chkboxSearchAddedFrom.Location = new System.Drawing.Point(6, 19);
            this.chkboxSearchAddedFrom.Name = "chkboxSearchAddedFrom";
            this.chkboxSearchAddedFrom.Properties.Caption = "From:";
            this.chkboxSearchAddedFrom.Size = new System.Drawing.Size(50, 19);
            this.chkboxSearchAddedFrom.TabIndex = 7;
            // 
            // dateSearchAddedFrom
            // 
            this.dateSearchAddedFrom.EditValue = new System.DateTime(2011, 1, 10, 16, 45, 17, 0);
            this.dateSearchAddedFrom.Location = new System.Drawing.Point(62, 19);
            this.dateSearchAddedFrom.Name = "dateSearchAddedFrom";
            this.dateSearchAddedFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSearchAddedFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateSearchAddedFrom.Size = new System.Drawing.Size(165, 20);
            this.dateSearchAddedFrom.TabIndex = 9;
            // 
            // chkboxSearchAddedTo
            // 
            this.chkboxSearchAddedTo.Location = new System.Drawing.Point(6, 45);
            this.chkboxSearchAddedTo.Name = "chkboxSearchAddedTo";
            this.chkboxSearchAddedTo.Properties.Caption = "To:";
            this.chkboxSearchAddedTo.Size = new System.Drawing.Size(49, 19);
            this.chkboxSearchAddedTo.TabIndex = 8;
            // 
            // lstviewSearchResult
            // 
            this.lstviewSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstviewSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lstviewSearchResult.GridLines = true;
            this.lstviewSearchResult.Location = new System.Drawing.Point(0, 21);
            this.lstviewSearchResult.Name = "lstviewSearchResult";
            this.lstviewSearchResult.Size = new System.Drawing.Size(769, 207);
            this.lstviewSearchResult.TabIndex = 0;
            this.lstviewSearchResult.UseCompatibleStateImageBehavior = false;
            this.lstviewSearchResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Birthday";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Company";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Profession";
            this.columnHeader6.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mobile No";
            this.columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Owner";
            this.columnHeader9.Width = 59;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupControl2.Controls.Add(this.btnSearchStartOver);
            this.groupControl2.Controls.Add(this.lstviewSearchResult);
            this.groupControl2.Location = new System.Drawing.Point(12, 196);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(769, 262);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Search Result";
            // 
            // btnSearchStartOver
            // 
            this.btnSearchStartOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchStartOver.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSearchStartOver.Location = new System.Drawing.Point(688, 234);
            this.btnSearchStartOver.Name = "btnSearchStartOver";
            this.btnSearchStartOver.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStartOver.TabIndex = 0;
            this.btnSearchStartOver.Text = "Start Over";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Group";
            // 
            // fviewSearchContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 483);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.statusStripSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fviewSearchContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Contact";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchKeyword.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchAddedTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchAddedTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxSearchAddedFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchAddedFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchAddedFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkboxSearchAddedTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripSearch;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbSearchKeyword;
        private DevExpress.XtraEditors.SimpleButton btnSearchGo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearchClose;
        private DevExpress.XtraEditors.DateEdit dateSearchAddedTo;
        private DevExpress.XtraEditors.DateEdit dateSearchAddedFrom;
        private DevExpress.XtraEditors.CheckEdit chkboxSearchAddedTo;
        private DevExpress.XtraEditors.CheckEdit chkboxSearchAddedFrom;
        private System.Windows.Forms.ListView lstviewSearchResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearchStartOver;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit cbSearchBy;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}