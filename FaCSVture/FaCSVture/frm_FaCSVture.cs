using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaCSVture
{
    public partial class frm_FaCSVture : Form
    {
        List<List<string>> tableStrings = new List<System.Collections.Generic.List<string>>();
        List<SizeF> widths = new List<SizeF>();
        bool widthsIniciated = false;

        // Create font and brush.
        Font drawFont = new Font("Arial", 10);
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        // Set format of string.
        StringFormat drawFormat = new StringFormat(StringFormatFlags.LineLimit);
        //drawFormat.FormatFlags = StringFormatFlags.;
        float totalExtrasLaborables = 0,totalExtrasFestivas=0, totalExtras=0;
        public frm_FaCSVture()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\user\\Documents\\Trabajo\\Gwyneth";
                openFileDialog.Filter = "coma separated values (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            IniTable(fileContent);
            IniTabPanel();
            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void IniWidths(Graphics g)
        {
            string text;
            SizeF textWidth;
            widths.Clear();
            if (tableStrings.Count > 0)
            {
                for (int line = 0; line < tableStrings.Count; line++)
                {
                    for (int row = 0; row < tableStrings[line].Count; row++)
                    {
                        text = tableStrings[line][row];
                        textWidth = g.MeasureString(text, drawFont, 0, drawFormat);
                        if (row >= widths.Count) widths.Add(textWidth);
                        if (textWidth.Width > widths[row].Width)
                            widths[row] = new SizeF(textWidth.Width, widths[row].Height);
                    }

                }
            }
        }

        void tableTest()
        {
            TextBox textBox = new TextBox();
            textBox.Text = "text uno";

        }
        void IniTable(string fileContent)
        {
            tableStrings.Clear();

            string[] rows = fileContent.Split('\n');
            for (int count = 1; count < rows.Length; count++)
            {
                //rows[count] = rows[count].Remove(0, 1);
            }
            totalExtrasFestivas = 0;
            totalExtrasLaborables = 0;
            totalExtras = 0;
            for (int rowNumber = 0; rowNumber < rows.Length; rowNumber++)
            {
                tableStrings.Add(new List<string>());
                string[] splited = rows[rowNumber].Split(',');
                for (int columnNumber = 0; columnNumber < splited.Length; columnNumber++)
                {
                    tableStrings[rowNumber].Add(splited[columnNumber]);
                }
                if(itemTST.Checked)
                {
                    try
                    {
                        DateTime parsedDate = DateTime.Parse(tableStrings[rowNumber][4]);
                        tableStrings[rowNumber][0] = parsedDate.DayOfWeek.ToString();
                        float decimalDuration = float.Parse(tableStrings[rowNumber][8], CultureInfo.InvariantCulture);
                    
                        if((parsedDate.DayOfWeek==DayOfWeek.Saturday)||
                            (parsedDate.DayOfWeek==DayOfWeek.Sunday))
                        {
                            //Dia festivo
                            tableStrings[rowNumber][10] = (decimalDuration).ToString();
                            totalExtrasFestivas += decimalDuration;
                            totalExtras += decimalDuration ;
                        }
                        else
                        {
                            //Dia laborable
                            tableStrings[rowNumber][9] = (decimalDuration-8).ToString();
                            totalExtrasLaborables += decimalDuration-8;
                            totalExtras += decimalDuration-8;
                        }
                        }
                    catch {
                    }
                }
            }
            vScrollBar1.Value = 0;
            vScrollBar1.Maximum = tableStrings.Count;
            hScrollBar1.Value = 0;
            if(tableStrings.Count>0)hScrollBar1.Maximum = tableStrings[0].Count;
            panel1.Invalidate();
        }

        private void frm_FaCSVture_Shown(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            TablePaint(e.Graphics);
        }

        private void frm_FaCSVture_Paint(object sender, PaintEventArgs e)
        {
        }
        void TablePaint(Graphics g)
        {
            int rowHeight = 20;
            int columnWidth = 100;


            // Create point for upper-left corner of drawing.
            float x = 0.0F;
            float y = 0.0F;
            int row = 0, column;
            int tableRow = vScrollBar1.Value;
            int tableColumn ;

            string dateInput;
            DateTime parsedDate;
            bool festivo = false;

            IniWidths(g);

            for (; tableRow < tableStrings.Count; row++, tableRow++)
            {
                y = row * rowHeight;
                for (x = 0, column = 0, tableColumn = hScrollBar1.Value; tableColumn < tableStrings[tableRow].Count; column++, tableColumn++)
                {
                    if(itemTST.Checked)
                    {
                        //Si esta seleccionada la opcion de Optimizacion para TST.
                        //Resaltamos los dias festivos

                        try
                        {
                            festivo = false;
                            dateInput = tableStrings[tableRow][4];
                             parsedDate = DateTime.Parse(dateInput);
                            if (parsedDate.DayOfWeek == DayOfWeek.Saturday) festivo = true;
                            if (parsedDate.DayOfWeek == DayOfWeek.Sunday) festivo = true;
                        }
                        catch
                        {
                        }
                    }
                    RectangleF rect =
                        new RectangleF(x, y, widths[tableColumn].Width, rowHeight);
                    g.DrawRectangle(SystemPens.ActiveBorder, new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height));
                    if(festivo)g.FillRectangle(SystemBrushes.Menu, new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height));
                    g.DrawString(
                        tableStrings[tableRow][tableColumn],
                        drawFont,
                        drawBrush,
                        rect,
                        drawFormat);
                    x += widths[tableColumn].Width;

                    
                }
            }
            //int char_a = (int)'a';
            //for (int index = 0; index < 40; index++)
            //{
                
            //    string text = "" + (char)(char_a + index) + 't';
            //    //Font font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            //    StringFormat format = new StringFormat(StringFormatFlags.NoWrap);
            //    SizeF size = g.MeasureString(text, drawFont, 0, format);
            //    g.DrawString(text, drawFont, drawBrush, new RectangleF(0, 10*index, size.Width, size.Height), format);
            //}
                
        }

        private void dad(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReplacePointsByComas();
            saveTest();
        }
        private void ReplacePointsByComas()
        {
            string line = "";
            foreach (List<string> row in tableStrings)
            {
                line = "";
                for (int celd = 0; celd < row.Count; celd++)
                {
                    row[celd] = row[celd].Replace('.', ',');
                    line += celd + ",";
                }
            }
        }
        private void saveTest()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = "C:\\Users\\user\\Documents\\Trabajo\\Gwyneth";
            saveFileDialog1.FileName = "test.csv";
            saveFileDialog1.Filter = "coma separated values (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                testSave(saveFileDialog1.FileName);
            }
        }
        void testSave(string fileName)
        {
            // Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                string line = "";
                foreach (List<string> row in tableStrings)
                {
                    line = "";
                    foreach (string celd in row)
                    {
                        line += celd + ";";
                    }
                    sw.WriteLine(line);
                }
            }

        }

        private void frm_FaCSVture_Load(object sender, EventArgs e)
        {

            string fileContent = string.Empty;
            var filePath = string.Empty;
            PrintStartupPath();

            string[] args;
            args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                //Get the path of specified file
                filePath = args[1];

                //Read the contents of the file into a stream
                //var fileStream = openFileDialog.OpenFile();
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                catch { }
            }
            IniTable(fileContent);
            IniTabPanel();
        }

        private void IniTabPanel ()
        {
            var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ".";
            if (itemTST.Checked)
            {
                lblNEntradas.Text = tableStrings.Count.ToString();
                float suma = 0;
                float current = 0;
                for(int row=0;row<tableStrings.Count;row++)
                {
                    try
                    {
                        current =float.Parse(tableStrings[row][8], culture);
                        suma += current;
                    }
                    catch
                    {

                    }
                }
                lblSuma1.Text = suma.ToString();
                lblFechasRepetidas.Text = "????";
                lblHorasLaborables.Text = totalExtrasLaborables.ToString();
                lblHorasFestivas.Text = totalExtrasFestivas.ToString();
                lblTotalExtras.Text = totalExtras.ToString();
            }
            if(itemMoney.Checked)
            {

            }
        }
        private void PrintStartupPath()
        {
            string[] args;
            args = Environment.GetCommandLineArgs();

            foreach (string arg in args)
            {
                System.Diagnostics.Debug.Print("The argument in command is: " +
                   arg);
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Invalidate();
        }

        private void itemMoney_Click(object sender, EventArgs e)
        {
            itemTST.Checked = false;
            itemMoney.Checked = true;
        }

        private void itemTST_Click(object sender, EventArgs e)
        {
            itemTST.Checked = true;
            itemMoney.Checked = false;
        }
    }
}