Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados_clientes()
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            SQL = $"select * from tb_cliente where telefone like '{txt_buscar.Text}%' order by nome asc"
            rs = db.Execute(SQL)
            With dgv_clientes
                cont = 1
                .Rows.Clear() 'Limpar as linhas do datagridview
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(2).Value, rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(1).Value)
                    rs.MoveNext() 'Mover o registro para a próxima linha do grid
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class