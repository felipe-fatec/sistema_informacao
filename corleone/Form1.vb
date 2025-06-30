Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        txt_senha.UseSystemPasswordChar = True
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            SQL = $"select * from tb_usuario where login='{txt_usuario.Text}'AND senha='{txt_senha.Text}'"
            rs = db.Execute(SQL)

            If rs.EOF = False Then
                If rs.Fields(4).Value = 0 Then
                    MsgBox("admin logado com sucesso!")
                    close_form1()
                    show_form2()

                ElseIf rs.Fields(4).Value = 1 Then
                    MsgBox("usuário logado com sucesso!")
                    close_form1()
                    show_form5()
                End If
            Else
                MsgBox("Usuário ou senha inválidos")
            End If
            atual = txt_usuario.Text
        Catch ex As Exception
            MsgBox("Erro")

        End Try
    End Sub

    Private Sub chk_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visualizar.CheckedChanged
        If chk_visualizar.CheckState = CheckState.Checked Then
            txt_senha.UseSystemPasswordChar = False
        Else
            txt_senha.UseSystemPasswordChar = True
        End If

    End Sub
End Class

