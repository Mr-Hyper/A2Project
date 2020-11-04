Imports System.Drawing.Text
Public Class BootUpScreen
    Dim LoadBarVal As Integer

    Private Sub BootUpScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim pfc As PrivateFontCollection = New PrivateFontCollection

        'pfc.AddFontFile("Fonts\MISTRAL.TTF")

        'LblBengalBlue.Font = New Font(pfc.Families(0), 72)
        'LblPOS.Font = New Font(pfc.Families(0), 36)

        LblProgressValue.Text = "0%"
        BootUpTimer.Enabled = True

    End Sub

    Private Sub BootUpTimer_Tick(sender As Object, e As EventArgs) Handles BootUpTimer.Tick

        LoadBar.Value += 1
        LoadBarVal = LoadBar.Value
        LblProgressValue.Text = Math.Round(LoadBarVal / 5) & "%"

        If LoadBar.Value <= 125 Then

            LblStatus.Text = "Initialising System"

        ElseIf LoadBar.Value <= 250 Then

            LblStatus.Text = "Integrating Database"

        ElseIf LoadBar.Value <= 375 Then

            LblStatus.Text = "Loading All Components"

        ElseIf LoadBar.Value = 500 Then

            BootUpTimer.Enabled = False

            Me.Hide()
            MainMenu.ShowDialog()
            Me.Close()
            MainMenu.Show()

        End If

    End Sub

    Private Sub LblBengalBlue_Click(sender As Object, e As EventArgs) Handles LblBengalBlue.Click

    End Sub
End Class