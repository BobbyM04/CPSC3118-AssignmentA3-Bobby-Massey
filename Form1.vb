Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set form properties
        Me.Text = "Burger Specials"
        Me.BackColor = Color.White
        Me.Size = New Size(600, 400)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.CenterToScreen()

        ' Label for Farm Burger Specials
        Dim lblFarmBurger As New Label()
        lblFarmBurger.Text = "Farm Burger Specials"
        lblFarmBurger.Font = New Font("Tahoma", 16, FontStyle.Bold)
        lblFarmBurger.TextAlign = ContentAlignment.MiddleCenter
        lblFarmBurger.Size = New Size(600, 35)
        lblFarmBurger.Location = New Point(0, 10)
        Me.Controls.Add(lblFarmBurger)

        'Picture of Prime Beef Burger
        Dim picPrimeBeef As New PictureBox()
        picPrimeBeef.BackColor = Color.Gray
        picPrimeBeef.Size = New Size(200, 200)
        picPrimeBeef.SizeMode = PictureBoxSizeMode.StretchImage
        picPrimeBeef.Location = New Point(50, 50)
        Me.Controls.Add(picPrimeBeef)
        'Picture of Prime Beef Burger
        Dim picVeggie As New PictureBox()
        picVeggie.BackColor = Color.Gray
        picVeggie.Size = New Size(200, 200)
        picVeggie.SizeMode = PictureBoxSizeMode.StretchImage
        picVeggie.Location = New Point(350, 50)
        Me.Controls.Add(picVeggie)

        'Prime Beef Button
        Dim btnPrimeBeef As New Button()
        btnPrimeBeef.Text = "Prime Beef"
        btnPrimeBeef.BackColor = Color.Gray
        btnPrimeBeef.Size = New Size(100, 30)
        btnPrimeBeef.Location = New Point(100, 270)
        AddHandler btnPrimeBeef.Click, AddressOf btnPrimeBeef_Click
        Me.Controls.Add(btnPrimeBeef)
        'Select Meal Button
        Dim btnSelectMeal As New Button()
        btnSelectMeal.Text = "Select Meal"
        btnSelectMeal.BackColor = Color.Gray
        btnSelectMeal.Size = New Size(100, 30)
        btnSelectMeal.Location = New Point(250, 270)
        AddHandler btnSelectMeal.Click, AddressOf btnSelectMeal_Click
        Me.Controls.Add(btnSelectMeal)
        'Veggie Button
        Dim btnVeggie As New Button()
        btnVeggie.Text = "Veggie"
        btnVeggie.BackColor = Color.Gray
        btnVeggie.Size = New Size(100, 30)
        btnVeggie.Location = New Point(400, 270)
        AddHandler btnVeggie.Click, AddressOf btnVeggie_Click
        Me.Controls.Add(btnVeggie)
        'Exit Button
        Dim btnExit As New Button()
        btnExit.Text = "Exit Window"
        btnExit.BackColor = Color.Gray
        btnExit.Size = New Size(100, 30)
        btnExit.Location = New Point(250, 390)
        AddHandler btnExit.Click, AddressOf btnExit_Click
        Me.Controls.Add(btnExit)

        'Text for GUI instructions
        Dim lblInstructions As New Label()
        lblInstructions.Text = "Choose a burger then click the Select Meal Button"
        lblInstructions.Font = New Font("Tahoma", 9)
        lblInstructions.TextAlign = ContentAlignment.MiddleCenter
        lblInstructions.Size = New Size(600, 15)
        lblInstructions.Location = New Point(0, 320)
        Me.Controls.Add(lblInstructions)

        'Text for Enjoy Message
        Dim lblEnjoy As New Label()
        lblEnjoy.Text = "Enjoy your burger special!"
        lblEnjoy.Font = New Font("Tahoma", 9)
        lblEnjoy.TextAlign = ContentAlignment.MiddleCenter
        lblEnjoy.Size = New Size(600, 18)
        lblEnjoy.Location = New Point(0, 345)
        Me.Controls.Add(lblEnjoy)
    End Sub
    Private Sub btnPrimeBeef_Click(sender As Object, e As EventArgs)
        Dim btnSelectMeal As Button = DirectCast(Me.Controls("btnSelectMeal"), Button)
    End Sub
    Private Sub btnVeggie_Click(sender As Object, e As EventArgs)
        Dim btnSelectMeal As Button = DirectCast(Me.Controls("btnSelectMeal"), Button)
    End Sub
    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs)
        Dim lblInstructions As Label = DirectCast(Me.Controls("lblInstructions"), Label)
        Dim lblEnjoy As Label = DirectCast(Me.Controls("lblEnjoy"), Label)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
