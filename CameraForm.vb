
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge.Imaging.Filters


Public Class CameraForm
    Dim CAM As VideoCaptureDevice
    Dim videoDevices As FilterInfoCollection
    Dim bmp As Bitmap
    Dim img As Image



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        'If cameras.ShowDialog() = DialogResult.OK Then
        '    CAM = cameras.VideoDevice
        '    AddHandler CAM.NewFrame, New NewFrameEventHandler(AddressOf Captured)
        '    CAM.Start()

        'End If

        If CAM.IsRunning = False Then
            CAM.Start()
        End If
    End Sub
    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
        End If
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        PictureBox2.Image = PictureBox1.Image.Clone
        If PictureBox2.Image IsNot Nothing Then
            img = PictureBox2.Image
        End If


        'Dim bm_source As New Bitmap(PictureBox1.Image)

        ''///Camera Bounds
        ''Dim rectImage1 = New Rectangle(PictureBox1.Bounds.X / 2, PictureBox1.Bounds.Y / 2, PictureBox1.Image.Width, PictureBox1.Image.Height)

        ''///Picture to crop Bounds
        ''Dim rectImage2 = New Rectangle(PictureBox2.Bounds.X, PictureBox2.Bounds.Y, PictureBox2.Width, PictureBox2.Height)



        'Dim rect1 As Rectangle = New Rectangle(0, 0, PictureBox1.Image.Width, PictureBox1.Image.Height)
        'Dim rect2 As Rectangle = New Rectangle(PictureBox2.Bounds.X, PictureBox2.Bounds.Y, PictureBox2.Width, PictureBox2.Height)

        'rect2.X = CInt(rect1.X + ((rect1.Width / 2) - (rect2.Width / 2)))
        'rect2.Y = CInt(rect1.Y + ((rect1.Height / 2) - (rect2.Height / 2)))


        ''Dim cropFilter As New Crop(rectImage1)

        'Dim cropFilter As New Crop(rect2)
        'bmp = cropFilter.Apply(bm_source)

        'PictureBox2.Image = bmp

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        SaveFileDialog1.DefaultExt = ".jpg"
        'Dim imageNew As Image = ResizeImage(PictureBox2.Image, 300, 300)

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            'Dim bm_source As New Bitmap(PictureBox2.Image)

            'Dim rect1 As Rectangle = New Rectangle(0, 0, PictureBox2.Image.Width, PictureBox2.Image.Height)
            Dim rect1 As Rectangle = New Rectangle(0, 0, img.Width, img.Height)
            Dim rect2 As Rectangle = New Rectangle(PictureBox2.Bounds.X, PictureBox2.Bounds.Y, PictureBox2.Bounds.Width, PictureBox2.Bounds.Height)

            rect2.X = CInt(rect1.X + ((rect1.Width / 2) - (rect2.Width / 2)))
            rect2.Y = CInt(rect1.Y + ((rect1.Height / 2) - (rect2.Height / 2)))



            Dim cropFilter As New Crop(rect2)
            bmp = cropFilter.Apply(img)

            PictureBox2.Image = bmp

            PictureBox2.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub EnumerateVideoDevices()
        ' enumerate video devices
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count <> 0 Then
            ' add all devices to combo
            For Each device As FilterInfo In videoDevices
                ComboboxSources.Items.Add(device.Name)
            Next
            CAM = New VideoCaptureDevice(videoDevices(0).MonikerString)
            AddHandler CAM.NewFrame, New NewFrameEventHandler(AddressOf Captured)
        Else
            ComboboxSources.Items.Add("No DirectShow devices found")
        End If
        ComboboxSources.SelectedIndex = 0
    End Sub

    'Private Sub EnumerateVideoModes(device As VideoCaptureDevice)
    '    ' get resolutions for selected video source
    '    Me.Cursor = Cursors.WaitCursor
    '    ComboBoxModes.Items.Clear()
    '    Try
    '        VideoCapabilities = videoDevice.VideoCapabilities
    '        For Each capabilty As VideoCapabilities In VideoCapabilities
    '            If Not ComboBoxModes.Items.Contains(capabilty.FrameSize) Then
    '                ComboBoxModes.Items.Add(capabilty.FrameSize)
    '            End If
    '        Next
    '        If VideoCapabilities.Length = 0 Then
    '            ComboBoxModes.Items.Add("Not supported")
    '        End If
    '        ComboBoxModes.SelectedIndex = 0
    '    Finally
    '        Me.Cursor = Cursors.[Default]
    '    End Try
    'End Sub

    'Private Sub CameraStart()
    '    If videoDevice IsNot Nothing Then
    '        If (VideoCapabilities IsNot Nothing) AndAlso (VideoCapabilities.Length <> 0) Then
    '            videoDevice.DesiredFrameSize = DirectCast(ComboBoxModes.SelectedItem, Size)
    '        End If
    '        VideoSourcePlayer1.VideoSource = videoDevice
    '        VideoSourcePlayer1.Start()
    '    End If
    'End Sub

    Private Sub CameraStop()
        If CAM IsNot Nothing And CAM.IsRunning Then
            ' stop video device
            CAM.SignalToStop()
            CAM = Nothing
        End If
    End Sub

    Private Sub CameraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnumerateVideoDevices()

    End Sub

    Private Sub CameraForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CameraStop()
    End Sub

End Class