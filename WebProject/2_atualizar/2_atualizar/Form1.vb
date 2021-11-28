Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        atualizar.Start()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub atualizar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atualizar.Tick
        WebBrowser1.Navigate("https://www.sapo.pt/")
    End Sub

End Class
