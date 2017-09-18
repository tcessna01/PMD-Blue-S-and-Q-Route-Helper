Public Class PMDmainForm

    Private ReadOnly dungeonsWhole() As String = {"Tiny Woods", "Thunderwave Cave", "Mt. Steel", "Sinister Woods", "Silent Chasm", "Mt. Thunder", "Mt. Thunder Peak", "Great Canyon", "Lapis Cave", "Mt. Blaze", "Mt. Blaze Peak", "Frosty Forest", "Frosty Grotto", "Mt. Freeze", "Mt. Freeze Peak", "Uproar Forest", "Magma Cavern", "Magma Cavern Pit", "Sky Tower", "Sky Tower Summit"} 'All Dungeons seeable in game first part of their name

    Private ReadOnly dungeonsPart1() As String = {"Tiny", "Thunderwave", "Mt", "Sinister", "Silent", "Mt", "Mt", "Great", "Lapis", "Mt", "Mt", "Frosty", "Frosty", "Mt", "Mt", "Uproar", "Magma", "Magma", "Sky", "Sky"} 'All Dungeons seeable in game first part of their name

    Private ReadOnly dungeonsPart2() As String = {"Woods", "Cave", "Steel", "Woods", "Chasm", "Thunder", "Thunder", "Canyon", "Cave", "Blaze", "Blaze", "Forest", "Grotto", "Freeze", "Freeze", "Forest", "Cavern", "Cavern", "Tower", "Tower"} 'All Dungeons seeable in game second part of their name

    Private ReadOnly dungeonsPart3() As String = {"", "", "", "", "", "", "Peak", "", "", "", "Peak", "", "", "", "Peak", "", "", "Pit", "", "Summit"} 'All Dungeons seeable in game third part of their name. Only Peaks or dungeons within dungeons need this extra part

    Private ReadOnly maxFloors() As Byte = {3, 5, 9, 12, 9, 10, 3, 12, 14, 12, 3, 9, 5, 15, 4, 9, 23, 1, 25, 9} 'Max floors per dungeon, runs parallel to dungeons()

    Private ReadOnly floors() As Byte = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25} 'All floors seeable in game  ;  The starting zero is a placeholder number so that maxFloors does not have to be -1 to every call (

    Private Const MAX_FLOOR As Byte = 25
    Private Const MIN_FLOOR As Byte = 1
    Private Const UNDERSCORE As Char = "_"
    Private Const CHARACTERF As Char = "F"

    Private dungeonIndexTracker = 0 'To keep track of what dungeon is next or previous - could not figure out a non global way to do this
    Private floorIndexTracker = 1   'To keep track of what floor is next or previous - could not figure out a non global way to do this

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadArrays()
        cboxDungeon.SelectedIndex = 0
        cboxhiddenDungeonSelected.SelectedIndex = 0
        cboxFloor.SelectedIndex = 0
        'lblDungeon.Text = dungeonsWhole(1)
        'lblFloor.Text = floors(1).ToString & "F"
    End Sub

    Private Sub loadArrays() 'sets both comboboxes with appropriate arrays for initial load. Only used once
        For index = 0 To dungeonsWhole.Length - 1
            cboxDungeon.Items.Add(dungeonsWhole(index))
            cboxhiddenDungeonSelected.Items.Add(dungeonsWhole(index))
        Next

        'For index = 1 To floors.Length - 1
        'cboxFloor.Items.Add(floors(index))
        'Next

        For index = MIN_FLOOR To 3
            cboxFloor.Items.Add(floors(index))
        Next

    End Sub

    Private Sub btnPreviousDungeon_Click(sender As Object, e As EventArgs) Handles btnPreviousDungeon.Click
        If cboxhiddenDungeonSelected.SelectedIndex > 0 Then
            cboxhiddenDungeonSelected.SelectedIndex = cboxhiddenDungeonSelected.SelectedIndex - 1
            lblDungeon.Text = dungeonsWhole(cboxhiddenDungeonSelected.SelectedIndex)
            setMaxFloors()
            resetFloorLabel()
            dungeonHasChanged()
            pictureHasChanged()
        End If
    End Sub

    Private Sub btnNextDungeon_Click(sender As Object, e As EventArgs) Handles btnNextDungeon.Click
        If cboxhiddenDungeonSelected.SelectedIndex < dungeonsWhole.Length - 1 Then
            cboxhiddenDungeonSelected.SelectedIndex = cboxhiddenDungeonSelected.SelectedIndex + 1
            lblDungeon.Text = dungeonsWhole(cboxhiddenDungeonSelected.SelectedIndex)
            setMaxFloors()
            resetFloorLabel()
            dungeonHasChanged()
            pictureHasChanged()
        End If
    End Sub

    Private Sub btnPreviousFloor_Click(sender As Object, e As EventArgs) Handles btnPreviousFloor.Click
        If floors(floorIndexTracker) > MIN_FLOOR Then
            floorIndexTracker = floorIndexTracker - MIN_FLOOR
            lblFloor.Text = floors(floorIndexTracker) & CHARACTERF
            pictureHasChanged()
        End If
    End Sub

    Private Sub btnNextFloor_Click(sender As Object, e As EventArgs) Handles btnNextFloor.Click
        If floors(floorIndexTracker) < maxFloors(cboxhiddenDungeonSelected.SelectedIndex) Then
            floorIndexTracker = floorIndexTracker + MIN_FLOOR
            lblFloor.Text = floors(floorIndexTracker) & CHARACTERF
            pictureHasChanged()
        End If
    End Sub

    Private Sub setMaxFloors()
        cboxFloor.Items.Clear()

        For index = MIN_FLOOR To maxFloors(cboxhiddenDungeonSelected.SelectedIndex)
            cboxFloor.Items.Add(floors(index))
        Next
    End Sub

    Private Sub resetFloorLabel()
        floorIndexTracker = MIN_FLOOR
        lblFloor.Text = floors(floorIndexTracker) & CHARACTERF
    End Sub

    Private Sub dungeonHasChanged()
        cboxDungeon.SelectedIndex = cboxhiddenDungeonSelected.SelectedIndex
        cboxFloor.SelectedIndex = 0
    End Sub

    Private Sub pictureHasChanged() 'Handles changing the picture after any update
        picBoxDungeon.Image = My.Resources.ResourceManager.GetObject((dungeonsPart1(cboxhiddenDungeonSelected.SelectedIndex) & UNDERSCORE & dungeonsPart2(cboxhiddenDungeonSelected.SelectedIndex) & UNDERSCORE & dungeonsPart3(cboxhiddenDungeonSelected.SelectedIndex) & UNDERSCORE & floors(floorIndexTracker) & CHARACTERF))
    End Sub

    Private Sub cboxDungeon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxDungeon.SelectedIndexChanged
        cboxhiddenDungeonSelected.SelectedIndex = cboxDungeon.SelectedIndex
        lblDungeon.Text = dungeonsWhole(cboxhiddenDungeonSelected.SelectedIndex)
        setMaxFloors()
        resetFloorLabel()
        dungeonHasChanged()
        pictureHasChanged()
    End Sub

    Private Sub cboxFloor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxFloor.SelectedIndexChanged
        floorIndexTracker = cboxFloor.SelectedIndex + MIN_FLOOR
        lblFloor.Text = floors(floorIndexTracker) & CHARACTERF
        'cboxFloor.SelectedIndex = 0
    End Sub
End Class
