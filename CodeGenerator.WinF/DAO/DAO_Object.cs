using CodeGenerator.WinF.Entitys;
using Sephiroth.Infrastructure.DataPersistence.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.WinF.DAO
{
    public class DAO_Object:SID_DAO<E_Object>
    {
        public IEnumerable<E_Object> GetTableObject(E_Table table)
        {
            if (this.GetDBcon().dbType == DBcon.dbtype.Oracle)
                return this.GetTableObjectOracle(table);
            else if (this.GetDBcon().dbType == DBcon.dbtype.MySql)
                return this.GetTableObjectMySql(table);
            else if (this.GetDBcon().dbType == DBcon.dbtype.MsSql)
                return this.GetTableObjectMsSql(table);
            return null;
        }
        /// <summary>
        /// 获取表对象
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public IEnumerable<E_Object> GetTableObjectOracle(E_Table table)
        {
            string sql = @"SELECT 10 as sortnum, A.Column_name  ,A.Data_type  ,A.Data_length  ,A.Data_precision ,
 A.Data_Scale  ,A.Nullable  ,A.Data_default ,
 B.Comments ,
 C.IndexCount FROM user_tab_columns A, user_col_comments B,
(
    SELECT COUNT(*) IndexCount,
	Column_Name FROM User_Ind_Columns WHERE Table_Name = :TABLE_NAME GROUP BY Column_Name
) C WHERE A.Table_Name = B.Table_Name
AND A.Column_Name = B.Column_Name
AND A.Column_Name = C.Column_Name(+)
AND A.Table_Name = :TABLE_NAME";

            return this.Query<E_Object>(sql, table);
        }

        public IEnumerable<E_Object> GetTableObjectMySql(E_Table table)
        {
            string sql = string.Format(@"SELECT
    10 as sortnum,
  COLUMN_NAME as Column_name,
    DATA_TYPE as Data_type,
  CHARACTER_MAXIMUM_LENGTH as Data_length,
  IS_NULLABLE  as Nullable,
  COLUMN_DEFAULT as Data_default,
  COLUMN_COMMENT as Comments 
FROM
 INFORMATION_SCHEMA.COLUMNS
where
-- developerclub为数据库名称，到时候只需要修改成你要导出表结构的数据库即可
table_schema ='{0}'
AND
-- article为表名，到时候换成你要导出的表的名称
-- 如果不写的话，默认会查询出所有表中的数据，这样可能就分不清到底哪些字段是哪张表中的了，所以还是建议写上要导出的名名称
table_name  = @TABLE_NAME", this.GetDBcon().dbname);

            return this.Query<E_Object>(sql, table);
        }

        public IEnumerable<E_Object> GetTableObjectMsSql(E_Table table)
        {
            string sql = string.Format(@" SELECT  
 10 as sortnum,
  B.NAME as Column_name,
    D.DATA_TYPE as Data_type,
  D.CHARACTER_MAXIMUM_LENGTH as Data_length,
  D.IS_NULLABLE  as Nullable,
  D.COLUMN_DEFAULT as Data_default,
	C.value AS column_description 
FROM sys.tables A  
INNER JOIN sys.columns B ON B.object_id = A.object_id  
LEFT JOIN sys.extended_properties C ON C.major_id = B.object_id AND C.minor_id = B.column_id 
LEFT JOIN INFORMATION_SCHEMA.columns D ON B.NAME = D.COLUMN_NAME AND D.TABLE_NAME = @TABLE_NAME
WHERE A.name = @TABLE_NAME", this.GetDBcon().dbname);
            return this.Query<E_Object>(sql, table);
        }
    }
}
