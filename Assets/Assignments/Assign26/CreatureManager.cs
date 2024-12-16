using System.Collections;
using System.Collections.Generic;
using Assignment26;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {

        void Start()
        {
            List<Creature> creatures = new List<Creature> { new Kangaroo(), new Duck() };
            List<IRunnable> runnables = new List<IRunnable>();
            List<ISwimmable> swimmables = new List<ISwimmable>();
            List<IJumpable> jumpables = new List<IJumpable>();

            Kangaroo kangaroo = new Kangaroo();
            runnables.Add(kangaroo);
            jumpables.Add(kangaroo);

            Duck duck = new Duck();
            runnables.Add(duck);
            swimmables.Add(duck);

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }
            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }
            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }
            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }
        }
    }
}