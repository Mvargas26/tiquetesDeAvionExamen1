Public Class frmAcercade
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmAcercade_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmPrincipal.pantallaAbierta = False
    End Sub
End Class