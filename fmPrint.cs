using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crystal_Report
{
    public partial class fmPrint : Form
    {
        List<OrderDetail> _list;
        Orders _orders;
        public fmPrint(Orders Orders, List<OrderDetail> list)
        {
            InitializeComponent();
            _orders = Orders;
            _list = list;
        }

        private void fmPrint_Load(object sender, EventArgs e)
        {
            //Init crystal report
            rptOrders1.SetDataSource(_list);
            rptOrders1.SetParameterValue("pOrderID", _orders.OrderID);
            rptOrders1.SetParameterValue("pDate", _orders.OrderDate.ToString("MM/dd/yyyy"));
            rptOrders1.SetParameterValue("pContactName", _orders.ContactName);
            rptOrders1.SetParameterValue("pPostalCode", _orders.PostalCode);
            rptOrders1.SetParameterValue("pAddress", _orders.Address);
            rptOrders1.SetParameterValue("pCity", _orders.City);
            rptOrders1.SetParameterValue("pPhone", _orders.Phone);
            crystalReportViewer.ReportSource = rptOrders1;
            crystalReportViewer.Refresh();
        }
    }
}