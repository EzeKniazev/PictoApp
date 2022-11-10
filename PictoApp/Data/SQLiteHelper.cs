using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using PictoApp.Models;
using System.Threading.Tasks;

namespace PictoApp.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<MCategorias>().Wait();
            db.CreateTableAsync<MPictogramas>().Wait();
            db.CreateTableAsync<MUsuarios>().Wait();
        }


        #region Categorias
        public Task<int> SaveCatAsync(MCategorias Cate)
        {
            if (Cate.CodCat != 0)
            {
                return db.UpdateAsync(Cate);
            }
            else
            {
                return db.InsertAsync(Cate);
            }
        }

        public Task<int> DeleteCatAsync(MCategorias Cate)
        {
            return db.DeleteAsync(Cate);
        }

        public Task<List<MCategorias>> GetCatAsync()
        {
            return db.Table<MCategorias>().ToListAsync();
        }


        public Task<MCategorias> GetCatByCodAsync(int codCat)
        {
            return db.Table<MCategorias>().Where(a => a.CodCat == codCat).FirstOrDefaultAsync();
        }
        #endregion

        #region Pictogramas

        public Task<int> SavePictoAsync(MPictogramas Picto)
        {
            if (Picto.CodPicto != 0)
            {
                return db.UpdateAsync(Picto);
            }
            else
            {
                return db.InsertAsync(Picto);
            }
        }

        public Task<int> DeletePictoAsync(MPictogramas Picto)
        {
            return db.DeleteAsync(Picto);
        }

        public Task<List<MPictogramas>> GetPictoAsync()
        {
            return db.Table<MPictogramas>().ToListAsync();
        }

        //Pictogramas por codigo
        public Task<MPictogramas> GetPictoByCodAsync(int codPicto)
        {
            return db.Table<MPictogramas>().Where(a => a.CodPicto == codPicto).FirstOrDefaultAsync();
        }

        #endregion

        #region Usuario

        public Task<int> SaveUserAsync(MUsuarios User)
        {
            if (User.CodUser != 0)
            {
                return db.UpdateAsync(User);
            }
            else
            {
                return db.InsertAsync(User);
            }
        }

        public Task<int> DeleteUserAsync(MUsuarios User)
        {
            return db.DeleteAsync(User);
        }

        public Task<List<MUsuarios>> GetUserAsync()
        {
            return db.Table<MUsuarios>().ToListAsync();
        }

        //Pictogramas por codigo
        public Task<MUsuarios> GetUserByCodAsync(int codUser)
        {
            return db.Table<MUsuarios>().Where(a => a.CodUser == codUser).FirstOrDefaultAsync();
        }

        public bool LoginValidate(string userName1, string pwd1)
        {
            var data = db.Table<MUsuarios>();
            var d1 = data.Where(x => x.NomUser == userName1 && x.Contrasena == pwd1).FirstOrDefaultAsync();

            if (d1 != data.FirstOrDefaultAsync())
            {
                return true;
            }
            else
                return false;
        }

        #endregion
    }
}
