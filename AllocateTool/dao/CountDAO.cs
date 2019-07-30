using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using AllocateTool.Entity;
using AllocateTool.utils;

namespace AllocateTool.dao
{
    public partial class CountDAO : BaseDAO<Count>
    {

        public void AddCountItemDAO(OleDbConnection conn, Count count)
        {

            string sqlStr = @"INSERT INTO counts(m_subject,m_mailincometime) VALUES(@M_subject,@M_mailincometime)";
            OleDbParameter[] paras = count.ToInsertByParamArray();

            ExecuteSQLNonquery(conn, sqlStr, paras);

        }
        public override Count ToEntity(OleDbDataReader reader)
        {
            Count count = new Count();
            EntityUtils.FillEntity<Record>(reader, count);
            return count;
        }
    }
}
