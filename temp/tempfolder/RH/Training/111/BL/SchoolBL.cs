using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_School ( RH_School ) BL类
    ///</summary>
    public class SchoolBL
    {

        /// <summary>
        /// 添加RH_School
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddSchool(SchoolEntity info)
        {
            return SchoolDB.AddSchool(info);
        }


        /// <summary>
        /// 修改RH_School
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifySchool(SchoolEntity info)
        {
            return SchoolDB.ModifySchool(info);
        }


        /// <summary>
        /// 删除RH_School
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveSchool(int ID)
        {
            return SchoolDB.RemoveSchool(ID);
        }

        /// <summary>
        /// 查看RH_School
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static SchoolEntity GetSchoolDetail(int ID)
        {
            return SchoolDB.GetSchoolDetail(ID);
        }
    }
}