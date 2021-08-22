Imports System.Runtime.CompilerServices
Imports EPDM.Interop.epdm

Public Module Extensions

    ''' <summary>
    ''' Returns an array containing vault names.
    ''' </summary>
    ''' <param name="vault">Vault object.</param>
    ''' <param name="OnlyLoggedIn">Only return logged in vault.</param>
    ''' <returns>An array of strings.</returns>
    <Extension()>
    Public Function GetVaultNames(ByVal vault As EdmVault5Class, ByVal OnlyLoggedIn As Boolean) As String()

        If vault Is Nothing Then
            Throw New ArgumentNullException("vault")
        End If

        Dim viewInfos As EdmViewInfo() = Nothing

        vault.GetVaultViews(viewInfos, OnlyLoggedIn)

        Dim vaultNames As New List(Of String)

        If viewInfos IsNot Nothing Then

            For Each viewInfo As EdmViewInfo In viewInfos
                vaultNames.Add(viewInfo.mbsVaultName)
            Next

        End If

        Return vaultNames.ToArray()

    End Function




End Module
