using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.WinF.Entitys
{
    public class E_Object
    {
        public bool ck { get; set; } = false;
        /// <summary>
        /// 模板排序字段
        /// </summary>
        public int sortnum { get; set; }

        /// <summary>
        /// 字段名
        /// </summary>
        public string Column_name { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string Data_type { get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        public string Data_length { get; set; }

        /// <summary>
        /// 整数位
        /// </summary>
        public string Data_precision { get; set; }

        /// <summary>
        /// 小数位
        /// </summary>
        public string Data_Scale { get; set; }

        /// <summary>
        /// 允许空值
        /// </summary>
        public string Nullable { get; set; }

        /// <summary>
        /// 缺省值
        /// </summary>
        public string Data_default { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// 索引次数
        /// </summary>
        public string IndexCount { get; set; }
    }
}
