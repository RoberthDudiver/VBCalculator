' Visual Basic Calculator Less than 10 code lines written 2/3/2019
'Roberth Dudiver rdudiver@gmail.com 
Public Class Form1

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click, Button5.Click, Button4.Click, Button3.Click
        If (TextBox1.Text = "0") Then TextBox1.Text = ""
        TextBox1.Text += CType(sender, Button).Text
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = i To 9 Step 1
            Dim butt As New Button With {.Text = i.ToString()}
            AddHandler butt.Click, AddressOf Me.Button_Click
            NumberPanel.Controls.Add(butt)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = New DataTable().Compute(TextBox1.Text, Nothing)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "0"
    End Sub
End Class
