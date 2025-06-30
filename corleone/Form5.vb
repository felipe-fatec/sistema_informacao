Public Class Form5
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        show_form1()
        clear_form1()
        close_form5()
    End Sub

    Private Sub btn_cad_usuarios_Click(sender As Object, e As EventArgs) Handles btn_cad_usuarios.Click
        show_form6()
        close_form5()
    End Sub

    Private Sub btn_cadastrar_pedidos_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_pedidos.Click
        show_form8()
        close_form5()
    End Sub
End Class