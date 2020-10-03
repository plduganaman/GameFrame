# GameFrame

I wanted a simple way to send commands to my Game Frame device to do various things based on a schedule
The exe (which is all you really need but you can modify the source code too) is located in the 
GameFrame\bin\Debug\netcoreapp3.1 folder
The exe can be run from a command line with the following parameters:
IP address and commmand to run in quotes.
For example:
192.168.1.11 "power on"

Here are the available commands that can be passed to the Game Frame:

            //Argument 1    Argument 2	Description
            //next                              Next animation.
            //brightness    0-7	            Set brightness level.
            //power         on/off              Power up/down the Game Frame. Leave argument 2 blank to toggle.
            //play          8.3 folder name     Play a specific folder by name.
            //alert         8.3 folder name     Play a specific folder by name as alert.
            //color         RGB color code      Fill the display with a specific color (i.e. #FF0000 for red). You may also pass “random” for a random color.
            //clockface     1-5	            Change the clock face graphic.
            //timezone      UTC Offset          Offset from UTC in hours, from -12.0 to 13.0.
            //playback      0-2	            Playback mode (0=Sequential, 1=Shuffle, 2=Pause animations).
            //display	    0-2	            System mode(0=Gallery, 1=Clock, 2=Effects).
            //cycle	    1-8	            Animation duration(1=10s, 2=30s, 3=1m, 4=5m, 5=15m, 6=30m, 7=1h, 8=infinity).
            //reboot                            Reboot Game Frame.
            
 Hopefully someone else can get some use out of this.  
 I have set mine up via the Windows Task Scheduler to start and stop, change modes during various times of the day and week.
 
 According to Visual Studio (which the project was built with) the app can run in Windows, MacOS and Linux.  
 
 
