Public Class Form1
    Private isAdding As Boolean = False
    Private isSubtracting As Boolean = False
    Private isDividing As Boolean = False
    Private isMultiplying As Boolean = False
    Private isModulus As Boolean = False


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isAdding = False Then
            Dim answer As Double = add(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            isAdding = True
        ElseIf isAdding Then
            Dim ans As Double = add(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()

        Else
            Dim MessageBoxIcons As Object = Nothing
            MessageBox.Show("Please fill all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        End If


    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isSubtracting = False Then
            Dim answer As Double = subtract(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            isSubtracting = True
        ElseIf isSubtracting Then
            Dim ans As Double = subtract(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()

        Else
            Dim MessageBoxIcons As Object = Nothing
            MessageBox.Show("Please fill all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isDividing = False Then
            Dim answer As Double = divide(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            isDividing = True
        ElseIf isDividing Then
            Dim ans As Double = divide(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()

        Else
            Dim MessageBoxIcons As Object = Nothing
            MessageBox.Show("Please fill all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        End If


    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isMultiplying = False Then
            Dim answer As Double = multiply(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            isMultiplying = True
        ElseIf isMultiplying Then
            Dim ans As Double = multiply(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()

        Else
            Dim MessageBoxIcons As Object = Nothing
            MessageBox.Show("Please fill all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        End If


    End Sub

    Private Sub btnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isModulus = False Then
            Dim answer As Double = modulus(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            isModulus = True
        ElseIf isModulus Then
            Dim ans As Double = modulus(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()

        Else
            Dim MessageBoxIcons As Object = Nothing
            MessageBox.Show("Please fill all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        End If


    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        If txtNum1.Text.Length <> 0 Then
            Dim answer As Double = PI(CType(txtNum1.Text, Double))
            txtAnswer.Text = String.Format("{0:n3}", answer)
            txtNum2.Text = String.Format("{0: n3}", Math.PI)
            txtNum2.ReadOnly = True
            isAdding = True
        ElseIf isAdding Then
            Dim ans As Double = add(CType(txtNum1.Text, Double), CType(txtAnswer.Text, Double))
            txtAnswer.Text = ans.ToString()

        Else
            Dim MessageBoxIcons As Object = Nothing
            MessageBox.Show("Please fill all fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        End If
    End Sub

    Private Function add(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function

    Private Function subtract(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function

    Private Function divide(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 / num2
    End Function

    Private Function multiply(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function

    Private Function modulus(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 Mod num2
    End Function


    Private Function PI(ByVal num1 As Double) As Double
        Return num1 * Math.PI
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum2.ReadOnly = False
        revertBool()
        txtNum1.Clear()
        txtNum2.Clear()
        txtAnswer.Clear()


    End Sub

    Private Sub revertBool()
        isAdding = False
        isSubtracting = False
        isDividing = False
        isModulus = False
        isMultiplying = False
    End Sub

    Private Sub btnPi_MouseHover(sender As Object, e As EventArgs) Handles btnPi.MouseHover
        tlTipPi.SetToolTip(btnPi, "Only one value is needed in this first value field")
    End Sub
End Class
