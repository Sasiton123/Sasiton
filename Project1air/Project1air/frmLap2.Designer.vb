<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLap2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCom = New System.Windows.Forms.TextBox()
        Me.lblTotalSale = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCommissionCom = New System.Windows.Forms.Label()
        Me.lblCommissionPrinter = New System.Windows.Forms.Label()
        Me.txtPrinter = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCommissionTotal = New System.Windows.Forms.Label()
        Me.btCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณยอดขายสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1. Computer Acer Veriton x5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2. Printer HP M529DN"
        '
        'txtCom
        '
        Me.txtCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCom.Location = New System.Drawing.Point(438, 85)
        Me.txtCom.Name = "txtCom"
        Me.txtCom.Size = New System.Drawing.Size(169, 30)
        Me.txtCom.TabIndex = 3
        '
        'lblTotalSale
        '
        Me.lblTotalSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotalSale.Location = New System.Drawing.Point(438, 186)
        Me.lblTotalSale.Name = "lblTotalSale"
        Me.lblTotalSale.Size = New System.Drawing.Size(169, 25)
        Me.lblTotalSale.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ยอดขายรวม"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(338, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ค่าคอมมิชชัน Computer Acer Veriton x5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(63, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(284, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "ค่าคอมมิชชัน Printer HP M529DN"
        '
        'lblCommissionCom
        '
        Me.lblCommissionCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCommissionCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCommissionCom.Location = New System.Drawing.Point(438, 268)
        Me.lblCommissionCom.Name = "lblCommissionCom"
        Me.lblCommissionCom.Size = New System.Drawing.Size(169, 25)
        Me.lblCommissionCom.TabIndex = 4
        '
        'lblCommissionPrinter
        '
        Me.lblCommissionPrinter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCommissionPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCommissionPrinter.Location = New System.Drawing.Point(438, 314)
        Me.lblCommissionPrinter.Name = "lblCommissionPrinter"
        Me.lblCommissionPrinter.Size = New System.Drawing.Size(169, 25)
        Me.lblCommissionPrinter.TabIndex = 4
        '
        'txtPrinter
        '
        Me.txtPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrinter.Location = New System.Drawing.Point(438, 139)
        Me.txtPrinter.Name = "txtPrinter"
        Me.txtPrinter.Size = New System.Drawing.Size(169, 30)
        Me.txtPrinter.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(600, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "__________________________________________________________________________"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(63, 362)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 25)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "ค่าคอมมิชชันรวม"
        '
        'lblCommissionTotal
        '
        Me.lblCommissionTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCommissionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCommissionTotal.Location = New System.Drawing.Point(438, 362)
        Me.lblCommissionTotal.Name = "lblCommissionTotal"
        Me.lblCommissionTotal.Size = New System.Drawing.Size(169, 25)
        Me.lblCommissionTotal.TabIndex = 4
        '
        'btCalculate
        '
        Me.btCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btCalculate.Location = New System.Drawing.Point(154, 439)
        Me.btCalculate.Name = "btCalculate"
        Me.btCalculate.Size = New System.Drawing.Size(112, 37)
        Me.btCalculate.TabIndex = 6
        Me.btCalculate.Text = "คำนวณ"
        Me.btCalculate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClose.Location = New System.Drawing.Point(333, 439)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 37)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "ปิดโปรแกรม"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmLap2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 537)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btCalculate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCommissionTotal)
        Me.Controls.Add(Me.lblCommissionPrinter)
        Me.Controls.Add(Me.lblCommissionCom)
        Me.Controls.Add(Me.lblTotalSale)
        Me.Controls.Add(Me.txtPrinter)
        Me.Controls.Add(Me.txtCom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLap2"
        Me.Text = "frmLap2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCom As TextBox
    Friend WithEvents lblTotalSale As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCommissionCom As Label
    Friend WithEvents lblCommissionPrinter As Label
    Friend WithEvents txtPrinter As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCommissionTotal As Label
    Friend WithEvents btCalculate As Button
    Friend WithEvents btnClose As Button
End Class
