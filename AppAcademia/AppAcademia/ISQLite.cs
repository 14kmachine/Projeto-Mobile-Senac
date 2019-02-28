using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppAcademia
{
    public interface ISQLite
    {
        SQLiteAsyncConnection AcessarDB();
    }
}
