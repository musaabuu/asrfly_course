using Asrfly.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Code {
    public static class DependencyInjection {
        public static void AddDependencyValues() {
            ConfigurationObjectManager.Register("Categories", new CategoriesEntity());
            ConfigurationObjectManager.Register("SystemRecords", new SystemRecordsEntity());
            ConfigurationObjectManager.Register("Customers", new CustomersEntity());
            ConfigurationObjectManager.Register("Suppliers", new SuppliersEntity());
            ConfigurationObjectManager.Register("Projects", new ProjectsEntity());
            ConfigurationObjectManager.Register("Outcome", new OutcomeEntity());
        }
    }
}
