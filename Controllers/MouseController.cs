using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     class MouseController: IController, IUpdateable
    {
    private List<(Rectangle, ICommand, int)> actions;

    public MouseController()
    {
        actions = new List<(Rectangle, ICommand, int)>();
    }
    public void RegisterCommand(Rectangle rect, ICommand command, int button)
    {
        actions.Add((rect, command, button));
    }

    public void Update()
    {
        var mouseState = Mouse.GetState();
        foreach (var action in actions)
        {
            // left mouse click if int is 0
            if (action.Item3 == 0)
            {
                if (action.Item1.Contains(mouseState.Position) && (mouseState.LeftButton == ButtonState.Pressed))
                {
                    action.Item2.Execute();
                }
            } 
            // right mouse click is 1
            if (action.Item3 == 1)
            {
                if (action.Item1.Contains(mouseState.Position) && (mouseState.RightButton == ButtonState.Pressed))
                {
                    action.Item2.Execute();
                }
            }
        }
    }
    }

