﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankAccount
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lstTransactions = New System.Windows.Forms.ListBox()
        Me.lblTransactionLog = New System.Windows.Forms.Label()
        Me.lblBeginningBalance = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(72, 364)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(202, 65)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(298, 364)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(202, 65)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(536, 364)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(202, 65)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(5, 4)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(205, 51)
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "Ryan Isaacson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS115 - Fall 2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Assignment#10 - Bank Account"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Blackadder ITC", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(255, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(263, 51)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Bank Of Riche$"
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(159, 204)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(138, 22)
        Me.txtUserInput.TabIndex = 5
        '
        'lstTransactions
        '
        Me.lstTransactions.FormattingEnabled = True
        Me.lstTransactions.ItemHeight = 16
        Me.lstTransactions.Location = New System.Drawing.Point(440, 142)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(231, 180)
        Me.lstTransactions.TabIndex = 7
        '
        'lblTransactionLog
        '
        Me.lblTransactionLog.AutoSize = True
        Me.lblTransactionLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionLog.Location = New System.Drawing.Point(482, 114)
        Me.lblTransactionLog.Name = "lblTransactionLog"
        Me.lblTransactionLog.Size = New System.Drawing.Size(153, 25)
        Me.lblTransactionLog.TabIndex = 8
        Me.lblTransactionLog.Text = "Transaction Log"
        '
        'lblBeginningBalance
        '
        Me.lblBeginningBalance.AutoSize = True
        Me.lblBeginningBalance.Location = New System.Drawing.Point(147, 184)
        Me.lblBeginningBalance.Name = "lblBeginningBalance"
        Me.lblBeginningBalance.Size = New System.Drawing.Size(168, 17)
        Me.lblBeginningBalance.TabIndex = 9
        Me.lblBeginningBalance.Text = "Enter Beginning Balance:"
        '
        'frmBankAccount
        '
        Me.AcceptButton = Me.btnGo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBeginningBalance)
        Me.Controls.Add(Me.lblTransactionLog)
        Me.Controls.Add(Me.lstTransactions)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "frmBankAccount"
        Me.Text = "Bank Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lstTransactions As ListBox
    Friend WithEvents lblTransactionLog As Label
    Friend WithEvents lblBeginningBalance As Label
End Class
