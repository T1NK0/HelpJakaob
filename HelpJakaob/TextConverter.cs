using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakaob
{
    /// <summary>
    /// Converts the message to HTML
    /// </summary>
    public interface ITextConverter
    {
        public virtual string ConvertBodyToHTML(string plainText);
    }
}
