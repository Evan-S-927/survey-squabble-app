using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveySquabbleApp
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        //I make an instance of the game as a public variable that can be accessed
        //from anywhere within the program. I acknowledge that this is a security
        //issue for projects with larger scope, but this is a for-fun project meant
        //to help me better understand using multiple threads simultaneously and also
        //just to get in the habit of finishing personal projects.

        //The name is ungaBunga because this solves a lot of my problems with a caveman
        //level of brainpower. I will eventually advance past the stone age.
        public static Game ungaBunga;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Assigns RunGame to an instance of the Thread object, so I can
            //use 2 windows concurrently. This is so that someone can edit the
            //control dock without any of the players seeing what they're doing on
            //the main window.
            Thread thread = new Thread(RunGame);
            thread.Start();

            Application.Run(new ControlDock());
        }


        //Instantiates the public variable to the "Game" object, then runs it.
        //This is within a separate function as that is an easy way to put the
        //new window on its own thread (using the Thread object type).
        static void RunGame()
        {
            ungaBunga = new Game();
            Application.Run(ungaBunga);
        }
    }
}
