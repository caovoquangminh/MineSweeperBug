using System.Text.RegularExpressions;

namespace MineSweeper.Session
{
    internal partial class RegularExpressionContainer
    {
        internal static RegularExpressionContainer regularExpressionContainer
        {
            get
            {
                if (_regularExpressionContainer is null)
                {
                    _regularExpressionContainer = new RegularExpressionContainer();
                }

                return _regularExpressionContainer;
            }
        }
        private static RegularExpressionContainer _regularExpressionContainer;
    }

    internal partial class RegularExpressionContainer
    {
        /// <summary>
        /// <b>
        /// <br>new Regex(@"^\d+$");</br>
        /// </b>
        /// </summary>
        internal Regex regexIsNumber
        {
            get
            {
                if (_regexIsNumber is null)
                {
                    _regexIsNumber = new Regex(@"^\d+$");
                }

                return _regexIsNumber;
            }
        }
        private Regex _regexIsNumber;
    }
}
