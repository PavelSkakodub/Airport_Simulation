using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Классы_к_системе_полётов;

namespace Модель_системы_полётов
{
    public partial class Form1 : Form
    {
        readonly DataBaza AirBaza = new DataBaza(); //объект класса информации по аэропортам
        readonly Raise r = new Raise(); //объект класса рейсов

        bool flag;  //проверка для добавления аэропорта
        bool dflag; //проверка для удаления аэропорта
        bool aflag; //проверка для удаления самолёта

        public Form1()
        {
            InitializeComponent();
        }

        #region Функции формы
        private void Form1_Load(object sender, EventArgs e)
        {        
            WindowState = FormWindowState.Maximized; //максимум формы
            showPanel.Location = new Point(Width-35, 0); //кнопка открытия панели управления
            showPanel.Size = new Size(20, 20);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            r.DrawAirports(e.Graphics); //рисование всех аэропортов
            r.DrawAirplane(e.Graphics); //рисование всех самолётов
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == true) //проверка нажатия кнопки "Добавить"
            {
                if (SelectType.SelectedIndex == 0) //если выбран тип пассажирский
                {
                    r.airports.Add(new PassengerAirport(CityAirport.Text, e.Location, Convert.ToByte(Capacity.Text))); //добавление в коллекцию объекта
                }
                if (SelectType.SelectedIndex == 1) //если выбран тип грузовой
                {
                    r.airports.Add(new CargoAirport(CityAirport.Text, e.Location, Convert.ToByte(Capacity.Text))); //добавление в коллекцию объекта
                }
                if (SelectType.SelectedIndex == 2) //если выбран тип военный
                {
                    r.airports.Add(new MilitaryAirport(CityAirport.Text, e.Location, Convert.ToByte(Capacity.Text))); //добавление в коллекцию объекта   
                }
                Refresh();
            }
            flag = false; //запрет на повторное добавление аэропорта
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dflag)
            {
                r.DelAirport(e.Location); //удаление найденного аэропорта
                Refresh();
            }
            if(aflag)
            {
                r.FindAirplane(e.Location); //удаление найденного самолёта
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
        #endregion

        #region Функции сохранения данных о рейсе
        private void SaveRaise(Airplane air)
        {
            air.g = CreateGraphics();
            air.CityDeparture = where.Text;
            air.CityArrival = there.Text;
            air.DateDeparture = departureTime.Value;
            air.DateArrival = arrivalTime.Value;
            MessageBox.Show(air.DateArrival + ":" + air.DateDeparture);
            if (r.TestCapacity(air))
            {
                r.airplanes.Add(air);
                r.FindAirport(air);
            }
            else MessageBox.Show("Не вмещается в аэропорт!");
        } //сохранение данных о самолёте
        private void Save1_Click(object sender, EventArgs e)
        {
            aflag = false;
            if (combo.Text != "" && where.Text != "" && there.Text != "" && speed.Text != "" && cargo_air.Text != "")
            {
                if (where.Text != there.Text) 
                {
                    if (new Random().Next(0, 100) != 1) //вероятность 1 из 100 что отменят рейс
                    {
                        if (combo.SelectedIndex == 0)
                        {
                            PassengerAirplane p = new PassengerAirplane();
                            switch (formAirplane.SelectedIndex + 1)
                            {
                                case 1:
                                    p = new PassengerAirplane(Properties.Resources.pas1);
                                    break;
                                case 2:
                                    p = new PassengerAirplane(Properties.Resources.pas2);
                                    break;
                                case 3:
                                    p = new PassengerAirplane(Properties.Resources.pas3);
                                    break;
                            }
                            //инициализация нового самолёта с заданием скорости (из-за свойств)
                            p.Speed = ushort.Parse(speed.Text);
                            p.Capacity = ushort.Parse(cargo_air.Text);
                            SaveRaise(p);
                        } //для пассажирских
                        if (combo.SelectedIndex == 1)
                        {
                            CargoAirplane car = new CargoAirplane();
                            switch (formAirplane.SelectedIndex + 1)
                            {
                                case 1:
                                    car = new CargoAirplane(Properties.Resources.cargo1);
                                    break;
                                case 2:
                                    car = new CargoAirplane(Properties.Resources.cargo2);
                                    break;
                                case 3:
                                    car = new CargoAirplane(Properties.Resources.cargo3);
                                    break;
                            }
                            //инициализация нового самолёта
                            car.Speed = ushort.Parse(speed.Text);
                            car.Capacity = ushort.Parse(cargo_air.Text);
                            SaveRaise(car);
                        } //для грузовых
                        if (combo.SelectedIndex == 2)
                        {
                            MilitaryAirplane mil = new MilitaryAirplane();
                            switch (formAirplane.SelectedIndex + 1)
                            {
                                case 1:
                                    mil = new MilitaryAirplane(Properties.Resources.military1);
                                    break;
                                case 2:
                                    mil = new MilitaryAirplane(Properties.Resources.military2);
                                    break;
                                case 3:
                                    mil = new MilitaryAirplane(Properties.Resources.military3);
                                    break;
                            }
                            //инициализация нового самолёта
                            mil.Speed = ushort.Parse(speed.Text);
                            mil.Capacity = ushort.Parse(cargo_air.Text);
                            SaveRaise(mil);
                        } //для военных
                    }
                    else MessageBox.Show("Рейс отменён из-за погодных или др. условий!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //очитска для нового рейса
                    combo.Text = ""; where.Text = ""; there.Text = ""; departureTime.Value = DateTime.Now; arrivalTime.Value = DateTime.Now; speed.Clear(); cargo_air.Clear();
                }
                else MessageBox.Show("Нельзя прилететь в город, с которого вылетели!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Не все поля заполнены или заполнены некорректно!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } //сохранение данных рейса
        private void combo1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            where.Items.Clear(); //очистка элементов
            there.Items.Clear(); //при переключении типа

            for (int i = 0; i < r.airports.Count; i++)
            {
                if (combo.SelectedItem.ToString() == r.airports[i].Type) //если тип аэропорта совпадает с выбранным добавляем его в comboBox
                {
                    where.Items.Add(r.airports[i].Name);
                    there.Items.Add(r.airports[i].Name);
                }
            }
        } //добавление аэропортов в comboBox
        #endregion

        #region Сериализация и десериализация аэропортов
        private void Serializable_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = "d:\\",
                Filter = "Text File (*.dat)|*.dat",
                FilterIndex = 2,
                AddExtension = true
            }; //объект для сохранения файла
            saveFileDialog.ShowDialog();
            BinaryFormatter formatter = new BinaryFormatter();
            List<Airport> serialize = new List<Airport>(r.airports);
            using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, serialize);
            }
        } //сериализация аэропортов
        private void Deserializable_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "d:\\",
                Filter = "Text File (*.dat)|*.dat",
                FilterIndex = 2,
                AddExtension = true
            };
            openFileDialog.ShowDialog();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
            {
                r.airports = (List<Airport>)formatter.Deserialize(fs);
            }
            Refresh();
        } //десериализация аэропортов
        #endregion

        #region Функции кнопок
        private void startRaise_Click(object sender, EventArgs e)
        {
            timer1.Start(); //старт таймера
            r.FlyAirplanes(); //асинхронный запуск всех сущ-их рейсов
        } //запуск всех рейсов
        private void colorCity_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Airport.colorCity = colorDialog1.Color;
            Refresh();
        } //цвет надписи города
        private void fontSize_Click(object sender, EventArgs e)
        {
            Airport.fontSize = Convert.ToSByte(Microsoft.VisualBasic.Interaction.InputBox("Введите размер надписи аэропортов:"));
            Refresh();
        }  //размер надписи города
        private void AddAirport_Click(object sender, EventArgs e)
        {
            flag = true;
            dflag = false;
        } //переключатель
        private void colorVisible_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            PassengerAirplane.visibleColor = colorDialog1.Color;
        } //цвет траектории
        private void colorVisible2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            CargoAirplane.visibleColor = colorDialog1.Color;
        } //цвет траектории
        private void colorVisible3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            MilitaryAirplane.visibleColor = colorDialog1.Color;
        } //цвет траектории
        private void DelAirport_Click(object sender, EventArgs e)
        {
            dflag = true;
            flag = false;
        } //удаление аэропорта
        private void DelAirplane_Click(object sender, EventArgs e)
        {
            aflag = true;
        } //удаление рейса
        private void OpenAirportBaza_Click_1(object sender, EventArgs e)
        {
            InfoBaza Info = new InfoBaza();
            //try
            //{
            //открываем форму и заполняем таблицы
            Info.Show();
                AirBaza.AirportsBazaAsync(r.airports,Info.dataGrid);
                //Info.Show();
            //}
            //catch
            //{
               // MessageBox.Show("Ошибка при работе с БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  Info.Close();
            //}
        } //открыть базу аэропортов
        private void BazaAirplaneRaise_Click(object sender, EventArgs e)
        {
            InfoBaza Info = new InfoBaza();
            //создаём коллекцию из всех самолётов и добавляем туда обе коллекции
            List<Airplane> air = new List<Airplane>(r.airplanes.Count + r.resultAirplane.Count);
            air.AddRange(r.airplanes);
            air.AddRange(r.resultAirplane);
            //try
            //{
                //открываем форму и заполняем таблицы
                AirBaza.AirplanesBazaAsync(air, Info.dataGrid);
                Info.Show();
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка при работе с БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Info.Close();
            //}
        } //открыть базу самолётов
        private void showPanel_Click(object sender, EventArgs e)
        {
            InstrumentPanel.Visible = true;
        } //открыть панель инструментов
        private void closePanel_Click(object sender, EventArgs e)
        {
            InstrumentPanel.Visible = false;
        } //скрыть панель инструментов
        private void checkP_CheckedChanged(object sender, EventArgs e)
        {
            if (PassengerAirplane.visible == true) PassengerAirplane.visible = false;
            else PassengerAirplane.visible = true;
        } //показать траекторию пассажирских
        private void checkC_CheckedChanged(object sender, EventArgs e)
        {
            if (CargoAirplane.visible == true) CargoAirplane.visible = false;
            else CargoAirplane.visible = true;
        } //показать траеторию грузовых
        private void checkM_CheckedChanged(object sender, EventArgs e)
        {
            if (MilitaryAirplane.visible == true) MilitaryAirplane.visible = false;
            else MilitaryAirplane.visible = true;
        } //показать траеторию военных
        #endregion
    }
}
