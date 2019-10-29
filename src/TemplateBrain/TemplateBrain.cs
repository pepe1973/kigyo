using SnakeLib;
using SnakeLib.Brains;

namespace TemplateBrain
{
    public class TemplateBrain : SnakeBrainBase
    {
        public override string Name => "Template Brain";

        public override string Author => "<noname>";

        public override Direction GetNextMovement(bool grow)
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
             * It is a good idea to check every other properties to make the most of your snake brain!
             * 
             * Also, look at the helper methods and events (AppleAdded, AppleGone, GetHeadForDirection)
             */

            // Now we look around, and move to an empty location, if there is any...
            return Field[GetHeadForDirection(Direction.Right)].IsEmpty ? Direction.Right
                : (Field[GetHeadForDirection(Direction.Left)].IsEmpty ? Direction.Left
                : (Field[GetHeadForDirection(Direction.Up)].IsEmpty ? Direction.Up
                : Direction.Down));
        }
    }
}
