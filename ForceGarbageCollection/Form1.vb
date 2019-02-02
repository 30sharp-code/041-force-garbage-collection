'--------------------------------------------------------------
'
'               www.30sharp.com
'
'--------------------------------------------------------------
Public Class Form1

    Private m_ObjectNumber As Integer = 0

    ' Create an object.
    Private Sub btnAllocateObject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllocateObject.Click
        Dim obj As New TestClass
        obj.ObjectNumber = m_ObjectNumber
        MessageBox.Show("Created object " & m_ObjectNumber)
        m_ObjectNumber += 1
    End Sub

    ' Collect all garbage generations.
    Private Sub btnForceGarbageCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForceGarbageCollection.Click
        GC.Collect()
        MessageBox.Show("Done")
    End Sub
End Class
Public Class TestClass
    Public ObjectNumber As Integer

    ' Display a finalization message.
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        MessageBox.Show("Finalizing " & ObjectNumber)
    End Sub
End Class