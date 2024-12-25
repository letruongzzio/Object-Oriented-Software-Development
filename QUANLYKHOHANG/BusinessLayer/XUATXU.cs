using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class XUATXU
    {
        Entities db;

        public XUATXU()
        {
            db = Entities.CreateEntities();
        }

        public tb_XUATXU getItem(int id)
        {
            return db.tb_XUATXU.FirstOrDefault(x => x.ID == id);
        }

        public List<tb_XUATXU> getAll()
        {
            return db.tb_XUATXU.ToList();
        }

        public List<tb_XUATXU> getList()
        {
            return getAll();
        }

        public void add(tb_XUATXU xx)
        {
            try
            {
                db.tb_XUATXU.Add(xx);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
            }
        }

        public void update(tb_XUATXU xx)
        {
            tb_XUATXU _xx = db.tb_XUATXU.FirstOrDefault(x => x.ID == xx.ID);
            if (_xx != null)
            {
                _xx.TEN = xx.TEN;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
                }
            }
            else
            {
                throw new Exception("Không tìm thấy dữ liệu cần cập nhật");
            }
        }

        public void delete(int id)
        {
            tb_XUATXU _xx = db.tb_XUATXU.FirstOrDefault(x => x.ID == id);
            if (_xx != null)
            {
                db.tb_XUATXU.Remove(_xx);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
                }
            }
            else
            {
                throw new Exception("Không tìm thấy dữ liệu cần xóa");
            }
        }
    }
}
