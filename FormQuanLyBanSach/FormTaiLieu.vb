Public Class FormTaiLieu
    Dim SQL As New classConnectionDb
    Dim index As Integer

    Dim lan As Integer


    Private Sub FormTaiLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tab1.ForeColor = Color.DodgerBlue
        txtTimKiem.Visible = False
        lan = 1

        hienThi("SELECT * FROM SACH")


    End Sub



    Private Sub Load_Grid()
        If SQL.RecordCount > 0 Then
            dgTaiLieu.DataSource = SQL.SQLDS.Tables(0)
            dgTaiLieu.Rows(0).Selected = True


        End If
    End Sub

    Private Sub hienThi(Bang As String)
        SQL.ExecQuery(Bang)
        Load_Grid()
        lb_soSach.Text = "(Có " & SQL.RecordCount & " đầu tài liệu)"
    End Sub



    Private Sub tab1_Click(sender As Object, e As EventArgs) Handles tab1.Click
        trans1.Width = tab1.Width
        trans1.Left = tab1.Left
        tab1.ForeColor = Color.DodgerBlue
        tab2.ForeColor = Color.Black
        tab5.ForeColor = Color.Black
        tab3.ForeColor = Color.Black
        tab4.ForeColor = Color.Black
        hienThi("SELECT * FROM SACH")




    End Sub

    Private Sub tab2_Click(sender As Object, e As EventArgs) Handles tab2.Click

        trans1.Width = tab2.Width
        trans1.Left = tab2.Left
        tab2.ForeColor = Color.DodgerBlue
        tab1.ForeColor = Color.Black
        tab5.ForeColor = Color.Black
        tab3.ForeColor = Color.Black
        tab4.ForeColor = Color.Black
        hienThi("SELECT * FROM TACGIA")
    End Sub



    Private Sub tab3_Click(sender As Object, e As EventArgs) Handles tab3.Click
        trans1.Width = tab3.Width
        trans1.Left = tab3.Left
        tab3.ForeColor = Color.DodgerBlue
        tab2.ForeColor = Color.Black
        tab5.ForeColor = Color.Black
        tab1.ForeColor = Color.Black
        tab4.ForeColor = Color.Black
        hienThi("SELECT * FROM THELOAI")


    End Sub

    Private Sub tab4_Click(sender As Object, e As EventArgs) Handles tab4.Click
        trans1.Width = tab4.Width
        trans1.Left = tab4.Left
        tab4.ForeColor = Color.DodgerBlue
        tab2.ForeColor = Color.Black
        tab5.ForeColor = Color.Black
        tab3.ForeColor = Color.Black
        tab1.ForeColor = Color.Black
        hienThi("SELECT nxb FROM SACH")

    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click

        tran1.ShowSync(txtTimKiem)

        If lan = 1 Then
            txtTimKiem.Visible = True

        Else
            txtTimKiem.Visible = False

        End If
        lan = lan + 1
        If lan > 2 Then
            lan = 1
        End If





    End Sub

    Private Sub tab5_Click(sender As Object, e As EventArgs) Handles tab5.Click
        trans1.Width = tab5.Width
        trans1.Left = tab5.Left
        tab5.ForeColor = Color.DodgerBlue
        tab2.ForeColor = Color.Black
        tab4.ForeColor = Color.Black
        tab3.ForeColor = Color.Black
        tab1.ForeColor = Color.Black
        hienThi("SELECT * FROM PHIEUNHAP")
    End Sub

    Private Sub dgTaiLieu_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgTaiLieu.CellMouseUp
        If e.Button = MouseButtons.Right Then
            dgTaiLieu.Rows(e.RowIndex).Selected = True
            index = e.RowIndex



            dgTaiLieu.CurrentCell = dgTaiLieu.Rows(e.RowIndex).Cells(1)
            ContextMenuStrip1.Show(dgTaiLieu, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)

        End If
    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Click
        ' If Not dgTaiLieu.Rows(index).IsNewRow Then
        'dgTaiLieu.Rows.RemoveAt(index)





        ' End If
    End Sub
End Class
