using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;

namespace Классы_к_системе_полётов
{
    [Serializable]
    public abstract class Airport 
    {
        public string Name; //название аэропорта
        public Point Location; //координаты аэропорта
        public Color tabloColor; //цвет табло
        public string Type; //тип аэропорта
        public byte capacity; //вместимость самолётов
        public int Arrival; //число прилётов
        public int Departure; //число вылетов
        public static Color colorCity = Color.Yellow; //цвет подписи для всех
        public static sbyte fontSize = 6; //размер шрифта для всех 
        public Rectangle region; //область попадания по аэропорту
        public Airport(string type)
        {
            Type = type;
            tabloColor = Color.Red;
        }
        public abstract void DrawAirport(Graphics g); //метод рисования аэропорта, переопредел-ся в произв-ых классах
    } //абстрактный класс всех аэропортов

    [Serializable]
    public class PassengerAirport : Airport
    {
        public PassengerAirport(string name, Point location,byte cap):base("Пассажирский") //конструктор класса
        {
            Name = name;
            Location = location;
            capacity = cap;
            region = new Rectangle(location.X-15,location.Y-18, 30, 24);
        }
        public override void DrawAirport(Graphics g) //рисование аэропорта
        {
            Pen p = new Pen(Color.Black, 3);
            Pen pen = new Pen(Color.Black, 2);
            g.DrawRectangle(p, Location.X - 15, Location.Y - 3, 30, 6); //основное здание
            g.FillRectangle(new SolidBrush(Color.CornflowerBlue), Location.X - 14.7f, Location.Y - 2.7f, 29.7f, 5.7f); //заливка здания
            g.DrawLine(new Pen(Color.MediumBlue, 3), Location.X - 12, Location.Y, Location.X - 8, Location.Y); //окна
            g.DrawLine(new Pen(Color.MediumBlue, 3), Location.X - 6, Location.Y, Location.X - 2, Location.Y);
            g.DrawLine(new Pen(Color.MediumBlue, 3), Location.X, Location.Y, Location.X + 4, Location.Y);
            g.DrawLine(p, Location.X + 10, Location.Y + 3, Location.X + 10, Location.Y - 3); //дверь
            g.DrawLine(pen, Location.X - 19, Location.Y + 6, Location.X + 20, Location.Y + 6); //фундамент аэропорта
            Rectangle tablo = new Rectangle(Location.X + 2, Location.Y - 7, 10, 3); //табло с индикатором
            g.FillRectangle(new SolidBrush(tabloColor), tablo); //заливка табло
            Rectangle tower = new Rectangle(Location.X - 11, Location.Y - 11, 4, 6); //башня
            g.DrawRectangle(p, tower);
            g.FillRectangle(new SolidBrush(Color.White), tower.X + 0.3f, tower.Y + 0.3f, tower.Width - 0.3f, tower.Height - 0.3f); //заливка башни
            g.DrawLine(pen, tower.X, tower.Y + 3, tower.X + tower.Width, tower.Y + 3);

            Point[] antena = new Point[4]; //антенна
            antena[0] = new Point(tower.X, tower.Y - 1);
            antena[1] = new Point(tower.X - 3, tower.Y - 5);
            antena[2] = new Point(tower.X + tower.Width + 3, tower.Y - 5);
            antena[3] = new Point(tower.X + tower.Width, tower.Y - 1);

            g.DrawPolygon(pen, antena); //антенна
            g.FillPolygon(new SolidBrush(Color.White), antena); //заливка антенны
            g.DrawLine(pen, tower.X + 1.5f, tower.Y - 5, tower.X + 1.5f, tower.Y - 10); //антенна торчащая
            g.DrawString(Name, new Font("Microsoft Sans Serif", fontSize), new SolidBrush(colorCity), new Point(Location.X + 22, Location.Y - 6)); //надпись города
        }
    } //пассажирский аэропорт

    [Serializable]
    public class CargoAirport : Airport
    {
        public CargoAirport(string name, Point location,byte cap) : base("Грузовой") //конструктор класса
        {
            Name = name;
            Location = location;
            capacity = cap;
            region = new Rectangle(location.X - 15, location.Y - 20, 30, 26);
        }
        public override void DrawAirport(Graphics g) //рисование аэропорта
        {
            Pen p = new Pen(Color.Black, 3);
            Pen pen = new Pen(Color.Black, 2);

            g.DrawRectangle(p, Location.X - 15, Location.Y - 4, 30, 8); //основное здание
            g.FillRectangle(new SolidBrush(Color.SandyBrown), Location.X - 14.7f, Location.Y - 3.7f, 29.7f, 7.7f); //заливка здания
            g.DrawLine(new Pen(Color.Black, 2), Location.X - 19, Location.Y + 6, Location.X + 20, Location.Y + 6); //фундамент аэропорта
            g.DrawLine(new Pen(Color.MediumBlue, 2), Location.X - 11, Location.Y - 2.7f, Location.X - 11, Location.Y + 3); //окна
            g.DrawLine(new Pen(Color.MediumBlue, 2), Location.X - 7, Location.Y - 2.7f, Location.X - 7, Location.Y + 3);
            g.DrawLine(new Pen(Color.MediumBlue, 2), Location.X - 3, Location.Y - 2.7f, Location.X - 3, Location.Y + 3);
            g.DrawLine(new Pen(Color.SaddleBrown, 6), Location.X + 10, Location.Y - 2, Location.X + 10, Location.Y + 4); //ворота
            g.DrawLine(p, Location.X + 3, Location.Y, Location.X + 3, Location.Y + 4); //дверь

            Point[] pt = new Point[6]; //крыша
            pt[0] = new Point(Location.X - 18, Location.Y - 4);
            pt[1] = new Point(Location.X - 18, Location.Y - 6);
            pt[2] = new Point(Location.X - 10, Location.Y - 9);
            pt[3] = new Point(Location.X + 10, Location.Y - 9);
            pt[4] = new Point(Location.X + 18, Location.Y - 6);
            pt[5] = new Point(Location.X + 18, Location.Y - 4);

            g.DrawPolygon(pen, pt); //рисование 
            g.FillPolygon(new SolidBrush(Color.Brown), pt);   //и заливка крыши
            Rectangle tower = new Rectangle(Location.X - 7, Location.Y - 15, 3, 5); //башня
            g.DrawRectangle(pen, tower);
            g.FillRectangle(new SolidBrush(Color.White), tower); //заливка башни
            Rectangle tablo = new Rectangle(Location.X, Location.Y - 13, 8, 3); //табло с индикатором
            g.FillRectangle(new SolidBrush(tabloColor), tablo); //заливка табло

            Point[] antena = new Point[4]; //антенна
            antena[0] = new Point(tower.X - 1, tower.Y);
            antena[1] = new Point(tower.X - 4, tower.Y - 4);
            antena[2] = new Point(tower.X + tower.Width + 3, tower.Y - 4);
            antena[3] = new Point(tower.X + tower.Width, tower.Y);

            g.DrawPolygon(pen, antena); //рисование антенны
            g.FillPolygon(new SolidBrush(Color.White), antena); //заливка антенны
            g.DrawLine(pen, tower.X + 1, tower.Y - 4, tower.X + 1, tower.Y - 8); //торчащая антенна
            g.DrawString(Name, new Font("Microsoft Sans Serif", fontSize), new SolidBrush(colorCity), new Point(Location.X + 22, Location.Y - 4)); //надпись города
        }
    } //грузовой аэропорт

    [Serializable]
    public class MilitaryAirport : Airport
    {
        public MilitaryAirport(string name, Point location,byte cap):base("Военный") //конструктор класса 
        {
            Name = name;
            Location = location;
            capacity = cap;
            region = new Rectangle(location.X - 20, location.Y - 25, 45, 25);
        }
        public override void DrawAirport(Graphics g) //рисование военного аэропорта
        {
            Pen p = new Pen(Color.Black, 2);
            Rectangle tower = new Rectangle(Location.X + 2, Location.Y - 20, 3, 20); //башня

            Point[] antena = new Point[4]; //антенна
            antena[0] = new Point(tower.X - 1, tower.Y - 1);
            antena[1] = new Point(tower.X - 4, tower.Y - 5);
            antena[2] = new Point(tower.X + tower.Width + 3, tower.Y - 5);
            antena[3] = new Point(tower.X + tower.Width, tower.Y - 1);

            g.DrawLine(p, Location.X - 25, Location.Y + 2, Location.X + 30, Location.Y + 2); //фундамент
            g.DrawRectangle(p, tower); //рисование башни
            g.DrawPolygon(p, antena); //рисование антенны
            g.FillRectangle(new SolidBrush(Color.White), tower);
            g.FillPolygon(new SolidBrush(Color.White), antena);
            g.DrawLine(p, tower.X + 1, tower.Y - 6, tower.X + 1, tower.Y - 9); //торчащая антенна

            DrawBaza(g, Location); //1 база
            DrawBaza(g, new Point(Location.X + 25, Location.Y)); //2 база
            g.DrawString(Name, new Font("Microsoft Sans Serif", fontSize), new SolidBrush(colorCity), new Point(Location.X + 30, Location.Y - 8)); //надпись города
        }
        private void DrawBaza(Graphics g, Point Location) //рисование базы
        {
            Point[] baza = new Point[5]; //основа базы
            baza[0] = new Point(Location.X - 20, Location.Y);
            baza[1] = new Point(Location.X - 20, Location.Y - 8);
            baza[2] = new Point(Location.X - 10, Location.Y - 14);
            baza[3] = new Point(Location.X, Location.Y - 8);
            baza[4] = new Point(Location.X, Location.Y);

            g.DrawPolygon(new Pen(Color.Black, 4), baza); //рисование основы
            g.FillPolygon(new SolidBrush(Color.ForestGreen), baza); //раскраска основы базы
            g.DrawLine(new Pen(Color.MediumBlue, 4), Location.X - 16, Location.Y - 7, Location.X - 16, Location.Y - 3.3f); //окна
            g.DrawLine(new Pen(Color.MediumBlue, 4), Location.X - 4, Location.Y - 7, Location.X - 4, Location.Y - 3.3f);
            g.DrawLine(new Pen(Color.Black, 4), Location.X - 10, Location.Y - 4, Location.X - 10, Location.Y); //дверь
            g.DrawLine(new Pen(Color.Black, 2), Location.X - 10, Location.Y - 14, Location.X - 10, Location.Y - 16);
            Rectangle flag = new Rectangle(Location.X - 10, Location.Y - 20, 5, 3); //флаг
            g.DrawRectangle(new Pen(Color.Black, 2), flag);
            g.FillRectangle(new SolidBrush(tabloColor), flag); //заливка флага цветом индикатора

        }
    } //военный аэропорт
    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    public class Airplane
    {
        public string Type; //тип самолёта
        public Image img; //картинка самолёта
        public string CityArrival; //город прилёта
        public string CityDeparture; //город вылета
        public DateTime DateArrival; //дата прилёта
        public DateTime DateDeparture; //дата вылета
        public PointF location; //координаты самолёта
        public PointF A; //точка отлёта
        public PointF B; //точка прилёта
        public Graphics g; //объект графики
        public ushort speed; //скорость самолёта
        public ushort capacity; //вместимость самолёта
        public string status; //статус самолёта

        protected Airplane(string type,Image image)
        {
            Type = type;
            img = image;
            img = ResizeImage(img, 34, 34); //размер картинки
            status = "Готов к вылету";
        } //конструктор с аргументами
        protected Airplane()
        {

        } //пустой конструктор без аргументов

        public void AirFly()
        {
            //коэф-ты траектории 
            float k = (B.Y - A.Y) / (B.X - A.X);
            float b = (A.Y - k * A.X);

            location = A; //нач.положение самолёта
            double angle = Math.Atan(k) * (180 / Math.PI); //расчёт угла поворота самолёта
            float step = Math.Abs(B.X - A.X) / (1300 - speed); //шаг от скорости
            int flag = B.X < A.X ? -1 : 1; //меняет направление полёта и поворота(влево/вправо)
            img = RotateImage(g, img, (int)(flag * 90 + angle)); //+-90 т.к нач.угол у картинки 90

            for (int i = 0; i < (1300 - speed); i++)
            {
                location.Y = (k * location.X + b); //координаты Y с учётом размеров картинки
                location.X += flag * step;
                Thread.Sleep(100); //таймер 
            }
        } //метод полёта самолёта из точки A в точку B под углом
        public void VisibleS(Graphics g, Color color)
        {
            Pen pen = new Pen(color, 2);
            pen.DashStyle = DashStyle.Dash; //пунктирная линия
            g.DrawLine(pen, A, B);
        } //отображение траектории самолёта
        public void DrawAir(Graphics f)
        {
            f.DrawImage(img, new PointF(location.X - img.Width / 2, location.Y - img.Height / 2));
        } //рисование с смещением из-за картинки
        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        } //изменение размеров картинки
        private static Bitmap RotateImage(Graphics g, Image img, int angle)
        {
            Bitmap bit = new Bitmap(img.Width, img.Height);
            Graphics f = Graphics.FromImage(bit);

            f.TranslateTransform(bit.Width / 2, bit.Height / 2);
            f.RotateTransform(angle);
            f.TranslateTransform(-bit.Width / 2, -bit.Height / 2);
            f.InterpolationMode = InterpolationMode.HighQualityBicubic;
            f.DrawImage(img, 0, 0);
            g.TranslateTransform(img.Width / 2, img.Height / 2);
            g.DrawImage(bit, -bit.Width / 2, -bit.Height / 2);

            return bit;
        } //поворот картинки на угол
    } //базовый класс для всех видов самолётов
    public class PassengerAirplane : Airplane 
    {
        public static Color visibleColor; //цвет траектории
        public ushort Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < 400 || value > 800)
                {
                    speed = (ushort)new Random().Next(400, 800);
                }
                else speed = value;
            }
        } //свойство скорости
        public ushort Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value < 200 || value > 1400)
                {
                    capacity = (ushort)new Random().Next(200, 1400);
                }
                else capacity = value;
            }
        } //свойство вместимости
        public static bool visible; //видимость траектории полёта
        public PassengerAirplane()
        {

        } //пустой конструктор
        public PassengerAirplane(Image imgs):base("Пассажирский", imgs)
        {
            visibleColor = Color.Blue;
        }
    } //пассажирский самолёт
    public class CargoAirplane : Airplane
    {
        public static Color visibleColor; //цвет траектории
        public ushort Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < 300 || value > 950)
                {
                    speed = (ushort)new Random().Next(300, 950);
                }
                else speed = value;
            }
        } //свойство доступа к скорости
        public ushort Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value < 20 || value > 350)
                {
                    capacity = (ushort)new Random().Next(20, 350);
                }
                else capacity = value;
            }
        } //свойство доступа к вместимости
        public static bool visible; //видимость траектории полёта
        public CargoAirplane()
        {

        } //пустой конструктор
        public CargoAirplane(Image imgs) : base("Грузовой", imgs)
        {
            visibleColor = Color.Brown;
        }
    } //грузовой самолёт
    public class MilitaryAirplane : Airplane
    {
        public static Color visibleColor; //цвет траектории
        public ushort Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < 800 || value > 1100)
                {
                    speed = (ushort)new Random().Next(800, 1100);
                }
                else speed = value;
            }
        } //свойство доступа к скорости
        public ushort Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value < 30 || value > 300)
                {
                    capacity = (ushort)new Random().Next(30, 300);
                }
                else capacity = value;
            }
        } //свойство доступа к вместимости
        public static bool visible; //видимость траектории полёта
        public MilitaryAirplane()
        {

        } //пустой конструктор
        public MilitaryAirplane(Image imgs) : base("Военный", imgs)
        {
            visibleColor = Color.Green;
        }
    } //военный самолёт
    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    public class Raise
    {     
        public List<Airport>  airports = new List<Airport>(); //коллекция аэропортов
        public List<Airplane> airplanes = new List<Airplane>(); //коллекция самолётов
        public List<Airplane> resultAirplane = new List<Airplane>(); //список всех отлетавших самолётов

        #region Самолёты
        public void DrawAirplane(Graphics g)
        {
            for (int a = 0; a < airplanes.Count; a++)
            {
                if (airplanes[a].location != new PointF(0, 0))
                {
                    airplanes[a].DrawAir(g);
                    DrawVisible(g, airplanes[a]);
                }         
            }
        } //рисование всех самолётов
        public void FlyAirplanes()
        {
            for (int i = 0; i < airplanes.Count; i++)
            {
                if (airplanes[i].location == new PointF(0, 0)) //если рейс новый (координаты нулевые)
                {
                    FlyAsync(airplanes[i]);
                }
                else continue;
            } //запуск пассажирских рейсов
        } //запуск всех рейсов
        public void FindAirplane(Point point)
        {
            for (int i = 0; i < airplanes.Count; i++)
            {
                if (new Rectangle((int)airplanes[i].location.X, (int)airplanes[i].location.Y, 34, 34).Contains(point))
                {
                    airplanes[i].status = "Отменён";
                    resultAirplane.Add(airplanes[i]); //помещение в список отлетавших
                    airplanes.Remove(airplanes[i]); //удаление из активного списка
                    return;
                }
            }
        } //поиск самолёта для удаления

        private async void FlyAsync(Airplane airplane)
        {
            DepartureAirport(airplane);
            await Task.Run(airplane.AirFly);
            AirportChecked(airplane);         
        } //асинхронный запуск с проверками вылета/прилёта

        private void AirportChecked(Airplane air) 
        {
            resultAirplane.Add(air); //помещение в список отлетавших
            foreach(var city in airports)
            {
                if (air.Type == city.Type)
                {
                    ArriivalAirport(air, city);
                }
            }
            air.status = "Прилетел";
            airplanes.Remove(air); //удаление из списка
        } //проверка прилёта
        private void ArriivalAirport(Airplane air, Airport city) 
        {
            if (air.CityDeparture == city.Name) //меняем цвет табло у вылет.аэропорта
            {
                city.tabloColor = Color.Red;
            }
            if (air.CityArrival == city.Name)
            {
                city.Arrival += 1;
            }
        } //фиксируем прилёт самолёта
        private void DepartureAirport(Airplane air)
        {
            foreach (var p in airports)
            {
                if (air.Type == p.Type && air.CityDeparture == p.Name) 
                {
                    p.Departure += 1;
                    p.tabloColor = Color.Green;
                    air.status = "В пути";
                }
            }
        } //фиксируем вылёт самолёта
        private void DrawVisible(Graphics e, Airplane air)
        {
            if (air is PassengerAirplane && PassengerAirplane.visible) 
            {
                air.VisibleS(e, PassengerAirplane.visibleColor);
            }
            if (air is CargoAirplane && CargoAirplane.visible)
            {
                air.VisibleS(e, CargoAirplane.visibleColor);
            }
            if (air is MilitaryAirplane && MilitaryAirplane.visible)
            {
                air.VisibleS(e, MilitaryAirplane.visibleColor);
            }
        } //проверка и рисование траектории полёта
        #endregion

        #region Аэропорты
        public void DrawAirports(Graphics g)
        {
            for (int i = 0; i < airports.Count; i++)
            {
                airports[i].DrawAirport(g);
            } 
        } //рисование аэропортов
        public void FindAirport(Airplane air)
        {
            foreach (var city in airports)
            {
                if (air.Type == city.Type) //если типы совпадают
                {
                    if (city.Name == air.CityDeparture)
                    {
                        air.A = new PointF(city.Location.X, city.Location.Y);
                        city.capacity++; //увеличиваем вместимость при вылете
                    }
                    if (city.Name == air.CityArrival)
                    {
                        air.B = new PointF(city.Location.X, city.Location.Y);
                        city.capacity--; //уменьшаем вместимость при влёте
                    }
                }
            }
        } //поиск и установка координат вылета/прилёта самолёта
        public void DelAirport(Point point)
        {
            for (int i = 0; i < airports.Count; i++)
            {
                if (airports[i].region.Contains(point))
                {
                    airports.Remove(airports[i]);
                    return;
                }
            }
        } //поиск аэропорта для удаления
        public bool TestCapacity(Airplane air)
        {
            foreach(var city in airports)
            {
                if (city.Type == air.Type && city.Name == air.CityArrival && city.capacity > 0)   
                {
                    return true;
                }
            }
            return false;
        } //проверка на вместимость
        #endregion
    } //класс рейсов с взаимодейсвием между объектами
    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    public class DataBaza 
    {
        private readonly SqlConnection sc; //подключение к БД
        private string query; //запрос к БД

        public DataBaza()
        {
            sc = new SqlConnection(ConfigurationManager.ConnectionStrings["InfoBaza"].ConnectionString);
        }

        private void SetAirportInBaza(List<Airport> airports)
        {      
            try
            {
                SqlCommand rg = new SqlCommand("TRUNCATE TABLE [Airports]", sc); //очистка предыдущей таблицы
                sc.Open();           
                rg.ExecuteNonQuery();

                for (int i = 0; i < airports.Count; i++)
                {
                    query = "insert into [Airports](Город,Тип,Вместимость,Число_вылетов,Число_прилётов) " +
                        "Values (N'" + airports[i].Name + "',N'" + airports[i].Type + "'," + airports[i].capacity + "," + airports[i].Departure + "," + airports[i].Arrival + ")";
                    rg = new SqlCommand(query, sc);
                    rg.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close(); 
            }
        } //заполнение базы данных
        private void SetAirplanesInBaza(List<Airplane> airplanes)
        {
            try
            {
                SqlCommand rg = new SqlCommand("TRUNCATE TABLE [Airplanes]", sc); //очистка предыдущей таблицы
                sc.Open();
                rg.ExecuteNonQuery();

                for (int i = 0; i < airplanes.Count; i++)
                {
                    query = "insert into [Airplanes](Тип,Статус,Город_вылета,Город_прилёта,Дата_вылета,Дата_прилёта,Скорость,Вместимость)" +
                        "Values (N'" + airplanes[i].Type + "',N'" + airplanes[i].status + "',N'" + airplanes[i].CityDeparture + "',N'" + airplanes[i].CityArrival + "',N'" + airplanes[i].DateDeparture.ToString("yyyy-mm-dd") + "',N'" + airplanes[i].DateArrival.ToString("yyyy-mm-dd")+ "'," + airplanes[i].speed + "," + airplanes[i].capacity + ")";
                    rg = new SqlCommand(query, sc);
                    rg.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sc.Close();
            }
        } //заполнение базы данных
        private void SetDataGrid(DataGridView dataGrid, string sda)
        {
            object d = new object();
            sc.Open();
            lock (d)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sda, sc);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGrid.DataSource = dataSet.Tables[0];
            }
            sc.Close();
        } //отображение базы данных в таблицу
        private void OpenAirportsBaza(DataGridView dataGrid)
        {
            SetDataGrid(dataGrid,"SELECT * FROM Airports ORDER BY Тип");
        } //сортируем таблицу с аэропортами
        private void OpenAirplanesBaza(DataGridView dataGrid)
        {
            SetDataGrid(dataGrid, "SELECT * FROM Airplanes ORDER BY Тип");
        }  //сортируем таблицу с самолётами

        public void AirportsBazaAsync(List<Airport> airports, DataGridView dataGrid)
        {
            SetAirportInBaza(airports); //заполняем SQL таблицу
            OpenAirportsBaza(dataGrid); //заполняем таблицу 
        } //заполнение таблиц
        public void AirplanesBazaAsync(List<Airplane> airplanes, DataGridView dataGrid)
        {
            SetAirplanesInBaza(airplanes); //заполняем SQL таблицу
            OpenAirplanesBaza(dataGrid); //заполняем таблицу
        } //заполнение таблиц
    } //класс БД с заполнением и открытием
}
