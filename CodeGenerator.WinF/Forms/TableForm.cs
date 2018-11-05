using CodeGenerator.WinF.Bis;
using CodeGenerator.WinF.DAO;
using CodeGenerator.WinF.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator.WinF.Forms
{
    public partial class TableForm : Form
    {
        private E_Table table { get; set; }

        private DAO_Object dAO_Object { get; set; } = new DAO_Object();

        public TableForm(E_Table tparam)
        {
            InitializeComponent();
            this.table = tparam;
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            this.InitForm();
        }

        private void InitForm()
        {
            this.gridControl1.DataSource = dAO_Object.GetTableObject(table);
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.InitForm();
        }

        private void 生成EntitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gridControl1.DataSource == null || (this.gridControl1.DataSource as IEnumerable<E_Object>).Count() <= 0)
                return;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Entity文件路径";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            string foldPath = dialog.SelectedPath;
            var lanversion = 6;
            if ((sender as ToolStripMenuItem) == this.生成EntitysC50语法ToolStripMenuItem)
                lanversion = 5;
            string strTest = this.CreateTPL(lanversion);
            System.IO.File.WriteAllText(string.Format("{0}/{1}.cs",foldPath,table.TABLE_NAME), strTest, Encoding.UTF8);
            MessageBox.Show("保存成功！");
        }

        /// <summary>
        /// 创建模板字符串
        /// </summary>
        /// <returns></returns>
        private string CreateTPL(int lanversion = 6)
        {
            var data = (this.gridControl1.DataSource as IEnumerable<E_Object>).ToList();

            var col = data.OrderBy(p=>p.Column_name).Select(p =>
            {
                return this.GetType()
                .GetMethod("GetColfor" + dAO_Object.GetDBcon().dbType.ToString())
                .Invoke(this, new object[] { p,lanversion} )
                .ToString();
            }).ToArray();

            var map = data.OrderBy(p => p.Column_name).Select(p => 
            {
                var tpm = lanversion == 5 ? TPL.map5 : TPL.map;
                return string.Format(tpm, p.Comments ?? "", p.Column_name, table.TABLE_NAME);
            }).ToArray();
            return string.Format(TPL.entitys, table.TABLE_NAME, string.Join("\r\n", map), string.Join("\r\n", col));
        }

        public string GetColforOracle(E_Object p,int lanversion)
        {
            string dbtype = "string";
            string def = string.Empty;
            string attr = string.Empty;

            if (p.Data_type.ToUpper() == "NUMBER")
            {
                dbtype = "int" + (p.Nullable == "Y" ? "?" : "");
                def = string.IsNullOrEmpty(p.Data_default) ? def : " = " + p.Data_default + ";";
            }
            else if (p.Data_type.ToUpper() == "DATE"|| p.Data_type.ToUpper() == "DATETIME")
            {
                dbtype = "DateTime" + (p.Nullable == "Y" ? "?" : "");
            }
            else if (p.Data_type.ToUpper() == "NUMERIC"|| p.Data_type.ToUpper() == "NUMERIC")
            {
                dbtype = "decimal" + (p.Nullable == "Y" ? "?" : "");
                if (lanversion > 5)
                {
                    def = string.IsNullOrEmpty(p.Data_default) ? def : " = " + p.Data_default + ";";
                }
            }
            if(dbtype=="string")
            {
                attr += string.Format("\r\n            [StringLength({0}, ErrorMessage = \"长度必须小于{0}个字符。\")]", p.Data_length);
            }
            if(!string.IsNullOrEmpty(p.Comments))
            {
                attr += string.Format("\r\n            [Display(Name=\"{0}\")]", p.Comments);
            }

            return string.Format(TPL.col, (p.Comments ?? "").ToString(), dbtype, p.Column_name, def, attr);

        }

        public string GetColforMsSql(E_Object p, int lanversion)
        {
            string dbtype = "string";
            string def = string.Empty;
            string attr = string.Empty;

            if (p.Data_type == "int")
            {
                dbtype = "int" + (p.Nullable == "Y" ? "?" : "");
                def = string.IsNullOrEmpty(p.Data_default) ? def : " = " + p.Data_default + ";";
            }
            else if (p.Data_type.ToUpper() == "DATETIME")
            {
                dbtype = "DateTime" + (p.Nullable == "Y" ? "?" : "");
                def = " = DateTime.Now;";
            }
            else if (p.Data_type.ToUpper() == "NUMERIC")
            {
                dbtype = "decimal" + (p.Nullable == "Y" ? "?" : "");
                if (lanversion > 5)
                {
                    def = string.IsNullOrEmpty(p.Data_default) ? def : " = " + p.Data_default + ";";
                }
            }
            if (dbtype == "string")
            {
                attr += string.Format("\r\n            [StringLength({0}, ErrorMessage = \"长度必须小于{0}个字符。\")]", p.Data_length);
                if(!string.IsNullOrEmpty(p.Data_default)&& p.Data_default == "('')")
                {
                    def = "\"\"";
                }
                def = string.IsNullOrEmpty(p.Data_default) ? def : " = " + p.Data_default.Replace("(","").Replace(")","") + ";";
            }
            if (!string.IsNullOrEmpty(p.Comments))
            {
                attr += string.Format("\r\n            [Display(Name=\"{0}\")]", p.Comments);
            }

            return string.Format(TPL.col, (p.Comments ?? "").ToString(), dbtype, p.Column_name, def, attr);

        }

        private void 生成avalonhtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = (this.gridControl1.DataSource as IEnumerable<E_Object>).ToList();
            var colinputs = data.OrderBy(p => p.sortnum).Select(p =>
            {
                var typecol = "string";
                if (p.Data_type == "NUMBER")
                {
                    typecol = "number";
                }
                return string.Format(TPL.avaloninput, "6", p.Column_name, typecol);
            }).ToList();
            var html = string.Format(TPL.avalonhtml, string.Join("", colinputs));
            var tmp = new tmpform(html);
            tmp.ShowDialog();

            //if (this.gridControl1.DataSource == null || (this.gridControl1.DataSource as IEnumerable<E_Object>).Count() <= 0)
            //    return;
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.Description = "请选择文件路径";

            //if (dialog.ShowDialog() != DialogResult.OK)
            //    return;

            //string foldPath = dialog.SelectedPath;

            //var data = (this.gridControl1.DataSource as IEnumerable<E_Object>).ToList();
            //var colinputs = data.OrderBy(p => p.sortnum).Select(p =>
            //{
            //    var typecol = "string";
            //    if (p.Data_type == "NUMBER")
            //    {
            //        typecol = "number";
            //    }
            //    return string.Format(TPL.avaloninput, "6", p.Column_name, typecol);
            //}).ToList();
            //var html = string.Format(TPL.avalonhtml, string.Join("", colinputs));

            //string strTest = html;
            //System.IO.File.WriteAllText(string.Format("{0}/{1}.html", foldPath, table.TABLE_NAME), strTest, Encoding.UTF8);
            //MessageBox.Show("保存成功！");
        }

        private void 生成json对象ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = (this.gridControl1.DataSource as IEnumerable<E_Object>).ToList();
            
            var colinputs = data.OrderBy(p => p.sortnum).Select(p =>
            {
                return string.Format("{0}: '{1}'", p.Column_name, p.Comments);
            }).ToList();
            
            string strTest = string.Format("{{{0}}}",string.Join(",",colinputs));

            var tmp = new tmpform(strTest);
            tmp.ShowDialog();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = (this.gridControl1.DataSource as IEnumerable<E_Object>).ToList();
            data.ForEach(p =>
            {
                p.ck = true;
            });
            this.gridControl1.DataSource = data;
        }

        private void 反选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = (this.gridControl1.DataSource as IEnumerable<E_Object>).ToList();
            data.ForEach(p =>
            {
                p.ck = !p.ck;
            });
            this.gridControl1.DataSource = data;
        }

        private void 生成avalonhtml选中ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var data = (this.gridControl1.DataSource as IEnumerable<E_Object>).ToList();
            var colinputs = data.Where(p=>p.ck).OrderBy(p => p.sortnum).Select(p =>
            {
                var typecol = "string";
                if (p.Data_type == "NUMBER")
                {
                    typecol = "number";
                }
                return string.Format(TPL.avaloninput, "6", p.Column_name, typecol);
            }).ToList();
            var html = string.Format(TPL.avalonhtml, string.Join("", colinputs));
            var tmp = new tmpform(html);
            tmp.ShowDialog();
        }

        private void 生成btcolumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = (this.gridControl1.DataSource as IEnumerable<E_Object>).ToList();
            if (sender != this.生成btcolumnsToolStripMenuItem)
                data = data.Where(p => p.ck).ToList();
            var colinputs = data.OrderBy(p => p.sortnum).Select(p =>
            {
                return string.Format(@"{{field:'{0}',title:this.vmtag.{0},sortable: true}}", p.Column_name);
            }).ToList();

            var tmp = new tmpform(@"[{
                                checkbox: true
                            },"+ string.Join(",", colinputs) + "]");
            tmp.ShowDialog();
        }
    }
}
