Public Class FormTaiLieu
    Dim SQL As New classConnectionDb

    Private Sub FormTaiLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tab1.ForeColor = Color.DodgerBlue
        SQL.ExecQuery("SELECT * FROM SACH")

        ' FormThemMoiTaiLieu1.Visible = False
        'FormSearchTaiLieu1.Visible = False
        Load_Grid()
        lb_soSach.Text = "(Có " & SQL.RecordCount & " đầu tài liệu)"


        ' Sua_Header()

    End Sub
    Private Sub Sua_Header()
        dgTaiLieu.DataSource = SQL.SQLDS.Tables(0)
        With dgTaiLieu
            .RowHeadersVisible = False
            .Columns(0).Name = "Ảnh bìa"
            .Columns(1).Name = "Mã sách"
            .Columns(2).Name = "Tên sách"
            .Columns(3).Name = "Số lượng tồn"
            .Columns(4).Name = "Giá bán"
            .Columns(5).Name = "Tác giả"
            .Columns(6).Name = "Thể loại"
            .Columns(7).Name = "Nhà xuất bản"

        End With
    End Sub

    Private Sub Load_Grid()
        If SQL.RecordCount > 0 Then
            dgTaiLieu.DataSource = SQL.SQLDS.Tables(0)
            dgTaiLieu.Rows(0).Selected = True







        End If
    End Sub

    Private Sub btnThemMoi_Click(sender As Object, e As EventArgs) Handles btnThemMoi.Click
        'FormThemMoiTaiLieu1.Visible = True
        ' FormThemMoiTaiLieu1.BringToFront()
        ' FormThemMoiTaiLieu1.Show()




    End Sub

    Private Sub tab1_Click(sender As Object, e As EventArgs) Handles tab1.Click
        trans1.Width = tab1.Width
        trans1.Left = tab1.Left
        tab1.ForeColor = Color.DodgerBlue
        tab2.ForeColor = Color.Black

        tab3.ForeColor = Color.Black
        tab4.ForeColor = Color.Black







    End Sub

    Private Sub tab2_Click(sender As Object, e As EventArgs) Handles tab2.Click

        trans1.Width = tab2.Width
        trans1.Left = tab2.Left
        tab2.ForeColor = Color.DodgerBlue
        tab1.ForeColor = Color.Black

        tab3.ForeColor = Color.Black
        tab4.ForeColor = Color.Black


    End Sub



    Private Sub tab3_Click(sender As Object, e As EventArgs) Handles tab3.Click
        trans1.Width = tab3.Width
        trans1.Left = tab3.Left
        tab3.ForeColor = Color.DodgerBlue
        tab2.ForeColor = Color.Black

        tab1.ForeColor = Color.Black
        tab4.ForeColor = Color.Black



    End Sub

    Private Sub tab4_Click(sender As Object, e As EventArgs) Handles tab4.Click
        trans1.Width = tab4.Width
        trans1.Left = tab4.Left
        tab4.ForeColor = Color.DodgerBlue
        tab2.ForeColor = Color.Black

        tab3.ForeColor = Color.Black
        tab1.ForeColor = Color.Black


    End Sub
End Class
