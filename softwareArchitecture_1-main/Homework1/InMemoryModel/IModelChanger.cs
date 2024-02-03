using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.InMemoryModel
{
    interface IModelChanger
    {
        public void NotifyChange(IModelChanger sender);
    }
}
