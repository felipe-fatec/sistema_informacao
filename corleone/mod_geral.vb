Imports System.Diagnostics.Eventing.Reader
Imports ADODB

Module mod_geral
    Public SQL, resp, atual As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=corleone;UID=root;PWD=usbw;port=3307;option=3;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub show_form1()
        Form1.Show()
    End Sub

    Sub close_form1()
        Form1.Hide()
    End Sub

    Sub clear_form1()
        Try
            With Form1
                .txt_usuario.Clear()
                .txt_senha.Clear()
            End With
        Catch ex As Exception
            Exit Sub

        End Try
    End Sub

    Sub show_form2()
        Form2.Show()
    End Sub

    Sub close_form2()
        Form2.Hide()

    End Sub

    Sub show_form3()
        Form3.Show()
    End Sub

    Sub close_form3()
        Form3.Hide()
    End Sub

    Sub show_form5()
        Form5.Show()
    End Sub

    Sub close_form5()
        Form5.Hide()
    End Sub
    Sub show_form6()
        Form6.Show()
    End Sub
    Sub close_form6()
        Form6.Hide()
    End Sub

    Sub show_form8()
        Form8.Show()
    End Sub

    Sub close_form8()
        Form8.Hide()
    End Sub

    Sub show_form9()
        Form9.ShowDialog()
    End Sub


    Sub clear_form3()
        Try
            With Form3
                .txt_nome.Clear()
                .txt_login.Clear()
                .txt_senha.Clear()
                .cmb_tipo.SelectedIndex = 1
            End With
        Catch ex As Exception
            Exit Sub

        End Try
    End Sub

    Sub clear_form6()
        Try
            With Form6
                .txt_cep.Clear()
                .txt_nome.Clear()
                .txt_telefone.Clear()
                .txt_endereco.Clear()
                .txt_numero.Clear()
                .txt_bairro.Clear()
                .txt_cidade.Clear()
                .txt_uf.Clear()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub clear_form8()
        Try
            With Form8
                .txt_telefone.Clear()
                .txt_valor_total.Clear()
                .txt_sabor.Clear()
                .txt_bebida.Clear()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_tipo_campo()
        Try
            With Form3.cmb_tipo.Items
                .Add("Administrador")
                .Add("Usuário")
            End With
            Form3.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            Exit Sub

        End Try
    End Sub

    Sub carregar_forma_pagamento()
        Try
            With Form8.cmb_forma_pagamento.Items
                .Add("Dinheiro")
                .Add("Débito")
                .Add("Crédito")
                .Add("Pix")
            End With
            Form8.cmb_forma_pagamento.SelectedIndex = 0
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Function blank_form3()
        With Form3
            If .txt_nome.Text = "" Or
               .txt_login.Text = "" Or
               .txt_senha.Text = "" Then
                Return False
            Else
                Return True
            End If

        End With
    End Function

    Function blank_form8()
        With Form8
            If .txt_telefone.Text = "" Or
               .txt_valor_total.Text = "" Or
               .txt_sabor.Text = "" Or
               .txt_bebida.Text = "" Then
                Return False
            Else
                Return True
            End If

        End With
    End Function

    Sub carregar_dados()
        Try
            SQL = "select * from tb_usuario order by nome_usuario asc"
            rs = db.Execute(SQL)
            With Form4.dgv_usuarios
                cont = 1
                .Rows.Clear() 'Limpar as linhas do datagridview
                Do While rs.EOF = False
                    If rs.Fields(4).Value = 0 Then
                        .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, "Administrador")
                    Else
                        .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, "Usuário")
                    End If
                    rs.MoveNext() 'Mover o registro para a próxima linha do grid
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("erro ao carregar")
        End Try
    End Sub

    Sub carregar_dados_clientes()
        Try
            SQL = "select * from tb_cliente order by nome asc"
            rs = db.Execute(SQL)
            With Form7.dgv_clientes
                cont = 1
                .Rows.Clear() 'Limpar as linhas do datagridview
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(2).Value, rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(1).Value)
                    rs.MoveNext() 'Mover o registro para a próxima linha do grid
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("erro ao carregar")
        End Try
    End Sub

    Sub carregar_dados_pedidos()
        Try
            SQL = "select tb_cliente.nome, tb_cliente.telefone, tb_cliente.cep, tb_cliente.numero, tb_pedido.id_pedido, tb_pedido.data, tb_pedido.sabor, tb_pedido.bebida, tb_pedido.forma_pagamento, tb_pedido.total from tb_cliente inner join tb_pedido on tb_cliente.telefone = tb_pedido.fone"
            rs = db.Execute(SQL)
            With Form9.dgv_pedidos

                .Rows.Clear() 'Limpar as linhas do datagridview
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(4).Value, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, rs.Fields(9).Value)
                    rs.MoveNext() 'Mover o registro para a próxima linha do grid

                Loop
            End With
        Catch ex As Exception
        MsgBox("erro ao carregar")
        End Try
    End Sub


End Module
