using Appliances.Models.Appliances.ComputingDevices.Portables;
using Appliances.Models.Appliances.ComputingDevices.Portables.Laptops;
using Appliances.Models.Appliances.ComputingDevices.Portables.Smartphones;
using Modul2HW6.Enums;
using Modul2HW6.Models;
using Modul2HW6.Models.Appliances.ComputingDevices.Stations;
using Modul2HW6.Models.Appliances.ComputingDevices.Stations.MultiMedias;
using Modul2HW6.Models.Appliances.KitchenDevices.HeatDevices;
using Modul2HW6.Models.Appliances.KitchenDevices.ShreddingDevices;

namespace Modul2HW6.Providers
{
   public class AppliancesProvider
    {
        private Appliance[] _data;
        public AppliancesProvider()
        {
            _data = new Appliance[]
            {
                new Multicooker()
                {
                    BurnersCount = 4,
                    Color = Color.Black,
                    MaxTemperature = 250,
                    Power = 4500,
                    Price = 4999,
                    Producer = Company.Braun
                },

                new ElectricKettle()
            {
                Color = Color.Green,
                MaxTemperature = 130,
                Power = 600,
                Noise = 20,
                Price = 800,
                Producer = Company.Electrolux,
                Volume = 2.5,
            },
                new Mixer()
                {
                    BladesCount = 3,
                    Color = Color.White,
                    Noise = 25,
                    Type = MixerType.Stationary,
                    Power = 100,
                    Price = 1100,
                    Producer = Company.Moulinex,
                },

                new MeatGrinder()
                {
                    BladesCount = 5,
                    Color = Color.Grey,
                    Noise = 53,
                    NozzlesCount = 3,
                    Power = 300,
                    Price = 1900,
                    Producer = Company.Fujitsu,
                },

                new AudioSystem()
                {
                    Color = Color.Yellow,
                    MaxFrequency = 900,
                    MinFrequency = 100,
                    OS = OperatingSystem.Other,
                    ProcessorFrequency = 350,
                    Ports = new PortType[] { PortType.AUX, PortType.USB },
                    Power = 250,
                    PowerSupply = PowerSupply.Linear,
                    Price = 7000,
                    Producer = Company.JBL,
                },

                new PersonalComputer()
                {
                    Color = Color.White,
                    ProcessorFrequency = 3600,
                    IsMonoBlock = false,
                    OS = OperatingSystem.Windows,
                    Power = 750,
                    PowerSupply = PowerSupply.Linear,
                    Price = 17000,
                    Producer = Company.Asus,
                },

                new PersonalComputer()
                {
                    Color = Color.White,
                    ProcessorFrequency = 2400,
                    IsMonoBlock = true,
                    OS = OperatingSystem.MacOs,
                    Power = 600,
                    PowerSupply = PowerSupply.Linear,
                    Price = 34999,
                    Producer = Company.Apple,
                },

                new Notebook()
                {
                    DegreeOfOpening = 130,
                    BateryCapacity = 30000,
                    Color = Color.Green,
                    OS = OperatingSystem.Ubuntu,
                    Power = 300,
                    Price = 24000,
                    ProcessorFrequency = 3000,
                    Producer = Company.HewlettPackard
                },

                new TouchLaptop()
                {
                    DegreeOfOpening = 110,
                    TouchQuantity = 6,
                    MatrixType = MatrixType.IPS,
                    FingerPrintScaner = false,
                    BateryCapacity = 15000,
                    Color = Color.Black,
                    OS = OperatingSystem.Windows,
                    Power = 200,
                    Price = 21000,
                    ProcessorFrequency = 1800,
                    Producer = Company.Lenovo
                },

                new PushButtonPhone()
                {
                    KeyboardType = KeyboardType.Rubber,
                    BateryCapacity = 1000,
                    Color = Color.Violet,
                    ProcessorFrequency = 350,
                    OS = OperatingSystem.Symbian,
                    Power = 10,
                    Price = 700,
                    SimCardQuantity = 2,
                    Producer = Company.Nokia
                },

                new TouchscreenPhone()
                {
                    BateryCapacity = 8000,
                    Color = Color.Black,
                    FingerPrintScaner = true,
                    ProcessorFrequency = 1800,
                    MatrixType = MatrixType.AMOLED,
                    OS = OperatingSystem.Android,
                    Power = 10,
                    TouchQuantity = 5,
                    Price = 19999,
                    Producer = Company.Google,
                    SimCardQuantity = 2
                }
            };
        }

        public Appliance[] GetData()
        {
            return _data;
        }
    }
}
