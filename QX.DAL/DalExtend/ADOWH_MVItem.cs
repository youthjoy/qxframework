using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;


namespace QX.DAL
{
    public partial class ADOWH_MVItem
    {

        
        public bool InsertOrUpdateMoveItem(List<WH_MVItem> detail)
        {
            
            bool result = false;
            if (detail != null)
            {
                idb.BeginTransaction();
                try
                {
                    //string ReturnId =(string)MainInstance.AddWithReturn(main);
                    for (int i = 0; i < detail.Count; i++)
                    {
                        if (GetListByWhere(" AND MVI_Code='" + detail[i].MVI_Code + "' ").Count() > 0)
                        {
                            Update(detail[i]);
                        }
                        else
                        {
                            Add(detail[i]);
                        }
                    }
                    idb.CommitTransaction();
                    result = true;
                }
                catch (Exception)
                {
                    idb.RollbackTransaction();
                }
            }
            return result;
        }
    }
}
