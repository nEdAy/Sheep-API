using System.Linq;
using System.Collections.Generic;
using MvcApplication1.DAO;
using MvcApplication1.Model;
namespace MvcApplication1.BLL{
public partial class _UserBLL{
/// <summary>
/// 数据库操作对象
/// </summary>
private _UserDAO _dao = new _UserDAO();
        private wechatDAO wechat_dao = new wechatDAO();
#region 向数据库中添加一条记录 +bool; Insert(_User model)
/// <summary>
/// 微信端，有邀请人注册
/// </summary>
/// <param name="model"></param>
/// <param name="history"></param>
/// <param name="history1"></param>
/// <returns></returns>
public bool Insert(_User model,CreditsHistory history, CreditsHistory history1)
{
return _dao.Insert(model,history,history1);
}
        /// <summary>
        /// 微信端，没有邀请人注册
        /// </summary>
        /// <param name="model"></param>
        /// <param name="history"></param>
        /// <returns></returns>
        public bool Insert(_User model, CreditsHistory history)
        {
            return _dao.Insert(model, history);
        }
        /// <summary>
        /// APP端，没有邀请人注册
        /// </summary>
        /// <param name="model"></param>
        /// <param name="history"></param>
        /// <returns></returns>
        public bool Insert1(_User model,CreditsHistory history)
        {
            return _dao.Insert1(model,history); 
        }
        /// <summary>
        /// APP端，有邀请人注册
        /// </summary>
        /// <param name="model"></param>
        /// <param name="history"></param>
        /// <returns></returns>
        public bool Insert1(_User model, CreditsHistory history, CreditsHistory history1,string inviteCode)
        {
            return _dao.Insert1(model, history,history1,inviteCode);
        }

        //有邀请码绑定操作
        public bool UpdateInsert(_User model,CreditsHistory history)
        {
            return _dao.UpdateInsert(model,history);
        }

        //无邀请码绑定操作
        public bool UpdateInsert1(_User model)
        {
            return _dao.UpdateInsert1(model);
        }
        //public bool UpdateCreditByOpenId(string openId,int credit)
        //{
        //    return _dao.UpdateCreditByOpenId(openId, credit);
        //}

        public bool UpdateCreditByObjectId(string objectId,CreditsHistory history)
        {
            return _dao.UpdateCreditByObjectId(objectId,history);
        }

        #endregion
        #region 删除一条记录 +bool Delete(string objectId)
        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="objectId">主键</param>
        /// <returns>是否成功</returns>
        public bool Delete(string objectId)
{
return _dao.Delete(objectId);
}
#endregion
#region 根据主键ID更新一条记录 +bool Update(_User model)
/// <summary>
/// 根据主键更新一条记录
/// </summary>
/// <param name="model">更新后的实体</param>
/// <returns>执行结果受影响行数</returns>
public bool Update(_User model)
{
return _dao.Update(model);
}
#endregion
#region 查询条数 +int QueryCount(object wheres)
/// <summary>
/// 查询条数
/// </summary>
/// <param name="wheres">查询条件</param>
/// <returns>实体</returns>
public int QueryCount(object wheres)
{
return _dao.QueryCount(wheres);
}
        #endregion
        
        /// <summary>
        /// 查询username是否存在
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool QueryExitByUsername(string username)
        {
            List<Wheres> list = new List<Wheres>();
            Wheres wh = new Wheres();
            wh.setField("username", "=", username, "");
            list.Add(wh);
            return _dao.QuerySingleByWheres(wh) != null;
        }
        
        public bool QueryBandByUsername(string username)
        {
            return _dao.QueryBandByUsername(username) > 0;
        }        

#region 分页查询一个集合 +IEnumerable<Users> QueryList(int index, int size, object wheres=null, string orderField=null, bool isDesc = false)
///<summary>
///分页查询一个集合
///</summary>
///<param name="index">页码</param>
///<param name="size">页大小</param>
///<param name="wheres">条件匿名类</param>
///<param name="orderField">排序字段</param>
///<param name="isDesc">是否降序排序</param>
///<returns>实体集合</returns>
public IEnumerable<_User> QueryList(int index, int size=10, object wheres=null, string orderField=null, bool isDesc=false)
{
return _dao.QueryList(index, size, wheres, orderField, isDesc);
}
#endregion
#region 分页查询一个集合 +IEnumerable<Users> QueryListX(int index, int size,object columns=null, object wheres=null, string orderField=null, bool isDesc = false)
///<summary>
///分页查询一个集合
///</summary>
///<param name="index">页码</param>
///<param name="size">页大小</param>
///<param name="wheres">条件匿名类</param>
///<param name="orderField">排序字段</param>
///<param name="isDesc">是否降序排序</param>
///<returns>实体集合</returns>
public IEnumerable<Dictionary<string, object>> QueryListX(int index, int size=10,object columns=null, object wheres=null, string orderField=null, bool isDesc=false)
{
return _dao.QueryListX(index, size,columns, wheres, orderField, isDesc);
}
#endregion
#region 查询单个模型实体 +_User QuerySingleByWheres(object wheres)
///<summary>
///查询单个模型实体
///</summary>
///<param name="wheres">条件匿名类</param>
///<returns>实体</returns>
public _User QuerySingleByWheres(object wheres)
{
return _dao.QuerySingleByWheres(wheres);
}
#endregion
#region 查询单个模型实体 +Dictionary<string,object> QuerySingleByWheresX(object wheres,object columns)
///<summary>
///查询单个模型实体
///</summary>
///<param name="wheres">条件</param>
///<param name="columns">列集合</param>
///<returns>实体</returns>
public Dictionary<string,object> QuerySingleByWheresX(object wheres,object columns)
{
return _dao.QuerySingleByWheresX(wheres,columns);
}
#endregion
#region 查询单个模型实体 +_User QuerySingleById(string objectId)
///<summary>
///查询单个模型实体
///</summary>
///<param name="objectId">key</param>
///<returns>实体</returns>
public _User QuerySingleById(string objectId){
return _dao.QuerySingleById(objectId);
}
#endregion
#region 查询单个模型实体 +Dictionary<string,object> QuerySingleByIdX(string objectId,object columns)///<summary>
///查询单个模型实体
///</summary>
///<param name=objectId>key</param>
///<returns>实体</returns>
///<returns>实体</returns>
public Dictionary<string,object> QuerySingleByIdX(string objectId, object columns)
{
return _dao.QuerySingleByIdX(objectId,columns);
}
#endregion
#region 根据主键修改指定列 +bool UpdateById(string objectId,object columns)
/// <summary>
/// 根据主键更新指定记录
/// </summary>
/// <param name="objectId">主键</param>
/// <param name="columns">列集合对象</param>
/// <returns>是否成功</returns>
public bool UpdateById(string objectId, object columns)
{
return _dao.UpdateById(objectId, columns);
}
 #endregion
#region 根据条件更新记录+bool UpdateByWheres(object wheres, object columns)
/// <summary>
/// 根据条件更新记录
/// </summary>
/// <param name="wheres">条件集合实体实体</param>
/// <param name="columns">列集合对象</param>
/// <returns>是否成功</returns>
public bool UpdateByWheres(object wheres, object columns)
{
return _dao.UpdateByWheres(wheres, columns);
}
 #endregion
}
}