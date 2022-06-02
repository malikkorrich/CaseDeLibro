Public Class FormRepLibros
    Private Sub FormRepLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'cas_lib_dbDataSet.Libros' Puede moverla o quitarla según sea necesario.
        Me.LibrosTableAdapter.Fill(Me.cas_lib_dbDataSet.Libros)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        GestionLibro.Show()

    End Sub
End Class