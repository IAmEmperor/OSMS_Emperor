Public Class Form9
    Private mytype As Integer = 1
    Private Sub Form9_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '构建测试数据
        dgv1.RowCount = 5
        For i As Integer = 0 To 4
            dgv1.Rows(i).Cells(0).Value = i
            dgv1.Rows(i).Cells(1).Value = "电缆"
            dgv1.Rows(i).Cells(3).Value = "米"
        Next
        For i As Integer = 0 To 4
            dgv1.Rows(i).Cells(2).Value = 50 + i
        Next

        dgv1.Rows(0).Cells(4).Value = 10
        dgv1.Rows(0).Cells(5).Value = 50
        dgv1.Rows(0).Cells(6).Value = 500

        dgv1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        dgv1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        dgv1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mytype = 1 '用第一种方法打印
        myp.InvalidatePreview()
    End Sub

    Private Sub myp_PrintDocument() Handles myp.PrintDocument
        If mytype = 1 Then
            '用第一种方法 打印
            FF1()
        ElseIf mytype = 2 Then
            '用第二种方法打印
            FF2()
        ElseIf mytype = 3 Then
            ff3()
        End If
       
    End Sub
    Private Sub FF1()
        '第一种打印实现方法
        myp.NewPage()
        Dim title As String
        title = dw.Text & "报价单" & "（用第一种方法实现打印）"
        Dim titlefont As New Font("黑体", 18, FontStyle.Bold)
        myp.PrintDGV(dgv1, title, titlefont, StringAlignment.Center, "1111", True, True, 0, True, False, 0, 0, True, Nothing)
        '取合计数
        Dim sumnum As Single = 0
        For i As Integer = 0 To dgv1.RowCount - 1
            If IsNumeric(dgv1.Rows(i).Cells(6).Value) Then
                sumnum = sumnum + CDec(dgv1.Rows(i).Cells(6).Value)
            End If
        Next
        Dim smallje As String
        smallje = "金额合计(小写)：" & Format(sumnum, "#,###,###,###,##0.00")
        Dim bigje As String
        bigje = "总计金额（大写）：" & myp.SmallToBig(sumnum) '大写金额"

        Dim jefont As New Font("黑体", 12, FontStyle.Bold)
        Dim mysize As SizeF
        myp.CellMargin = New System.Drawing.Printing.Margins(15, 15, 15, 15)
        mysize = myp.MeasureCell(smallje, jefont) '需要的大小


        myp.DrawCell(bigje, myp.PaperPrintWidth - mysize.Width, mysize.Height, jefont, Color.Red, "1001", StringAlignment.Near, StringAlignment.Center, False, False, False, False, 6, Color.Empty, Color.Black, 0)


        myp.DrawCell(smallje, mysize.Width, mysize.Height, jefont, Color.Red, "0011", StringAlignment.Near, StringAlignment.Center, False, False, False, False, 6, Color.Empty, Color.Black, 0)

        myp.NewRow(mysize.Height)
        myp.NewRow(20)
        Dim mytextfont As New Font("宋体", 13)

        myp.DrawText("备注：" & bz.Text, myp.PaperPrintWidth, mytextfont, 0)
        myp.NewRow(myp.LastDrawTextHeight)
        myp.NewRow(30)
        Dim maxlineheight As Single
        myp.DrawText("联系人：" & xm.Text, myp.PaperPrintWidth / 3, mytextfont, 0)
        maxlineheight = myp.LastDrawTextHeight

        myp.Currentx = myp.PaperPrintWidth / 3
        myp.DrawText("手机：" & sj.Text, myp.PaperPrintWidth / 3, mytextfont, 0)
        If myp.LastDrawTextHeight > maxlineheight Then
            maxlineheight = myp.LastDrawTextHeight
        End If
        Dim mystringformat As New StringFormat(StringFormat.GenericTypographic)
        mystringformat.Alignment = StringAlignment.Far '右对齐
        myp.Currentx = myp.PaperPrintWidth / 3 * 2
        myp.DrawText(dw.Text, myp.PaperPrintWidth / 3, mytextfont, Color.Black, mystringformat, 0) '右对齐输出
        If myp.LastDrawTextHeight > maxlineheight Then
            maxlineheight = myp.LastDrawTextHeight
        End If

        myp.NewRow(maxlineheight)
        myp.NewRow(30)

        myp.DrawText("电话：" & tel.Text, myp.PaperPrintWidth / 3, mytextfont, 0)
        myp.Currentx = myp.PaperPrintWidth / 3
        myp.DrawText("传真：" & cz.Text, myp.PaperPrintWidth / 3, mytextfont, 0)

        mystringformat.Alignment = StringAlignment.Far '右对齐
        myp.Currentx = myp.PaperPrintWidth / 3 * 2
        myp.DrawText("报价日期：" & rq.Text, myp.PaperPrintWidth / 3, mytextfont, Color.Black, mystringformat, 0) '右对齐输出
    End Sub
    Private Sub FF2()
        '第二种打印实现方法,未考虑到金额列的移动哦，通用性较差，但也是一个很好的实现思路,但原则不适合有数据绑定的DataGridView
        myp.NewPage()
        Dim title As String
        title = dw.Text & "报价单" & "（另一种打印方法实现打印）"
        Dim titlefont As New Font("黑体", 18, FontStyle.Bold)

        '取合计数
        Dim sumnum As Single = 0
        For i As Integer = 0 To dgv1.RowCount - 1
            If IsNumeric(dgv1.Rows(i).Cells(6).Value) Then
                sumnum = sumnum + CDec(dgv1.Rows(i).Cells(6).Value)
            End If
        Next
        Dim smallje As String
        smallje = "金额合计(小写)：" & Format(sumnum, "#,###,###,###,##0.00")
        Dim bigje As String
        bigje = "总计金额（大写）：" & myp.SmallToBig(sumnum) '大写金额"


        Dim jefont As New Font("黑体", 12, FontStyle.Bold)

        Dim tempdgv As New DataGridView
        myp.CopyDataGridView(dgv1, tempdgv, False)
        tempdgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        tempdgv.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
        tempdgv.RowCount = tempdgv.RowCount + 1 '加一行合计行
        For i As Integer = 0 To tempdgv.ColumnCount - 3
            tempdgv.Rows(tempdgv.RowCount - 1).Cells(i).Value = bigje
        Next
        tempdgv.Rows(tempdgv.RowCount - 1).Cells(tempdgv.ColumnCount - 1).Value = smallje
        tempdgv.Rows(tempdgv.RowCount - 1).Tag = "合并"
        tempdgv.Rows(tempdgv.RowCount - 1).Cells(tempdgv.ColumnCount - 2).Value = smallje
        tempdgv.Rows(tempdgv.RowCount - 1).Tag = "合并"
        tempdgv.Rows(tempdgv.RowCount - 1).DefaultCellStyle.ForeColor = Color.Red
        tempdgv.Rows(tempdgv.RowCount - 1).DefaultCellStyle.Font = jefont
        myp.PrintDGV(tempdgv, title, titlefont, StringAlignment.Center, "1111", True, False, 6, True, False, 0, 0, False, Nothing)




        myp.NewRow(20)
        Dim mytextfont As New Font("宋体", 13)

        myp.DrawText("备注：" & bz.Text, myp.PaperPrintWidth, mytextfont, 0)
        myp.NewRow(myp.LastDrawTextHeight)
        myp.NewRow(30)
        Dim maxlineheight As Single
        myp.DrawText("联系人：" & xm.Text, myp.PaperPrintWidth / 3, mytextfont, 0)
        maxlineheight = myp.LastDrawTextHeight

        myp.Currentx = myp.PaperPrintWidth / 3
        myp.DrawText("手机：" & sj.Text, myp.PaperPrintWidth / 3, mytextfont, 0)
        If myp.LastDrawTextHeight > maxlineheight Then
            maxlineheight = myp.LastDrawTextHeight
        End If
        Dim mystringformat As New StringFormat(StringFormat.GenericTypographic)
        mystringformat.Alignment = StringAlignment.Far '右对齐
        myp.Currentx = myp.PaperPrintWidth / 3 * 2
        myp.DrawText(dw.Text, myp.PaperPrintWidth / 3, mytextfont, Color.Black, mystringformat, 0) '右对齐输出
        If myp.LastDrawTextHeight > maxlineheight Then
            maxlineheight = myp.LastDrawTextHeight
        End If

        myp.NewRow(maxlineheight)
        myp.NewRow(30)

        myp.DrawText("电话：" & tel.Text, myp.PaperPrintWidth / 3, mytextfont, 0)
        myp.Currentx = myp.PaperPrintWidth / 3
        myp.DrawText("传真：" & cz.Text, myp.PaperPrintWidth / 3, mytextfont, 0)

        mystringformat.Alignment = StringAlignment.Far '右对齐
        myp.Currentx = myp.PaperPrintWidth / 3 * 2
        myp.DrawText("报价日期：" & rq.Text, myp.PaperPrintWidth / 3, mytextfont, Color.Black, mystringformat, 0) '右对齐输出
    End Sub
    Private Sub ff3()
        '第一种打印实现方法
        myp.NewPage()
        Dim title As String
        title = dw.Text & "报价单" & "（用第一种方法实现打印）"
        Dim titlefont As New Font("黑体", 18, FontStyle.Bold)
        myp.PrintDGV(dgv1, title, titlefont, StringAlignment.Center, "1111", True, True, 6, True, False, 0, 0, True, Nothing)
        '取合计数
        Dim sumnum As Single = 0
        For i As Integer = 0 To dgv1.RowCount - 1
            If IsNumeric(dgv1.Rows(i).Cells(6).Value) Then
                sumnum = sumnum + CDec(dgv1.Rows(i).Cells(6).Value)
            End If
        Next
        Dim smallje As String
        smallje = "金额合计(小写)：" & Format(sumnum, "#,###,###,###,##0.00")
        Dim bigje As String
        bigje = "总计金额（大写）：" & myp.SmallToBig(sumnum) '大写金额"

        Dim jefont As New Font("黑体", 12, FontStyle.Bold)
        Dim mysize As SizeF
        myp.CellMargin = New System.Drawing.Printing.Margins(15, 15, 15, 15)
        mysize = myp.MeasureCell(smallje, jefont) '需要的大小


        myp.DrawCell(bigje, myp.PaperPrintWidth - mysize.Width, mysize.Height, jefont, Color.Red, "1001", StringAlignment.Near, StringAlignment.Center, False, False, False, False, 6, Color.Empty, Color.Black, 0)


        myp.DrawCell(smallje, mysize.Width, mysize.Height, jefont, Color.Red, "0011", StringAlignment.Near, StringAlignment.Center, False, False, False, False, 6, Color.Empty, Color.Black, 0)

        myp.NewRow(mysize.Height)
        myp.NewRow(20)
        myp.DrawPanel(GroupBox1, False)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mytype = 2
        myp.InvalidatePreview()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mytype = 3
        myp.InvalidatePreview()
    End Sub
End Class