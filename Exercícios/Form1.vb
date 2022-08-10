Public Class Form1
    Private Sub Comparar_Click(sender As Object, e As EventArgs) Handles Comparar.Click
        Try


            If Double.Parse(Num1.Text) > Double.Parse(Num2.Text) Then
                ResultMaior.Text = Num1.Text
            End If

            If Double.Parse(Num2.Text) > Double.Parse(Num1.Text) Then
                ResultMaior.Text = Num2.Text
            End If
        Catch

            MessageBox.Show("Entrada inváida")

        End Try


    End Sub
End Class
