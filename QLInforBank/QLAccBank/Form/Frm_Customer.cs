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

            dgv_customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_customer.MultiSelect = false;
        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            Customer c = new Customer();
            cusList = c.GetListFormCSV();   // load toàn bộ dữ liệu lúc đầu
            dgv_customer.DataSource = cusList;
        }
        private void txt_tim_TextChanged_1(object sender, EventArgs e)
        {
            string filterText = txt_tim.Text.ToLower();

            if (string.IsNullOrEmpty(filterText))
            {
                dgv_customer.DataSource = cusList;
            }
            else
            {
                var filtered = cusList.Where(c =>
                    c.CustomerID.ToLower().Contains(filterText) ||
                    c.FirstName.ToLower().Contains(filterText) ||
                    c.LastName.ToLower().Contains(filterText) ||
                    c.PhoneNumber.ToLower().Contains(filterText) ||
                    c.Email.ToLower().Contains(filterText) ||
                    c.IDCard.ToLower().Contains(filterText)
                ).ToList();

                dgv_customer.DataSource = filtered;
            }

            dgv_customer.Refresh();
        }
        private string GenerateCustomerID()
        {
            if (cusList.Count == 0)
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


        private void dgv_customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgv_customer.Rows[e.RowIndex];
            if (row == null) return;

            txt_hodem.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
            txt_ten.Text = row.Cells["LastName"].Value?.ToString() ?? "";

            string gender = row.Cells["Gender"].Value?.ToString() ?? "";
            comboBox_gioitinh.SelectedItem = (gender == "Nam" || gender == "Nữ") ? gender : null;

            if (DateTime.TryParse(row.Cells["DOB"].Value?.ToString(), out DateTime dob))
                dtp_ngaysinh.Value = dob;

            txt_sdt.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
            txt_email.Text = row.Cells["Email"].Value?.ToString() ?? "";
            txt_diachi.Text = row.Cells["Address"].Value?.ToString() ?? "";
            txt_cancuoc.Text = row.Cells["IDCard"].Value?.ToString() ?? "";
        }

        private void btt_QLTK_Click(object sender, EventArgs e)
        {
            if (dgv_customer.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng trước khi xem tài khoản!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại, không mở form
            }
            Frm_BankAccount frm = new Frm_BankAccount();
            frm.ShowDialog();
        }

        private void dgv_customer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_customer.Columns.Contains("Action") &&
         e.ColumnIndex == dgv_customer.Columns["Action"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Lấy icon (nếu chưa có thì bỏ hoặc thêm icon tương ứng trong Resources)
                Image editIcon = Properties.Resources.edit;   // Cây bút
                Image deleteIcon = Properties.Resources.delete; // Thùng rác

                // Tính vị trí icon trong cell
                int iconY = e.CellBounds.Y + (e.CellBounds.Height - 16) / 2;
                int editX = e.CellBounds.X + 8;
                int deleteX = e.CellBounds.X + 35;

                e.Graphics.DrawImage(editIcon, new Rectangle(editX, iconY, 16, 16));
                e.Graphics.DrawImage(deleteIcon, new Rectangle(deleteX, iconY, 16, 16));

                e.Handled = true;
            }
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !dgv_customer.Columns.Contains("Action") ||
        e.ColumnIndex != dgv_customer.Columns["Action"].Index)
                return;

            // Tính vị trí click tương đối trong cell
            Rectangle cellRect = dgv_customer.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            int mouseX = dgv_customer.PointToClient(Cursor.Position).X - cellRect.X;

            // Vùng click icon
            int editStart = 8;
            int deleteStart = 35;

            string customerID = dgv_customer.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();

            if (mouseX >= editStart && mouseX < editStart + 16)
            {
                // 🟢 Sửa khách hàng
                MessageBox.Show($"Sửa khách hàng {customerID}");
            }
            else if (mouseX >= deleteStart && mouseX < deleteStart + 16)
            {
                // 🗑️ Xóa khách hàng
                DialogResult result = MessageBox.Show($"Xóa khách hàng {customerID} ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var delCus = cusList.FirstOrDefault(c => c.CustomerID == customerID);
                    if (delCus != null)
                    {
                        cusList.Remove(delCus);
                        dgv_customer.DataSource = null;
                        dgv_customer.DataSource = cusList;

                        string filePath = Path.Combine(Application.StartupPath, "customers.csv");
                        saveListToCSV(dgv_customer, filePath);
                        MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo");
                    }
                }
            }
        }
    }
}