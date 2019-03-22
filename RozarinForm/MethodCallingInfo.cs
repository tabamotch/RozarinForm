using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozarinForm
{
    public class MethodCallingInfo
    {
        /// <summary>
        /// 解析対象メソッドを含むソースファイルのパス
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 解析対象メソッドの定義(引数定義含む)
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// 呼び出し先メソッドのリスト
        /// </summary>
        public List<string> CallingMethodName { get; } = new List<string>();

        public int Lines { get; set; } = 0;
    }
}
