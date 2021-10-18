using System.Linq;
using SnakeLib;
using SnakeLib.Brains;
using SnakeLib.Enums;
using SnakeLib.PowerUps;

namespace TemplateBrain
{
    public class TemplateBrain : SnakeBrainBase
    {
        public override string Name => "Template Brain";

        public override string Author => "<noname>";

        public override Movement GetNextMovement(bool grow)
        {
            /* This is the method you need to implement. It is called by the framework before each step, and the Snake will move 
             * into the direction indicated by the returned Direction value.
             * 
             * The grow parameter indicates whether the snake will grow in this step or not.
             * 
             * Some of the important objects and propoerties:
             *
             *  this.Me                       - my snake
             *  this.Me[n]                    - nth point of the snake
             *  this.Me.Head                  - first point of the snake
             *  this.Me.Tail                  - last point of the snake
             *  this.Me.Size                  - length
             *  this.Me.Score                 - score
             *  this.Me.ThinkTime             - overall thinktime during a Round. Cannot exceed this.Field.ThinkTimeLimit.
             *
             *  this.Enemy                    - enemy snake, has same properties as Me
             *
             *  this.Field                    - the game area
             *  this.Field.XSize              - height of the game area
             *  this.Field.YSize              - width of the game area
             *  this.Field[x,y]               - cell in the given position
             *  this.Field[x,y].IsApple       - there is an apple on the cell
             *  this.Field[x,y].IsObstacle    - there is an obstacle on the cell
             *
             *  this.Field.Apples             - collection of apples currently in the game
             *  this.Field.Apples[n]          - nth apple
             *  this.Field.Apples[n].Age      - age of the nth apple
             *  this.Field.Apples[n].Lifetime - lifetime of the nth apple
             *  this.Field.Apples[n].Location - location of the nth apple
             *  this.Field.AppleFrequency     - how often apples are displayed
             *
             *  this.Field.PowerUps           - collection of PowerUps currently in the game
             *  this.Field.PowerUps.Any(x => x.Type == PowerType.NoWall)                                - check if there is NoWall powerup available on Field
             *  this.PowerUps.Any(x => x.Type == PowerType.NoWall && x.UsageLeft > 0)                   - check if we have available NoWall powerup
             *  this.Me.PowerUps.Any(x => x.Type == PowerType.NoWall && x.UsageLeft > 0)                - check if we have available NoWall powerup
             *
             *  new Movement { direction = Direction.Up }.ActivateDiagonalPowerUp(Direction.Right)      - example for Diagonal PowerUp usage. (passing in secondary direction)
             *  new Movement { direction = Direction.Up }.ActivateReversePowerUp()                     - example for Reverse PowerUp usage.
             *
             *  powerups are setup in arena/Simple.arena
             *
             * It is a good idea to check other properties to make the most of your snake brain!
             * 
             * Also, look at the helper methods and events (AppleAdded, AppleGone, GetHeadForDirection)
             * 
             * 
             * Publish your dll by creating a new Class Library into this solution based on TemplateBrain or simply override TemplateBrain.cs, 
             * modify AssemblyName in Class Library properties and also modify the namespace of your brain class.
             */

            // Now we look around, and move to an empty location, if there is any...
            var direction = Field[GetHeadForDirection(Direction.Right)].IsEmpty ? Direction.Right
                : (Field[GetHeadForDirection(Direction.Left)].IsEmpty ? Direction.Left
                : (Field[GetHeadForDirection(Direction.Up)].IsEmpty ? Direction.Up
                : Direction.Down));

            var movement = new Movement { Direction = direction };

            // If we have a diagonal powerup, and we are going up or down, then go diagonal!
            // This makes no sense without checking if the target is an empty cell, but acts as an example
            if (Me.PowerUps.Any(x => x.Type == PowerUpType.Diagonal && x.UsageLeft > 0) && 
                (direction == Direction.Up || direction == Direction.Down))
                movement.ActivateDiagonalPowerUp(Direction.Left);
            
            return movement;
        }
    }
}
