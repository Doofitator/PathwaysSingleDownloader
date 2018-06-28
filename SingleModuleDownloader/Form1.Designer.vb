<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_downloadModule = New System.Windows.Forms.Button()
        Me.btn_downloadVideo = New System.Windows.Forms.Button()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_downloadModule
        '
        Me.btn_downloadModule.Location = New System.Drawing.Point(12, 103)
        Me.btn_downloadModule.Name = "btn_downloadModule"
        Me.btn_downloadModule.Size = New System.Drawing.Size(75, 23)
        Me.btn_downloadModule.TabIndex = 1
        Me.btn_downloadModule.Text = "Module"
        Me.btn_downloadModule.UseVisualStyleBackColor = True
        '
        'btn_downloadVideo
        '
        Me.btn_downloadVideo.Location = New System.Drawing.Point(176, 103)
        Me.btn_downloadVideo.Name = "btn_downloadVideo"
        Me.btn_downloadVideo.Size = New System.Drawing.Size(75, 23)
        Me.btn_downloadVideo.TabIndex = 2
        Me.btn_downloadVideo.Text = "Video"
        Me.btn_downloadVideo.UseVisualStyleBackColor = True
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(12, 52)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(239, 20)
        Me.txt_code.TabIndex = 0
        Me.txt_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter the pathways module code below and click the media you would like to downlo" &
    "ad."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "e.g. ACMNA182-06"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 138)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.btn_downloadVideo)
        Me.Controls.Add(Me.btn_downloadModule)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Single Module Downloader by Ash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_downloadModule As Button
    Friend WithEvents btn_downloadVideo As Button
    Friend WithEvents txt_code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
