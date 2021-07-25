Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub
    Dim con As New SqlConnection("Data Source=LAPTOP-C4KRQ36J\SQLEXPRESS;Initial Catalog=ProgrammingDB;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim pid As Integer = Textproductid.Text
            Dim iname As String = Textitemname.Text
            Dim design As String = Textdesign.Text
            Dim color As String = Combocolor.Text
            Dim insertdate As DateTime = DateTimePickerinsert.Text
            Dim wtype As String = ""
            If Radioallowed.Checked Then
                wtype = "Allowed"
            Else
                wtype = "Not Allowed"
            End If
            con.Open()
            Dim command As New SqlCommand("Insert into Product_Setup_Table values('" & pid & "','" & iname & "','" & design & "','" & color & "','" & insertdate & "','" & wtype & "')", con)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Inserted")
            LoadDataInGrid()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Either Item is Duplicated or It Failed to add to Database")
        End Try


    End Sub
    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("select * from Product_Setup_Table", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim pid As Integer = Textproductid.Text
            Dim iname As String = Textitemname.Text
            Dim design As String = Textdesign.Text
            Dim color As String = Combocolor.Text
            Dim insertdate As DateTime = DateTimePickerinsert.Text
            Dim wtype As String = ""
            If Radioallowed.Checked Then
                wtype = "Allowed"
            Else
                wtype = "Not Allowed"
            End If
            con.Open()
            Dim command As New SqlCommand("update Product_Setup_Table set ItemName = '" & iname & "',Design = '" & design & "',Color = '" & color & "',ItemDate = '" & insertdate & "',Warranty = '" & wtype & "' where Product_ID = '" & pid & "'", con)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Updated.")
            LoadDataInGrid()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Either Item is Duplicated or It Failed to add to Database")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("are you sure to delete?", "Delete Item", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            con.Open()
            Dim pid As Integer = Textproductid.Text
            Dim command As New SqlCommand("delete Product_Setup_Table where Product_ID = '" & pid & "'", con)
            command.ExecuteNonQuery()
            MessageBox.Show("ITEM DELETED")
            LoadDataInGrid()
            con.Close()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim pid As Integer = Textproductid.Text
            Dim command As New SqlCommand("select * from Product_Setup_Table where Product_ID = '" & pid & "'", con)
            Dim sda As New SqlDataAdapter(command)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ITEM NOT FOUND")
        End Try

    End Sub
End Class
