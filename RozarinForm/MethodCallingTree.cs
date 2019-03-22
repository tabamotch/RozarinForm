using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozarinForm
{
    public class MethodCallingTree
    {
        public string MethodName { get; set; }

        public List<MethodCallingTree> CallingMethodList { get; } = new List<MethodCallingTree>();

        public int Lines { get; set; }
    }
}
