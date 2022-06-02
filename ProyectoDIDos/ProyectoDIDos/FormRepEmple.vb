Public Class FormRepEmple
    Private Sub FormRepEmple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'cas_lib_dbDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.cas_lib_dbDataSet.Empleados)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        GestionEmpleados.Show()

    End Sub
End Class