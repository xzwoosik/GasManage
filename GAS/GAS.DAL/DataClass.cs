﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GAS.DAL
{
    public class DataClass
    {
        #region 定义与实例化
        BaseClass baseClass=new BaseClass();
        #endregion


        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Pass">密码</param>
        /// <returns>check结果</returns>
        bool LoginChek(string Name, string Pass)
        {
            SqlDataReader temDR = baseClass.getcom("select * from tb_Login where Name='" + Name + "' and Pass='" + Pass + "'");
            bool ifcom = temDR.Read();
            if (ifcom)
            {
                BaseClass.My_con.Close();
                BaseClass.My_con.Dispose();
            }
            BaseClass.con_close();
            return ifcom;
        }

        void TestCon()
        {
            baseClass.con_open();  //连接数据库
            BaseClass.con_close();
            
        }
    }
}
