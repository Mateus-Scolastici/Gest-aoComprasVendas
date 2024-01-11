using System.Windows.Forms.DataVisualization.Charting;

namespace GestaoComprasVendas
{
    public partial class FrmSalesMinusPurchases : Form
    {
        private Chart chart1 = new Chart();
        public FrmSalesMinusPurchases()
        {
            InitializeComponent();
            Controls.Add(chart1);
            ConfigureColumnChart();
            PopulateChart();
        }

        private void ConfigureColumnChart()
        {
            // Configurações adicionais do gráfico de colunas
            chart1.ChartAreas.Add("ChartArea");
            chart1.Series.Add("Series");

            // Adicione dados de exemplo (substitua isso com seus próprios dados)
            chart1.Series["Series"].Points.AddXY("Categoria1", 10);
            chart1.Series["Series"].Points.AddXY("Categoria2", 20);
            chart1.Series["Series"].Points.AddXY("Categoria3", 15);

            // Personalize conforme necessário
            chart1.Series["Series"].ChartType = SeriesChartType.Column;
            chart1.Series["Series"].IsValueShownAsLabel = true;
        }

        private void PopulateChart()
        {
            // Adicione dados de exemplo ao gráfico
            chart1.Series.Clear();
            chart1.Series.Add("Vendas");

            // Dados de exemplo
            string[] categories = { "Produto A", "Produto B", "Produto C", "Produto D" };
            int[] sales = { 50, 30, 80, 20 };

            for (int i = 0; i < categories.Length; i++)
            {
                chart1.Series["Vendas"].Points.AddXY(categories[i], sales[i]);
            }

            // Defina o tipo de gráfico para colunas
            chart1.Series["Vendas"].ChartType = SeriesChartType.Column;

            // Adicione um título ao gráfico
            chart1.Titles.Add("Vendas por Produto");
        }
    }
}
