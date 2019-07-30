using System;
using System.Data.OleDb;
using AllocateTool.utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllocateTool.Entity
{
    /// <summary>
    /// 用于记录数据库中的条数，提示是否出现覆盖写的问题
    /// </summary>
    public partial class Count
    {

        public Count()
        {
            M_subject = "";
        }
        public int ID { get; set; }
        public string M_subject { get; set; }
        public DateTime? M_mailincometime { get; set; }


        public OleDbParameter[] ToInsertByParamArray()
        {
            OleDbParameter[] param = {
                    new OleDbParameter("@M_subject",EntityUtils.SqlNull(M_subject)),

                    new OleDbParameter("@M_mailincometime",EntityUtils.SqlNull(M_mailincometime)),

            };

            for (int i = 0; i < param.Length; i++)
            {
                param[i].IsNullable = true;
            }

            return param;

        }

        public OleDbParameter[] ToUpdateByParamArray()
        {
            OleDbParameter[] param = {

                    new OleDbParameter("@M_subject",EntityUtils.SqlNull(M_subject)),

                    new OleDbParameter("@M_mailincometime",EntityUtils.SqlNull(M_mailincometime)),

                new OleDbParameter("@ID",ID)
            };

            for (int i = 0; i < param.Length; i++)
            {
                param[i].IsNullable = true;
            }

            return param;

        }

        public override string ToString()
        {
            return String.Format("id:{0},Subject:{1},MailIncomeTime:{2}", ID, M_subject, M_mailincometime);
        }
    }
}
