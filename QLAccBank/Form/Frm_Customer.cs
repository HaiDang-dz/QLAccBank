using QLAccBank.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLAccBank
{
    public partial class Frm_Customer : Form
    {
        List<Class.Customer> cusList = new List<Class.Customer>();
        public Frm_Customer()
        {
            InitializeComponent();
            dgv_customer.AutoGenerateColumns = false;
            dgv_customer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // MÀU NỀN CÁCH DÒNG  
            dgv_customer.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_customer.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            cusList = customer.GetListFormCSV();
            dgv_customer.DataSource = cusList;
            DataTable dt = customer.ToDataTable(cusList);
            dgv_customer.DataSource = cusList;
        }
        private void txt_tim_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txt_tim.Text.ToLower();
            var filteredList = cusList.Where(c => c.CustomerID.ToLower().Contains(searchText) ||
                                                  c.FirstName.ToLower().Contains(searchText) ||
                                                  c.LastName.ToLower().Contains(searchText) ||
                                                  c.PhoneNumber.ToLower().Contains(searchText) ||
                                                  c.Email.ToLower().Contains(searchText) ||
                                                  c.IDCard.ToLower().Contains(searchText)).ToList();
            dgv_customer.DataSource = filteredList;
        }

        private void dgv_customer_SelectionChanged(object sender, EventArgs e)
        {
            // Bỏ qua nếu nhấn vào tiêu đề cột hoặc hàng
            if (dgv_customer.CurrentRow == null || dgv_customer.CurrentRow.Index < 0)
                return;

            DataGridViewRow row = dgv_customer.CurrentRow;

            txt_hodem.Text = row.Cells[1].Value?.ToString() ?? "";
            txt_ten.Text = row.Cells[2].Value?.ToString() ?? "";

            string gender = row.Cells[3].Value?.ToString() ?? "";
            comboBox_gioitinh.SelectedItem =
                (gender == "Nam" || gender == "Nữ") ? gender : null;

            if (DateTime.TryParse(row.Cells[4].Value?.ToString(), out DateTime dob))
                dtp_ngaysinh.Value = dob;
            else
                dtp_ngaysinh.Value = DateTime.Now;

            txt_sdt.Text = row.Cells[5].Value?.ToString() ?? "";
            txt_email.Text = row.Cells[6].Value?.ToString() ?? "";
        }
        private string GenerateCustomerID()
        {
            if(cusList.Count == 0)
                return "CUST001";
            var maxID = cusList
                .Select(c => int.Parse(c.CustomerID.Replace("CUST", "")))

                .Max();
            int newID = maxID + 1;
            return $"CUST{newID:D3}";
        }
        public void saveListToCSV(DataGridView dgv, string filePath)
        {
            try
            {
                StringBuilder csvContent = new StringBuilder();
                // Lấy header (tiêu đề các cột)
                string[] columnNames = dgv.Columns
                    .OfType<DataGridViewColumn>()
                    .Select(column => "\"" + column.HeaderText + "\"")
                    .ToArray();
                csvContent.AppendLine(string.Join(",", columnNames));
                // Lấy dữ liệu từng dòng
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow) // bỏ qua dòng mới để nhập dữ liệu
                    {
                        string[] cells = row.Cells
                            .OfType<DataGridViewCell>()
                            .Select(cell =>
                                "\"" + (cell.Value == null ? "" : cell.Value.ToString().Replace("\"", "\"\"")) + "\""
                            )
                            .ToArray();
                        csvContent.AppendLine(string.Join(",", cells));
                    }
                }
                // Ghi ra file
                File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
                MessageBox.Show("Lưu danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file CSV: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_them_Click_1(object sender, EventArgs e)
        {
            string newCustomerID = GenerateCustomerID();
            // Mở form thêm với CustomerID tự động
            Frm_Add_Customer frmAdd = new Frm_Add_Customer();  // Không truyền customer (để thêm mới)
            frmAdd.txtMaKhachHang.Text = newCustomerID;  // Điền sẵn CustomerID
            frmAdd.txtMaKhachHang.Enabled = false;  // Khóa không cho sửa (tùy chọn)
            if (frmAdd.ShowDialog() == DialogResult.OK && frmAdd.returnCustomer != null)
            {
                // Gán CustomerID mới cho khách hàng trả về
                frmAdd.returnCustomer.CustomerID = newCustomerID;
                // Thêm vào danh sách
                cusList.Add(frmAdd.returnCustomer);
                // Cập nhật DataGridView
                dgv_customer.DataSource = null;  // Reset DataSource
                dgv_customer.DataSource = cusList;  // Gán lại danh sách mới
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");

            }
            string filePath = Path.Combine(Application.StartupPath, "customers.csv");
            saveListToCSV(dgv_customer, filePath);
        }


        private void btt_QLTK_Click(object sender, EventArgs e)
        {
            if (dgv_customer.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng trước khi xem tài khoản!",
                                "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại, không mở form
            }
            Frm_BankAccount frm = new Frm_BankAccount();
            frm.ShowDialog(); 
        }
    }
}