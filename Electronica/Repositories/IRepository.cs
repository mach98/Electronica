using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Repositories
{
    interface IRepository
    {
    IEnumerable GetAllRecords();
    IQueryable GetAllRecordsIQueryable();
    IEnumerable GetRecordsToShow(int pageNo, int pageSize, int currentPageNo, Expression<Func<Tbl_Entity, bool>> wherePredict, Expression<Func<Tbl_Entity, int>> orderByPredict);
 
    int GetAllRecordsCount();
 
    void Add(Tbl_Entity entity);
    void Update(Tbl_Entity entity);
    void UpdateByWhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict, Action ForEachPredict);
    Tbl_Entity GetFirstOrDefault(int recordId);
 
    void Remove(Tbl_Entity entity);
    void RemoveByWhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict);
    void RemoveRangeByWhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict);
    void InactiveAndDeleteMarkByWhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict, Action ForEachPredict);
    Tbl_Entity GetFirstOrDefaultByParameter(Expression<Func<Tbl_Entity, bool>> wherePredict);
    IEnumerable GetListByParameter(Expression<Func<Tbl_Entity, bool>> wherePredict);
    IEnumerable GetResultBySqlProcedure(string query, params object[] parameters);
}
    }
}
