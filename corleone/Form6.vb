Imports System.Diagnostics.Tracing

Public Class Form6
    Private Sub buscar_cep_Click(sender As Object, e As EventArgs) Handles buscar_cep.Click
        Try
            Dim ds As New DataSet
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txt_cep.Text)
            ds.ReadXml(xml)
            If ds.Tables(0).Rows(0)("resultado") = 1 Then
                txt_endereco.Text = ds.Tables(0).Rows(0)("tipo_logradouro") & " " & ds.Tables(0).Rows(0)("logradouro")
                txt_bairro.Text = ds.Tables(0).Rows(0)("bairro")
                txt_cidade.Text = ds.Tables(0).Rows(0)("cidade")
                txt_uf.Text = ds.Tables(0).Rows(0)("uf")
            Else
                MsgBox("CEP não localizado... Tente novamente")
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar o CEP." & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txt_sair_Click(sender As Object, e As EventArgs) Handles txt_sair.Click
        clear_form6()
        show_form5()
        close_form6()
    End Sub

    Private Sub txt_salvar_Click(sender As Object, e As EventArgs) Handles txt_salvar.Click
        Try
            SQL = $"select * from tb_cliente where telefone='{txt_telefone.Text}'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
                SQL = $"insert into tb_cliente (telefone,cep,nome,endereco,numero,bairro, cidade, uf) values ('{txt_telefone.Text}','{txt_cep.Text}','{txt_nome.Text}','{txt_endereco.Text}','{txt_numero.Text}','{txt_bairro.Text}', '{txt_cidade.Text}', '{txt_uf.Text}')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else
                SQL = $"update tb_cliente set cep='{txt_cep.Text}', nome='{txt_nome.Text}', endereco='{txt_endereco.Text}', numero='{txt_numero.Text}', bairro='{txt_bairro.Text}', cidade='{txt_cidade.Text}', uf='{txt_uf.Text}' where telefone='{txt_telefone.Text}'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If

            clear_form6()

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Form7.ShowDialog()
    End Sub
End Class