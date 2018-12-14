﻿Imports info.lundin.math


Public Class Form1

    Dim a, b, n, ec As Single
    Dim x(50), er(50) As Single
    Dim i, redon As Integer
    Dim cadena As String
    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function


    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        n = tcs.Text
        a = ta.Text
        b = tb.Text
        redon = n + 2
        ec = 0.5 * 10 ^ (-n)
        x(i) = (a * f(b) - b * f(a)) / (f(b) - f(a))
        er(i) = 1

        salida.Rows.Add(0, a, Math.Round(x(i), redon), b, Math.Round(f(a), redon), f(x(i)), Math.Round(f(b), redon), "---")
        Do While er(i) > ec
            If f(a) * f(x(i)) < 0 Then
                b = x(i)
            Else
                a = x(i)
            End If

            x(i + 1) = (a * f(b) - b * f(a)) / (f(b) - f(a))
            er(i + 1) = Math.Abs((x(i + 1) - x(i)) / x(i + 1))
            salida.Rows.Add(i + 1, Math.Round(a, redon), Math.Round(x(i + 1), redon), Math.Round(b, redon),
            Math.Round(f(a), redon), Math.Round(f(x(i + 1)), redon), Math.Round(f(b), redon), Math.Round(er(i + 1), redon))
            i = i + 1

        Loop
        salida.Rows.Add("", "La raíz es x= ", Math.Round(x(i), redon), "", "", "", "", "")

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        End
    End Sub

    Private Sub salida_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles salida.CellContentClick

    End Sub
End Class
