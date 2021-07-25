Imports System.Net.Mail
Imports System.IO
Public Class Form1
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Dispose()
    End Sub
    Dim a As String = ""
    Private Sub lnkAttachment_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAttachment.LinkClicked
        'With OpenFileDialog1
        '.FileName = ""
        '.Multiselect = False

        'End With
        If OpenFileDialog1.ShowDialog() = 1 Then
            lblAttachment.Text = OpenFileDialog1.FileName
            a = OpenFileDialog1.FileName
        Else
            lblAttachment.Text = "Add Attachment"
        End If
    End Sub
    Dim accountFrom As String = "nirmithdalmeida@hotmail.com"
    Dim message As New MailMessage
    Dim smtp As New SmtpClient
    Dim instance As IDisposable
    Private Sub btnSend_Click(sender As Object, e As EventArgs, Optional ByVal lnkAttachment As String = "") Handles btnSend.Click
        Try
            Dim Mail As New MailMessage
            Mail.To.Add(txtto.Text)
            Mail.Subject = txtsubject.Text
            Mail.From = New MailAddress(accountFrom)
            Mail.Body = txtmessage.Text
            'Dim attach As New Attachment(OpenFileDialog1.FileName)

            'Dim attach As New System.Net.Mail.Attachment(OpenFileDialog1.FileName)
            'If Not (a = "") Then
            'Mail.Attachments.Add(attach)
            'End If

            Dim SMTP As New SmtpClient("smtp-mail.outlook.com")
            SMTP.Port = 587
            SMTP.Credentials = New System.Net.NetworkCredential(accountFrom, "noel06072000")
            SMTP.EnableSsl = True
            SMTP.Send(Mail)
            MsgBox("Sent Successfully")
            'Table1BindingSource.EndEdit()
            'Table1TableAdapter.Update(Database2DataSet)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Table1' table. You can move, or remove it, as needed.
        'Me.Table1TableAdapter.Fill(Me.Database2DataSet.Table1)
        'txtfrom.Text = accountFrom
        'txtfrom.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Table1BindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Table1BindingSource.RemoveCurrent()
    End Sub

    Private Sub txtfrom_TextChanged(sender As Object, e As EventArgs) Handles txtfrom.TextChanged
        'txtfrom.Text = accountFrom
    End Sub
End Class
