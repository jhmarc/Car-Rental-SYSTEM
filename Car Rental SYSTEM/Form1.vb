Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim conn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim query As String = "INSERT INTO carrental_tb (car_model, renter_name, start_date, end_date) VALUES (@car_model, @renter_name, @start_date, @end_date)"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=carrental_est;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@car_model", TextBoxCar.Text)
                    cmd.Parameters.AddWithValue("@renter_name", TextBoxRenter.Text)
                    cmd.Parameters.AddWithValue("@start_date", DateTimePickerStart.Value)
                    cmd.Parameters.AddWithValue("@end_date", DateTimePickerEnd.Value)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record inserted successfully!")

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim query As String = "SELECT * FROM carrental_tb"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=carrental_est;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvResults.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query = "UPDATE carrental_tb SET car_model=@car_model,renter_name=@renter_name,start_date=@start_date,end_date=@end_date WHERE id=@id"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=carrental_est;")
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@car_model", TextBoxCar.Text)
                    cmd.Parameters.AddWithValue("renter_name", TextBoxRenter.Text)
                    cmd.Parameters.AddWithValue("@start_date", DateTimePickerStart.Value)
                    cmd.Parameters.AddWithValue("end_date", DateTimePickerEnd.Value)
                    cmd.Parameters.AddWithValue("@id", TextBoxID.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Record updated successfully")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query = "DELETE FROM carrental_tb WHERE id=@id"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=carrental_est;")
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TextBoxID.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted sucessfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database=carrental_est;"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL car rental tb as successful")
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub
End Class