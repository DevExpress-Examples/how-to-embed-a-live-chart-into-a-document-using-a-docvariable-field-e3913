﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace BizPad
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New RibbonForm1())
        End Sub
    End Class
End Namespace
