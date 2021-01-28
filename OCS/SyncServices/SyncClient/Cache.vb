' Copyright © Microsoft Corporation.  All Rights Reserved.
' This code released under the terms of the 
' Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
'


Partial Public Class CacheSyncAgent
    
    Private Sub OnInitialized()
        Dim proxy As New SyncServiceReference.CacheSyncContractClient
        Dim remoteProvider As New Microsoft.Synchronization.Data.ServerSyncProviderProxy(proxy)

        Me.RemoteProvider = remoteProvider
    End Sub
End Class
