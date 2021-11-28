Public Class Form1
    Dim codigo_anterior As String
    Dim cont As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        atualizar.Start()
    End Sub

    Private Sub atualizar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atualizar.Tick
        Try
            Dim codigo As String
            WebBrowser1.Navigate("https://www.sapo.pt/")
            codigo = New System.Net.WebClient().DownloadString("https://www.sapo.pt/")
            RichTextBox1.Text = codigo

            If cont = 1 Then

                If codigo <> codigo_anterior Then
                    atualizar.Stop()
                    bip.Start()
                    cont = 0
                Else
                    codigo = codigo_anterior
                End If
            Else
                codigo_anterior = codigo
                cont = 1

            End If

        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical, "Erro")
        End Try



    End Sub

    Private Sub bt_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_reset.Click
        atualizar.Stop()
        atualizar.Start()
    End Sub

    Private Sub bip_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bip.Tick
        My.Computer.Audio.Play("C:\Users\andre\Desktop\WebProject\trabalho_1_M8_PSI\3_fonte_pagina\Censor_Beep.wav")
    End Sub

    Private Sub bt_sound_stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_sound_stop.Click
        bip.Stop()

    End Sub

End Class