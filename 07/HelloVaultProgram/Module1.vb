Imports EPDM.Interop.epdm
Module Module1
    Sub Main()

        Dim vault As New EdmVault5Class()
        Dim appMainWindowHandle = Process.GetCurrentProcess().MainWindowHandle.ToInt32

        'print hello vault message
        vault.MsgBox(appMainWindowHandle, "Hello Vault!")


    End Sub

End Module
