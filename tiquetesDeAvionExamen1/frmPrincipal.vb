Public Class frmPrincipal
    Public pantallaAbierta As Boolean = False
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OPERACIONESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPERACIONESToolStripMenuItem.Click
        If Not pantallaAbierta Then
            Dim frmPantallaOperaciones As New frmOperaciones
            With frmPantallaOperaciones
                .MdiParent = Me
                .Show()
            End With

            pantallaAbierta = True
        End If


    End Sub

    Private Sub CONFIGURACIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONFIGURACIÓNToolStripMenuItem.Click
        If Not pantallaAbierta Then
            Dim frmPantallaConfiguracion As New frmConfiguracion
            With frmPantallaConfiguracion
                .MdiParent = Me
                .Show()
            End With
            pantallaAbierta = True
        End If

    End Sub

    Private Sub ACERCADEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACERCADEToolStripMenuItem.Click
        If Not pantallaAbierta Then
            Dim frmPantallaAcercaDe As New frmAcercade
            With frmPantallaAcercaDe
                .MdiParent = Me
                .Show()
            End With
            pantallaAbierta = True
        End If

    End Sub


End Class
