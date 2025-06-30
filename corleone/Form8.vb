Public Class Form8
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        show_form5()
        close_form8()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            SQL = $"select * from tb_pedido where fone='{txt_telefone.Text}'"
            rs = db.Execute(SQL)
            If blank_form8() Then
                SQL = $"insert into tb_pedido (data,fone, total,forma_pagamento,sabor, bebida) values ('{cmb_data_pedido.Text}','{txt_telefone.Text}','{txt_valor_total.Text}','{cmb_forma_pagamento.Text}', '{txt_sabor.Text}', '{txt_bebida.Text}')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                clear_form8()

            Else
                MsgBox("Preencha todo o formulário")
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_forma_pagamento()
    End Sub
End Class