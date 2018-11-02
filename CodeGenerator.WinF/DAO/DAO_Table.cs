using CodeGenerator.WinF.Entitys;
using Sephiroth.Infrastructure.DataPersistence.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.WinF.DAO
{
    public class DAO_Table: SID_DAO<E_Table>
    {
        public List<E_Table> GetThisAllTable(string pdname = "")
        {
            if (string.IsNullOrEmpty(pdname))
                pdname = this.GetDBcon().dbname;
            string sql = string.Empty;
            if (this.GetDBcon().dbType == DBcon.dbtype.Oracle)
                sql = "select TABLE_NAME from ALL_TABLES where owner =:pdname ";
            else if (this.GetDBcon().dbType == DBcon.dbtype.MySql)
                sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = @pdname ";
            else if (this.GetDBcon().dbType == DBcon.dbtype.MsSql)
                sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.tables ";
            //sql = "select TABLE_NAME from ALL_TABLES where owner ='PMSPRDBAK'";
            return this.Query<E_Table>(sql, new {pdname }).ToList();
        }
    }
}
