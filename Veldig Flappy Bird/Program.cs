using System;
using System.Threading;
using System.Xml;
using Veldig_Flappy_Bird;

var pipes = new Pipes();
var bird = new Bird(10, 20);
var board = new Board();
var timer = 0;

Run();

void Run()
{
    int consoleWidth = 124;
    Console.SetWindowSize(board.width + 10, board.height + 10);
    var inputThread = new Thread(inputHandler);
    inputThread.Start();

    while (true)
    {
        Console.Clear();
        board.Draw();
        pipes.Draw(consoleWidth);
        bird.Draw();
        if (timer % 50 == 0) pipes.addPipe(consoleWidth);
        Thread.Sleep(100);
        pipes.gameTime++;
        timer++;
        bird.Down();

        if (pipes.CheckCollision(bird.X, bird.Y, bird.bird.Length) || board.CheckCollision(bird.X, bird.Y, bird.bird.Length))
        {
            Console.Clear();
            Console.WriteLine("Game Over!");
            Console.WriteLine($"Score: {pipes.Score}");
            break;
        }
    }
}

void inputHandler()
{
    while (true)
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(intercept:true).Key;
            if (key == ConsoleKey.Spacebar)
            {
                bird.Jump();
            }
        }
    }
}