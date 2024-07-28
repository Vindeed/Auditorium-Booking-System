Module Global_Variables
    Public Structure sClient
        <VBFixedString(15)> Public FName As String
        <VBFixedString(15)> Public LName As String
        Public DOB As Date
        Public Phone As Long
        <VBFixedArray(39)> Public SeatsBooked() As Byte
        Public Payment As Decimal
        Public ccNumber As Long
        <VBFixedString(30)> Public ccName As String
        Public ccPin As Integer
        Public ccExpiry As Date

        'cc is an abbreviation for credit card

    End Structure

    'Main array of records/structures
    Public arrClients(39) As sClient

    'Largest filled index in the array
    Public arrCurrentMaxValue As Byte

    'Used to find the size of a field in the array
    Public arrClientTemp As New sClient
    Public shRecClientSize As Short = Len(arrClientTemp)

    'For Update Screen and UpdateSeats Screen
    Public bytRecToBeUpdated As Byte

    'INPUT and UPDATE process variables
    <VBFixedString(15)> Public FName As String
    <VBFixedString(15)> Public LName As String
    Public DOB As Date
    Public Phone As Long
    <VBFixedArray(39)> Public SeatsBooked() As Byte
    Public Payment As Decimal

    Public Function ChangeDateFormat(ByRef DataGridView As Object) As Object
        DataGridView.Columns(2).DefaultCellStyle.Format = "d"

        Return DataGridView
    End Function

    Public Function ChangeHeight(ByRef DataGridView As Object) As Object
        For i = 0 To DataGridView.Rows.Count - 1
            DataGridView.Rows(i).Height = 40
        Next

        Return DataGridView
    End Function

    Public Function DisableSorting(ByRef DataGridView As Object) As Object
        For i = 0 To DataGridView.Columns.Count - 1
            DataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic '
        Next i

        Return DataGridView
    End Function

    Public Function PopulateDGV(ByRef DataGridView As Object) As Object
        For i = 0 To arrCurrentMaxValue - 1
            DataGridView.Rows.Add(arrClients(i).FName, arrClients(i).LName, arrClients(i).DOB, arrClients(i).Phone, arrClients(i).Payment)
        Next

        Return DataGridView
    End Function

    Public Function RemoveArrows(ByRef NumericUpDown As Object) As Object
        NumericUpDown.Controls(0).Hide()

        Return NumericUpDown
    End Function


End Module
