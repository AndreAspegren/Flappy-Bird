using System;
using System.Threading;

using Veldig_Flappy_Bird;

var game = new GameLogic();
var pipes = new Pipes();
var movement = 0;
var timer = 0;
Run(); 
void Run()
{
    Console.SetWindowSize(300, 300);
    while (true)
    {
        pipes.draw(movement, 20);
        if (timer % 5 == 0) pipes.addPipe(250);
        Thread.Sleep(200);
        movement--;
        pipes.gameTime--;
        timer++;
    }
}


