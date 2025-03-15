using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Code {
    public static class ConfigurationObjectManager {
        private static Dictionary<string, Object> ObjectList = new Dictionary<string, object>();

        public static void Register(string ObjectName, object ObjectValue) {
            ObjectList.Add(ObjectName, ObjectValue);
        }

        public static object GetObject(string ObjectName) {
            return ObjectList[ObjectName];
        }

    }
}
