using Engine;

namespace GameMain.GameStates;

internal class StartState : GameState
{
    public StartState(GameStateManager gameStateManager) : base(gameStateManager)
    {
        AddChild(new SpriteGameObject("UI/sprite_standard_background", 0f));
    }
}
