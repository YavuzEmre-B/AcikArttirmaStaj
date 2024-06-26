namespace AcikArttirmaStaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductManager productManager = new ProductManager();
        Product product = new Product();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgrwProductList.DataSource = productManager.GetAll();
            dgrwProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGiveOffer_Click(object sender, EventArgs e)
        {

            dgrwProductList.DataSource = null;
            dgrwProductList.DataSource = productManager.GetAll();
        }
    }
}
