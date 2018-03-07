<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.btnTrans = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnPresent = New System.Windows.Forms.Button()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.btnMap = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.klojh = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTrans
        '
        Me.btnTrans.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrans.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTrans.Location = New System.Drawing.Point(27, 469)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(426, 248)
        Me.btnTrans.TabIndex = 0
        Me.btnTrans.Text = "Transport"
        Me.btnTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTrans.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInfo.Location = New System.Drawing.Point(461, 469)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(426, 248)
        Me.btnInfo.TabIndex = 1
        Me.btnInfo.Text = "Information"
        Me.btnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnPresent
        '
        Me.btnPresent.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPresent.Location = New System.Drawing.Point(895, 215)
        Me.btnPresent.Name = "btnPresent"
        Me.btnPresent.Size = New System.Drawing.Size(426, 248)
        Me.btnPresent.TabIndex = 5
        Me.btnPresent.Text = "Presenter"
        Me.btnPresent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPresent.UseVisualStyleBackColor = True
        '
        'btnTime
        '
        Me.btnTime.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTime.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTime.Location = New System.Drawing.Point(461, 215)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(426, 248)
        Me.btnTime.TabIndex = 4
        Me.btnTime.Text = "Timetable"
        Me.btnTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'btnMap
        '
        Me.btnMap.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMap.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMap.Location = New System.Drawing.Point(27, 215)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(426, 248)
        Me.btnMap.TabIndex = 3
        Me.btnMap.Text = "Map"
        Me.btnMap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMap.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(663, 50)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Welcome to the ECIS Conference 2018"
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(895, 469)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 248)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quick Information"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.ECIS_Logo_F_01
        Me.PictureBox2.Location = New System.Drawing.Point(310, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(157, 141)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.lin
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'klojh
        '
        Me.klojh.BackColor = System.Drawing.Color.RoyalBlue
        Me.klojh.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.klojh.Location = New System.Drawing.Point(465, 0)
        Me.klojh.Name = "klojh"
        Me.klojh.Size = New System.Drawing.Size(885, 141)
        Me.klojh.TabIndex = 10
        Me.klojh.Text = "Main Menu"
        Me.klojh.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(854, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 32)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1111, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 32)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.klojh)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPresent)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.btnMap)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnTrans)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main menu"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTrans As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnPresent As Button
    Friend WithEvents btnTime As Button
    Friend WithEvents btnMap As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents klojh As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
