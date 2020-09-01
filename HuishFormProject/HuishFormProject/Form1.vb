Imports System.ComponentModel

Public Class frmDiceCricket
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ClearArr()

    End Sub

    '
    'Global variables
    '

    Dim PlaceInNames As Integer = 0
    Dim RollPlaces As Integer = 0
    Dim TotalDiceValueA As Integer = 0
    Dim TotalDiceValueB As Integer = 0

    Dim NameArray(1) As String
    Dim Score(1024) As Integer

    '
    'Class to add players
    '

    Private Sub btnPlayerName_MouseClick(sender As Object, e As MouseEventArgs) Handles btnPlayerName.MouseClick

        NameArray(PlaceInNames) = InputName.Text
        txtScores.AppendText(NameArray(PlaceInNames) + " - Has entered!" & vbCrLf) '& vbCrLf &

        PlaceInNames += 1

    End Sub

    '
    ' Class that detects weather someone has rolled a dice
    '

    Private Sub btnNextShot_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNextShot.MouseClick

        Dim DiceRoll As Integer = Math.Ceiling(Rnd() * 12)
        Score(RollPlaces) = DiceRoll

        If RollPlaces Mod 2 = 0 Then

            If DiceRoll = 5 Then
                txtScores.AppendText(NameArray(0) & " is a LOSER" & vbCrLf)
                totalBox.Text = NameArray(1) & " won with " & TotalDiceValueB.ToString() & " points"

            Else
                txtScores.AppendText(NameArray(0) & " has rolled a " & DiceRoll.ToString() & vbCrLf)
                TotalDiceValueA += DiceRoll
                totalBox.Text = NameArray(0) & " your score is: " & TotalDiceValueA.ToString()


            End If

        Else

            If DiceRoll = 5 Then
                txtScores.AppendText(NameArray(1) & " is a LOSER" & vbCrLf)
                totalBox.Text = NameArray(0) & " won with " & TotalDiceValueA.ToString() & " points"


            Else
                txtScores.AppendText(NameArray(1) & " has rolled a " & DiceRoll.ToString() & vbCrLf)
                TotalDiceValueB += DiceRoll
                totalBox.Text = NameArray(1) & " your score is: " & TotalDiceValueB.ToString()

            End If

        End If

        RollPlaces += 1

    End Sub
End Class
