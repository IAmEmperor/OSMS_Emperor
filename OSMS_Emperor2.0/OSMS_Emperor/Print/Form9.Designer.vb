<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bz = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.xm = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cz = New System.Windows.Forms.TextBox
        Me.tel = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.sj = New System.Windows.Forms.TextBox
        Me.rq = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dw = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.序号 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.品名 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.myp = New VBprinter.VB2008Print
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.myp)
        Me.SplitContainer1.Size = New System.Drawing.Size(950, 506)
        Me.SplitContainer1.SplitterDistance = 303
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bz)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.xm)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cz)
        Me.GroupBox1.Controls.Add(Me.tel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.sj)
        Me.GroupBox1.Controls.Add(Me.rq)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dw)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "尾部要打印的内容"
        '
        'bz
        '
        Me.bz.Location = New System.Drawing.Point(71, 73)
        Me.bz.Name = "bz"
        Me.bz.Size = New System.Drawing.Size(664, 21)
        Me.bz.TabIndex = 1
        Me.bz.Text = "这是备注的内容"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "传真："
        '
        'xm
        '
        Me.xm.Location = New System.Drawing.Point(318, 19)
        Me.xm.Name = "xm"
        Me.xm.Size = New System.Drawing.Size(178, 21)
        Me.xm.TabIndex = 1
        Me.xm.Text = "张三"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(510, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "手机："
        '
        'cz
        '
        Me.cz.Location = New System.Drawing.Point(318, 46)
        Me.cz.Name = "cz"
        Me.cz.Size = New System.Drawing.Size(178, 21)
        Me.cz.TabIndex = 1
        Me.cz.Text = "0731"
        '
        'tel
        '
        Me.tel.Location = New System.Drawing.Point(71, 46)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(178, 21)
        Me.tel.TabIndex = 1
        Me.tel.Text = "0731-1252215"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "联系人："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "单位："
        '
        'sj
        '
        Me.sj.Location = New System.Drawing.Point(557, 19)
        Me.sj.Name = "sj"
        Me.sj.Size = New System.Drawing.Size(178, 21)
        Me.sj.TabIndex = 1
        Me.sj.Text = "12345583933"
        '
        'rq
        '
        Me.rq.Location = New System.Drawing.Point(557, 46)
        Me.rq.Name = "rq"
        Me.rq.Size = New System.Drawing.Size(178, 21)
        Me.rq.TabIndex = 1
        Me.rq.Text = "2011年2月8日"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "电话："
        '
        'dw
        '
        Me.dw.Location = New System.Drawing.Point(71, 19)
        Me.dw.Name = "dw"
        Me.dw.Size = New System.Drawing.Size(178, 21)
        Me.dw.TabIndex = 1
        Me.dw.Text = "中南林业科技大学"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "备注："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(510, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "日期："
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(562, 267)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(250, 28)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "用第三种方法打印预览"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(290, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(250, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "用第二种方法打印预览"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "用第一种方法打印预览"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.序号, Me.品名, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.GridColor = System.Drawing.Color.Black
        Me.dgv1.Location = New System.Drawing.Point(1, 112)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 23
        Me.dgv1.Size = New System.Drawing.Size(937, 149)
        Me.dgv1.TabIndex = 2
        '
        '序号
        '
        Me.序号.HeaderText = "序号"
        Me.序号.Name = "序号"
        '
        '品名
        '
        Me.品名.HeaderText = "品名"
        Me.品名.Name = "品名"
        '
        'Column1
        '
        Me.Column1.HeaderText = "规格"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "单位"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "数量"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "单价"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "小计金额"
        Me.Column5.Name = "Column5"
        '
        'myp
        '
        Me.myp.CanOpenReport = True
        Me.myp.CanSaveReport = True
        Me.myp.CellMargin = New System.Drawing.Printing.Margins(3, 3, 3, 3)
        Me.myp.Currentx = 0.0!
        Me.myp.Currenty = 0.0!
        Me.myp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.myp.DocumentName = "VB2008打印控件"
        Me.myp.DoubleLineSpace = 4.0!
        Me.myp.EnabledPageSetting = True
        Me.myp.EnabledPrint = True
        Me.myp.EnablePrintDraft = True
        Me.myp.EnableSaveAsImage = True
        Me.myp.EnableSaveAsPDF = True
        Me.myp.IsAutoAddEmptyRow = False
        Me.myp.IsAutoAdjustPrinterMargin = True
        Me.myp.IsDGVCellValignmentCenter = True
        Me.myp.IsDrawmargin = True
        Me.myp.IsDrawPageFooterLine = False
        Me.myp.IsDrawPageHeaderLine = False
        Me.myp.IsDrawTableFooterEveryPage = False
        Me.myp.IsDrawZDX = False
        Me.myp.IsImmediatePrintNotPreview = False
        Me.myp.IsImmediatePrintNotPreviewShowPrintDialog = False
        Me.myp.IsNeedCheckNewPage = True
        Me.myp.IsNeedPrintPageHeaderAndFooter = True
        Me.myp.IsShowContextMenu = True
        Me.myp.IsShowErrorMSG = True
        Me.myp.IsShowMessageIfPrinterNotSupportPaper = True
        Me.myp.IsShowPageContinues = False
        Me.myp.IsShowPrintStatusDialog = True
        Me.myp.IsShowProgess = True
        Me.myp.IsUseAPIprintDialog = False
        Me.myp.IsUseDGVPadding = True
        Me.myp.IsUseDoubleLine = False
        Me.myp.Location = New System.Drawing.Point(0, 0)
        Me.myp.Name = "myp"
        Me.myp.OffsetX = 0.0!
        Me.myp.OffsetY = 0.0!
        Me.myp.OuterBorder = False
        Me.myp.OuterBorderColor = System.Drawing.Color.Black
        Me.myp.OuterBorderWidth = 2.0!
        Me.myp.PageScale = 1.0!
        Me.myp.PageUnits = VBprinter.VB2008Print.PageExportUnit.CentiMeter
        Me.myp.PaperBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.myp.PaperForeColor = System.Drawing.Color.White
        Me.myp.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.myp.PaperLandscape = False
        Me.myp.PaperMargins = New System.Drawing.Printing.Margins(254, 254, 254, 254)
        Me.myp.PaperSize = CType(resources.GetObject("myp.PaperSize"), System.Drawing.Printing.PaperSize)
        Me.myp.ShapeDepth = 20
        Me.myp.Size = New System.Drawing.Size(950, 199)
        Me.myp.TabIndex = 3
        Me.myp.TextColor = System.Drawing.Color.Black
        Me.myp.TextFont = New System.Drawing.Font("宋体", 9.0!)
        Me.myp.ToolBarVisible = True
        Me.myp.UseAntiAlias = True
        Me.myp.WaterMarkColor = System.Drawing.Color.Red
        Me.myp.WaterMarkFont = New System.Drawing.Font("华文行楷", 80.0!, System.Drawing.FontStyle.Bold)
        Me.myp.WaterMarkLandscape = True
        Me.myp.WaterMarkOpacity = CType(128, Byte)
        Me.myp.WaterMarkText = ""
        Me.myp.ZDXFont = New System.Drawing.Font("宋体", 9.0!)
        Me.myp.ZDXLinecoLor = System.Drawing.Color.Black
        Me.myp.ZDXLineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.myp.ZDXPosition = 0.0!
        Me.myp.ZDXText = "装订线"
        Me.myp.ZDXTextColor = System.Drawing.Color.Black
        Me.myp.ZDXType = VBprinter.VB2008Print.TheZDXTYPE.LEFT
        Me.myp.ZDYButton2Text = ""
        Me.myp.ZDYButton2ToolTipText = ""
        Me.myp.ZDYButton2Visible = False
        Me.myp.ZDYButtonText = ""
        Me.myp.ZDYButtonToolTipText = ""
        Me.myp.ZDYButtonVisible = True
        Me.myp.Zoom = 1
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 506)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form9"
        Me.Text = "打印报价单的演示，用到了一些技巧"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents xm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dw As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents rq As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sj As System.Windows.Forms.TextBox
    Friend WithEvents cz As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents myp As VBprinter.VB2008Print
    Friend WithEvents 序号 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 品名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bz As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
