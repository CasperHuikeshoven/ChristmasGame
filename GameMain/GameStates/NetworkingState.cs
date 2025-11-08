using Engine;
using Engine.UI;
using Microsoft.Xna.Framework;

namespace GameMain.GameStates;

public class NetworkingState : GameState
{
    private Button _serverButton;
    private Button _clientButton;

    public NetworkingState(GameStateManager gameStateManager) : base(gameStateManager)
    {
        _serverButton = new Button("UI/sprite_standard_button");
        _clientButton = new Button("UI/sprite_standard_button");

        _serverButton.Text = "Server";
        _clientButton.Text = "Client";

        _serverButton.LocalPosition = new Vector2(128, 60);
        _clientButton.LocalPosition = new Vector2(128, 100);

        AddChild(_serverButton);
        AddChild(_clientButton);

        AddChild(new SpriteGameObject("UI/sprite_standard_background", 0f));
    }

    public override void HandleInput(InputHelper inputHelper)
    {
        base.HandleInput(inputHelper);

        if (_serverButton.Pressed)
        {
            NetworkManager.AsHost();
            GameStateManager.SwitchState(ChristmasGame.Key_StartState);
        }
        else if (_clientButton.Pressed)
        {
            NetworkManager.AsClient();
            GameStateManager.SwitchState(ChristmasGame.Key_StartState);
        }
    }
}
