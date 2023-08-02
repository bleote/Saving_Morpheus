using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                             Welcome to");
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine(@"
           _____             _               __  __                  _                    
          / ____|           (_)             |  \/  |                | |                   
         | (___   __ ___   ___ _ __   __ _  | \  / | ___  _ __ _ __ | |__   ___ _   _ ___ 
          \___ \ / _` \ \ / / | '_ \ / _` | | |\/| |/ _ \| '__| '_ \| '_ \ / _ \ | | / __|
          ____) | (_| |\ V /| | | | | (_| | | |  | | (_) | |  | |_) | | | |  __/ |_| \__ \
         |_____/ \__,_| \_/ |_|_| |_|\__, | |_|  |_|\___/|_|  | .__/|_| |_|\___|\__,_|___/
                                      __/ |                   | |                         
                                     |___/                    |_|                         
        ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                      Developed by Bruno Leote");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n\n---Press Enter to continue---");

        // Wait for user to press Enter
        Console.ReadLine();

        // Clear the console
        Console.Clear();

        string textScene1Part1 = "\nThings in Matrix have been crazy lately. The agents are aware of Neo(YOU) and have captured Morpheus.\r\nThey want Morpheus to give up the location of his ship, Nebuchadnezzar, so the agents can send sentinels to kill everyone onboard.\r\n\nThe agents are on a high floor in a skyscraper, torturing Morpheus, who's seated, handcuffed to a chair.\r\n";
        int delayMilliseconds = 5;

        TypeTextLetterByLetter(textScene1Part1, delayMilliseconds, true);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
                         .';::;,cl;.       ...',;:cclloooooc:cc:;,'..                                                                                 
                        ..,,,;;:c;.........',;::cloooddddddollollc:;,'...                                 .';;;;;;;;;,,,.                             
                         ....';lxxlll:''',;;:clllooodddddddolloollcc::;;,'...                           'llloodoodxxddoddc'                           
                              ..:dOXWXkc;:::ccllllooooooooolclolllccc:::;;,,'...                        .cxOKKOdlc;.........                          
                                ..;xXWWKo::cccllllloooooooolclllllcc::;,,'''',''...                    .cXWMNOc..                                     
                .            ';.  .;kNWWOl:ccccllllllllllllc:cllcc:,..........',''....                 :XWWWKo.   ':,.                                
             ....           .d0dl;,dXWXOxc::cccccccclllllccc::ccc,...;oxkOO0Okdc,''.......            .cddkKN0l,'clok:.                               
           .......         ..;xKK0odXNKo,,::::ccccccccccccc:;:::,. .c0XNWWMMMWWXx;''........           ...lKNXkld00kxc.                               
              ....         .,,;o0KOk0KXXKkl:::::::::::::::::;;:;.   .lOKXNWWWMWWNx,...........       .:kdoOKKK0OO0ko::.                               
              .....       .,ldook0KKKO0XX0d;''''''''''',,,,''',.    .;xkkdllllkKk:...............    'dkO00OkO000xc:coc'.                             
       ..............  .'cdkO0kdlldxO000xc,,,,,,,,,,,'''''''..'. .. .:do:'.  .dXd.  ........           'dkO0kxdolccoddxxo;.                           
      ...............'lk0K0OkOxl;,;coxkxc,,,,,,,,,,,,,,,,,,,'',''::,.;dkkxooodkkkc.............        .'lxkdl:;;:lxOOKXNXd:,.                        
     .................lkKWWNXKOo;'',;ckk:''''','''''''''''''..'',cdl'':lodOKKXklol'............         .oxl:;;;:coOXWWWX0kkxo:,;,.                   
       ............ .':ldOXWWWNOl,....,;'.'''''''''''''''''........'..,:coxkxxxol:............          .....',;cd0WWNKkddxkOOOOkdc,..                
          ........',:llodddkKNWWk,................................  .....',,;:cc:'........                    .'oKWN0kdodxkkkxol:'....                
            ..........',:lolld0NNx,.................................''.  ....,;;'....                         .lXWKxdoodxxdlc;,,.   .                 
                        ..,::::l0Xl................................,cc;'.........                             .dXOdolllodc,'..'.   ..                 
                       .....';;,;l;.............................. .oKKOxl,...'c:..                            .:ollccclo:...''.   .'.                 
                       ....''.','''..      ..  ...............''.. ,kNWWN0l''oKx,'....                     'l:;clcccccl:. .',....;'.                  
                      .........';'.''.          .........',,;;,'....,kWMMXc..cX0:','''...                 ,0Kocc::::cl;..;dkkkO0KOdc;.                
                       ..........,'..'.          ... .....'',',,.....,kWMXl.'xNWk;...'.....              'OXd::;;,;:::cdONWMMMMMMMMWN0xc'             
                       ........  .'.....         ..    ........''.....,kWMOc;lXMWx,'''....              .oXx,',,'',;lkXNNNWWMMMMMMMMWWNN0o'           
                        .......   .......        ..      ..........''..,kWKx:.:0WXo,''..                'OO,......,ck0KXXXXNWWMMMMMMWNNXK0k:.         
                        ......      .....        .          .........''.,xXXo..:KMO:',..                ;k:.......,coxxxkkO0KXNWWWWWNXKK0OOx;         
                         .....       ...        ..           ..........'.'oOo'.'xWNo''..               .',. .........,:cllodddkOkkkkxdddkkkxc.        
                         .....                  ..            .............'..  ,0Wk,..                ..   .....    ..',:cccccc:;,;;'':looo:.        
                          ....                 ..                    .  ...      cXO'..                .     ...        ..'''''',,'''',;;;;:;;.       
                          ....                ...                                .xx.                  .       .''.  .:c'.......',,,,,,,,,,,;:'       
                           ...               ....    .                            ,;.                          .;;.  .'dc   ....,,;;;;;::::::;.       
                                             ...                                                                       '.......';:c:::c::;,,,,.       
                             .                                                                                 ..     ..  .......',,,,,'.......       
                             ..            .....                                                         ..  ....     ..     .......''.........       
                             ..             ....                                                       ... ....       .'.    ....   .....'...'.       
                                             ...           ..  .      ........  ..,,.               ..........  ...    '. .......   .,'.','''..       
                                             ...                  ...  .....'';d0XNNKkl.          ..........   .:.     .. ....,'.  .:lc,';;,'.        
                                ..           .''.                   .    .....cXWNNNNX0d:'    ....''.. ...   .;oc:lo'  .'  ..',,.  .;l:'.'''..        
             .                 . .           ':c:'.                           ,kxdxxkko;,. ..''..,:c;...   .:ddl;:xd.  .'.   ...   ..........         
            ...                              ;dxxxdlc;'...                    .'...;c;... .;lc:cx0XXO;.';:ldxdl:'.;;.   '.         ............       
                                            .l00000KKK00kkl.                              .:xdd0NNXXOdddxxxdoc:,..,,.   ..     .   ..'......'','.     
                 ...  ......                 ;xkkkOOOOOkkkl.                               .';lxkkkxddookkdoc;;'..,,.   .'      .....''... .'..;;,..  
''''''''.......''''''''';:,'.                ..'',''',,,,'.                                .,lxxdoool::dOxl:,''....'.   .,.      ...,,...'. ......':,.
;;::;,,,,,,,,,,;cllolc;,,,,'.       ..       .dKKK0k0XXXXKc                            ..;codddollcc:;;;,..   ...  ..   .;..      .....'c:. .,'... .:c
:;:::;'.'''''',coddxxdlc,'''.                .oWWWNKXWWWMX:                          'cddxxxdooolooc:,.       ...       ':'...........'ldc.  ''... .,c
::cll:,''',,',lddxxddooo:'''.       ...       ,0WNX0KNNNWO'                         .'lxOkxooxkOOOxoc:.               ..,c,.''.......':do'.. .'..'.':c
llooll:,,,;;,:dkdoooxxdo:,,,.       ...       .dXXKk0XXXXo.                         ..',:ddcloooc:,'..                 .;l;',,,,,,''',ll' ... .. .';:;
xdxxxdc::ccc:cdxxdxkkkxoc:::,.       .         ;O0Oxk000O;                        .''...';:,,;;,.....                   ,l;,,,,,,,''',;.   .. .'..';:;
kkkkkdllllllloxkOK0kdxxccccc;.                 .lkxodkkkd'                      ..............','....                   .:,''''''''''..        '. .','
kkkOOxddddoooooodkkdoddlcccc;.                  ,oocldddc.                     ...        ...   ..    ..                .;..'''''''..          .'  ...
xxxxxddxxxdddoollllllllllccc:.         .    .',,;cc;:ccc;.                                             ..               .;. .''''...           .'.  . 
xxxxxxxxdddddddoooooooooolllc.  ......''.   .,,,;,.......                                               .               .;.  ..''.              ..  ..
kxxxxxxxxxxxxxxxxxddddddddool'  .;::'.'... ..  ...                                                                      .:.   ....              .'....
OOOOOkkkkkkkkkkkkkkkkkkxxxxxd;   ...........    ..                                                                      .:.     .                .'.. 
kkkkkxxxxxxxddddoooollllcc:::.      .'.':c;..   ..                                                                      .:.                      .,.  
................                     ...,;;'...',.                                                                      .:.                       .'  
                                 .....',;;;,';::;.                                                                      .:.                       .,. 
  .............'',,,;;;:::ccc:;:coddl::lc.  .'';:.                                                                      ':.                        .' 
;:clllodxkOO00O00KKXXXXNNXNWNkooodO0kold:.   ..''                                                                       ':.                         '.
        ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n---Press Enter to continue---");

        // Wait for user to press Enter
        Console.ReadLine();

        // Clear the console
        Console.Clear();

        string textScene1Part2 = "\nWhen they least expect, they hear the sound of a military chopper. Looking out the window, they see a woman in black leather driving the helicopter: Trinity! She's bringing Neo in the backseat as her only support.\r\n\r\nNeo has anger in his eyes, and he is aiming a rotatory cannon at the agents. \r\nBefore anyone could move, Neo opens fire, in mid-air. \r\n\nCapsules are now raining from the sky, with bullets crossing the space between the helicopter and the building in a fraction of a second, crushing the windows, and hitting everyone standing up on the floor. All the agents in the room are dead!\r\n\r\nIt's Morpheus's chance to escape...\n";

        TypeTextLetterByLetter(textScene1Part2, delayMilliseconds, true);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
................................................... .                                                  .,...'',,,'''''','',,,;::::cc;,,,,,,,;;;:::clll
......................................................                 .                               .'.......,,','''''''',,,,,;:cccc::::ccc:::;;,,,
......................................................            ..                                   .',''.....,,,,''''''''''...';;::::::clllllloool
.....................................................     .       ..                                   .',''''...'''''''''''''''''',,;;;;;;;;;;;;;;;::
''...............................................                ....                                 ..,;,,'''''''''''''''''''''',,,;::::::ccccc::::;
''........................   ..  .  ...........                  .''.  ..  .                          ..,:;,,,,''''''''''''''''''','.,::::::::::::::::
'''..''..  ...''.......            ...... .....        .  .      .''.                                 ..'::,,,,,''''''''''''''''''','':::::ccc:cccc:::
..''''''..',''''.'....              ..    ......      ....       .''.                            ......';cc::;;,,'''''''''''''''''','.;c::ccccccccc:::
........'..''........       ....'''....,...   ...    ......      .,,.                       ..';:clloodddxxxdddolcc:;;,,''''''''''','.,c::ccccccccc:::
.............. .....      .,;codxkkdolx0kdl;'.....  .....        .,,.                   .',:cloddddddoollloodxxxdddxxdooc:;,'''''''',.':::::ccc::::;;:
..........'...           .;ccloxkOO000KXXXK0xl'............      .,,.                .';lodddooollcc:;'....,:looooooddxxkxdol:,''''',.':c:::cccc::;;;:
'''''.....'..            .,::clldxkO0KKXXXXKKOl............      .,,.              .':loollccc:;,''''..     .:lllllooooddxxkkxdc:;,,,'':c:ccccccc:;;;;
''''.''............     ..,;:clloxkkO00KXXXKK0o'..........       .,,.            .';cccc:;;,,'...  ....     .;cllllllllllooddxdoc:;;;,';cc:::cccccc::c
'''...........''.....   .',:looodxkOOO0KKKKKK0o'...........      .;,.          .';:cc::;,'....       .......,:llclllllccc:::::;'....,;,;c::cccccc:::::
'''''''..............  ..'',;:clodkOOO0KKKKK0Oc............      .;,.        ..,:ccc::;,'....          ...,;::c:::ccc:;,'....'..    .,;:ccccccccc::cc:
,,,,,,,''.''',,'..... ..........',cxkdllloxxkkl............      .;,.       .,:lllc:::;,'...            ..',;;;;;;;;,'..    ....    .:loolccccccccclol
',,',,,,,,,,,,,,''.....''...';::..;xOdc,',codko,,.               .;,.     ..'clllc::::;;,'...          ...,;;;;,,''...       ......,:oxkkxolcccccccccc
.............''........',;;:looc'.lO0OxdodxxOOdxd.               .;,.    .',:llcc:::::;;;;,'..........'',;::::;;,'..           ..';codxxkkkdlcccc::c:;
..'.        .''..'''.....,;cool;',oO0OOOO0000Oxxd' . ....        .:,.   .':clllcc:::::cc::::;;;,,;:::::::cccccc:;'..            .,coddxxxkOkdlccccclol
'','''.....',;,,,,;,......';cl:,;:oO0000000OOOOOo'.........      .c;.  .':lollc::::::::;'...';:c::ccccccloooddoolc;'...      ...;coddddxxxkOOxocccclol
;,''','',,,,,,,;,,,;,'.....,::'...;ddxkO00Okxxko,','.            'c;....';:cc:;;,,',;;,.     .;clccclodkOOkkxddddoolc:;;,;;;::cloodddddxxxkkOOxoccclll
;;,,,,,,,''',,,,,,'''......,;;;,'':odxkkOOkko,...';,.            'c;.....',,,''.....','.     .,lollldO0K0xl;'....';codddoooodddddooooddxxxxkkOkxocccll
.',,,;;,,'',,,,,,''''......''',,;codkkkkkkkx:....,;,;.           'c;...........     ..''.   .':ooooxOKKkl'.         .:dkkxdddddoooddddddxxxxkOOOxlccll
....'','''',,,,;,,,,''.....''..',;::cldxkkxl,......''.           ':'.. ......         ..''',;:lllodOK0x;.             ,okOxddddooddddxxdddddxk0KOxlcll
'::'............;,'...........',:clodxxxxxl'......'''.          .';..  ......           ..',::cccox0Kk:.               ,dOOxddooddddddddoolcclx0KOdlll
;kx;...........,xx;..........':loodxxxxxxkc..;l;..'',.......   ..'..   .......           ..';:ccclx00x;                .cxOxdollllc:;;;::;'...'lxxdlll
:kd'...........;kx,....... ...;ldxkkkxxkOk;..cd:..'','..'',. .....     ..''..............',;::cccldO0x;                 ;dkxl:;;,'.....'''.    .;lllll
lOo............:kd'........   .';:lddxkOOx,..:d:..'','..','......       .,;;;,,,,,,,,,;;;:::::ccccldOkl.                ,lol;'...      .''.    .:lllll
oOl............cOo.............':ldxkkkOOk;..cd;..'','''','....         .,::::::;;::::::::::::ccllcldkxc.              .;cc;..          ..''..,lxkxoll
xOl............;c'.''.....'',;:coolllcclccc;,cd;..'','''','..            .;cccc:::::::::::::::ccccccloxxl;.          .,cll:'.             .';cox0KOxol
kOc....'''...      ....';;;::colcloxxl:dkdc;'';' .'','.'''..             .,:clcc:::::::::::::::ccccccloxxkxo:'....',codxdl:,...           .,:ldk0KOxol
Ok:........            ..'',:clclxxol:,',c;....  .'','.....               .';clcc:::::::::::::::::::::cldxkOOkxdddxxkkxdolc:;,'.........',:lodxk00kdll
kd,.......                   ..''','...  ......  .'','.''.                 ..;cccc:::::;;;;,,'',,,'....,:looooddxxxdddooooollcc:::clloooooddddxO0Oxoll
..........                     ..  ........ .'.  .'',,''..                   .;cc::;;;,,''.........     .:loolllloooooooooooolllllloddxxxddddxO00Oxoll
  ............................ ...  ........'.. ...''....                     .,;:;,''....    ....      .,cloooooooolllcccllc:;,;:cooodddxxxxk0K0kdlll
  ...................................................                          .',,'...        ....    .';cllllllcc:;;''',;;,..  .'clooddxxkkO00kdolll
   ......................                     .....                             ......           .....',:ccc:::;;,'.......,,.     .,lodddxxkO00kxollll
     ....................                       .                                 ....             ..',::::;,,'....      .',..    .;loddddxkOOkdolllll
    ...........     ...,'..   .                                                     .....          ..',;;;,,'....         ..'.....;codddxk000kdollllll
      ........       ..,,...''.',,,,'',;,,'...                                        ...'''''....'',;;;;;,'....            .',;:cloddxk0KKOxdllllllll
.....  .......      ...........''''',,;::c:,..                                         ..,;ccccc::::::::::;,''...           ..,cloodxO0KK0koccllllllll
....                  ..... .....   .........                                            ..',,;,,,,,,,'''''.........       ...',;;;:clllc:,..',,,,,,,,
        ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n---Press Enter to continue---");
        

        // Wait for user to press Enter
        Console.ReadLine();

        // Clear the console
        Console.Clear();

        string textScene1Part3 = "\nMorpheus breaks free and is about to jump from the window to the chopper, but before he can do it, Agent Smith, who was not previously in the scene, opens a door and shoot Morpheus right in his leg.\r\n\nIt doesn't seem like he'll be able to jump.";

        TypeTextLetterByLetter(textScene1Part3, delayMilliseconds, true);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\n---What do you do?---\n");
        Console.ForegroundColor = ConsoleColor.White;

        MakeChoiceOne();

    }

    static void TypeTextLetterByLetter(string text, int delayMilliseconds, bool allowSkip)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (allowSkip && Console.KeyAvailable)
            {
                // If the user presses Enter, skip the animation and display the entire text immediately.
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.Write(text.Substring(i)); // Display the remaining text.
                    return; // Exit the loop.
                }
            }

            Console.Write(text[i]);
            Thread.Sleep(delayMilliseconds);
        }
    }

    static void MakeChoiceOne()
    {
        int delayMilliseconds = 5;
        Console.WriteLine("a) Believe he'll make it and wait for it. He's Morpheus, godammit! He can handle it!\n\nb) Try to give Morpheus some coverage, shooting at the same direction he's coming from.\n\nc) Since you're tied to the chopper, you jump into Morpheus's direction to grab him mid-air.\n");
        string input = Console.ReadLine().ToLower();

        if (input == "a")
        {
            // Clear the console
            Console.Clear();

            string oneA = "\nYou sit and wait while Morpheus loses momentum after the shot. He's got not enough speed and not enough strength.\r\nThen you see him slowly fall into the abysm between the skyscraper and the helicopter... He's now dead! You failed! \n";

            TypeTextLetterByLetter(oneA, delayMilliseconds, true);
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                   _____          __  __ ______    ______      ________ _____  
                  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
                 | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
                 | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
                 | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
                  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
            ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (input == "b")
        {
            // Clear the console
            Console.Clear();

            string oneB = "\nIn a desperate attempt to cover Morpheus, you shoot in the same direction he's coming from... What a terrible idea!\r\nMorpheus didn't even make it to the jump, falling flat on the ground, dead, with multiple shots from your rotatory cannon.\n";

            TypeTextLetterByLetter(oneB, delayMilliseconds, true);
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                   _____          __  __ ______    ______      ________ _____  
                  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
                 | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
                 | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
                 | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
                  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
             ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (input == "c")
        {
            // Clear the console
            Console.Clear();

            string oneC = "\nAs soon as you jump, your body reaches Morpheus, and after almost falling, you're able to hold his hand!\n";

            TypeTextLetterByLetter(oneC, delayMilliseconds, true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
..'''',,,;;::cdkO00OOOOOOOOOOOOOOOOkkkkkkkkkkkkkkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOkd:,..... ........''',,;
.......',;::ldk000OOOOOOOOOOOOOOOOOOkkkkkkkkkkkkkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO0Oko:,..............'',;
      ...,:cok0000OOOOOOOOOOOOOOOOOOOOOkkkkkkkkkkkkkkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO0Okd:,''.''........',;
....  ....,:dOK0000OOOOOOOOOOOOOOOOOOOOOOOOOkkkkkkkkkkkkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO000koc;,''.........',
...........,cx0K0000OOOOOOkOOOOOOOOOOOOOOOOOkkkkkkkkkkkkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO000ko:,''..........
'.........'',:dO00000OOOOOOOOOOOOOOOOOOOOOOkkkkkkkkkkkkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO000xc;''..........
''........'',;cx0K0000OOOOOOOOOOOOOOOOOOOOOOOkkkkkkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO00Odc;,'..........
'..........'',;cxO00000OOOOOOOOOOOOOOOOOOOOOOOkkkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO0Okl:;,'..........
.............',;:ok00000OOOOOOOOOOOOOOOOOOOOOOOOOkkOOOOOOkkxxxxkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOkdc;,'...........
,'............'',;:oxO000OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOkxdooooooooddddddxxxkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOkdc:;,...     ....
,.............'',,;;:lxkO000OOOOOOOOOOOOOOOOOOOOOOkkkkxdolccccc:;;::cccccclllllooddxxkkkxdddxkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOdc;,,'........... 
'................'',,;:coxkO00000OOOOOOOOOOOOOOOOkkkkxdolc::::;'.',;;;;;;;::::::ccccclllcccclodddddxxkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOxl;''.....'',''''..
'....................',,;:coxkOO00000OOOOOOOOOOkxxxkkxdol:;;;;;,..,;:::;;;;;;;:::::::::;;;;:::::cclllllldxkOOOOOOkkkkkkkkkOOOOOOOOxc;'....  ..........
'...''..................'',;;:codxkO00OOOOOOOOkxdodkOxdolc:;;;;,',:cccc::;;,,,;;;;;;;;;;;;;;;,,,;;;;;,,;:ldkOOOkkkkkkkkkkkkkOOOOOxl:,....             
,,'.......           ......''',,;:coxkOOOOOOOOkxoldkOkdolc:;;,,,;loolc::;;;,,,,,;;;,,,,,,'....''''..'',,;cdkOOOOOkkkkkkkkkkkOOOOko:,'...              
::;,'...                ........'',;;:lxkOOkOOOxllokOkdlc::;,'',cdxdl:;;;,,,,,'',,;;;;,,'...........'',;;:ldkkkkOOkkkkkkkkkkOOOkdc,'...               
cccc:;'..                 .........'.'',cdkkkOOxoloxOkdl:;;;,'.'ckkdl:;;,,,,,,'..',;::;'......   ....',,;;:cclodxxkkkkkkkkkOOOkxl:,'.....             
ccccc::;,'...                 ...........:dxdkOxolldOOxoc;;,,'..:x0ko:;,;;;;;,'...';cc;...''.    ...''',,,;;;;:ccloddxxkkOOOOOko:,'........           
ccc:::cc::;,'......                 .....cdoldkkolcokOxl:;,,''..'oO0kl:;,;;;;;,'...;c:'.,:;.    ..''''',,,,,,;;;;:::ccloddxkkkd:'....  .....          
ccc:::::cc::;,,''...        . .        .;oxoclxkdlllxOko:;;,,,'..,d00xl:;,,;;;,'..'::,';cc,.   ..',,,,,,,,,,,,,,,,;;;;;::cclll:,'...    .....         
ccc::::::cc:::::;,..  ...              'lxkdccoxdolcdOOd:;;;;;;,'.;x0Oxl;,,,,,,''';:,',cl;.   ..',;;;,,,,,,,,,'''',,,,,;;;;;,.....        ...         
ccccc::::c::::::c:;'.....    ..       .:dkxo:;:lolc:cdOkl:;;;:;;,''ck0Odc;,,,,,'',;,.':c;.    .',;;;;;;;;,,,,,'''''''',,,,,'.                         
olcccc:::c:::;::cccc:,'.......      ..:oxxoc:;,;;;;,;cxkxl:;;:::;,',ck0ko:,,,,,,,;;'.,::.    ..,;;;;,,,,,,,,,,''''''''',,'..                          
;lllcccccccc:;;;:cllc::;,'..       .':oxkdc;;,,,;,,,,;lkkxl:;;::::,''ckOxc;,,,,,;:,..,:,.   ..',;;;;;;;,,,,,,,,,,,,,,,'''.                            
 .:lllccccccc::;;;:cccc:;,..      .,coxkkxc;,,,,,;,,,,;okkdl:;;::c:,',oOkdc:;,,;::,.,;,.   ..',;;:ccccc::;;,,,,,,,,,,,''.                             
  ..;cllllclllc:;;;:cccc:,..     .,ldxxkOkl;,,,,,,;,,,,;okkoc;;::cc:,':xOkdolc:coc,;lc,.   ..';cloooooolc::;;;,,,,,,,,'.                              
     .:ooollllllc::;:cccc:,.    .,oxxxxxOko:,,,,',;;,,,,;lkxo:;;::cc:,':dkxddolloc;lxo,   ..';ldxxxdoolllcc::::;;,,,,'.                               
   ..'coooddoooollcc:::ccc:,.   .cxxdoodkkdc;,,,'',;;,,,,;lxxl:;;:::::,';dxxxooooc;ldl.   ..,:dkkxxddoolllcccc:::::;'.                                
....,lxdodkkxxddooollcccclc:,.  'oxdl:;lkOxl;,,,''',;;,,,,,lxdl:;;::::;''cxkkdool:;;;'.   ..':okkxxdddoooollcccccc:,.                                .
...,cxkddxkkkkkxxdddoollllllc,. .lxdl;,cxkxo:;,,,'',;;;;,,';ldoc;;;;;;;;,;oxxxddoc::'.     .',cdkkxxddooooollllllc;.                                  
.';lxkkxdxkkkkkkkkxxxddooolllc,..,ldl:;lxkxdc;,,,'',;:;;;,,,;looc;;;,,;;;;:coddooll:'.     ..';oxkxxxdddoooolllll:'.                                  
':oxkkkxxxxxxxxxxxxkkxxxddolllc:,',colldkkxdo:,,,''';;;;;;,',;cllc;,,,,;;;;:clolllc,..     ...,:dxkxxxxdddooooooc'.                                   
cdkkkkkxxxxxxxxxxxxxxxxxxxxdoollc,.,looxkxxxdc;,,''';;;;;;;,,,;:cc:;,,,,;;;::lllcc;............;lxxxkxxxxxddoool,.                                    
xkkxxxxxxxxxxxxxxxxxxxxxxxxxxddolc;;ldooxxxkxo:,,''',;;;;;;,,,,;;::;,,,,,,;;;::::;'...........',cdxxxkxxxxxxddl;.                                     
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxdolclddlldxkkdc;,'''',;;;;;;,,,,;::;,,,,,,,,,;:::;'........';c:;codxxxxxkkkkxd:.                                      
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxdodxxo::lxkxo:,'''',;;;;;,,,,,,;::;,,,,,,,,,;::;'....''',coxdoloddxxxxxkkkdc.                                       
dxxxxxxxxxxxxxxdxxxxxxxxxxxxxxxxxxxxxxxdl;,:oxdc;,''',,:c:;,,,,,,,,,,''''''''',:c:,'.''',;coxxxdooddxxxxxkkxc.                                        
dxxxxxxxxxxxddddddddddddddddddxddddddxxddl,.':ll:;,'',;ldoc;;,,,,,,,,,,,''''';cll:;,;;;:cldddddddooooddxxxdc.                                         
ddddddddddddddddddddddddddddddddddddddddddl,...''......,clcc:::::::;;,,,,;;::cdxoccloooddddddddddddolloodo:.                                          
dddddddddddddddddddddddddddddddddddddddddxdl;'............''',,,;;;::cclooooolllllodddddddddddddddddddol:,.                                           
ddddddddddddddddddddddddddddddddddddddddddddolc:;;;;;;;;;;;:::ccccloodddddoolccccloddddddddddoddddddddoc,..                                           
ddddddddddddddddddddddddddddddddddddddddddddddddddooooooddddddddddddddddddoolcllcclodddooooooooooddddoc,..                                            
ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddoooloollcoooooooooooooodddoc;...                                            
oddddddddddddddddddddddddddddddoooooooooddddddddddddddddddddddddddooodooooddddollllloooooooooooooddoc,...                                             
ldddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddolllooddddddddddddddol;'...                                             
            ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---Press Enter to continue---");

            // Wait for user to press Enter
            Console.ReadLine();

            // Clear the console
            Console.Clear();

            string textScene2 = "\nYou won't be able to hold Morpheus for too long.\r\nTrinity quickly got the helicopter out of the scene, but some of the bullets fired by Agent Smith hit the fuel tank, making the chopper pour a severe amount of gasoline.";

            TypeTextLetterByLetter(textScene2, delayMilliseconds, true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n---What do you do?---\n");
            Console.ForegroundColor = ConsoleColor.White;

            MakeChoiceTwo();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Try again.\n");
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(2000);
            
            Console.Clear();
            
            string textScene1Part3 = "\nMorpheus breaks free and is about to jump from the window to the chopper, but before he can do it, Agent Smith, who was not previously in the scene, opens a door and shoot Morpheus right in his leg.\r\n\nIt doesn't seem like he'll be able to jump.";

            TypeTextLetterByLetter(textScene1Part3, delayMilliseconds, true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n---What do you do?---\n");
            Console.ForegroundColor = ConsoleColor.White;

            MakeChoiceOne();
        }
    }

    static void MakeChoiceTwo()
    {
        int delayMilliseconds = 5;
        Console.WriteLine("a) Aim at the next skyscraper to drop Morpheus on the rooftop. He's Morpheus, goddammit! He can handle it!\n\nb) Keep holding Morpheus as long as you can. If you fall, you'll fall together!\n");
        string input = Console.ReadLine().ToLower();

        if (input == "a")
        {
            // Clear the console
            Console.Clear();

            string twoA = "\nYou drop Morpheus from a pretty high altitude, but he can roll his body as soon as he touches the ground with his feet. He's now safe!\n";

            TypeTextLetterByLetter(twoA, delayMilliseconds, true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWOodKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd,;kMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd,;OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk:.'dWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKc'..lNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk;'..cXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXo'...:XMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0:''..oNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWd,''';OMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMWNNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWXkkNMMMMMMMMMMKc....cKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMN0xlc;,,cdKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNkl;,dNMMMMMMMMWXd'....lXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMWOl,.     ..':OWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd...'OMMMMMMMMNk:.....;OWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMKl.     ....';:oKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWO,.  .:KXXXXNWNx'......oNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
W0:...........':lox,WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXl......;;,,;:cc'......,kMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
No........','',cdddoxKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0;..'''''..............cKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
Wx,'''..';ooolcoxkxdookKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0:.'''......   ...... .;ONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MKc'''''':dxxxkkOOkkxdoOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNx,........     ...   .':lx0XWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MWO:''''':dOkxkOOkkxxxxKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN0o'.........    ....,;clllloxKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMWOl,''''cxkkkkkOOkkkONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0o;'. .........  .  .:lloddddddkNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMNOc,';lxkkkkxkkkkxk0Oxlc:cldk0XNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMWKxolllc...........    .;llloddxkxdlo0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMNklldxxxxxdolc:;'..       ..',:loddkOKNWMMMMMMMMMMMMMMMWNKOxlccll:'.  .......    .,looodddxxxc. .;kNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMW0dddolc;'....           ............,cldxO000KXNWWXKOxoc:;:clc,.      .... ..  .:lodxxddxo:'.  ..:dOXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMM0l;,...          ...............    ...........,loc::::;;:cxKX0d;.   .,'.......'codxxxdl:,.......  .,lkXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMXo'.            .................         .        ...';cox0NMMMMN0xxOKX0xl:,....,:::;,'......''...  ...,ckXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMNk;.           .....................      .,,........';cokKNWMMMMMMMMMMMMMMMWNX0Oxdolc:;;;:ccclolc,..........,lx0NMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMW0l.         .......................',.     'kNXK000KKXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWNNWWWWWWWWNKOxoc;'.......;oOKK00O0KXNWWMMMMMMMMMMMMMMMMMM
MWXo'..       ............................      ,xXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOxo:,'....'''.....',cKMMMMMMMMMMMMMMMMMM
MXl.....      ...............................    .lXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKOxl:,'.........;0MMMMMMMMMMMMMMMMMM
MXl.....      ....''............................  ;KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNKkdl:;'....:k0KXNNWMMMMMMMMMMMM
MWx'....      .. ..'............................. .;dKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNKOxocccccccccccNMMMMMMMMMM
MMK:.....         .... .........................   ..oXMMMMMMMMMMMMMWNX0kkxxxxxxxddoodxxxdddxO0KXXNNNWWWWWMMMMMMMMMMMMMMMMMMMMWNOl,,,,,;;;cOWMMMMMMMMM
MMNo......        ...    .......................   ...,:lookNMMMMNOl;'..                    ....',,;;;;:::::clldOKNNNNWMMMWX0xl;...',,;cc:coONMMMMMMMM
MMMO,....         ..   ......................... .,:;.     .cKNKx:.             ....................... .........';;;:clooc,.......',;:cldkkkXMMMMMMMM
MMMWOc.                 ..........................'.     .....,..   ..  ...................................',clcc:::::;'........'''',;co0WMWWWMMMMMMMM
MMMMM0,               .   ........             ...        ..    .    .....................................'::ccloc;;;;;:cc;'''',;codkOKWMMMMMMMMMMMMMM
MMMMWx.          ..    ..........             ....       ..         ...................................'''',,,,;;;,,,,'',;,'''';o0WMMMMMMMMMMMMMMMMMMM
MMMMXc.          ....  ..............        .''.          ..      .....................'',;:coddxxxkkOO0000000KKKKKK00Okxdolox0NMMMMMMMMMMMMMMMMMMMMM
MMMM0;          ..,'...................  ..';c:,.      .   ...... .................':oxkO0KNNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMMMMMMMMMMMMMMMMMMMMMMM
MMMMO'          .:c;'....................';;,::,.      ........... ...............,dXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
            ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---Press Enter to continue---");

            // Wait for user to press Enter
            Console.ReadLine();

            // Clear the console
            Console.Clear();

            string textScene3Part1 = "\nAlthough Morpheus is safe, now you find yourself hanging from a falling helicopter.\r\n\r\nThe chopper is systematically failing, but Trinity manages to land you atop another building.\n";

            TypeTextLetterByLetter(textScene3Part1, delayMilliseconds, true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
ooooooooooolooooooollccc::::;;,;;;;,,,,,,,,,,,,,,,,,,,;;;,,,,,,,,,,,,,;;;,,,,'',;;,,,,;,,,;;;;;;;;;;;;;;;;,,,;;;;;;;;;;;,,,,;;,,;;,,,,,,,,;;;;;;;;;:cc
oooooooooollooooooooollllllllcclllllcccccccccccc::::::;;;;;;;,,,,,,,,;;'...   .;ool:;,,,,,,,,,,;,,,,,,,,,,,,,;;;;;;,,,,,,,,,,;,,,;;;;;::::ccclllllcloo
ooooooooollooooooooooooooooooloooooooooooooooooolooooolllcc:::;;;;;,,,.. ..  .:x0K0ko:,,',,,,,,,,,,,,,,,,,,,,;;;;;;;;;;;;;:::cc:cllllloooooooooooolloo
oooooooolloooooooooooooooooollooooooooooooooooooooddddddddoooolllccc;..  ....,dO0K0OOkdoc;,,,;,,;;;;;;;;;;;,,;::::::ccccclllooollodddddddoooooooooolod
ooooooolllllllllllooooooooolllloooooooooooooooolloooooooooooooooooooc.      .,lxOOOOO00Oxlccccccccccccclllllclooooooooodddddddddlooooooooooooooooollld
oooooolclolllllllllllllllollloooooooooooooooooollooooooooooooooodddoo,       .'lxkOO000OOkxdooooooooooooddddoodddddddddddddddxddoloooooooooooooolllllo
oooooolloooooooooolllllooolloooooooooooooooooolloooooooooooooooodddodl'      ..:oxkkkOOOO0Oo:::clodddddoddooooddddddddddddddddddolooooooooooooooooooll
ooooollooooooooooollooloollooooooooooooooooooollooooooodddddddddddooddo;.   .cxxxxxdxxkkxl;,,,,,,:lddddddooooodddddddddddddddddddolooooooooooooooooool
ooooolooooooooooooooooooolooooooooooooooooooolloooooooooooooooooddolddddo:;,;:coxkxxdxxx:'.'',,,'',cdddddoooolodddddddddddddxxdddolooooooooooooooooooo
oooolloooooooooooooooooollooooooooooooooooollllooooooooooooooooooollddddddddo;.'cdkOOOOkc'''''''...,codddoooolodddddddddddddxdddxdlooooooooooooooooooo
olllloooooooooooooooooollooooooooooooooooooollloooooooooooooooooooloddddddddl'.,ldxkO00x:'',,''.....';cddddoollddoddddddddddddddddlloooooooooooooooooo
ollllollloooooooooooooollooooooooooooooooooollooooooooooooooooooooloddddddlc' .,okkOOOxc''',,,,,'.....,cdddddllodddddddddddddooooolllooooooooooooooooo
olloooooooooooooooooooolooooooooooooooooooooloooooooooooooooooooollodddddo'.....';cclc;''''',,,,,......;oddddoodddddddddddddddddooollooooooooodddddooo
olloooooooooooooooooooooooooooooooooooooooollodoooooooooooooooooolloddddo,   ..'''''''''''',,,,,,.......:odddolodddddddddddddddddoolloooooooodddddddoo
lloooooooooooooooolcc:cloodddoooooooooooooolooooooooooooodddooooolloodddc.....'',;,,''''''',,,,''.......'cdddolodddddddddddddddddddolloooooooddddddooo
ooooooooooooooooc;,,'.';:clooodddooooooooooloddooooooooddddoooooollooddo,..'',,,,;;;,,,,,,,,,,,''''.....':oxddlodddddddddddddddddddollooooooodddddoooo
dooooooooooooool:,''..,,,,,;::loodoollcc::::cllooooooodddddooooolloooddc. ..',,,,,,,,,,,,,,,,,,'''',' ..',lxxdolddddddddddddddddddddlcooooooooddddoooo
doooooooooooooooc;,..',,,,,,,,,;:::;,,,'''.''',;;:clooddddddoooollodddd:.  ..',,,,'..',,,,,,,,''''.,:...',cdxdolddddddddddddddddddddoloooooooooooooooo
ooooooooooooooooooc;;;,,'''''''''''''''''.''''''''',;:codddddooolldddddc.    ..''....''''''''','''.':,..',cdddoldddddddddddddddddddddllooooooooooooooo
ooooooooooooooooodollllcc::;''''''''''''..'''''''''''',,:clooddoloddddxc.    .....  .......'''''''..;c..',cdddolodddddddddddddddddoooolooooooooooooooo
dooooooooooooooodoloodddddoc;,,'',,,,,,,'',,,,,,,,,,''''',,;codoodddxxxo.    .....  ......''''''''..:o,.';ldddoloddddddddddddddddddooolloooooooooooooo
oooooooooooooooodolodddddddc;,,,,,,,,;,,'',,,,,,,,,,,,,,,,,,,cooodddxxxx;    ....    ....''''',,''..'c,.':oddooloddddddddddddddddddooolloooooooooooood
oooooooooooooooooloddddddddl:,,,,,,,;;;,',,,,,,,,,,,,,,,,,,,,;cooxxdxxxxo.   .... ......''''',::,.  ....':oddddllddoooodddddddddddddddoloooooddddddddd
oooooooooooooooolloodddddddl:,,,,,,,,,,',,,,,,,,,,,,,,;;;,,,,,,;codxxxxxx:.....'.. .......''',;'.  .;lol:ldddddllooooooooddddddddddddoollooodddddddddd
oooooooooddddooolllloooodddol:;,,,,,,,,',,,,,,,,,,,,,,;;,,,,,,'',;:lodxxkxc,'.''''. ...  ......   .ckO0Oo:oddddolododooddddddddddddddodllooooddddddddd
oooooooooooooollllllllcccloodol:;,,,,,',;,,,,,,''........'',,,'',,,;;:cldxxdl,'',,,'....','..    .cxxkOd,.,cdddolldddddddddddddooodddodolloooodddddddd
oooooooooolloollooodddollccclloooc:,,'',;::;,,'.............','',;;;,,,;;:cll:..',,,''.....      ;odol:'...':oddlldddddoooodddoooooooooollooooodddoood
oooooolllloooolloooooooddollc:cclool:,.'',,;;,'...''',,,''....'',,,,,,,;;;;;;,. ..',,,'.. ..,;;,:do,.........,cdllddddoooooooooooooooooooloooooooooood
ooooolclloooolloooooooooooooollc:ccll:,'''',:c:;,,....''''''....''''''',,,,,'.    ..',,'. ,oddddxd:...........'loldddoooooooooooooooooooolodddddddodod
oooolcclooooollooooooooooddddddoolccllll:;;,;:cccc;'''',,,,;,'.';:ccc:;;;;;;'.     ...',,,;:cloddddo:'.  ......coodddoooooooooooooooooooollddddddddddd
ooolcccloooollooooooooooddddddodddooc::lolc:;;;:clc,...'',,,,'.'codddddollcc,        ..'cxxllol:;:clooc'.......;loodoooooooodoooooooooooolcododddddddd
oolcccloooollloooooooooddddddoooddddlcc:codolc:;;:cc;'...'''''..;oddddxxxxl:.       .',,lxxdxd:'''',,:cc;'.....,:codooooodddddooooooooooooccoooooooood
olccclooooollooooooooooooooooooooooolodl::loddol:;;;;;'.....'...,ldddddoc:..     ...,ldlcoxdkxl;;,'',,,,,,'...',;;looooooooooooooooooooooocclooooooooo
l::llllllllclolllllllcclllllllloooooloddl:;codddol:;,,,,'.......'cdddo:.        ...'cddo::ldxdooollllc:;,,'. ...',,:looooooooooooooooooooolclooooooooo
l::cllllllccllllllllllllcccccccccccclooodo:;:lddddl:,,,,,'.......:ddc'        ....,ldddl;;cloooooooodddoll:'.  ..,,'':looooooooooooooooooolccooooooooo
ollclllllccllooooooooooooooloolll:;:loooooo:;:looool;,';c:'......,lc..       ...':lddool,,:looooooooooooodool;'...',,;cllllllllllllllllllllccllooooooo
ollllllllccllloooooooooooooooooool:;cloooool:,:looooc;,:ol:;'.............';:ccloodooool,':llllllllooooooooooool;..':cccllllllllllllllllllll:cllloollo
llllllllcclllllooooooooooollllllll;,;cloooool:,:cllolc;:llc:;,,'.. ....';loddddddooooooc,':llllllllllllllllllloool;',;:cllllllllllllccllllll:cloolllll
lllllllcccllllllllllllllllllllllll;,,;clllllll:,;cllllc;;;;::c:,'.....';looooooooolllllc,':llllllllllllllllllllloocccccclllllccccccccccccccl::llllllll
lccccccccclccccccccccccccccccccclc:;;;:cllllllc:;,;:ccc:;'',:c:,,..'''';clllllllllccccl:'':lllllllllllllllllllllll::cllllllllccccccccccccccc:;:llllccl
lcccllccclllcccccccccccccccccccccccc;;:clllllllll:;;:::ccc:,,:c,;'...',,:lllccccccccccl:'':cllllllllllllllllllllll:;cllllllllllllllllllcccccc;:lllllll
lccclcccclllcccccccccccccccccccccccc:;;:cllllllllllccccclll:,,,'','.,;:::cccccccccccccc:',:cccccccccccccccclllllcl:;cllllllllllcclllllccccccc:;clllccl
lccclc:cllllcccccccccccccccccccc::cc:;;:cllllllllccccccllllc::,'..''';c:::ccccccccccccc:',ccccccccccccccccccccclllc;:cccccllllccccccccccccccc:;:cccccc
lcccc:cccccccccccccccccccccccccc::cc:;;:cccccccccccccllllll::cc:'....,;;:cccccccccccccc:';:cccccccccccccccccccccccc;;ccccccccccccccccccccccccc;;cccccc
lcccc:ccccccccccccccccccccccccc::ccc:;;;:cccccccccccllllllc::ccc:,....,:ccccccccccccccc;,;:cccccccccccccccccccccccc;;ccccccccccccccccccccccccc:;:ccccc
cccc::ccccccccccccccccccccccccc::cccc;,;:cccccccccccccccllc;:ccccc;'...,:ccccccccccccc:,,;:cccccccccccccccccccccccc;;ccccccccccccccccccccccccc:;;ccccc
ccc:::ccccc:cccccccccccccccccc:::ccc:;,;:ccccccccccccccccl:;:::ccc:;'. .;ccccccccccccc;',:ccccc:ccccccccccc:::::c::;;:ccccccccccccccccccccccccc;;:cccc
c::::::cccc::::::::::ccccccc:::;:::::;,,;:cccccccccc::;::c:;:::;:;;;;,..':ccccccccccc;'';:c::::::cccccc::::::::::::;,:ccccccccccccccccccccccccc:,:cccc
ccc::ccccccccccccccccccccccccc::ccccc:,;:ccccccccccc:,,;;:::::;;;:::c:'..;ccccccccccc;'',:ccccccccccccccccccccccccc:;:ccccccccccccccccccccccccc:;;cccc
            ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---Press Enter to continue---");

            // Wait for user to press Enter
            Console.ReadLine();

            // Clear the console
            Console.Clear();

            string textScene3Part2 = "\nYou realize you are still tied to the chopper, which is about to hit a building ahead, with Trinity inside.";

            TypeTextLetterByLetter(textScene3Part2, delayMilliseconds, true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n---What do you do?---\n");
            Console.ForegroundColor = ConsoleColor.White;

            MakeChoiceThree();
        }
        else if (input == "b")
        {
            // Clear the console
            Console.Clear();

            string twoB = "\nYou try to hold his hand, but the wind and the weight are too much for you.\r\nYou missed the timing on the skyscraper... your hands can't hold anymore... Morpheus falls, and now he's gone!\n";

            TypeTextLetterByLetter(twoB, delayMilliseconds, true);
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                   _____          __  __ ______    ______      ________ _____  
                  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
                 | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
                 | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
                 | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
                  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
             ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Try again.\n");
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(2000);

            Console.Clear();

            string textScene2 = "\nYou won't be able to hold Morpheus for too long.\r\nTrinity quickly got the helicopter out of the scene, but some of the bullets fired by Agent Smith hit the fuel tank, making the chopper pour a severe amount of gasoline.";

            TypeTextLetterByLetter(textScene2, delayMilliseconds, true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n---What do you do?---\n");
            Console.ForegroundColor = ConsoleColor.White;

            MakeChoiceTwo();
        }
    }

    static void MakeChoiceThree()
    {
        int delayMilliseconds = 5;
        Console.WriteLine("a) Untie yourself as quickly as possible and hope for the best with Trinity.\n\nb) Hold tight to the rope, believing Trinity will somehow manage to leave the chopper.\n\nc) Give a chance to the rumors that you're the chosen one, and try to hold the helicopter in the air with the power of your mind.\n");
        string input = Console.ReadLine().ToLower();

        if (input == "a")
        {
            // Clear the console
            Console.Clear();

            string threeA = "\nYou quickly release yourself from the ropes.\r\nAfter a short moment, you look up and see Trinity trying to jump off the Helicopter, but there's nothing that can help her.\r\n\r\nYou're safe... and she's dead.\n";

            TypeTextLetterByLetter(threeA, delayMilliseconds, true);
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                   _____          __  __ ______    ______      ________ _____  
                  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
                 | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
                 | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
                 | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
                  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
            ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (input == "c")
        {
            // Clear the console
            Console.Clear();

            string threeB = "\nWith your hands, you squeeze the side of your head tight, firmly focusing the chopper and repeating to yourself: \"Stop! Stop! Stop!\"\r\n\r\nBut nothing happens...\r\nAnd because you're still tied, your body is dragged by the helicopter.\r\n\r\nYou and Trinity die in a massive crash against the building.\n";

            TypeTextLetterByLetter(threeB, delayMilliseconds, true);
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                   _____          __  __ ______    ______      ________ _____  
                  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
                 | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
                 | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
                 | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
                  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
             ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (input == "b")
        {
            // Clear the console
            Console.Clear();

            string threeC = "\nYou wrap your arm around the rope and hold it tight.\r\nAt the same time, Trinity was able to reach the backseat, destroy the base of the rope tied to the helicopter with a gunshot, and jump off holding the rope... which you were holding tight from the other side, from the edge of the building!\r\n\r\nThe chopper hits the other building ahead, causing a massive explosion, but incredibly, you're both alive! Hanging on each side of the rope.\n";

            TypeTextLetterByLetter(threeC, delayMilliseconds, true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
ddddxxocodoodkxddddddooodxxdxxxdddxxxxxxxxdddxxddxddxkxxkkOOkxxxOOOkkkOOOOOkdco::kOO0KXXXXK000OOOOOdcxOOkOkkkkkxoxOOkkkkkkkkkkkkkOkkkkkkkkkOOOOOOOOOO0
kxdxkxccdxxddxxxdxxxxxxxxkkxxkxddxOO00OOkkkkkkkkkOOkkOkkO000OOO000KKKKKKKK0Oxld::0KKXNNNNNNXXKKK000dlkK0000O000OkO00OOOOO00OOOOOOOOOOO0000OOO00O00000K
OkkkkkxkOOOkxxxkkkkkkkkkkkkkkkOOO0000000000OOOO0000OOO00000KKKKXXXNNNNNNNXK0kd::;WWWWWWWWWWWWWNXXXKKKKKKK00KKKKKKKKK00KK0KKK0000K0000KKKKKK00KK00KK0KX
0OOOOOkkOOkkdddkkkkkkkxkkkkO00KXXK00O00KK0OOOOOOO00OO00000KXXXXNWWWWWWWWNNNKOx::NWWWWWWWWWWMMWWNNXKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK0000KKX
OkOOOOOOOOOkkxkkkOOxxxddkkkOO0KOkkOOOOO00000OOOOO00000KKKKKXNNWWWWWWWWWWWWNX0k::WWWWWWWWWWWMMWWWNXKKKKKKKKKKKKKKKKK000KKKKKKKKK0KK000KK000KKKK00000KKX
OOOOOOOOOOOkkOOOOOkxxxxxxxxkOOOocdO000OOOOOOOO0000KXXXXXXXKKKXNWWWWWWWWWWWNX0::;WWWWWWWWWWWWWWWWWNXKKKKKKKKKKKKK00000000KK000000000000000000OOO000000K
0OOOOOO00OOOOOOOOOOkkkxdxkkOOOkkkkO00O0OOO00000KXXNNNNNXNNXKKXNNWWWWWWWWWWNX0::WWWWWWWWWWWWWWWWWWNXKKKKKK00KKKKKK000K000000000000O0000000OOOOOO000000K
0OOO0000000OOOOOOOOOkxddk0K0OkkkkOOOOO000KKKKKKKXNNNWWWWWNNXXNNNWWWWWWWWWWNX0::WWWWWWWWWWWWWWWNNNNXKK0KKK00KK0KK0000000000000O00000KKK0O00OOOOOO000O0K
OOOOO000000OOOOOOOOkkxxdxkOOOkkkkOOO00KXNNNXXKKKXNNNNWWWWWNNNNNNWWWWWWWWWWNK::;WWWWWWWWWWWNNNXXXXXK0KKKKK00000KK0000000000000000000000OOO000OOOOOOOO0K
0OO000000000000000OOOOOkkkkkkkkkkO00000XNNXKKKKKXNNNNWWWWNNNWNWWWWWWWWWWWWNN:;XWWWWWWWWWWWNNXXXXXKOk0KKK00000000000000000000000000000OOOO000OOOOOOOkOK
0OO000000KK00000000000000OkkkkkkO000000XXXXKKKXXXNNNWWWWNNNNWWWWWWWWWWWWWWX::;XNWWWWWWWWNNNNXXXXKK0000000000K0OO0000OO0000000000000000O000O00OOOOOOOOK
00000000000000000000000KXXXK00KKKKKK00KXXXKKXXXNNNNWWWWWWNNNWWWWWWWWWNNNWWX::;KNNNNNNNNNNNNNNNNXXKXKKKKKKKK000OO00000O00O00K000000000000000OOOO0OO000K
000000000000000000000KKKXNNXKKKXXXXXXKKXXXKKXXXNNNNWWWWWWWWWWWWWWNNNNNNNWN0::kKNNNXXXNNNWWWNNNNNNNXXKKKKKKKKK000000K00000000000000000000000000OOOOOOOK
0O0000000000000000KK0K000KKKKKKKKXXXNNNNNNNNXXNNNWWWWWWWWWWWWWNNNNNNNNWWNOl::o0NNNXXXNNWWWWWNNNNNXXKKKKKKKKK0000OO000OO00000000OO00000000000000OOOOOOK
0O00K00000000000OO000000OOO000KXXNNNNNWWWWWNNNNNNNNWWWWWWWWWWNNNNNWWWWWW0:..':kNWWNNWWWWWWWWWWNNNXXKKK0000000000KKK00OOO000000000000000000000OOOOOOOO0
000000000000000OOO000000KKKKXXXNWWWWNWWWWWWWWNNNNNNNNNNWWWWWNNXXNNWWWWWXl....'dXWWWWMMWWWWWWWWNNXXXKKKK000000000KKKKK0000000000000000000000000OOOOOOO0
0O00000000000OO000000KKXXNNNNNNWWWWWWWWWWWWWWWNNNXNNNNNNNNNNNNXXNNWWWWWXc ..'lkXWWWMMMWWWWWWWNNNXXXKKKKKKKKK00OO0KK000O000O0000000000000000OOOOOOOOOO0
OOOO00000OOOkkO00KKKKXXNNNNWWWNWWWWWWWWWWWWWWWWNXXXNNNNNNNXXXXNNNNKxlccl;';co0XNWWWWWWWWWWWWNNNXNXXKKKK00000OOO000OOkOOOOOOOO0000000000000OOOOOOOOOOO0
OOOOOO0OkddxkO0KKKKXXXXNNNNNNWWWWWWWWWWWWWWWWWWNXXXXNNXNNNNNNNNNNk,     .;lldONWWWWWWWWNNNNNNNXXNXXKKKKK0000OOOOO0O00OOOkkkOO0000000O000OOOOOOOOOOOOO0
OOOO00OxolokO0KXXXXNNXXKKXXNNNWWWWNNNWWWWWWWWWNXXXXXXNNNNNNNNWNKo.      .:llox0NWWWWWWNNNNNNNNNNXNXXXXXKK00000OOO000000OOOOOO0000000000000OOOOOOOOOOO0
OOO000kdodO00KXNNXKKKKKKKXXXNNWWWWNWWWWWWWWWWWNNXXXXXXXNNNNWWNk,        ':lldl,:ONWWWWNNNNNNNNNNNNNNNXXXKK000000O00000000OO0OO0000OOO00000O0OOOOOOOOO0
OO00K000O0KXXXXXXXXXXKKKKKXXNNWWWNNWWWWWWWWWWWNNXXXXXXXXNNWWN0;........';:lodd:'oXWWNNXXXNNNWWWNNNNNNXXXK00000OOOOO000000OO0000000OO000000OOOOOOOOOOO0
000KKKKKKXNNXXXXXXXXXKKKKKKKXNWWWWWWWWWWWWWWWNNNXXXXXXXNNNNWNO;';;'''',::;:clxkxxO00OxxkOKXNNWWNNNNNNXXNX00O0OOO0OOOO0000000000000000000OOOOOOOOOOOOO0
00KKXXXOkKNNNXXXXXXKK00000KXXNNNWWWWWWWWWWWNNNNNNXXXXXXXNNWWNNKOd:. ...;:,,,;coolloollllok0XNWWWNNNNNNNNXK0OOOO0OOOO0000000000000000000OOOOOOOOO0OOOO0
00KXXXNXKXXNNNXKKKKK000KKKKXXXNNNWWWWWWNNNNNNNNNNNNXXXNNNNWWWWWWN0o;. .::,'..,clllllcccclok0XNWWNNNNWWNNNXK000O000OOOOOO000O00OOOO00000OOO0OOOOO00OOO0
00KXXXNNXXXXXXXKKKXXK00KKKKXXXNNNNNWWWWWWWWWNNNNXXXXXXXNNNNNNWWWWWWXd,.::,'..';cllccc:;,,:oOXNWWWNNNNNNNXK000000000000000OOOOOOOO000000OOOOOOOOOOOOOO0
0KKXXXXXXXXXXXKKKXNXXX00KKKKXKKKXXNNWWWWWWNNNNXXXXXXXXXXXNNNNNNWWWWWWk:::;,,,,,;::::;,...'lkKNWNNNNNNNNXXK000000000OOO00000O00OOOO0OOOOOOkkOOOOOOO0000
00KKXKKKKKXXXKK0KXXKKXK000OOOOO000KXNNNNNNNXXXKKKKKKKXXXXXXNNNNNWWWWKd;'.....''''....    .:kKXNNNNNNXXXK000000000OOOO000000O000OOkOOkkkkkkkkOOkOOOO0KK
OO00KKKKKKKXXK0KKXKXXK00K0OxxkOOOOO00KKXKKKK0000000KKKKKKXXXNNNNNWWXx:.                   .;kXNNNXXKKKK000000000OOO000O00OOOO00OOOOkkkkkkOkkkxxxxkkkO0
kOOO0000KKKKXXXXKKXXNX00KK0kkOO0OOOOOO000000000OOOO0KKKKKKXXXXNNNNXkc'                    .l0XXXKKXKKK00000O0000O0000OO00OOOOOOOOOOOOOOkkOkkkkkkxkOkk0
0000000000KKKXXXXXKKKKXXXKK000OOOOOO000OO0000KKOOO000OkxxOKKKKXNWXkc,.                   .dKKXKKK0K00000000O00OO00OOOOOKK0OkxxkOOOkkOOOOOOkkkOOkxkOOO0
OO00OOO00000KXXXXNXKKKKXK0O00OOOOOOOOkOkkO0KKKK000O000kxdxO0KKXNXxc,.                  ..:OKKXKK0000000000OOOOOOOOOOOOO0000kxxkOkkkkkkkxxkOkkkxxkkOOO0
OOOOOO00000KKKXXXXXK000K0OOO0OOOOOOkkkkkOO000000OOOOO000OOO00KKXkc,.                    .,ok0KK0OOO0OOOOOOOOOO0OkOOO00OO0000OOkkkkkxxxxddxkkkkkkkkkkk0
kOOOOO00KKKKKKKKXXXKKKK0000O000OOOkkkkkOOOkkOOOOOOkkkO0OOOO0KKXKd;'.                      .l0XK0OOOOOkkOOOOOOOO0OOO000OOOkkkkkkxxkkkkkkxkxxkkxxxkkkkxk
kO0OOO00000000000KKKKKKXKK00OOOOkkkkOOkkOOOOOOkkkkkOOkkkkkkOKKXKd;.   .:c.                'dKXK0OOOOkkkOOOOkOOkOOkOO00OkkkxkkkkkkxkkkkxxxxxkOkxddxxddk
kkOkkOOO00OOOOO00OOOOO0000OOOOOOkkkkOOkkOkkkkkkkkkkkkkkkOkkOO0K0o'. ..,kd.     .          cKXKK0OkkkkkkkkkkkOkkkkkkOO0OkkxxkkxxxxddxkkkxkkkkOOkxdxxxdx
ddddxkkkkOOOkkkkkkxxkkkkOkkkkkOOOkkkkkkxxxxkxxxxkkkkkkO00OkOkkO0kl;:'.oKo.      .        .xXK00OOkkkkkkkkkOOOkkOOkkkOOOkkkkkkkkkxddxkkxxxxkxkkkxddddxk
ooddddddddxxdddddddxxkkkkkxxxkkkkkkkkkxxxxxxxxkkkkkkxxkOkkO0OkO0KKKx,:0Nk'              .;xKK00OOOkxxxkkkOOOkkkkOkkkkkkkkkkkkkkkxxxxxxxddddxddxxddoodk
ooddooooooooodddoddxxxxkkxxxxxkkxkkkxxxxxxxxddkkxxkkxxxxdxxkkO00KKO:,xNXx.             .lxxO000OOOkkxxkkkkkkkkkkkkkkkkkkkkkkkxxkxxdxxdddddxxddkOkxdook
llooooooooddoooodddxxddxxxxxxxxxxxxdxxxxxdddolcldxxxxxdddddxkOO00Ol'l0XO;            ..'dOllllk0Okkxkkkkkxxkkkkkkxxkkkxkkxkkkkkkkxxxxxxxxxxxdddxxxdodk
llooloooddddolooodddddddddxxddxxddxxddxddoollcccooddddddxddxkkkO0x,;kXXx'.           ....'..';okkOkkxxxxxxxxxxkkkxxxxxxxxxxxxxdxxdddxxdxxxxdddddxxxddk
lllllllooodddolodddooodddddddddddddddddooooolllooooddddxxddxxkkkx:.l0XX0c.. .        .      .;;;dOkkkkxxxxxxddxxdxxxxxxxxxxxxxdxxxddddddxddddddddooodk
ollloollooooooooddddoooddoooddooodddoooooddxxdddoodddddxkxxxkkkxc.,kXXNXo.                 ..;::dkxxkkxdddddxxxdodddxddxxxxxxxddddddddddxkdddooooooodx
lcclooooollccloddooddoooooooooooooooooddooddxdddoodkkxdxkkkkOOOo'.lKXNNXl.                .'cOKOkkxxkxxxdddddxddddddddxxxxxxddxdoooodddddxxddoooxdooox
lccllllooooloooollooooooodddoolllloolloooooooodddddxxxxxxkkO00k: .okkxkk:..              .':xXK0Okxddddxxxkkxdoooodddddddxdddddoooodxddxxdodoooodddoox
llclllcccllllooollloloooddddolllllooooooloooodddoddxxxxddolcc:,.  ....','.               .'ckK0OkxxddddodxOOxdooooooooooddddddddoooooooooooooolooooood
cllcccccclllllllcclllllloollolllloolllllooollool:;;;,'..... ..        ...                .'cO0Okkxxddddollodxxddoolloooooooooxxdooooollloooooollllllld
dOkolooddddoodddodxxddoodxdxxddddkOxddxxxxxddl:'..........                                'o0KK0OOOOkkxxxkk0K0kkkxxddxxxxxkkxkOOkkxxxxxxxxddxxxddddddk
            ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---Press Enter to continue---");

            // Wait for user to press Enter
            Console.ReadLine();

            // Clear the console
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n                                  Well done! Morpheus, Trinity, and Neo can continue their fight against the Matrix.\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXdc;,...,lodkKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNOc....    ....;ld0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNOc,..  ...       ....oXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNo. ..',;::;;colc:'..  .lNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMO' .;okO0XXKKXNNNXKkl,. .kWMMMMMMMMMMMMMMMMMMMWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMx..;dO0KXNNNWWWWWWNNXOc..;KMMMMMMMMMMMMMWX0OkkkkO0KNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWx..:xO00KXNNNNNNNNNNXKd, .kMMMMMMMMMMWXkollloodoooodkKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMk..;xO0KKXXXXNNNNNNNK0d' .xMMMMMMMMMNOl;:lodxxxxxddoookXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK;.,:ccodxOKKK0kkxdolol. 'OMMMMMMMMWOc;:coxxxxxkkkxdolcxNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMWNXKKKXNWMMMMMMMMMMMMMMMMMMMMMMMMMMMXl..     .'okc...    ...,oKMMMMMMMMNd,,;codxddxxxxxdlccoKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMWXOd;,,'';;:d0NMMMMMMMMMMMMMMMMMMMMMMMMXd;,.     'x0o.      .:lokXWMMMMMMMNo.',;:lolccccoddllclONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMXo'.......','..:OWMMMMMMMMMMMMMMMMMMMMMMXxoddolccldOXKkolccodOOkkOXWMMMMMMW0;..',,,:l;...';clolldkXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMW0;   .;oxkO00Ol' .dNMMMMMMMMMMMMMMMMMMMMMW0xdxO0KK0k0XXKXXNNXK0O0KKNMMMMMMMXc.   ..'cdl.  ..:ddlcldKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMK:  .,d0XNNNNXKOo,..dWMMMMMMMMMMMMMMMMMMMMMNOdoxk00kooxdx0KKX0OOOKNWMMMMMMMMNl    ..;oxxoccldxdoc:cdKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWd. .:k0KXXXXXK0kdc. 'OMMMMMMMMMMMMMMMMMMMMMMNOodkOOOxxxkOKKK00Ok0NMMMMMMMMMMWo. ....';clodxkxdol::oONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMX;  ,ldddxk0K0Odl:;. .oWMMMMMMMMMMMMMMMMMMMMMMXxodddodxxxxxxxOOkkKWMMMMMMMMMMMO'  ...,;cloxxxdolc:cxXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMK:.........:do,..    .oWMMMMMMMMMMMMMMMMMMMMMMNkllooooolodxxxxxxkKWMMMMMMMMMMMNl  ...';:ccloollcc:;,:kNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMW0d;',.     'dc.      .dNMMMMMMMMMMMMMMMMMMMMMMOcclldkOOOOOOkkxdxooKMMMMMMMMMMMMO,  ..';:cllllcc:;,,. .lNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMWXOoldoc,'';oOx;......;OWMMMMMMMMMMMMMMMMMMMMMNc .,:codxxxxddooo:..oWMMMMMMMMMMMXl. ..,:loolc:;,'',.   .dWMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWX0xodkOOOkxxdllddl;,dXMMMMMMMMMMMMMMMMMMMMMWk.   ..''..,cc:;'.   ,kWMMMMMMMWKx:.   ...,,;,'....'.     'kWMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWXdcodkO0Okxoclll:,oXWMMMMMMMMMMMMMMMMMMMMWk'       .',,'..       .lOXWMMNOc'               ....       ,xKNWMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMWOclxkkkxddoc;::;c0MMMMMMMMMMMMMMMMMMWKkl;.         ...            .';lo:.                             ..,lx0XNMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMNl;oxxkkkxdlc:::kNMMMMMMMMMMMMMMMN0x:.                                                                    ..';cdk0XWMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMWKxdolodkkxo:''xWMMMMMMMMMMMMMW0o;.                                               ...   ....                     .':lx0XWMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMM0:;llc;'...  .:KMMMMMMMMMMN0o;.                                                  .,.   ...                          ..'cxKNWMMMMMM
MMMMMMMMMMMMMMMMMMMNl  ..;c:,......oWMMMMMMNOo;.                                                          ...           ...    ......''......',cOWMMMM
MMMMMMMMMMMMMMMMMMNk'     .;llc;.  .oXWMNkl,.                                                                        ..',,'.  .,,;:;;c;.',,.    ,0MMMM
MMMMMMMMMMMMMMMN0o;.        ,od:.    .:oc.                                                                         ....,;;:;;,;:cllclo:',,.     .kMMMM
MMMMMMMMMWXK0xc,.           .:l,.                                                                                  ...,,,,;,,,,,;cc:c:;,,...    'OMMMM
MMMMMWKxc,'..               'cl,...                                                                               .'..,,;;,',,'..';;,,,,,'....  'OMMMM
MMMXd;.                    .;loooo:.                                                                              .,'';;;,,,'... .''.''',;,'... .oNMMM
MMK:                      .'codO0Od:.                                                                            .,;,,,,,''..',.  ......','...  .,OWMM
MK;   ...                  .cxO000kc.                                                                            .;:,,,,,''..''.    ........    ..oNMM
No.    .;;.                 'oO000k;                                                                             .,;,,;;,';,'''.    ....  ..      ;KMM
0,      .;:,.           ..  .:k0K0o.                                                                              ...',,,,;::;'.     .''.         ,OWM
x.       ...''..        .....;dOKO,                                                                                ....',',cc:'.     ..''.       .,kWM
x.           ..''.       .''.,ok0d.                                                                                       ..''.       ......     .'dNM
x.             .',.       ...'cxOl.                                                                                                   ...,;,..    .cXM
x'                           .'co;.                                                                                     ....           ..,,,'..    ,KM            
            ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n                                                                    THE END\n");

            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Try again.\n");
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(2000);

            Console.Clear();

            string textScene3Part2 = "\nYou realize you are still tied to the chopper, which is about to hit a building ahead, with Trinity inside.";

            TypeTextLetterByLetter(textScene3Part2, delayMilliseconds, true);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n---What do you do?---\n");
            Console.ForegroundColor = ConsoleColor.White;

            MakeChoiceThree();
        }
    }
}