using Agate.MVC.Base;
using UnityEngine;

namespace ExampleGame.GameSystem.Module.ClickGame
{
    public class ClickGameModel : BaseModel, IClickGameModel
    {
        public int Food { get; private set; } = 10;
        public int Drink { get; private set; } = 10;

        public void SetFood(int food)
        {
            Food = food;
            SetDataAsDirty();
        }

        public void SetDrink(int drink)
        {
            Drink = drink;
            SetDataAsDirty();
        }

        public void SubstractFood()
        {
            if (Food > 0)
            {
                Food--;
                SetDataAsDirty();
            }
            else
            {
                Debug.Log("Food is not available.");
            }
        }

        public void SubstractDrink()
        {
            if (Drink > 0)
            {
                Drink--;
                SetDataAsDirty();
            }
            else
            {
                Debug.Log("Drink is not available.");
            }

        }
    }

}