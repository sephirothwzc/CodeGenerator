using CodeGenerator.WinF.DAO;
using CodeGenerator.WinF.Forms;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator.WinF
{
    public partial class MainForm : Form
    {
        private DAO_Table dao_table = new DAO_Table();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.InitForm();
        }

        /// <summary>
        /// 加载窗体
        /// </summary>
        private void InitForm()
        {
            string dbserver = string.Empty;
            if (dao_table.GetDBcon().dbType == Sephiroth.Infrastructure.DataPersistence.Dapper.DBcon.dbtype.Oracle)
                dbserver = ConfigurationManager.AppSettings["dbserver"].ToString();
            var tablename = dao_table.GetThisAllTable(dbserver);
            var items = tablename.OrderBy(x => x.TABLE_NAME)
                .Select(x =>
                {
                    var nbi = new NavBarItemLink(new NavBarItem
                    {
                        Name = x.TABLE_NAME,
                        Caption = x.TABLE_NAME,
                    });
                    nbi.Item.LinkClicked += (send, e) =>
                    {
                        //判断当前页面是否已经打开
                        var pindex = this.xtraTabbedMdiManager1.Pages.FirstOrDefault(page => x.TABLE_NAME.Equals(page.Text));
                        //选中
                        if (pindex != null)
                        {
                            this.xtraTabbedMdiManager1.SelectedPage = pindex;
                            return;
                        }
                        //创建新页面
                        TableForm doc = new TableForm(x);

                        doc.Text = x.TABLE_NAME;
                        doc.WindowState = FormWindowState.Maximized;
                        doc.MdiParent = this;
                        doc.Show();
                    };
                    return nbi;
                }).ToArray();
            this.nbg_table.ItemLinks.AddRange(items);
        }
    }
}
