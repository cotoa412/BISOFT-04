Public Class Reminder
    Dim db As New database
    Dim Fecha As DateTime
    Private Sub Reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        PanelRemider.Visible = True

        Dim Rows = db.ReaderQuery("Select a.NameActivity,c.NameCourse,a.[Priority]
                                   From Activity a,CourseUser cu, [User] us, Course c
                                    Where a.NameActivity='Hacer tarea'
                                    and a.DateHour in (Select a.DateHour
                                                      From Activity a, CourseUser cu, [User] u,Course c
                                                      Where cu.IdCourse=c.IdCourse 
                                                      and cu.IdUser=u.Id
                                                      And a.IdActivity = 2)
                                     and a.Course=cu.IdCourse
                                     and cu.IdUser=us.Id
                                     and c.IdCourse=cu.IdCourse")

        LabelShowReminder.Text = Rows(0).Item("NameActivity")
        LabelCourse.Text = Rows(0).Item("NameCourse")
        LabelPriority.Text = Rows(0).Item("Priority")

        LabelShowReminder.Visible = True
        LabelCourse.Visible = True
        LabelPriority.Visible = True




    End Sub

    Sub Label_Change()
        Dim day, week As Int16

    End Sub




End Class