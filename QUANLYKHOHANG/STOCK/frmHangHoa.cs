using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;

namespace STOCK
{
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        bool _them;
        string _barcode;
        NHACUNGCAP _nhacc;
        DONVITINH _dvt;
        NHOMHANGHOA _nhomHH;
        XUATXU _xuatxu;
        HANGHOA _hanghoa;

        void loadNhom()
        {
            cboNhom.DataSource = _nhomHH.getList();
            cboNhom.DisplayMember = "TENNHOM";
            cboNhom.ValueMember = "IDNHOM";
        }

        void loadNhaCC()
        {
            cboNhaCC.DataSource = _nhacc.getList();
            cboNhaCC.DisplayMember = "TENNCC";
            cboNhaCC.ValueMember = "MANCC";
        }

        void loadDVT()
        {
            cboDVT.DataSource = _dvt.getList();
            cboDVT.DisplayMember = "TEN";
            cboDVT.ValueMember = "ID";
        }

        void loadXuatXu()
        {
            cboXuatXu.DataSource = _xuatxu.getList();
            cboXuatXu.DisplayMember = "TEN";
            cboXuatXu.ValueMember = "ID";
        }

        public void loadData()
        {
            // gc.gcDanhSach.DataSource = _hanghoa.getListByNhom(int.Parse(cboNhom.SelectedValue.ToString()));
            // gvDanhSach.OptionsBehavior.Editable = false;
        }

        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }

        void _edControl(bool t)
        {
            txtTen.Enabled = t;
            txtTenTat.Enabled = t;
            txtMoTa.Enabled = t;
            cboDVT.Enabled = t;
            spGia.Enabled = t;
            cboNhaCC.Enabled = t;
            cboXuatXu.Enabled = t;
            chkDisabled.Enabled = t;
        }

        void _reset()
        {
            txtBarcode.Text = "";
            txtTen.Text = "";
            txtTenTat.Text = "";
            txtMoTa.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cboNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            _edControl(true);
            _reset();
            showHideControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _edControl(true);
            showHideControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _hanghoa.delete(_barcode);
                loadData();
            }
            else
                MessageBox.Show("Vui lòng chọn dòng cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_HANGHOA hh = new tb_HANGHOA();
            }
            else
            {
                tb_HANGHOA hh = _hanghoa.getItem(_barcode);
            }
            _them = false;
            loadData();
            _edControl(false);
            showHideControl(true);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_HANGHOA hh = new tb_HANGHOA();
            }
            else
            {
                tb_HANGHOA hh = _hanghoa.getItem(_barcode);
            }
            _them = false;
            loadData();
            _edControl(false);
            showHideControl(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            _nhacc = new NHACUNGCAP();
            _dvt = new DONVITINH();
            _nhomHH = new NHOMHANGHOA();
            _xuatxu = new XUATXU();
            _hanghoa = new HANGHOA();
            loadData();
            showHideControl(true);
            _edControl(false);

            loadNhom();
            loadNhaCC();
            loadDVT();
            loadXuatXu();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
                chkDisabled.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}