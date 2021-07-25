<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfrom = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lnkAttachment = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblAttachment = New System.Windows.Forms.Label()
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmailFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet = New Email_Form.database2DataSet()
        Me.Table1TableAdapter = New Email_Form.database2DataSetTableAdapters.Table1TableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 41)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(502, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 32)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "[ CLOSE ]"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sender"
        '
        'txtfrom
        '
        Me.txtfrom.Location = New System.Drawing.Point(128, 79)
        Me.txtfrom.Name = "txtfrom"
        Me.txtfrom.Size = New System.Drawing.Size(486, 27)
        Me.txtfrom.TabIndex = 2
        Me.txtfrom.Text = "nirmithdalmeida@hotmail.com"
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(430, 515)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(184, 34)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'lnkAttachment
        '
        Me.lnkAttachment.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lnkAttachment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkAttachment.ForeColor = System.Drawing.Color.Gray
        Me.lnkAttachment.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkAttachment.LinkColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lnkAttachment.Location = New System.Drawing.Point(37, 531)
        Me.lnkAttachment.Name = "lnkAttachment"
        Me.lnkAttachment.Size = New System.Drawing.Size(165, 27)
        Me.lnkAttachment.TabIndex = 15
        Me.lnkAttachment.TabStop = True
        Me.lnkAttachment.Text = "Add Attachment"
        Me.lnkAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnkAttachment.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblAttachment
        '
        Me.lblAttachment.AutoSize = True
        Me.lblAttachment.Location = New System.Drawing.Point(57, 496)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(123, 20)
        Me.lblAttachment.TabIndex = 22
        Me.lblAttachment.Text = "ATTACHMENT"
        '
        'txtmessage
        '
        Me.txtmessage.Location = New System.Drawing.Point(128, 235)
        Me.txtmessage.Multiline = True
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(486, 227)
        Me.txtmessage.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Body"
        '
        'txtto
        '
        Me.txtto.Location = New System.Drawing.Point(128, 126)
        Me.txtto.Name = "txtto"
        Me.txtto.Size = New System.Drawing.Size(486, 27)
        Me.txtto.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Subject"
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(128, 172)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(486, 27)
        Me.txtsubject.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(641, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 493)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmailFromDataGridViewTextBoxColumn, Me.EmailToDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.BodyDataGridViewTextBoxColumn, Me.AttachmentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(497, 467)
        Me.DataGridView1.TabIndex = 0
        '
        'EmailFromDataGridViewTextBoxColumn
        '
        Me.EmailFromDataGridViewTextBoxColumn.DataPropertyName = "emailFrom"
        Me.EmailFromDataGridViewTextBoxColumn.HeaderText = "emailFrom"
        Me.EmailFromDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailFromDataGridViewTextBoxColumn.Name = "EmailFromDataGridViewTextBoxColumn"
        Me.EmailFromDataGridViewTextBoxColumn.Width = 125
        '
        'EmailToDataGridViewTextBoxColumn
        '
        Me.EmailToDataGridViewTextBoxColumn.DataPropertyName = "emailTo"
        Me.EmailToDataGridViewTextBoxColumn.HeaderText = "emailTo"
        Me.EmailToDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailToDataGridViewTextBoxColumn.Name = "EmailToDataGridViewTextBoxColumn"
        Me.EmailToDataGridViewTextBoxColumn.Width = 125
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "subject"
        Me.SubjectDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.Width = 125
        '
        'BodyDataGridViewTextBoxColumn
        '
        Me.BodyDataGridViewTextBoxColumn.DataPropertyName = "body"
        Me.BodyDataGridViewTextBoxColumn.HeaderText = "body"
        Me.BodyDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BodyDataGridViewTextBoxColumn.Name = "BodyDataGridViewTextBoxColumn"
        Me.BodyDataGridViewTextBoxColumn.Width = 125
        '
        'AttachmentDataGridViewTextBoxColumn
        '
        Me.AttachmentDataGridViewTextBoxColumn.DataPropertyName = "attachment"
        Me.AttachmentDataGridViewTextBoxColumn.HeaderText = "attachment"
        Me.AttachmentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AttachmentDataGridViewTextBoxColumn.Name = "AttachmentDataGridViewTextBoxColumn"
        Me.AttachmentDataGridViewTextBoxColumn.Width = 125
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database2DataSet
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(274, 482)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 34)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(274, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 34)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfrom)
        Me.Controls.Add(Me.lblAttachment)
        Me.Controls.Add(Me.txtmessage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsubject)
        Me.Controls.Add(Me.lnkAttachment)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfrom As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents lnkAttachment As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblAttachment As Label
    Friend WithEvents txtmessage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsubject As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database2DataSet As database2DataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As database2DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents EmailFromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailToDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttachmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
