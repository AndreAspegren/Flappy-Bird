using System;
using System.Threading;
using Veldig_Flappy_Bird;

var pipes = new Pipes();
var timer = 0;

Run();

void Run()
{
    int consoleWidth = 124;
    Console.SetWindowSize(220, 60);
    while (true)
    {
        pipes.draw(consoleWidth);
        if (timer % 5 == 0) pipes.addPipe(124);
        Thread.Sleep(500);
        pipes.gameTime++;
        timer++;
    }
}