Public Class InviterDetail
    Public Property MemberID As Integer
    Public Property UserName As String
    Public Property Hobby As String
    Public Property Picture As Image

    Public Sub tempNotice(memberID As Integer, userName As String, hobby As String, pic As Image)
        Me.MemberID = memberID
        Me.UserName = userName
        Me.Hobby = hobby
        Me.Picture = pic
    End Sub

    Public Sub New()
        Me.MemberID = Nothing
        Me.UserName = Nothing
        Me.Hobby = Nothing
        Me.Picture = Nothing
    End Sub

End Class
