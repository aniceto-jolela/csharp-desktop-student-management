using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cpqi.Helpers
{
    public static class RegexRules
    {
        /// <summary>
        /// Only letters (with accents), spaces and hyphens for proper names.
        /// </summary>
        public static readonly Regex FullName = new Regex(@"^[A-Za-zÀ-ÖØ-öø-ÿÇç'´`\- ]+$", RegexOptions.Compiled);

        /// <summary>
        /// Only letters, numbers and underscores for usernames.
        /// </summary>
        public static readonly Regex UserName = new Regex(@"^[a-zA-Z0-9_]+$", RegexOptions.Compiled);

        /// <summary>
        /// Validates ID with 6 to 15 alphanumeric characters.
        /// </summary>
        public static readonly Regex BI = new Regex(@"^[A-Z0-9]{6,15}$", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        /// <summary>
        /// Validates phone with digits, spaces and common symbols.
        /// </summary>
        public static readonly Regex Phone = new Regex(@"^[\d\s\+\-\(\)]{7,15}$", RegexOptions.Compiled);
    }
}
