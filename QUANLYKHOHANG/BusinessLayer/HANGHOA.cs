using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class HANGHOA
    {
        Entities db;
        public HANGHOA()
        {
            db = Entities.CreateEntities();
        }
        public tb_HANGHOA getItem(string barcode)
        {
            return db.tb_HANGHOA.FirstOrDefault(x => x.BARCODE == barcode);
        }
        public List<tb_HANGHOA> getListByNhom(int idNhom)
        {
            return db.tb_HANGHOA.Where(x => x.IDNHOM == idNhom).OrderBy(o => o.CREATE_DATE).ToList();
        }
        public tb_HANGHOA add(tb_HANGHOA hh)
        {
            try
            {
                db.tb_HANGHOA.Add(hh);
                db.SaveChanges();
                return hh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_HANGHOA update(tb_HANGHOA hh)
        {
            tb_HANGHOA _hh = db.tb_HANGHOA.FirstOrDefault(x => x.BARCODE == hh.BARCODE);
            _hh.TENHH = hh.TENHH;
            _hh.TENTAT = hh.TENTAT;
            _hh.DVT = hh.DVT;
            _hh.DONGIA = hh.DONGIA;
            _hh.MANCC = hh.MANCC;
            _hh.MAXX = hh.MAXX;
            _hh.MOTA = hh.MOTA;
            _hh.DISABLED = hh.DISABLED;
            try
            {
                db.SaveChanges();
                return _hh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void delete(string barcode)
        {
            tb_HANGHOA _hh = db.tb_HANGHOA.FirstOrDefault(x => x.BARCODE == barcode);

            _hh.DISABLED = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}