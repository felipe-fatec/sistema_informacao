Imports ADODB

Public Class Form3
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        clear_form3()
        close_form3()
        show_form2()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_tipo_campo()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            SQL = $"select * from tb_usuario where nome_usuario='{txt_nome.Text}'"
            rs = db.Execute(SQL)
            If rs.EOF = True And blank_form3() Then
                SQL = $"insert into tb_usuario (nome_usuario,login,senha,tipo_usuario) values ('{txt_nome.Text}','{txt_login.Text}','{txt_senha.Text}','{cmb_tipo.SelectedIndex}')"
                rs = db.Execute(SQL)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                clear_form3()

            ElseIf rs.EOF = False And blank_form3() Then
                SQL = $"update tb_usuario set nome_usuario='{txt_nome.Text}', login='{txt_login.Text}', senha='{txt_senha.Text}', tipo_usuario='{cmb_tipo.SelectedIndex}'  where nome_usuario='{txt_nome.Text}'"
                rs = db.Execute(SQL)
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                clear_form3()
            Else
                MsgBox("Preencha todo o formulário")
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        SQL = $"select * from tb_usuario where nome_usuario='{txt_nome.Text}'"
        rs = db.Execute(SQL)

        If rs.EOF = False Then
            If rs.Fields(2).Value <> atual Then
                resp = MsgBox("Deseja realmente excluir o" + vbNewLine &
                                        "usuário: " & txt_nome.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    SQL = $"delete from tb_usuario where nome_usuario='{txt_nome.Text}'"
                    rs = db.Execute(SQL)
                    clear_form3()
                End If
            Else
                MsgBox("Erro ao excluir, usuário logado!")
            End If

        Else
                MsgBox("Usuário não encontrado")
        End If

    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Form4.ShowDialog()
    End Sub

    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged
        SQL = $"select * from tb_usuario where nome_usuario like '{txt_nome.Text}'"
        rs = db.Execute(SQL)

        If rs.EOF = False Then
            txt_login.Text = rs.Fields(2).Value
            txt_senha.Text = rs.Fields(3).Value
        End If

    End Sub
End Class