Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1
    Private TargetProcessHandle As Integer
    Private pfnStartAddr As Integer
    Private pszLibFileRemote As String
    Private TargetBufferSize As Integer

    Public Const PROCESS_VM_READ = &H10
    Public Const TH32CS_SNAPPROCESS = &H2
    Public Const MEM_COMMIT = 4096
    Public Const PAGE_READWRITE = 4
    Public Const PROCESS_CREATE_THREAD = (&H2)
    Public Const PROCESS_VM_OPERATION = (&H8)
    Public Const PROCESS_VM_WRITE = (&H20)
    Dim DLLFileName As String
    Public Declare Function ReadProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (
    ByVal lpLibFileName As String) As Integer

    Public Declare Function VirtualAllocEx Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpAddress As Integer,
    ByVal dwSize As Integer,
    ByVal flAllocationType As Integer,
    ByVal flProtect As Integer) As Integer

    Public Declare Function WriteProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function GetProcAddress Lib "kernel32" (
    ByVal hModule As Integer, ByVal lpProcName As String) As Integer

    Private Declare Function GetModuleHandle Lib "Kernel32" Alias "GetModuleHandleA" (
    ByVal lpModuleName As String) As Integer

    Public Declare Function CreateRemoteThread Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpThreadAttributes As Integer,
    ByVal dwStackSize As Integer,
    ByVal lpStartAddress As Integer,
    ByVal lpParameter As Integer,
    ByVal dwCreationFlags As Integer,
    ByRef lpThreadId As Integer) As Integer

    Public Declare Function OpenProcess Lib "kernel32" (
    ByVal dwDesiredAccess As Integer,
    ByVal bInheritHandle As Integer,
    ByVal dwProcessId As Integer) As Integer

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (
    ByVal lpClassName As String,
    ByVal lpWindowName As String) As Integer

    Private Declare Function CloseHandle Lib "kernel32" Alias "CloseHandleA" (
    ByVal hObject As Integer) As Integer


    Dim ExeName As String = IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath)
    Private Sub Inject()
        On Error GoTo 1 ' If error occurs, app will close without any error messages
        Timer1.Stop()
        Dim TargetProcess As Process() = Process.GetProcessesByName(TextBox1.Text)
        TargetProcessHandle = OpenProcess(PROCESS_CREATE_THREAD Or PROCESS_VM_OPERATION Or PROCESS_VM_WRITE, False, TargetProcess(0).Id)
        pszLibFileRemote = OpenFileDialog1.FileName
        pfnStartAddr = GetProcAddress(GetModuleHandle("Kernel32"), "LoadLibraryA")
        TargetBufferSize = 1 + Len(pszLibFileRemote)
        Dim Rtn As Integer
        Dim LoadLibParamAdr As Integer
        LoadLibParamAdr = VirtualAllocEx(TargetProcessHandle, 0, TargetBufferSize, MEM_COMMIT, PAGE_READWRITE)
        Rtn = WriteProcessMemory(TargetProcessHandle, LoadLibParamAdr, pszLibFileRemote, TargetBufferSize, 0)
        CreateRemoteThread(TargetProcessHandle, 0, 0, pfnStartAddr, LoadLibParamAdr, 0, 0)
        CloseHandle(TargetProcessHandle)
1:      Me.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If InternetConnection() = False Then
            Label3.ForeColor = Color.Red
            Label3.Text = "Not Connected."
        Else
            Label3.ForeColor = Color.LimeGreen
            Label3.Text = "Connected."
        End If

        ProgramCombo.Items.Add("none")
        ProgramCombo.Items.Add("csgo")
        ProgramCombo.Items.Add("ros")

        DLLs.Name = "DLLs"
        BrowseButton.Text = "Browse"
        Label1.Text = "Waiting for Program to Start.."
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Function InternetConnection() As Boolean
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("https://www.google.com.ph/")
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles InjectButton.Click
        If IO.File.Exists(OpenFileDialog1.FileName) Then
            Dim TargetProcess As Process() = Process.GetProcessesByName(TextBox1.Text)
            If TargetProcess.Length = 0 Then

                Me.Label1.Text = ("Waiting for " + TextBox1.Text + ".exe")
            Else
                Timer1.Stop()
                Me.Label1.Text = "Successfully Injected!"
                Call Inject()
                If CheckBox1.Checked = True Then
                    End
                Else
                End If
            End If
        Else
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If IO.File.Exists(OpenFileDialog1.FileName) Then
            Dim TargetProcess As Process() = Process.GetProcessesByName(TextBox1.Text)
            If TargetProcess.Length = 0 Then

                Me.Label1.Text = ("Waiting for " + TextBox1.Text + ".exe")
            Else
                Timer1.Stop()
                Me.Label1.Text = "Successfully Injected!"
                Call Inject()
                If CheckBox1.Checked = True Then
                    End
                Else
                End If
            End If
        Else
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim FileName As String
        FileName = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\"))
        Dim DllFileName As String = FileName.Replace("\", "")
        Me.DLLs.Items.Add(DllFileName)
    End Sub

    Private Sub BrowseButton_Click_1(sender As Object, e As EventArgs) Handles BrowseButton.Click
        OpenFileDialog1.Filter = "DLL (*.dll) |*.dll"
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        For i As Integer = (DLLs.SelectedItems.Count - 1) To 0 Step -1
            DLLs.Items.Remove(DLLs.SelectedItems(i))
        Next
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DLLs.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        InjectButton.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        InjectButton.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub ProgramCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProgramCombo.SelectedIndexChanged
        If ProgramCombo.SelectedItem = ("csgo") Then ' For CSGO Only...
            TextBox1.Text = ProgramCombo.SelectedItem

        ElseIf ProgramCombo.SelectedItem = ("ros") Then ' For Rules of Survival Only...
            TextBox1.Text = ProgramCombo.SelectedItem

        ElseIf ProgramCombo.SelectedItem = ("none") Then ' Nothing is selected...
            TextBox1.Text = ""
        End If
    End Sub
End Class

