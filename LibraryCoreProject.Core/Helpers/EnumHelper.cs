using LibraryCoreProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Core.Helpers
{
    public static class EnumHelper
    {
        public static string GetStringFromEnumInt(int value)
            => Enum.GetName(typeof(Category), value);
    }
}
