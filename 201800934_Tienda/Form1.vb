Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If C_arroz.Text <> "" And C_frijol.Text <> "" And C_azucar.Text <> "" Then
            Const p_arroz = 2
            Const p_frijol = 1.75
            Const p_azucar = 2.5

            Dim t_arroz As Double
            Dim t_frijol As Double
            Dim t_azucar As Double
            Dim t_compra As Double
            Dim t_iva As Double
            Dim t_desc As Double

            t_arroz = p_arroz * C_arroz.Text
            t_frijol = p_frijol * C_frijol.Text
            t_azucar = p_azucar * C_azucar.Text
            t_compra = t_arroz + t_frijol + t_azucar
            t_iva = t_compra * 0.12
            t_desc = (t_compra + t_iva) * 0.025

            'RESULTADOS A MOSTRAR ---------------------------------------------------------
            psIVA.Text = System.Math.Round(t_compra, 2)
            IVA.Text = System.Math.Round((t_iva), 2)
            pcIVA.Text = System.Math.Round(t_iva + t_compra, 2)
            desc.Text = System.Math.Round(t_desc, 2)
            pfinal.Text = System.Math.Round(t_compra + t_iva - t_desc, 2)

            GroupBox2.Visible = True

        Else
            MsgBox("Algun campo esta vacio", MsgBoxStyle.OkOnly)
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        C_arroz.Clear()
        C_frijol.Clear()
        C_azucar.Clear()
        C_arroz.Text = 0
        C_frijol.Text = 0
        C_azucar.Text = 0
        C_arroz.Focus()
        GroupBox2.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub

    Private Sub C_arroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_arroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub C_frijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_frijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub C_azucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_azucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
