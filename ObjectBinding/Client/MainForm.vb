' Copyright © Microsoft Corporation.  All Rights Reserved.
' This code released under the terms of the 
' Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
'
' Copyright (c) Microsoft Corporation. All rights reserved.
Imports CustomerLibrary

Public Class MainForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CustomersBindingSource.DataSource = CustomerManager.GetAllCustomers()
    End Sub

    Private Sub CustomersBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles CustomersBindingSource.AddingNew
        e.NewObject = CustomerManager.GetNewCustomer()
    End Sub
End Class