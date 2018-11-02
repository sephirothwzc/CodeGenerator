using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.WinF.Bis
{
    /// <summary>
    /// 文件模板
    /// </summary>
    public partial class TPL
    {
        public const string entitys = @"
using DapperExtensions.Mapper;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entitys
{{
    public partial class Mapper_{0}:ClassMapper<{0}>
    {{
        public Mapper_{0}()
        {{
            {1}
        }}
    }}
    public partial class {0}
    {{
        {2}
    }}
}}
";
        public const string col = @"
            /// <summary>
            /// {0}
            /// </summary>{4}
            public {1} {2} {{ get; set; }}{3}
";
        public const string map = @"
            /// <summary>
            /// {0}
            /// </summary>
            Map(x => x.{1}).Column(nameof({2}.{1}));
";
        public const string map5 = @"
            /// <summary>
            /// {0}
            /// </summary>
            Map(x => x.{1}).Column(""{1}"");
";
        public const string avalonhtml = @"
<form class=""form-horizontal"" role=""form""  ms-validate=""validate"">
    {0}
    <div class=""col-xs-12  form-group"">
        <input type=""button"" name=""btnSubmit"" class=""btn btn-primary fl_r"" value=""保存"" />
        <div class=""clear""></div>
    </div>
</form>
";
        // 0 数量 2列 6 3列 4
        // 1 字段名
        // 2 字段类型
        public const string avaloninput = @"        <div class=""col-xs-{0} form-group"">
            <label class=""col-xs-2 control-label""  for=""{1}"">{{{{@vmtag.{1}}}}}</label>
            <div class=""col-xs-10"">
                <input class=""form-control"" type=""text"" ms-attr=""{{placeholder:@vmtag.{1}}}""
                       ms-duplex-{2}=""@vmmodel.{1}"" maxlength=""25"">
            </div>
        </div>
";
    }
}
