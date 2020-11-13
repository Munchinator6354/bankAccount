Option Strict On
Option Explicit On

'Check to see that withdrawl or deposit is selected
'Store user's money amount into a variable
'Log the user's input into the list box
'Perform math adding or subtracting user's input into running total



Public Class frmBankAccount
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim strInput As String = ""
        Dim dblInput As Double
        Dim dblTotal As Double

        dblTotal = CDbl(txtUserInput.Text)
        lstTransactions.Items.Add(dblTotal.ToString("c2"))
        strInput = InputBox("Please enter an amount to deposit")

        Do Until strInput = ""
            If IsNumeric(strInput) And strInput.Contains("-") Then
                dblInput = CDbl(strInput)
                dblTotal = dblTotal - dblInput
                lstTransactions.Items.Add(dblInput.ToString("c2"))
            ElseIf IsNumeric(strInput) Then
                dblInput = CDbl(strInput)
                dblTotal = dblTotal + dblInput
                lstTransactions.Items.Add(dblInput.ToString("c2"))
            Else
                MsgBox("Please enter bank account starting balance")
            End If
            strInput = InputBox("If you need to deposit more, please enter another amount")
        Loop
        lstTransactions.Items.Add("______________________________")
        lstTransactions.Items.Add("Account Balance is " & dblTotal.ToString("c2"))
    End Sub
End Class
