namespace ExemploLINQ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasLINQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereTiposAnonimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endsWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlgunsCamposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campoCalculadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andOrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrupamentoLINQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.innerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasLINQToolStripMenuItem,
            this.agrupamentoLINQToolStripMenuItem,
            this.agregaçãoToolStripMenuItem1,
            this.firstToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasLINQToolStripMenuItem
            // 
            this.consultasLINQToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemSimplesToolStripMenuItem,
            this.orderByToolStripMenuItem,
            this.whereToolStripMenuItem,
            this.whereStringToolStripMenuItem,
            this.whereTiposAnonimosToolStripMenuItem,
            this.containsToolStripMenuItem,
            this.startWithToolStripMenuItem,
            this.endsWithToolStripMenuItem,
            this.listarAlgunsCamposToolStripMenuItem,
            this.campoCalculadoToolStripMenuItem,
            this.andOrToolStripMenuItem});
            this.consultasLINQToolStripMenuItem.Name = "consultasLINQToolStripMenuItem";
            this.consultasLINQToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.consultasLINQToolStripMenuItem.Text = "Consultas LINQ";
            // 
            // listagemSimplesToolStripMenuItem
            // 
            this.listagemSimplesToolStripMenuItem.Name = "listagemSimplesToolStripMenuItem";
            this.listagemSimplesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listagemSimplesToolStripMenuItem.Text = "Listagem Simples";
            this.listagemSimplesToolStripMenuItem.Click += new System.EventHandler(this.listagemSimplesToolStripMenuItem_Click);
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.orderByToolStripMenuItem.Text = "Order By";
            this.orderByToolStripMenuItem.Click += new System.EventHandler(this.orderByToolStripMenuItem_Click);
            // 
            // whereToolStripMenuItem
            // 
            this.whereToolStripMenuItem.Name = "whereToolStripMenuItem";
            this.whereToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.whereToolStripMenuItem.Text = "Where";
            this.whereToolStripMenuItem.Click += new System.EventHandler(this.whereToolStripMenuItem_Click);
            // 
            // whereStringToolStripMenuItem
            // 
            this.whereStringToolStripMenuItem.Name = "whereStringToolStripMenuItem";
            this.whereStringToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.whereStringToolStripMenuItem.Text = "Where String";
            this.whereStringToolStripMenuItem.Click += new System.EventHandler(this.whereStringToolStripMenuItem_Click);
            // 
            // whereTiposAnonimosToolStripMenuItem
            // 
            this.whereTiposAnonimosToolStripMenuItem.Name = "whereTiposAnonimosToolStripMenuItem";
            this.whereTiposAnonimosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.whereTiposAnonimosToolStripMenuItem.Text = "Where Tipos Anonimos";
            this.whereTiposAnonimosToolStripMenuItem.Click += new System.EventHandler(this.whereTiposAnonimosToolStripMenuItem_Click);
            // 
            // containsToolStripMenuItem
            // 
            this.containsToolStripMenuItem.Name = "containsToolStripMenuItem";
            this.containsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.containsToolStripMenuItem.Text = "Contains";
            this.containsToolStripMenuItem.Click += new System.EventHandler(this.containsToolStripMenuItem_Click);
            // 
            // startWithToolStripMenuItem
            // 
            this.startWithToolStripMenuItem.Name = "startWithToolStripMenuItem";
            this.startWithToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.startWithToolStripMenuItem.Text = "StartWith";
            this.startWithToolStripMenuItem.Click += new System.EventHandler(this.startWithToolStripMenuItem_Click);
            // 
            // endsWithToolStripMenuItem
            // 
            this.endsWithToolStripMenuItem.Name = "endsWithToolStripMenuItem";
            this.endsWithToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.endsWithToolStripMenuItem.Text = "EndsWith";
            this.endsWithToolStripMenuItem.Click += new System.EventHandler(this.endsWithToolStripMenuItem_Click);
            // 
            // listarAlgunsCamposToolStripMenuItem
            // 
            this.listarAlgunsCamposToolStripMenuItem.Name = "listarAlgunsCamposToolStripMenuItem";
            this.listarAlgunsCamposToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listarAlgunsCamposToolStripMenuItem.Text = "Listar Alguns Campos";
            this.listarAlgunsCamposToolStripMenuItem.Click += new System.EventHandler(this.listarAlgunsCamposToolStripMenuItem_Click);
            // 
            // campoCalculadoToolStripMenuItem
            // 
            this.campoCalculadoToolStripMenuItem.Name = "campoCalculadoToolStripMenuItem";
            this.campoCalculadoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.campoCalculadoToolStripMenuItem.Text = "campoCalculado";
            this.campoCalculadoToolStripMenuItem.Click += new System.EventHandler(this.campoCalculadoToolStripMenuItem_Click);
            // 
            // andOrToolStripMenuItem
            // 
            this.andOrToolStripMenuItem.Name = "andOrToolStripMenuItem";
            this.andOrToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.andOrToolStripMenuItem.Text = "And Or";
            this.andOrToolStripMenuItem.Click += new System.EventHandler(this.andOrToolStripMenuItem_Click);
            // 
            // agrupamentoLINQToolStripMenuItem
            // 
            this.agrupamentoLINQToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.innerToolStripMenuItem});
            this.agrupamentoLINQToolStripMenuItem.Name = "agrupamentoLINQToolStripMenuItem";
            this.agrupamentoLINQToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.agrupamentoLINQToolStripMenuItem.Text = "Agrupamento LINQ";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // innerToolStripMenuItem
            // 
            this.innerToolStripMenuItem.Name = "innerToolStripMenuItem";
            this.innerToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.innerToolStripMenuItem.Text = "Inner";
            this.innerToolStripMenuItem.Click += new System.EventHandler(this.innerToolStripMenuItem_Click);
            // 
            // agregaçãoToolStripMenuItem1
            // 
            this.agregaçãoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minMaxToolStripMenuItem,
            this.médiaToolStripMenuItem});
            this.agregaçãoToolStripMenuItem1.Name = "agregaçãoToolStripMenuItem1";
            this.agregaçãoToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.agregaçãoToolStripMenuItem1.Text = "Agregação";
            // 
            // minMaxToolStripMenuItem
            // 
            this.minMaxToolStripMenuItem.Name = "minMaxToolStripMenuItem";
            this.minMaxToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.minMaxToolStripMenuItem.Text = "Min Max";
            this.minMaxToolStripMenuItem.Click += new System.EventHandler(this.minMaxToolStripMenuItem_Click);
            // 
            // médiaToolStripMenuItem
            // 
            this.médiaToolStripMenuItem.Name = "médiaToolStripMenuItem";
            this.médiaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.médiaToolStripMenuItem.Text = "Média";
            this.médiaToolStripMenuItem.Click += new System.EventHandler(this.médiaToolStripMenuItem_Click);
            // 
            // firstToolStripMenuItem
            // 
            this.firstToolStripMenuItem.Name = "firstToolStripMenuItem";
            this.firstToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.firstToolStripMenuItem.Text = "First";
            this.firstToolStripMenuItem.Click += new System.EventHandler(this.firstToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.Location = new System.Drawing.Point(0, 24);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(781, 356);
            this.dgv.TabIndex = 1;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 380);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStripMenuItem consultasLINQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whereStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whereTiposAnonimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endsWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlgunsCamposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campoCalculadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem andOrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrupamentoLINQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem innerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstToolStripMenuItem;
    }
}

