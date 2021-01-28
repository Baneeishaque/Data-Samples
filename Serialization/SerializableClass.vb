' Copyright © Microsoft Corporation.  All Rights Reserved.
' This code released under the terms of the 
' Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
'
' Copyright (c) Microsoft Corporation. All rights reserved.
' This class is marked as Serializable. 
<Serializable()> Public Class SerializableClass

    ' All fields in this class will be serialized, regardless of scope, 
    ' unless they are specifically marked as NonSerialized, like z.

    Public PublicVariable As Integer
    Private privateVariable As Integer
    <NonSerialized()> Public NonSerializedVariable As Integer


    ''' <summary>
    ''' Simple constructor to load in values for the fields.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal publicVar As Integer, ByVal privateVar As Integer, ByVal nonSerializedVar As Integer)
        Me.PublicVariable = publicVar
        Me.privateVariable = privateVar
        Me.NonSerializedVariable = nonSerializedVar
    End Sub


    ''' <summary>
    ''' Property to view the value of the private field y.
    ''' </summary>
    Public ReadOnly Property PublicProperty() As Integer
        Get
            Return privateVariable
        End Get
    End Property
End Class
