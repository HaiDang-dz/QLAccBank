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
        private void bt_them_Click_1(object sender, EventArgs e)
        {
            Frm_Add_Customer frmAdd = new Frm_Add_Customer();
            if (frmAdd.ShowDialog() == DialogResult.OK && frmAdd.returnCustomer != null)
            {
                Customer handler = new Customer();
                var list = handler.GetListFormCSV();
                list.Add(frmAdd.returnCustomer);
                //handler.SaveListToCSV(list);
                //LoadCustomerData();
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
            }
        }
    }
}