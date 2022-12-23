Imports System.Drawing.Text
Imports FontAwesome.Sharp

Public Class Parawork
    'Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint
    'Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Constructor
    Public Sub New()
        InitializeComponent()

        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 52)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub

    'Methods
    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form Icon 
            'IconCurrentForm.IconChar = currentBtn.IconChar
            'IconCurrentForm.IconColor = customColor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Transparent
            currentBtn.IconColor = Color.Transparent
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            'end
            childForm.TopLevel = False

        End If
        currentChildForm = currentChildForm
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActiveButton(sender, RGBColors.color1)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActiveButton(sender, RGBColors.color2)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        ActiveButton(sender, RGBColors.color3)
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        ActiveButton(sender, RGBColors.color4)
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        ActiveButton(sender, RGBColors.color5)
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        ActiveButton(sender, RGBColors.color6)
    End Sub

    'Events
    'End Sub
End Class
