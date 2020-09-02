Imports System.ComponentModel

Public Class frmDiceCricket
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ClearArr()
        'unused delete if you want :)
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

        ' Try block to catch weather the user has added more than 2 players
        ' this prevents any errors due to an array becoming out of index

        Try

            NameArray(PlaceInNames) = InputName.Text
            txtScores.AppendText(NameArray(PlaceInNames) + " - Has entered!" & vbCrLf) '& vbCrLf &

        Catch ex As Exception

            txtScores.AppendText("Only 2 Players are aloud! Resetting array! :)" & vbCrLf) 'alerting user

            Dim NameArray(1) As String 'resetting array
            PlaceInNames = 10

        End Try


        PlaceInNames += 1

        If PlaceInNames = 11 Then 'checking weather the arrays index has been placed out of bounds
            PlaceInNames = 0
        End If

    End Sub

    '
    ' Class that detects weather someone has rolled a dice
    '

    Private Sub btnNextShot_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNextShot.MouseClick

        Dim DiceRoll As Integer = Math.Ceiling(Rnd() * 6) + Math.Ceiling(Rnd() * 6) '2 dice to increase amount of randomness
        Score(RollPlaces) = DiceRoll

        If RollPlaces Mod 2 = 0 Then 'Mod is % because F modulo symbol said microsoft

            If DiceRoll = 5 Then 'declearing who the loser is
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
