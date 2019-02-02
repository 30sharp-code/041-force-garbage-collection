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
        Me.btnForceGarbageCollection = New System.Windows.Forms.Button
        Me.btnAllocateObject = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnForceGarbageCollection
        '
        Me.btnForceGarbageCollection.Location = New System.Drawing.Point(46, 86)
        Me.btnForceGarbageCollection.Name = "btnForceGarbageCollection"
        Me.btnForceGarbageCollection.Size = New System.Drawing.Size(112, 40)
        Me.btnForceGarbageCollection.TabIndex = 3
        Me.btnForceGarbageCollection.Text = "Force Garbage Collection"
        '
        'btnAllocateObject
        '
        Me.btnAllocateObject.Location = New System.Drawing.Point(46, 24)
        Me.btnAllocateObject.Name = "btnAllocateObject"
        Me.btnAllocateObject.Size = New System.Drawing.Size(112, 40)
        Me.btnAllocateObject.TabIndex = 2
        Me.btnAllocateObject.Text = "Allocate Object"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 154)
        Me.Controls.Add(Me.btnForceGarbageCollection)
        Me.Controls.Add(Me.btnAllocateObject)
        Me.Name = "Form1"
        Me.Text = "www.30sharp.com"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnForceGarbageCollection As System.Windows.Forms.Button
    Friend WithEvents btnAllocateObject As System.Windows.Forms.Button

End Class
