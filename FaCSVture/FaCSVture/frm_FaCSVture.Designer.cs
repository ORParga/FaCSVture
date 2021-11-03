namespace FaCSVture
{
    partial class frm_FaCSVture
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FaCSVture));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTST = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSuma1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNEntradas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblTitleHoras = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHorasLaborables = new System.Windows.Forms.Label();
            this.lblHorasFestivas = new System.Windows.Forms.Label();
            this.lblFechasRepetidas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalExtras = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.plantillasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem1.Text = "Guardar sin puntos...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // plantillasToolStripMenuItem
            // 
            this.plantillasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTST,
            this.itemMoney});
            this.plantillasToolStripMenuItem.Name = "plantillasToolStripMenuItem";
            this.plantillasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.plantillasToolStripMenuItem.Text = "Plantillas";
            // 
            // itemTST
            // 
            this.itemTST.Checked = true;
            this.itemTST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemTST.Name = "itemTST";
            this.itemTST.Size = new System.Drawing.Size(111, 22);
            this.itemTST.Text = "TST";
            this.itemTST.Click += new System.EventHandler(this.itemTST_Click);
            // 
            // itemMoney
            // 
            this.itemMoney.Name = "itemMoney";
            this.itemMoney.Size = new System.Drawing.Size(111, 22);
            this.itemMoney.Text = "Money";
            this.itemMoney.Click += new System.EventHandler(this.itemMoney_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStripContainer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 404);
            this.splitContainer1.SplitterDistance = 596;
            this.splitContainer1.TabIndex = 2;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(596, 379);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(596, 404);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 379);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(0, 362);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(580, 17);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(580, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 379);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotalExtras);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblFechasRepetidas);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblHorasFestivas);
            this.tabPage1.Controls.Add(this.lblHorasLaborables);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblTitleHoras);
            this.tabPage1.Controls.Add(this.lblSuma1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblNEntradas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TST";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSuma1
            // 
            this.lblSuma1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuma1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSuma1.Location = new System.Drawing.Point(119, 53);
            this.lblSuma1.Name = "lblSuma1";
            this.lblSuma1.Size = new System.Drawing.Size(70, 23);
            this.lblSuma1.TabIndex = 3;
            this.lblSuma1.Text = "0";
            this.lblSuma1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trabajado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNEntradas
            // 
            this.lblNEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNEntradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNEntradas.Location = new System.Drawing.Point(119, 7);
            this.lblNEntradas.Name = "lblNEntradas";
            this.lblNEntradas.Size = new System.Drawing.Size(70, 23);
            this.lblNEntradas.TabIndex = 1;
            this.lblNEntradas.Text = "0";
            this.lblNEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de entradas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTitleHoras
            // 
            this.lblTitleHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleHoras.Location = new System.Drawing.Point(7, 110);
            this.lblTitleHoras.Name = "lblTitleHoras";
            this.lblTitleHoras.Size = new System.Drawing.Size(114, 23);
            this.lblTitleHoras.TabIndex = 4;
            this.lblTitleHoras.Text = "Extras laborables";
            this.lblTitleHoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(7, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Extras festivas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorasLaborables
            // 
            this.lblHorasLaborables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorasLaborables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorasLaborables.Location = new System.Drawing.Point(119, 110);
            this.lblHorasLaborables.Name = "lblHorasLaborables";
            this.lblHorasLaborables.Size = new System.Drawing.Size(70, 23);
            this.lblHorasLaborables.TabIndex = 6;
            this.lblHorasLaborables.Text = "0";
            this.lblHorasLaborables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHorasFestivas
            // 
            this.lblHorasFestivas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorasFestivas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorasFestivas.Location = new System.Drawing.Point(119, 133);
            this.lblHorasFestivas.Name = "lblHorasFestivas";
            this.lblHorasFestivas.Size = new System.Drawing.Size(70, 23);
            this.lblHorasFestivas.TabIndex = 7;
            this.lblHorasFestivas.Text = "0";
            this.lblHorasFestivas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechasRepetidas
            // 
            this.lblFechasRepetidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechasRepetidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechasRepetidas.Location = new System.Drawing.Point(119, 30);
            this.lblFechasRepetidas.Name = "lblFechasRepetidas";
            this.lblFechasRepetidas.Size = new System.Drawing.Size(70, 23);
            this.lblFechasRepetidas.TabIndex = 9;
            this.lblFechasRepetidas.Text = "0";
            this.lblFechasRepetidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(7, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fechas Repetidas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalExtras
            // 
            this.lblTotalExtras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalExtras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalExtras.Location = new System.Drawing.Point(119, 156);
            this.lblTotalExtras.Name = "lblTotalExtras";
            this.lblTotalExtras.Size = new System.Drawing.Size(70, 23);
            this.lblTotalExtras.TabIndex = 11;
            this.lblTotalExtras.Text = "0";
            this.lblTotalExtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(7, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Extras";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_FaCSVture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_FaCSVture";
            this.Text = "FaCSVture";
            this.Load += new System.EventHandler(this.frm_FaCSVture_Load);
            this.Shown += new System.EventHandler(this.frm_FaCSVture_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_FaCSVture_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNEntradas;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ToolStripMenuItem plantillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemTST;
        private System.Windows.Forms.ToolStripMenuItem itemMoney;
        private System.Windows.Forms.Label lblSuma1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechasRepetidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHorasFestivas;
        private System.Windows.Forms.Label lblHorasLaborables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitleHoras;
        private System.Windows.Forms.Label lblTotalExtras;
        private System.Windows.Forms.Label label6;
    }
}

