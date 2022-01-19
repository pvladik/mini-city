Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input
Imports Microsoft.Xna.Framework.Graphics

''' <summary>
''' This is the main type for your game
''' </summary>
''' 
Public Class Game1
    Inherits Microsoft.Xna.Framework.Game



    Private WithEvents graphics As GraphicsDeviceManager
    Private WithEvents spriteBatch As SpriteBatch

    Public form1 As New Form1()

    Public img_grass01 As Texture2D
    Public img_house01 As Texture2D
    Public img_house02 As Texture2D
    Public img_house03 As Texture2D
    Public img_frame01 As Texture2D
    Public img_frame02 As Texture2D
    Public img_hospital As Texture2D
    Public img_water_tower As Texture2D
    Public img_road01 As Texture2D
    Public img_road02 As Texture2D
    Public img_road03 As Texture2D
    Public img_road04 As Texture2D
    Public img_road05 As Texture2D
    Public img_road06 As Texture2D
    Public img_road07 As Texture2D
    Public img_roadt1 As Texture2D
    Public img_roadt2 As Texture2D
    Public img_roadt3 As Texture2D
    Public img_roadt4 As Texture2D
    Public img_pipe01 As Texture2D
    Public img_pipe02 As Texture2D
    Public img_pipe03 As Texture2D
    Public img_pipe04 As Texture2D
    Public img_pipe05 As Texture2D
    Public img_pipe06 As Texture2D
    Public img_pipe07 As Texture2D
    Public img_pipe08 As Texture2D
    Public img_pipet1 As Texture2D
    Public img_pipet2 As Texture2D
    Public img_pipet3 As Texture2D
    Public img_pipet4 As Texture2D
    Public img_factory As Texture2D
    Public img_ground As Texture2D
    Public img_construction As Texture2D
    Public img_wind_turbine As Texture2D
    Public img_ground_under_water As Texture2D
    Public img_solar_powerplant As Texture2D
    Public ico_play As Texture2D
    Public ico_pause As Texture2D
    Public ico_button_house_on, ico_button_house_off As Texture2D
    Public ico_button_road_on, ico_button_road_off As Texture2D
    Public ico_button_hospital_on, ico_button_hospital_off As Texture2D
    Public ico_button_destroy_on, ico_button_destroy_off As Texture2D
    Public ico_button_underground_on, ico_button_underground_off As Texture2D
    Public ico_button_on_ground_on, ico_button_on_ground_off As Texture2D
    Public ico_button_pipe_on, ico_button_pipe_off As Texture2D
    Public ico_button_electrically_on, ico_button_electrically_off As Texture2D
    Public ico_button_solar_powerplant_on, ico_button_solar_powerplant_off As Texture2D
    Public ico_button_wind_turbine_on, ico_button_wind_turbine_off As Texture2D
    Public ico_button_water_tower_on, ico_button_water_tower_off As Texture2D
    Public ico_button_open, ico_button_save As Texture2D
    Public ico_button_factory_on, ico_button_factory_off As Texture2D


    'rectangle
    Dim pixel_texture As Texture2D

    'Font
    Public FontArial As SpriteFont
    Public fontArialsmall As SpriteFont


    'Integer, Byte
    Dim screen_width As Integer = 800
    Dim screen_height As Integer = 600
    Dim array_selected_item(12, 12) As Byte
    Dim rnd1, rnd2 As Integer
    Dim temp_integer, temp_integer2 As Double
    Dim x, y As Integer
    Dim map_size As Integer = 30
    Dim temp_x, temp_y As Integer
    Dim mouseX_absolut, mouseY_absolut, temp_mousex, temp_mousey, mouse_start_x, mouse_start_y, mouseX_gaming, mouseY_gaming As Integer
    Dim map_x, map_y As Integer
    Dim map_start_x, map_start_y As Integer
    Dim tick_selected As Integer = 0
    Dim select_tile As Point
    Dim first_tile As Point
    Dim rozdil_x, rozdil_y As Integer
    Dim scale As Double = 1.0
    Dim main_panel_width As Integer = 185
    Dim side_banner_width As Integer = 50
    Dim bottom_banner_height As Integer = 50
    Dim info_panel_width As Integer = 175
    Dim info_panel_height As Integer = 175
    Dim people As Integer
    Dim gaming_area_X, gaming_area_Y As Integer
    Dim money As Double = 50000
    Dim timertext As Double
    Dim elapsed_time As Double
    Dim timer_date As Double
    Dim elapsed_time_date As Double
    Dim price_house11 As Integer = 100
    Dim price_house12 As Integer = 150
    Dim price_house19 As Integer = 200
    Dim price_hospital As Integer = 350
    Dim price_solar_powerplant As Integer = 1000
    Dim price_wind_turbine As Integer = 1500
    Dim price_pipe As Integer = 50
    Dim price_road As Integer = 50
    Dim price_factory As Integer = 1000
    Dim price_water_tower As Integer = 500
    Dim pos_y_minus_money As Integer = 20
    Dim temp_price As Double
    Dim counter_multiple_tiles As Double
    Dim days_in_year(13) As Integer
    Dim population As Integer = 0


    'string
    Dim temp_day, temp_month As String
    Dim debug_string As String
    Dim print_infobox_name As String = ""
    Dim print_infobox_info As String = ""
    Dim print_infobox_price As String = ""
    Dim string_date As String = ""
    Dim solar_info1 As String = ""
    Dim solar_info2 As String = ""
    Dim wind_turbine_info1 As String = ""
    Dim wind_turbine_info2 As String = ""
    Dim road_info1 As String = ""
    Dim road_info2 As String = ""
    Dim hospital_info1 As String = ""
    Dim hospital_info2 As String = ""
    Dim water_tower_info1 As String = ""
    Dim water_tower_info2 As String = ""
    Dim factory_info1 As String = ""
    Dim factory_info2 As String = ""




    'Boolean
    Dim tick_frame01 As Boolean = True
    Dim draw_houses As Boolean = False
    Dim draw_solar_powerplants As Boolean = False
    Dim draw_electrically As Boolean = False
    Dim draw_watters As Boolean = False
    Dim draw_wind_turbine As Boolean = False
    Dim draw_hospital As Boolean = False
    Dim draw_road01 As Boolean = False
    Dim draw_roads As Boolean = False
    Dim draw_pipes As Boolean = False
    Dim draw_factory As Boolean = False
    Dim draw_water_tower As Boolean = False
    Dim direction_X As Boolean = False
    Dim direction_Y As Boolean = False
    Dim first_click_right As Boolean = False
    Dim first_click_left As Boolean = False
    Dim destroy_item As Boolean = False
    Dim in_underground As Boolean = False
    Dim select_line_tile As Boolean = False
    Dim select_area_tiles As Boolean = False
    Dim move_map As Boolean = False
    Dim Playing_game As Boolean = False
    Dim mouse_left_down As Boolean = False
    Dim mouse_right_down As Boolean = False
    Dim left_mouse_click As Boolean = False
    Dim left_mouse_up As Boolean = False
    Dim left_mouse_hold As Boolean = False
    Dim right_mouse_click As Boolean = False
    Dim right_mouse_up As Boolean = False
    Dim right_mouse_hold As Boolean = False
    Dim scrollwheelactive As Boolean = False
    Dim mouse_in_gaming_area As Boolean = False
    Dim show_minus_money_text As Boolean = False


    Dim old_mouse_state As MouseState
    Dim current_mouse_state As MouseState
    Dim key_state As KeyState

    Dim btn_underground As my_button
    Dim btn_on_ground As my_button
    Dim btn_solar_powerplant As my_button
    Dim btn_wind_turbine As my_button
    Dim btn_destroy As my_button
    Dim btn_electrically As my_button
    Dim btn_waters As my_button
    Dim btn_hospital As my_button
    Dim btn_house As my_button
    Dim btn_pipe As my_button
    Dim btn_road As my_button
    Dim btn_start As my_button
    Dim btn_water_tower As my_button
    Dim btn_open As my_button
    Dim btn_save As my_button
    Dim btn_factory As my_button

    Dim temp_rect As Rectangle
    Dim rectangle_banner As Rectangle
    Dim rectangle_main_panel As Rectangle
    Dim rectangle_bottom_panel As Rectangle
    Dim rectangle_info_panel As Rectangle


    Dim gaming_date As my_date_format

    'my structure tile
    Dim array_tiles_on_ground(12, 12) As Tile
    Dim array_tiles_underground(12, 12) As Tile

    Structure my_button
        Public x As Integer
        Public y As Integer
        Public width As Integer
        Public height As Integer
        Public pressed As Boolean
        Public image As Texture2D
    End Structure

    Structure Tile
        Public image As Integer
        Public road As Byte
        Public pipe As Byte
        Public is_water As Byte
        Public offset As Integer
        Public price As Single
        Public name As String
        Public info_text As String
        Public people As Integer
        Public people_max As Integer

    End Structure

    Structure my_date_format
        Public day As Integer
        Public month As Integer
        Public year As Integer
        'New
        Public Sub New(
          ByVal m_day As Integer, ByVal m_month As Integer, ByVal m_Year As Integer)
            day = m_day
            month = m_month
            year = m_Year
        End Sub 'New
    End Structure


    Public Sub New()
        graphics = New GraphicsDeviceManager(Me)
        Content.RootDirectory = "Content"
    End Sub

    Protected Overrides Sub Initialize()
        ' TODO: Add your initialization logic here

        '_______________________________________________________
        load_Settings()

        '________________________________________________________


        graphics.PreferredBackBufferWidth = screen_width
        graphics.PreferredBackBufferHeight = screen_height
        graphics.IsFullScreen = False
        graphics.ApplyChanges()
        MyBase.IsMouseVisible = True
        MyBase.Initialize()

    End Sub

    Protected Overrides Sub LoadContent()
        ' Create a new SpriteBatch, which can be used to draw textures.

        spriteBatch = New SpriteBatch(GraphicsDevice)



        'image load
        img_grass01 = Content.Load(Of Texture2D)("tiles\grass01")
        img_house01 = Content.Load(Of Texture2D)("tiles\house01")
        img_house02 = Content.Load(Of Texture2D)("tiles\house02")
        img_house03 = Content.Load(Of Texture2D)("tiles\house03")
        img_frame01 = Content.Load(Of Texture2D)("tiles\frame01")
        img_frame02 = Content.Load(Of Texture2D)("tiles\frame02")
        img_hospital = Content.Load(Of Texture2D)("tiles\hospital")
        img_water_tower = Content.Load(Of Texture2D)("tiles\watertower")
        img_road01 = Content.Load(Of Texture2D)("tiles\road01")
        img_road02 = Content.Load(Of Texture2D)("tiles\road02")
        img_road03 = Content.Load(Of Texture2D)("tiles\road03")
        img_road04 = Content.Load(Of Texture2D)("tiles\road04")
        img_road05 = Content.Load(Of Texture2D)("tiles\road05")
        img_road06 = Content.Load(Of Texture2D)("tiles\road06")
        img_road07 = Content.Load(Of Texture2D)("tiles\road07")
        img_roadt1 = Content.Load(Of Texture2D)("tiles\roadt1")
        img_roadt2 = Content.Load(Of Texture2D)("tiles\roadt2")
        img_roadt3 = Content.Load(Of Texture2D)("tiles\roadt3")
        img_roadt4 = Content.Load(Of Texture2D)("tiles\roadt4")
        img_pipe01 = Content.Load(Of Texture2D)("tiles\pipe01")
        img_pipe02 = Content.Load(Of Texture2D)("tiles\pipe02")
        img_pipe03 = Content.Load(Of Texture2D)("tiles\pipe03")
        img_pipe04 = Content.Load(Of Texture2D)("tiles\pipe04")
        img_pipe05 = Content.Load(Of Texture2D)("tiles\pipe05")
        img_pipe06 = Content.Load(Of Texture2D)("tiles\pipe06")
        img_pipe07 = Content.Load(Of Texture2D)("tiles\pipe07")
        img_pipe08 = Content.Load(Of Texture2D)("tiles\pipe08")
        img_pipet1 = Content.Load(Of Texture2D)("tiles\pipet1")
        img_pipet2 = Content.Load(Of Texture2D)("tiles\pipet2")
        img_pipet3 = Content.Load(Of Texture2D)("tiles\pipet3")
        img_pipet4 = Content.Load(Of Texture2D)("tiles\pipet4")
        img_ground = Content.Load(Of Texture2D)("tiles\ground01")
        img_factory = Content.Load(Of Texture2D)("tiles\factory")
        img_construction = Content.Load(Of Texture2D)("tiles\construction")
        img_ground_under_water = Content.Load(Of Texture2D)("tiles\groundunderwater")
        img_solar_powerplant = Content.Load(Of Texture2D)("tiles\solar_powerplant")
        img_wind_turbine = Content.Load(Of Texture2D)("tiles\wind_turbine")
        ico_pause = Content.Load(Of Texture2D)("tiles\ico_pause")
        ico_play = Content.Load(Of Texture2D)("tiles\ico_play")
        ico_button_house_on = Content.Load(Of Texture2D)("tiles\ico_button_house_on")
        ico_button_house_off = Content.Load(Of Texture2D)("tiles\ico_button_house_off")
        ico_button_road_on = Content.Load(Of Texture2D)("tiles\ico_button_road_on")
        ico_button_road_off = Content.Load(Of Texture2D)("tiles\ico_button_road_off")
        ico_button_hospital_off = Content.Load(Of Texture2D)("tiles\ico_button_hospital_off")
        ico_button_hospital_on = Content.Load(Of Texture2D)("tiles\ico_button_hospital_on")
        ico_button_destroy_off = Content.Load(Of Texture2D)("tiles\ico_button_destroy_off")
        ico_button_destroy_on = Content.Load(Of Texture2D)("tiles\ico_button_destroy_on")
        ico_button_underground_off = Content.Load(Of Texture2D)("tiles\ico_button_underground_off")
        ico_button_underground_on = Content.Load(Of Texture2D)("tiles\ico_button_underground_on")
        ico_button_on_ground_off = Content.Load(Of Texture2D)("tiles\ico_button_on_ground_off")
        ico_button_on_ground_on = Content.Load(Of Texture2D)("tiles\ico_button_on_ground_on")
        ico_button_pipe_off = Content.Load(Of Texture2D)("tiles\ico_button_pipe_off")
        ico_button_pipe_on = Content.Load(Of Texture2D)("tiles\ico_button_pipe_on")
        ico_button_electrically_off = Content.Load(Of Texture2D)("tiles\ico_button_electrically_off")
        ico_button_electrically_on = Content.Load(Of Texture2D)("tiles\ico_button_electrically_on")
        ico_button_solar_powerplant_on = Content.Load(Of Texture2D)("tiles\ico_button_solar_powerplant_on")
        ico_button_solar_powerplant_off = Content.Load(Of Texture2D)("tiles\ico_button_solar_powerplant_off")
        ico_button_wind_turbine_off = Content.Load(Of Texture2D)("tiles\ico_button_wind_turbine_off")
        ico_button_wind_turbine_on = Content.Load(Of Texture2D)("tiles\ico_button_wind_turbine_on")
        ico_button_water_tower_on = Content.Load(Of Texture2D)("tiles\ico_button_water_tower_on")
        ico_button_water_tower_off = Content.Load(Of Texture2D)("tiles\ico_button_water_tower_off")
        ico_button_open = Content.Load(Of Texture2D)("tiles\ico_button_open")
        ico_button_save = Content.Load(Of Texture2D)("tiles\ico_button_save")
        ico_button_factory_off = Content.Load(Of Texture2D)("tiles\ico_button_factory_off")
        ico_button_factory_on = Content.Load(Of Texture2D)("tiles\ico_button_factory_on")

        'rectangles
        rectangle_main_panel = New Rectangle(screen_width - main_panel_width, 0, main_panel_width, screen_height)
        rectangle_banner = New Rectangle(screen_width - main_panel_width - side_banner_width, 0, side_banner_width, screen_height)
        rectangle_bottom_panel = New Rectangle(0, screen_height - bottom_banner_height, screen_width - main_panel_width, bottom_banner_height)
        rectangle_info_panel = New Rectangle(screen_width - main_panel_width + 5, 250, info_panel_width, info_panel_height)



        gaming_area_X = screen_width - main_panel_width - side_banner_width
        gaming_area_Y = screen_height - bottom_banner_height

        pixel_texture = Content.Load(Of Texture2D)("tiles\panel_grey")

        'Font load
        FontArial = Content.Load(Of SpriteFont)("Font\Arial")
        fontArialsmall = Content.Load(Of SpriteFont)("Font\Arial_small")

        'date
        gaming_date = New my_date_format(25, 11, 1990)

        ' integer
        map_x = 256
        map_y = 256

        'Button on_ground
        btn_on_ground.x = screen_width - 45
        btn_on_ground.y = 30
        btn_on_ground.width = 40
        btn_on_ground.height = 40
        btn_on_ground.image = ico_button_on_ground_on
        btn_on_ground.pressed = True

        'Button underground
        btn_underground.x = screen_width - 45
        btn_underground.y = 75
        btn_underground.width = 40
        btn_underground.height = 40
        btn_underground.image = ico_button_underground_off
        btn_underground.pressed = False

        'Button powerplant
        btn_solar_powerplant.x = screen_width - main_panel_width - 45
        btn_solar_powerplant.y = 75
        btn_solar_powerplant.width = 40
        btn_solar_powerplant.height = 40
        btn_solar_powerplant.image = ico_button_solar_powerplant_off
        btn_solar_powerplant.pressed = False

        'Button wind turbine
        btn_wind_turbine.x = screen_width - main_panel_width - 45
        btn_wind_turbine.y = 120
        btn_wind_turbine.width = 40
        btn_wind_turbine.height = 40
        btn_wind_turbine.image = ico_button_wind_turbine_off
        btn_wind_turbine.pressed = False


        'Button start
        btn_start.x = screen_width - main_panel_width + 5
        btn_start.y = 30
        btn_start.width = 40
        btn_start.height = 40
        btn_start.pressed = False

        'Button house
        btn_house.x = screen_width - main_panel_width + 5
        btn_house.y = 120
        btn_house.width = 40
        btn_house.height = 40
        btn_house.pressed = False

        'Button road
        btn_road.x = screen_width - main_panel_width + 5
        btn_road.y = 75
        btn_road.width = 40
        btn_road.height = 40
        btn_road.pressed = False

        'Button hospital
        btn_hospital.x = screen_width - main_panel_width + 5
        btn_hospital.y = 165
        btn_hospital.width = 40
        btn_hospital.height = 40
        btn_hospital.pressed = False

        'Button destroy
        btn_destroy.x = screen_width - main_panel_width + 5 + 45
        btn_destroy.y = 30
        btn_destroy.width = 40
        btn_destroy.height = 40
        btn_destroy.pressed = False

        'Button pipes
        btn_pipe.x = screen_width - main_panel_width - 45
        btn_pipe.y = 75
        btn_pipe.width = 40
        btn_pipe.height = 40
        btn_pipe.image = ico_button_pipe_off
        btn_pipe.pressed = False

        'Button electrically
        btn_electrically.x = screen_width - main_panel_width + 5 + 90
        btn_electrically.y = 75
        btn_electrically.width = 40
        btn_electrically.height = 40
        btn_electrically.pressed = False

        'Button waters
        btn_waters.x = screen_width - main_panel_width + 5 + 45
        btn_waters.y = 75
        btn_waters.width = 40
        btn_waters.height = 40
        btn_waters.pressed = False

        'Button water tower
        btn_water_tower.x = screen_width - main_panel_width - 45
        btn_water_tower.y = 120
        btn_water_tower.width = 40
        btn_water_tower.height = 40
        btn_water_tower.image = ico_button_water_tower_off
        btn_water_tower.pressed = False

        'Button open
        btn_open.x = screen_width - main_panel_width + 5
        btn_open.y = screen_height - 50
        btn_open.width = 40
        btn_open.height = 40
        btn_open.image = ico_button_open
        btn_open.pressed = False

        'Button save
        btn_save.x = screen_width - main_panel_width + 50
        btn_save.y = screen_height - 50
        btn_save.width = 40
        btn_save.height = 40
        btn_save.image = ico_button_save
        btn_save.pressed = False

        'Button factory
        btn_factory.x = screen_width - main_panel_width + 5 + 45
        btn_factory.y = 120
        btn_factory.width = 40
        btn_factory.height = 40
        btn_factory.pressed = False


        ReDim array_selected_item(map_size + 3, map_size + 3)
        ReDim array_tiles_on_ground(map_size + 3, map_size + 3)
        ReDim array_tiles_underground(map_size + 3, map_size + 3)

        'array main tiles on ground
        For y = 1 To map_size + 3
            For x = 1 To map_size + 3
                temp_x = map_x + (x * 32) - (y * 32)
                temp_y = map_y + (y * 16) + (x * 16)
                array_tiles_on_ground(x, y).image = 10
                array_tiles_on_ground(x, y).road = 0
                array_tiles_on_ground(x, y).offset = 0
            Next
        Next

        'array main tiles underground
        For y = 1 To map_size + 3
            For x = 1 To map_size + 3
                temp_x = map_x + (x * 32) - (y * 32)
                temp_y = map_y + (y * 16) + (x * 16)

                array_tiles_underground(x, y).image = 16
                array_tiles_underground(x, y).road = 0
                array_tiles_underground(x, y).pipe = 0
                array_tiles_underground(x, y).offset = 0
            Next
        Next


        'Days in year, add to array
        days_in_year(0) = 0 'null
        days_in_year(1) = 31 'january
        days_in_year(2) = 28
        days_in_year(3) = 31
        days_in_year(4) = 30
        days_in_year(5) = 31
        days_in_year(6) = 30
        days_in_year(7) = 31
        days_in_year(8) = 31
        days_in_year(9) = 30
        days_in_year(10) = 31
        days_in_year(11) = 30
        days_in_year(12) = 31 'december


        ' TODO: use Me.Content to load your game content here
    End Sub

    Protected Overrides Sub Update(ByVal gameTime As GameTime)

        'keys check
        If Keyboard.GetState.IsKeyDown(Keys.Escape) Then
            reset_button()
            print_infobox_info = ""
            print_infobox_name = ""
            print_infobox_price = ""
        End If
        'debug window
        If Keyboard.GetState.IsKeyDown(Keys.F5) Then
            form1.Visible = True
        End If



        ' mouse check
        mouse_check()


        'check click on button
        Buttons()


        'GAME RUNNING
        If Playing_game = True Then
            'calculatin date
            calculate_date(gameTime.ElapsedGameTime.TotalMilliseconds)

            'Draw with one click              
            draw_one_click()

            ' left mouse button hold
            left_mouse_button_hold()

            'left mouse button up
            left_mouse_button_up()
        End If
        debug_string = ""



        ''TIMER
        If show_minus_money_text = True Then
            elapsed_time = gameTime.ElapsedGameTime.TotalMilliseconds
            timertext += elapsed_time
            pos_y_minus_money = pos_y_minus_money + 1
            If timertext > 450 Then
                timertext = 0
                show_minus_money_text = False
                pos_y_minus_money = 5
            End If
        End If




        '----------------------------------------------------------------------------------------
        '___________________________________________________________________________________________
        'right button mouse
        If right_mouse_hold = True Then
            If first_click_right = True Then
                first_click_right = False
                mouse_start_x = Mouse.GetState.X
                mouse_start_y = Mouse.GetState.Y
                map_start_x = map_x
                map_start_y = map_y

            End If
            rozdil_x = (mouse_start_x - mouseX_absolut)
            rozdil_y = (mouse_start_y - mouseY_absolut)
            map_x = (map_start_x - rozdil_x)
            map_y = (map_start_y - rozdil_y)
        Else
            first_click_right = True
        End If



        ' TODO: Add your update logic here
        MyBase.Update(gameTime)
    End Sub

    Private Function Get_image(ByVal i As Integer, ByVal x As Integer, ByVal y As Integer) As Texture2D
        Select Case i
            Case 10
                array_tiles_on_ground(x, y).offset = 0
                Return img_grass01
            Case 11
                array_tiles_on_ground(x, y).offset = 32
                Return img_house01
            Case 12
                array_tiles_on_ground(x, y).offset = 32
                Return img_house02
            Case 13
                array_tiles_on_ground(x, y).offset = 32
                Return img_solar_powerplant
            Case 14
                array_tiles_on_ground(x, y).offset = 32
                Return img_hospital
            Case 15
                array_tiles_on_ground(x, y).offset = 32
                Return img_water_tower
            Case 16
                array_tiles_on_ground(x, y).offset = 0
                Return img_ground
            Case 17
                array_tiles_on_ground(x, y).offset = 0
                Return img_ground_under_water
            Case 18
                array_tiles_on_ground(x, y).offset = 96
                Return img_wind_turbine
            Case 19
                array_tiles_on_ground(x, y).offset = 0
                Return img_house03
            Case 20
                array_tiles_on_ground(x, y).offset = 32
                Return img_construction
            Case 21
                array_tiles_on_ground(x, y).offset = 32
                Return img_factory
            Case 30
                array_tiles_on_ground(x, y).offset = 0
                Return img_road01
            Case 31
                array_tiles_on_ground(x, y).offset = 0
                Return img_road02
            Case 32
                array_tiles_on_ground(x, y).offset = 0
                Return img_road03
            Case 33
                array_tiles_on_ground(x, y).offset = 0
                Return img_road04
            Case 34
                array_tiles_on_ground(x, y).offset = 0
                Return img_road05
            Case 35
                array_tiles_on_ground(x, y).offset = 0
                Return img_road06
            Case 36
                array_tiles_on_ground(x, y).offset = 0
                Return img_road07
            Case 37
                array_tiles_on_ground(x, y).offset = 0
                Return img_roadt1
            Case 38
                array_tiles_on_ground(x, y).offset = 0
                Return img_roadt2
            Case 39
                array_tiles_on_ground(x, y).offset = 0
                Return img_roadt3
            Case 40
                array_tiles_on_ground(x, y).offset = 0
                Return img_roadt4
            Case 41
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipe01
            Case 42
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipe02
            Case 43
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipe03
            Case 44
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipe04
            Case 45
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipe05
            Case 46
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipe06
            Case 47
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipe07
            Case 48
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipe08
            Case 49
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipet1
            Case 50
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipet2
            Case 51
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipet3
            Case 52
                array_tiles_on_ground(x, y).offset = 0
                Return img_pipet4
            Case Else

                Return Nothing
        End Select

    End Function

    Private Sub calculate_date(ByVal elapsed_time As Double)

        timer_date += elapsed_time
        'every 1 second add 1 day
        If timer_date > 300 Then
            timer_date = 0

            gaming_date.day += 1

            'jump to next month
            If gaming_date.day > days_in_year(gaming_date.month) Then
                gaming_date.day = 1
                gaming_date.month += 1
            End If

            'jump to the next year
            If gaming_date.month > 12 Then
                gaming_date.month = 1
                gaming_date.year += 1
            End If
        End If

        'add 0 if number<10
        If gaming_date.day < 10 Then
            temp_day = "0"
        Else
            temp_day = ""
        End If
        If gaming_date.month < 10 Then
            temp_month = "0"
        Else
            temp_month = ""
        End If

        'complete string
        string_date = temp_day & gaming_date.day.ToString & "/" & temp_month & gaming_date.month.ToString & "/" & gaming_date.year.ToString
    End Sub

    Private Sub reset_tile(ByVal x As Integer, ByVal y As Integer)
        array_tiles_on_ground(x, y).image = 10
        array_tiles_on_ground(x, y).info_text = ""
        array_tiles_on_ground(x, y).is_water = 0
        array_tiles_on_ground(x, y).name = ""
        array_tiles_on_ground(x, y).offset = 0
        array_tiles_on_ground(x, y).pipe = 0
        array_tiles_on_ground(x, y).price = 0
        array_tiles_on_ground(x, y).road = 0
        array_tiles_on_ground(x, y).people = 0
        array_tiles_on_ground(x, y).people_max = 0

    End Sub

    Private Sub coordinates_mouse()
        'in px
        mouseX_gaming = map_x - CInt((Mouse.GetState.X - 32 * scale))
        mouseY_gaming = map_y - CInt((Mouse.GetState.Y - 16 * scale))

        '  in tiles
        select_tile.X = CInt(((mouseX_gaming / (64 * scale) + mouseY_gaming / (32 * scale)) * -1))
        select_tile.Y = CInt(((mouseY_gaming / (32 * scale) - mouseX_gaming / (64 * scale)) * -1))


    End Sub

    Protected Overrides Sub Draw(ByVal gameTime As GameTime)
        GraphicsDevice.Clear(Color.CornflowerBlue)

        spriteBatch.Begin()
        ' draw tiles
        For y = 1 To map_size + 2
            For x = 1 To map_size + 2
                temp_x = map_x + CInt(((x * 32) - (y * 32)) * scale)
                temp_y = map_y + CInt(((y * 16) + (x * 16)) * scale)

                If in_underground = False Then
                    temp_rect = New Rectangle(CInt(temp_x), CInt(temp_y - (array_tiles_on_ground(x, y).offset) * scale), CInt(64 * scale), CInt((32 + array_tiles_on_ground(x, y).offset) * scale))
                    spriteBatch.Draw(Get_image(array_tiles_on_ground(x, y).image, x, y), temp_rect, Color.White)
                Else
                    temp_rect = New Rectangle(CInt(temp_x), CInt(temp_y - (array_tiles_underground(x, y).offset) * scale), CInt(64 * scale), CInt((32 + array_tiles_underground(x, y).offset) * scale))
                    spriteBatch.Draw(Get_image(array_tiles_underground(x, y).image, x, y), temp_rect, Color.White)
                End If

                'show selected tiles
                If array_selected_item(x, y) = 1 Then
                    temp_rect = New Rectangle(temp_x, temp_y, CInt(64 * scale), CInt(32 * scale))

                    spriteBatch.Draw(img_frame01, temp_rect, Color.White)
                End If

            Next
        Next


        '-----------------------------------------------------------------------------
        'draw panel
        spriteBatch.Draw(pixel_texture, rectangle_main_panel, Color.White)

        '---------------------------------------------------------------------
        'draw side banner
        spriteBatch.Draw(pixel_texture, rectangle_banner, Color.Gray)

        'draw bottom banner
        spriteBatch.Draw(pixel_texture, rectangle_bottom_panel, Color.Gray)

        spriteBatch.Draw(pixel_texture, rectangle_info_panel, Color.LightGray)



        'main button

        temp_rect = New Rectangle(btn_start.x, btn_start.y, btn_start.width, btn_start.height)
        spriteBatch.Draw(btn_start.image, temp_rect, Color.White)
        temp_rect = New Rectangle(btn_hospital.x, btn_hospital.y, btn_hospital.width, btn_hospital.height)
        spriteBatch.Draw(btn_hospital.image, temp_rect, Color.White)
        temp_rect = New Rectangle(btn_electrically.x, btn_electrically.y, btn_electrically.width, btn_electrically.height)
        spriteBatch.Draw(btn_electrically.image, temp_rect, Color.White)
        temp_rect = New Rectangle(btn_waters.x, btn_waters.y, btn_waters.width, btn_waters.height)
        spriteBatch.Draw(btn_waters.image, temp_rect, Color.White)
        temp_rect = New Rectangle(btn_road.x, btn_road.y, btn_road.width, btn_road.height)
        spriteBatch.Draw(btn_road.image, temp_rect, Color.White)
        temp_rect = New Rectangle(btn_house.x, btn_house.y, btn_house.width, btn_house.height)
        spriteBatch.Draw(btn_house.image, temp_rect, Color.White)
        temp_rect = New Rectangle(btn_destroy.x, btn_destroy.y, btn_destroy.width, btn_destroy.height)
        spriteBatch.Draw(btn_destroy.image, temp_rect, Color.White)
        temp_rect = New Rectangle(btn_factory.x, btn_factory.y, btn_factory.width, btn_factory.height)
        spriteBatch.Draw(btn_factory.image, temp_rect, Color.White)

        'open / save button
        temp_rect = New Rectangle(btn_open.x, btn_open.y, btn_open.width, btn_open.height)
        spriteBatch.Draw(btn_open.image, temp_rect, Color.White)

        temp_rect = New Rectangle(btn_save.x, btn_save.y, btn_save.width, btn_save.height)
        spriteBatch.Draw(btn_save.image, temp_rect, Color.White)




        'in underground/ on ground
        temp_rect = New Rectangle(btn_on_ground.x, btn_on_ground.y, btn_on_ground.width, btn_on_ground.height)
        spriteBatch.Draw(btn_on_ground.image, temp_rect, Color.White)
        temp_rect = New Rectangle(btn_underground.x, btn_underground.y, btn_underground.width, btn_underground.height)
        spriteBatch.Draw(btn_underground.image, temp_rect, Color.White)

        'electrically
        If draw_electrically = True Then
            temp_rect = New Rectangle(btn_wind_turbine.x, btn_wind_turbine.y, btn_wind_turbine.width, btn_wind_turbine.height)
            spriteBatch.Draw(btn_wind_turbine.image, temp_rect, Color.White)

            temp_rect = New Rectangle(btn_solar_powerplant.x, btn_solar_powerplant.y, btn_solar_powerplant.width, btn_solar_powerplant.height)
            spriteBatch.Draw(btn_solar_powerplant.image, temp_rect, Color.White)
        End If

        'waters
        If draw_watters = True Then
            temp_rect = New Rectangle(btn_pipe.x, btn_pipe.y, btn_pipe.width, btn_pipe.height)
            spriteBatch.Draw(btn_pipe.image, temp_rect, Color.White)

            temp_rect = New Rectangle(btn_water_tower.x, btn_water_tower.y, btn_water_tower.width, btn_water_tower.height)
            spriteBatch.Draw(btn_water_tower.image, temp_rect, Color.White)
        End If


        'draw MONEY
        spriteBatch.DrawString(FontArial, "Money: " & money.ToString & " MM", New Vector2(30, screen_height - bottom_banner_height + 5), Color.White)
        'draw POPULATION
        spriteBatch.DrawString(FontArial, "Population: " & population.ToString, New Vector2(30, screen_height - bottom_banner_height + 25), Color.White)


        'draw timer
        ' spriteBatch.DrawString(FontArial, "timer:" & timertext.ToString, New Vector2(30, screen_height - bottom_banner_height + 25), Color.Black)

        'show minus money
        If show_minus_money_text = True Then
            spriteBatch.DrawString(FontArial, "- " & CInt(temp_price).ToString, New Vector2(80, screen_height - bottom_banner_height - pos_y_minus_money), Color.Red)
            spriteBatch.DrawString(FontArial, "- " & CInt(temp_price).ToString, New Vector2(mouse_start_x, mouse_start_y - pos_y_minus_money - 15), Color.Red)
        End If

        'DATE
        spriteBatch.DrawString(fontArialsmall, string_date, New Vector2(screen_width - main_panel_width - 80, screen_height - bottom_banner_height + 5), Color.Red)

        'draw infobox texts
        spriteBatch.DrawString(FontArial, print_infobox_name, New Vector2(screen_width - main_panel_width + 15, 260), Color.Black)
        spriteBatch.DrawString(fontArialsmall, print_infobox_info, New Vector2(screen_width - main_panel_width + 15, 285), Color.Black)
        spriteBatch.DrawString(FontArial, "Price: " & print_infobox_price & " MM", New Vector2(screen_width - main_panel_width + 15, 400), Color.Black)


        'prints debug
        print_debug()

        spriteBatch.End()

        ' TODO: Add your drawing code here
        MyBase.Draw(gameTime)
    End Sub

    Private Sub print_debug()
        For b = 0 To map_size
            For a = 0 To map_size
                debug_string += array_tiles_on_ground(a, b).image.ToString & ";"
            Next
            debug_string += vbCrLf
        Next

        debug_string += vbCrLf

        debug_string += "mousex_absolut:" & mouseX_absolut.ToString & ";" & mouseY_absolut.ToString + vbCrLf
        debug_string += "mousex_gaming:" & mouseX_gaming.ToString & ";" & mouseY_gaming.ToString + vbCrLf
        debug_string += "select tile:" & select_tile.X.ToString & ";" & select_tile.Y.ToString + vbCrLf
        debug_string += "first tile:" & first_tile.X.ToString & ";" & first_tile.Y.ToString + vbCrLf

        'debug_string += "Left Button;" & mouse_left_down.ToString + vbCrLf
        'debug_string += "right Button;" & mouse_right_down.ToString + vbCrLf

        'debug_string += "temp_mousex;" & temp_mousex.ToString & ";" & temp_mousey.ToString + vbCrLf
        'debug_string += "mouse_startx;" & mouse_start_x.ToString & ";" & mouse_start_y.ToString + vbCrLf
        'debug_string += "draw_road;" & draw_roads.ToString & vbCrLf
        'debug_string += "draw_houses;" & draw_houses.ToString & vbCrLf

        'debug_string += "temp_integer;" & temp_integer.ToString & vbCrLf
        'debug_string += "temp_integer2;" & temp_integer2.ToString & vbCrLf

        debug_string += "scale;" & scale.ToString & vbCrLf


        debug_string += "mouse in gaming;" & mouse_in_gaming_area.ToString & vbCrLf

        debug_string += "tempx;" & temp_x.ToString & vbCrLf
        debug_string += "map start x;" & map_start_x.ToString & vbCrLf
        debug_string += "mouse stasrt x;" & mouse_start_x.ToString & vbCrLf


        debug_string += "map_x;" & map_x.ToString & ";" & map_y.ToString + vbCrLf

        debug_string += "rozdil;" & rozdil_x.ToString & ";" & rozdil_y.ToString + vbCrLf
        debug_string += "hospital info;" & hospital_info1.ToString & ";" & hospital_info2.ToString + vbCrLf



        form1.tb_debug.Text = debug_string


        '  spriteBatch.DrawString(FontArial, debug_string.ToString, New Vector2(screen_width - 220, 180), Color.Black)

    End Sub

    'load mouse position
    Private Sub mouse_check()
        'Get  Mouse position
        mouseX_absolut = Mouse.GetState.X
        mouseY_absolut = Mouse.GetState.Y

        coordinates_mouse()

        old_mouse_state = current_mouse_state
        current_mouse_state = Mouse.GetState

        If mouseX_absolut < gaming_area_X And mouseX_absolut > 0 And mouseY_absolut < gaming_area_Y And mouseY_absolut > 0 Then
            mouse_in_gaming_area = True
        Else
            mouse_in_gaming_area = False
        End If

        'Left
        'nothing
        If old_mouse_state.LeftButton = ButtonState.Released And current_mouse_state.LeftButton = ButtonState.Released Then
            left_mouse_click = False
            left_mouse_up = False
            left_mouse_hold = False
        End If

        'click
        If old_mouse_state.LeftButton = ButtonState.Released And current_mouse_state.LeftButton = ButtonState.Pressed Then
            left_mouse_click = True
            left_mouse_up = False
            left_mouse_hold = False
        End If

        'hold
        If old_mouse_state.LeftButton = ButtonState.Pressed And current_mouse_state.LeftButton = ButtonState.Pressed Then
            left_mouse_click = False
            left_mouse_up = False
            left_mouse_hold = True
        End If

        'mouse up
        If old_mouse_state.LeftButton = ButtonState.Pressed And current_mouse_state.LeftButton = ButtonState.Released Then
            left_mouse_click = False
            left_mouse_up = True
            left_mouse_hold = False
        End If


        'RIGHT
        'nothing
        If old_mouse_state.RightButton = ButtonState.Released And current_mouse_state.RightButton = ButtonState.Released Then
            right_mouse_click = False
            right_mouse_up = False
            right_mouse_hold = False
        End If

        'click
        If old_mouse_state.RightButton = ButtonState.Released And current_mouse_state.RightButton = ButtonState.Pressed Then
            right_mouse_click = True
            right_mouse_up = False
            right_mouse_hold = False
        End If

        'hold
        If old_mouse_state.RightButton = ButtonState.Pressed And current_mouse_state.RightButton = ButtonState.Pressed Then
            right_mouse_click = False
            right_mouse_up = False
            right_mouse_hold = True
        End If

        'mouse up
        If old_mouse_state.RightButton = ButtonState.Pressed And current_mouse_state.RightButton = ButtonState.Released Then
            right_mouse_click = False
            right_mouse_up = True
            right_mouse_hold = False
        End If


        'wheel
        'SCALE
        If old_mouse_state.ScrollWheelValue > current_mouse_state.ScrollWheelValue Then
            scrollwheelactive = True
            If scale <= 0.5 Then
                scale = 0.5
            Else
                scale = scale - 0.5
            End If
        ElseIf old_mouse_state.ScrollWheelValue < current_mouse_state.ScrollWheelValue Then
            scrollwheelactive = True
            If scale >= 2 Then
                scale = 2
            Else
                scale = scale + 0.5
            End If
        Else
            scrollwheelactive = False

        End If
    End Sub

    Private Sub Buttons()

        'check pressed  button
        If left_mouse_click = True Then

            If mouseX_absolut > btn_destroy.x And mouseX_absolut < btn_destroy.x + btn_destroy.width And mouseY_absolut > btn_destroy.y And mouseY_absolut < btn_destroy.y + btn_destroy.height Then
                reset_button()
                btn_destroy.pressed = True
                select_area_tiles = True
                select_line_tile = False
            ElseIf mouseX_absolut > btn_electrically.x And mouseX_absolut < btn_electrically.x + btn_electrically.width And mouseY_absolut > btn_electrically.y And mouseY_absolut < btn_electrically.y + btn_electrically.height Then
                reset_button()
                btn_electrically.pressed = True
                select_area_tiles = False
                select_line_tile = False
                in_underground = False
                btn_underground.pressed = False
            ElseIf mouseX_absolut > btn_hospital.x And mouseX_absolut < btn_hospital.x + btn_hospital.width And mouseY_absolut > btn_hospital.y And mouseY_absolut < btn_hospital.y + btn_hospital.height Then
                reset_button()
                btn_hospital.pressed = True
                select_area_tiles = False
                select_line_tile = False
                in_underground = False
                btn_underground.pressed = False
                print_infobox_name = hospital_info1
                print_infobox_info = hospital_info2
                print_infobox_price = price_hospital.ToString
            ElseIf mouseX_absolut > btn_house.x And mouseX_absolut < btn_house.x + btn_house.width And mouseY_absolut > btn_house.y And mouseY_absolut < btn_house.y + btn_house.height Then
                reset_button()
                btn_house.pressed = True
                select_area_tiles = True
                select_line_tile = False
                in_underground = False
                btn_underground.pressed = False
            ElseIf mouseX_absolut > btn_waters.x And mouseX_absolut < btn_waters.x + btn_waters.width And mouseY_absolut > btn_waters.y And mouseY_absolut < btn_waters.y + btn_waters.height Then
                reset_button()
                draw_watters = True
                btn_waters.pressed = True
                select_area_tiles = False
                select_line_tile = True
            ElseIf mouseX_absolut > btn_road.x And mouseX_absolut < btn_road.x + btn_road.width And mouseY_absolut > btn_road.y And mouseY_absolut < btn_road.y + btn_road.height Then
                reset_button()
                btn_road.pressed = True
                select_area_tiles = False
                select_line_tile = True
                print_infobox_name = road_info1
                print_infobox_info = road_info2
                print_infobox_price = price_road.ToString
            ElseIf mouseX_absolut > btn_factory.x And mouseX_absolut < btn_factory.x + btn_factory.width And mouseY_absolut > btn_factory.y And mouseY_absolut < btn_factory.y + btn_factory.height Then
                reset_button()
                btn_factory.pressed = True
                select_area_tiles = False
                select_line_tile = True
                print_infobox_name = factory_info1
                print_infobox_info = factory_info2
                print_infobox_price = price_factory.ToString
            ElseIf mouseX_absolut > btn_start.x And mouseX_absolut < btn_start.x + btn_start.width And mouseY_absolut > btn_start.y And mouseY_absolut < btn_start.y + btn_start.height Then
                reset_button()
                If btn_start.pressed = True Then
                    btn_start.pressed = False
                Else
                    btn_start.pressed = True
                End If
            ElseIf mouseX_absolut > btn_open.x And mouseX_absolut < btn_open.x + btn_open.width And mouseY_absolut > btn_open.y And mouseY_absolut < btn_open.y + btn_open.height Then
                'OPEN FILE
                import_game()

            ElseIf mouseX_absolut > btn_save.x And mouseX_absolut < btn_save.x + btn_save.width And mouseY_absolut > btn_save.y And mouseY_absolut < btn_save.y + btn_save.height Then
                'SAVE GAME
                save_game()
            End If





            '_______________________________________________________________________________________
            '  button on ground / underground

            If mouseX_absolut > btn_on_ground.x And mouseX_absolut < btn_on_ground.x + btn_on_ground.width And mouseY_absolut > btn_on_ground.y And mouseY_absolut < btn_on_ground.y + btn_on_ground.height Then
                reset_button()
                btn_underground.pressed = False
                btn_on_ground.pressed = True
            End If

            If mouseX_absolut > btn_underground.x And mouseX_absolut < btn_underground.x + btn_underground.width And mouseY_absolut > btn_underground.y And mouseY_absolut < btn_underground.y + btn_underground.height Then
                reset_button()
                btn_underground.pressed = True
                btn_on_ground.pressed = False
            End If


            '__________________________________________________________________________________________
            'Electrically
            If draw_electrically = True Then
                'button wind turbine
                If mouseX_absolut > btn_wind_turbine.x And mouseX_absolut < btn_wind_turbine.x + btn_wind_turbine.width And mouseY_absolut > btn_wind_turbine.y And mouseY_absolut < btn_wind_turbine.y + btn_wind_turbine.height Then
                    reset_button()
                    btn_wind_turbine.pressed = True
                    btn_electrically.pressed = True
                    in_underground = False
                    btn_underground.pressed = False
                    print_infobox_name = wind_turbine_info1
                    print_infobox_info = wind_turbine_info2
                    print_infobox_price = price_wind_turbine.ToString

                End If

                'button solar powerlants
                If mouseX_absolut > btn_solar_powerplant.x And mouseX_absolut < btn_solar_powerplant.x + btn_solar_powerplant.width And mouseY_absolut > btn_solar_powerplant.y And mouseY_absolut < btn_solar_powerplant.y + btn_solar_powerplant.height Then
                    reset_button()
                    btn_solar_powerplant.pressed = True
                    btn_electrically.pressed = True
                    in_underground = False
                    btn_underground.pressed = False
                    print_infobox_name = solar_info1
                    print_infobox_info = solar_info2
                    print_infobox_price = price_solar_powerplant.ToString

                End If
            End If

            'waters
            If draw_watters = True Then
                'water tower
                If mouseX_absolut > btn_water_tower.x And mouseX_absolut < btn_water_tower.x + btn_water_tower.width And mouseY_absolut > btn_water_tower.y And mouseY_absolut < btn_water_tower.y + btn_water_tower.height Then
                    reset_button()
                    btn_water_tower.pressed = True
                    btn_waters.pressed = True
                    in_underground = False
                    btn_underground.pressed = False
                    print_infobox_name = water_tower_info1
                    print_infobox_info = water_tower_info2
                    print_infobox_price = price_water_tower.ToString

                End If

                'pipes
                If mouseX_absolut > btn_pipe.x And mouseX_absolut < btn_pipe.x + btn_pipe.width And mouseY_absolut > btn_pipe.y And mouseY_absolut < btn_pipe.y + btn_pipe.height Then
                    reset_button()
                    btn_pipe.pressed = True
                    btn_waters.pressed = True
                    in_underground = True
                    btn_underground.pressed = True

                End If
            End If

        End If

        '------------------------------------------------------------------------------------------------------------------
        'load image to buttons
        If btn_destroy.pressed = True Then
            destroy_item = True
            btn_destroy.image = ico_button_destroy_on
        Else
            destroy_item = False
            btn_destroy.image = ico_button_destroy_off
        End If

        If btn_electrically.pressed = True Then
            draw_electrically = True
            btn_electrically.image = ico_button_electrically_on
        Else
            draw_electrically = False
            btn_electrically.image = ico_button_electrically_off
        End If

        If btn_hospital.pressed = True Then
            draw_hospital = True
            btn_hospital.image = ico_button_hospital_on
        Else
            draw_hospital = False
            btn_hospital.image = ico_button_hospital_off
        End If

        If btn_house.pressed = True Then
            draw_houses = True
            btn_house.image = ico_button_house_on
        Else
            draw_houses = False
            btn_house.image = ico_button_house_off
        End If

        If btn_waters.pressed = True Then
            draw_watters = True
            btn_waters.image = ico_button_pipe_on
        Else
            draw_watters = False
            btn_waters.image = ico_button_pipe_off
        End If

        If btn_road.pressed = True Then
            draw_roads = True
            btn_road.image = ico_button_road_on
        Else
            draw_roads = False
            btn_road.image = ico_button_road_off
        End If

        If btn_pipe.pressed = True Then
            draw_pipes = True
            btn_pipe.image = ico_button_pipe_on
        Else
            draw_pipes = False
            btn_pipe.image = ico_button_pipe_off
        End If

        If btn_solar_powerplant.pressed = True Then
            draw_solar_powerplants = True
            btn_solar_powerplant.image = ico_button_solar_powerplant_on
        Else
            draw_solar_powerplants = False
            btn_solar_powerplant.image = ico_button_solar_powerplant_off
        End If

        If btn_water_tower.pressed = True Then
            draw_water_tower = True
            btn_water_tower.image = ico_button_water_tower_on
        Else
            draw_water_tower = False
            btn_water_tower.image = ico_button_water_tower_off
        End If

        If btn_wind_turbine.pressed = True Then
            draw_wind_turbine = True
            btn_wind_turbine.image = ico_button_wind_turbine_on
        Else
            draw_wind_turbine = False
            btn_wind_turbine.image = ico_button_wind_turbine_off
        End If

        If btn_factory.pressed = True Then
            draw_factory = True
            btn_factory.image = ico_button_factory_on
        Else
            draw_factory = False
            btn_factory.image = ico_button_factory_off
        End If


        If btn_start.pressed = True Then
            Playing_game = True
            btn_start.image = ico_play
        Else
            Playing_game = False
            btn_start.image = ico_pause
        End If


        'underground / on ground button
        If btn_underground.pressed = False Then
            btn_on_ground.image = ico_button_on_ground_on
            btn_underground.image = ico_button_underground_off
            in_underground = False
        Else
            btn_on_ground.image = ico_button_on_ground_off
            btn_underground.image = ico_button_underground_on
            in_underground = True
        End If

        ''Print Debug to form1
        If form1.Visible = True Then
            ' form1.tb_debug.Text = debug_string
        End If


    End Sub

    Private Sub draw_one_click()
        'Drawing tiles on click

        If left_mouse_click = True And mouse_in_gaming_area = True And select_tile.X > 0 And select_tile.X < map_size + 3 And select_tile.Y > 0 And select_tile.Y < map_size + 3 Then
            'houses
            mouse_start_x = Mouse.GetState.X
            mouse_start_y = Mouse.GetState.Y

            If draw_houses = True Then
                If array_tiles_on_ground(select_tile.X, select_tile.Y).image = 10 Then
                    rnd1 = CInt(2 * Rnd())

                    If rnd1 = 0 Then
                        array_tiles_on_ground(select_tile.X, select_tile.Y).image = 11
                        money = money - price_house11
                        show_minus_money_text = True
                        temp_price = price_house11
                        population += 8
                    ElseIf rnd1 = 1 Then
                        array_tiles_on_ground(select_tile.X, select_tile.Y).image = 12
                        money = money - price_house12
                        show_minus_money_text = True
                        temp_price = price_house12
                        population += 10
                    Else
                        array_tiles_on_ground(select_tile.X, select_tile.Y).image = 19
                        money = money - price_house19
                        show_minus_money_text = True
                        temp_price = price_house19
                        population += 12
                    End If
                End If

                'hospital
            ElseIf draw_hospital = True Then
                If array_tiles_on_ground(select_tile.X, select_tile.Y).image = 10 Then
                    reset_tile(select_tile.X, select_tile.Y)
                    array_tiles_on_ground(select_tile.X, select_tile.Y).image = 14
                    money = money - price_hospital
                    show_minus_money_text = True
                    temp_price = price_hospital
                End If

                'factory
            ElseIf draw_factory = True Then
                If array_tiles_on_ground(select_tile.X, select_tile.Y).image = 10 Then
                    reset_tile(select_tile.X, select_tile.Y)
                    array_tiles_on_ground(select_tile.X, select_tile.Y).image = 21
                    money = money - price_factory
                    show_minus_money_text = True
                    temp_price = price_factory
                End If


                'wind turbine
            ElseIf draw_wind_turbine = True Then
                If array_tiles_on_ground(select_tile.X, select_tile.Y).image = 10 Then
                    reset_tile(select_tile.X, select_tile.Y)
                    array_tiles_on_ground(select_tile.X, select_tile.Y).image = 18
                    money = money - price_wind_turbine
                    show_minus_money_text = True
                    temp_price = price_wind_turbine
                End If

                'solar powerplant
            ElseIf draw_solar_powerplants = True Then
                If array_tiles_on_ground(select_tile.X, select_tile.Y).image = 10 Then
                    reset_tile(select_tile.X, select_tile.Y)
                    array_tiles_on_ground(select_tile.X, select_tile.Y).image = 13
                    money = money - price_solar_powerplant
                    show_minus_money_text = True
                    temp_price = price_solar_powerplant
                End If

                'water tower
            ElseIf draw_water_tower = True Then
                If array_tiles_on_ground(select_tile.X, select_tile.Y).image = 10 Then
                    reset_tile(select_tile.X, select_tile.Y)
                    array_tiles_on_ground(select_tile.X, select_tile.Y).image = 15
                    array_tiles_underground(select_tile.X, select_tile.Y).pipe = 1
                    money = money - price_water_tower
                    show_minus_money_text = True
                    temp_price = price_water_tower
                End If


                'destroy
            ElseIf destroy_item = True Then
                If in_underground = False Then
                    reset_tile(select_tile.X, select_tile.Y)
                    array_tiles_on_ground(select_tile.X, select_tile.Y).image = 10
                    array_tiles_on_ground(select_tile.X, select_tile.Y).road = 0
                Else
                    reset_tile(select_tile.X, select_tile.Y)
                    array_tiles_underground(select_tile.X, select_tile.Y).image = 16
                    array_tiles_underground(select_tile.X, select_tile.Y).pipe = 0
                End If

            Else

            End If

        End If

    End Sub

    Private Sub left_mouse_button_hold()
        'left button mouse
        If left_mouse_hold = True And mouse_in_gaming_area = True Then
            'coordinates tiles from coordinates map px


            'detect button down
            If first_click_left = True Then
                first_click_left = False
                first_tile.X = select_tile.X
                first_tile.Y = select_tile.Y
            End If

            clear_array()

            'Select line tiles
            If select_line_tile = True Then
                If select_tile.X > first_tile.X Or select_tile.X < first_tile.X And select_tile.Y = first_tile.Y Then
                    temp_integer = CInt(select_tile.X - first_tile.X)
                    direction_X = True
                    direction_Y = False
                    For a = 0 To Math.Abs(CInt(temp_integer))
                        If temp_integer < 0 Then
                            array_selected_item(first_tile.X + (a * -1), first_tile.Y) = 1
                        Else
                            array_selected_item(first_tile.X + a, first_tile.Y) = 1
                        End If
                    Next
                ElseIf select_tile.Y > first_tile.Y Or select_tile.Y < first_tile.Y And select_tile.X = first_tile.X Then
                    temp_integer = CInt(select_tile.Y - first_tile.Y)
                    direction_Y = True
                    direction_X = False
                    For a = 0 To Math.Abs(CInt(temp_integer))
                        If temp_integer < 0 Then
                            array_selected_item(first_tile.X, first_tile.Y + (a * -1)) = 1
                        Else
                            array_selected_item(first_tile.X, first_tile.Y + a) = 1
                        End If
                    Next
                End If
            End If

            'select area tiles
            If select_area_tiles = True Then
                If (select_tile.X > 0 Or select_tile.X < map_size + 3) And (select_tile.Y > 0 And select_tile.Y < map_size + 3) Then
                    temp_integer = select_tile.X - first_tile.X
                    temp_integer2 = select_tile.Y - first_tile.Y

                    For y = 0 To Math.Abs(CInt(temp_integer2))
                        For x = 0 To Math.Abs(CInt(temp_integer))

                            If select_tile.X < first_tile.X And select_tile.Y < first_tile.Y Then
                                array_selected_item(first_tile.X + x * -1, first_tile.Y + y * -1) = 1
                            ElseIf select_tile.X > first_tile.X And select_tile.Y > first_tile.Y Then
                                array_selected_item(first_tile.X + x, first_tile.Y + y) = 1
                            ElseIf select_tile.X > first_tile.X And select_tile.Y = first_tile.Y Then
                                array_selected_item(first_tile.X + x, first_tile.Y + y) = 1
                            ElseIf select_tile.X < first_tile.X And select_tile.Y = first_tile.Y Then
                                array_selected_item(first_tile.X + x * -1, first_tile.Y + y) = 1
                            ElseIf select_tile.X = first_tile.X And select_tile.Y > first_tile.Y Then
                                array_selected_item(first_tile.X + x, first_tile.Y + y) = 1
                            ElseIf select_tile.X = first_tile.X And select_tile.Y < first_tile.Y Then
                                array_selected_item(first_tile.X + x, first_tile.Y + y * -1) = 1
                            End If
                        Next
                    Next

                End If

            End If
        End If

    End Sub

    Private Sub left_mouse_button_up()
        If left_mouse_up = True Then

            'mouse up
            first_click_left = True

            'generate  tiles 
            For y = 1 To map_size + 2
                For x = 1 To map_size + 2
                    'house
                    If draw_houses = True Then
                        If array_selected_item(x, y) = 1 Then
                            If array_tiles_on_ground(x, y).image = 10 Then
                                rnd1 = CInt(2 * Rnd())
                                If rnd1 = 0 Then
                                    array_tiles_on_ground(x, y).image = 11
                                    money = money - price_house11
                                    counter_multiple_tiles += price_house11
                                    population += 8
                                ElseIf rnd1 = 1 Then
                                    array_tiles_on_ground(x, y).image = 12
                                    money = money - price_house12
                                    counter_multiple_tiles += price_house12
                                    population += 10
                                Else
                                    array_tiles_on_ground(x, y).image = 19
                                    money = money - price_house19
                                    counter_multiple_tiles += price_house19
                                    population += 12
                                End If
                            End If
                            form1.Text += rnd1.ToString & ";"
                        End If
                    End If

                    'roads
                    If draw_roads = True Then
                        If array_selected_item(x, y) = 1 Then
                            'straight road
                            If array_tiles_on_ground(x, y).image = 10 And direction_X = True Then
                                array_tiles_on_ground(x, y).road = 1
                                array_tiles_on_ground(x, y).image = 31
                                money = money - price_road
                                counter_multiple_tiles += price_road
                            ElseIf array_tiles_on_ground(x, y).image = 10 And direction_Y = True Then
                                array_tiles_on_ground(x, y).image = 32
                                array_tiles_on_ground(x, y).road = 1
                                money = money - price_road
                                counter_multiple_tiles += price_road
                            End If
                        End If
                    End If

                    'destroy
                    If destroy_item = True Then
                        If array_selected_item(x, y) = 1 Then
                            array_tiles_on_ground(x, y).image = 10
                            array_tiles_on_ground(x, y).road = 0
                        End If
                    End If


                    'pipe
                    If draw_pipes = True Then
                        If array_selected_item(x, y) = 1 Then
                            'straight pipe
                            array_tiles_underground(x, y).pipe = 1
                            money = money - price_pipe
                            counter_multiple_tiles += price_pipe
                        End If
                    End If

                Next
            Next

            If counter_multiple_tiles > 0 Then
                temp_price = counter_multiple_tiles
                counter_multiple_tiles = 0
                show_minus_money_text = True
            End If





            check_roads()
            show_tiles_under_water()
            check_pipes()

            clear_array()

        End If

    End Sub

    Private Sub clear_array()
        'clear array
        For y = 1 To map_size + 2
            For x = 1 To map_size + 2
                array_selected_item(x, y) = 0
            Next
        Next
    End Sub

    'check roads
    Private Sub check_roads()
        For y = 1 To map_size + 2
            For x = 1 To map_size + 2
                'Try
                ' cross
                If array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x - 1, y).road = 1 And array_tiles_on_ground(x, y - 1).road = 1 And array_tiles_on_ground(x + 1, y).road = 1 And array_tiles_on_ground(x, y + 1).road = 1 Then
                    array_tiles_on_ground(x, y).image = 30
                    'corners
                ElseIf array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x + 1, y).road = 1 And array_tiles_on_ground(x - 1, y).road = 0 And array_tiles_on_ground(x, y + 1).road = 1 And array_tiles_on_ground(x, y - 1).road = 0 Then
                    array_tiles_on_ground(x, y).image = 35
                ElseIf array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x + 1, y).road = 0 And array_tiles_on_ground(x - 1, y).road = 1 And array_tiles_on_ground(x, y + 1).road = 0 And array_tiles_on_ground(x, y - 1).road = 1 Then
                    array_tiles_on_ground(x, y).image = 33
                ElseIf array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x + 1, y).road = 1 And array_tiles_on_ground(x - 1, y).road = 0 And array_tiles_on_ground(x, y + 1).road = 0 And array_tiles_on_ground(x, y - 1).road = 1 Then
                    array_tiles_on_ground(x, y).image = 36
                ElseIf array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x + 1, y).road = 0 And array_tiles_on_ground(x - 1, y).road = 1 And array_tiles_on_ground(x, y + 1).road = 1 And array_tiles_on_ground(x, y - 1).road = 0 Then
                    array_tiles_on_ground(x, y).image = 34
                    ' T section
                ElseIf array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x - 1, y).road = 1 And array_tiles_on_ground(x, y - 1).road = 1 And array_tiles_on_ground(x + 1, y).road = 1 And array_tiles_on_ground(x, y + 1).road = 0 Then
                    array_tiles_on_ground(x, y).image = 39
                ElseIf array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x - 1, y).road = 1 And array_tiles_on_ground(x, y - 1).road = 1 And array_tiles_on_ground(x + 1, y).road = 0 And array_tiles_on_ground(x, y + 1).road = 1 Then
                    array_tiles_on_ground(x, y).image = 40
                ElseIf array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x - 1, y).road = 1 And array_tiles_on_ground(x, y - 1).road = 0 And array_tiles_on_ground(x + 1, y).road = 1 And array_tiles_on_ground(x, y + 1).road = 1 Then
                    array_tiles_on_ground(x, y).image = 37
                ElseIf array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x - 1, y).road = 0 And array_tiles_on_ground(x, y - 1).road = 1 And array_tiles_on_ground(x + 1, y).road = 1 And array_tiles_on_ground(x, y + 1).road = 1 Then
                    array_tiles_on_ground(x, y).image = 38
                End If

                'straight road
                If array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x - 1, y).road = 1 And array_tiles_on_ground(x, y - 1).road = 0 And array_tiles_on_ground(x + 1, y).road = 1 And array_tiles_on_ground(x, y + 1).road = 0 Then
                    array_tiles_on_ground(x, y).image = 31
                ElseIf array_tiles_on_ground(x, y).road = 1 And array_tiles_on_ground(x - 1, y).road = 0 And array_tiles_on_ground(x, y - 1).road = 1 And array_tiles_on_ground(x + 1, y).road = 0 And array_tiles_on_ground(x, y + 1).road = 1 Then
                    array_tiles_on_ground(x, y).image = 32
                End If

            Next
        Next
    End Sub

    'check_pipes
    Private Sub check_pipes()
        For y = 1 To map_size + 2
            For x = 1 To map_size + 2
                Try
                    ' cross
                    If array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 1 And array_tiles_underground(x, y - 1).pipe = 1 And array_tiles_underground(x + 1, y).pipe = 1 And array_tiles_underground(x, y + 1).pipe = 1 Then
                        array_tiles_underground(x, y).image = 41
                    End If

                Catch ex As Exception

                End Try

                'corners
                Try
                    If array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x + 1, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 0 And array_tiles_underground(x, y + 1).pipe = 1 And array_tiles_underground(x, y - 1).pipe = 0 Then
                        array_tiles_underground(x, y).image = 45
                    ElseIf array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x + 1, y).pipe = 0 And array_tiles_underground(x - 1, y).pipe = 1 And array_tiles_underground(x, y + 1).pipe = 0 And array_tiles_underground(x, y - 1).pipe = 1 Then
                        array_tiles_underground(x, y).image = 48
                    ElseIf array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x + 1, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 0 And array_tiles_underground(x, y + 1).pipe = 0 And array_tiles_underground(x, y - 1).pipe = 1 Then
                        array_tiles_underground(x, y).image = 47
                    ElseIf array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x + 1, y).pipe = 0 And array_tiles_underground(x - 1, y).pipe = 1 And array_tiles_underground(x, y + 1).pipe = 1 And array_tiles_underground(x, y - 1).pipe = 0 Then
                        array_tiles_underground(x, y).image = 46
                    End If

                Catch ex As Exception

                End Try

                ' T section
                Try
                    If array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 1 And array_tiles_underground(x, y - 1).pipe = 1 And array_tiles_underground(x + 1, y).pipe = 1 And array_tiles_underground(x, y + 1).pipe = 0 Then
                        array_tiles_underground(x, y).image = 51
                    ElseIf array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 1 And array_tiles_underground(x, y - 1).pipe = 1 And array_tiles_underground(x + 1, y).pipe = 0 And array_tiles_underground(x, y + 1).pipe = 1 Then
                        array_tiles_underground(x, y).image = 52
                    ElseIf array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 1 And array_tiles_underground(x, y - 1).pipe = 0 And array_tiles_underground(x + 1, y).pipe = 1 And array_tiles_underground(x, y + 1).pipe = 1 Then
                        array_tiles_underground(x, y).image = 49
                    ElseIf array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 0 And array_tiles_underground(x, y - 1).pipe = 1 And array_tiles_underground(x + 1, y).pipe = 1 And array_tiles_underground(x, y + 1).pipe = 1 Then
                        array_tiles_underground(x, y).image = 50
                    End If

                Catch ex As Exception

                End Try

                ' Straigt pipe
                Try
                    If array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 1 And array_tiles_underground(x, y - 1).pipe = 0 And array_tiles_underground(x + 1, y).pipe = 1 And array_tiles_underground(x, y + 1).pipe = 0 Then
                        array_tiles_underground(x, y).image = 42
                    ElseIf array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 0 And array_tiles_underground(x, y - 1).pipe = 1 And array_tiles_underground(x + 1, y).pipe = 0 And array_tiles_underground(x, y + 1).pipe = 1 Then
                        array_tiles_underground(x, y).image = 43
                    End If

                Catch ex As Exception

                End Try

                ' end pipe 
                Try
                    If array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 1 And array_tiles_underground(x, y - 1).pipe = 0 And array_tiles_underground(x + 1, y).pipe = 0 And array_tiles_underground(x, y + 1).pipe = 0 Then
                        array_tiles_underground(x, y).image = 42
                    ElseIf array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 0 And array_tiles_underground(x, y - 1).pipe = 1 And array_tiles_underground(x + 1, y).pipe = 0 And array_tiles_underground(x, y + 1).pipe = 0 Then
                        array_tiles_underground(x, y).image = 43
                    ElseIf array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 0 And array_tiles_underground(x, y - 1).pipe = 0 And array_tiles_underground(x + 1, y).pipe = 1 And array_tiles_underground(x, y + 1).pipe = 0 Then
                        array_tiles_underground(x, y).image = 42
                    ElseIf array_tiles_underground(x, y).pipe = 1 And array_tiles_underground(x - 1, y).pipe = 0 And array_tiles_underground(x, y - 1).pipe = 0 And array_tiles_underground(x + 1, y).pipe = 0 And array_tiles_underground(x, y + 1).pipe = 1 Then
                        array_tiles_underground(x, y).image = 43
                    End If

                Catch ex As Exception

                End Try

            Next
        Next

        ' add water tower pipe
        For y = 1 To map_size + 2
            For x = 1 To map_size + 2
                If array_tiles_on_ground(x, y).image = 15 Then
                    array_tiles_underground(x, y).image = 44
                End If
            Next
        Next



        clear_array()
    End Sub

    'showtiles underwater
    Private Sub show_tiles_under_water()

        'reset tiles under water
        For y = 1 To map_size + 2
            For x = 1 To map_size + 2
                If array_tiles_underground(x, y).pipe = 0 Then
                    array_tiles_underground(x, y).image = 16
                End If
            Next
        Next

        'select under water tiles 
        For y = 1 To map_size + 2
            For x = 1 To map_size + 2
                If array_tiles_underground(x, y).pipe = 1 Then
                    Try
                        array_tiles_underground(x + 1, y + 1).image = 17
                        array_tiles_underground(x - 1, y - 1).image = 17
                        array_tiles_underground(x - 1, y + 1).image = 17
                        array_tiles_underground(x + 1, y - 1).image = 17
                        array_tiles_underground(x, y + 1).image = 17
                        array_tiles_underground(x - 1, y).image = 17
                        array_tiles_underground(x + 1, y).image = 17
                        array_tiles_underground(x, y - 1).image = 17
                    Catch

                    End Try
                End If
            Next
        Next
    End Sub

    'reset buttons
    Private Sub reset_button()
        btn_destroy.pressed = False
        btn_electrically.pressed = False
        btn_hospital.pressed = False
        btn_house.pressed = False
        btn_waters.pressed = False
        btn_road.pressed = False
        btn_factory.pressed = False

        btn_solar_powerplant.pressed = False
        btn_water_tower.pressed = False
        btn_wind_turbine.pressed = False
        btn_pipe.pressed = False


    End Sub

    Private Sub reset_electrically_button()
        'electrically reset
        btn_wind_turbine.image = ico_button_wind_turbine_off
        btn_wind_turbine.pressed = False

        btn_solar_powerplant.image = ico_button_solar_powerplant_off
        btn_solar_powerplant.pressed = False

    End Sub

    Private Sub reset_waters_button()
        'electrically reset
        btn_water_tower.image = ico_button_water_tower_off
        btn_water_tower.pressed = False

        btn_pipe.image = ico_button_pipe_off
        btn_pipe.pressed = False

    End Sub

    Private Sub update_tiles_atributes()
        For y = 1 To map_size + 2
            For x = 1 To map_size + 2


            Next
        Next


    End Sub

    Private Sub save_game()

        Dim path_map As New IO.StreamWriter("Content\save\main_map.txt", False)

        path_map.Write((map_size).ToString + vbCrLf)

        ' export tile
        For b = 0 To map_size + 2
            For a = 0 To map_size + 2
                path_map.Write(array_tiles_on_ground(a, b).image & ":" & array_tiles_on_ground(a, b).road & ":" & array_tiles_on_ground(a, b).pipe & ":" & array_tiles_on_ground(a, b).offset & ";")
            Next
            path_map.Write(vbCrLf)
        Next

        'export roads
        For b = 0 To map_size + 2
            For a = 0 To map_size + 2
                path_map.Write(array_tiles_on_ground(a, b).road & ":")
            Next
            path_map.Write(vbCrLf)
        Next
        path_map.Close()


        'nahraj ulozena data
        ' Dim soubor_data = "data.txt"
        ' Dim soubor3 As New IO.StreamWriter(soubor_data, False)
        'pozice

        'studna

        'voda


        ' soubor3.Close()

        MsgBox("Save completed")


    End Sub

    Private Sub import_game()
        Dim myStream As System.IO.StreamReader = New System.IO.StreamReader("Content\save\main_map.txt")
        Dim line As String
        Dim temp_array() As String
        Dim temp_array2(3) As String
        Dim line_y As Integer = 0
        Dim first_line As Boolean = True

        temp_array2(0) = ""
        temp_array2(1) = ""
        temp_array2(2) = ""
        temp_array2(3) = ""

        Do
            line = myStream.ReadLine()
            If line Is Nothing Then
                Exit Do
            End If

            'read first line and read size of map
            If first_line = True Then
                map_size = CInt(line)
                'reset array
                ReDim array_selected_item(map_size + 3, map_size + 3)
                ReDim array_tiles_on_ground(map_size + 3, map_size + 3)
                ReDim array_tiles_underground(map_size + 3, map_size + 3)
                For y = 0 To map_size + 3
                    For x = 0 To map_size + 3
                        array_tiles_on_ground(x, y).image = 10
                        array_tiles_underground(x, y).image = 12
                    Next
                Next

                first_line = False

                Continue Do
            End If

            temp_array = Split(line, ";")

            'tiles load
            If line_y < map_size + 3 Then
                For a = 0 To map_size + 2
                    temp_array2 = Split(temp_array(a), ":")

                    array_tiles_on_ground(a, line_y).image = CInt(temp_array2(0))
                    array_tiles_on_ground(a, line_y).road = CByte(temp_array2(1))
                    array_tiles_on_ground(a, line_y).pipe = CByte(temp_array2(2))
                    array_tiles_on_ground(a, line_y).offset = CInt(temp_array2(3))

                Next
                line_y += 1
                Continue Do
            End If

        Loop

        myStream.Close()


    End Sub

    Private Sub load_Settings()
        Dim myStream As System.IO.StreamReader = New System.IO.StreamReader("Content\settings.txt")
        Dim line As String
        Dim temp_array(1) As String
        Dim line_y As Integer = 0

        temp_array(0) = ""
        temp_array(1) = ""

        Do
            line = myStream.ReadLine()
            If line Is Nothing Then
                Exit Do
            End If

            temp_array = Split(line, ":")

            Select Case line_y
                Case 0
                    map_size = CInt(temp_array(1))
                Case 1
                    screen_width = CInt(temp_array(1))
                Case 2
                    screen_height = CInt(temp_array(1))
            End Select

            line_y += 1
        Loop

        'load texts
        myStream = New System.IO.StreamReader("Content\texts.txt")
        line_y = 0
        Do
            line = myStream.ReadLine()
            If line Is Nothing Then
                Exit Do
            End If

            temp_array = Split(line, ":")


            Select Case line_y
                Case 0
                    solar_info1 = temp_array(1)
                Case 1
                    solar_info2 = temp_array(1)
                Case 2
                    wind_turbine_info1 = temp_array(1)
                Case 3
                    wind_turbine_info2 = temp_array(1)
                Case 4
                    hospital_info1 = temp_array(1)
                Case 5
                    hospital_info2 = temp_array(1)
                Case 6
                    road_info1 = temp_array(1)
                Case 7
                    road_info2 = temp_array(1)
                Case 8
                    water_tower_info1 = temp_array(1)
                Case 9
                    water_tower_info2 = temp_array(1)
                Case 10
                    factory_info1 = temp_array(1)
                Case 11
                    factory_info2 = temp_array(1)

            End Select
            line_y += 1
        Loop

    End Sub
End Class
