Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Public Class FontHelper
    Private Shared privateFonts As New PrivateFontCollection()

    Public Enum CustomFontStyle
        Regular = 0
        Bold = 1
        Italic = 2
        Underline = 4
        Strikeout = 8
    End Enum

    Public Shared Function GetCustomFont(fontName As String, fontSize As Single, style As CustomFontStyle) As Font
        If privateFonts.Families.Length = 0 Then
            ' Load the font only once
            Dim fontPath As String = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\Fonts\Inter.ttf")
            Dim fontData As Byte() = IO.File.ReadAllBytes(fontPath)
            Dim fontPtr As IntPtr = Marshal.AllocCoTaskMem(fontData.Length)
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length)
            privateFonts.AddMemoryFont(fontPtr, fontData.Length)
            Marshal.FreeCoTaskMem(fontPtr)
        End If

        Dim fontStyle As FontStyle = FontStyle.Regular

        If (style And CustomFontStyle.Bold) = CustomFontStyle.Bold Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If (style And CustomFontStyle.Italic) = CustomFontStyle.Italic Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If (style And CustomFontStyle.Underline) = CustomFontStyle.Underline Then
            fontStyle = fontStyle Or FontStyle.Underline
        End If

        If (style And CustomFontStyle.Strikeout) = CustomFontStyle.Strikeout Then
            fontStyle = fontStyle Or FontStyle.Strikeout
        End If

        Return New Font(privateFonts.Families(0), fontSize, fontStyle)
    End Function
End Class
