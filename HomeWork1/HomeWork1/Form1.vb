' Project: Homework1
' Author:  Dominic Vadala
' Description: This project inputs car rental informatio for a car rental company.
' It calculates the miles driven and the total charged for the renatl company.



Public Class RentalChargesForm
    Const DAILY_RATE_DECIMAL As Decimal = 40
    Const MILEAGE_RATE_DECIMAL As Decimal = 0.25D

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' exit program
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear previous amounts from the form

        EndOdometerTextBox.Clear()
        NumberDaysTextBox.Clear()
        MilesDrivenTextBox.Clear()
        TotalChargeTextBox.Clear()
        With BeginOdometerTextBox
            .Clear()
            .Focus()
        End With

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim BeginningOdometerDecimal, EndingOdometerDecimal As Decimal
        Dim NumOfDaysInt As Integer
        Dim MilesDrivenDecimal, NumDaysCharge, TotalChargeDecimal, MileagePriceDecimal As Decimal

        ' Check if beging odometer is numeric
        Try
            BeginningOdometerDecimal = Decimal.Parse(BeginOdometerTextBox.Text)

            Try
                ' check if ending odometer is a valid input
                EndingOdometerDecimal = Decimal.Parse(EndOdometerTextBox.Text)

                Try
                    ' check if number of days is a valid input
                    NumOfDaysInt = Integer.Parse(NumberDaysTextBox.Text)

                    ' calculations
                    ' Calculate the miles driven end odometer - begin odometer
                    MilesDrivenDecimal = EndingOdometerDecimal - BeginningOdometerDecimal
                    ' Calculate price for miles drive miles driven * mileage rate
                    MileagePriceDecimal = MilesDrivenDecimal * MILEAGE_RATE_DECIMAL
                    ' Days charge number of days * daily rate
                    NumDaysCharge = NumOfDaysInt * DAILY_RATE_DECIMAL
                    ' calculate the total charge mileage price + number days charge
                    TotalChargeDecimal = NumDaysCharge + MileagePriceDecimal

                    ' output to text box
                    MilesDrivenTextBox.Text = MilesDrivenDecimal.ToString("n1")
                    TotalChargeTextBox.Text = TotalChargeDecimal.ToString("c")





                Catch NumberOfDaysException As FormatException

                    ' if number of dasy is an invalid input through error and focus on text box

                    MessageBox.Show("Number of days must be a number",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                    ' select Number of Days text box
                    With NumberDaysTextBox
                        .Focus()
                        .SelectAll()
                    End With


                End Try

            Catch EndOdometerException As FormatException

                MessageBox.Show("End Odometer must be numeric",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                ' slect ENDING ODOMETER text box
                With EndOdometerTextBox
                    .Focus()
                    .SelectAll()
                End With

            End Try

        Catch BeginOdometerException As FormatException

            '

            MessageBox.Show("Beginning Odometer must be numeric",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            ' reset the cursor to the failed input
            ' moving cursor to the Beginning Odometer textbox
            BeginOdometerTextBox.Focus()
            ' highlight the text
            BeginOdometerTextBox.SelectAll()
        End Try
    End Sub

    Private Sub RentalChargesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
