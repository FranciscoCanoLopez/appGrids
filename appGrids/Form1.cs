using System.Globalization;

namespace appGrids
{
    public partial class Form1 : Form
    {
        private List<string[]> allData = [];
        public Form1()
        {
            InitializeComponent();
            lstvData.View = View.Details;
            dTP1.Format = DateTimePickerFormat.Custom;
            dTP1.CustomFormat = "yyyy";

            dTP2.Format = DateTimePickerFormat.Custom;
            dTP2.CustomFormat = "yyyy";
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Filter = "CSV Files|*.csv"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                string[] headers = lines[0].Split(',');
                lstvData.Columns.Clear();
                lstvData.Items.Clear();
                foreach (string header in headers)
                {
                    lstvData.Columns.Add(header);
                }
                allData = [];
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    ListViewItem lvi = new(fields);
                    lstvData.Items.Add(lvi);
                    allData.Add(fields);
                }

                CBArtist.Items.Clear();
                var artists = allData.Select(data => data[2]).Distinct();
                foreach (string artist in artists)
                {
                    CBArtist.Items.Add(artist);
                }
            }
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            if (CBArtist.SelectedItem != null)
            {
                string selectedArtist = CBArtist.SelectedItem.ToString()!;

                lstvData.Items.Clear();
                foreach (string[] data in allData)
                {
                    if (data[2] == selectedArtist)
                    {
                        ListViewItem lvi = new(data);
                        lstvData.Items.Add(lvi);
                    }
                }
            }
        }

        private void BTNSearch_Album_Click(object sender, EventArgs e)
        {
            if (CBArtist.SelectedItem != null)
            {
                string selectedArtist = CBArtist.SelectedItem.ToString();

                // Obtener los años seleccionados
                int añoInicio = dTP1.Value.Year;
                int añoFin = dTP2.Value.Year;

                // Filtrar los álbumes del artista seleccionado dentro del rango de años
                var albumesEnRango = allData.Where(data =>
                {
                    if (data[2] == selectedArtist && DateTime.TryParseExact(data[6], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaLanzamiento))
                    {
                        int añoLanzamiento = fechaLanzamiento.Year;
                        return añoLanzamiento >= añoInicio && añoLanzamiento <= añoFin;
                    }
                    return false;
                });

                // Mostrar los álbumes en el ListView
                lstvData.Items.Clear();
                foreach (var album in albumesEnRango)
                {
                    lstvData.Items.Add(new ListViewItem(album));
                }
            }
        }
    }
}
