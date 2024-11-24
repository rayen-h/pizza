Public Class Form1
    Private Sub combobox_selectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim taille = ComboBox1.SelectedItem.ToString()
        Dim ingredient As String = ""
        If RadioButton1.Checked Then
            ingredient = "croute fine"
        ElseIf RadioButton2.Checked Then
            ingredient = "courte classique"
        ElseIf RadioButton3.Checked Then
            ingredient = "courte epaisse"

        End If

        Dim ingrsupp As String = ""
        If CheckBox1.Checked Then
            ingrsupp = "champigions"
        ElseIf CheckBox2.Checked Then
            ingrsupp = "olives"
        ElseIf CheckBox3.Checked Then
            ingrsupp = "poivres"
        ElseIf CheckBox4.Checked Then
            ingrsupp = "fromage supplimentaire"

        End If

        Dim msg As String = "taille :" + taille + "   " + " type de courte :" + ingredient + "    " + " ingredient supplimentaire :" + ingrsupp
        MessageBox.Show(msg)


    End Sub
End Class