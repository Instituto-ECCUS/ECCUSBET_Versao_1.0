<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SizingView
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SizingView))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnDimensionat = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Sizing = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtVoldaBet = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtAreadaBet = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtProfundidadeMedia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtVolUtio = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SelecaoPadrao = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNPessoas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIntervalo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTemperatura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Analyze = New System.Windows.Forms.TabPage()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnAnalise = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VolUtioGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfundidadeGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VolTotalGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimparToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CarregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesenvolvedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.Sizing.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Analyze.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnDimensionat
        '
        Me.BtnDimensionat.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnDimensionat.Location = New System.Drawing.Point(322, 57)
        Me.BtnDimensionat.Name = "BtnDimensionat"
        Me.BtnDimensionat.Size = New System.Drawing.Size(102, 31)
        Me.BtnDimensionat.TabIndex = 0
        Me.BtnDimensionat.Text = "Dimensionar"
        Me.BtnDimensionat.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Sizing)
        Me.TabControl1.Controls.Add(Me.Analyze)
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(685, 385)
        Me.TabControl1.TabIndex = 3
        '
        'Sizing
        '
        Me.Sizing.BackColor = System.Drawing.Color.Teal
        Me.Sizing.Controls.Add(Me.Label10)
        Me.Sizing.Controls.Add(Me.TxtVoldaBet)
        Me.Sizing.Controls.Add(Me.Label11)
        Me.Sizing.Controls.Add(Me.TxtAreadaBet)
        Me.Sizing.Controls.Add(Me.Label8)
        Me.Sizing.Controls.Add(Me.TxtProfundidadeMedia)
        Me.Sizing.Controls.Add(Me.Label7)
        Me.Sizing.Controls.Add(Me.TxtVolUtio)
        Me.Sizing.Controls.Add(Me.PictureBox1)
        Me.Sizing.Controls.Add(Me.Panel1)
        Me.Sizing.Controls.Add(Me.BtnDimensionat)
        Me.Sizing.Location = New System.Drawing.Point(4, 22)
        Me.Sizing.Name = "Sizing"
        Me.Sizing.Padding = New System.Windows.Forms.Padding(3)
        Me.Sizing.Size = New System.Drawing.Size(677, 359)
        Me.Sizing.TabIndex = 0
        Me.Sizing.Text = "Dimensionamento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(394, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Volume da Bet (m³)"
        '
        'TxtVoldaBet
        '
        Me.TxtVoldaBet.Enabled = False
        Me.TxtVoldaBet.Location = New System.Drawing.Point(397, 198)
        Me.TxtVoldaBet.Name = "TxtVoldaBet"
        Me.TxtVoldaBet.Size = New System.Drawing.Size(77, 20)
        Me.TxtVoldaBet.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(277, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Área (m²)"
        '
        'TxtAreadaBet
        '
        Me.TxtAreadaBet.Enabled = False
        Me.TxtAreadaBet.Location = New System.Drawing.Point(280, 198)
        Me.TxtAreadaBet.Name = "TxtAreadaBet"
        Me.TxtAreadaBet.Size = New System.Drawing.Size(77, 20)
        Me.TxtAreadaBet.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Profundidade média (m)"
        '
        'TxtProfundidadeMedia
        '
        Me.TxtProfundidadeMedia.Enabled = False
        Me.TxtProfundidadeMedia.Location = New System.Drawing.Point(397, 143)
        Me.TxtProfundidadeMedia.Name = "TxtProfundidadeMedia"
        Me.TxtProfundidadeMedia.Size = New System.Drawing.Size(77, 20)
        Me.TxtProfundidadeMedia.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(277, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Volume útil (m³)"
        '
        'TxtVolUtio
        '
        Me.TxtVolUtio.Enabled = False
        Me.TxtVolUtio.Location = New System.Drawing.Point(280, 143)
        Me.TxtVolUtio.Name = "TxtVolUtio"
        Me.TxtVolUtio.Size = New System.Drawing.Size(77, 20)
        Me.TxtVolUtio.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(554, 268)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 91)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.SelecaoPadrao)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtNPessoas)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtIntervalo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtTemperatura)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 356)
        Me.Panel1.TabIndex = 4
        '
        'SelecaoPadrao
        '
        Me.SelecaoPadrao.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SelecaoPadrao.FormattingEnabled = True
        Me.SelecaoPadrao.Items.AddRange(New Object() {"Residência padrão baixo", "Residência padrão médio", "Residência padrão alto", "Hotel", "Alojamento provisório"})
        Me.SelecaoPadrao.Location = New System.Drawing.Point(8, 71)
        Me.SelecaoPadrao.Name = "SelecaoPadrao"
        Me.SelecaoPadrao.Size = New System.Drawing.Size(121, 21)
        Me.SelecaoPadrao.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Número de pessoas = "
        '
        'TxtNPessoas
        '
        Me.TxtNPessoas.Location = New System.Drawing.Point(153, 187)
        Me.TxtNPessoas.Name = "TxtNPessoas"
        Me.TxtNPessoas.Size = New System.Drawing.Size(77, 20)
        Me.TxtNPessoas.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Intervalo de limpeza (anos) = "
        '
        'TxtIntervalo
        '
        Me.TxtIntervalo.Location = New System.Drawing.Point(153, 157)
        Me.TxtIntervalo.Name = "TxtIntervalo"
        Me.TxtIntervalo.Size = New System.Drawing.Size(77, 20)
        Me.TxtIntervalo.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Temperatura (°C) = "
        '
        'TxtTemperatura
        '
        Me.TxtTemperatura.Location = New System.Drawing.Point(153, 127)
        Me.TxtTemperatura.Name = "TxtTemperatura"
        Me.TxtTemperatura.Size = New System.Drawing.Size(77, 20)
        Me.TxtTemperatura.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Padrão da residênbcia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dados de entrada"
        '
        'Analyze
        '
        Me.Analyze.BackColor = System.Drawing.Color.Teal
        Me.Analyze.Controls.Add(Me.BtnExportar)
        Me.Analyze.Controls.Add(Me.PictureBox2)
        Me.Analyze.Controls.Add(Me.BtnAnalise)
        Me.Analyze.Controls.Add(Me.Chart1)
        Me.Analyze.Controls.Add(Me.DataGridView1)
        Me.Analyze.Location = New System.Drawing.Point(4, 22)
        Me.Analyze.Name = "Analyze"
        Me.Analyze.Padding = New System.Windows.Forms.Padding(3)
        Me.Analyze.Size = New System.Drawing.Size(677, 359)
        Me.Analyze.TabIndex = 1
        Me.Analyze.Text = "Análise"
        '
        'BtnExportar
        '
        Me.BtnExportar.Location = New System.Drawing.Point(582, 101)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(74, 35)
        Me.BtnExportar.TabIndex = 8
        Me.BtnExportar.Text = "Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(554, 268)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 91)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'BtnAnalise
        '
        Me.BtnAnalise.Location = New System.Drawing.Point(473, 101)
        Me.BtnAnalise.Name = "BtnAnalise"
        Me.BtnAnalise.Size = New System.Drawing.Size(75, 35)
        Me.BtnAnalise.TabIndex = 2
        Me.BtnAnalise.Text = "Analizar"
        Me.BtnAnalise.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.DarkGray
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Chart1.BackImageTransparentColor = System.Drawing.Color.White
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart1.BorderSkin.BackColor = System.Drawing.SystemColors.ActiveCaption
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(8, 151)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.Chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(443, 197)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VolUtioGrid, Me.ProfundidadeGrid, Me.AreaGrid, Me.VolTotalGrid})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(9, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.DataGridView1.Size = New System.Drawing.Size(443, 119)
        Me.DataGridView1.TabIndex = 0
        '
        'VolUtioGrid
        '
        Me.VolUtioGrid.HeaderText = "Volume útil (m²)"
        Me.VolUtioGrid.Name = "VolUtioGrid"
        Me.VolUtioGrid.ReadOnly = True
        '
        'ProfundidadeGrid
        '
        Me.ProfundidadeGrid.HeaderText = "Profundidade (m)"
        Me.ProfundidadeGrid.Name = "ProfundidadeGrid"
        Me.ProfundidadeGrid.ReadOnly = True
        '
        'AreaGrid
        '
        Me.AreaGrid.HeaderText = "Ária (m²)"
        Me.AreaGrid.Name = "AreaGrid"
        Me.AreaGrid.ReadOnly = True
        '
        'VolTotalGrid
        '
        Me.VolTotalGrid.HeaderText = "Volume total (m³)"
        Me.VolTotalGrid.Name = "VolTotalGrid"
        Me.VolTotalGrid.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.ManualToolStripMenuItem, Me.DesenvolvedorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimparToolStripMenuItem, Me.ToolStripSeparator1, Me.SalvarToolStripMenuItem, Me.ToolStripSeparator2, Me.CarregarToolStripMenuItem, Me.ToolStripSeparator3, Me.SairToolStripMenuItem, Me.ToolStripSeparator4, Me.SairToolStripMenuItem1})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'LimparToolStripMenuItem
        '
        Me.LimparToolStripMenuItem.Image = CType(resources.GetObject("LimparToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LimparToolStripMenuItem.Name = "LimparToolStripMenuItem"
        Me.LimparToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LimparToolStripMenuItem.Text = "Limpar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Enabled = False
        Me.SalvarToolStripMenuItem.Image = CType(resources.GetObject("SalvarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalvarToolStripMenuItem.Text = "Salvar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'CarregarToolStripMenuItem
        '
        Me.CarregarToolStripMenuItem.Enabled = False
        Me.CarregarToolStripMenuItem.Image = CType(resources.GetObject("CarregarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CarregarToolStripMenuItem.Name = "CarregarToolStripMenuItem"
        Me.CarregarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CarregarToolStripMenuItem.Text = "Carregar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Enabled = False
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SairToolStripMenuItem.Text = "Excluir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Image = CType(resources.GetObject("SairToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'DesenvolvedorToolStripMenuItem
        '
        Me.DesenvolvedorToolStripMenuItem.Name = "DesenvolvedorToolStripMenuItem"
        Me.DesenvolvedorToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.DesenvolvedorToolStripMenuItem.Text = "Desenvolvedor"
        '
        'SizingView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(684, 411)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "SizingView"
        Me.Text = "ECCUSBET"
        Me.TabControl1.ResumeLayout(False)
        Me.Sizing.ResumeLayout(False)
        Me.Sizing.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Analyze.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDimensionat As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Sizing As TabPage
    Friend WithEvents Analyze As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimparToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CarregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesenvolvedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTemperatura As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIntervalo As TextBox
    Friend WithEvents TxtVolUtio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtProfundidadeMedia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNPessoas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtVoldaBet As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtAreadaBet As TextBox
    Friend WithEvents SelecaoPadrao As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VolUtioGrid As DataGridViewTextBoxColumn
    Friend WithEvents ProfundidadeGrid As DataGridViewTextBoxColumn
    Friend WithEvents AreaGrid As DataGridViewTextBoxColumn
    Friend WithEvents VolTotalGrid As DataGridViewTextBoxColumn
    Friend WithEvents BtnAnalise As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents BtnExportar As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
