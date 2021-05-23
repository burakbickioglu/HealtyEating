using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utils.Reporter.Abstract
{
    public interface IReporter
    {
        public void CreateJson(object data, string filePath);

    }
}
