Public Class Form1
    Dim Question As Integer
    Dim Score As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Score: 0"
        Label1.Text = "League Of Legends Trivia Game"
        RadioButton1.Text = "Answer 1"
        RadioButton2.Text = "Answer 2"
        RadioButton3.Text = "Answer 3"
        RadioButton4.Text = "Answer 4"
        Label2.Text = "Select a Question to Begin"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Question = 1
        Label1.Text = "What is the name of Yasuo's Brother?"
        RadioButton1.Text = "Shen"
        RadioButton2.Text = "Yone"
        RadioButton3.Text = "Riven"
        RadioButton4.Text = "Darius"
        Label2.Text = "Question 1"
        Button2.Enabled = False
        Button1.Enabled = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Question = 2
        Label1.Text = "Where in Runeterra is Riven from?"
        RadioButton1.Text = "Zaun"
        RadioButton2.Text = "Piltover"
        RadioButton3.Text = "Demacia"
        RadioButton4.Text = "Noxus"
        Label2.Text = "Question 2"
        Button3.Enabled = False
        Button1.Enabled = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Question = 3
        Label1.Text = "What is the Name of Jax's Ultimate?"
        RadioButton1.Text = "Counter Strike"
        RadioButton2.Text = "Leap Strike"
        RadioButton3.Text = "Grandmaster's Might"
        RadioButton4.Text = "Empower"
        Label2.Text = "Question 3"
        Button4.Enabled = False
        Button1.Enabled = True
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Question = 4
        Label1.Text = "What is the Name of Kalista's Passive?"
        RadioButton1.Text = "Rend"
        RadioButton2.Text = "Martial Poise"
        RadioButton3.Text = "Spear of Vengeance"
        RadioButton4.Text = "Fate's Call"
        Label2.Text = "Question 4"
        Button5.Enabled = False
        Button1.Enabled = True
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Question = 5
        Label1.Text = "What is Caitlyn's Title?"
        RadioButton1.Text = "The Sheriff of Piltover"
        RadioButton2.Text = "The Hexplosives Expert"
        RadioButton3.Text = "The Bounty Hunter"
        RadioButton4.Text = "The Sherff of Zaun"
        Label2.Text = "Question 5"
        Button6.Enabled = False
        Button1.Enabled = True
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Question = 6
        Label1.Text = "What is the Name of Seguani's Mount?"
        RadioButton1.Text = "Zed"
        RadioButton2.Text = "Trundle"
        RadioButton3.Text = "Bristle"
        RadioButton4.Text = "Lissandra"
        Label2.Text = "Question 6"
        Button7.Enabled = False
        Button1.Enabled = True
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Question = 7
        Label1.Text = "Who helps Shen Maintain Balance throughout Runeterra?"
        RadioButton1.Text = "Akali and Kennen"
        RadioButton2.Text = "Kennen and Zed"
        RadioButton3.Text = "Akali and Lee Sin"
        RadioButton4.Text = "Akali and Zed"
        Label2.Text = "Question 7"
        Button8.Enabled = False
        Button1.Enabled = True
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Question = 8
        Label1.Text = "What Jungle Camp Gives you Mana/Energy Regen and Cooldown Reduction?"
        RadioButton1.Text = "Red Buff"
        RadioButton2.Text = "Wolf Camp"
        RadioButton3.Text = "Raptor Camp"
        RadioButton4.Text = "Blue Buff"
        Label2.Text = "Question 8"
        Button9.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Question = 9
        Label1.Text = "What Lane Normally has Assassins and Mages?"
        RadioButton1.Text = "Top Lane"
        RadioButton2.Text = "Jungle"
        RadioButton3.Text = "Mid Lane"
        RadioButton4.Text = "Bottom Lane"
        Label2.Text = "Question 9"
        Button10.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Question = 10
        Label1.Text = "What Company Created League of Legends?"
        RadioButton1.Text = "Blizzard"
        RadioButton2.Text = "Riot Games"
        RadioButton3.Text = "Treyarch"
        RadioButton4.Text = "Mojang"
        Label2.Text = "Question 10"
        Button11.Enabled = False
        Button1.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton2.Checked And Question = 1 Then
            MsgBox("Correct")
            Score = Score + 1
            Button1.Enabled = False
        ElseIf RadioButton4.Checked And Question = 2 Then
            MsgBox("Correct")
            Score = Score + 1
            Button1.Enabled = False
        ElseIf RadioButton3.Checked And Question = 3 Then
            MsgBox("Correct")
            Score = Score + 1
            Button1.Enabled = False
        ElseIf RadioButton2.Checked And Question = 4 Then
            MsgBox("Correct")
            Score = Score + 1
            Button1.Enabled = False
        ElseIf RadioButton1.Checked And Question = 5 Then
            MsgBox("Correct")
            Score = Score + 1
            Button1.Enabled = False
        ElseIf RadioButton3.Checked And Question = 6 Then
            MsgBox("Correct")
            Score = Score + 1
            Button1.Enabled = False
        ElseIf RadioButton1.Checked And Question = 7 Then
            MsgBox("Correct")
            Score = Score + 1
            Button1.Enabled = False
        ElseIf RadioButton4.Checked And Question = 8 Then
            MsgBox("Correct")
            Score = Score + 1
            Button1.Enabled = False
        ElseIf RadioButton3.Checked And Question = 9 Then
            MsgBox("Correct")
            Score = Score + 1
            Button1.Enabled = False
        ElseIf RadioButton2.Checked And Question = 10 Then
            MsgBox("Correct")
            Score = Score + 1
            Button1.Enabled = False
        Else MsgBox("Incorrect")
            Button1.Enabled = False
        End If
        Label3.Text = "Score:" & Score
        If Question = 10 And Button1.Enabled = False Then
            MsgBox("Congrats! You Finished the Trivia Game!")
        End If
    End Sub

End Class