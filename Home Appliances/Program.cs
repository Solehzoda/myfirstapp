using System;

namespace Home_Appliances
{
    class Program
    {
        private string brand;
        protected int power;
        public bool onOff;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public void TurnON()
        {
            onOff = true;
            Console.WriteLine("Turned ON");
        }

        public void TurnOFF()
        {
            onOff = false;
            Console.WriteLine("Turned OFF");
        }

        public void InfoDisplay()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("On off: " + onOff);
        
    }

        class Refrigirator : Program
        {
            public Refrigirator(string brand, int power)
            {
                this.Brand = brand;
                this.power = power;
                this.onOff = false;
            }
        }

        public void RefrigiratorDisplay()
        {
            Console.WriteLine("InfoRefrigirator");
            
        }

        class WashingMachine: Program
        {
            public WashingMachine(string brand, int power)
            {
                this.Brand = brand;
                this.power = power;
                this.onOff = false;
            }

            public void InfoWashingMachineDisplay()
            {
                Console.WriteLine("InfoWashingMachine");
            }
        }
        static void Main(string[] args)
        {
           Refrigirator refrigirator = new Refrigirator("Samsung", 220);
           WashingMachine washingMachine = new WashingMachine("OLG", 110);
           
           refrigirator.RefrigiratorDisplay();
           refrigirator.TurnON();
           refrigirator.TurnOFF();
           
           Console.WriteLine(refrigirator.Brand);
           
           
           washingMachine.InfoWashingMachineDisplay();
           washingMachine.onOff = true;
           washingMachine.InfoDisplay();
           washingMachine.onOff = false;
           washingMachine.InfoWashingMachineDisplay();
           
           
        }
    }
}