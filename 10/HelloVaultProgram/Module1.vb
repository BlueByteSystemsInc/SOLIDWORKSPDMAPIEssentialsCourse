Imports Core
Imports EPDM.Interop.epdm
Module Module1
    Sub Main()

        Dim vault As New EdmVault5Class()
        Dim vaultNames = vault.GetVaultNames(False)
        If vaultNames IsNot Nothing Then
            For Each vaultName As String In vaultNames
                Console.WriteLine(vaultName)
            Next
        End If
    End Sub

End Module
