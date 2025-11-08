using Engine;
using GameMain.GameStates;
using System;

namespace GameMain
{
    public class ChristmasGame : ExtendedGame
    {
        public const string Key_StartState = "startState";
        public const string Key_NetworkingState = "networkState";

        [STAThread]
        static void Main()
        {
            ChristmasGame game = new ChristmasGame();
            game.Run();
        }

        public ChristmasGame()
        {
            GameStateManager.AddGameState(new StartState(GameStateManager), Key_StartState);
            GameStateManager.AddGameState(new NetworkingState(GameStateManager), Key_NetworkingState);
            GameStateManager.SwitchState(Key_NetworkingState);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }
    }
}
