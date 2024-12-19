using Lab4_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hiển thị thời gian giao hàng từ ngày hiện hành đến ngày hiện hành
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Today;
            LoadData(startDate, endDate); // Load dữ liệu cho ngày hiện hành

            // Kiểm tra trạng thái của CheckBox
            if (chkView.Checked)
            {
                // Nếu checkbox được kiểm tra, hiển thị dữ liệu từ đầu tháng đến cuối tháng hiện hành
                DateTime firstDayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                LoadData(firstDayOfMonth, lastDayOfMonth);
            }
        }

        private void LoadData(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (var context = new ProductOrderDB())
                {
                    // Lọc hóa đơn theo khoảng thời gian
                    var invoices = context.Invoices
                        .Where(i => i.DeliveryDate >= startDate && i.DeliveryDate <= endDate)
                        .Select(i => new
                        {
                            i.InvoiceNo,
                            i.OrderDate,
                            i.DeliveryDate,
                            TotalAmount = i.Orders.Sum(o => o.Price * o.Quantity) // Tính tổng tiền đơn hàng
                        }).ToList();

                    // Hiển thị một thông báo để kiểm tra dữ liệu trả về
                    if ( invoices.Count == 0)
                    {
                        MessageBox.Show("Trả về 0 hóa đơn.");
                    }
                    else
                    {
                        // Bind dữ liệu vào DataGridView
                        dgvOrders.Rows.Clear();
                        int stt = 1;
                        foreach (var invoice in invoices)
                        {
                            int rowIndex = dgvOrders.Rows.Add();
                            dgvOrders.Rows[rowIndex].Cells[0].Value = stt++;
                            dgvOrders.Rows[rowIndex].Cells[1].Value = invoice.InvoiceNo;
                            dgvOrders.Rows[rowIndex].Cells[2].Value = invoice.OrderDate.ToString("dd/MM/yyyy");
                            dgvOrders.Rows[rowIndex].Cells[3].Value = invoice.DeliveryDate.ToString("dd/MM/yyyy");
                            dgvOrders.Rows[rowIndex].Cells[4].Value = invoice.TotalAmount;
                        }

                        // Tính tổng tiền
                        txtTotal.Text = invoices.Sum(i => i.TotalAmount).ToString("N0");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        private void chkView_CheckedChanged(object sender, EventArgs e)
        {

            if (chkView.Checked)
            {
                // Nếu checkbox không được kiểm tra, hiển thị lại dữ liệu từ 1/10/2019 đến 4/10/2019
                DateTime startDate = new DateTime(2019, 10, 1);
                DateTime endDate = new DateTime(2019, 10, 4);
                LoadData(startDate, endDate);
            }

            else
            {
                // Nếu checkbox được kiểm tra, hiển thị dữ liệu từ đầu tháng đến cuối tháng hiện hành
                DateTime firstDayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                LoadData(firstDayOfMonth, lastDayOfMonth);

            }
        }

        private void dtpDat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grbInfor_Enter(object sender, EventArgs e)
        {

        }
    }
}
