using Module_3.HW_2.Interfaces;
using Module_3.HW_2.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Module_3.HW_2.Services
{
    public class CultureService : ICultureService
    {
        private readonly CultureInfo _defaultCulture;
        private readonly IDictionary<string, CultureInfo> _cultureData;

        public CultureService()
        {
            _defaultCulture = CultureInfo.GetCultureInfo("en-US");
            _cultureData = new Dictionary<string, CultureInfo>();
        }

        public void Add(params string[] cultureIDs)
        {
            foreach (string cultureID in cultureIDs)
            {
                CultureInfo cultureInfo = new (cultureID);

                _cultureData.Add(cultureID, cultureInfo);
            }
        }

        public CultureInfo[] GetCultureData()
        {
            CultureInfo[] cultureInfo = new CultureInfo[_cultureData.Count];
            int i = 0;

            foreach (var cultureData in _cultureData)
            {
                cultureInfo[i++] = cultureData.Value;
            }

            return cultureInfo;
        }

        public object GetCulture(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("Can't get culture info, string is null or empty!");
            }

            return true switch
            {
                true when Regex.IsMatch(str, "[ЇїІіЄєҐґ']") => CultureInfo.GetCultureInfo("uk-UA"),
                true when Regex.IsMatch(str, "[a-zA-Z]") => CultureInfo.GetCultureInfo("en-US"),
                true when Regex.IsMatch(str, "[0-9]") => CharTypes.Digit,
                true when Regex.IsMatch(str, "[`~!@#$%^&*()_+-=,./?\\|';:[\"\\]{}<>\\s]") => CharTypes.Symbol,
                _ => _defaultCulture,
            };
        }
    }
}
