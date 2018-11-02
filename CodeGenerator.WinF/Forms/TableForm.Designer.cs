namespace CodeGenerator.WinF.Forms
{
    partial class TableForm
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成EntitysC50语法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成EntitysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成DAOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.生成avalonhtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成avalonhtml选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成json对象ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_sortnum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_column_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_data_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_data_length = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_data_precision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Data_Scale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nullable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Data_default = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_comments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IndexCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.生成btcolumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成btcolumns选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1534, 859);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.生成EntitysC50语法ToolStripMenuItem,
            this.生成EntitysToolStripMenuItem,
            this.生成DAOToolStripMenuItem,
            this.导出excelToolStripMenuItem,
            this.toolStripSeparator1,
            this.生成avalonhtmlToolStripMenuItem,
            this.生成avalonhtml选中ToolStripMenuItem,
            this.生成btcolumnsToolStripMenuItem,
            this.生成btcolumns选中ToolStripMenuItem,
            this.生成json对象ToolStripMenuItem,
            this.toolStripSeparator2,
            this.全选ToolStripMenuItem,
            this.反选ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(342, 492);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 生成EntitysC50语法ToolStripMenuItem
            // 
            this.生成EntitysC50语法ToolStripMenuItem.Name = "生成EntitysC50语法ToolStripMenuItem";
            this.生成EntitysC50语法ToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.生成EntitysC50语法ToolStripMenuItem.Text = "生成Entitys(C#5.0语法)";
            this.生成EntitysC50语法ToolStripMenuItem.Click += new System.EventHandler(this.生成EntitysToolStripMenuItem_Click);
            // 
            // 生成EntitysToolStripMenuItem
            // 
            this.生成EntitysToolStripMenuItem.Name = "生成EntitysToolStripMenuItem";
            this.生成EntitysToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.生成EntitysToolStripMenuItem.Text = "生成Entitys";
            this.生成EntitysToolStripMenuItem.Click += new System.EventHandler(this.生成EntitysToolStripMenuItem_Click);
            // 
            // 生成DAOToolStripMenuItem
            // 
            this.生成DAOToolStripMenuItem.Name = "生成DAOToolStripMenuItem";
            this.生成DAOToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.生成DAOToolStripMenuItem.Text = "生成DAO";
            // 
            // 导出excelToolStripMenuItem
            // 
            this.导出excelToolStripMenuItem.Name = "导出excelToolStripMenuItem";
            this.导出excelToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.导出excelToolStripMenuItem.Text = "导出excel";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(338, 6);
            // 
            // 生成avalonhtmlToolStripMenuItem
            // 
            this.生成avalonhtmlToolStripMenuItem.Name = "生成avalonhtmlToolStripMenuItem";
            this.生成avalonhtmlToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.生成avalonhtmlToolStripMenuItem.Text = "生成avalon.html";
            this.生成avalonhtmlToolStripMenuItem.Click += new System.EventHandler(this.生成avalonhtmlToolStripMenuItem_Click);
            // 
            // 生成avalonhtml选中ToolStripMenuItem
            // 
            this.生成avalonhtml选中ToolStripMenuItem.Name = "生成avalonhtml选中ToolStripMenuItem";
            this.生成avalonhtml选中ToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.生成avalonhtml选中ToolStripMenuItem.Text = "生成avalon.html(选中)";
            this.生成avalonhtml选中ToolStripMenuItem.Click += new System.EventHandler(this.生成avalonhtml选中ToolStripMenuItem_Click);
            // 
            // 生成json对象ToolStripMenuItem
            // 
            this.生成json对象ToolStripMenuItem.Name = "生成json对象ToolStripMenuItem";
            this.生成json对象ToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.生成json对象ToolStripMenuItem.Text = "生成i18n-json对象";
            this.生成json对象ToolStripMenuItem.Click += new System.EventHandler(this.生成json对象ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(338, 6);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // 反选ToolStripMenuItem
            // 
            this.反选ToolStripMenuItem.Name = "反选ToolStripMenuItem";
            this.反选ToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.反选ToolStripMenuItem.Text = "反选";
            this.反选ToolStripMenuItem.Click += new System.EventHandler(this.反选ToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_sortnum,
            this.col_column_name,
            this.col_data_type,
            this.col_data_length,
            this.col_data_precision,
            this.col_Data_Scale,
            this.col_nullable,
            this.col_Data_default,
            this.col_comments,
            this.col_IndexCount,
            this.col_ck});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // col_sortnum
            // 
            this.col_sortnum.Caption = "排序";
            this.col_sortnum.FieldName = "sortnum";
            this.col_sortnum.Name = "col_sortnum";
            this.col_sortnum.Visible = true;
            this.col_sortnum.VisibleIndex = 1;
            // 
            // col_column_name
            // 
            this.col_column_name.Caption = "字段名";
            this.col_column_name.FieldName = "Column_name";
            this.col_column_name.Name = "col_column_name";
            this.col_column_name.Visible = true;
            this.col_column_name.VisibleIndex = 2;
            // 
            // col_data_type
            // 
            this.col_data_type.Caption = "数据类型";
            this.col_data_type.FieldName = "Data_type";
            this.col_data_type.Name = "col_data_type";
            this.col_data_type.Visible = true;
            this.col_data_type.VisibleIndex = 3;
            // 
            // col_data_length
            // 
            this.col_data_length.Caption = "长度";
            this.col_data_length.FieldName = "Data_length";
            this.col_data_length.Name = "col_data_length";
            this.col_data_length.Visible = true;
            this.col_data_length.VisibleIndex = 4;
            // 
            // col_data_precision
            // 
            this.col_data_precision.Caption = "整数位";
            this.col_data_precision.FieldName = "Data_precision";
            this.col_data_precision.Name = "col_data_precision";
            this.col_data_precision.Visible = true;
            this.col_data_precision.VisibleIndex = 5;
            // 
            // col_Data_Scale
            // 
            this.col_Data_Scale.Caption = "小数位";
            this.col_Data_Scale.FieldName = "Data_Scale";
            this.col_Data_Scale.Name = "col_Data_Scale";
            this.col_Data_Scale.Visible = true;
            this.col_Data_Scale.VisibleIndex = 6;
            // 
            // col_nullable
            // 
            this.col_nullable.Caption = "允许空值";
            this.col_nullable.FieldName = "Nullable";
            this.col_nullable.Name = "col_nullable";
            this.col_nullable.Visible = true;
            this.col_nullable.VisibleIndex = 7;
            // 
            // col_Data_default
            // 
            this.col_Data_default.Caption = "缺省值";
            this.col_Data_default.FieldName = "Data_default";
            this.col_Data_default.Name = "col_Data_default";
            this.col_Data_default.Visible = true;
            this.col_Data_default.VisibleIndex = 8;
            // 
            // col_comments
            // 
            this.col_comments.Caption = "备注";
            this.col_comments.FieldName = "Comments";
            this.col_comments.Name = "col_comments";
            this.col_comments.Visible = true;
            this.col_comments.VisibleIndex = 9;
            // 
            // col_IndexCount
            // 
            this.col_IndexCount.Caption = "索引次数";
            this.col_IndexCount.FieldName = "IndexCount";
            this.col_IndexCount.Name = "col_IndexCount";
            this.col_IndexCount.Visible = true;
            this.col_IndexCount.VisibleIndex = 10;
            // 
            // col_ck
            // 
            this.col_ck.Caption = "ck";
            this.col_ck.ColumnEdit = this.repositoryItemCheckEdit1;
            this.col_ck.FieldName = "ck";
            this.col_ck.Name = "col_ck";
            this.col_ck.Visible = true;
            this.col_ck.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // 生成btcolumnsToolStripMenuItem
            // 
            this.生成btcolumnsToolStripMenuItem.Name = "生成btcolumnsToolStripMenuItem";
            this.生成btcolumnsToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.生成btcolumnsToolStripMenuItem.Text = "生成bt-columns";
            this.生成btcolumnsToolStripMenuItem.Click += new System.EventHandler(this.生成btcolumnsToolStripMenuItem_Click);
            // 
            // 生成btcolumns选中ToolStripMenuItem
            // 
            this.生成btcolumns选中ToolStripMenuItem.Name = "生成btcolumns选中ToolStripMenuItem";
            this.生成btcolumns选中ToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.生成btcolumns选中ToolStripMenuItem.Text = "生成bt-columns(选中)";
            this.生成btcolumns选中ToolStripMenuItem.Click += new System.EventHandler(this.生成btcolumnsToolStripMenuItem_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 859);
            this.Controls.Add(this.gridControl1);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_column_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_data_type;
        private DevExpress.XtraGrid.Columns.GridColumn col_data_length;
        private DevExpress.XtraGrid.Columns.GridColumn col_data_precision;
        private DevExpress.XtraGrid.Columns.GridColumn col_Data_Scale;
        private DevExpress.XtraGrid.Columns.GridColumn col_nullable;
        private DevExpress.XtraGrid.Columns.GridColumn col_Data_default;
        private DevExpress.XtraGrid.Columns.GridColumn col_comments;
        private DevExpress.XtraGrid.Columns.GridColumn col_IndexCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成EntitysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成DAOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成EntitysC50语法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成avalonhtmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.Columns.GridColumn col_sortnum;
        private System.Windows.Forms.ToolStripMenuItem 生成json对象ToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn col_ck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成avalonhtml选中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成btcolumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成btcolumns选中ToolStripMenuItem;
    }
}