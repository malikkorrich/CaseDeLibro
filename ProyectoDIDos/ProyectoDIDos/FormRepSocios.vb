Public Class FormRepSocios
    Private Sub FormRepSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'cas_lib_dbDataSet.ClientesSocios' Puede moverla o quitarla según sea necesario.
        Me.ClientesSociosTableAdapter.Fill(Me.cas_lib_dbDataSet.ClientesSocios)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        GestionClienteSocio.Show()

    End Sub

End Class