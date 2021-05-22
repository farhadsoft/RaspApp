using System;
using System.Threading;
using System.Device.Gpio;


namespace RaspApp
{
    class Program
    {
        static GpioController controller = new GpioController();
        static void Main()
        {
            int[] pins = new int[] { 18, 24, 25 };

            foreach (int pin in pins)
            {
                controller.OpenPin(pin, PinMode.Output);
                controller.Write(pin, 0);
            }

            Console.WriteLine("Setup complete!");
            
            while (true)
            {
                StartRed();
                StartYellow();
                StartGreen();
            }
        }

        public static void StartRed()
        {
            int pin = 18;
            int lightTime = 5000;

            controller.Write(pin, PinValue.High);
            Thread.Sleep(lightTime);
            controller.Write(pin, PinValue.Low);
        }

        public static void StartYellow()
        {
            int pin = 24;
            int lightTime = 1000;

            controller.Write(pin, PinValue.High);
            Thread.Sleep(lightTime);
            controller.Write(pin, PinValue.Low);
            Thread.Sleep(lightTime);
            controller.Write(pin, PinValue.High);
            Thread.Sleep(lightTime);
            controller.Write(pin, PinValue.Low);
            Thread.Sleep(lightTime);
            controller.Write(pin, PinValue.High);
            Thread.Sleep(lightTime);
            controller.Write(pin, PinValue.Low);
            Thread.Sleep(lightTime);
        }

        public static void StartGreen()
        {
            int pin = 25;
            int lightTime = 5000;

            controller.Write(pin, PinValue.High);
            Thread.Sleep(lightTime);
            controller.Write(pin, PinValue.Low);
        }
    }
}
