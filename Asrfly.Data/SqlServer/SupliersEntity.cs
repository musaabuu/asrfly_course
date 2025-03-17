using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asrfly.Core;
using Asrfly.Core.SqlServer;

namespace Asrfly.Data.SqlServer {
    public class SupliersEntity : IDataHelper<Supliers> {
        private DBContext db;
        private Supliers table;

        // Constructor
        public SupliersEntity() {
            db = new DBContext();
        }

        #region Methods

        public int Add(Supliers table) {
            try {
                if (db.Database.CanConnect()) {
                    db.Supliers.Add(table);
                    db.SaveChanges();
                    return 1;
                } else {
                    return 0;
                }
            } catch {
                return 0;
            }
        }

        public async Task<int> AddAsync(Supliers table) {
            try {
                if (await db.Database.CanConnectAsync()) {
                    await db.Supliers.AddAsync(table);
                    await db.SaveChangesAsync();
                    return 1;
                } else {
                    return 0;
                }
            } catch {
                return 0;
            }
        }

        public int Delete(int Id) {
            try {
                if (db.Database.CanConnect()) {
                    table = Find(Id);
                    db.Supliers.Remove(table);
                    db.SaveChanges();
                    return 1;
                } else {
                    return 0;
                }
            } catch {
                return 0;
            }
        }

        public async Task<int> DeleteAsync(int Id) {
            try {
                if (await db.Database.CanConnectAsync()) {
                    table = await FindAsync(Id);
                    await Task.Run(() => db.Supliers.Remove(table));
                    await db.SaveChangesAsync();
                    return 1;
                } else {
                    return 0;
                }
            } catch {
                return 0;
            }
        }

        public int Edit(Supliers table) {
            try {
                if (db.Database.CanConnect()) {
                    db = new DBContext();
                    db.Supliers.Update(table);
                    db.SaveChanges();
                    return 1;
                } else {
                    return 0;
                }
            } catch {
                return 0;
            }
        }

        public async Task<int> EditAsync(Supliers table) {
            try {
                if (await db.Database.CanConnectAsync()) {
                    db = new DBContext();
                    await Task.Run(() => db.Supliers.Update(table));
                    await db.SaveChangesAsync();
                    return 1;
                } else {
                    return 0;
                }
            } catch {
                return 0;
            }
        }

        public Supliers Find(int Id) {
            try {
                if (db.Database.CanConnect()) {
                    return db.Supliers.Where(x => x.Id == Id).First();
                } else {
                    return null;
                }
            } catch {
                return null;
            }
        }

        public async Task<Supliers> FindAsync(int Id) {
            try {
                if (await db.Database.CanConnectAsync()) {
                    return await Task.Run(() => db.Supliers.Where(x => x.Id == Id).First());
                } else {
                    return null;
                }
            } catch {
                return null;
            }
        }

        public List<Supliers> GetAllData() {
            try {
                if (db.Database.CanConnect()) {
                    return db.Supliers.ToList();
                } else {
                    return null;
                }
            } catch {
                return null;
            }
        }

        public async Task<List<Supliers>> GetAllDataAsync() {
            try {
                if (await db.Database.CanConnectAsync()) {
                    return await Task.Run(() => db.Supliers.ToList());
                } else {
                    return null;
                }
            } catch {
                return null;
            }
        }

        public List<Supliers> Search(string SearchItem) {
            try {
                if (db.Database.CanConnect()) {
                    return db.Supliers.Where(
                        x => x.Id.ToString() == SearchItem
                        || x.Name.Contains(SearchItem)
                        || x.PhoneNumber.Contains(SearchItem)
                        || x.Address.Contains(SearchItem)
                        || x.Details.Contains(SearchItem)
                        || x.Balance.ToString().Contains(SearchItem)
                        || x.AddedDate.Date.ToString().Contains(SearchItem)).ToList();
                } else {
                    return null;
                }
            } catch {
                return null;
            }
        }

        public async Task<List<Supliers>> SearchAsync(string SearchItem) {
            try {
                if (await db.Database.CanConnectAsync()) {
                    return await Task.Run(() => db.Supliers.Where(
                        x => x.Id.ToString() == SearchItem
                        || x.Name.Contains(SearchItem)
                        || x.PhoneNumber.Contains(SearchItem)
                        || x.Address.Contains(SearchItem)
                        || x.Details.Contains(SearchItem)
                        || x.Email.Contains(SearchItem)
                        || x.Balance.ToString().Contains(SearchItem)
                        || x.AddedDate.Date.ToString().Contains(SearchItem)).ToList());
                } else {
                    return null;
                }
            } catch {
                return null;
            }
        }

        #endregion
    }
}
