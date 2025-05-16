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

namespace GestorProductosWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GestorProductos gestor = new GestorProductos();
        public MainWindow()
        {
            InitializeComponent();
            CargarDatosIniciales();
            dataGridProductos.ItemsSource = gestor.ObtenerListaProductos();

            ComboTipoBusqueda.Items.Add("ID");
            ComboTipoBusqueda.Items.Add("Nombre");
            ComboTipoBusqueda.Items.Add("Codigo de Barras");

            ComboTipoBusqueda.SelectedIndex = 0;
        }
        private void CargarDatosIniciales()
        {
            gestor.AgregarProducto(new Producto
            {
                Id = 3,
                CodigoBarras = "789123",
                Nombre = "Teclado",
                Categoria = "Electronica",
                Precio = 300,
                Stock = 20
            });
            gestor.AgregarProducto(new Producto
            {
                Id = 1,
                CodigoBarras = "123456",
                Nombre = "Mouse",
                Categoria = "Electronica",
                Precio = 10,
                Stock = 5
            });
            gestor.AgregarProducto(new Producto
            {
                Id = 4,
                CodigoBarras = "456789",
                Nombre = "Monitor",
                Categoria = "Electronica",
                Precio = 600,
                Stock = 10
            });
            gestor.AgregarProducto(new Producto
            {
                Id = 2,
                CodigoBarras = "321654",
                Nombre = "USB",
                Categoria = "Electronica",
                Precio = 15,
                Stock = 5
            });

        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}