using System.Collections.Generic;
using System.Drawing.Design;
using HBD.WinForms.Properties;

namespace HBD.WinForms.Design
{
    public class DefaultRegexEditor : UITypeEditor
    {
        private IDictionary<string, string> defaults = new Dictionary<string, string>
        {
            {"Email Expression", Resources.Regex_Email}
        };
    }
}