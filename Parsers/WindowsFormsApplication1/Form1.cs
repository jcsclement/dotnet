using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textXMLBox.ScrollBars = ScrollBars.Vertical;
            textJsonBox.ScrollBars = ScrollBars.Vertical;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // MessageBox.Show("Hi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openXMLFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Open the file as a stream
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openXMLFileDialog.FileName);
                string xml = sr.ReadToEnd();
                textXMLBox.Text = xml;

                // Close the file as a stream
                sr.Close();

                var watch = System.Diagnostics.Stopwatch.StartNew();
                // Convert stream to xml
                var doc = new XmlDocument();
                doc.LoadXml(xml);

                // Convert xml to xml
                var jsonText = JsonConvert.SerializeXmlNode(doc);

                // Write into a multiline textbox
                textJsonBox.Text = jsonText;
                watch.Stop();

                // Write into a label the runtime
                lblRuntime.Text = watch.ElapsedMilliseconds.ToString() + " ms";

            }
        }
    }
}
