using System.Linq;
using System.Collections.Generic;
using MvcApplication1.DAO;
using MvcApplication1.Model;
using System;

namespace MvcApplication1.BLL{
public partial class TbkItemBLL{
/// <summary>
/// ���ݿ��������
/// </summary>
private TbkItemDAO _dao = new TbkItemDAO();
#region �����ݿ�������һ����¼ +bool; Insert(TbkItem model)
/// <summary>
/// �����ݿ�������һ����¼
/// </summary>
/// <param name="model">Ҫ���ӵ�ʵ��</param>
/// <returns>�Ƿ�ɹ�</returns>
public bool Insert(TbkItem model)
{
return _dao.Insert(model);
}

 public bool InsertSome(List<TbkItem> list)
        {
            return _dao.InsertSome(list);
        }

        public bool DeleteAll()
        {
            return _dao.DeleteAll();
        }
        #endregion
        #region ɾ��һ����¼ +bool Delete(long num_iid)
        /// <summary>
        /// ɾ��һ����¼
        /// </summary>
        /// <param name="num_iid">����</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool Delete(long num_iid)
{
return _dao.Delete(num_iid);
}
#endregion
#region ��������ID����һ����¼ +bool Update(TbkItem model)
/// <summary>
/// ������������һ����¼
/// </summary>
/// <param name="model">���º��ʵ��</param>
/// <returns>ִ�н����Ӱ������</returns>
public bool Update(TbkItem model)
{
return _dao.Update(model);
}
#endregion
#region ��ѯ���� +int QueryCount(object wheres)
/// <summary>
/// ��ѯ����
/// </summary>
/// <param name="wheres">��ѯ����</param>
/// <returns>ʵ��</returns>
public int QueryCount(object wheres)
{
return _dao.QueryCount(wheres);
}
#endregion

#region ��ҳ��ѯһ������ +IEnumerable<Users> QueryList(int index, int size, object wheres=null, string orderField=null, bool isDesc = false)
///<summary>
///��ҳ��ѯһ������
///</summary>
///<param name="index">ҳ��</param>
///<param name="size">ҳ��С</param>
///<param name="wheres">����������</param>
///<param name="orderField">�����ֶ�</param>
///<param name="isDesc">�Ƿ�������</param>
///<returns>ʵ�弯��</returns>
public IEnumerable<TbkItem> QueryList(int index, int size=10, object wheres=null, string orderField=null, bool isDesc=false)
{
return _dao.QueryList(index, size, wheres, orderField, isDesc);
}
#endregion
#region ��ҳ��ѯһ������ +IEnumerable<Users> QueryListX(int index, int size,object columns=null, object wheres=null, string orderField=null, bool isDesc = false)
///<summary>
///��ҳ��ѯһ������
///</summary>
///<param name="index">ҳ��</param>
///<param name="size">ҳ��С</param>
///<param name="wheres">����������</param>
///<param name="orderField">�����ֶ�</param>
///<param name="isDesc">�Ƿ�������</param>
///<returns>ʵ�弯��</returns>
public IEnumerable<Dictionary<string, object>> QueryListX(int index, int size=10,object columns=null, object wheres=null, string orderField=null, bool isDesc=false)
{
return _dao.QueryListX(index, size,columns, wheres, orderField, isDesc);
}
#endregion
#region ��ѯ����ģ��ʵ�� +TbkItem QuerySingleByWheres(object wheres)
///<summary>
///��ѯ����ģ��ʵ��
///</summary>
///<param name="wheres">����������</param>
///<returns>ʵ��</returns>
public TbkItem QuerySingleByWheres(object wheres)
{
return _dao.QuerySingleByWheres(wheres);
}
#endregion
#region ��ѯ����ģ��ʵ�� +Dictionary<string,object> QuerySingleByWheresX(object wheres,object columns)
///<summary>
///��ѯ����ģ��ʵ��
///</summary>
///<param name="wheres">����</param>
///<param name="columns">�м���</param>
///<returns>ʵ��</returns>
public Dictionary<string,object> QuerySingleByWheresX(object wheres,object columns)
{
return _dao.QuerySingleByWheresX(wheres,columns);
}
#endregion
#region ��ѯ����ģ��ʵ�� +TbkItem QuerySingleById(long num_iid)
///<summary>
///��ѯ����ģ��ʵ��
///</summary>
///<param name="num_iid">key</param>
///<returns>ʵ��</returns>
public TbkItem QuerySingleById(long num_iid){
return _dao.QuerySingleById(num_iid);
}
#endregion
#region ��ѯ����ģ��ʵ�� +Dictionary<string,object> QuerySingleByIdX(long num_iid,object columns)///<summary>
///��ѯ����ģ��ʵ��
///</summary>
///<param name=num_iid>key</param>
///<returns>ʵ��</returns>
///<returns>ʵ��</returns>
public Dictionary<string,object> QuerySingleByIdX(long num_iid, object columns)
{
return _dao.QuerySingleByIdX(num_iid,columns);
}
#endregion
#region ���������޸�ָ���� +bool UpdateById(long num_iid,object columns)
/// <summary>
/// ������������ָ����¼
/// </summary>
/// <param name="num_iid">����</param>
/// <param name="columns">�м��϶���</param>
/// <returns>�Ƿ�ɹ�</returns>
public bool UpdateById(long num_iid, object columns)
{
return _dao.UpdateById(num_iid, columns);
}
 #endregion
#region �����������¼�¼+bool UpdateByWheres(object wheres, object columns)
/// <summary>
/// �����������¼�¼
/// </summary>
/// <param name="wheres">��������ʵ��ʵ��</param>
/// <param name="columns">�м��϶���</param>
/// <returns>�Ƿ�ɹ�</returns>
public bool UpdateByWheres(object wheres, object columns)
{
return _dao.UpdateByWheres(wheres, columns);
}
 #endregion
}
}