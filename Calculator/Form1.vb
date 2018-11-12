Public Class Form1
    Dim Result As Integer
    Dim button As Button
    Dim Calc As Double

    Private Sub ClickMethod(sender As Object, e As EventArgs) Handles Number1.Click, Number2.Click, Number3.Click, Number4.Click, Number5.Click, Number6.Click, Number7.Click, Number8.Click, Number9.Click, OperationPlus.Click, OperationMinus.Click, OperationMultiply.Click, OperationDivide.Click, OperationEqual.Click, OperationClear.Click
        button = CType(sender, Button)
        If button.Name = "Number1" Then
            TextB1.Text = TextB1.Text + Number1.Text
        End If

        If button.Name = "Number2" Then
            TextB1.Text = TextB1.Text + Number2.Text
        End If

        If button.Name = "Number3" Then
            TextB1.Text = TextB1.Text + Number3.Text

        End If

        If button.Name = "Number4" Then
            TextB1.Text = TextB1.Text + Number4.Text
        End If

        If button.Name = "Number5" Then
            TextB1.Text = TextB1.Text + Number5.Text
        End If

        If button.Name = "Number6" Then
            TextB1.Text = TextB1.Text + Number6.Text
        End If

        If button.Name = "Number7" Then
            TextB1.Text = TextB1.Text + Number7.Text
        End If

        If button.Name = "Number8" Then
            TextB1.Text = TextB1.Text + Number8.Text
        End If

        If button.Name = "Number9" Then
            TextB1.Text = TextB1.Text + Number9.Text
        End If

        If button.Name = "OperationPlus" Then
            Calc = TextB1.Text + "+"

            TextB1.Text = ""
        End If

        If button.Name = "OperationMinus" Then
            Calc = TextB1.Text
            TextB1.Text = ""
            TextB1.Text = TextB1.Text + "-"
        End If

        If button.Name = "OperationMultiply" Then
            Calc = TextB1.Text
            TextB1.Text = ""
            TextB1.Text = TextB1.Text + "*"
        End If

        If button.Name = "OperationDivide" Then
            Calc = TextB1.Text
            TextB1.Text = ""
            TextB1.Text = TextB1.Text + "/"
        End If

        If button.Name = "OperationEqual" Then
            Calc += TextB1.Text
            Result = New DataTable().Compute(Calc, Nothing)
            TextB1.Text = Result
        End If

        If button.Name = "OperationClear" Then
            TextB1.Text = ""
        End If

    End Sub
End Class
