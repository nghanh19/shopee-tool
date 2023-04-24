namespace ShopeeTool
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.nudParallel = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.viewAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAccount = new DevExpress.XtraGrid.GridControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnRandom = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lueCountries = new DevExpress.XtraEditors.LookUpEdit();
            this.lueGSM = new DevExpress.XtraEditors.LookUpEdit();
            this.chkPhoneNumber = new DevExpress.XtraEditors.CheckEdit();
            this.chkIpVN = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParallel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCountries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGSM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIpVN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.nudParallel);
            this.groupControl3.Controls.Add(this.btnStart);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(621, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(187, 55);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Progress";
            // 
            // nudParallel
            // 
            this.nudParallel.Font = new System.Drawing.Font("Tahoma", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudParallel.Location = new System.Drawing.Point(6, 5);
            this.nudParallel.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudParallel.Name = "nudParallel";
            this.nudParallel.Size = new System.Drawing.Size(79, 45);
            this.nudParallel.TabIndex = 6;
            this.nudParallel.ThousandsSeparator = true;
            this.nudParallel.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.Enabled = false;
            this.btnStart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStart.ImageOptions.SvgImage")));
            this.btnStart.Location = new System.Drawing.Point(91, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 46);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // viewAccount
            // 
            this.viewAccount.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAccount.Appearance.HeaderPanel.Options.UseFont = true;
            this.viewAccount.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewAccount.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewAccount.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.viewAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn4,
            this.colState});
            gridFormatRule1.Column = this.colState;
            gridFormatRule1.ColumnApplyTo = this.colState;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.Green;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[State] = \'Successfully\'";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.Column = this.colState;
            gridFormatRule2.ColumnApplyTo = this.colState;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[State] = \'CaptchaError\'";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.viewAccount.FormatRules.Add(gridFormatRule1);
            this.viewAccount.FormatRules.Add(gridFormatRule2);
            this.viewAccount.GridControl = this.gridAccount;
            this.viewAccount.Name = "viewAccount";
            this.viewAccount.OptionsView.ShowAutoFilterRow = true;
            this.viewAccount.OptionsView.ShowFooter = true;
            this.viewAccount.OptionsView.ShowGroupPanel = false;
            this.viewAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewAccount_KeyDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Username";
            this.gridColumn1.FieldName = "Username";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Username", "Total accounts: {0:N0}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Email";
            this.gridColumn2.FieldName = "Email";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Password";
            this.gridColumn3.FieldName = "Password";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Phone";
            this.gridColumn5.FieldName = "Phone";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "IP Info";
            this.gridColumn4.FieldName = "ProxyInfo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // colState
            // 
            this.colState.Caption = "State";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.AllowEdit = false;
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 5;
            // 
            // gridAccount
            // 
            this.gridAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAccount.Location = new System.Drawing.Point(0, 59);
            this.gridAccount.MainView = this.viewAccount;
            this.gridAccount.Name = "gridAccount";
            this.gridAccount.Size = new System.Drawing.Size(810, 408);
            this.gridAccount.TabIndex = 3;
            this.gridAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewAccount});
            // 
            // btnImport
            // 
            this.btnImport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImport.ImageOptions.SvgImage")));
            this.btnImport.Location = new System.Drawing.Point(5, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(132, 46);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import Accounts";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExport);
            this.groupControl1.Controls.Add(this.btnRandom);
            this.groupControl1.Controls.Add(this.btnImport);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(362, 55);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Data";
            // 
            // btnExport
            // 
            this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
            this.btnExport.Location = new System.Drawing.Point(266, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(88, 46);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRandom.ImageOptions.SvgImage")));
            this.btnRandom.Location = new System.Drawing.Point(143, 5);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(117, 46);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Random Info";
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(810, 59);
            this.panelControl1.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lueCountries);
            this.groupControl2.Controls.Add(this.lueGSM);
            this.groupControl2.Controls.Add(this.chkPhoneNumber);
            this.groupControl2.Controls.Add(this.chkIpVN);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(364, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(257, 55);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Options";
            // 
            // lueCountries
            // 
            this.lueCountries.Location = new System.Drawing.Point(117, 29);
            this.lueCountries.Name = "lueCountries";
            this.lueCountries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCountries.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryCode", "Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryName", "Name")});
            this.lueCountries.Properties.DisplayMember = "CountryName";
            this.lueCountries.Properties.NullText = "Select Country";
            this.lueCountries.Properties.ValueMember = "CountryCode";
            this.lueCountries.Size = new System.Drawing.Size(134, 20);
            this.lueCountries.TabIndex = 1;
            // 
            // lueGSM
            // 
            this.lueGSM.Location = new System.Drawing.Point(117, 6);
            this.lueGSM.Name = "lueGSM";
            this.lueGSM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGSM.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GSMCode", "Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GSMName", "Name")});
            this.lueGSM.Properties.DisplayMember = "GSMName";
            this.lueGSM.Properties.NullText = "Select GSM Service";
            this.lueGSM.Properties.ValueMember = "GSMCode";
            this.lueGSM.Size = new System.Drawing.Size(134, 20);
            this.lueGSM.TabIndex = 1;
            // 
            // chkPhoneNumber
            // 
            this.chkPhoneNumber.Location = new System.Drawing.Point(6, 5);
            this.chkPhoneNumber.Name = "chkPhoneNumber";
            this.chkPhoneNumber.Properties.Caption = "GSM Service";
            this.chkPhoneNumber.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgRadio2;
            this.chkPhoneNumber.Size = new System.Drawing.Size(105, 22);
            this.chkPhoneNumber.TabIndex = 0;
            // 
            // chkIpVN
            // 
            this.chkIpVN.EditValue = true;
            this.chkIpVN.Location = new System.Drawing.Point(6, 28);
            this.chkIpVN.Name = "chkIpVN";
            this.chkIpVN.Properties.Caption = "Country IP";
            this.chkIpVN.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgRadio2;
            this.chkIpVN.Size = new System.Drawing.Size(105, 22);
            this.chkIpVN.TabIndex = 0;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 467);
            this.Controls.Add(this.gridAccount);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "Shopee Register - fb.com/soul.keeper79";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudParallel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueCountries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGSM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIpVN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraGrid.Views.Grid.GridView viewAccount;
        private DevExpress.XtraGrid.GridControl gridAccount;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit chkIpVN;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.CheckEdit chkPhoneNumber;
        private DevExpress.XtraEditors.LookUpEdit lueGSM;
        private DevExpress.XtraEditors.SimpleButton btnRandom;
        private DevExpress.XtraEditors.LookUpEdit lueCountries;
        private System.Windows.Forms.NumericUpDown nudParallel;
    }
}

