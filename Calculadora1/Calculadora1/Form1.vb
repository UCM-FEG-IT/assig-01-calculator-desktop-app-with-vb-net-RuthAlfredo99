Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Bntum.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Btnnove.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Btnseis.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Btnigual.Click

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Btnmenos.Click

    End Sub

    Private Sub ButtonClickMetod(sender As Object, e As EventArgs) Handles Bntum.Click, Btndois.Click, Btntres.Click, Btnquatro.Click, Btncinco.Click, Btnseis.Click, btnsete.Click, Btnoito.Click, Btnmais.Click, Btnmenos.Click, Btndivisao.Click, Btnmaismenos.Click, Btnresultado.Click,
        Dim button As Button = CType(sender, Button)
        If Button.Name = "Bntum" Then

            TextBox.Text = TextBox.Text + "1"
        End If

        If Button.Name = "Btndois" Then

            TextBox.Text = TextBox.Text + "2"
        End If

        If Button.Name = "Btntres" Then

            TextBox.Text = TextBox.Text + "3"
        End If

        If Button.Name = "Btnquatro" Then

            TextBox.Text = TextBox.Text + "4"
        End If

        If Button.Name = "Btncinco" Then

            TextBox.Text = TextBox.Text + "5"
        End If

        If Button.Name = "Btnseis" Then

            TextBox.Text = TextBox.Text + "6"
        End If

        If Button.Name = "Btnsete" Then

            TextBox.Text = TextBox.Text + "7"
        End If

        If Button.Name = "Btnoito" Then

            TextBox.Text = TextBox.Text + "8"
        End If

        If Button.Name = "Btnnove" Then

            TextBox.Text = TextBox.Text + "9"
        End If

        If button.Name = "Btnmaismenos+-" Then

            TextBox.Text = TextBox + "0"
        End If

        If Button.Name = "Btnzero" Then

            TextBox.Text = TextBox.Text + "."
        End If

        If button.Name = "OpEquals" Then
            Dim equation As String = TextBox.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox.Text = result
        End If

        If button.Name = "OpMultiply" Then

            TextBox.Text = TextBox.Text + "*"
        End If

        If button.Name = "OpDivide" Then

            TextBox.Text = TextBox.Text + "/"
        End If

        If button.Name = "OpPlus" Then

            TextBox.Text = TextBox.Text + "+"
        End If

        If button.Name = "OpMinus" Then

            TextBox.Text = TextBox.Text + "-"
        End If

        If button.Name = "OpClear" Then

            TextBox.Text = "TextBox.Text"
        End If
    End Sub
End Class
