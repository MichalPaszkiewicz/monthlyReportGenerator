using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace reportsExe
{
    public partial class ReportGenerator : Form
    {
        public ReportGenerator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected override void OnResize(EventArgs e)
        {

            base.OnResize(e);
        }

        private void GenerateFile()
        {
            var rows = this.ReportGrid.Rows;

            if (rows.Count == 0)
            {
                return;
            }

            var columns = this.ReportGrid.Columns;

            var result = new Dictionary<string, Dictionary<string, int>>();

            for (var i = 0; i < rows.Count - 1; i++)
            {
                var row = rows[i];

                var kvPairs = new Dictionary<string, int>();

                for (var j = 1; j < columns.Count; j++)
                {
                    var cell = row.Cells[j];

                    if (columns[j] != null && cell.Value != null && cell.Value.ToString() != "")
                    {
                        kvPairs.Add(columns[j].Name, int.Parse(cell.Value.ToString()));
                    }
                }

                result.Add(row.Cells[0].Value.ToString(), kvPairs);
            }

            var serialisedTxt = JsonConvert.SerializeObject(result);

            File.WriteAllText(Directory.GetCurrentDirectory() + "/data.js", serialisedTxt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateFile();

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo()
            {
                WorkingDirectory = Directory.GetCurrentDirectory(),
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                Arguments = "/C node reportGenerator.js"
            };
            process.StartInfo = startInfo;
            process.Start();

            System.Diagnostics.Process.Start(startInfo.WorkingDirectory + "/test.html");
        }
    }
}
