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
    public partial class Frm_BankAccount : Form
    {
        private List<BankAccount> BankAccountList = new List<BankAccount>();
        private List<Customer> CustomerList = new List<Customer>();
        public Frm_BankAccount()
        {
            InitializeComponent();
            dgv_Customer.AutoGenerateColumns = false;
            dgv_Customer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Customer.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_Customer.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            dgv_BankAccount.AutoGenerateColumns = false;
            dgv_BankAccount.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_BankAccount.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_BankAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        
    }
}