﻿using System;

namespace LifeOfSybren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:'##:::::::'####:'########:'########:::::'#######::'########:::
: ##:::::::. ##:: ##.....:: ##.....:::::'##.... ##: ##.....::::
: ##:::::::: ##:: ##::::::: ##:::::::::: ##:::: ##: ##:::::::::
: ##:::::::: ##:: ######::: ######:::::: ##:::: ##: ######:::::
: ##:::::::: ##:: ##...:::: ##...::::::: ##:::: ##: ##...::::::
: ##:::::::: ##:: ##::::::: ##:::::::::: ##:::: ##: ##:::::::::
: ########:'####: ##::::::: ########::::. #######:: ##:::::::::
:........::....::..::::::::........::::::.......:::..::::::::::
::'######::'##:::'##:'########::'########::'########:'##::: ##:
:'##... ##:. ##:'##:: ##.... ##: ##.... ##: ##.....:: ###:: ##:
: ##:::..:::. ####::: ##:::: ##: ##:::: ##: ##::::::: ####: ##:
:. ######::::. ##:::: ########:: ########:: ######::: ## ## ##:
::..... ##:::: ##:::: ##.... ##: ##.. ##::: ##...:::: ##. ####:
:'##::: ##:::: ##:::: ##:::: ##: ##::. ##:: ##::::::: ##:. ###:
:. ######::::: ##:::: ########:: ##:::. ##: ########: ##::. ##:
::......::::::..:::::........:::..:::::..::........::..::::..::
                                                                 ");
            Console.WriteLine("Press 'enter' to start.");
            Console.ReadLine();
            Console.Clear();
            Game.Instance.ActOne();
        }
    }
}
