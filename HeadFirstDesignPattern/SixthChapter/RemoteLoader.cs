using System;

namespace HeadFirstDesignPattern.SixthChapter
{
    public class RemoteLoader
    {
        //public static void Main(string[] args)
        //{
        //    RemoteControl remoteControl = new RemoteControl();

        //    Light livingRoomLight = new Light("Living Room");
        //    Light kitchenLight = new Light("Kitchen");
        //    CeilingFan ceilingFan = new CeilingFan("Living Room");
        //    GarageDoor garageDoor = new GarageDoor();
        //    Stereo stereo = new Stereo("Living Room");

        //    LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
        //    LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
        //    LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
        //    LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

        //    CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
        //    CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

        //    GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
        //    GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

        //    StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
        //    StereoOffCommand stereoOff = new StereoOffCommand(stereo);

        //    remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        //    remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
        //    remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
        //    remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);

        //    Console.WriteLine(remoteControl);

        //    remoteControl.OnButtonWasPushed(0);
        //    remoteControl.OffButtonWasPushed(0);
        //    remoteControl.OnButtonWasPushed(1);
        //    remoteControl.OffButtonWasPushed(1);
        //    remoteControl.OnButtonWasPushed(2);
        //    remoteControl.OffButtonWasPushed(2);
        //    remoteControl.OnButtonWasPushed(3);
        //    remoteControl.OffButtonWasPushed(3);
        //}

        //public static void Main(string[] args)
        //{
        //    RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

        //    Light livingRoomLight = new Light("Living Room");

        //    LightOnCommand LivingRoomLightOn = new LightOnCommand(livingRoomLight);
        //    LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

        //    remoteControl.SetCommand(0, LivingRoomLightOn, livingRoomLightOff);

        //    remoteControl.OnButtonWasPushed(0);
        //    remoteControl.OffButtonWasPushed(0);
        //    Console.WriteLine(remoteControl);
        //    remoteControl.UndoButtonWasPushed();
        //    remoteControl.OffButtonWasPushed(0);
        //    remoteControl.OnButtonWasPushed(0);
        //    Console.WriteLine(remoteControl);
        //    remoteControl.UndoButtonWasPushed();
        //}

        //public static void Main(string[] args)
        //{
        //    RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

        //    CeilingFan ceilingFan = new CeilingFan("Living Room");

        //    CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
        //    CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
        //    CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

        //    remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
        //    remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

        //    remoteControl.OnButtonWasPushed(0);
        //    remoteControl.OffButtonWasPushed(0);
        //    Console.WriteLine(remoteControl);
        //    remoteControl.UndoButtonWasPushed();

        //    remoteControl.OnButtonWasPushed(1);
        //    Console.WriteLine(remoteControl);
        //    remoteControl.UndoButtonWasPushed();
        //}

        public static void Main(string[] args)
        {
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

            Light light = new Light("Living Room");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand lightOn = new LightOnCommand(light);
            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);

            LightOffCommand lightOff = new LightOffCommand(light);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            ICommand[] partyOn = { lightOn, stereoOnWithCD };
            ICommand[] partyOff = { lightOff, stereoOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            Console.WriteLine("--- Pushing Macro on---");
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine("--- Pushing Macro off---");
            remoteControl.OffButtonWasPushed(0);
        }
    }
}
