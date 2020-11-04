<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BootUpScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BootUpScreen))
        Me.LblBengalBlue = New System.Windows.Forms.Label()
        Me.LblPOS = New System.Windows.Forms.Label()
        Me.LblPublisher = New System.Windows.Forms.Label()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.LoadBar = New System.Windows.Forms.ProgressBar()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.BootUpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LblProgressValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblBengalBlue
        '
        Me.LblBengalBlue.AutoSize = True
        Me.LblBengalBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBengalBlue.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblBengalBlue.Location = New System.Drawing.Point(47, 49)
        Me.LblBengalBlue.Name = "LblBengalBlue"
        Me.LblBengalBlue.Size = New System.Drawing.Size(570, 108)
        Me.LblBengalBlue.TabIndex = 0
        Me.LblBengalBlue.Text = "Bengal Blue"
        Me.LblBengalBlue.UseWaitCursor = True
        '
        'LblPOS
        '
        Me.LblPOS.AutoSize = True
        Me.LblPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPOS.Location = New System.Drawing.Point(471, 139)
        Me.LblPOS.Name = "LblPOS"
        Me.LblPOS.Size = New System.Drawing.Size(128, 55)
        Me.LblPOS.TabIndex = 1
        Me.LblPOS.Text = "POS"
        Me.LblPOS.UseWaitCursor = True
        '
        'LblPublisher
        '
        Me.LblPublisher.AutoSize = True
        Me.LblPublisher.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPublisher.Location = New System.Drawing.Point(12, 9)
        Me.LblPublisher.Name = "LblPublisher"
        Me.LblPublisher.Size = New System.Drawing.Size(81, 15)
        Me.LblPublisher.TabIndex = 2
        Me.LblPublisher.Text = "Hyper Studios™"
        Me.LblPublisher.UseWaitCursor = True
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.Location = New System.Drawing.Point(612, 9)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(40, 14)
        Me.LblVersion.TabIndex = 3
        Me.LblVersion.Text = "0.2.6.1"
        Me.LblVersion.UseWaitCursor = True
        '
        'LoadBar
        '
        Me.LoadBar.Location = New System.Drawing.Point(24, 243)
        Me.LoadBar.Maximum = 500
        Me.LoadBar.Name = "LoadBar"
        Me.LoadBar.Size = New System.Drawing.Size(614, 32)
        Me.LoadBar.TabIndex = 4
        Me.LoadBar.UseWaitCursor = True
        '
        'LblStatus
        '
        Me.LblStatus.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(101, 194)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(469, 35)
        Me.LblStatus.TabIndex = 5
        Me.LblStatus.Text = "Initialising System"
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblStatus.UseWaitCursor = True
        '
        'BootUpTimer
        '
        Me.BootUpTimer.Interval = 1
        '
        'LblProgressValue
        '
        Me.LblProgressValue.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProgressValue.Location = New System.Drawing.Point(101, 278)
        Me.LblProgressValue.Name = "LblProgressValue"
        Me.LblProgressValue.Size = New System.Drawing.Size(469, 35)
        Me.LblProgressValue.TabIndex = 6
        Me.LblProgressValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblProgressValue.UseWaitCursor = True
        '
        'BootUpScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 332)
        Me.Controls.Add(Me.LblProgressValue)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.LoadBar)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.LblPublisher)
        Me.Controls.Add(Me.LblPOS)
        Me.Controls.Add(Me.LblBengalBlue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BootUpScreen"
        Me.ShowInTaskbar = False
        Me.Text = "Loading Bengal Blue POS"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBengalBlue As Label
    Friend WithEvents LblPOS As Label
    Friend WithEvents LblPublisher As Label
    Friend WithEvents LblVersion As Label
    Friend WithEvents LoadBar As ProgressBar
    Friend WithEvents LblStatus As Label
    Friend WithEvents BootUpTimer As Timer
    Friend WithEvents LblProgressValue As Label
End Class
