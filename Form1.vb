'Nama: Muhammad Rafi Casey Susanto
'NIM: 230401020014
'Kelas: IT101 Pemrogramman Visual


Imports System.IO

Public Class TheFile
    Private Sub Buka_Click(sender As Object, e As EventArgs) Handles Buka.Click
        Dim path As String = TextBoxPath.Text

        If Directory.Exists(path) Then
            BukaFolder(path)
        ElseIf File.Exists(path) Then
            BukaFile(path)
        Else
            MessageBox.Show("Path tidak valid.")
        End If
    End Sub

    Private Sub BukaFolder(path As String)
        ListBoxItems.Items.Clear()
        Dim folders() As String = Directory.GetDirectories(path)
        Dim files() As String = Directory.GetFiles(path)

        For Each folder In folders
            ListBoxItems.Items.Add(IO.Path.GetFileName(folder) & " (Folder)")
        Next

        For Each file In files
            ListBoxItems.Items.Add(IO.Path.GetFileName(file) & " (File)")
        Next
    End Sub

    Private Sub BukaFile(path As String)
        If IO.Path.GetExtension(path).ToLower() = ".txt" Then
            Try
                TextBoxEditor.Text = File.ReadAllText(path)
                TextBoxPath.Text = path
            Catch ex As Exception
                MessageBox.Show("Tidak dapat membuka file.")
            End Try
        Else
            MessageBox.Show("Hanya file teks (.txt) yang dapat dibuka dan diedit.")
        End If
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        Dim path As String = TextBoxPath.Text

        If File.Exists(path) Then
            Try
                File.WriteAllText(path, TextBoxEditor.Text)
                MessageBox.Show("Perubahan telah disimpan.")
            Catch ex As Exception
                MessageBox.Show("Tidak dapat menyimpan perubahan pada file.")
            End Try
        Else
            MessageBox.Show("File tidak ditemukan.")
        End If
    End Sub

    Private Sub TextBoxEditor_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEditor.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
