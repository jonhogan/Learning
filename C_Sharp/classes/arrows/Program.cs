﻿/*
 
                          /$$    /$$ /$$                                                                     
                         | $$   | $$|__/                                                                     
                         | $$   | $$ /$$ /$$$$$$$                                                            
                         |  $$ / $$/| $$| $$__  $$                                                           
                          \  $$ $$/ | $$| $$  \ $$                                                           
                           \  $$$/  | $$| $$  | $$                                                           
                            \  $/   | $$| $$  | $$                                                           
                             \_/    |__/|__/  |__/                                                           
                                                                                     
                                                                                     
                                                                                     
  /$$$$$$$$ /$$             /$$               /$$                          /$$       
 | $$_____/| $$            | $$              | $$                         | $/       
 | $$      | $$  /$$$$$$  /$$$$$$    /$$$$$$$| $$$$$$$   /$$$$$$   /$$$$$$|_//$$$$$$$
 | $$$$$   | $$ /$$__  $$|_  $$_/   /$$_____/| $$__  $$ /$$__  $$ /$$__  $$ /$$_____/
 | $$__/   | $$| $$$$$$$$  | $$    | $$      | $$  \ $$| $$$$$$$$| $$  \__/|  $$$$$$ 
 | $$      | $$| $$_____/  | $$ /$$| $$      | $$  | $$| $$_____/| $$       \____  $$
 | $$      | $$|  $$$$$$$  |  $$$$/|  $$$$$$$| $$  | $$|  $$$$$$$| $$       /$$$$$$$/
 |__/      |__/ \_______/   \___/   \_______/|__/  |__/ \_______/|__/      |_______/ 
                                                                                     
                                                                                     
                                                                                     
           /$$$$$$                                                                           
          /$$__  $$                                                                          
         | $$  \ $$  /$$$$$$   /$$$$$$   /$$$$$$  /$$  /$$  /$$  /$$$$$$$                    
         | $$$$$$$$ /$$__  $$ /$$__  $$ /$$__  $$| $$ | $$ | $$ /$$_____/                    
         | $$__  $$| $$  \__/| $$  \__/| $$  \ $$| $$ | $$ | $$|  $$$$$$                     
         | $$  | $$| $$      | $$      | $$  | $$| $$ | $$ | $$ \____  $$                    
         | $$  | $$| $$      | $$      |  $$$$$$/|  $$$$$/$$$$/ /$$$$$$$/                    
         |__/  |__/|__/      |__/       \______/  \_____/\___/ |_______/                     
                                                                                     
                                                                                     
                                                                                     
 Program to start learning OOP concepts in C#
 Create an arrow class, pass values for arrow head, shaft length and fletching
 Use these values to calculate the cost of the arrow
*/






enum ArrowHead {
    wood,
    obsidian,
    steel
}

enum Fletching{
    chicken,
    turkey,
    goose
}

class arrow{
    private string fletching;
    private string arrowHead;
    private double length;
    public arrow(){
            fletching = "chicken";
            arrowHead = "wood";
            length = 60.0;

        }

    public:

    
}