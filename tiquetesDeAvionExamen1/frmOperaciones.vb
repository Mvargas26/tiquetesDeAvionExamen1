Public Class frmOperaciones
    Dim globalBoleto As String
    Dim globalImpuesto As String



    '// METODOS MANUALES
    Private Function calcularMontoBoleto() '//metodo que calcula cuanto va a pagar con impuesto

        Dim boleto As Integer
        Dim impuesto As Double
        Dim opc As Integer = cmbPaisDestino.SelectedIndex
        Dim valorBoletoconImpuesto As Double = 0

        Select Case opc
            Case 0 '// el pais destino sera Colombia
                boleto = 570
                impuesto = boleto * 0.25
                valorBoletoconImpuesto = boleto + impuesto
            Case 1 '// el pais destino sera Panama
                boleto = 270
                impuesto = boleto * 0.25
                valorBoletoconImpuesto = boleto + impuesto
            Case 2 '// el pais destino sera Panama
                boleto = 690
                impuesto = boleto * 0.14
                valorBoletoconImpuesto = boleto + impuesto

        End Select

        Dim valorBoletoConDescuento As Double = valorBoletoconImpuesto
        Dim cantidadBoletos As Integer = Me.txtCantidad.Text
        Dim descuento As Double

        If cantidadBoletos = 2 Or cantidadBoletos = 3 Then
            descuento = valorBoletoconImpuesto * 0.05
            valorBoletoConDescuento = (valorBoletoconImpuesto * cantidadBoletos) - descuento

        ElseIf cantidadBoletos > 3 Then
            descuento = valorBoletoconImpuesto * 0.08
            valorBoletoConDescuento = (valorBoletoconImpuesto * cantidadBoletos) - descuento

        End If
        lblIVA.Text = impuesto * cantidadBoletos
        lblSubTotal.Text = boleto * cantidadBoletos
        lblTotal.Text = valorBoletoConDescuento

        '//variables para salvar los datos que saldran al datagrid
        globalBoleto = boleto
        globalImpuesto = impuesto


        Return valorBoletoConDescuento
    End Function '// fin metodo calcularMonto

    Private Sub metodoLimpiar() '// limpiamos la pantalla operaciones
        cmbPaisOrigen.ResetText()
        cmbPaisDestino.ResetText()
        dtpFechaViaje.ResetText()
        txtCedula.ResetText()
        txtNombre.ResetText()
        txtCantidad.ResetText()
    End Sub

    Private Function ValidarDatos() As Boolean '// metodo que valida todos los campos esten llenos
        Try
            Dim datosvalidos As Boolean = True
            Dim strMensaje As New System.Text.StringBuilder("Favor validad la informacion de los campos solicitados")

            With strMensaje
                .Append(vbCrLf)
                If String.IsNullOrEmpty(Me.cmbPaisOrigen.Text.Trim) Then
                    .Append(" El pais de Origen es requerido")
                    .Append(vbCrLf)
                    datosvalidos = False
                End If

                If String.IsNullOrEmpty(Me.cmbPaisDestino.Text.Trim) Then
                    .Append(" El pais de destino es requerido")
                    .Append(vbCrLf)
                    datosvalidos = False
                End If

                If String.IsNullOrEmpty(Me.txtCedula.Text.Trim) Then
                    .Append(" El numero de Cedula es requerido")
                    .Append(vbCrLf)
                    datosvalidos = False
                End If

                If String.IsNullOrEmpty(Me.txtNombre.Text.Trim) Then
                    .Append(" El Nombre Completo es requerido")
                    .Append(vbCrLf)
                    datosvalidos = False
                End If

                If String.IsNullOrEmpty(Me.txtCantidad.Text.Trim) Then
                    .Append(" La cantidad de boletos es requerida")
                    .Append(vbCrLf)
                    datosvalidos = False
                End If
            End With

            If Not datosvalidos Then
                MessageBox.Show(strMensaje.ToString(), "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Return datosvalidos

        Catch ex As Exception
            Throw New Exception("Error al validad datos de entrada ", ex)
        End Try
    End Function '// fin funcion validar datos





    '//METODOS Y ACCIONES DEL SISTEMA
    Private Sub frmOperaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//Carga combos
        With Me.cmbPaisOrigen.Items
            .Add("Costa Rica")
            .Add("Colombia")
            .Add("Panamá")
            .Add("U.S.A")
        End With

        With Me.cmbPaisDestino.Items
            .Add("Colombia")
            .Add("Panamá")
            .Add("U.S.A")
        End With '// fin carga combos

    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        ValidarDatos()
        Try
            If Not Me.ValidarDatos Then Exit Sub

            calcularMontoBoleto()

            Try
                Dim inombre As String = Me.txtNombre.Text.ToUpper
                Dim ipaisDestino As String = Me.cmbPaisDestino.Text.ToUpper
                Dim icantidadTiquetes As Integer = CInt(Me.txtCantidad.Text)
                Dim iboleto As Integer = globalBoleto.ToUpper
                Dim iImpuesto As Integer = globalImpuesto.ToUpper


                dgvDatos.Rows.Add(inombre, ipaisDestino, icantidadTiquetes, iboleto, iImpuesto)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            metodoLimpiar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmOperaciones_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmPrincipal.pantallaAbierta = False
    End Sub


End Class