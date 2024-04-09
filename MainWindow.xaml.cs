using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SfDataGrid_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    #region Model Class
    public class OrderInfo
    {
        string _ProductId;
        string _ProductName;
        int _SalesID;
        int _Percent;
        string _CustomerName;
        string _CustomerId;

        public string ProductId
        {
            get { return _ProductId; }
            set { _ProductId = value; }
        }

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        public int SalesID
        {
            get { return _SalesID; }
            set { _SalesID = value; }
        }

        public int Percent
        {
            get { return _Percent; }
            set { _Percent = value; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        public string CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }

        public OrderInfo(string productId, string productName, int salesID, int percent, string customerName, string customerId)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.SalesID = salesID;
            this.Percent = percent;
            this.CustomerName = customerName;
            this.CustomerId = customerId;
        }
    }
    #endregion

    #region View Model Class
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public ViewModel()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo("P1", "Hardware", 3232, 557, "Maria Anders", "ALFKI"));
            _orders.Add(new OrderInfo("P2", "Software", 4545, 890, "Ana Trujilo", "ANATR"));
            _orders.Add(new OrderInfo("P3", "Hardware", 6742, 476, "Antonio Moreno", "ANTON"));
            _orders.Add(new OrderInfo("P4", "Software", 7844, 368, "Thomas Hardy", "AROUT"));
            _orders.Add(new OrderInfo("P5", "Hardware", 1234, 980, "Christina Berglund", "BERGS"));
            _orders.Add(new OrderInfo("P6", "Software", 7568, 457, "Hanna Moos", "BLAUS"));
            _orders.Add(new OrderInfo("P7", "Hardware", 9785, 234, "Frederique Citeaux", "BLONP"));
            _orders.Add(new OrderInfo("P8", "Software", 1231, 789, "Martin Sommer", "BOLID"));
            _orders.Add(new OrderInfo("P9", "Hardware", 4236, 442, "Laurence Lebihan", "BONAP"));
            _orders.Add(new OrderInfo("P10", "Software", 7369, 578, "Elizabeth Lincoln", "BOTTM"));
        }
    }
    #endregion
}