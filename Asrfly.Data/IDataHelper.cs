using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Data {
    public interface IDataHelper<Table> {
        // Read

        /// <summary>Gets all data.</summary>
        /// <returns>All Data Of Table</returns>
        List<Table> GetAllData();
        /// <summary>Searches the specified search item.</summary>
        /// <param name="SearchItem">The search item.</param>
        /// <returns>Searched Data</returns>
        List<Table> Search(string SearchItem);
        /// <summary>Finds the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Table Row Where Id == ID</returns>
        Table Find(int Id);

        // Write

        /// <summary>Adds the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>
        ///   <para>1 When Task Sucess And 0 When Task Faild</para>
        /// </returns>
        int Add(Table table);
        /// <summary>Edits the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 When Task Sucess And 0 When Task Faild</returns>
        int Edit(Table table);
        /// <summary>Deletes the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>1 When Task Sucess And 0 When Task Faild</returns>
        int Delete(int Id);

        // Read Async

        /// <summary>Gets all data asynchronous.</summary>
        /// <returns>All Data Of Table</returns>
        Task<List<Table>> GetAllDataAsync();
        Task<List<Table>> SearchAsync(string SearchItem);
        Task<Table> FindAsync(int Id);

        // Write Async

        Task<int> AddAsync(Table table);
        Task<int> EditAsync(Table table);
        Task<int> DeleteAsync(int Id);
    }
}
