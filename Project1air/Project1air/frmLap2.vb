Public Class frmLap2
    Private Sub btCalculate_Click(sender As Object, e As EventArgs) Handles btCalculate.Click

        Dim Computer As Double
        Dim Printer As Double
        Dim SumSale As Double
        Dim CommissionCom As Double
        Dim CommissionPrinter As Double
        Dim SumCommission As Double

        Computer = txtCom.Text
        Printer = txtPrinter.Text
        SumSale = Computer + Printer

        CommissionCom = Computer * 0.05
        CommissionPrinter = Printer * 0.1
        SumCommission = CommissionCom + CommissionPrinter

        lblTotalSale.Text = SumSale
        lblCommissionCom.Text = CommissionCom
        lblCommissionPrinter.Text = CommissionPrinter
        lblCommissionTotal.Text = SumCommission









    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class