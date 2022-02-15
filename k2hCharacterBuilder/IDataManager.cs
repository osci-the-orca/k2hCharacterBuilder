using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2hCharacterBuilder
{
    interface IDataManager<T>
    {
        List<T> LoadData();
    }
}
