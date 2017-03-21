/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2016/11/05 16:55:35
*生成者：wlitsoft
*/
using System;
namespace WYG.Model
{
    ///<summary>
    ///表CJ_CJSJT的实体类
    ///</summary>
    public class CJ_CJSJT
    {
        private decimal id;
        private decimal cJQXJBXX;
        private object sJT;
        private string gUID;

        /// <summary>
        /// Id
        /// </summary>
        public decimal ID
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 测井曲线基本信息
        /// </summary>
        public decimal CJQXJBXX
        {
            get { return cJQXJBXX; }
            set { cJQXJBXX = value; }
        }
        /// <summary>
        /// 数据体
        /// </summary>
        public object SJT
        {
            get { return sJT; }
            set { sJT = value; }
        }
        /// <summary>
        /// GUID
        /// </summary>
        public string GUID
        {
            get { return gUID; }
            set { gUID = value; }
        }

    }
}