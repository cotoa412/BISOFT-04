Public Class Horario
    Dim db As New database
    Private Sub Horario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show_Schedule()

    End Sub

    Private Sub Show_Schedule()

        Dim i As Integer = 1
        Dim Max As Integer = 3

        While i <= 7

            Dim rows = db.ReaderQuery("SELECT a.[Inicio],a.[Fin],a.[Desc] From [Periods] p,[AcitvityHorario] a,[User] us WHERE a.[User]=p.[User] AND us.[UserName]='" & Profile.TextBoxUser.Text & "' AND us.[Id]=a.[User] AND us.[Id]=p.[User]
                                        And a.[Id]=p.[Id] AND p.Day='" & i & "'")

            If rows.count > 0 Then

                Dim Num As Integer = 0
                Dim X As Integer = 0
                Dim Y As Integer = 0

                If i = 2 Then
                    X = 1
                End If

                If i = 3 Then
                    X = 2
                End If

                If i = 4 Then
                    X = 3
                End If

                If i = 5 Then
                    X = 6
                End If

                If i = 6 Then
                    X = 5
                End If

                If i = 7 Then
                    X = 6
                End If





                For Each Item In rows

                    If Y > 3 And rows.count > Max Then

                        Me.Size = New Size(Me.Width, Me.Height + 44)


                    End If

                    Dim PanelHorario As New Panel
                    Dim LabelInicio As New Label
                    Dim LabelInicio_Hora As New Label
                    Dim LabelFin As New Label
                    Dim LabelFin_Hora As New Label
                    Dim LabelDesc_Desc As New Label

                    LabelInicio.Text = "Inicio:"
                    LabelInicio.Location = New Point(10, 9)
                    LabelInicio.AutoSize = True
                    LabelInicio.Font = New Font(LabelInicio.Font, FontStyle.Bold)
                    LabelInicio.Visible = True
                    PanelHorario.Controls.Add(LabelInicio)

                    LabelInicio_Hora.Text = rows(Num).Item("Inicio").ToString
                    LabelInicio_Hora.Location = New Point(49, 9)
                    LabelInicio_Hora.AutoSize = True
                    LabelInicio_Hora.Font = New Font(LabelInicio_Hora.Font, FontStyle.Bold)
                    LabelInicio_Hora.Visible = True
                    PanelHorario.Controls.Add(LabelInicio_Hora)

                    LabelFin.Text = "Fin:"
                    LabelFin.Location = New Point(10, 34)
                    LabelFin.AutoSize = True
                    LabelFin.Font = New Font(LabelFin.Font, FontStyle.Bold)
                    LabelFin.Visible = True
                    PanelHorario.Controls.Add(LabelFin)

                    LabelFin_Hora.Text = rows(Num).Item("Fin").ToString
                    LabelFin_Hora.Location = New Point(49, 34)
                    LabelFin_Hora.AutoSize = True
                    LabelFin_Hora.Font = New Font(LabelFin_Hora.Font, FontStyle.Bold)
                    LabelFin_Hora.Visible = True
                    PanelHorario.Controls.Add(LabelFin_Hora)

                    LabelDesc_Desc.Text = rows(Num).Item("Desc").ToString
                    LabelDesc_Desc.Location = New Point(10, 60)
                    LabelDesc_Desc.AutoSize = True
                    LabelDesc_Desc.Font = New Font(LabelDesc_Desc.Font, FontStyle.Bold)
                    LabelDesc_Desc.Visible = True
                    PanelHorario.Controls.Add(LabelDesc_Desc)

                    PanelHorario.Location = New Point(12 + (X * 125), 157 + (Y * 94))
                    PanelHorario.Size = New Size(119, 88)
                    PanelHorario.BorderStyle = BorderStyle.FixedSingle
                    PanelHorario.BackColor = Color.Gray
                    PanelHorario.Visible = True
                    Me.Controls.Add(PanelHorario)

                    PanelHorario.Name = "PanelHorario" & Num
                    LabelInicio.Name = "LabelInicio" & Num
                    LabelInicio_Hora.Name = "LabelInicio_Hora" & Num
                    LabelFin.Name = "LabelFin" & Num
                    LabelFin_Hora.Name = "LabelFin_Hora" & Num
                    LabelDesc_Desc.Name = "LabelDesc_Desc" & Num

                    Num += 1
                    Y += 1

                Next

                If Y > Max And rows.Count > Max Then

                    Me.Size = New Size(Me.Width, Me.Height + 40)
                    Max = rows.count

                End If

            Else

            End If
            i += 1
        End While

    End Sub


End Class