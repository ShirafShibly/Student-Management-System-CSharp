using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DAL;
using SMS.Other;
using System.Data;

namespace SMS.Model
{
    class StaffModel
    {
      
        public int AddStaff(Staff_DAL staff_DAL)
        {


            //string sql = string.Format("INSERT INTO Staff(EFName,ELName,EAddress,ENIC,EGende,EmartitalStatus,Enationality,EDOB,EEmail,EMobile,EDesignation)" +
            //   "VALUES(@EFName,@ELName,@EAddress,@ENIC,@EGende,@EmartitalStatus,@Enationality,@EDOB,@EEmail,@EMobile,@EDesignation)");

            string sql = string.Format("INSERT INTO Staff(EFName,ELName,EFullName,ENameWithInit,EAddress,ENIC,EGende,EmartitalStatus,Enationality,EEmail,EMobile,EHomeMobile,EDesignation,EDOB,EEnrollDate,photo_data)" +
               "VALUES(@EFName,@ELName,@EFullName,@ENameWithInit,@EAddress,@ENIC,@EGende,@EmartitalStatus,@Enationality,@EEmail,@EMobile,@EHomeMobile,@EDesignation,@EDOB,@EEnrollDate,@photo_data)");

            SqlParameter[] _sql = new SqlParameter[16];

            _sql[0] = SqlParameterFormat.Format("@EFName", staff_DAL.EFName);
            _sql[1] = SqlParameterFormat.Format("@ELName", staff_DAL.ELName);
            _sql[2] = SqlParameterFormat.Format("@EFullName", staff_DAL.EFullName);
            _sql[3] = SqlParameterFormat.Format("@ENameWithInit", staff_DAL.ENameWithInit);
            _sql[4] = SqlParameterFormat.Format("@EAddress", staff_DAL.EAddress);
            _sql[5] = SqlParameterFormat.Format("@ENIC", staff_DAL.ENIC);
            _sql[6] = SqlParameterFormat.Format("@EGende", staff_DAL.EGende);
            _sql[7] = SqlParameterFormat.Format("@EmartitalStatus", staff_DAL.EmartitalStatus);
            _sql[8] = SqlParameterFormat.Format("@Enationality", staff_DAL.Enationality);
            _sql[9] = SqlParameterFormat.Format("@EDOB", staff_DAL.EDOB);
            _sql[10] = SqlParameterFormat.Format("@EEmail", staff_DAL.EEmail);
            _sql[11] = SqlParameterFormat.Format("@EMobile", staff_DAL.EMobile);
            _sql[12] = SqlParameterFormat.Format("@EDesignation", staff_DAL.EDesignation);
            _sql[13] = SqlParameterFormat.Format("@EHomeMobile", staff_DAL.EHomeMobile);
            _sql[14] = SqlParameterFormat.Format("@EEnrollDate", staff_DAL.EEnrollDate);
            _sql[15] = SqlParameterFormat.Format("@photo_data", staff_DAL.photo_data);


            return ODBC.SetData(sql, _sql);
        }

        internal object GetAllStaffDtl()
        {
            try
            {
                string sql = string.Format("SELECT * FROM Staff");


                return ODBC.GetData(sql, null);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
