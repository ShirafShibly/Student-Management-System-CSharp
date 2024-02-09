using SMS.DAL;
using SMS.Other;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Model
{
    class CourseModel
    {
        public int AddCourse(Course_DAL course_DAL)
        {
            string sql = string.Format("INSERT INTO Course(CName,CType,CStatus)" +
                "VALUES(@CName,@CType,@CStatus)");

            SqlParameter[] _sql = new SqlParameter[3];

            _sql[0] = SqlParameterFormat.Format("@CName", course_DAL.CName);
            _sql[1] = SqlParameterFormat.Format("@CType", course_DAL.CType);
            _sql[2] = SqlParameterFormat.Format("@CStatus", course_DAL.Cstatus);

            return ODBC.SetData(sql, _sql);
        }

        public static DataTable GetAllCourse()
        {
            try
            {
                string sql = string.Format("SELECT * FROM Course");

               
                return ODBC.GetData(sql, null);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int DeleteCourse(int cID)
        {
            string sql = string.Format("DELETE FROM Course WHERE CID=@Cid");
            //string sql = string.Format("SP_DELETE_COURSE");


            SqlParameter[] _sql = new SqlParameter[1];
            _sql[0] = SqlParameterFormat.Format("@Cid", cID);

            return ODBC.SetData(sql, _sql);
        }

        

        public DataTable CourseSearch(string search_text)
        {
            string text_like = "%" + search_text + "%";
            string sql = string.Format("SELECT * FROM  Course WHERE CName LIKE @CName");
            SqlParameter[] _sql = new SqlParameter[1];
            _sql[0] = SqlParameterFormat.Format("@CName", text_like);

            return ODBC.GetData(sql, _sql);
        }

        public int UpdateCourse(Course_DAL course_DAL)
        {
            string sql = string.Format("UPDATE Course SET CName=@CName,CType=@CType,CStatus=@CStatus WHERE CID=@Cid");

            SqlParameter[] _sql = new SqlParameter[4];

            _sql[0] = SqlParameterFormat.Format("@CName", course_DAL.CName);
            _sql[1] = SqlParameterFormat.Format("@CType", course_DAL.CType);
            _sql[2] = SqlParameterFormat.Format("@CStatus", course_DAL.Cstatus);
            _sql[3] = SqlParameterFormat.Format("@Cid", course_DAL.CID);

            return ODBC.SetData(sql, _sql);
        }
    }
}
