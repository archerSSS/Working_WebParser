using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebParser.Core
{
    class ParserWorker
    {
        Parser parser;
        ParserSettings parserSettings;

        #region Properties

        Parser par
        {
            get
            {
                return parser;
            }
            set
            {
                
            }
        }

        ParserSettings pars
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
            }
        }


        #endregion

        public ParserWorker(Parser p)
        {
            parser = p;
        }
    }
}