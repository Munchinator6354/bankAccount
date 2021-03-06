﻿Option Strict On
Option Explicit On

'Program:       bankAccount
'Programmer:    Ryan Isaacson / GitHub: Munchinator6354
'Date           November 13, 2020
'Description    Program simulates the very most basic functions of a bank account, starting with 
'               an intitial balance and allows for withdrawal And deposit to the account value.

Public Class frmBankAccount

    'Subroutine:    frmBankAccount_Load
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 13, 2020
    'Description    Initiates the picture box with the picture of uncle scrooge in his money bin from DuckTales.
    Private Sub frmBankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picUncleScrooge.Image = Image.FromFile("..\Images\uncleScrooge.png")
    End Sub

    'Subroutine:    btnGo_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 13, 2020
    'Description    Initiates the bank account with a starting amount and then shows the user an Input box for withdrawals and deposits.
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim strInput As String = ""
        Dim dblInput As Double
        Dim dblTotal As Double

        'Validates user input for beginning balance
        If IsNumeric(txtUserInput.Text) Then
            dblTotal = CDbl(txtUserInput.Text)
            lstTransactions.Items.Add(dblTotal.ToString("c2"))
            strInput = InputBox("Please enter an amount to deposit or withdraw" & vbCrLf & "To Withdraw: Input a negative number" & vbCrLf & "To Exit: Input nothing and hit enter")

            Do Until strInput = ""
                'Validates user input within Input Box
                If IsNumeric(strInput) And strInput.Contains("-") Then
                    'This route is chosen if a withdrawl is selected
                    dblInput = CDbl(strInput)
                    dblTotal = (dblTotal + dblInput)
                    lstTransactions.Items.Add(dblInput.ToString("c2"))

                ElseIf IsNumeric(strInput) Then
                    'This route is chosen if a deposit is selected
                    dblInput = CDbl(strInput)
                    dblTotal = dblTotal + dblInput
                    lstTransactions.Items.Add(dblInput.ToString("c2"))

                Else
                    MsgBox("Please enter bank account starting balance")
                End If
                strInput = InputBox("Please enter an amount to deposit or withdraw" & vbCrLf & "To Withdraw: Input a negative number" & vbCrLf & "To Exit: Input nothing and hit enter")
            Loop
        Else MsgBox("You must input a number for the beginning balance")
        End If
        lstTransactions.Items.Add("______________________________")
        lstTransactions.Items.Add("Account Balance is " & dblTotal.ToString("c2"))
    End Sub

    'Subroutine:    btnClear_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 13, 2020
    'Description    Clears the textbox and listbox and sets the app back to the beginning.
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserInput.Text = ""
        txtUserInput.Focus()
        txtUserInput.SelectAll()
        lstTransactions.Items.Clear()
    End Sub

    'Subroutine:    btnExit_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 13, 2020
    'Description    Exits the program.
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub


End Class
