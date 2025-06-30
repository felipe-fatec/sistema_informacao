Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btn_cad_usuarios_Click(sender As Object, e As EventArgs) Handles btn_cad_usuarios.Click
        close_form2()
        show_form3()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        show_form1()
        clear_form1()
        close_form2()
    End Sub

    Private Sub btn_historico_Click(sender As Object, e As EventArgs) Handles btn_historico.Click
        show_form9()
    End Sub
End Class