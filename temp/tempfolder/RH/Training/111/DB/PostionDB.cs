using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Postion ( RH_Postion ) DB类
    ///</summary>
    public class PostionDB
    {

        /// <summary>
        /// 添加RH_Postion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddPostion(PostionEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Postion_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Postion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyPostion(PostionEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Postion_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Postion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemovePostion(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Postion_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Postion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static PostionEntity GetPostionDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Postion_Detail", param, DBConnEnm.TRDBWrite);
            return (PostionEntity)ORMapping.MapSingleObject(typeof(PostionEntity),dt);
        }
    }
}