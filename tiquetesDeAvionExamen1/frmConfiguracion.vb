Public Class frmConfiguracion
    Private Sub frmConfiguracion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmPrincipal.pantallaAbierta = False
    End Sub

    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.cmbColores.Items
            .Add("Rojo")
            .Add("Verde")
            .Add("Negro")

        End With


    End Sub

    Private Sub btnCambiarColor_Click(sender As Object, e As EventArgs) Handles btnCambiarColor.Click
        If cmbColores.SelectedIndex = 0 Then

            frmPrincipal.ForeColor = Color.Red
            frmOperaciones.ForeColor = Color.Red
            frmAcercade.ForeColor = Color.Red

        ElseIf cmbColores.SelectedIndex = 1 Then

            frmPrincipal.ForeColor = Color.Green
            frmOperaciones.ForeColor = Color.Green
            frmAcercade.ForeColor = Color.Green

        ElseIf cmbColores.SelectedIndex = 2 Then

            frmPrincipal.ForeColor = Color.Black
            frmOperaciones.ForeColor = Color.Black
            frmAcercade.ForeColor = Color.Black

        End If
    End Sub
End Class