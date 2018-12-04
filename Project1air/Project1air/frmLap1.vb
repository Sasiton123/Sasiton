Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        lblYearly.Text = txtSalary.Text * 12
        lblTax.Text = lblYearly.Text * 0.05
        lblTotal.Text = lblYearly.Text - lblTax.Text

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
