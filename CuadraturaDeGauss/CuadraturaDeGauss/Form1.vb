Imports info.lundin.math

Public Class Form1
    Dim ak() As Single
    Dim lk() As Single
    Dim integral(500) As Single
    Dim er(500) As Single
    Dim b As Single
    Dim a As Single
    Dim n As Single
    Dim i As Integer
    Dim redon As Integer
    Dim ec As Single

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("pi", 3.14159265)
        parser.Values.Add("e", 2.71828182)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles salida.CellContentClick

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        salida.Rows.Clear()

    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click

        Dim suma As Single
        Dim i As Single

        Dim z As Single


        redon = cs.Text + 2

        er(i) = 1
        a = ta.Text
        b = tb.Text
        n = 4
        ec = 0.5 * 10 ^ (-cs.Text)
        suma = 0
        tabla(n)

        For k = 0 To n - 1
            suma = suma + ((b - a) / 2) * (ak(k) * f(((b + a) / 2) + (((b - a) / 2) * lk(k))))
        Next
        integral(i) = suma
        salida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(er(i), redon))

        n = n + 1

        tabla(n)

        Do While er(i) > ec
            i = i + 1
            suma = 0
            For k = 0 To n - 1
                suma = suma + ((b - a) / 2) * (ak(k) * f(((b + a) / 2) + (((b - a) / 2) * lk(k))))
                ''    salida.Rows.Add(n, Math.Round(suma, redon), k)
            Next
            integral(i) = suma
            salida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(er(i), redon))

            n = n + 1
            tabla(n)
        Loop

    End Sub

    Private Sub tabla(n As Single)
        ReDim ak(0 To n - 1)
        ReDim lk(0 To n - 1)


        If (n = 3) Then
            lk(0) = -0.77459667
            lk(1) = 0
            lk(2) = 0.77459667

            ak(0) = 0.55555556
            ak(1) = 0.88888889
            ak(2) = 0.55555556

        End If

        If (n = 4) Then

            lk(0) = -0.86113631
            lk(1) = -0.33998104
            lk(2) = 0.33998104
            lk(3) = 0.86113631

            ak(0) = 0.34785484
            ak(1) = 0.65214516
            ak(2) = 0.65214516
            ak(3) = 0.34785484
        End If

        If (n = 5) Then

            lk(0) = -0.90617985
            lk(1) = -0.53846931
            lk(2) = 0
            lk(3) = 0.53846931
            lk(4) = 0.90617985


            ak(0) = 0.23692688
            ak(1) = 0.47862868
            ak(2) = 0.56888889
            ak(3) = 0.47862868
            ak(4) = 0.23692688


        End If

        If (n = 6) Then


            lk(0) = -0.93246951
            lk(1) = -0.66120039
            lk(2) = -0.23861919
            lk(3) = 0.23861919
            lk(4) = 0.66120039
            lk(5) = 0.93246951


            ak(0) = 0.1713245
            ak(1) = 0.36076158
            ak(2) = 0.46791394
            ak(3) = 0.46791394
            ak(4) = 0.36076158
            ak(5) = 0.1713245

        End If



    End Sub



End Class
